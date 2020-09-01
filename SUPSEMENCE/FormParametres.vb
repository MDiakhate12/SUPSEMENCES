Imports System.IO
Imports MySql.Data.MySqlClient

Public Class FormParametres
    Private connection As MySqlConnection = DBConnection.connection
    Private currentLocalisationId As Integer
    Private CurrentNiveauxCheckedList As CheckedListBox = New CheckedListBox()

    Private Sub FormParametres_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'SemencesDataSet.niveau_de_production'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.Niveau_de_productionTableAdapter.Fill(Me.SemencesDataSet.niveau_de_production)
        Me.Zone_agro_ecologiqueTableAdapter.Fill(Me.SemencesDataSet.zone_agro_ecologique)
        Me.LocalisationTableAdapter.Fill(Me.SemencesDataSet.localisation)
        Me.MagasinTableAdapter.Fill(Me.SemencesDataSet.magasin)
        Me.SpeculationTableAdapter.Fill(Me.SemencesDataSet.speculation)

        LoadSpeculation()
        LoadVariete()
        LoadZone()
        FillChoixRegion(RegionBindingSource, RegionZone, RegionZone, CommuneZone, Zone)
        FillChoixCommune(CommuneBindingSource, CommuneZone, RegionZone, CommuneZone, Zone)
        FillChoixLocalite(LocaliteBindingSource, LocaliteZone, RegionZone, CommuneZone, Zone)
        FillChoixLocaliteMagasin()
        LoadMagasin()
        FillNiveaux()
        FillChoixVariete()
        FillContact()
        FIllInstitutionForm()

        DataVarieteInstitution.Columns("id_variete").Visible = False

    End Sub


    Private Function GetIdSpeculationInstitution(id_institution, id_variete)
        Dim query = "select id_speculation_institution 
                     from variete
                     inner join speculation on speculation.id_speculation=variete.id_speculation
                     inner join speculation_institution on speculation_institution.id_speculation=variete.id_speculation
                     where (id_variete=@id_variete and id_institution=@id_institution)"

        Dim command = New MySqlCommand(query, connection)
        command.Parameters.AddWithValue("@id_institution", id_institution)
        command.Parameters.AddWithValue("@id_variete", id_variete)
        Dim reader = command.ExecuteReader()
        Dim id As Integer
        While reader.Read()
            id = reader.GetInt16("id_speculation_institution")
        End While
        reader.Close()
        Return id
    End Function
    Private Sub OpenImage(Image, Dialog)
        With Dialog
            .Filter = ("Images | *.jpg; *.png; *.jpeg *.bmp; *.ico; *.gif;")
        End With
        Dialog.FileName = ""
        If (Dialog.ShowDialog() = DialogResult.OK) Then
            Image.Image = Image.FromFile(Dialog.FileName)
            MessageBox.Show(Dialog.FileName)
        End If
    End Sub

    Public Sub FillChoixVariete()
        Dim queryGetInstitutionVariete = "select nom_variete, id_variete, nom_speculation, s.id_speculation from variete
                                          inner join speculation_institution si on variete.id_speculation=si.id_speculation
                                          inner join speculation s on s.id_speculation=si.id_speculation
                                          where si.id_institution=@id_institution"

        Dim commandGetInstitutionVariete = New MySqlCommand(queryGetInstitutionVariete, connection)
        commandGetInstitutionVariete.Parameters.AddWithValue("@id_institution", DBConnection.id_institution)

        Dim varieteInstitutionAdapter = New MySqlDataAdapter(commandGetInstitutionVariete)

        Dim varieteInstitutionTable = New DataTable()
        varieteInstitutionAdapter.Fill(varieteInstitutionTable)

        VarieteBindingSource.DataSource = varieteInstitutionTable

        NomVariete.ValueMember = varieteInstitutionTable.Columns("id_variete").ToString()
        NomVariete.DisplayMember = varieteInstitutionTable.Columns("nom_variete").ToString()

        NomSpeculationVariete.ValueMember = varieteInstitutionTable.Columns("id_speculation").ToString()
        NomSpeculationVariete.DisplayMember = varieteInstitutionTable.Columns("nom_speculation").ToString()
    End Sub

    Private Sub SaveVariete(id_institution As Integer, id_variete As Integer, stock_de_securite As Integer)
        Dim id_speculation_institution = GetIdSpeculationInstitution(id_institution, id_variete)

        Dim queryNewInstitutionVariete = "insert into variete_institution(id_institution, id_variete, stock_de_securite, id_speculation_institution) 
                                          values(@id_institution, @id_variete, @stock_de_securite, @id_speculation_institution)"

        Try
            Dim commandNewInstitutionVariete = New MySqlCommand(queryNewInstitutionVariete, connection)

            commandNewInstitutionVariete.Parameters.AddWithValue("@id_institution", id_institution)
            commandNewInstitutionVariete.Parameters.AddWithValue("@id_variete", id_variete)
            commandNewInstitutionVariete.Parameters.AddWithValue("@stock_de_securite", stock_de_securite)
            commandNewInstitutionVariete.Parameters.AddWithValue("@id_speculation_institution", id_speculation_institution)
            Dim resultCount = commandNewInstitutionVariete.ExecuteNonQuery()
            LoadVariete()
            MessageBox.Show("Ajoutée avec succés!", "Nouvelle variété")
        Catch ex As MySqlException
            MessageBox.Show("Cette variété existe déjà chez nous.", "Variété déjà ajoutée")
        End Try

    End Sub

    Private Sub LoadVariete()
        Dim queryGetInstitutionVariete = "SELECT variete_institution.id_variete, nom_variete, nom_speculation, longueur_cycle, nom_zone, stock_de_securite
                                            FROM variete_institution
                                                inner join variete on variete.id_variete=variete_institution.id_variete
                                                inner join zone_agro_ecologique on zone_agro_ecologique.id_zone=variete.id_zone
                                                inner join speculation_institution on speculation_institution.id_speculation_institution=variete_institution.id_speculation_institution
                                                inner join speculation on speculation.id_speculation=speculation_institution.id_speculation
                                                where variete_institution.id_institution=@id_institution"

        Dim commandGetInstitutionVariete = New MySqlCommand(queryGetInstitutionVariete, connection)
        commandGetInstitutionVariete.Parameters.AddWithValue("@id_institution", DBConnection.id_institution)

        Dim varieteInstitutionAdapter = New MySqlDataAdapter(commandGetInstitutionVariete)

        Dim varieteInstitutionTable = New DataTable()
        varieteInstitutionAdapter.Fill(varieteInstitutionTable)

        DataVarieteInstitution.DataSource = varieteInstitutionTable
    End Sub


    Private Sub SaveSpeculation(id_institution As Integer, id_speculation As Integer)
        Dim queryNewInstitutionSpeculation = "insert into speculation_institution(id_institution, id_speculation) values(@id_institution, @id_speculation)"

        Try
            Dim commandNewInstitutionSpeculation = New MySqlCommand(queryNewInstitutionSpeculation, connection)

            commandNewInstitutionSpeculation.Parameters.AddWithValue("@id_institution", id_institution)
            commandNewInstitutionSpeculation.Parameters.AddWithValue("@id_speculation", id_speculation)
            commandNewInstitutionSpeculation.ExecuteNonQuery()
            LoadSpeculation(id_speculation)
            MessageBox.Show("Ajoutée avec succés!", "Nouvelle spéculation", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As MySqlException
            MessageBox.Show("Cette speculation existe déjà chez nous.", "Spéculation déjà ajoutée", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub LoadSpeculation(Optional last_inserted_id = Nothing)
        Dim getSpeculation = "select nom_speculation
                                        from speculation_institution
                                        inner join speculation on speculation.id_speculation=speculation_institution.id_speculation
                                        where speculation_institution.id_institution=@id_institution"

        If last_inserted_id IsNot Nothing Then
            getSpeculation += " and speculation_institution.id_speculation=@last_inserted_id"
        End If

        Dim commandSpeculation = New MySqlCommand(getSpeculation, connection)
        commandSpeculation.Parameters.AddWithValue("@id_institution", DBConnection.id_institution)

        If last_inserted_id IsNot Nothing Then
            commandSpeculation.Parameters.AddWithValue("@last_inserted_id", last_inserted_id)
        End If

        Dim reader = commandSpeculation.ExecuteReader()

        While reader.Read()
            Dim label = reader.GetString(0)
            'Dim quantite = reader.GetUInt16(1)
            Dim image = System.Drawing.Image.FromFile($"{DBConnection.imagePath}semences\{label}.jpg")

            AddCard(image, label)
        End While

        reader.Close()

    End Sub
    Private Sub AddCard(image As Drawing.Image, label As String, Optional quantite As String = "")
        Dim card = New FormStockCard()

        With card
            .Image.Image = image
            .Image.Dock = DockStyle.Fill
            .Label.Text = label
            .Label.Font = New Font("Stencil", 18)

            .Quantite.Text = ""
            .TopLevel = False
            .Size = New Size(125, 125)
            .LabelStockDeSecurite.Text = ""
            .LabelStockDeSecurite.Visible = False
            .Quantite.Visible = False
            .Panel4.Height = 45
            .Dock = DockStyle.Bottom
        End With
        SpeculationFlowLayout.Controls.Add(card)
        card.BringToFront()
        card.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If NomVariete.SelectedValue IsNot Nothing And StockDeSecurite.Value <> 0 Then
            SaveVariete(id_institution:=DBConnection.id_institution, id_variete:=NomVariete.SelectedValue, stock_de_securite:=StockDeSecurite.Value)
        Else
            MessageBox.Show("Veuillez entrer des données correctes svp.", "Données invalides")
            Return
        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If NomSpeculation.SelectedValue IsNot Nothing Then
            SaveSpeculation(id_institution:=DBConnection.id_institution, id_speculation:=NomSpeculation.SelectedValue)
        Else
            MessageBox.Show("Veuillez entrer des données correctes svp.", "Données invalides")
            Return
        End If
    End Sub


    Private Sub RechercheVariete_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RechercheVariete.GotFocus
        If RechercheVariete.Text = "Rechercher" Then
            RechercheVariete.Text = ""
        End If
    End Sub

    Private Sub RechercheVariete_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RechercheVariete.LostFocus
        If RechercheVariete.Text = "" Then
            RechercheVariete.Text = "Rechercher"
        Else
            ClearRechercher.Visible = True
        End If
    End Sub

    Private Sub RechercheVariete_TextChanged(sender As Object, e As EventArgs) Handles RechercheVariete.TextChanged
        If RechercheVariete.Text = "Rechercher" Or RechercheVariete.Text = "" Then
            Return
        End If

        Dim queryField As String = "nom_variete"
        If ChoixRechercheVariete.SelectedItem = "Variété" Then
            queryField = "nom_variete"
        ElseIf ChoixRechercheVariete.SelectedItem = "Spéculation" Then
            queryField = "nom_speculation"
        ElseIf ChoixRechercheVariete.SelectedItem = "Zone" Then
            queryField = "nom_zone"
        ElseIf ChoixRechercheVariete.SelectedItem = "Cycle" Then
            queryField = "longueur_cycle"
        ElseIf ChoixRechercheVariete.SelectedItem = "Stock de sécurité" Then
            queryField = "stock_de_securite"
        End If

        Dim queryValue = RechercheVariete.Text
        RechercherVariete(queryValue, queryField)
    End Sub

    Private Sub RechercherVariete(queryValue, queryField)

        Dim query As String = $"SELECT variete.id_variete, nom_variete, nom_speculation, longueur_cycle, nom_zone, stock_de_securite
                                FROM variete_institution
                                inner join variete on variete.id_variete=variete_institution.id_variete
                                inner join zone_agro_ecologique on zone_agro_ecologique.id_zone=variete.id_zone
                                inner join speculation on speculation.id_speculation=variete.id_speculation
                                where (id_institution=@id_institution and
                                      {queryField} like '%{queryValue}%')"

        Rechercher(query, DataVarieteInstitution)
    End Sub


    Private Sub Rechercher(query, table)
        Dim command = New MySqlCommand(query, connection)
        Dim queryAdapter = New MySqlDataAdapter(command)
        Dim queryTable = New DataTable()

        command.Parameters.AddWithValue("@id_institution", DBConnection.id_institution)
        queryAdapter.FillAsync(queryTable)

        table.DataSource = queryTable
        If queryTable.Rows.Count > 0 Then
            table.Rows(0).Selected = True
        End If
    End Sub



    Private Sub EnregistrerMagasin_Click(sender As Object, e As EventArgs)
        SaveMagasin()
    End Sub
    Private Sub SaveMagasin()
        Dim queryNewInstitutionVariete = "insert into magasin(nom_magasin, id_institution, id_localisation) values(@nom_magasin, @id_institution, @id_localisation)"

        Try
            Dim commandNewInstitutionVariete = New MySqlCommand(queryNewInstitutionVariete, connection)

            commandNewInstitutionVariete.Parameters.AddWithValue("@id_institution", DBConnection.id_institution)
            commandNewInstitutionVariete.Parameters.AddWithValue("@id_localisation", LocaliteMagasin.SelectedValue)
            commandNewInstitutionVariete.Parameters.AddWithValue("@nom_magasin", NomMagasin.Text)
            Dim resultCount = commandNewInstitutionVariete.ExecuteNonQuery()
            LoadVariete()
            MessageBox.Show("Ajouté avec succés!", "Nouveau magasin")
        Catch ex As MySqlException
            MessageBox.Show("Ce existe déjà chez nous.", "Magasin déjà ajoutée")
        End Try
    End Sub

    Private Sub ClearRechercher_Click(sender As Object, e As EventArgs) Handles ClearRechercher.Click
        If Not RechercheVariete.Text.Equals("") Then
            RechercheVariete.Clear()
        End If
    End Sub

    Private Sub LoadZone()
        Dim queryGetInstitutionVariete = "select nom_zone, region, departement, commune, village from zone_institution
                                            inner join localisation on localisation.id_localisation=zone_institution.id_localisation
                                            inner join zone_agro_ecologique on zone_agro_ecologique.id_zone=localisation.id_zone
                                            where zone_institution.id_institution=@id_institution"

        Dim commandGetInstitutionVariete = New MySqlCommand(queryGetInstitutionVariete, connection)
        commandGetInstitutionVariete.Parameters.AddWithValue("@id_institution", DBConnection.id_institution)

        Dim varieteInstitutionAdapter = New MySqlDataAdapter(commandGetInstitutionVariete)

        Dim varieteInstitutionTable = New DataTable()
        varieteInstitutionAdapter.Fill(varieteInstitutionTable)

        DataZones.DataSource = varieteInstitutionTable
    End Sub

    Private Sub Zone_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Zone.SelectedIndexChanged
        FillChoixRegion(RegionBindingSource, RegionZone, RegionZone, CommuneZone, Zone)
        FillChoixCommune(CommuneBindingSource, CommuneZone, RegionZone, CommuneZone, Zone)
        FillChoixLocalite(LocaliteBindingSource, LocaliteZone, RegionZone, CommuneZone, Zone)
    End Sub

    Private Sub FillChoixRegion(BindingSource As BindingSource, NextControl As ComboBox, RegionControl As ComboBox, CommuneControl As ComboBox, Optional ZoneControl As ComboBox = Nothing)
        Dim query = "select distinct region from localisation"
        If NextControl.Name.Contains("Zone") Then
            query = "select distinct region from localisation where id_zone=@id_zone"
        End If
        FillChoix(query:=query,
                   BindingSourceControl:=BindingSource,
                   NextChoixControl:=NextControl,
                   valueCol:="region",
                   displayCol:="region",
                 ZoneControl:=ZoneControl,
                  RegionControl:=RegionControl,
                  CommuneControl:=CommuneControl)
    End Sub

    Private Sub Region_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RegionZone.SelectedIndexChanged
        FillChoixCommune(CommuneBindingSource, CommuneZone, RegionZone, CommuneZone, Zone)
    End Sub

    Private Sub FillChoixCommune(BindingSource As BindingSource, NextControl As ComboBox, RegionControl As ComboBox, CommuneControl As ComboBox, Optional ZoneControl As ComboBox = Nothing)
        Dim query = $"select distinct commune from localisation where region=@region"
        If NextControl.Name.Contains("Zone") Then
            query = $"select distinct commune from localisation where id_zone=@id_zone and region=@region"
        End If
        FillChoix(query:=query,
                  BindingSourceControl:=BindingSource,
                  NextChoixControl:=NextControl,
                  valueCol:="commune",
                  displayCol:="commune",
                 ZoneControl:=ZoneControl,
                  RegionControl:=RegionControl,
                  CommuneControl:=CommuneControl)
    End Sub

    Private Sub CommuneZone_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CommuneZone.SelectedIndexChanged
        FillChoixLocalite(LocaliteBindingSource, LocaliteZone, RegionZone, CommuneZone, Zone)
    End Sub

    Private Sub FillChoixLocalite(BindingSource As BindingSource, NextControl As ComboBox, RegionControl As ComboBox, CommuneControl As ComboBox, Optional ZoneControl As ComboBox = Nothing)
        Dim query = $"select village from localisation where (region=@region and commune=@commune)"
        If NextControl.Name.Contains("Zone") Then
            query = $"select village from localisation where (id_zone=@id_zone and region=@region and commune=@commune)"
        End If
        FillChoix(query:=query,
                  BindingSourceControl:=BindingSource,
                  NextChoixControl:=NextControl,
                  valueCol:="village",
                  displayCol:="village",
                  ZoneControl:=ZoneControl,
                  RegionControl:=RegionControl,
                  CommuneControl:=CommuneControl)

    End Sub

    Private Sub FillChoix(query, BindingSourceControl, NextChoixControl, valueCol, displayCol, RegionControl, CommuneControl, Optional ZoneControl = Nothing)

        Dim command = New MySqlCommand(query, connection)

        If NextChoixControl.Name.Contains("Zone") And Zone IsNot Nothing Then
            command.Parameters.AddWithValue("@id_zone", Zone.SelectedValue)
        End If

        command.Parameters.AddWithValue("@region", RegionControl.SelectedValue)
        command.Parameters.AddWithValue("@commune", CommuneControl.SelectedValue)

        Dim adapter = New MySqlDataAdapter(command)
        Dim dataTable = New DataTable()
        adapter.Fill(dataTable)

        BindingSourceControl.DataSource = dataTable

        NextChoixControl.ValueMember = dataTable.Columns(valueCol).ToString()
        NextChoixControl.DisplayMember = dataTable.Columns(displayCol).ToString()
    End Sub


    Private Sub AjouterContact_Click(sender As Object, e As EventArgs) Handles AjouterContact.Click
        AddNewContact()
    End Sub

    Private Sub AddNewContact(Optional Prenom = "", Optional Nom = "", Optional Client = "", Optional Telephone = "")
        Dim ContactForm = New FormContact()
        If Prenom IsNot String.Empty Or Nom IsNot String.Empty Or Telephone IsNot String.Empty Then
            ContactForm.Prenom.Text = Prenom
            ContactForm.Nom.Text = Nom
            ContactForm.Telephone.Text = Telephone
        End If

        ContactForm.Label6.Visible = False
        ContactForm.Client.Visible = False

        Dim result = ContactForm.ShowDialog()

        If result = DialogResult.OK Then
            'MessageBox.Show(ContactForm.Nom.Text & Environment.NewLine & "
            '" & ContactForm.Prenom.Text & Environment.NewLine & "
            '" & ContactForm.Telephone.Text & Environment.NewLine & "
            '" & ContactForm.Mail.Text & Environment.NewLine & "
            '" & ContactForm.Localisation.SelectedValue & Environment.NewLine & "
            '" & ContactForm.Client.SelectedValue)

            Dim newContact = "insert into contact(nom,prenom,telephone,email,id_localisation, id_institution)
                            values(@nom,@prenom,@telephone,@email,@id_localisation, @id_institution)"

            Dim command = New MySqlCommand(newContact, connection)

            command.Parameters.AddWithValue("@nom", ContactForm.Nom.Text)
            command.Parameters.AddWithValue("@prenom", ContactForm.Prenom.Text)
            command.Parameters.AddWithValue("@telephone", ContactForm.Telephone.Text)
            command.Parameters.AddWithValue("@email", ContactForm.Mail.Text)
            command.Parameters.AddWithValue("@id_localisation", ContactForm.Localisation.SelectedValue)
            command.Parameters.AddWithValue("@id_institution", DBConnection.id_institution)

            command.ExecuteNonQuery()

            FillContact()

            MessageBox.Show("Ajouté avec succés!", "Nouveau contact", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Enregistrer_Click(sender As Object, e As EventArgs) Handles Enregistrer.Click
        Dim result = MessageBox.Show("Confirmer ?", "Nouvelle zone de culture", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Try
                Dim id_localisation = GetIdLocalisation(RegionZone, CommuneZone, LocaliteZone, Zone)

                Dim insertZone = "insert into zone_institution(id_institution, id_localisation) values(@id_institution, @id_localisation)"
                Dim insertCommand = New MySqlCommand(insertZone, connection)


                insertCommand.Parameters.AddWithValue("@id_institution", DBConnection.id_institution)
                insertCommand.Parameters.AddWithValue("@id_localisation", id_localisation)

                insertCommand.ExecuteNonQuery()

                LoadZone()
            Catch ex As MySqlException
                MessageBox.Show("Cette zone existe déjà chez nous.", "Zone déjà ajoutée", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End If
    End Sub

    Private Function GetIdLocalisation(Region, Commune, Localite, Optional Zone = Nothing, Optional fromInstitution = False) As Integer
        Dim result As Integer
        If fromInstitution = True Then
            Dim query = "select id_localisation from institution where id_institution=@id_institution"
            Dim command = New MySqlCommand(query, connection)
            command.Parameters.AddWithValue("@id_institution", DBConnection.id_institution)
            result = Integer.Parse(command.ExecuteScalar())
        Else
            Dim query = "select id_localisation from localisation where (region=@region and commune=@commune and village=@village)"

            Dim command = New MySqlCommand(query, connection)
            If Zone IsNot Nothing Then
                query = "select id_localisation from localisation where (id_zone=@id_zone and region=@region and commune=@commune and village=@village)"
                command.Parameters.AddWithValue("@id_zone", Zone.SelectedValue)
            End If
            command.Parameters.AddWithValue("@region", Region.SelectedValue)
            command.Parameters.AddWithValue("@commune", Commune.SelectedValue)
            command.Parameters.AddWithValue("@village", Localite.SelectedValue)
            result = Integer.Parse(command.ExecuteScalar())
        End If

        Return result

    End Function

    Private Sub FillChoixLocaliteMagasin()
        Dim query = "Select zone_institution.id_localisation, village, region  from zone_institution
                     inner join localisation on localisation.id_localisation=zone_institution.id_localisation
                     inner join zone_agro_ecologique on zone_agro_ecologique.id_zone=localisation.id_zone
                     where zone_institution.id_institution=@id_institution"

        FillLocalite(query:=query,
                  BindingSourceControl:=LocaliteMagasinBindingSource,
                  ChoixControl:=LocaliteMagasin,
                  valueCol:="id_localisation",
                  displayCol:="village")
    End Sub

    Private Sub FillLocalite(query, BindingSourceControl, ChoixControl, valueCol, displayCol)

        Dim command = New MySqlCommand(query, connection)
        command.Parameters.AddWithValue("@id_institution", DBConnection.id_institution)


        Dim adapter = New MySqlDataAdapter(command)
        Dim dataTable = New DataTable()
        adapter.Fill(dataTable)

        BindingSourceControl.DataSource = dataTable

        ChoixControl.ValueMember = dataTable.Columns(valueCol).ToString()
        ChoixControl.DisplayMember = dataTable.Columns(displayCol).ToString()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If NomMagasin.Text IsNot String.Empty Then
            Dim result = MessageBox.Show("Confirmer ?", "Nouvelle zone de culture", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                'Try
                Dim query = "insert into magasin(nom_magasin, id_institution, id_localisation) values(@nom_magasin, @id_institution, @id_localisation)"
                Dim command = New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@nom_magasin", NomMagasin.Text)
                command.Parameters.AddWithValue("@id_institution", DBConnection.id_institution)
                command.Parameters.AddWithValue("@id_localisation", LocaliteMagasin.SelectedValue)


                Dim adapter = New MySqlDataAdapter(command)
                Dim dataTable = New DataTable()
                adapter.Fill(dataTable)

                command.ExecuteNonQuery()
                LoadMagasin()

                MessageBox.Show("Ajouté avec succés.", "Nouveau magasin", MessageBoxButtons.OK, MessageBoxIcon.Information)


                'Catch ex As MySqlException
                '    MessageBox.Show("Ce magasin existe déjà chez nous.", "Magasin déjà ajouté", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                'End Try
            End If
        Else
            MessageBox.Show("Veuillez remplir tous les champs svp", "Formulaire invalide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If


    End Sub

    Private Sub LoadMagasin()
        Dim query = "SELECT nom_magasin, region, commune, village
                                                FROM magasin
                                                inner join localisation on localisation.id_localisation=magasin.id_localisation
                                                where id_institution=@id_institution"

        Dim command = New MySqlCommand(query, connection)
        command.Parameters.AddWithValue("@id_institution", DBConnection.id_institution)

        Dim adapter = New MySqlDataAdapter(command)

        Dim dataTable = New DataTable()
        adapter.FillAsync(dataTable)

        DataMagasin.DataSource = dataTable
    End Sub

    Private Sub EnregistrerInstitution_Click(sender As Object, e As EventArgs) Handles EnregistrerInstitution.Click

        If TextBox1.Text IsNot String.Empty Or
            TextBox2.Text IsNot String.Empty Or
            RegionInstitution.Text IsNot String.Empty Or
            CommuneIntitution.Text IsNot String.Empty Or
            LocaliteInstitution.Text IsNot String.Empty Then

            Dim id_localisation = GetIdLocalisation(RegionInstitution, CommuneIntitution, LocaliteInstitution)

            Dim result = MessageBox.Show("Confirmer ?", "Ajouter/Modifier Institution", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Dim query = "update institution 
                             set nom_complet=@nom_complet, sigle=@sigle, id_localisation=@id_localisation
                             where id_institution=@id_institution"

                Dim command = New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@id_institution", DBConnection.id_institution)
                command.Parameters.AddWithValue("@nom_complet", TextBox1.Text)
                command.Parameters.AddWithValue("@sigle", TextBox2.Text)
                command.Parameters.AddWithValue("@id_localisation", id_localisation)

                command.ExecuteNonQuery()
            End If
        Else
            MessageBox.Show("Veuillez remplir tous les champs svp", "Formulaire invalide", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub
    Private Sub FillNiveaux()
        Dim query = "select nom_niveau 
                     from niveau_institution 
                     inner join niveau_de_production n on n.id_niveau=niveau_institution.id_niveau 
                     where id_institution=@id_institution"

        Dim command = New MySqlCommand(query, connection)
        command.Parameters.AddWithValue("@id_institution", DBConnection.id_institution)
        Dim reader = command.ExecuteReader()
        Dim nom_niveau As String
        Dim checkbox As CheckBox
        While reader.Read()
            nom_niveau = reader.GetString("nom_niveau")
            checkbox = GroupBox1.Controls.Item(nom_niveau)
            checkbox.Checked = True
            checkbox.Enabled = False
        End While
        reader.Close()

        'query = "select nom_niveau 
        '             from niveau_de_production"

        'FillCheckedList(
        '    query:=query,
        '    checkedList:=NiveauxCheckedList,
        '    currentCheckedList:=CurrentNiveauxCheckedList,
        '    columnName:="nom_niveau"
        '    )
    End Sub
    Private Sub FillCheckedList(query As String, checkedList As CheckedListBox, currentCheckedList As CheckedListBox, Optional columnName As String = "nom_variete", Optional defaultState As Boolean = False)

        If connection.State = ConnectionState.Closed Then
            Return
        End If

        Dim command = New MySqlCommand(query, connection)

        command.Parameters.AddWithValue("@id_institution", DBConnection.id_institution)

        Dim reader = command.ExecuteReader()

        checkedList.Items.Clear()
        currentCheckedList.Items.Clear()

        While reader.Read()
            checkedList.Items.Add(reader.GetString(columnName), defaultState)
            currentCheckedList.Items.Add(reader.GetString(columnName), defaultState)
        End While

        reader.Close()

    End Sub

    Private Sub EnregistrerNiveaux_Click(sender As Object, e As EventArgs) Handles EnregistrerNiveaux.Click
        Dim items = ""
        For Each checkBox As CheckBox In GroupBox1.Controls
            If checkBox.Checked Then
                items = $"{items} {Environment.NewLine} ({GroupBox1.Controls.IndexOf(checkBox)}, {DBConnection.id_institution}),"
            End If
        Next
        items = items.Substring(0, items.Length - 1)
        Dim query = $"insert into niveau_institution(id_niveau, id_institution) values {items} on duplicate key update id_niveau=id_niveau"
        Dim command = New MySqlCommand(query, connection)
        command.ExecuteNonQuery()
        MessageBox.Show("Ajoutés avec succés.", "Niveaux de semence", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub FillContact()
        Dim query = "select prenom, nom, telephone, email 
                     from contact 
                     where id_institution=@id_institution 
                     "
        Dim command = New MySqlCommand(query, connection)

        command.Parameters.AddWithValue("@id_institution", DBConnection.id_institution)

        Dim adapter = New MySqlDataAdapter(command)
        Dim dataTable = New DataTable()
        adapter.Fill(dataTable)

        DataContactInstitution.DataSource = dataTable
    End Sub

    Private Sub FIllInstitutionForm()
        FillNomStructure()
        FillChoixRegion(RegionInstitutionBindingSource, RegionInstitution, RegionInstitution, CommuneIntitution)

        Dim id_localisation = GetIdLocalisation(RegionInstitution, CommuneIntitution, LocaliteInstitution, fromInstitution:=True)
        Dim query = "select distinct region from localisation where id_localisation=@id_localisation"
        Dim command = New MySqlCommand(query, connection)
        command.Parameters.AddWithValue("@id_localisation", id_localisation)
        Dim reader = command.ExecuteReader()
        Dim region As String = ""
        While reader.Read()
            region = reader.GetString("region")
        End While
        reader.Close()
        RegionInstitution.SelectedValue = region

        FillChoixCommune(CommuneInstitutionBindingSource, CommuneIntitution, RegionInstitution, CommuneIntitution)
        FillChoixLocalite(LocaliteInstitutionBindingSource, LocaliteInstitution, RegionInstitution, CommuneIntitution)
    End Sub

    Private Sub FillNomStructure()
        Dim query = "select nom_complet, sigle, id_localisation 
                     from institution 
                     where id_institution=@id_institution
                     "
        Dim command = New MySqlCommand(query, connection)

        command.Parameters.AddWithValue("@id_institution", DBConnection.id_institution)

        Dim reader = command.ExecuteReader()
        While reader.Read()
            TextBox1.Text = reader.GetString("nom_complet")

            TextBox2.Text = reader.GetString("sigle")
        End While
        reader.Close()
    End Sub

    Private Sub RegionInstitution_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RegionInstitution.SelectedIndexChanged
        FillChoixCommune(CommuneInstitutionBindingSource, CommuneIntitution, RegionInstitution, CommuneIntitution)
        FillChoixLocalite(LocaliteInstitutionBindingSource, LocaliteInstitution, RegionInstitution, CommuneIntitution)
    End Sub

    Private Sub CommuneIntitution_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CommuneIntitution.SelectedIndexChanged
        FillChoixLocalite(LocaliteInstitutionBindingSource, LocaliteInstitution, RegionInstitution, CommuneIntitution)
    End Sub

    'Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
    '    Dim items As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer)()


    '    Dim query = "select id_niveau, nom_niveau 
    '                 from niveau_de_production
    '                 where ()"

    '    query = InsertFilter(query, NiveauxCheckedList, "nom_niveau")
    '    MessageBox.Show(query)
    '    Dim command = New MySqlCommand(query, connection)
    '    'command.Parameters.AddWithValue("@id_institution", DBConnection.id_institution)
    '    Dim reader = command.ExecuteReader()

    '    While reader.Read()
    '        items.Add(reader.GetString("nom_niveau"), reader.GetUInt64("id_niveau"))
    '    End While
    '    reader.Close()

    '    query = "delete from niveau_institution;
    '                 insert into niveau_institution(id_niveau, nom_niveau, id_institution) values "

    '    query = InsertValuesFilter(query, items, DBConnection.id_institution)
    '    MessageBox.Show(query)
    '    command = New MySqlCommand(query, connection)
    '    command.Parameters.AddWithValue("@id_institution", DBConnection.id_institution)
    '    command.ExecuteNonQuery()
    'End Sub
    'Private Function InsertFilter(query As String, CurrentCheckedList As CheckedListBox, columnName As String)
    '    Return query.Insert(query.LastIndexOf(")"), $" {columnName} in ({GetCheckedValues(CurrentCheckedList)}) ")
    'End Function

    'Private Function InsertValuesFilter(query As String, items As Dictionary(Of String, Integer), id_institution As Integer)
    '    For Each item In items
    '        query = query.Insert(query.LastIndexOf(" "), $" ('{item.Key}', {item.Value}, {id_institution}), ")
    '    Next
    '    Return query.Substring(0, query.LastIndexOf(","))
    'End Function
    'Private Function GetCheckedValues(checkedList As CheckedListBox)
    '    Dim values = ""
    '    Dim items = checkedList.CheckedItems

    '    If items.Count > 0 Then
    '        For Each item In items
    '            values = $"{values}, '{item}'"
    '        Next
    '    End If
    '    Return values.Substring(2)
    'End Function
    'Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    'End Sub

    'Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
    '    Dim split = TextBox1.Text.Split(" ")
    '    Dim sigle = ""
    '    For Each word In split
    '        If word.ToLower().Equals("de") Or
    '           word.ToLower().Equals("de") Or
    '           word.ToLower().Equals("du") Or
    '           word.ToLower().Equals("le") Or
    '           word.ToLower().Equals("la") Or
    '           word.ToLower().Equals("l'") Then
    '            Continue For
    '        Else
    '            MessageBox.Show(word.Substring(0, 1))
    '        End If

    '        'sigle = $"{sigle}{word.Substring(0, 1).ToUpper()}"
    '    Next
    '    TextBox2.Text = sigle
    'End Sub
End Class
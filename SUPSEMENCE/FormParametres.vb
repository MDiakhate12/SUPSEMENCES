Imports System.IO
Imports MySql.Data.MySqlClient

Public Class FormParametres
    Private connection As MySqlConnection = DBConnection.connection
    Private currentLocalisationId As Integer

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
        FillChoixRegion()
        FillChoixCommune()
        FillChoixLocalite()
        FillChoixLocaliteMagasin()
        LoadMagasin()
        FillChoixLocaliteInstitution()
        FillNiveaux()
        FillChoixVariete()

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
        If RechercheVariete.Text = "Rechercher" Then
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

        Dim query As String = $"SELECT id_variete, nom_variete, nom_speculation, longueur_cycle, nom_zone, stock_de_securite
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
        Dim queryGetInstitutionVariete = "select nom_zone, region, departement, commune, village, longitude, latitude from zone_institution
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
        FillChoixRegion()
        FillChoixCommune()
        FillChoixLocalite()
    End Sub

    Private Sub FillChoixRegion()
        Dim query = "select distinct region from localisation where id_zone=@id_zone"
        FillChoix(query:=query,
                   BindingSourceControl:=RegionBindingSource,
                   NextChoixControl:=RegionZone,
                   valueCol:="region",
                   displayCol:="region")
    End Sub

    Private Sub Region_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RegionZone.SelectedIndexChanged
        FillChoixCommune()
    End Sub

    Private Sub FillChoixCommune()
        Dim query = $"select distinct commune from localisation where id_zone=@id_zone and region=@region"
        FillChoix(query:=query,
                  BindingSourceControl:=CommuneBindingSource,
                  NextChoixControl:=CommuneZone,
                  valueCol:="commune",
                  displayCol:="commune")
    End Sub

    Private Sub CommuneZone_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CommuneZone.SelectedIndexChanged
        FillChoixLocalite()
    End Sub

    Private Sub FillChoixLocalite()
        Dim query = $"select village from localisation where (id_zone=@id_zone and region=@region and commune=@commune)"
        FillChoix(query:=query,
                  BindingSourceControl:=LocaliteBindingSource,
                  NextChoixControl:=LocaliteZone,
                  valueCol:="village",
                  displayCol:="village")

    End Sub

    Private Sub FillChoix(query, BindingSourceControl, NextChoixControl, valueCol, displayCol)

        Dim command = New MySqlCommand(query, connection)

        command.Parameters.AddWithValue("@id_zone", Zone.SelectedValue)
        command.Parameters.AddWithValue("@region", RegionZone.SelectedValue)
        command.Parameters.AddWithValue("@commune", CommuneZone.SelectedValue)

        Dim adapter = New MySqlDataAdapter(command)
        Dim dataTable = New DataTable()
        adapter.Fill(dataTable)

        BindingSourceControl.DataSource = dataTable

        NextChoixControl.ValueMember = dataTable.Columns(valueCol).ToString()
        NextChoixControl.DisplayMember = dataTable.Columns(displayCol).ToString()
    End Sub

    Private Sub Panel6_Paint(sender As Object, e As PaintEventArgs) Handles Panel6.Paint

    End Sub

    Private Sub AjouterContact_Click(sender As Object, e As EventArgs) Handles AjouterContact.Click
        AddNewContact()
    End Sub

    Private Sub AddNewContact(Optional Prenom = "", Optional Nom = "", Optional Client = "")
        If Prenom IsNot String.Empty Or Nom IsNot String.Empty Or Client IsNot String.Empty Then
            FormContact.Prenom.Text = Prenom
            FormContact.Nom.Text = Nom
            FormContact.Client.SelectedValue = Client
        End If


        Dim result = FormContact.ShowDialog()

        If result = DialogResult.OK Then
            'MessageBox.Show(FormContact.Nom.Text & Environment.NewLine & "
            '" & FormContact.Prenom.Text & Environment.NewLine & "
            '" & FormContact.Telephone.Text & Environment.NewLine & "
            '" & FormContact.Mail.Text & Environment.NewLine & "
            '" & FormContact.Localisation.SelectedValue & Environment.NewLine & "
            '" & FormContact.Client.SelectedValue)

            Dim newContact = "insert into contact(nom,prenom,telephone,email,id_localisation,id_client)
                            values(@nom,@prenom,@telephone,@email,@id_localisation,@id_client)"

            Dim command = New MySqlCommand(newContact, connection)

            command.Parameters.AddWithValue("@nom", FormContact.Nom.Text)
            command.Parameters.AddWithValue("@prenom", FormContact.Prenom.Text)
            command.Parameters.AddWithValue("@telephone", FormContact.Telephone.Text)
            command.Parameters.AddWithValue("@email", FormContact.Mail.Text)
            command.Parameters.AddWithValue("@id_localisation", FormContact.Localisation.SelectedValue)
            command.Parameters.AddWithValue("@id_client", FormContact.Client.SelectedValue)

            command.ExecuteNonQuery()
            MessageBox.Show("Ajouté avec succés!", "Nouveau contact", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub Enregistrer_Click(sender As Object, e As EventArgs) Handles Enregistrer.Click
        Dim result = MessageBox.Show("Confirmer ?", "Nouvelle zone de culture", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Try
                Dim query = "select id_localisation from localisation where (id_zone=@id_zone and region=@region and commune=@commune and village=@village)"

                Dim command = New MySqlCommand(query, connection)

                command.Parameters.AddWithValue("@id_zone", Zone.SelectedValue)
                command.Parameters.AddWithValue("@region", RegionZone.SelectedValue)
                command.Parameters.AddWithValue("@commune", CommuneZone.SelectedValue)
                command.Parameters.AddWithValue("@village", LocaliteZone.SelectedValue)

                Dim insertZone = "insert into zone_institution(id_institution, id_localisation) values(@id_institution, @id_localisation)"
                Dim insertCommand = New MySqlCommand(insertZone, connection)


                insertCommand.Parameters.AddWithValue("@id_institution", DBConnection.id_institution)
                insertCommand.Parameters.AddWithValue("@id_localisation", Integer.Parse(command.ExecuteScalar()))

                insertCommand.ExecuteNonQuery()

                LoadZone()
            Catch ex As MySqlException
                MessageBox.Show("Cette zone existe déjà chez nous.", "Zone déjà ajoutée", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End Try
        End If
    End Sub


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

    Private Sub FillChoixRegionInstitution(query, BindingSourceControl, NextChoixControl, valueCol, displayCol)
        Dim command = New MySqlCommand(query, connection)

        command.Parameters.AddWithValue("@region", ComboBox1.SelectedValue)

        Dim adapter = New MySqlDataAdapter(command)
        Dim dataTable = New DataTable()
        adapter.Fill(dataTable)

        BindingSourceControl.DataSource = dataTable

        NextChoixControl.ValueMember = dataTable.Columns(valueCol).ToString()
        NextChoixControl.DisplayMember = dataTable.Columns(displayCol).ToString()
    End Sub

    Private Sub FillChoixLocaliteInstitution()
        Dim query = "select village from localisation where region=@region"
        FillChoixInstitution(query:=query,
                  BindingSourceControl:=LocaliteInstitutionBindingSource,
                  NextChoixControl:=ComboBox2,
                  valueCol:="village",
                  displayCol:="village")
    End Sub

    Private Sub FillChoixInstitution(query, BindingSourceControl, NextChoixControl, valueCol, displayCol)

        Dim command = New MySqlCommand(query, connection)

        command.Parameters.AddWithValue("@region", ComboBox1.SelectedValue)

        Dim adapter = New MySqlDataAdapter(command)
        Dim dataTable = New DataTable()
        adapter.Fill(dataTable)

        BindingSourceControl.DataSource = dataTable

        NextChoixControl.ValueMember = dataTable.Columns(valueCol).ToString()
        NextChoixControl.DisplayMember = dataTable.Columns(displayCol).ToString()
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If TextBox1.Text IsNot String.Empty Or TextBox2.Text IsNot String.Empty Or ComboBox1.Text IsNot String.Empty Then
            Dim result = MessageBox.Show("Confirmer ?", "Ajouter/Modifier Institution", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Dim query = "insert into institution(nom_complet, sigle, id_localisation) 
                     values (@nom_complet, @sigle, @id_localisation)
                     on duplicate key update nom_complet=@om_complet, sigle=@sigle, id_localisation=@id_localisation"

                Dim command = New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@nom_complet", DBConnection.id_institution)
                command.Parameters.AddWithValue("@sigle", DBConnection.id_institution)
                command.Parameters.AddWithValue("@id_localisation", DBConnection.id_institution)


                command.ExecuteNonQuery()
            End If
        End If

    End Sub
    Private Sub FillNiveaux()
        Dim query = "select nom_niveau from niveau_institution inner join niveau_de_production n on n.id_niveau=niveau_institution.id_niveau where id_institution=@id_institution"

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
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
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

End Class
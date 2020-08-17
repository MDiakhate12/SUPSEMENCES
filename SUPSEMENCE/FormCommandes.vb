Imports MySql.Data.MySqlClient
Public Class FormCommandes

    Private connection As MySqlConnection = DBConnection.connection
    Private Sub FormCommandes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'SemencesDataSet.niveau_institution'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.ProductionTableAdapter.Fill(Me.SemencesDataSet.production)

        LoadCommandes()
        FillChoixClient()
        LoadCommandesATraiter()
        FillChoixNiveau()
        LoadCommandesAEnlever()
        LoadChoixVariete()

        RadioSociete.Checked = True
        CommandeData.Columns("numero_de_commade").Visible = False

        TraitementCommandeData.Columns("numero_de_commade").Visible = False
        GestionEnlevementData.Columns("numero_de_commade").Visible = False

        CommandeData.AllowUserToAddRows = False
        TraitementCommandeData.AllowUserToAddRows = False
        GestionEnlevementData.AllowUserToAddRows = False

        TraitementCommandeData.Columns("stock_de_securite").Visible = False
        GestionEnlevementData.Columns("stock_de_securite").Visible = False

    End Sub

    'Private Sub FormCommandes_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
    '    MessageBox.Show("Si le client existe déja passez directement à l'enregistrement de la commande.", "Comment enregistrer", MessageBoxButtons.OK, MessageBoxIcon.Information)
    'End Sub

    Public Sub FillChoixNiveau()
        Dim query = "select nom_niveau, niveau_institution.id_niveau 
                          from niveau_institution
                          inner join niveau_de_production ndp on ndp.id_niveau=niveau_institution.id_niveau
                          where niveau_institution.id_institution=@id_institution"

        Dim command = New MySqlCommand(query, connection)
        command.Parameters.AddWithValue("@id_institution", DBConnection.id_institution)

        Dim dataTable = New DataTable()
        Dim dataAdapter = New MySqlDataAdapter(command)
        dataAdapter.FillAsync(dataTable)

        NiveauinstitutionBindingSource.DataSource = dataTable

        Niveau.DisplayMember = dataTable.Columns("nom_niveau").ToString()
        Niveau.ValueMember = dataTable.Columns("id_niveau").ToString()
        Niveau.SelectedValue = dataTable.Rows(1).Item("id_niveau").ToString()

    End Sub

    Public Sub FillChoixClient()
        Dim getClients = "select * from client order by id_client desc"

        Dim command = New MySqlCommand(getClients, connection)

        Dim dataTable = New DataTable()
        Dim dataAdapter = New MySqlDataAdapter(command)
        dataAdapter.FillAsync(dataTable)

        ClientBindingSource.DataSource = dataTable

        Client.DisplayMember = dataTable.Columns("nom_complet_structure").ToString()
        Client.ValueMember = dataTable.Columns("id_client").ToString()

    End Sub

    Public Sub LoadChoixVariete()

        Dim getProductions = "Select id_production, v.nom_variete, s.nom_speculation, v.id_speculation, m.nom_magasin, m.id_magasin 
                                From production p, magasin m, variete_institution vi, variete v, speculation s
                                Where (
                                vi.id_institution =@id_institution And
                                 m.id_magasin = p.id_magasin And
                                 vi.id_variete_institution = p.id_variete_institution And
                                 v.id_variete = vi.id_variete And
                                 s.id_speculation = v.id_speculation and 
                                 p.id_niveau=@id_niveau
                                )"

        Dim command = New MySqlCommand(getProductions, connection)
        command.Parameters.AddWithValue("@id_institution", DBConnection.id_institution)
        command.Parameters.AddWithValue("@id_niveau", Niveau.SelectedValue)
        Dim dataTable = New DataTable()
        Dim dataAdapter = New MySqlDataAdapter(command)
        dataAdapter.FillAsync(dataTable)
        ProductionBindingSource.DataSource = dataTable


        Production.ValueMember = dataTable.Columns("id_production").ToString()
        Production.DisplayMember = dataTable.Columns("nom_variete").ToString()

        Speculation.DisplayMember = dataTable.Columns("nom_speculation").ToString()
        Speculation.ValueMember = dataTable.Columns("id_speculation").ToString()

        MagasinEnlevement.DisplayMember = dataTable.Columns("nom_magasin").ToString()
        MagasinEnlevement.ValueMember = dataTable.Columns("id_magasin").ToString()

    End Sub

    Private Sub LoadCommandes()

        Dim getCommande = "select
                            numero_de_commade,
	                        variete.nom_variete,
	                        speculation.nom_speculation,
	                        niveau_de_production.nom_niveau,
	                        commande.quantite, 
                            commande.montant, 
                            client.nom_complet_structure client
                        from commande
                        join client on client.id_client=commande.id_client
                        join magasin on magasin.id_magasin=commande.magasin_enlevement
                        join production on commande.id_production=production.id_production
                        join niveau_institution on production.id_niveau_institution=niveau_institution.id_niveau_institution
                        join niveau_de_production on niveau_institution.id_niveau=niveau_de_production.id_niveau
                        join variete_institution on variete_institution.id_variete_institution=production.id_variete_institution 
                        join variete on variete_institution.id_variete = variete.id_variete
                        join speculation on variete.id_speculation=speculation.id_speculation
                        where production.id_institution=@id_institution
                        order by numero_de_commade desc"


        Dim command = New MySqlCommand(getCommande, connection)

        command.Parameters.AddWithValue("@id_institution", DBConnection.id_institution)
        Dim dataAdapter = New MySqlDataAdapter(command)
        Dim commandeTable = New DataTable()
        dataAdapter.FillAsync(commandeTable)
        CommandeData.DataSource = commandeTable
        Dim firstRow = CommandeData.Rows.GetFirstRow(DataGridViewElementStates.Visible)
        CommandeData.Rows(firstRow).Selected = True
    End Sub

    Private Sub LoadStocks()
        Dim connection As MySqlConnection


        connection = New MySqlConnection(DBConnection.connectionString)

        Dim getQuantiteSpeculation = "select nom_variete, nom_speculation, sum(quantite_produite) quantite_totale, stock_de_securite
                                        from production, variete_institution, variete, speculation 
                                        where (
                                        production.id_institution=@id_institution and 
                                        variete_institution.id_variete_institution=production.id_variete_institution and
                                        variete.id_variete=variete_institution.id_variete and
                                        variete.id_speculation=speculation.id_speculation
                                        )
                                        group by nom_variete;"

        Dim commandQuantiteSpeculation = New MySqlCommand(getQuantiteSpeculation, connection)
        commandQuantiteSpeculation.Parameters.AddWithValue("@id_institution", DBConnection.id_institution)


        Dim reader = commandQuantiteSpeculation.ExecuteReader()

        While reader.Read()

        End While

        reader.Close()


    End Sub

    Private Sub LoadCommandesATraiter()

        Dim getCommande = "select commande.id_production production, numero_de_commade, nom_variete, quantite quantite_commandee, stock_de_securite, quantite_disponible
                            from commande
                            inner join production on production.id_production=commande.id_production 
                            inner join variete_institution on variete_institution.id_variete_institution=production.id_variete_institution
                            inner join variete on variete.id_variete=variete_institution.id_variete
                            where(production.id_institution=@id_institution and
                                  commande.est_traite=0 and
                                  commande.est_rejetee=0)
                            order by numero_de_commade desc"


        Dim command = New MySqlCommand(getCommande, connection)

        command.Parameters.AddWithValue("@id_institution", DBConnection.id_institution)
        Dim dataAdapter = New MySqlDataAdapter(command)
        Dim commandeTable = New DataTable()
        dataAdapter.Fill(commandeTable)

        FillValidite(TraitementCommandeData, commandeTable)

        'Dim firstRow = TraitementCommandeData.Rows.GetFirstRow(DataGridViewElementStates.Visible)
        'TraitementCommandeData.Rows(firstRow).Selected = True
        TraitementCommandeData.ClearSelection()

    End Sub

    Private Sub LoadCommandesAEnlever()

        Dim getCommande = "select commande.id_production production, numero_de_commade, nom_variete, date_enlevement_souhaitee, quantite quantite_commandee, stock_de_securite, quantite_disponible
                            From commande
                            inner Join production on production.id_production=commande.id_production 
                            inner Join variete_institution on variete_institution.id_variete_institution=production.id_variete_institution
                            inner Join variete on variete.id_variete=variete_institution.id_variete
                            where(Production.id_institution =@id_institution And
                                  commande.est_traite = 1 And
                                  commande.est_valide = 1 And
                                  commande.est_enlevee = 0 And
                                  commande.est_annulee = 0 And
                                  commande.est_rejetee = 0)
                            order by numero_de_commade desc"


        Dim command = New MySqlCommand(getCommande, connection)

        command.Parameters.AddWithValue("@id_institution", DBConnection.id_institution)
        Dim dataAdapter = New MySqlDataAdapter(command)
        Dim commandeTable = New DataTable()
        dataAdapter.Fill(commandeTable)

        FillValidite(GestionEnlevementData, commandeTable)
        'Dim firstRow = TraitementCommandeData.Rows.GetFirstRow(DataGridViewElementStates.Visible)
        'TraitementCommandeData.Rows(firstRow).Selected = True
        GestionEnlevementData.ClearSelection()
    End Sub
    Private Sub FillValidite(data As DataGridView, table As DataTable)
        Dim dataColumn = New DataColumn("Validité", GetType(Image))
        table.Columns.Add(dataColumn)
        data.DataSource = table
        Dim quantite_commandee As Integer
        Dim quantite_disponible As Integer
        Dim stock_de_securite As Integer
        Dim validite As DataGridViewImageCell
        For Each row As DataGridViewRow In data.Rows
            quantite_commandee = Convert.ToInt32(row.Cells("quantite_commandee").Value)
            quantite_disponible = Convert.ToInt32(row.Cells("quantite_disponible").Value)
            stock_de_securite = Convert.ToInt32(row.Cells("stock_de_securite").Value)
            validite = row.Cells("Validité")

            If quantite_commandee >= quantite_disponible Then
                validite.Value = Image.FromFile($"{DBConnection.imagePath}icons8-warning-28.png")
                validite.ToolTipText = "Attention! Cette commande ne peut pas être honorée pour l'instant" & Environment.NewLine & "La quantitée demandée n'est pas disponible en stock"
            Else
                validite.Value = Image.FromFile($"{DBConnection.imagePath}icons8-ok-28.png")
                validite.ToolTipText = "Cette commande peut être honorée"
            End If
        Next
    End Sub
    Private Sub SaveCommande()

        If Quantite.Value <= 0 Or Montant.Value <= 0 Then
            MessageBox.Show("La quantité ne peut pas être nulle!", "Forumlaire invalide", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If DateEnlevement.Value <= DateExpressionBesoin.Value Then
            MessageBox.Show("La date d'enlèvement ne peut pas être inférieure à la date où le client a exprimé le besoin!", "Forumlaire invalide", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If DateEnlevement.Value < Date.Now() Then
            MessageBox.Show("La date d'enlèvement ne peut pas être inférieure celle d'aujourd'hui!", "Forumlaire invalide", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If Date.Now() < DateExpressionBesoin.Value Then
            MessageBox.Show("Le client ne peut pas exprimer le besoin à une date supérieure à celle d'aujoud'hui!", "Forumlaire invalide", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim newCommande = $"insert into commande(quantite,montant, date_enlevement_souhaitee,date_enlevement_reelle,
                            date_creation,date_expression_besoin_client,
                            magasin_enlevement,id_production,id_client)
                            values(@quantite,@montant,@date_enlevement_souhaitee,@date_enlevement_reelle,
                            @date_creation,@date_expression_besoin_client,
                            @magasin_enlevement,@id_production,@id_client)"


        Dim command = New MySqlCommand(newCommande, connection)

        command.Parameters.AddWithValue("@quantite", Quantite.Value)
        command.Parameters.AddWithValue("@montant", Montant.Value)
        command.Parameters.AddWithValue("@date_enlevement_souhaitee", DateEnlevement.Value)
        command.Parameters.AddWithValue("@date_enlevement_reelle", DateEnlevement.Value)
        command.Parameters.AddWithValue("@date_creation", Date.Now())
        command.Parameters.AddWithValue("@date_expression_besoin_client", DateExpressionBesoin.Value)
        command.Parameters.AddWithValue("@magasin_enlevement", MagasinEnlevement.SelectedValue)
        command.Parameters.AddWithValue("@id_production", Production.SelectedValue)
        command.Parameters.AddWithValue("@id_client", Client.SelectedValue)
        command.ExecuteNonQuery()
        LoadCommandes()
        MessageBox.Show("Ajoutée avec succés!", "Nouvelle commande", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Quantite.Value = 0
        Montant.Value = 0

    End Sub
    Private Sub setMontant()
        Dim getPrix = New MySqlCommand("select prix_unitaire from production where id_production=@id_production", connection)

        getPrix.Parameters.AddWithValue("@id_production", Production.SelectedValue)
        Dim prix_unitaire As Integer
        Dim reader = getPrix.ExecuteReader()
        While reader.Read()
            prix_unitaire = reader.GetUInt32("prix_unitaire")
        End While
        Montant.Value = prix_unitaire * Quantite.Value
        reader.Close()
    End Sub

    Private Sub Quantite_ValueChanged(sender As Object, e As EventArgs) Handles Quantite.ValueChanged
        If connection.State = ConnectionState.Closed Then
            Return
        End If
        setMontant()
    End Sub

    Private Sub Production_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Production.SelectedIndexChanged
        If connection.State = ConnectionState.Closed Then
            Return
        End If
        setMontant()
    End Sub

    Private Sub EnregistrerCommande_Click(sender As Object, e As EventArgs) Handles EnregistrerCommande.Click
        SaveCommande()
    End Sub

    Private Sub RadioSociete_CheckedChanged(sender As Object, e As EventArgs) Handles RadioSociete.CheckedChanged
        If RadioSociete.Checked Then
            LabelStructure.Visible = True
            NomStructure.Visible = True
            LabelSigle.Visible = True
            SigleStructure.Visible = True

            LabelPrenomClient.Visible = False
            PrenomClient.Visible = False
            LabelNomClient.Visible = False
            NomClient.Visible = False
        ElseIf RadioParticulier.Checked Then
            LabelStructure.Visible = False
            NomStructure.Visible = False
            LabelSigle.Visible = False
            SigleStructure.Visible = False

            LabelPrenomClient.Visible = True
            PrenomClient.Visible = True
            LabelNomClient.Visible = True
            NomClient.Visible = True
        End If
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

    Private Sub SaveClient(nom_complet_structure As String, acronyme As String, prenom As String, nom As String, est_particulier As Integer)



        Dim newClient As String
        Dim command As MySqlCommand



        newClient = $"insert into client(nom_complet_structure, acronyme, prenom, nom, est_particulier)
                            values(@nom_complet_structure, @acronyme, @prenom, @nom, @est_particulier); select last_insert_id()"

        command = New MySqlCommand(newClient, connection)

        command.Parameters.AddWithValue("@nom_complet_structure", nom_complet_structure)
        command.Parameters.AddWithValue("@acronyme", acronyme)
        command.Parameters.AddWithValue("@prenom", prenom)
        command.Parameters.AddWithValue("@nom", nom)
        command.Parameters.AddWithValue("@est_particulier", est_particulier)

        Dim id_client = CInt(command.ExecuteScalar())

        MessageBox.Show("Ajouté avec succés!", "Nouveau client", MessageBoxButtons.OK, MessageBoxIcon.Information)
        PrenomClient.Clear()
        NomClient.Clear()
        NomStructure.Clear()
        SigleStructure.Clear()
        If prenom IsNot String.Empty And nom IsNot String.Empty Then
            AddNewContact(prenom, nom, id_client)
        Else
            AddNewContact()
        End If
        FillChoixClient()

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        If RadioParticulier.Checked Then
            If PrenomClient.Text Is String.Empty Or NomClient.Text Is String.Empty Then
                MessageBox.Show("Veuillez remplir tous les champs svp.", "Forumlaire invalide", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            SaveClient(PrenomClient.Text & " " & NomClient.Text, "", PrenomClient.Text, NomClient.Text, 1)
        Else
            If NomStructure.Text Is String.Empty Or SigleStructure.Text Is String.Empty Then
                MessageBox.Show("Veuillez remplir tous les champs svp.", "Forumlaire invalide", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If
            SaveClient(NomStructure.Text, SigleStructure.Text, "", "", 0)
        End If
    End Sub

    Private Sub AjouterContact_Click(sender As Object, e As EventArgs) Handles AjouterContact.Click
        'Dim result = MessageBox.Show("Vous n'avez pas encore enregistré un nouveau client." & Environment.NewLine & "Ajouter un contact existant ?", "Comment enregistrer", MessageBoxButtons.OK, MessageBoxIcon.
        AddNewContact()
    End Sub

    Private Sub TraitementCommandeData_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles TraitementCommandeData.CellEnter
        Dim getCommande = "select
	                        variete.nom_variete,
	                        speculation.nom_speculation,
	                        commande.quantite,
                            (quantite_produite-stock_de_securite) quantite_disponible,
                            commande.montant, 
                            client.nom_complet_structure,
	                        commande.date_expression_besoin_client, 
                            commande.date_enlevement_souhaitee,
	                        magasin.nom_magasin
                        from commande
                        join client on client.id_client=commande.id_client
                        join magasin on magasin.id_magasin=commande.magasin_enlevement
                        join production on commande.id_production=production.id_production
                        join variete_institution on variete_institution.id_variete_institution=production.id_variete_institution 
                        join variete on variete_institution.id_variete = variete.id_variete
                        join speculation on variete.id_speculation=speculation.id_speculation
                        where production.id_institution=@id_institution and
                              commande.numero_de_commade=@id_commande
                        order by numero_de_commade desc"


        Dim command = New MySqlCommand(getCommande, connection)

        command.Parameters.AddWithValue("@id_institution", DBConnection.id_institution)
        command.Parameters.AddWithValue("@id_commande", TraitementCommandeData.CurrentRow.Cells("numero_de_commade").Value)
        Dim reader = command.ExecuteReader()
        Dim labelList As New List(Of Control) From {LVariete, LSpeculation, LQuantiteCommande, LQuantiteDisponible, LMontant, LClient, LDateExprBesoin, LDateEnlevement, LMagasin}
        Dim readerCount = reader.FieldCount()
        Dim index = 0
        While reader.Read()
            For Each label As Label In labelList
                label.Text = reader.GetValue(index)
                index += 1
            Next
        End While
        reader.Close()

    End Sub

    Private Sub TraitementCommandeData_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles TraitementCommandeData.RowPrePaint
        CommandValidityMarker(TraitementCommandeData, e)
    End Sub

    Private Sub CommandValidityMarker(data As DataGridView, e As DataGridViewRowPrePaintEventArgs)
        'Try
        '    If Convert.ToInt32(data.Rows(e.RowIndex).Cells(2).Value) >= Convert.ToInt32(data.Rows(e.RowIndex).Cells(5).Value) Then
        '        data.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(255, 192, 192)
        '        data.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.Firebrick
        '    Else
        '        data.Rows(e.RowIndex).DefaultCellStyle.BackColor = Color.FromArgb(192, 255, 192)
        '        data.Rows(e.RowIndex).DefaultCellStyle.ForeColor = Color.FromArgb(38, 129, 55)
        '    End If
        'Catch ex As Exception
        '    Return
        'End Try
    End Sub

    Private Sub ButtonValiderCommande_Click(sender As Object, e As EventArgs) Handles ButtonValiderCommande.Click
        ValiderCommande()
    End Sub

    Private Sub ValiderCommande()
        Dim currentRow = TraitementCommandeData.CurrentRow
        Dim currentQuantiteDisponible = currentRow.Cells("quantite_disponible").Value
        Dim currentQuantiteDemandee = currentRow.Cells("quantite_commandee").Value
        Dim id_commande = currentRow.Cells("numero_de_commade")
        Dim id_production = currentRow.Cells("production")



        'Try

        Dim getCommande As String

        If currentQuantiteDemandee >= currentQuantiteDisponible Then
            Dim result2 = MessageBox.Show("Vous êtes sur le point de valider une commande qui dépasse la quantité de stock disponible. Etes-vous sûr ?", "Stock de sécurité atteint", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result2 = DialogResult.Yes Then
                getCommande = "update commande set est_traite=1, est_valide=0, est_rejetee=0 where numero_de_commade=@id_commande"
            Else
                Return
            End If
        Else
            Dim result = MessageBox.Show("Confirmer ?", "Validation commande", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                getCommande = "update commande set est_traite=1, est_valide=1, est_rejetee=0 where numero_de_commade=@id_commande"
            Else
                Return
            End If
        End If


        Dim command = New MySqlCommand(getCommande, connection)

        command.Parameters.AddWithValue("@id_institution", DBConnection.id_institution)
        command.Parameters.AddWithValue("@id_commande", id_commande.Value)
        command.ExecuteNonQuery()

        updateStockDisponible(id_production.Value, currentQuantiteDemandee)

        LoadCommandesATraiter()
        LoadCommandesAEnlever()
        MessageBox.Show("Commande validée avec succés", "Commande validée", MessageBoxButtons.OK, MessageBoxIcon.Information)
        TraitementCommandeData.ClearSelection()
        TraitementCommandeData.Rows(0).Selected = True


        'Catch ex As MysqlException
        '    MessageBox.Show("Veuillez reessayer plus tard svp.", "Erreur innattendue", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Return
        'End Try


    End Sub


    Private Sub updateStockDisponible(id, quantiteCommandee)
        Dim query = "update production 
                    set quantite_disponible=(quantite_disponible - @quantite_commandee) 
                    where id_production=@id_production"
        Dim command = New MySqlCommand(query, connection)
        Dim queryAdapter = New MySqlDataAdapter(command)
        Dim queryTable = New DataTable()

        command.Parameters.AddWithValue("@id_production", id)
        command.Parameters.AddWithValue("@quantite_commandee", quantiteCommandee)

        command.ExecuteNonQuery()
    End Sub

    Private Sub RejeterCommande()
        Dim currentRow = TraitementCommandeData.CurrentRow
        Dim currentQuantiteDisponible = currentRow.Cells(5).Value
        Dim currentQuantiteDemandee = currentRow.Cells(2).Value

        Try
            Dim result = MessageBox.Show("Confirmer ?", "Rejet commande", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Dim getCommande As String


                If currentQuantiteDisponible >= currentQuantiteDemandee Then
                    Dim result2 = MessageBox.Show("Vous êtes sur le point de rejeter une commande qui ne dépasse pas la quantité de stock disponible. Etes-vous sûr ?", "Rejet commande valide", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    If result2 = DialogResult.Yes Then
                        getCommande = "update commande set est_traite=1, est_valide=1, est_rejetee=1 where numero_de_commade=@id_commande"
                    Else
                        Return
                    End If
                Else
                    getCommande = "update commande set est_traite=1, est_valide=0, est_rejetee=1 where numero_de_commade=@id_commande"
                End If


                Dim command = New MySqlCommand(getCommande, connection)

                command.Parameters.AddWithValue("@id_institution", DBConnection.id_institution)
                command.Parameters.AddWithValue("@id_commande", currentRow.Cells(0).Value)
                command.ExecuteNonQuery()
                LoadCommandesATraiter()
                MessageBox.Show("Commande rejetée avec succés", "Commande rejetée", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TraitementCommandeData.ClearSelection()
                TraitementCommandeData.Rows(0).Selected = True
            Else
                Return
            End If

        Catch ex As Exception
            MessageBox.Show("Veuillez reessayer plus tard svp.", "Erreur innattendue", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End Try


    End Sub

    Private Sub ButtonRejeterCommande_Click(sender As Object, e As EventArgs) Handles ButtonRejeterCommande.Click
        RejeterCommande()
    End Sub

    Private Sub TraitementCommande_Enter(sender As Object, e As EventArgs) Handles TraitementCommande.Enter
        LoadCommandesATraiter()
    End Sub

    Private Sub GestionEnlevementData_RowPrePaint(sender As Object, e As DataGridViewRowPrePaintEventArgs) Handles GestionEnlevementData.RowPrePaint
        CommandValidityMarker(GestionEnlevementData, e)
    End Sub

    Private Sub Recherche_GotFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Recherche.GotFocus
        If Recherche.Text = "Rechercher" Then
            Recherche.Text = ""
        End If
    End Sub

    Private Sub Recherche_LostFocus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Recherche.LostFocus
        If Recherche.Text = "" Then
            Recherche.Text = "Rechercher"
        End If
    End Sub

    Private Sub Recherche_TextChanged(sender As Object, e As EventArgs) Handles Recherche.TextChanged
        If Recherche.Text = "Rechercher" Then
            Return
        Else
            ClearRechercher.Visible = True
        End If

        Dim fields As New List(Of String) From {
           "variete.nom_variete",
           "speculation.nom_speculation",
           "niveau_de_production.nom_niveau",
           "commande.quantite",
           "commande.montant",
           "client.nom_complet_structure"
}

        Dim queryField As String = GetField(ChoixRecherche, fields)

        Dim queryValue = Recherche.Text

        Dim query = $"select
	                        variete.nom_variete,
	                        speculation.nom_speculation,
	                        niveau_de_production.nom_niveau,
	                        commande.quantite, 
                            commande.montant, 
                            client.nom_complet_structure client
                        from commande
                        join client on client.id_client=commande.id_client
                        join magasin on magasin.id_magasin=commande.magasin_enlevement
                        join production on commande.id_production=production.id_production
                        join niveau_institution on production.id_niveau_institution=niveau_institution.id_niveau_institution
                        join niveau_de_production on niveau_institution.id_niveau=niveau_de_production.id_niveau
                        join variete_institution on variete_institution.id_variete_institution=production.id_variete_institution 
                        join variete on variete_institution.id_variete = variete.id_variete
                        join speculation on variete.id_speculation=speculation.id_speculation
                        where production.id_institution=@id_institution and
                        {queryField} like '%{queryValue}%'
                        order by numero_de_commade desc"

        Rechercher(query, CommandeData)

    End Sub

    Private Function GetField(selector As ComboBox, fields As List(Of String)) As String
        Dim searchField As String = fields.First()
        For Each item In selector.Items
            If (selector.SelectedItem = item) Then
                searchField = fields(selector.Items.IndexOf(item))
                Exit For
            End If
        Next
        Return searchField
    End Function

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

    Private Sub ClearRechercher_Click(sender As Object, e As EventArgs)
        If Not Recherche.Text.Equals("") Then
            Recherche.Clear()
        End If
    End Sub


    Private Sub CommandeData_CellMouseUp(sender As Object, e As DataGridViewCellMouseEventArgs) Handles CommandeData.CellMouseUp
        ShowContextMenu(e, contextMenu:=ContextMenuStrip1, tableData:=CommandeData)
    End Sub
    Private Sub ShowContextMenu(e As DataGridViewCellMouseEventArgs, contextMenu As ContextMenuStrip, tableData As DataGridView)
        If e.Button = MouseButtons.Right Then
            tableData.ClearSelection()
            tableData.Rows(e.RowIndex).Selected = True
            contextMenu.Show(tableData, e.Location)
            contextMenu.Show(Cursor.Position)
        End If
    End Sub

    Private Sub MenuItemModifier_Click(sender As Object, e As EventArgs) Handles ModifierMenuItem.Click
        Dim updateForm = New FormUpdateCommande()
        Dim currentRow = CommandeData.SelectedRows(0)
        Dim id = currentRow.Cells("numero_de_commade").Value

        Dim query = "select quantite,montant, date_enlevement_souhaitee,date_enlevement_reelle,
                            date_creation,date_derniere_modification,date_expression_besoin_client,
                            magasin_enlevement,id_production,id_client 
                     from commande where numero_de_commade=@id"

        Dim command = New MySqlCommand(query, connection)
        command.Parameters.AddWithValue("@id", id)

        Dim reader = command.ExecuteReader()
        Dim production
        Dim client
        Dim quantite
        Dim magasin
        updateForm.id = id
        While reader.Read()
            quantite = reader.GetString("quantite")
            updateForm.Montant.Value = reader.GetString("montant")
            updateForm.DateEnlevement.Value = reader.GetString("date_enlevement_souhaitee")
            updateForm.DateEnlevement.Value = reader.GetString("date_enlevement_reelle")
            updateForm.DateExpressionBesoin.Value = reader.GetString("date_expression_besoin_client")
            magasin = reader.GetString("magasin_enlevement")
            production = reader.GetString("id_production")
            client = reader.GetString("id_client")
        End While


        reader.Close()

        Dim result = updateForm.ShowDialog()
        updateForm.Production.SelectedValue = production
        updateForm.Client.SelectedValue = client
        updateForm.Quantite.Value = quantite
        updateForm.MagasinEnlevement.SelectedValue = magasin

        If result = DialogResult.OK Then
            LoadCommandes()
        End If

    End Sub

    Private Sub SupprimerMenuItem_Click(sender As Object, e As EventArgs) Handles SupprimerMenuItem.Click
        Supprimer(tableName:="commande", tableData:=CommandeData, idName:="numero_de_commade", errorMessage:=AddressOf DeleteError)
    End Sub

    Private Sub Supprimer(tableName As String, idName As String, tableData As DataGridView, errorMessage As Action)
        Dim currentRow = tableData.SelectedRows(0)
        Dim idValue = currentRow.Cells(idName).Value
        Dim result = MessageBox.Show("Confirmer ?", $"Suppression {tableName}", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        If result = DialogResult.Yes Then
            Try
                Dim query = $"delete from {tableName} where {idName}=@{idName}"
                Dim command = New MySqlCommand(query, connection)
                command.Parameters.AddWithValue($"{idName}", idValue)
                command.ExecuteNonQuery()
                CommandeData.Rows.RemoveAt(currentRow.Index)
                MessageBox.Show("Supprimé avec succés", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As MySqlException When ex.Number = 1451
                errorMessage()
                Return
            End Try
        End If

    End Sub

    Private Sub DeleteError()
        MessageBox.Show("Cette production possède actuellement des commandes en cours.", "Suppression impossible", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub Niveau_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Niveau.SelectedIndexChanged
        LoadChoixVariete()
    End Sub

    Private Sub EnleverCommande()

    End Sub

    Private Sub AnnulerEnlevementCommande()

    End Sub

    Private Sub ValiderEnlevement_Click(sender As Object, e As EventArgs) Handles ValiderEnlevement.Click
        Dim currentRow = GestionEnlevementData.CurrentRow()
        Dim currentQuantiteDisponible = currentRow.Cells("quantite_disponible").Value
        Dim currentQuantiteDemandee = currentRow.Cells("quantite_commandee").Value
        Dim id_commande = currentRow.Cells("numero_de_commade")
        Dim id_production = currentRow.Cells("production")


        If currentQuantiteDemandee >= currentQuantiteDisponible Then
            MessageBox.Show("Enlèvement impossible! La quantité commandée n'est pas disponible en stock actuellement", "Enlèvement impossible", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        Else
            Dim result = MessageBox.Show("Confirmer ?", "Validation commande", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Dim getCommande = "update commande set est_enlevee=1, est_annulee=0, date_enlevement_reelle=@date_enlevement_reelle where numero_de_commade=@id_commande"

                Dim command = New MySqlCommand(getCommande, connection)

                command.Parameters.AddWithValue("@id_institution", DBConnection.id_institution)
                command.Parameters.AddWithValue("@id_commande", id_commande.Value)
                command.Parameters.AddWithValue("@date_enlevement_reelle", Date.Now())

                command.ExecuteNonQuery()

                LoadCommandesAEnlever()
                MessageBox.Show("Commande enlevée avec succés", "Commande enlevée", MessageBoxButtons.OK, MessageBoxIcon.Information)
                GestionEnlevementData.ClearSelection()

                If GestionEnlevementData.Rows.Count > 0 Then
                    GestionEnlevementData.Rows(0).Selected = True
                End If
            Else
                Return
            End If
        End If


    End Sub

    Private Sub EnlevementAnnule_Click(sender As Object, e As EventArgs) Handles EnlevementAnnule.Click
        Dim currentRow = GestionEnlevementData.CurrentRow()
        Dim currentQuantiteDisponible = currentRow.Cells("quantite_disponible").Value
        Dim currentQuantiteDemandee = currentRow.Cells("quantite_commandee").Value
        Dim id_commande = currentRow.Cells("numero_de_commade")
        Dim id_production = currentRow.Cells("production")

        Dim result = MessageBox.Show("Confirmer ?", "Annulation enlèvement commande", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Dim getCommande = "update commande set est_enlevee=0, est_annulee=1, date_enlevement_reelle=@date_enlevement_reelle where numero_de_commade=@id_commande"

            Dim command = New MySqlCommand(getCommande, connection)

                command.Parameters.AddWithValue("@id_institution", DBConnection.id_institution)
                command.Parameters.AddWithValue("@id_commande", id_commande.Value)
                command.Parameters.AddWithValue("@date_enlevement_reelle", Date.Now())

                command.ExecuteNonQuery()

                LoadCommandesAEnlever()
            MessageBox.Show("Enlèvement annulé avec succés!", "Enlèvelemnt annulé", MessageBoxButtons.OK, MessageBoxIcon.Information)
            GestionEnlevementData.ClearSelection()
                GestionEnlevementData.Rows(0).Selected = True
            Else
                Return
            End If

    End Sub
End Class

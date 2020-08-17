Imports MySql.Data.MySqlClient
Public Class FormUpdateCommande

    Private connection As MySqlConnection = DBConnection.connection
    Public id
    Private Sub FormUpdateCommande_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.ProductionTableAdapter.Fill(Me.SemencesDataSet.production)

        FillChoixClient()
        LoadChoixVariete()

    End Sub

    Public Sub FillChoixClient()
        Dim getClients = "select * from client order by id_client desc"

        Dim command = New MySqlCommand(getClients, connection)

        Dim dataTable = New DataTable()
        Dim dataAdapter = New MySqlDataAdapter(command)
        dataAdapter.Fill(dataTable)

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
                                 s.id_speculation = v.id_speculation
                                )"

        Dim command = New MySqlCommand(getProductions, connection)
        command.Parameters.AddWithValue("@id_institution", DBConnection.id_institution)
        Dim dataTable = New DataTable()
        Dim dataAdapter = New MySqlDataAdapter(command)
        dataAdapter.Fill(dataTable)
        ProductionBindingSource.DataSource = dataTable

        Production.ValueMember = dataTable.Columns("id_production").ToString()
        Production.DisplayMember = dataTable.Columns("nom_variete").ToString()

        Speculation.DisplayMember = dataTable.Columns("nom_speculation").ToString()
        Speculation.ValueMember = dataTable.Columns("id_speculation").ToString()

        MagasinEnlevement.DisplayMember = dataTable.Columns("nom_magasin").ToString()
        MagasinEnlevement.ValueMember = dataTable.Columns("id_magasin").ToString()

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
        If connection.State = ConnectionState.Executing Or connection.State = ConnectionState.Fetching Or connection.State = ConnectionState.Closed Then
            Return
        Else
            setMontant()
        End If
    End Sub

    Private Sub Production_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Production.SelectedIndexChanged
        If connection.State = ConnectionState.Closed Then
            Return
        End If
        setMontant()
    End Sub

    Private Sub EnregistrerCommande_Click(sender As Object, e As EventArgs) Handles EnregistrerCommande.Click
        UpdateCommande(id)

        If Me.DialogResult = DialogResult.OK Then
            Me.Close()
        End If
    End Sub

    Private Sub UpdateCommande(id)

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

        Dim newCommande = $"update commande 
                            set
                            quantite = @quantite,
                            montant = @montant,
                            date_enlevement_souhaitee = @date_enlevement_souhaitee,
                            date_enlevement_reelle = @date_enlevement_reelle,
                            date_derniere_modification = @date_derniere_modification,
                            magasin_enlevement = @magasin_enlevement,
                            id_production = @id_production,
                            id_client = @id_client
                            where numero_de_commade=@id"

        Dim command = New MySqlCommand(newCommande, connection)

        command.Parameters.AddWithValue("@quantite", Quantite.Value)
        command.Parameters.AddWithValue("@montant", Montant.Value)
        command.Parameters.AddWithValue("@date_enlevement_souhaitee", DateEnlevement.Value)
        command.Parameters.AddWithValue("@date_enlevement_reelle", DateEnlevement.Value)

        command.Parameters.AddWithValue("@id", id)
            command.Parameters.AddWithValue("@date_derniere_modification", Date.Now())
        command.Parameters.AddWithValue("@magasin_enlevement", MagasinEnlevement.SelectedValue)
        command.Parameters.AddWithValue("@id_production", Production.SelectedValue)
        command.Parameters.AddWithValue("@id_client", Client.SelectedValue)
        command.ExecuteNonQuery()
        MessageBox.Show("Modifié avec succés!", "Commande modifiée", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Quantite.Value = 0
        Montant.Value = 0

        Me.DialogResult = DialogResult.OK

    End Sub
End Class
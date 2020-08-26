Imports MySql.Data.MySqlClient

Public Class FormUpdateProduction

    Private connection As MySqlConnection = DBConnection.connection
    Private Sub FormUpdateProduction_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Public Sub LoadChoixVariete()
        Dim getVarietes = "select variete_institution.id_variete_institution, nom_variete 
                            from variete_institution 
                            inner join variete 
                            on variete.id_variete=variete_institution.id_variete 
                            where id_institution=@id_institution"

        Dim command = New MySqlCommand(getVarietes, connection)
        command.Parameters.AddWithValue("@id_institution", DBConnection.id_institution)
        Dim dataTable = New DataTable()
        Dim dataAdapter = New MySqlDataAdapter(command)
        dataAdapter.Fill(dataTable)
        VarieteBindingSource.DataSource = dataTable
        ChoixVariete.DisplayMember = dataTable.Columns("nom_variete").ToString()
        ChoixVariete.ValueMember = dataTable.Columns("id_variete_institution").ToString()
    End Sub

    Public Sub LoadChoixNiveau()
        Dim getVarietes = "select n.nom_niveau, n.id_niveau 
                            from niveau_institution ni
                            inner join niveau_de_production n
                            on n.id_niveau=ni.id_niveau
                            where id_institution=@id_institution"

        Dim command = New MySqlCommand(getVarietes, connection)
        command.Parameters.AddWithValue("@id_institution", DBConnection.id_institution)
        Dim dataTable = New DataTable()
        Dim dataAdapter = New MySqlDataAdapter(command)
        dataAdapter.FillAsync(dataTable)
        NiveauinstitutionBindingSource.DataSource = dataTable
        NiveauDeProduction.DisplayMember = dataTable.Columns("nom_niveau").ToString()
        NiveauDeProduction.ValueMember = dataTable.Columns("id_niveau").ToString()
        NiveauDeProduction.SelectedValue = dataTable.Rows(1).Item("id_niveau").ToString()
    End Sub



    Public Sub ShowZoneUnderLocalite()
        Dim getZone = "select nom_zone, departement, commune from localisation loc inner join zone_agro_ecologique zone on loc.id_zone=zone.id_zone where loc.id_localisation=@selected_location"
        Dim command = New MySqlCommand(getZone, connection)
        command.Parameters.AddWithValue("@selected_location", Localisation.SelectedValue)
        Dim reader = command.ExecuteReader()
        Dim nom_zone As String
        Dim commune As String
        Dim departement As String
        While reader.Read()
            nom_zone = reader.GetString("nom_zone")
            commune = reader.GetString("commune")
            departement = reader.GetString("departement")
            ZoneProduction.Text = $"Zone {nom_zone} {Environment.NewLine}{departement} - {commune}"
            ZoneProduction.Visible = True
        End While
        reader.Close()
    End Sub
    Public Sub Localisation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Localisation.SelectedIndexChanged
        If connection.State = ConnectionState.Closed Then
            Return
        End If
        If connection.State = ConnectionState.Fetching Or connection.State = ConnectionState.Executing Then
            Return
        End If
        ShowZoneUnderLocalite()
        FillMagasin()
    End Sub

    Public Sub FillChoixLocalite()
        Dim query = "Select zone_institution.id_localisation, village  from zone_institution
                     inner join localisation on localisation.id_localisation=zone_institution.id_localisation
                     inner join zone_agro_ecologique on zone_agro_ecologique.id_zone=localisation.id_zone
                     where zone_institution.id_institution=@id_institution"

        FillChoix(query:=query,
                  BindingSourceControl:=LocalisationBindingSource,
                  ChoixControl:=Localisation,
                  valueCol:="id_localisation",
                  displayCol:="village")
    End Sub

    Public Sub FillChoix(query, BindingSourceControl, ChoixControl, valueCol, displayCol)

        Dim command = New MySqlCommand(query, connection)
        command.Parameters.AddWithValue("@id_institution", DBConnection.id_institution)


        Dim adapter = New MySqlDataAdapter(command)
        Dim dataTable = New DataTable()
        adapter.Fill(dataTable)

        BindingSourceControl.DataSource = dataTable

        ChoixControl.ValueMember = dataTable.Columns(valueCol).ToString()
        ChoixControl.DisplayMember = dataTable.Columns(displayCol).ToString()
    End Sub

    Public Sub FillMagasin()
        If connection.State = ConnectionState.Fetching Or connection.State = ConnectionState.Executing Then
            Return
        End If
        Dim query = "SELECT id_magasin, nom_magasin
                        FROM magasin 
                        inner join localisation 
                        on magasin.id_localisation=localisation.id_localisation
                        where (commune=@commune and id_institution=@id_institution)"

        Dim command = New MySqlCommand(query, connection)

        Dim commune = GetCommuneMagasin()

        command.Parameters.AddWithValue("@id_institution", DBConnection.id_institution)
        command.Parameters.AddWithValue("@commune", commune)

        Dim adapter = New MySqlDataAdapter(command)

        Dim dataTable = New DataTable()
        adapter.Fill(dataTable)

        MagasinBindingSource.DataSource = dataTable

        Magasin.DisplayMember = dataTable.Columns("nom_magasin").ToString()
        Magasin.ValueMember = dataTable.Columns("id_magasin").ToString()
    End Sub

    Private Function GetCommuneMagasin()
        Dim getCommune = New MySqlCommand("select commune from localisation where id_localisation=@id_localisation", connection)
        getCommune.Parameters.AddWithValue("@id_localisation", Localisation.SelectedValue)

        Dim reader = getCommune.ExecuteReader()
        Dim commune As String = ""

        While reader.Read()
            commune = reader.GetString(0)
        End While

        reader.Close()
        Return commune
    End Function

    Private Sub FormUpdateProduction_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Me.DialogResult = DialogResult.OK Then
            Return
        End If
        Dim result = MessageBox.Show("Formulaire non sauvegardé." & Environment.NewLine & "Voulez vous vraiment fermer ?", "Annulation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Enregistrer.Click

        If (ChoixVariete.Text Is String.Empty Or QuantiteProduite.Text Is String.Empty Or PrixUnitaire.Text Is String.Empty Or DateProduction.Text Is String.Empty Or Localisation.SelectedValue Is String.Empty Or Magasin.SelectedValue Is String.Empty Or NiveauDeProduction.SelectedValue Is String.Empty) Then
            Dim result = MessageBox.Show("Le formulaire est incomplet!" & Environment.NewLine & "Veuillez remplir tous les champs svp.", "Formulaire incomplet", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        Else
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub

End Class
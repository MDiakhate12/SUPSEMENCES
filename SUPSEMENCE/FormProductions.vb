Imports MySql.Data.MySqlClient
Public Class FormSpeculations

    'Private currentPage As Form = Nothing
    Private connection As MySqlConnection = DBConnection.connection

    Private Sub FormProductions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'SemencesDataSet1.niveau_institution'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.Niveau_institutionTableAdapter.Fill(Me.SemencesDataSet1.niveau_institution)


        Dim newPage = FormStockSpeculation
        newPage.TopLevel = False
        newPage.FormBorderStyle = FormBorderStyle.None
        newPage.Dock = DockStyle.Fill
        EtatStocksSpeculation.Controls.Add(newPage)
        EtatStocksSpeculation.Tag = newPage
        newPage.BringToFront()
        newPage.Visible = True
        newPage.Show()

        LoadChoixSpeculation()
        LoadChoixVariete()
        LoadChoixNiveau()
        LoadProduction()
        LoadStockVariete()
        FillChoixLocalite()
        FillMagasin()
        ShowZoneUnderLocalite()

        DateProduction.MaxDate = DateTime.Now()

        'NavigateTo(FormStockSpeculation, ButtonStockSpeculation)

        DataProduction.Columns("id_production").Visible = False

        NiveauDeProduction.SelectedIndex = NiveauDeProduction.FindStringExact("Prébase")
    End Sub

    Private Sub LoadChoixSpeculation()
        Dim getVarietes = "select nom_speculation, s.id_speculation
                            from speculation_institution si 
                            inner join speculation s 
                            on s.id_speculation=si.id_speculation
                            where id_institution=@id_institution"

        Dim command = New MySqlCommand(getVarietes, connection)
        command.Parameters.AddWithValue("@id_institution", DBConnection.id_institution)
        Dim dataTable = New DataTable()
        Dim dataAdapter = New MySqlDataAdapter(command)
        dataAdapter.Fill(dataTable)
        SpeculationBindingSource.DataSource = dataTable

        ChoixSpéculation.DisplayMember = dataTable.Columns("nom_speculation").ToString()
        ChoixSpéculation.ValueMember = dataTable.Columns("id_speculation").ToString()
    End Sub

    Private Sub LoadChoixVariete()
        Dim getVarietes = "select variete_institution.id_variete_institution, nom_variete 
                            from variete_institution 
                            inner join variete 
                            on variete.id_variete=variete_institution.id_variete 
                            where id_institution=@id_institution and id_speculation=@id_speculation"

        Dim command = New MySqlCommand(getVarietes, connection)
        command.Parameters.AddWithValue("@id_institution", DBConnection.id_institution)
        command.Parameters.AddWithValue("@id_speculation", ChoixSpéculation.SelectedValue)
        Dim dataTable = New DataTable()
        Dim dataAdapter = New MySqlDataAdapter(command)
        dataAdapter.FillAsync(dataTable)
        VarieteBindingSource.DataSource = dataTable
        ChoixVariete.DisplayMember = dataTable.Columns("nom_variete").ToString()
        ChoixVariete.ValueMember = dataTable.Columns("id_variete_institution").ToString()
    End Sub

    Private Sub LoadChoixNiveau()
        Dim getVarietes = "select n.nom_niveau, ni.id_niveau_institution
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
        NiveauDeProduction.ValueMember = dataTable.Columns("id_niveau_institution").ToString()
    End Sub



    Private Sub ShowZoneUnderLocalite()
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

    Private Sub LoadProduction()
        Dim getProduction = "select id_production, nom_variete, nom_speculation, nom_niveau, date_de_production, nom_magasin, departement, quantite_produite, prix_unitaire
                             from production p
                             inner join magasin m on m.id_magasin=p.id_magasin
                             inner join niveau_institution on p.id_niveau_institution=niveau_institution.id_niveau_institution
                             inner join niveau_de_production on niveau_institution.id_niveau=niveau_de_production.id_niveau
                             inner join variete_institution vi on vi.id_variete_institution=p.id_variete_institution
                             inner join variete v on v.id_variete = vi.id_variete
                             inner join speculation s on s.id_speculation = v.id_speculation
                             inner join localisation l on l.id_localisation = p.id_localisation
                             inner join zone_agro_ecologique z on z.id_zone = l.id_zone
                             where vi.id_institution = @id_institution
                             order by id_production desc"


        Dim command = New MySqlCommand(getProduction, connection)

        command.Parameters.AddWithValue("@id_institution", DBConnection.id_institution)

        Dim dataAdapter = New MySqlDataAdapter(command)
        Dim productionTable = New DataTable()
        dataAdapter.Fill(productionTable)
        DataProduction.DataSource = productionTable

    End Sub

    Private Sub LoadStockVariete()
        Dim getProduction = "select nom_variete, nom_speculation, sum(quantite_produite) quantite_produite, sum(quantite_disponible) quantite_disponible, stock_de_securite
                             from production
                             inner join variete_institution on variete_institution.id_variete_institution=production.id_variete_institution
                             inner join variete on variete.id_variete=variete_institution.id_variete
                             inner join speculation on speculation.id_speculation=variete.id_speculation
                             where production.id_institution=@id_institution
                             group by nom_variete"


        Dim command = New MySqlCommand(getProduction, connection)

        command.Parameters.AddWithValue("@id_institution", DBConnection.id_institution)

        Dim dataAdapter = New MySqlDataAdapter(command)
        Dim productionTable = New DataTable()
        dataAdapter.Fill(productionTable)
        DataStockVarieteTab.DataSource = productionTable

    End Sub

    Private Sub Localisation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Localisation.SelectedIndexChanged
        If connection.State = ConnectionState.Closed Then
            Return
        End If
        ShowZoneUnderLocalite()
        FillMagasin()
    End Sub

    Private Sub FillChoixLocalite()
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

    Private Sub FillChoix(query, BindingSourceControl, ChoixControl, valueCol, displayCol)

        Dim command = New MySqlCommand(query, connection)
        command.Parameters.AddWithValue("@id_institution", DBConnection.id_institution)


        Dim adapter = New MySqlDataAdapter(command)
        Dim dataTable = New DataTable()
        adapter.Fill(dataTable)

        BindingSourceControl.DataSource = dataTable

        ChoixControl.ValueMember = dataTable.Columns(valueCol).ToString()
        ChoixControl.DisplayMember = dataTable.Columns(displayCol).ToString()
    End Sub

    Private Sub FillMagasin()
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If Date.Now() < DateProduction.Value Then
            MessageBox.Show("La date de production ne peut pas être supérieure à celle d'aujourd'hui!", "Forumlaire invalide", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If QuantiteProduite.Value <= 0 Or PrixUnitaire.Value <= 0 Then
            MessageBox.Show("La quantité et le prix ne peuvent pas être nuls", "Forumlaire invalide", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim newProduction = "insert into production(date_de_production, quantite_produite, prix_unitaire, id_variete_institution, id_localisation, id_magasin, id_niveau_institution) 
                                values(@date_de_production, @quantite_produite, @prix_unitaire, @id_variete_institution, @id_localisation, @id_magasin, @id_niveau_institution); 
                                select last_insert_id();"

        Dim command = New MySqlCommand(newProduction, connection)

        command.Parameters.AddWithValue("@id_variete_institution", Integer.Parse(ChoixVariete.SelectedValue))
        command.Parameters.AddWithValue("@quantite_produite", QuantiteProduite.Value)
        command.Parameters.AddWithValue("@prix_unitaire", PrixUnitaire.Value)
        command.Parameters.AddWithValue("@date_de_production", DateProduction.Value)
        command.Parameters.AddWithValue("@id_localisation", Localisation.SelectedValue)
        command.Parameters.AddWithValue("@id_magasin", Magasin.SelectedValue)
        command.Parameters.AddWithValue("@id_niveau_institution", NiveauDeProduction.SelectedValue)

        Dim id = command.ExecuteScalar()
        UpdateQuantite(id)

        LoadProduction()
        MessageBox.Show("Ajoutée avec succés!", "Nouvelle production", MessageBoxButtons.OK, MessageBoxIcon.Information)
        QuantiteProduite.Value = 0
        PrixUnitaire.Value = 0

    End Sub

    Private Sub UpdateQuantite(id)
        Dim query = "update production 
                    join variete_institution 
                    on variete_institution.id_variete_institution=production.id_variete_institution 
                    set quantite_disponible=(production.quantite_produite - variete_institution.stock_de_securite) 
                    where id_production=@id_production"
        Dim command = New MySqlCommand(query, connection)
        Dim queryAdapter = New MySqlDataAdapter(command)
        Dim queryTable = New DataTable()

        command.Parameters.AddWithValue("@id_production", id)
        command.ExecuteNonQuery()
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

        Dim fields As New List(Of String) From {"nom_variete", "nom_speculation", "nom_niveau", "nom_magasin", "quantite_produite", "prix_unitaire"}

        Dim queryField As String = GetField(ChoixRecherche, fields, "nom_variete")

        Dim queryValue = Recherche.Text

        Dim query = $"Select id_production, nom_variete, nom_speculation, nom_niveau, date_de_production, nom_magasin, departement, quantite_produite, prix_unitaire
                             From production p
                             inner Join magasin m on m.id_magasin=p.id_magasin
                             Join niveau_institution on p.id_niveau_institution=niveau_institution.id_niveau_institution
                             Join niveau_de_production on niveau_institution.id_niveau=niveau_de_production.id_niveau
                             inner Join variete_institution vi on vi.id_variete_institution=p.id_variete_institution
                             inner Join variete v on v.id_variete = vi.id_variete
                             inner Join speculation s on s.id_speculation = v.id_speculation
                             inner Join localisation l on l.id_localisation = p.id_localisation
                             inner Join zone_agro_ecologique z on z.id_zone = l.id_zone
                             where(vi.id_institution = @id_institution And
                             {queryField} Like '%{queryValue}%')
                             order by id_production desc"

        Rechercher(query, DataProduction)

    End Sub

    Private Function GetField(selector As ComboBox, fields As List(Of String), defaultField As String) As String
        Dim searchField As String = defaultField
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

    Private Sub ClearRechercher_Click(sender As Object, e As EventArgs) Handles ClearRechercher.Click
        If Not Recherche.Text.Equals("") Then
            Recherche.Clear()
        End If
    End Sub

    Private Sub DataProduction_CellMouseUp(sender As DataGridView, e As DataGridViewCellMouseEventArgs) Handles DataProduction.CellMouseUp
        ShowContextMenu(e, contextMenu:=ContextMenuProduction, tableData:=DataProduction)
    End Sub

    Private Sub ShowContextMenu(e As DataGridViewCellMouseEventArgs, contextMenu As ContextMenuStrip, tableData As DataGridView)
        If e.Button = MouseButtons.Right Then
            tableData.ClearSelection()
            tableData.Rows(e.RowIndex).Selected = True
            contextMenu.Show(tableData, e.Location)
            contextMenu.Show(Cursor.Position)
        End If
    End Sub

    Private Sub MenuItemModifier_Click(sender As Object, e As EventArgs) Handles MenuItemModifier.Click
        Dim getProduction = "select p.id_production, p.date_de_production, p.quantite_produite, p.prix_unitaire, p.id_variete_institution, p.id_localisation, p.id_magasin, p.id_niveau_institution
                             from production p
                             inner join magasin m on m.id_magasin=p.id_magasin
                             join niveau_institution ni on p.id_niveau_institution=ni.id_niveau_institution
                             join niveau_de_production n on n.id_niveau=ni.id_niveau
                             inner join variete_institution vi on vi.id_variete_institution=p.id_variete_institution
                             inner join variete v on v.id_variete = vi.id_variete
                             inner join speculation s on s.id_speculation = v.id_speculation
                             inner join localisation l on l.id_localisation = p.id_localisation
                             inner join zone_agro_ecologique z on z.id_zone = l.id_zone
                             where (
                                vi.id_institution = @id_institution and
                                p.id_production=@id_production)"

        Dim command = New MySqlCommand(getProduction, connection)

        Dim currentRow = DataProduction.SelectedRows(0)

        command.Parameters.AddWithValue("@id_institution", DBConnection.id_institution)
        command.Parameters.AddWithValue("@id_production", currentRow.Cells("id_production").Value)

        Dim updateForm = New FormUpdateProduction()
        updateForm.LoadChoixVariete()
        updateForm.LoadChoixNiveau()
        updateForm.FillChoixLocalite()
        updateForm.FillMagasin()
        updateForm.ShowZoneUnderLocalite()
        Dim reader = command.ExecuteReader()
        Dim id
        Dim id_localisation
        While reader.Read()
            updateForm.ChoixVariete.SelectedValue = reader.GetString("id_variete_institution")
            updateForm.QuantiteProduite.Value = reader.GetString("quantite_produite")
            updateForm.PrixUnitaire.Value = reader.GetString("prix_unitaire")
            updateForm.DateProduction.Value = reader.GetString("date_de_production")
            id_localisation = reader.GetString("id_localisation")
            updateForm.Magasin.SelectedValue = reader.GetString("id_magasin")
            updateForm.NiveauDeProduction.SelectedValue = reader.GetString("id_niveau_institution")
            id = reader.GetInt16("id_production")
        End While
        reader.Close()
        updateForm.Localisation.SelectedValue = id_localisation
        Dim result = updateForm.ShowDialog()

        If result = DialogResult.OK Then
            UpdateProduction(
            id,
            updateForm.QuantiteProduite.Value,
            updateForm.PrixUnitaire.Value,
            updateForm.Localisation.SelectedValue,
            updateForm.Magasin.SelectedValue
            )
            MessageBox.Show("Modifiée avec succés!", "Modification production", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LoadProduction()
        End If


    End Sub

    Private Sub UpdateProduction(id, QuantiteProduite, PrixUnitaire, Localisation, Magasin)
        Dim query = "update production 
                    join variete_institution 
                    on variete_institution.id_variete_institution=production.id_variete_institution 
                    set 
                        quantite_produite=@quantite_produite,
                        quantite_disponible=(@quantite_produite - variete_institution.stock_de_securite),
                        prix_unitaire=@prix_unitaire,
                        id_localisation=@id_localisation,
                        id_magasin=@id_magasin
                    where id_production=@id_production"
        Dim command = New MySqlCommand(query, connection)
        Dim queryAdapter = New MySqlDataAdapter(command)
        Dim queryTable = New DataTable()


        command.Parameters.AddWithValue("@id_production", id)
        command.Parameters.AddWithValue("@quantite_produite", QuantiteProduite)
        command.Parameters.AddWithValue("@prix_unitaire", PrixUnitaire)
        command.Parameters.AddWithValue("@id_localisation", Localisation)
        command.Parameters.AddWithValue("@id_magasin", Magasin)
        command.ExecuteNonQuery()
    End Sub

    Private Sub SupprimerMenuItem_Click(sender As Object, e As EventArgs) Handles SupprimerMenuItem.Click
        Supprimer(tableName:="production", tableData:=DataProduction, idName:="id_production", errorMessage:=AddressOf ProductionDeleteError)
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

                DataProduction.Rows.RemoveAt(currentRow.Index)

                MessageBox.Show("Supprimé avec succés", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As MySqlException
                If ex.Number = 1451 Then
                    errorMessage()
                End If
                Return
            End Try

        End If
    End Sub

    Private Sub ProductionDeleteError()
        MessageBox.Show("Cette production possède actuellement des commandes en cours.", "Suppression impossible", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub Magasin_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Magasin.SelectedIndexChanged

    End Sub

    Private Sub ChoixSpéculation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ChoixSpéculation.SelectedIndexChanged
        LoadChoixVariete()
    End Sub

    Private Sub ClearRechercher_Click_1(sender As Object, e As EventArgs) Handles ClearRechercher.Click

    End Sub
End Class
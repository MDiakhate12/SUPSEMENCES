Imports LiveCharts
Imports LiveCharts.Wpf
Imports MySql.Data.MySqlClient

Public Class FormRapports
    Private connection As MySqlConnection = DBConnection.connection
    Private CurrentCommandeCheckedList As CheckedListBox = New CheckedListBox()
    Private CurrentProductionCheckedList As CheckedListBox = New CheckedListBox()
    Private CurrentClientCheckedList As CheckedListBox = New CheckedListBox()
    Private CurrentLocaliteCheckedList As CheckedListBox = New CheckedListBox()
    Private CurrentNiveauCheckedList As CheckedListBox = New CheckedListBox()
    Private CurrentGenVarieteCheckedList As CheckedListBox = New CheckedListBox()
    Private CurrentGenClientCheckedList As CheckedListBox = New CheckedListBox()
    Private CurrentGenLocaliteCheckedList As CheckedListBox = New CheckedListBox()
    Private CurrentGenNiveauCheckedList As CheckedListBox = New CheckedListBox()

    Private Sub FormRapports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'SemencesDataSet.commande'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        'Me.CommandeTableAdapter.Fill(Me.SemencesDataSet.commande)
        LoadSpeculationChart()
        FillSpeculationInstitution()

        LoadVarieteChart()
        LoadVarieteProductionChart()
        LoadCommandeProductionChart()

        FillVarieteCheckBoxList()
        FillClientCheckBoxList(selector:=NomSpeculationCommande, checkedList:=ClientCommandeCheckedList, currentCheckedList:=CurrentClientCheckedList)

        FillVarieteProductionCheckBoxList(selector:=NomSpeculationProduction, checkedList:=VarieteProductionCheckedList, currentCheckedList:=CurrentProductionCheckedList)
        FillLocaliteProductionCheckedList(selector:=NomSpeculationProduction, checkedList:=LocaliteCheckedList, currentCheckedList:=CurrentLocaliteCheckedList)
        FillNiveauCheckedList(selector:=NomSpeculationProduction, checkedList:=NiveauCheckedList, currentCheckedList:=CurrentNiveauCheckedList)

        FillVarieteProductionCheckBoxList(selector:=NomSpeculationGen, checkedList:=GenVarieteCheckedList, currentCheckedList:=CurrentGenVarieteCheckedList)
        FillLocaliteProductionCheckedList(selector:=NomSpeculationGen, checkedList:=GenLocaliteCheckedList, currentCheckedList:=CurrentGenLocaliteCheckedList)
        FillNiveauCheckedList(selector:=NomSpeculationGen, checkedList:=GenNiveauCheckedList, currentCheckedList:=CurrentGenNiveauCheckedList)
        FillClientCheckBoxList(selector:=NomSpeculationGen, checkedList:=GenClientCheckedList, currentCheckedList:=CurrentGenClientCheckedList)




        DateDebut.MaxDate = DateTime.Now()
        DateFin.MaxDate = DateTime.Now()

        DateDebutProduction.MaxDate = DateTime.Now()
        DateFinProduction.MaxDate = DateTime.Now()

        DateDebutGen.MaxDate = DateTime.Now()
        DateFinGen.MaxDate = DateTime.Now()

    End Sub

    Private Sub FillSpeculationInstitution()
        Dim query = "select speculation.nom_speculation, speculation.id_speculation, id_speculation_institution 
                        from speculation_institution 
                        inner join speculation on speculation_institution.id_speculation = speculation.id_speculation 
                        where id_institution = @id_institution"

        Dim command = New MySqlCommand(query, connection)
        command.Parameters.AddWithValue("@id_institution", DBConnection.id_institution)

        Dim commandAdapter = New MySqlDataAdapter(command)

        Dim dataTable = New DataTable()
        commandAdapter.Fill(dataTable)

        SpeculationBindingSource.DataSource = dataTable

        NomSpeculationCommande.DisplayMember = dataTable.Columns("nom_speculation").ToString()
        NomSpeculationCommande.ValueMember = dataTable.Columns("id_speculation").ToString()

        NomSpeculationProduction.DisplayMember = dataTable.Columns("nom_speculation").ToString()
        NomSpeculationProduction.ValueMember = dataTable.Columns("id_speculation").ToString()

        NomSpeculationGen.DisplayMember = dataTable.Columns("nom_speculation").ToString()
        NomSpeculationGen.ValueMember = dataTable.Columns("id_speculation").ToString()
    End Sub

    Private Sub FillClientCheckBoxList(checkedList, currentCheckedList, Optional selector = Nothing)
        Dim query = "select distinct nom_complet_structure 
                     from commande c 
                     inner join client cl on cl.id_client = c.id_client 
                     inner join production p on p.id_production=c.id_production
                     inner join variete_institution vi on vi.id_variete_institution=p.id_variete_institution
                     inner join variete v on v.id_variete=vi.id_variete
                     where p.id_institution=@id_institution and id_speculation=@id_speculation"
        'inner join variete_institution vi on vi.id_variete_institution=p.id_variete_institution
        'inner join variete v on v.id_variete=vi.id_variete
        'and id_speculation=@id_speculation


        FillCheckedList(
            query:=query,
            selector:=selector,
            checkedList:=checkedList,
            currentCheckedList:=currentCheckedList,
            columnName:="nom_complet_structure",
            defaultState:=False
            )
    End Sub

    Private Sub FillVarieteCheckBoxList()
        Dim query = "select distinct nom_variete 
                     from commande c 
                     inner join production p on p.id_production=c.id_production
                     inner join variete_institution vi on vi.id_variete_institution=p.id_variete_institution
                     inner join variete v on v.id_variete=vi.id_variete
                     where vi.id_institution=@id_institution and id_speculation=@id_speculation"

        FillCheckedList(
            query:=query,
            selector:=NomSpeculationCommande,
            checkedList:=VarieteCommandeCheckedList,
            currentCheckedList:=CurrentCommandeCheckedList
            )
    End Sub



    Private Sub FillVarieteProductionCheckBoxList(checkedList As CheckedListBox, currentCheckedList As CheckedListBox, Optional selector As ComboBox = Nothing)
        Dim query = "select distinct nom_variete 
                     from production p
                     inner join variete_institution vi on vi.id_variete_institution=p.id_variete_institution
                     inner join variete v on v.id_variete=vi.id_variete
                     where vi.id_institution=@id_institution and id_speculation=@id_speculation"

        FillCheckedList(
            query:=query,
            selector:=selector,
            checkedList:=checkedList,
            currentCheckedList:=currentCheckedList
            )
    End Sub

    Private Sub FillLocaliteProductionCheckedList(checkedList, currentCheckedList, Optional selector = Nothing)
        Dim query = "select distinct village 
                     from production p
                     inner join localisation l on l.id_localisation=p.id_localisation
                     inner join variete_institution vi on vi.id_variete_institution=p.id_variete_institution
                     inner join variete v on v.id_variete=vi.id_variete
                     where vi.id_institution=@id_institution and id_speculation=@id_speculation"

        FillCheckedList(
            query:=query,
            selector:=selector,
            checkedList:=checkedList,
            currentCheckedList:=currentCheckedList,
            columnName:="village"
            )
    End Sub

    Private Sub FillNiveauCheckedList(checkedList, currentCheckedList, Optional selector = Nothing)
        Dim query = "select distinct nom_niveau 
                     from production p 
                     inner join niveau_institution ni on ni.id_niveau_institution=p.id_niveau_institution
                     inner join niveau_de_production n on n.id_niveau=ni.id_niveau
                     inner join variete_institution vi on vi.id_variete_institution=p.id_variete_institution
                     inner join variete v on v.id_variete=vi.id_variete
                     where p.id_institution=@id_institution and id_speculation=@id_speculation"

        FillCheckedList(
            query:=query,
            selector:=selector,
            checkedList:=checkedList,
            currentCheckedList:=currentCheckedList,
            columnName:="nom_niveau"
            )
    End Sub
    Private Sub FillCheckedList(query As String, checkedList As CheckedListBox, currentCheckedList As CheckedListBox, Optional columnName As String = "nom_variete", Optional defaultState As Boolean = True, Optional selector As ComboBox = Nothing)
        If connection.State = ConnectionState.Closed Then
            Return
        End If

        Dim command = New MySqlCommand(query, connection)

        command.Parameters.AddWithValue("@id_institution", DBConnection.id_institution)
        If selector IsNot Nothing Then
            command.Parameters.AddWithValue("@id_speculation", selector.SelectedValue)
        End If


        Dim reader = command.ExecuteReader()

        checkedList.Items.Clear()
        currentCheckedList.Items.Clear()

        While reader.Read()
            checkedList.Items.Add(reader.GetString(columnName), defaultState)
            currentCheckedList.Items.Add(reader.GetString(columnName), defaultState)
        End While
        reader.Close()

    End Sub

    Private Function CheckedLessThanItems(CheckedList As CheckedListBox)
        If CheckedList.Name.Contains("Client") Then
            Return CheckedList.CheckedItems.Count >= 0 And CheckedList.CheckedItems.Count <= CheckedList.Items.Count
        End If
        Return CheckedList.CheckedItems.Count >= 1 And CheckedList.CheckedItems.Count <= CheckedList.Items.Count
    End Function
    Private Sub LoadVarieteChart()
        Dim getVarieteCommandeeTable = $"select nom_variete, sum(quantite) quantite, nom_complet_structure client, est_enlevee livré
                                    from commande c
                                    inner join production p on p.id_production=c.id_production
                                    inner join variete_institution vi on vi.id_variete_institution=p.id_variete_institution
                                    inner join variete v on v.id_variete=vi.id_variete
                                    inner join client cl on cl.id_client = c.id_client 
                                    where (p.id_institution=@id_institution and v.id_speculation=@nom_speculation) group by nom_variete"

        Dim getVarieteCommandee = $"select id_speculation, nom_variete, sum(quantite) quantite
                                    from commande c
                                    inner join production p on p.id_production=c.id_production
                                    inner join variete_institution vi on vi.id_variete_institution=p.id_variete_institution
                                    inner join variete v on v.id_variete=vi.id_variete
                                    inner join client cl on cl.id_client = c.id_client 
                                    where (p.id_institution=@id_institution and v.id_speculation=@nom_speculation) group by nom_variete"

        Dim getVarieteLivree = $"select id_speculation, nom_variete, sum(quantite) quantite 
                                from commande c
                                inner join production p on p.id_production=c.id_production
                                inner join variete_institution vi on vi.id_variete_institution=p.id_variete_institution
                                inner join variete v on v.id_variete=vi.id_variete 
                                    inner join client cl on cl.id_client = c.id_client 
                                where (p.id_institution=@id_institution and v.id_speculation=@nom_speculation and c.est_enlevee=1) group by nom_variete"

        If CheckedLessThanItems(CurrentCommandeCheckedList) Then

            getVarieteCommandeeTable = $"select nom_variete, sum(quantite) quantite, nom_complet_structure client, est_enlevee livré
                                    from commande c
                                    inner join production p on p.id_production=c.id_production
                                    inner join variete_institution vi on vi.id_variete_institution=p.id_variete_institution
                                    inner join variete v on v.id_variete=vi.id_variete
                     inner join client cl on cl.id_client = c.id_client 
                                    where (p.id_institution=@id_institution and v.id_speculation=@nom_speculation and
                                           nom_variete in ({GetCheckedValues(CurrentCommandeCheckedList)})
                                           ) 
                                           group by nom_variete"

            getVarieteCommandee = $"select id_speculation, nom_variete, sum(quantite) quantite
                                    from commande c
                                    inner join production p on p.id_production=c.id_production
                                    inner join variete_institution vi on vi.id_variete_institution=p.id_variete_institution
                                    inner join variete v on v.id_variete=vi.id_variete
                     inner join client cl on cl.id_client = c.id_client 
                                    where (p.id_institution=@id_institution and v.id_speculation=@nom_speculation and
                                           nom_variete in ({GetCheckedValues(CurrentCommandeCheckedList)})
                                           ) 
                                           group by nom_variete"

            getVarieteLivree = $"select id_speculation, nom_variete, sum(quantite) quantite 
                                from commande c
                                inner join production p on p.id_production=c.id_production
                                inner join variete_institution vi on vi.id_variete_institution=p.id_variete_institution
                                inner join variete v on v.id_variete=vi.id_variete 
                     inner join client cl on cl.id_client = c.id_client 
                                where (p.id_institution=@id_institution and v.id_speculation=@nom_speculation and c.est_enlevee=1 and
                                           nom_variete in ({GetCheckedValues(CurrentCommandeCheckedList)})
                                           ) 
                                           group by nom_variete"

            If FiltrerParDate.Checked Then
                getVarieteCommandeeTable = InsertDateFilter(getVarieteCommandeeTable, "date_expression_besoin_client", DateDebut, DateFin)
                getVarieteCommandee = InsertDateFilter(getVarieteCommandee, "date_expression_besoin_client", DateDebut, DateFin)
                getVarieteLivree = InsertDateFilter(getVarieteLivree, "date_expression_besoin_client", DateDebut, DateFin)
            End If

            'MessageBox.Show(GetCheckedValues())
        End If
        If CheckedLessThanItems(CurrentClientCheckedList) Then
            getVarieteCommandeeTable = InsertClientFilter(getVarieteCommandeeTable, CurrentClientCheckedList)
            getVarieteCommandee = InsertClientFilter(getVarieteCommandee, CurrentClientCheckedList)
            getVarieteLivree = InsertClientFilter(getVarieteLivree, CurrentClientCheckedList)
        End If


        FillChart(VarieteCommandeLivraisonChart, getVarieteCommandee, getVarieteLivree, "Quantité commandée en KG", "Quantité livrée en KG", "nom_variete", "quantite", fromCommandeChart:=True)

        FillTable(query:=getVarieteCommandeeTable, Table:=DataCommandeLivraison, selector:=NomSpeculationCommande)
    End Sub

    Private Sub LoadVarieteProductionChart()
        Dim getVarieteProduiteTable = $"select p.id_production, id_speculation, nom_variete, sum(quantite_produite - stock_de_securite) quantite_produite, village localite, nom_niveau
                                    from production p
                                    inner join localisation l on l.id_localisation=p.id_localisation
                                    inner join niveau_institution ni on ni.id_niveau_institution=p.id_niveau_institution
                                    inner join niveau_de_production n on n.id_niveau=ni.id_niveau
                                    inner join variete_institution vi on vi.id_variete_institution=p.id_variete_institution
                                    inner join variete v on v.id_variete=vi.id_variete
                                    where (p.id_institution=@id_institution and v.id_speculation=@nom_speculation) group by nom_variete"

        Dim getVarieteProduite = $"select p.id_production, id_speculation, nom_variete, sum(quantite_produite - stock_de_securite) quantite_produite, village localite, nom_niveau
                                    from production p
                                    inner join localisation l on l.id_localisation=p.id_localisation
                                    inner join niveau_institution ni on ni.id_niveau_institution=p.id_niveau_institution
                                    inner join niveau_de_production n on n.id_niveau=ni.id_niveau
                                    inner join variete_institution vi on vi.id_variete_institution=p.id_variete_institution
                                    inner join variete v on v.id_variete=vi.id_variete
                                    where (p.id_institution=@id_institution and v.id_speculation=@nom_speculation) group by nom_variete"


        'If (CheckedLessThanItems(CurrentProductionCheckedList) And
        '    CheckedLessThanItems(CurrentLocaliteCheckedList) And
        '    CheckedLessThanItems(CurrentNiveauCheckedList)) Then

        '    getVarieteProduiteTable = $"select p.id_production, id_speculation, nom_variete, sum(quantite_produite - stock_de_securite) quantite_produite, village localite, nom_niveau
        '                            from production p
        '                            inner join localisation l on l.id_localisation=p.id_localisation
        '                            inner join niveau_institution ni on ni.id_niveau_institution=p.id_niveau_institution
        '                            inner join niveau_de_production n on n.id_niveau=ni.id_niveau
        '                            inner join variete_institution vi on vi.id_variete_institution=p.id_variete_institution
        '                            inner join variete v on v.id_variete=vi.id_variete
        '                            where (
        '                                   p.id_institution=@id_institution and v.id_speculation=@nom_speculation and
        '                                   nom_variete in ({GetCheckedValues(CurrentProductionCheckedList)}) and
        '                                   village in ({GetCheckedValues(CurrentLocaliteCheckedList)}) and
        '                                   nom_niveau in ({GetCheckedValues(CurrentNiveauCheckedList)})
        '                                   )
        '                                   group by nom_variete"

        '    getVarieteProduite = $"select p.id_production, id_speculation, nom_variete, sum(quantite_produite - stock_de_securite) quantite_produite, village localite, nom_niveau
        '                            from production p
        '                            inner join localisation l on l.id_localisation=p.id_localisation
        '                            inner join niveau_institution ni on ni.id_niveau_institution=p.id_niveau_institution
        '                            inner join niveau_de_production n on n.id_niveau=ni.id_niveau
        '                            inner join variete_institution vi on vi.id_variete_institution=p.id_variete_institution
        '                            inner join variete v on v.id_variete=vi.id_variete
        '                            where (
        '                                   p.id_institution=@id_institution and v.id_speculation=@nom_speculation and
        '                                   nom_variete in ({GetCheckedValues(CurrentProductionCheckedList)}) and
        '                                   village in ({GetCheckedValues(CurrentLocaliteCheckedList)}) and
        '                                   nom_niveau in ({GetCheckedValues(CurrentNiveauCheckedList)})
        '                                   ) 
        '                                   group by nom_variete"

        If CheckedLessThanItems(CurrentProductionCheckedList) Then
            getVarieteProduiteTable = InsertFilter(getVarieteProduiteTable, CurrentProductionCheckedList, "nom_variete")
            getVarieteProduite = InsertFilter(getVarieteProduite, CurrentProductionCheckedList, "nom_variete")
        End If
        If CheckedLessThanItems(CurrentLocaliteCheckedList) Then
            getVarieteProduiteTable = InsertFilter(getVarieteProduiteTable, CurrentLocaliteCheckedList, "village")
            getVarieteProduite = InsertFilter(getVarieteProduite, CurrentLocaliteCheckedList, "village")
        End If
        If CheckedLessThanItems(CurrentNiveauCheckedList) Then
            getVarieteProduiteTable = InsertFilter(getVarieteProduiteTable, CurrentNiveauCheckedList, "nom_niveau")
            getVarieteProduite = InsertFilter(getVarieteProduite, CurrentNiveauCheckedList, "nom_niveau")
        End If

        If FiltrerParDateProduction.Checked Then
                getVarieteProduiteTable = InsertDateFilter(getVarieteProduiteTable, "date_de_production", DateDebutProduction, DateFinProduction)
                getVarieteProduite = InsertDateFilter(getVarieteProduite, "date_de_production", DateDebutProduction, DateFinProduction)
            End If

        'MessageBox.Show(GetCheckedValues(CurrentNiveauCheckedList))


        FillChart(VarieteProductionCommandeChart, getVarieteProduite, "", "Quantité produite en KG", "", "nom_variete", "quantite_produite", fromProductionChart:=True)

        FillTable(query:=getVarieteProduiteTable, Table:=DataVarieteProduction, selector:=NomSpeculationProduction)


    End Sub

    Private Sub LoadCommandeProductionChart()

        Dim getCommandeProductionTable = $"select p.id_production, nom_variete, sum(quantite_produite - stock_de_securite) quantite, village localite, nom_niveau
                                        from production p
                                        inner join localisation l on l.id_localisation=p.id_localisation
                                        inner join niveau_institution ni on ni.id_niveau_institution=p.id_niveau_institution
                                        inner join niveau_de_production n on n.id_niveau=ni.id_niveau
                                        inner join variete_institution vi on vi.id_variete_institution=p.id_variete_institution
                                        inner join variete v on v.id_variete=vi.id_variete
                                        where (
                                        p.id_institution=@id_institution and v.id_speculation=@nom_speculation )
                                        group by p.id_production"

        Dim getVarieteProduite = $"select p.id_production, id_speculation, nom_variete, sum(quantite_produite - stock_de_securite) quantite, village localite, nom_niveau
                                    from production p
                                    inner join localisation l on l.id_localisation=p.id_localisation
                                    inner join niveau_institution ni on ni.id_niveau_institution=p.id_niveau_institution
                                    inner join niveau_de_production n on n.id_niveau=ni.id_niveau
                                    inner join variete_institution vi on vi.id_variete_institution=p.id_variete_institution
                                    inner join variete v on v.id_variete=vi.id_variete
                                    where (p.id_institution=@id_institution and v.id_speculation=@nom_speculation) group by nom_variete"

        Dim getVarieteCommandee = $"select id_speculation, nom_variete, sum(quantite) quantite
                                    from commande c
                                    inner join production p on p.id_production=c.id_production
                                    inner join variete_institution vi on vi.id_variete_institution=p.id_variete_institution
                                    inner join variete v on v.id_variete=vi.id_variete
                                    where (p.id_institution=@id_institution and v.id_speculation=@nom_speculation) group by nom_variete"

        If CheckedLessThanItems(CurrentGenVarieteCheckedList) And
            CheckedLessThanItems(CurrentGenLocaliteCheckedList) And
            CheckedLessThanItems(CurrentGenNiveauCheckedList) Then

            getCommandeProductionTable = $"select p.id_production, nom_variete, sum(quantite_produite - stock_de_securite) quantite, village localite, nom_niveau
                                        from production p
                                        inner join localisation l on l.id_localisation=p.id_localisation
                                        inner join niveau_institution ni on ni.id_niveau_institution=p.id_niveau_institution
                                        inner join niveau_de_production n on n.id_niveau=ni.id_niveau
                                        inner join variete_institution vi on vi.id_variete_institution=p.id_variete_institution
                                        inner join variete v on v.id_variete=vi.id_variete
                                        where (
                                        p.id_institution=@id_institution and v.id_speculation=@nom_speculation and
                                        nom_variete in ({GetCheckedValues(CurrentGenVarieteCheckedList)}) and
                                        village in ({GetCheckedValues(CurrentGenLocaliteCheckedList)}) and
                                        nom_niveau in ({GetCheckedValues(CurrentGenNiveauCheckedList)})
                                        )
                                        group by p.id_production"

            getVarieteProduite = $"select p.id_production, id_speculation, nom_variete, sum(quantite_produite - stock_de_securite) quantite, village localite, nom_niveau
                                        from production p
                                        inner join localisation l on l.id_localisation=p.id_localisation
                                        inner join niveau_institution ni on ni.id_niveau_institution=p.id_niveau_institution
                                        inner join niveau_de_production n on n.id_niveau=ni.id_niveau
                                        inner join variete_institution vi on vi.id_variete_institution=p.id_variete_institution
                                        inner join variete v on v.id_variete=vi.id_variete
                                        where (
                                        p.id_institution=@id_institution and v.id_speculation=@nom_speculation and
                                        nom_variete in ({GetCheckedValues(CurrentGenVarieteCheckedList)}) and
                                        village in ({GetCheckedValues(CurrentGenLocaliteCheckedList)}) and
                                        nom_niveau in ({GetCheckedValues(CurrentGenNiveauCheckedList)})
                                        )
                                        group by nom_variete"
            'where (
            '       p.id_institution=@id_institution and v.id_speculation=@nom_speculation and
            '       nom_variete in ({GetCheckedValues(CurrentGenVarieteCheckedList)}) and
            '       village in ({GetCheckedValues(CurrentGenLocaliteCheckedList)}) and
            '       nom_niveau in ({GetCheckedValues(CurrentGenNiveauCheckedList)}) and
            '       nom_complet_structure in ({GetCheckedValues(CurrentGenClientCheckedList)})
            '       ) 
            '       group by nom_variete

            getVarieteCommandee = $"select p.id_production, id_speculation, nom_variete, sum(quantite) quantite, village localite, nom_niveau
                                        from commande c
                                        inner join production p on p.id_production=c.id_production
                                        inner join localisation l on l.id_localisation=p.id_localisation
                                        inner join niveau_institution ni on ni.id_niveau_institution=p.id_niveau_institution
                                        inner join niveau_de_production n on n.id_niveau=ni.id_niveau
                                        inner join variete_institution vi on vi.id_variete_institution=p.id_variete_institution
                                        inner join variete v on v.id_variete=vi.id_variete
                                        inner join client cl on cl.id_client = c.id_client 
                                        where (
                                        p.id_institution=@id_institution and v.id_speculation=@nom_speculation and
                                        nom_variete in ({GetCheckedValues(CurrentGenVarieteCheckedList)}) and
                                        village in ({GetCheckedValues(CurrentGenLocaliteCheckedList)}) and
                                        nom_niveau in ({GetCheckedValues(CurrentGenNiveauCheckedList)}) 
                                        ) 
                                               group by nom_variete"

            If FiltrerParDateGen.Checked Then
                getCommandeProductionTable = InsertDateFilter(getCommandeProductionTable, "date_de_production", DateDebutGen, DateFinGen)
                getVarieteProduite = InsertDateFilter(getVarieteProduite, "date_de_production", DateDebutGen, DateFinGen)
                getVarieteCommandee = InsertDateFilter(getVarieteCommandee, "date_expression_besoin_client", DateDebutGen, DateFinGen)
            End If
        End If

        If CheckedLessThanItems(CurrentGenClientCheckedList) Then
            getCommandeProductionTable = InsertClientFilter(getCommandeProductionTable, CurrentGenClientCheckedList)
            getVarieteCommandee = InsertClientFilter(getVarieteCommandee, CurrentGenClientCheckedList)
        End If
        FillChart(CommandeProductionChart, getVarieteProduite, getVarieteCommandee, "Quantité produite en KG", "Quantité commandée en KG", "nom_variete", "quantite")
        FillTable(query:=getCommandeProductionTable, Table:=DataCommandeProduction, selector:=NomSpeculationGen)

    End Sub

    Private Sub UpdateTitle(selector As ComboBox, chart As DataVisualization.Charting.Chart, Optional titleName As String = "Title3", Optional defaultTitle As String = "Variétés")
        Try
            Dim speculation = selector.Text
            If speculation.Length > 1 Then
                chart.Titles.FindByName(titleName).Text = speculation.Substring(0, 1).ToUpper() + speculation.Substring(1).ToLower()
            End If
        Catch ex As Exception
            chart.Titles.FindByName(titleName).Text = defaultTitle
        End Try
    End Sub

    Private Function InsertClientFilter(query As String, CurrentCheckedList As CheckedListBox, Optional clientColumnName As String = "nom_complet_structure")
        Return query.Insert(query.LastIndexOf(")"), $" and {clientColumnName} in ({GetCheckedValues(CurrentCheckedList)}) ")
    End Function
    Private Function InsertFilter(query As String, CurrentCheckedList As CheckedListBox, columnName As String)
        Return query.Insert(query.LastIndexOf(")"), $" and {columnName} in ({GetCheckedValues(CurrentCheckedList)}) ")
    End Function
    Private Function InsertDateFilter(query As String, dateColumnName As String, StartDate As DateTimePicker, EndDate As DateTimePicker)
        Return query.Insert(query.LastIndexOf(")"), $" and {dateColumnName} between '{StartDate.Text}' and '{EndDate.Text}' ")
    End Function
    'Private Sub DisplayMap()

    '    'Dim geoMap = New LiveCharts.WinForms.GeoMap()

    '    'Dim keyValues As New Dictionary(Of String, Double)

    '    'keyValues.Add("6977", 1179) 'Sédhiou
    '    ''keyValues.Add("6976", 85) 'Kédougou
    '    'keyValues.Add("6978", 7384) 'Kaffrine
    '    ''keyValues.Add("6975", 0) 'Saint Louis
    '    'keyValues.Add("1178", 29046) 'Dakar
    '    'keyValues.Add("1179", 2233) 'Diourbel
    '    'keyValues.Add("1180", 25233) 'Fatick
    '    'keyValues.Add("1181", 233) 'Kaolack
    '    'keyValues.Add("1182", 2523) 'Louga
    '    ''keyValues.Add("1183", 5233) 'Matam
    '    'keyValues.Add("1184", 9849) 'Thiès
    '    'keyValues.Add("680", 3579) 'Kolda
    '    'keyValues.Add("681", 1179) 'Ziguinchor
    '    'keyValues.Add("682", 81285) 'Tambacounda

    '    GeoMap.HeatMap = keyValues

    '    geoMap.Source = $"{Application.StartupPath}\Senegal.xml"
    '    Me.Controls.Add(geoMap)
    '    geoMap.Dock = DockStyle.Fill
    'End Sub

    Private Sub LoadSpeculationChart()
        Dim getProduction = $"select nom_speculation, sum(quantite_produite) quantite
                             from production p
                             inner join variete_institution vi on vi.id_variete_institution=p.id_variete_institution
                             inner join variete v on v.id_variete = vi.id_variete
                             inner join speculation s on s.id_speculation = v.id_speculation
                             where vi.id_institution = @id_institution 
                             group by nom_speculation"

        Dim fontSize As Double = 22
        Dim command = New MySqlCommand(getProduction, connection)

        command.Parameters.AddWithValue("@id_institution", DBConnection.id_institution)

        Dim values = New ChartValues(Of Integer)
        Dim labels = New List(Of String)

        Dim reader = command.ExecuteReader()

        While reader.Read()
            values.Add(reader.GetInt64("quantite"))
            labels.Add($"{reader.GetString("nom_speculation")}")
        End While


        'CartesianChart1.Series = New SeriesCollection From {
        '        New ColumnSeries With {
        '            .Title = "",
        '            .Values = values,
        '            .FontSize = fontSize
        '        }
        '    }

        'CartesianChart1.AxisX.Add(New Axis With {
        '        .Title = "Spéculation",
        '        .Labels = labels,
        '        .FontSize = fontSize
        '    })
        'CartesianChart1.AxisY.Add(New Axis With {
        '        .Title = "Quantite produite (en KG)",
        '        .FontSize = fontSize
        '    })


        reader.Close()
    End Sub
    Private Sub InitChart(chart As DataVisualization.Charting.Chart, serieName1 As String, serieName2 As String)
        chart.Series(serieName1).LabelForeColor = chart.Series(serieName1).Color

        For Each title In chart.Titles
            title.ForeColor = Color.DimGray
        Next

        chart.ChartAreas(0).AxisX.MajorGrid.LineWidth = 0
        chart.ChartAreas(0).AxisY.MajorGrid.LineWidth = 0

        If serieName2 = "" Then
            Return
        End If

        chart.Series(serieName2).LabelForeColor = chart.Series(serieName2).Color


    End Sub

    Private Sub FillChartSeries(chart As DataVisualization.Charting.Chart, query As String, seriesName As String, keyName As String, valueName As String, Optional fromCommandeChart As Boolean = False, Optional fromProductionChart As Boolean = False)
        If connection.State = ConnectionState.Closed Then
            Return
        End If

        Dim command = New MySqlCommand(query, connection)

        command.Parameters.AddWithValue("@id_institution", DBConnection.id_institution)

        If fromCommandeChart = False And fromProductionChart = False Then
            command.Parameters.AddWithValue("@nom_speculation", NomSpeculationGen.SelectedValue)
        End If
        If fromProductionChart = True Then
            fromCommandeChart = False
            command.Parameters.AddWithValue("@nom_speculation", NomSpeculationProduction.SelectedValue)
            'MessageBox.Show($"FROM PRODUCTION {fromProductionChart}")
        End If

        If fromCommandeChart = True Then
            fromProductionChart = False
            command.Parameters.AddWithValue("@nom_speculation", NomSpeculationCommande.SelectedValue)
            'MessageBox.Show($"FROM COMMANDE {fromCommandeChart}")
        End If

        Dim reader = command.ExecuteReader()

        chart.Series(seriesName).Points.Clear()
        While reader.Read()
            chart.Series(seriesName).Points.AddXY($"{reader.GetString(keyName)}", reader.GetUInt64(valueName))
        End While
        reader.Close()
    End Sub

    Private Sub FillTable(query As String, Table As DataGridView, selector As ComboBox)
        If connection.State = ConnectionState.Closed Then
            Return
        End If

        Dim command = New MySqlCommand(query, connection)

        command.Parameters.AddWithValue("@id_institution", DBConnection.id_institution)
        command.Parameters.AddWithValue("@nom_speculation", selector.SelectedValue)

        Dim commandAdapter = New MySqlDataAdapter(command)

        Dim dataTable = New DataTable()
        commandAdapter.Fill(dataTable)

        Table.DataSource = dataTable
    End Sub

    Private Sub FillChart(chart As DataVisualization.Charting.Chart, query1 As String, query2 As String, seriesName1 As String, seriesName2 As String, keyName As String, valueName As String, Optional fromCommandeChart As Boolean = False, Optional fromProductionChart As Boolean = False)
        InitChart(chart, seriesName1, seriesName2)

        FillChartSeries(
            chart:=chart,
            query:=query1,
            seriesName:=seriesName1,
            keyName:=keyName,
            valueName:=valueName,
            fromCommandeChart:=fromCommandeChart,
            fromProductionChart:=fromProductionChart
            )

        If seriesName2 = "" Then
            Return
        End If

        FillChartSeries(
            chart:=chart,
            query:=query2,
            seriesName:=seriesName2,
            keyName:=keyName,
            valueName:=valueName,
            fromCommandeChart:=fromCommandeChart,
            fromProductionChart:=fromProductionChart
            )

    End Sub



    Private Sub NomSpeculation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NomSpeculationCommande.SelectedIndexChanged
        'Try
        FillVarieteCheckBoxList()
        FillClientCheckBoxList(selector:=NomSpeculationCommande, checkedList:=ClientCommandeCheckedList, currentCheckedList:=CurrentClientCheckedList)

        UpdateTitle(NomSpeculationCommande, VarieteCommandeLivraisonChart)

        LoadVarieteChart()
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub NomSpeculationProduction_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NomSpeculationProduction.SelectedIndexChanged
        'Try
        FillVarieteProductionCheckBoxList(selector:=NomSpeculationProduction, checkedList:=VarieteProductionCheckedList, currentCheckedList:=CurrentProductionCheckedList)
        FillLocaliteProductionCheckedList(selector:=NomSpeculationProduction, checkedList:=LocaliteCheckedList, currentCheckedList:=CurrentLocaliteCheckedList)
        FillNiveauCheckedList(selector:=NomSpeculationProduction, checkedList:=NiveauCheckedList, currentCheckedList:=CurrentNiveauCheckedList)
        UpdateTitle(NomSpeculationProduction, VarieteProductionCommandeChart)

        LoadVarieteProductionChart()
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub CheckedListBox1_ItemCheck(sender As CheckedListBox, e As ItemCheckEventArgs) Handles VarieteCommandeCheckedList.ItemCheck
        UpdateChartOnCheck(e, checkedList:=VarieteCommandeCheckedList, currentCheckedList:=CurrentCommandeCheckedList, updateCallBack:=AddressOf LoadVarieteChart)
    End Sub

    Private Sub ClientCommandeCheckedList_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles ClientCommandeCheckedList.ItemCheck
        UpdateChartOnCheck(e, checkedList:=ClientCommandeCheckedList, currentCheckedList:=CurrentClientCheckedList, updateCallBack:=AddressOf LoadVarieteChart)
    End Sub


    Private Function GetCheckedValues(checkedList As CheckedListBox)
        Dim values = ""
        Dim items = checkedList.CheckedItems

        If items.Count > 0 Then
            For Each item In items
                values = $"{values}, '{item}'"
            Next
        End If
        Return values.Substring(2)
    End Function

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles Graphique.CheckedChanged
        ToggleTableChart(Graphique, Tableau, VarieteCommandeLivraisonChart, DataCommandeLivraison)
    End Sub
    Private Sub ToggleTableChart(ChartButton As RadioButton, TableButton As RadioButton, Chart As DataVisualization.Charting.Chart, DataTable As DataGridView)
        If ChartButton.Checked = True Then
            Chart.Visible = True
            DataTable.Visible = False
        ElseIf TableButton.Checked = True Then
            Chart.Visible = False
            DataTable.Visible = True
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles FiltrerParDate.CheckedChanged
        ToggleDatePickers(FiltrerParDate, DateDebut, DateFin, AddressOf LoadVarieteChart)
    End Sub

    Private Sub ToggleDatePickers(FilterCheckBox As CheckBox, StartDate As DateTimePicker, EndDate As DateTimePicker, UpdateCallBack As Action)
        If FilterCheckBox.Checked = True Then
            StartDate.Visible = True
            EndDate.Visible = True
        ElseIf FiltrerParDate.Checked = False Then
            StartDate.Visible = False
            EndDate.Visible = False
            UpdateCallBack()
        End If
    End Sub

    Private Sub DateDebut_ValueChanged(sender As Object, e As EventArgs) Handles DateDebut.ValueChanged
        LoadVarieteChart()
    End Sub

    Private Sub DateFin_ValueChanged(sender As Object, e As EventArgs) Handles DateFin.ValueChanged
        LoadVarieteChart()
    End Sub

    Private Sub VarieteProductionCheckedList_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles VarieteProductionCheckedList.ItemCheck
        UpdateChartOnCheck(e, checkedList:=VarieteProductionCheckedList, currentCheckedList:=CurrentProductionCheckedList, updateCallBack:=AddressOf LoadVarieteProductionChart)
    End Sub

    Private Sub UpdateChartOnCheck(e As ItemCheckEventArgs, checkedList As CheckedListBox, currentCheckedList As CheckedListBox, updateCallBack As Action)
        If e.NewValue = 0 Then
            If (currentCheckedList.Items.Count > 0 And currentCheckedList.Items.Count <= checkedList.Items.Count) Then
                currentCheckedList.SetItemCheckState(e.Index, e.NewValue)
                updateCallBack()
            End If
        Else
            If (currentCheckedList.Items.Count > 0 And currentCheckedList.Items.Count = checkedList.Items.Count) Then
                currentCheckedList.SetItemCheckState(e.Index, e.NewValue)
                updateCallBack()
            End If
        End If
    End Sub

    Private Sub LocaliteCheckedList_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles LocaliteCheckedList.ItemCheck
        UpdateChartOnCheck(e, checkedList:=LocaliteCheckedList, currentCheckedList:=CurrentLocaliteCheckedList, updateCallBack:=AddressOf LoadVarieteProductionChart)
    End Sub
    Private Sub NiveauCheckedList_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles NiveauCheckedList.ItemCheck
        UpdateChartOnCheck(e, checkedList:=NiveauCheckedList, currentCheckedList:=CurrentNiveauCheckedList, updateCallBack:=AddressOf LoadVarieteProductionChart)
    End Sub

    Private Sub GraphiqueProduction_CheckedChanged(sender As Object, e As EventArgs) Handles GraphiqueProduction.CheckedChanged
        ToggleTableChart(GraphiqueProduction, TableauProduction, VarieteProductionCommandeChart, DataVarieteProduction)
    End Sub

    Private Sub FiltrerParDateProduction_CheckedChanged(sender As Object, e As EventArgs) Handles FiltrerParDateProduction.CheckedChanged
        ToggleDatePickers(FiltrerParDateProduction, DateDebutProduction, DateFinProduction, AddressOf LoadVarieteProductionChart)
    End Sub


    Private Sub DateDebutProduction_ValueChanged(sender As Object, e As EventArgs) Handles DateDebutProduction.ValueChanged
        LoadVarieteProductionChart()
    End Sub

    Private Sub DateFinProduction_ValueChanged(sender As Object, e As EventArgs) Handles DateFinProduction.ValueChanged
        LoadVarieteProductionChart()
    End Sub

    Private Sub NomSpeculationGen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NomSpeculationGen.SelectedIndexChanged
        FillVarieteProductionCheckBoxList(selector:=NomSpeculationGen, checkedList:=GenVarieteCheckedList, currentCheckedList:=CurrentGenVarieteCheckedList)
        FillLocaliteProductionCheckedList(selector:=NomSpeculationGen, checkedList:=GenLocaliteCheckedList, currentCheckedList:=CurrentGenLocaliteCheckedList)
        FillNiveauCheckedList(selector:=NomSpeculationGen, checkedList:=GenNiveauCheckedList, currentCheckedList:=CurrentGenNiveauCheckedList)
        FillClientCheckBoxList(selector:=NomSpeculationGen, checkedList:=GenClientCheckedList, currentCheckedList:=CurrentGenClientCheckedList)
        UpdateTitle(NomSpeculationGen, CommandeProductionChart)

        LoadCommandeProductionChart()
    End Sub

    Private Sub FiltrerParDateGen_CheckedChanged(sender As Object, e As EventArgs) Handles FiltrerParDateGen.CheckedChanged
        ToggleDatePickers(FiltrerParDateGen, DateDebutGen, DateFinGen, AddressOf LoadCommandeProductionChart)
    End Sub

    Private Sub DateDebutGen_ValueChanged(sender As Object, e As EventArgs) Handles DateDebutGen.ValueChanged
        LoadCommandeProductionChart()
    End Sub

    Private Sub GraphiqueGen_CheckedChanged(sender As Object, e As EventArgs) Handles GraphiqueGen.CheckedChanged
        ToggleTableChart(GraphiqueGen, TableauGen, CommandeProductionChart, DataCommandeProduction)
    End Sub

    Private Sub DateFinGen_ValueChanged(sender As Object, e As EventArgs) Handles DateFinGen.ValueChanged
        LoadCommandeProductionChart()
    End Sub

    Private Sub GenVarieteCheckedList_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles GenVarieteCheckedList.ItemCheck
        UpdateChartOnCheck(e, checkedList:=GenVarieteCheckedList, currentCheckedList:=CurrentGenVarieteCheckedList, updateCallBack:=AddressOf LoadCommandeProductionChart)
    End Sub

    Private Sub GenLocaliteCheckedList_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles GenLocaliteCheckedList.ItemCheck
        UpdateChartOnCheck(e, checkedList:=GenLocaliteCheckedList, currentCheckedList:=CurrentGenLocaliteCheckedList, updateCallBack:=AddressOf LoadCommandeProductionChart)
    End Sub

    Private Sub GenNiveauCheckedList_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles GenNiveauCheckedList.ItemCheck
        UpdateChartOnCheck(e, checkedList:=GenNiveauCheckedList, currentCheckedList:=CurrentGenNiveauCheckedList, updateCallBack:=AddressOf LoadCommandeProductionChart)
    End Sub

    Private Sub GenClientCheckedList_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles GenClientCheckedList.ItemCheck
        UpdateChartOnCheck(e, checkedList:=GenClientCheckedList, currentCheckedList:=CurrentClientCheckedList, updateCallBack:=AddressOf LoadCommandeProductionChart)
    End Sub

    Private Sub CheckedListBox1_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles VarieteCommandeCheckedList.ItemCheck

    End Sub
End Class

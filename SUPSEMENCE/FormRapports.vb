Imports LiveCharts
Imports LiveCharts.Wpf
Imports MySql.Data.MySqlClient

Public Class FormRapports
    Private connection As MySqlConnection = DBConnection.connection
    Private CurrentVarieteProductionCheckedList As CheckedListBox = New CheckedListBox()
    Private CurrentLocaliteProductionCheckedList As CheckedListBox = New CheckedListBox()
    Private CurrentNiveauProductionCheckedList As CheckedListBox = New CheckedListBox()

    Private CurrentVarieteCommandeCheckedList As CheckedListBox = New CheckedListBox()
    Private CurrentLocaliteCommandeCheckedList As CheckedListBox = New CheckedListBox()
    Private CurrentNiveauCommandeCheckedList As CheckedListBox = New CheckedListBox()
    Private CurrentClientCommandeCheckedList As CheckedListBox = New CheckedListBox()

    Private CurrentGenVarieteCheckedList As CheckedListBox = New CheckedListBox()
    Private CurrentGenLocaliteCheckedList As CheckedListBox = New CheckedListBox()
    Private CurrentGenNiveauCheckedList As CheckedListBox = New CheckedListBox()
    Private CurrentGenClientCheckedList As CheckedListBox = New CheckedListBox()
    Private CurrenGentNiveauCheckedList As CheckedListBox = New CheckedListBox()

    'Private indexes As Dictionary(Of String, Integer) = New Dictionary(Of String, Integer)
    'Private Indexes As List(Of KeyValuePair(Of String, Integer)) = New List(Of KeyValuePair(Of String, Integer
    Private isVarieteCollapsed As Boolean = True
    Private isLocaliteCollapsed As Boolean = True
    Private isNiveauCollapsed As Boolean = True
    Private isDateCollapsed As Boolean = True

    Private isVarieteCollapsedCommande As Boolean = True
    Private isLocaliteCollapsedCommande As Boolean = True
    Private isNiveauCollapsedCommande As Boolean = True
    Private isDateCollapsedCommande As Boolean = True
    Private isClientCollapsedCommande As Boolean = True

    Private isVarieteCollapsedGen As Boolean = True
    Private isLocaliteCollapsedGen As Boolean = True
    Private isNiveauCollapsedGen As Boolean = True
    Private isDateCollapsedGen As Boolean = True
    Private isClientCollapsedGen As Boolean = True

    Private Sub FormRapports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'SemencesDataSet.commande'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        'Me.CommandeTableAdapter.Fill(Me.SemencesDataSet.commande)
        'LoadSpeculationChart()
        FillSpeculationInstitution()

        LoadVarieteChart()
        LoadVarieteProductionChart()
        LoadCommandeProductionChart()

        FillAllCheckedList(
        selector:=NomSpeculationCommande,
        variete:=VarieteCommandeCheckedList,
        currentVariete:=CurrentVarieteCommandeCheckedList,
        localite:=LocaliteCommandeCheckedList,
        currentLocalite:=CurrentLocaliteCommandeCheckedList,
        niveau:=NiveauCommandeCheckedList,
        currentNiveau:=CurrentNiveauCommandeCheckedList,
        client:=ClientCommandeCheckedList,
        currentClient:=CurrentClientCommandeCheckedList
        )

        FillAllCheckedList(
        selector:=NomSpeculationProduction,
        variete:=VarieteProductionCheckedList,
        currentVariete:=CurrentVarieteProductionCheckedList,
        localite:=LocaliteCheckedList,
        currentLocalite:=CurrentLocaliteProductionCheckedList,
        niveau:=NiveauCheckedList,
        currentNiveau:=CurrentNiveauProductionCheckedList
        )

        FillAllCheckedList(
        selector:=NomSpeculationGen,
        variete:=GenVarieteCheckedList,
        currentVariete:=CurrentGenVarieteCheckedList,
        localite:=GenLocaliteCheckedList,
        currentLocalite:=CurrentGenLocaliteCheckedList,
        niveau:=GenNiveauCheckedList,
        currentNiveau:=CurrenGentNiveauCheckedList,
        client:=GenClientCheckedList,
        currentClient:=CurrentGenClientCheckedList
        )

        DateDebut.MaxDate = DateTime.Now()
        DateFin.MaxDate = DateTime.Now()

        DateDebutProduction.MaxDate = DateTime.Now()
        DateFinProduction.MaxDate = DateTime.Now()

        DateDebutGen.MaxDate = DateTime.Now()
        DateFinGen.MaxDate = DateTime.Now()
    End Sub

    Private Sub FillAllCheckedList(selector, Optional variete = Nothing, Optional currentVariete = Nothing, Optional localite = Nothing, Optional currentLocalite = Nothing, Optional niveau = Nothing, Optional currentNiveau = Nothing, Optional client = Nothing, Optional currentClient = Nothing)
        If variete IsNot Nothing Then
            FillVarieteCheckedList(selector:=selector, checkedList:=variete, currentCheckedList:=currentVariete)
        End If

        If localite IsNot Nothing Then
            FillLocaliteCheckedList(selector:=selector, checkedList:=localite, currentCheckedList:=currentLocalite)
        End If

        If niveau IsNot Nothing Then
            FillNiveauCheckedList(selector:=selector, checkedList:=niveau, currentCheckedList:=currentNiveau)
        End If

        If client IsNot Nothing Then
            FillClientCheckBoxList(selector:=selector, checkedList:=client, currentCheckedList:=currentClient)
        End If
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
                     inner join client cl on cl.id_client=c.id_client
                     inner join production p on p.id_production=c.id_production
                     inner join localisation l on l.id_localisation=p.id_localisation
                     inner join niveau_institution ni on ni.id_niveau_institution=p.id_niveau_institution
                     inner join niveau_de_production n on n.id_niveau=ni.id_niveau
                     inner join variete_institution vi on vi.id_variete_institution=p.id_variete_institution
                     inner join variete v on v.id_variete=vi.id_variete
                     where (p.id_institution=@id_institution and id_speculation=@id_speculation)"
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

    Private Sub FillVarieteCheckedList(checkedList As CheckedListBox, currentCheckedList As CheckedListBox, Optional selector As ComboBox = Nothing)
        Dim query = "select distinct nom_variete
                     from production p
                     inner join localisation l on l.id_localisation=p.id_localisation
                     inner join niveau_institution ni on ni.id_niveau_institution=p.id_niveau_institution
                     inner join niveau_de_production n on n.id_niveau=ni.id_niveau
                     inner join variete_institution vi on vi.id_variete_institution=p.id_variete_institution
                     inner join variete v on v.id_variete=vi.id_variete
                     where(vi.id_institution=@id_institution And id_speculation=@id_speculation)"

        If checkedList.Name = VarieteCommandeCheckedList.Name Then
            query = "select distinct nom_variete
                     from commande c
                     inner Join production p on p.id_production=c.id_production
                     inner join localisation l on l.id_localisation=p.id_localisation
                     inner join niveau_institution ni on ni.id_niveau_institution=p.id_niveau_institution
                     inner join niveau_de_production n on n.id_niveau=ni.id_niveau
                     inner join variete_institution vi on vi.id_variete_institution=p.id_variete_institution
                     inner join variete v on v.id_variete=vi.id_variete
                     where(vi.id_institution=@id_institution And id_speculation=@id_speculation)"
        End If


        'If CheckedLessThanItems(CurrentLocaliteProductionCheckedList) Then
        '    query = InsertFilter(query, CurrentLocaliteProductionCheckedList, "village")
        'End If

        'If CheckedLessThanItems(CurrentNiveauProductionCheckedList) Then
        '    query = InsertFilter(query, CurrentNiveauProductionCheckedList, "nom_niveau")
        'End If

        FillCheckedList(
            query:=query,
            selector:=selector,
            checkedList:=checkedList,
            currentCheckedList:=currentCheckedList
            )
    End Sub

    Private Sub FillLocaliteCheckedList(checkedList, currentCheckedList, Optional selector = Nothing)
        Dim query = "select distinct village 
                     from production p
                     inner join localisation l on l.id_localisation=p.id_localisation
                     inner join niveau_institution ni on ni.id_niveau_institution=p.id_niveau_institution
                     inner join niveau_de_production n on n.id_niveau=ni.id_niveau
                     inner join variete_institution vi on vi.id_variete_institution=p.id_variete_institution
                     inner join variete v on v.id_variete=vi.id_variete
                     where (vi.id_institution=@id_institution and id_speculation=@id_speculation)"

        If checkedList.Name = LocaliteCommandeCheckedList.Name Then
            query = "select distinct village 
                     from commande c
                     inner join production p on p.id_production=c.id_production
                     inner join localisation l on l.id_localisation=p.id_localisation
                     inner join niveau_institution ni on ni.id_niveau_institution=p.id_niveau_institution
                     inner join niveau_de_production n on n.id_niveau=ni.id_niveau
                     inner join variete_institution vi on vi.id_variete_institution=p.id_variete_institution
                     inner join variete v on v.id_variete=vi.id_variete
                     where (vi.id_institution=@id_institution and id_speculation=@id_speculation)"
        End If
        'If CheckedLessThanItems(CurrentVarieteProductionCheckedList) Then
        '    query = InsertFilter(query, CurrentVarieteProductionCheckedList, "nom_variete")
        'End If

        'If CheckedLessThanItems(CurrentNiveauProductionCheckedList) Then
        '    query = InsertFilter(query, CurrentNiveauProductionCheckedList, "nom_niveau")
        'End If

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
                     inner join localisation l on l.id_localisation=p.id_localisation
                     inner join niveau_institution ni on ni.id_niveau_institution=p.id_niveau_institution
                     inner join niveau_de_production n on n.id_niveau=ni.id_niveau
                     inner join variete_institution vi on vi.id_variete_institution=p.id_variete_institution
                     inner join variete v on v.id_variete=vi.id_variete
                     where (p.id_institution=@id_institution and id_speculation=@id_speculation)"

        'If CheckedLessThanItems(CurrentVarieteProductionCheckedList) Then
        '    query = InsertFilter(query, CurrentVarieteProductionCheckedList, "nom_variete")
        'End If

        'If CheckedLessThanItems(CurrentLocaliteProductionCheckedList) Then
        '    query = InsertFilter(query, CurrentLocaliteProductionCheckedList, "village")
        'End If


        FillCheckedList(
            query:=query,
            selector:=selector,
            checkedList:=checkedList,
            currentCheckedList:=currentCheckedList,
            columnName:="nom_niveau"
            )
    End Sub
    Private Sub FillCheckedList(query As String, checkedList As CheckedListBox, currentCheckedList As CheckedListBox, Optional columnName As String = "nom_variete", Optional defaultState As Boolean = False, Optional selector As ComboBox = Nothing, ByRef Optional filters As List(Of String) = Nothing, Optional filterSelectors As List(Of String) = Nothing)

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

    Private Function CheckedLessThanItems(CheckedList As CheckedListBox, checkBox As CheckBox)
        'If checkBox IsNot Nothing Then
        Return CheckedList.CheckedItems.Count >= 1 And CheckedList.CheckedItems.Count <= CheckedList.Items.Count And checkBox.Checked = True
        'End If
        'Return CheckedList.CheckedItems.Count >= 1 And CheckedList.CheckedItems.Count <= CheckedList.Items.Count
    End Function
    Private Sub LoadVarieteChart()
        If VueGlobaleCommande.Checked = True Then
            Dim getVarieteCommandeeTable = $"select nom_speculation, sum(quantite) quantite
                                    from commande c
                                    inner join production p on p.id_production=c.id_production
                                    inner join variete_institution vi on vi.id_variete_institution=p.id_variete_institution
                                    inner join variete v on v.id_variete=vi.id_variete
                                    inner join speculation s on s.id_speculation=v.id_speculation
                                    where (p.id_institution=@id_institution) group by nom_speculation order by nom_speculation"

            Dim getVarieteCommandee = $"select nom_speculation, sum(quantite) quantite
                                    from commande c
                                    inner join production p on p.id_production=c.id_production
                                    inner join variete_institution vi on vi.id_variete_institution=p.id_variete_institution
                                    inner join variete v on v.id_variete=vi.id_variete
                                    inner join speculation s on s.id_speculation=v.id_speculation
                                    where (p.id_institution=@id_institution) group by nom_speculation order by nom_speculation"

            Dim getVarieteLivree = $"select nom_speculation, sum(quantite)*est_enlevee quantite
                                from commande c
                                inner join production p on p.id_production=c.id_production
                                inner join variete_institution vi on vi.id_variete_institution=p.id_variete_institution
                                inner join variete v on v.id_variete=vi.id_variete 
                                inner join speculation s on s.id_speculation=v.id_speculation
                                where (p.id_institution=@id_institution) group by nom_speculation order by nom_speculation"


            FillChart(VarieteCommandeLivraisonChart, getVarieteCommandee, getVarieteLivree, "Quantité commandée en KG", "Quantité livrée en KG", "nom_speculation", "quantite", fromCommandeChart:=True)

            FillTable(query:=getVarieteCommandeeTable, Table:=DataCommandeLivraison, selector:=NomSpeculationCommande)

        ElseIf VueDetailleeCommande.Checked = True Then
            Dim getVarieteCommandeeTable = $"select nom_variete, sum(quantite) quantite, nom_complet_structure client, village localite, nom_niveau, est_enlevee livré
                                    from commande c
                                    inner join production p on p.id_production=c.id_production
                                    inner join localisation l on l.id_localisation=p.id_localisation
                                    inner join niveau_institution ni on ni.id_niveau_institution=p.id_niveau_institution
                                    inner join niveau_de_production n on n.id_niveau=ni.id_niveau
                                    inner join variete_institution vi on vi.id_variete_institution=p.id_variete_institution
                                    inner join variete v on v.id_variete=vi.id_variete
                                    inner join client cl on cl.id_client = c.id_client 
                                    where (p.id_institution=@id_institution and v.id_speculation=@nom_speculation) group by numero_de_commade order by nom_variete"

            Dim getVarieteCommandee = $"select id_speculation, nom_variete, sum(quantite) quantite
                                    from commande c
                                    inner join production p on p.id_production=c.id_production
                                    inner join localisation l on l.id_localisation=p.id_localisation
                                    inner join niveau_institution ni on ni.id_niveau_institution=p.id_niveau_institution
                                    inner join niveau_de_production n on n.id_niveau=ni.id_niveau
                                    inner join variete_institution vi on vi.id_variete_institution=p.id_variete_institution
                                    inner join variete v on v.id_variete=vi.id_variete
                                    inner join client cl on cl.id_client = c.id_client 
                                    where (p.id_institution=@id_institution and v.id_speculation=@nom_speculation) group by nom_variete order by nom_variete"

            Dim getVarieteLivree = $"select id_speculation, nom_variete, sum(quantite)*est_enlevee quantite
                                from commande c
                                    inner join production p on p.id_production=c.id_production
                                inner join localisation l on l.id_localisation=p.id_localisation
                                    inner join niveau_institution ni on ni.id_niveau_institution=p.id_niveau_institution
                                    inner join niveau_de_production n on n.id_niveau=ni.id_niveau
                                    inner join variete_institution vi on vi.id_variete_institution=p.id_variete_institution
                                    inner join variete v on v.id_variete=vi.id_variete
                                    inner join client cl on cl.id_client = c.id_client  
                                where (p.id_institution=@id_institution and v.id_speculation=@nom_speculation) group by nom_variete order by nom_variete"


            If FiltrerDateCommande.Checked Then
                getVarieteCommandeeTable = InsertDateFilter(getVarieteCommandeeTable, "date_expression_besoin_client", DateDebut, DateFin)
                getVarieteCommandee = InsertDateFilter(getVarieteCommandee, "date_expression_besoin_client", DateDebut, DateFin)
                getVarieteLivree = InsertDateFilter(getVarieteLivree, "date_expression_besoin_client", DateDebut, DateFin)
            End If

            'MessageBox.Show(GetCheckedValues())

            If CheckedLessThanItems(CurrentVarieteCommandeCheckedList, FiltrerVarieteCommande) Then
                getVarieteCommandeeTable = InsertFilter(getVarieteCommandeeTable, CurrentVarieteCommandeCheckedList, "nom_variete")
                getVarieteCommandee = InsertFilter(getVarieteCommandee, CurrentVarieteCommandeCheckedList, "nom_variete")
                getVarieteLivree = InsertFilter(getVarieteLivree, CurrentVarieteCommandeCheckedList, "nom_variete")
            End If

            If CheckedLessThanItems(CurrentLocaliteCommandeCheckedList, FiltrerLocaliteCommande) Then
                getVarieteCommandeeTable = InsertFilter(getVarieteCommandeeTable, CurrentLocaliteCommandeCheckedList, "village")
                getVarieteCommandee = InsertFilter(getVarieteCommandee, CurrentLocaliteCommandeCheckedList, "village")
                getVarieteLivree = InsertFilter(getVarieteLivree, CurrentLocaliteCommandeCheckedList, "village")
            End If

            If CheckedLessThanItems(CurrentNiveauCommandeCheckedList, FiltrerNiveauCommande) Then
                getVarieteCommandeeTable = InsertFilter(getVarieteCommandeeTable, CurrentNiveauCommandeCheckedList, "nom_niveau")
                getVarieteCommandee = InsertFilter(getVarieteCommandee, CurrentNiveauCommandeCheckedList, "nom_niveau")
                getVarieteLivree = InsertFilter(getVarieteLivree, CurrentNiveauCommandeCheckedList, "nom_niveau")
            End If

            If CheckedLessThanItems(CurrentClientCommandeCheckedList, FiltrerClientCommande) Then
                getVarieteCommandeeTable = InsertFilter(getVarieteCommandeeTable, CurrentClientCommandeCheckedList, "nom_complet_structure")
                getVarieteCommandee = InsertFilter(getVarieteCommandee, CurrentClientCommandeCheckedList, "nom_complet_structure")
                getVarieteLivree = InsertFilter(getVarieteLivree, CurrentClientCommandeCheckedList, "nom_complet_structure")
            End If


            FillChart(VarieteCommandeLivraisonChart, getVarieteCommandee, getVarieteLivree, "Quantité commandée en KG", "Quantité livrée en KG", "nom_variete", "quantite", fromCommandeChart:=True)

            FillTable(query:=getVarieteCommandeeTable, Table:=DataCommandeLivraison, selector:=NomSpeculationCommande)

            HideColumnIfChecked("localite", DataCommandeLivraison, FiltrerLocaliteCommande)
            HideColumnIfChecked("nom_niveau", DataCommandeLivraison, FiltrerNiveauCommande)
            HideColumnIfChecked("client", DataCommandeLivraison, FiltrerClientCommande)

        End If
    End Sub

    Private Sub LoadVarieteProductionChart()
        Dim otherTableColumns = ""
        If VueParSpeculation.Checked = True Then
            Dim getVarieteProduiteTable = $"select nom_speculation, sum(quantite_produite - stock_de_securite) quantite_produite
                                    from production p
                                    inner join localisation l on l.id_localisation=p.id_localisation
                                    inner join variete_institution vi on vi.id_variete_institution=p.id_variete_institution
                                    inner join variete v on v.id_variete=vi.id_variete
                                    inner join speculation s on s.id_speculation=v.id_speculation
                                    where (p.id_institution=@id_institution) group by nom_speculation order by nom_speculation"

            Dim getVarieteProduite = $"select nom_speculation, sum(quantite_produite - stock_de_securite) quantite_produite
                                    from production p
                                    inner join localisation l on l.id_localisation=p.id_localisation
                                    inner join variete_institution vi on vi.id_variete_institution=p.id_variete_institution
                                    inner join variete v on v.id_variete=vi.id_variete
                                    inner join speculation s on s.id_speculation=v.id_speculation
                                    where (p.id_institution=@id_institution) group by nom_speculation order by nom_speculation"

            FillChart(VarieteProductionCommandeChart, getVarieteProduite, "", "Quantité produite en KG", "", "nom_speculation", "quantite_produite", fromProductionChart:=True)

            FillTable(query:=getVarieteProduiteTable, Table:=DataVarieteProduction, selector:=NomSpeculationProduction)

        ElseIf VueParVariete.Checked = True Then
            Dim getVarieteProduiteTable = $"select nom_variete, sum(quantite_produite - stock_de_securite) quantite_produite, village localite, nom_niveau niveau
                                    from production p
                                    inner join localisation l on l.id_localisation=p.id_localisation
                                    inner join niveau_institution ni on ni.id_niveau_institution=p.id_niveau_institution
                                    inner join niveau_de_production n on n.id_niveau=ni.id_niveau
                                    inner join variete_institution vi on vi.id_variete_institution=p.id_variete_institution
                                    inner join variete v on v.id_variete=vi.id_variete
                                    where (p.id_institution=@id_institution and v.id_speculation=@nom_speculation) 
                                    group by p.id_production order by nom_variete"

            Dim getVarieteProduite = $"select nom_variete, sum(quantite_produite - stock_de_securite) quantite_produite, village localite, nom_niveau niveau
                                    from production p
                                    inner join localisation l on l.id_localisation=p.id_localisation
                                    inner join niveau_institution ni on ni.id_niveau_institution=p.id_niveau_institution
                                    inner join niveau_de_production n on n.id_niveau=ni.id_niveau
                                    inner join variete_institution vi on vi.id_variete_institution=p.id_variete_institution
                                    inner join variete v on v.id_variete=vi.id_variete
                                    where (p.id_institution=@id_institution and v.id_speculation=@nom_speculation) group by nom_variete order by nom_variete"


            If CheckedLessThanItems(CurrentVarieteProductionCheckedList, FiltrerVariete) Then
                getVarieteProduiteTable = InsertFilter(getVarieteProduiteTable, CurrentVarieteProductionCheckedList, "nom_variete")
                getVarieteProduite = InsertFilter(getVarieteProduite, CurrentVarieteProductionCheckedList, "nom_variete")
            End If
            If CheckedLessThanItems(CurrentLocaliteProductionCheckedList, FiltrerLocalite) Then
                getVarieteProduiteTable = InsertFilter(getVarieteProduiteTable, CurrentLocaliteProductionCheckedList, "village")
                getVarieteProduite = InsertFilter(getVarieteProduite, CurrentLocaliteProductionCheckedList, "village")
            End If
            If CheckedLessThanItems(CurrentNiveauProductionCheckedList, FiltrerNiveau) Then
                getVarieteProduiteTable = InsertFilter(getVarieteProduiteTable, CurrentNiveauProductionCheckedList, "nom_niveau")
                getVarieteProduite = InsertFilter(getVarieteProduite, CurrentNiveauProductionCheckedList, "nom_niveau")
            End If

            If FiltrerParDateProduction.Checked Then
                getVarieteProduiteTable = InsertDateFilter(getVarieteProduiteTable, "date_de_production", DateDebutProduction, DateFinProduction)
                getVarieteProduite = InsertDateFilter(getVarieteProduite, "date_de_production", DateDebutProduction, DateFinProduction)
            End If

            'MessageBox.Show(GetCheckedValues(CurrentNiveauProductionCheckedList))

            FillChart(VarieteProductionCommandeChart, getVarieteProduite, "", "Quantité produite en KG", "", "nom_variete", "quantite_produite", fromProductionChart:=True)

            FillTable(query:=getVarieteProduiteTable, Table:=DataVarieteProduction, selector:=NomSpeculationProduction)

            HideColumnIfChecked("localite", DataVarieteProduction, FiltrerLocalite)
            HideColumnIfChecked("niveau", DataVarieteProduction, FiltrerNiveau)
        End If


    End Sub

    Private Sub LoadCommandeProductionChart()
        If VueGlobaleGen.Checked = True Then
            Dim getCommandeProductionTable = $"select s.nom_speculation,
                                                coalesce(sum(quantite_produite - stock_de_securite), 0) quantite_produite,
                                                c.quantite_commandee
                                                from production p
                                                inner join localisation l on l.id_localisation=p.id_localisation
                                                inner join niveau_institution ni on ni.id_niveau_institution=p.id_niveau_institution
                                                inner join niveau_de_production n on n.id_niveau=ni.id_niveau
                                                inner join variete_institution vi on vi.id_variete_institution=p.id_variete_institution
                                                inner join variete v on v.id_variete=vi.id_variete
                                                inner join speculation s on v.id_speculation=s.id_speculation
                                                inner join (
                                                select s.nom_speculation, coalesce(sum(quantite), 0) quantite_commandee
                                                from production p2
                                                left join commande c on c.id_production=p2.id_production
                                                inner join variete_institution vi on vi.id_variete_institution=p2.id_variete_institution
                                                inner join variete v on v.id_variete=vi.id_variete
                                                inner join speculation s on s.id_speculation=v.id_speculation
                                                where (p2.id_institution=1)
                                                group by nom_speculation
                                                order by nom_speculation
                                                ) c on c.nom_speculation = s.nom_speculation
                                                where (p.id_institution=@id_institution)
                                                group by nom_speculation
                                                order by nom_speculation"

            Dim getVarieteProduite = $"select  nom_speculation, sum(quantite_produite - stock_de_securite) quantite
                                    from production p
                                    inner join variete_institution vi on vi.id_variete_institution=p.id_variete_institution
                                    inner join variete v on v.id_variete=vi.id_variete
                                    inner join speculation s on s.id_speculation=v.id_speculation
                                    where (p.id_institution=@id_institution)
                                    group by nom_speculation
                                    order by nom_speculation"

            Dim getVarieteCommandee = $"select nom_speculation, coalesce(sum(quantite), 0) quantite
                                    from production p
                                    left join commande c on c.id_production=p.id_production
                                    inner join variete_institution vi on vi.id_variete_institution=p.id_variete_institution
                                    inner join variete v on v.id_variete=vi.id_variete
                                    inner join speculation s on s.id_speculation=v.id_speculation
                                    where (p.id_institution=@id_institution)
                                    group by nom_speculation
                                    order by nom_speculation"

            FillChart(CommandeProductionChart, getVarieteProduite, getVarieteCommandee, "Quantité produite en KG", "Quantité commandée en KG", "nom_speculation", "quantite")

            FillTable(query:=getCommandeProductionTable, Table:=DataCommandeProduction, selector:=NomSpeculationGen)
        ElseIf VueDetailleeGen.Checked = True Then
            Dim getCommandeProductionTable = $"select v.nom_variete, village localite, nom_niveau,
                                                coalesce(sum(quantite_produite - stock_de_securite), 0) quantite_produite,
                                                c.quantite_commandee
                                                from production p
                                                inner join localisation l on l.id_localisation=p.id_localisation
                                                inner join niveau_institution ni on ni.id_niveau_institution=p.id_niveau_institution
                                                inner join niveau_de_production n on n.id_niveau=ni.id_niveau
                                                inner join variete_institution vi on vi.id_variete_institution=p.id_variete_institution
                                                inner join variete v on v.id_variete=vi.id_variete
                                                inner join (
                                                select c.id_client, p2.id_production, v.nom_variete, coalesce(sum(quantite), 0) quantite_commandee
                                                from production p2
                                                left join commande c on c.id_production=p2.id_production
                                                inner join variete_institution vi on vi.id_variete_institution=p2.id_variete_institution
                                                inner join variete v on v.id_variete=vi.id_variete
                                                inner join speculation s on s.id_speculation=v.id_speculation
                                                where (p2.id_institution=@id_institution and s.id_speculation=@nom_speculation)
                                                group by p2.id_production                                    
                                                order by v.nom_variete
                                                ) c on c.id_production = p.id_production
                                                left join client cl on cl.id_client = c.id_client  
                                                where (p.id_institution=@id_institution and v.id_speculation=@nom_speculation)
                                                group by p.id_production
                                                order by v.nom_variete"

            Dim getVarieteProduite = $"select  nom_variete, sum(quantite_produite - stock_de_securite) quantite
                                    from production p
                                    inner join localisation l on l.id_localisation=p.id_localisation
                                    inner join niveau_institution ni on ni.id_niveau_institution=p.id_niveau_institution
                                    inner join niveau_de_production n on n.id_niveau=ni.id_niveau
                                    inner join variete_institution vi on vi.id_variete_institution=p.id_variete_institution
                                    inner join variete v on v.id_variete=vi.id_variete
                                    where (p.id_institution=@id_institution and v.id_speculation=@nom_speculation)
                                    group by nom_variete
                                    order by nom_variete"

            Dim getVarieteCommandee = $"select nom_variete, coalesce(sum(quantite), 0) quantite
                                        from production p
                                        inner join localisation l on l.id_localisation=p.id_localisation
                                        inner join niveau_institution ni on ni.id_niveau_institution=p.id_niveau_institution
                                        inner join niveau_de_production n on n.id_niveau=ni.id_niveau
                                        inner join variete_institution vi on vi.id_variete_institution=p.id_variete_institution
                                        inner join variete v on v.id_variete=vi.id_variete
                                        left join commande c on c.id_production=p.id_production
                                        left join client cl on cl.id_client = c.id_client  
                                        where (p.id_institution=@id_institution and v.id_speculation=@nom_speculation)
                                        group by nom_variete
                                        order by nom_variete"

            If FiltrerDateGen.Checked Then
                getCommandeProductionTable = InsertDateFilter(getCommandeProductionTable, "date_de_production", DateDebutGen, DateFinGen)
                getVarieteProduite = InsertDateFilter(getVarieteProduite, "date_de_production", DateDebutGen, DateFinGen)
                getVarieteCommandee = InsertDateFilter(getVarieteCommandee, "date_expression_besoin_client", DateDebutGen, DateFinGen)
            End If

            If CheckedLessThanItems(CurrentGenVarieteCheckedList, FiltrerVarieteGen) Then
                getCommandeProductionTable = InsertFilter(getCommandeProductionTable, CurrentGenVarieteCheckedList, "v.nom_variete")
                getVarieteProduite = InsertFilter(getVarieteProduite, CurrentGenVarieteCheckedList, "v.nom_variete")
                getVarieteCommandee = InsertFilter(getVarieteCommandee, CurrentGenVarieteCheckedList, "v.nom_variete")
            End If

            If CheckedLessThanItems(CurrentGenLocaliteCheckedList, FiltrerLocaliteGen) Then
                getCommandeProductionTable = InsertFilter(getCommandeProductionTable, CurrentGenLocaliteCheckedList, "village")
                getVarieteProduite = InsertFilter(getVarieteProduite, CurrentGenLocaliteCheckedList, "village")
            End If

            If CheckedLessThanItems(CurrentGenNiveauCheckedList, FiltrerNiveauGen) Then
                getCommandeProductionTable = InsertFilter(getCommandeProductionTable, CurrentGenNiveauCheckedList, "nom_niveau")
                getVarieteProduite = InsertFilter(getVarieteProduite, CurrentGenNiveauCheckedList, "nom_niveau")
            End If

            If CheckedLessThanItems(CurrentGenClientCheckedList, FiltrerClientGen) Then


                getCommandeProductionTable = InsertFilter(getCommandeProductionTable, CurrentGenClientCheckedList, "nom_complet_structure")
                getVarieteCommandee = getVarieteCommandee.Replace(
                    "coalesce(sum(quantite), 0) quantite",
                    $"if(nom_complet_structure in ({GetCheckedValues(CurrentGenClientCheckedList)}), coalesce(sum(quantite), 0), 0) quantite"
                    )
                'MessageBox.Show(getVarieteCommandee)
                'getVarieteCommandee = InsertFilter(getVarieteCommandee, CurrentGenClientCheckedList, "nom_complet_structure")
            End If

            FillChart(CommandeProductionChart, getVarieteProduite, getVarieteCommandee, "Quantité produite en KG", "Quantité commandée en KG", "nom_variete", "quantite")

            FillTable(query:=getCommandeProductionTable, Table:=DataCommandeProduction, selector:=NomSpeculationGen)
            HideColumnIfChecked("localite", DataCommandeProduction, FiltrerLocaliteGen)
            HideColumnIfChecked("nom_niveau", DataCommandeProduction, FiltrerNiveauGen)
        End If

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

    'Private Sub LoadSpeculationChart()
    '    Dim getProduction = $"select nom_speculation, sum(quantite_produite) quantite
    '                         from production p
    '                         inner join variete_institution vi on vi.id_variete_institution=p.id_variete_institution
    '                         inner join variete v on v.id_variete = vi.id_variete
    '                         inner join speculation s on s.id_speculation = v.id_speculation
    '                         where vi.id_institution = @id_institution 
    '                         group by nom_speculation"

    '    Dim fontSize As Double = 22
    '    Dim command = New MySqlCommand(getProduction, connection)

    '    command.Parameters.AddWithValue("@id_institution", DBConnection.id_institution)

    '    Dim values = New ChartValues(Of Integer)
    '    Dim labels = New List(Of String)

    '    Dim reader = command.ExecuteReader()

    '    While reader.Read()
    '        values.Add(reader.GetInt64("quantite"))
    '        labels.Add($"{reader.GetString("nom_speculation")}")
    '    End While


    '    'CartesianChart1.Series = New SeriesCollection From {
    '    '        New ColumnSeries With {
    '    '            .Title = "",
    '    '            .Values = values,
    '    '            .FontSize = fontSize
    '    '        }
    '    '    }

    '    'CartesianChart1.AxisX.Add(New Axis With {
    '    '        .Title = "Spéculation",
    '    '        .Labels = labels,
    '    '        .FontSize = fontSize
    '    '    })
    '    'CartesianChart1.AxisY.Add(New Axis With {
    '    '        .Title = "Quantite produite (en KG)",
    '    '        .FontSize = fontSize
    '    '    })


    '    reader.Close()
    'End Sub
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
            command.Parameters.AddWithValue("@nom_speculation", NomSpeculationCommande.SelectedValue)
            'MessageBox.Show($"FROM COMMANDE {fromCommandeChart}")
        End If

        Dim reader = command.ExecuteReader()

        chart.Series(seriesName).Points.Clear()
        While reader.Read()
            chart.Series(seriesName).Points.AddXY(reader.GetString(keyName), reader.GetUInt64(valueName))
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

    Private Sub HideColumnIfChecked(columnName As String, dataTable As DataGridView, checkBox As CheckBox)
        Try
            dataTable.Columns(columnName).Visible = checkBox.Checked
        Catch ex As Exception
            MessageBox.Show("Column does not exist")
        End Try

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
        FillAllCheckedList(
        selector:=NomSpeculationCommande,
        variete:=VarieteCommandeCheckedList,
        currentVariete:=CurrentVarieteCommandeCheckedList,
        localite:=LocaliteCommandeCheckedList,
        currentLocalite:=CurrentLocaliteCommandeCheckedList,
        niveau:=NiveauCommandeCheckedList,
        currentNiveau:=CurrentNiveauCommandeCheckedList,
        client:=ClientCommandeCheckedList,
        currentClient:=CurrentClientCommandeCheckedList
        )

        UpdateTitle(NomSpeculationCommande, VarieteCommandeLivraisonChart)

        LoadVarieteChart()
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub NomSpeculationProduction_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NomSpeculationProduction.SelectedIndexChanged
        'Try
        FillAllCheckedList(
        selector:=NomSpeculationProduction,
        variete:=VarieteProductionCheckedList,
        currentVariete:=CurrentVarieteProductionCheckedList,
        localite:=LocaliteCheckedList,
        currentLocalite:=CurrentLocaliteProductionCheckedList,
        niveau:=NiveauCheckedList,
        currentNiveau:=CurrentNiveauProductionCheckedList
        )
        UpdateTitle(NomSpeculationProduction, VarieteProductionCommandeChart)
        FiltrerParDateProduction.Checked = False

        LoadVarieteProductionChart()
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub NomSpeculationGen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NomSpeculationGen.SelectedIndexChanged
        FillAllCheckedList(
        selector:=NomSpeculationGen,
        variete:=GenVarieteCheckedList,
        currentVariete:=CurrentGenVarieteCheckedList,
        localite:=GenLocaliteCheckedList,
        currentLocalite:=CurrentGenLocaliteCheckedList,
        niveau:=GenNiveauCheckedList,
        currentNiveau:=CurrenGentNiveauCheckedList,
        client:=GenClientCheckedList,
        currentClient:=CurrentGenClientCheckedList
        )

        UpdateTitle(NomSpeculationGen, CommandeProductionChart)

        LoadCommandeProductionChart()
    End Sub

    Private Sub VarieteCommandeCheckedList_ItemCheck(sender As CheckedListBox, e As ItemCheckEventArgs) Handles VarieteCommandeCheckedList.ItemCheck
        UpdateChartOnCheck(e, checkedList:=VarieteCommandeCheckedList, currentCheckedList:=CurrentVarieteCommandeCheckedList, updateCallBack:=AddressOf LoadVarieteChart)
    End Sub

    Private Sub LocaliteCommandeCheckedList_ItemCheck(sender As CheckedListBox, e As ItemCheckEventArgs) Handles LocaliteCommandeCheckedList.ItemCheck
        UpdateChartOnCheck(e, checkedList:=LocaliteCommandeCheckedList, currentCheckedList:=CurrentLocaliteCommandeCheckedList, updateCallBack:=AddressOf LoadVarieteChart)
    End Sub

    Private Sub NiveauCommandeCheckedList_ItemCheck(sender As CheckedListBox, e As ItemCheckEventArgs) Handles NiveauCommandeCheckedList.ItemCheck
        UpdateChartOnCheck(e, checkedList:=NiveauCommandeCheckedList, currentCheckedList:=CurrentNiveauCommandeCheckedList, updateCallBack:=AddressOf LoadVarieteChart)
    End Sub


    Private Sub ClientCommandeCheckedList_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles ClientCommandeCheckedList.ItemCheck
        UpdateChartOnCheck(e, checkedList:=ClientCommandeCheckedList, currentCheckedList:=CurrentClientCommandeCheckedList, updateCallBack:=AddressOf LoadVarieteChart)
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

    Private Sub ToggleTableChart(ChartButton As RadioButton, TableButton As RadioButton, Chart As DataVisualization.Charting.Chart, DataTable As DataGridView)
        If ChartButton.Checked = True Then
            Chart.Visible = True
            DataTable.Visible = False
            'MessageBox.Show("FROM CHART BUTTON CHECKED")
        ElseIf TableButton.Checked = True Then
            Chart.Visible = False
            DataTable.Visible = True
        End If
    End Sub

    Private Sub ToggleDatePickers(FilterCheckBox As CheckBox, StartDate As DateTimePicker, EndDate As DateTimePicker, UpdateCallBack As Action)
        If FilterCheckBox.Checked = True Then
            StartDate.Visible = True
            EndDate.Visible = True
        ElseIf FilterCheckBox.Checked = False Then
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
        UpdateChartOnCheck(e, checkedList:=VarieteProductionCheckedList, currentCheckedList:=CurrentVarieteProductionCheckedList, updateCallBack:=AddressOf LoadVarieteProductionChart)

        'FillLocaliteCheckedList(selector:=NomSpeculationProduction, checkedList:=LocaliteCheckedList, currentCheckedList:=CurrentLocaliteProductionCheckedList)
        'FillNiveauCheckedList(selector:=NomSpeculationProduction, checkedList:=NiveauCheckedList, currentCheckedList:=CurrentNiveauProductionCheckedList)
    End Sub
    Private Sub LocaliteCheckedList_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles LocaliteCheckedList.ItemCheck
        UpdateChartOnCheck(e, checkedList:=LocaliteCheckedList, currentCheckedList:=CurrentLocaliteProductionCheckedList, updateCallBack:=AddressOf LoadVarieteProductionChart)

        'FillVarieteCheckedList(selector:=NomSpeculationProduction, checkedList:=VarieteProductionCheckedList, currentCheckedList:=CurrentVarieteProductionCheckedList)
        'FillNiveauCheckedList(selector:=NomSpeculationProduction, checkedList:=NiveauCheckedList, currentCheckedList:=CurrentNiveauProductionCheckedList)
    End Sub
    Private Sub NiveauCheckedList_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles NiveauCheckedList.ItemCheck
        UpdateChartOnCheck(e, checkedList:=NiveauCheckedList, currentCheckedList:=CurrentNiveauProductionCheckedList, updateCallBack:=AddressOf LoadVarieteProductionChart)

        'FillVarieteCheckedList(selector:=NomSpeculationProduction, checkedList:=VarieteProductionCheckedList, currentCheckedList:=CurrentVarieteProductionCheckedList)
        'FillLocaliteCheckedList(selector:=NomSpeculationProduction, checkedList:=LocaliteCheckedList, currentCheckedList:=CurrentLocaliteProductionCheckedList)
    End Sub

    Private Sub UpdateChartOnCheck(e As ItemCheckEventArgs, checkedList As CheckedListBox, currentCheckedList As CheckedListBox, updateCallBack As Action)
        If e.NewValue = 0 Then
            If (currentCheckedList.Items.Count > 0 And currentCheckedList.Items.Count <= checkedList.Items.Count) Then
                currentCheckedList.SetItemCheckState(e.Index, e.NewValue)
            End If
        Else
            If (currentCheckedList.Items.Count > 0 And currentCheckedList.Items.Count = checkedList.Items.Count) Then
                currentCheckedList.SetItemCheckState(e.Index, e.NewValue)
            End If
        End If
        updateCallBack()
    End Sub
    Private Sub GraphiqueProduction_CheckedChanged(sender As Object, e As EventArgs) Handles GraphiqueProduction.CheckedChanged
        ToggleTableChart(GraphiqueProduction, TableauProduction, VarieteProductionCommandeChart, DataVarieteProduction)
    End Sub

    Private Sub DateDebutProduction_ValueChanged(sender As Object, e As EventArgs) Handles DateDebutProduction.ValueChanged
        LoadVarieteProductionChart()
    End Sub

    Private Sub DateFinProduction_ValueChanged(sender As Object, e As EventArgs) Handles DateFinProduction.ValueChanged
        LoadVarieteProductionChart()
    End Sub

    Private Sub FiltrerParDateGen_CheckedChanged(sender As Object, e As EventArgs) Handles FiltrerDateGen.CheckedChanged
        ToggleDatePickers(FiltrerDateGen, DateDebutGen, DateFinGen, AddressOf LoadCommandeProductionChart)
    End Sub

    Private Sub DateDebutGen_ValueChanged(sender As Object, e As EventArgs) Handles DateDebutGen.ValueChanged
        LoadCommandeProductionChart()
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

    Private Sub FiltrerVariete_CheckedChanged(sender As Object, e As EventArgs) Handles FiltrerVariete.CheckedChanged
        Timer2.Start()
        LoadVarieteProductionChart()
    End Sub

    Private Sub FiltrerLocalite_CheckedChanged(sender As Object, e As EventArgs) Handles FiltrerLocalite.CheckedChanged
        Timer3.Start()
        LoadVarieteProductionChart()
    End Sub

    Private Sub FiltrerNiveau_CheckedChanged(sender As Object, e As EventArgs) Handles FiltrerNiveau.CheckedChanged
        Timer4.Start()
        LoadVarieteProductionChart()
    End Sub

    Private Sub FiltrerParDateProduction_CheckedChanged(sender As Object, e As EventArgs) Handles FiltrerParDateProduction.CheckedChanged
        Timer5.Start()
        If FiltrerParDateProduction.Checked = False Then
            LoadVarieteProductionChart()
        End If
    End Sub
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        CollapseElement(PanelVariete, Timer2, isVarieteCollapsed)
    End Sub
    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        CollapseElement(PanelLocalite, Timer3, isLocaliteCollapsed)
    End Sub
    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        CollapseElement(PanelNiveau, Timer4, isNiveauCollapsed)
    End Sub
    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        CollapseElement(PanelDate, Timer5, isDateCollapsed)
    End Sub

    Private Sub CollapseElement(panel As Panel, timer As Timer, ByRef isCollapsed As Boolean)
        If isCollapsed = True Then
            panel.Height += 10
            If panel.Size.Height = panel.MaximumSize.Height Then
                timer.Stop()
                isCollapsed = False
            End If
        Else
            panel.Height -= 10
            If panel.Size.Height = panel.MinimumSize.Height Then
                timer.Stop()
                isCollapsed = True
            End If
        End If
    End Sub

    Private Sub TableauProduction_CheckedChanged(sender As Object, e As EventArgs) Handles TableauProduction.CheckedChanged
        ToggleTableChart(GraphiqueProduction, TableauProduction, VarieteProductionCommandeChart, DataVarieteProduction)
    End Sub

    Private Sub VueParSpeculation_CheckedChanged_1(sender As Object, e As EventArgs) Handles VueParSpeculation.CheckedChanged
        ToggleDetailPanel(VueParVariete, PanelVueParVariete, AddressOf LoadVarieteProductionChart)
    End Sub
    Private Sub ToggleDetailPanel(check As RadioButton, panel As Panel, updateCallBack As Action)
        panel.Visible = check.Checked

        updateCallBack()
    End Sub
    Private Sub Tableau_CheckedChanged(sender As Object, e As EventArgs) Handles Tableau.CheckedChanged
        ToggleTableChart(Graphique, Tableau, VarieteCommandeLivraisonChart, DataCommandeLivraison)
    End Sub
    Private Sub Graphique_CheckedChanged_1(sender As Object, e As EventArgs) Handles Graphique.CheckedChanged
        ToggleTableChart(Graphique, Tableau, VarieteCommandeLivraisonChart, DataCommandeLivraison)
    End Sub

    Private Sub VueDetailleeCommande_CheckedChanged(sender As Object, e As EventArgs) Handles VueDetailleeCommande.CheckedChanged
        ToggleDetailPanel(VueDetailleeCommande, PanelDetailCommande, AddressOf LoadVarieteChart)
    End Sub

    Private Sub FiltrerVarieteCommande_CheckedChanged(sender As Object, e As EventArgs) Handles FiltrerVarieteCommande.CheckedChanged
        Timer6.Start()
        LoadVarieteChart()
    End Sub

    Private Sub FiltrerLocaliteCommande_CheckedChanged(sender As Object, e As EventArgs) Handles FiltrerLocaliteCommande.CheckedChanged
        Timer7.Start()
        LoadVarieteChart()
    End Sub

    Private Sub FiltrerNiveauCommande_CheckedChanged(sender As Object, e As EventArgs) Handles FiltrerNiveauCommande.CheckedChanged
        Timer8.Start()
        LoadVarieteChart()
    End Sub

    Private Sub FiltrerClientCommande_CheckedChanged(sender As Object, e As EventArgs) Handles FiltrerClientCommande.CheckedChanged
        Timer9.Start()
        LoadVarieteChart()
    End Sub

    Private Sub FiltrerDateCommande_CheckedChanged(sender As Object, e As EventArgs) Handles FiltrerDateCommande.CheckedChanged
        Timer10.Start()
        If FiltrerDateCommande.Checked = False Then
            LoadVarieteChart()
        End If
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        CollapseElement(PanelVarieteCommande, Timer6, isVarieteCollapsedCommande)
    End Sub
    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        CollapseElement(PanelLocaliteCommande, Timer7, isLocaliteCollapsedCommande)
    End Sub
    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick
        CollapseElement(PanelNiveauCommande, Timer8, isNiveauCollapsedCommande)
    End Sub
    Private Sub Timer9_Tick(sender As Object, e As EventArgs) Handles Timer9.Tick
        CollapseElement(PanelClientCommande, Timer9, isClientCollapsedCommande)
    End Sub

    Private Sub Timer10_Tick(sender As Object, e As EventArgs) Handles Timer10.Tick
        CollapseElement(PanelDateCommande, Timer10, isDateCollapsedCommande)
    End Sub

    Private Sub TableauGen_CheckedChanged(sender As Object, e As EventArgs) Handles TableauGen.CheckedChanged
        ToggleTableChart(GraphiqueGen, TableauGen, CommandeProductionChart, DataCommandeProduction)
    End Sub
    Private Sub GraphiqueGen_CheckedChanged(sender As Object, e As EventArgs) Handles GraphiqueGen.CheckedChanged
        ToggleTableChart(GraphiqueGen, TableauGen, CommandeProductionChart, DataCommandeProduction)
    End Sub

    Private Sub VueDetailleeGen_CheckedChanged(sender As Object, e As EventArgs) Handles VueDetailleeGen.CheckedChanged
        ToggleDetailPanel(VueDetailleeGen, PanelDetailGen, AddressOf LoadCommandeProductionChart)
    End Sub

    Private Sub GenVarieteCheckedList_ItemCheck(sender As CheckedListBox, e As ItemCheckEventArgs) Handles GenVarieteCheckedList.ItemCheck
        UpdateChartOnCheck(e, checkedList:=GenVarieteCheckedList, currentCheckedList:=CurrentGenVarieteCheckedList, updateCallBack:=AddressOf LoadCommandeProductionChart)
    End Sub

    Private Sub GenLocaliteCheckedList_ItemCheck(sender As CheckedListBox, e As ItemCheckEventArgs) Handles GenLocaliteCheckedList.ItemCheck
        UpdateChartOnCheck(e, checkedList:=GenLocaliteCheckedList, currentCheckedList:=CurrentGenLocaliteCheckedList, updateCallBack:=AddressOf LoadCommandeProductionChart)
    End Sub

    Private Sub GenNiveauCheckedList_ItemCheck(sender As CheckedListBox, e As ItemCheckEventArgs) Handles GenNiveauCheckedList.ItemCheck
        UpdateChartOnCheck(e, checkedList:=GenNiveauCheckedList, currentCheckedList:=CurrentGenNiveauCheckedList, updateCallBack:=AddressOf LoadCommandeProductionChart)
    End Sub

    Private Sub GenClientCheckedList_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles GenClientCheckedList.ItemCheck
        UpdateChartOnCheck(e, checkedList:=GenClientCheckedList, currentCheckedList:=CurrentGenClientCheckedList, updateCallBack:=AddressOf LoadCommandeProductionChart)
    End Sub

    Private Sub Timer11_Tick(sender As Object, e As EventArgs) Handles Timer11.Tick
        CollapseElement(PanelVarieteGen, Timer11, isVarieteCollapsedGen)
    End Sub
    Private Sub Timer12_Tick(sender As Object, e As EventArgs) Handles Timer12.Tick
        CollapseElement(PanelLocaliteGen, Timer12, isLocaliteCollapsedGen)
    End Sub
    Private Sub Timer13_Tick(sender As Object, e As EventArgs) Handles Timer13.Tick
        CollapseElement(PanelNiveauGen, Timer13, isNiveauCollapsedGen)
    End Sub
    Private Sub Timer14_Tick(sender As Object, e As EventArgs) Handles Timer14.Tick
        CollapseElement(PanelClientGen, Timer14, isClientCollapsedGen)
    End Sub
    Private Sub Timer15_Tick(sender As Object, e As EventArgs) Handles Timer15.Tick
        CollapseElement(PanelDateGen, Timer15, isDateCollapsedGen)
    End Sub
    Private Sub FiltrerVarieteGen_CheckedChanged(sender As Object, e As EventArgs) Handles FiltrerVarieteGen.CheckedChanged
        Timer11.Start()
        LoadCommandeProductionChart()
    End Sub

    Private Sub FiltrerLocaliteGen_CheckedChanged(sender As Object, e As EventArgs) Handles FiltrerLocaliteGen.CheckedChanged
        Timer12.Start()
        LoadCommandeProductionChart()
    End Sub

    Private Sub FiltrerNiveauGen_CheckedChanged(sender As Object, e As EventArgs) Handles FiltrerNiveauGen.CheckedChanged
        Timer13.Start()
        LoadCommandeProductionChart()
    End Sub

    Private Sub FiltrerClientGen_CheckedChanged(sender As Object, e As EventArgs) Handles FiltrerClientGen.CheckedChanged
        Timer14.Start()
        LoadCommandeProductionChart()
    End Sub

    Private Sub FiltrerDateGen_CheckedChanged(sender As Object, e As EventArgs) Handles FiltrerDateGen.CheckedChanged
        Timer15.Start()
        If FiltrerDateGen.Checked = False Then
            LoadCommandeProductionChart()
        End If
    End Sub

End Class

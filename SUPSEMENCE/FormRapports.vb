Imports System.Windows.Forms
Imports LiveCharts
Imports LiveCharts.Wpf
Imports MySql.Data.MySqlClient

Public Class FormRapports
    Private connection As MySqlConnection = DBConnection.connection
    Private Sub FormRapports_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'SemencesDataSet.commande'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.CommandeTableAdapter.Fill(Me.SemencesDataSet.commande)
        LoadSpeculationChart()
        LoadCommandeLivraisonChart()
        FillSpeculationInstitution()
        LoadVarieteChart()
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

        NomSpeculation.DisplayMember = dataTable.Columns("nom_speculation").ToString()
        NomSpeculation.ValueMember = dataTable.Columns("id_speculation").ToString()
    End Sub

    Private Sub FillVarieteCheckBoxList()
        Dim query = "select nom_variete 
                     from variete_institution vi 
                     inner join variete v on v.id_variete=vi.id_variete
                     where id_institution=@id_institution and id_speculation=@id_speculation"

        Dim command = New MySqlCommand(query, connection)

        command.Parameters.AddWithValue("@id_institution", DBConnection.id_institution)
        command.Parameters.AddWithValue("@id_speculation", NomSpeculation.SelectedValue)


        Dim reader = command.ExecuteReader()

        CheckedListBox1.Items.Clear()
        While reader.Read()
            CheckedListBox1.Items.Add(reader.GetString("nom_variete"), True)
        End While
        reader.Close()
    End Sub

    Private Sub LoadVarieteChart()
        Dim getVarieteCommandee = $"select id_speculation, nom_variete, sum(quantite) quantite
                                    from commande c
                                    inner join production p on p.id_production=c.id_production
                                    inner join variete_institution vi on vi.id_variete_institution=p.id_variete_institution
                                    inner join variete v on v.id_variete=vi.id_variete
                                    where (p.id_institution=@id_institution and v.id_speculation={NomSpeculation.SelectedValue})
                                    group by nom_variete"

        Dim getVarieteLivree = $"select id_speculation, nom_variete, sum(quantite) quantite 
                                from commande c
                                inner join production p on p.id_production=c.id_production
                                inner join variete_institution vi on vi.id_variete_institution=p.id_variete_institution
                                inner join variete v on v.id_variete=vi.id_variete 
                                where (p.id_institution=@id_institution and v.id_speculation={NomSpeculation.SelectedValue} and c.est_enlevee=1)
                                group by nom_variete"

        FillChart(Chart3, getVarieteCommandee, getVarieteLivree, "Quantité commandée en KG", "Quantité livrée en KG", "nom_variete", "quantite")
        Try
            Dim speculation = NomSpeculation.Text
            If speculation.Length > 1 Then
                Chart3.Titles.FindByName("Title3").Text = speculation.Substring(0, 1).ToUpper() + speculation.Substring(1).ToLower()
            End If
        Catch ex As Exception
            Chart3.Titles.FindByName("Title3").Text = "Variétés"
        End Try


    End Sub
    Private Sub DisplayMap()

        Dim geoMap = New LiveCharts.WinForms.GeoMap()

        Dim keyValues As New Dictionary(Of String, Double)

        keyValues.Add("6977", 1179) 'Sédhiou
        'keyValues.Add("6976", 85) 'Kédougou
        keyValues.Add("6978", 7384) 'Kaffrine
        'keyValues.Add("6975", 0) 'Saint Louis
        keyValues.Add("1178", 29046) 'Dakar
        keyValues.Add("1179", 2233) 'Diourbel
        keyValues.Add("1180", 25233) 'Fatick
        keyValues.Add("1181", 233) 'Kaolack
        keyValues.Add("1182", 2523) 'Louga
        'keyValues.Add("1183", 5233) 'Matam
        keyValues.Add("1184", 9849) 'Thiès
        keyValues.Add("680", 3579) 'Kolda
        keyValues.Add("681", 1179) 'Ziguinchor
        keyValues.Add("682", 81285) 'Tambacounda

        geoMap.HeatMap = keyValues

        geoMap.Source = $"{Application.StartupPath}\Senegal.xml"
        Me.Controls.Add(geoMap)
        geoMap.Dock = DockStyle.Fill
    End Sub

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


        CartesianChart1.Series = New SeriesCollection From {
                New ColumnSeries With {
                    .Title = "",
                    .Values = values,
                    .FontSize = fontSize
                }
            }

        CartesianChart1.AxisX.Add(New Axis With {
                .Title = "Spéculation",
                .Labels = labels,
                .FontSize = fontSize
            })
        CartesianChart1.AxisY.Add(New Axis With {
                .Title = "Quantite produite (en KG)",
                .FontSize = fontSize
            })


        reader.Close()
    End Sub
    Private Sub InitChart(chart As DataVisualization.Charting.Chart, serieName1 As String, serieName2 As String)
        chart.Series(serieName1).LabelForeColor = chart.Series(serieName1).Color
        chart.Series(serieName2).LabelForeColor = chart.Series(serieName2).Color

        For Each title In chart.Titles
            title.ForeColor = Color.DimGray
        Next

        chart.ChartAreas(0).AxisX.MajorGrid.LineWidth = 0
        chart.ChartAreas(0).AxisY.MajorGrid.LineWidth = 0

    End Sub

    Private Sub FillChartSeries(chart As DataVisualization.Charting.Chart, query As String, seriesName As String, keyName As String, valueName As String)

        Dim command = New MySqlCommand(query, connection)

        command.Parameters.AddWithValue("@id_institution", DBConnection.id_institution)


        Dim reader = command.ExecuteReader()

        chart.Series(seriesName).Points.Clear()
        While reader.Read()
            chart.Series(seriesName).Points.AddXY($"{reader.GetString(keyName)}", reader.GetUInt64(valueName))
        End While
        reader.Close()
    End Sub

    Private Sub FillChart(chart As DataVisualization.Charting.Chart, query1 As String, query2 As String, seriesName1 As String, seriesName2 As String, keyName As String, valueName As String)
        InitChart(chart, seriesName1, seriesName2)

        FillChartSeries(
            chart:=chart,
            query:=query1,
            seriesName:=seriesName1,
            keyName:=keyName,
            valueName:=valueName
            )

        FillChartSeries(
            chart:=chart,
            query:=query2,
            seriesName:=seriesName2,
            keyName:=keyName,
            valueName:=valueName
            )

    End Sub

    Private Sub LoadCommandeLivraisonChart()
        Dim query1 = "select numero_de_commade, nom_speculation, sum(quantite) quantite from commande c 
                        inner join production p on p.id_production = c.id_production
                        inner join variete_institution vi on vi.id_variete_institution = p.id_variete_institution
                        inner join variete v on vi.id_variete = v.id_variete
                        inner join speculation s on s.id_speculation = v.id_speculation
                        where vi.id_institution = @id_institution
                        group by s.nom_speculation"
        Dim query2 = "select numero_de_commade, nom_speculation, sum(quantite) quantite from commande c 
                        inner join production p on p.id_production = c.id_production
                        inner join variete_institution vi on vi.id_variete_institution = p.id_variete_institution
                        inner join variete v on vi.id_variete = v.id_variete
                        inner join speculation s on s.id_speculation = v.id_speculation
                        where vi.id_institution = @id_institution and est_enlevee = 1
                        group by s.nom_speculation"
        FillChart(Chart1, query1, query2, "Quantité commandée en KG", "Quantité livrée en KG", "nom_speculation", "quantite")


        Dim query3 = "select nom_speculation, sum(quantite_produite) quantite
                             from production p
                             inner join variete_institution vi on vi.id_variete_institution=p.id_variete_institution
                             inner join variete v on v.id_variete = vi.id_variete
                             inner join speculation s on s.id_speculation = v.id_speculation
                             where vi.id_institution = @id_institution 
                             group by nom_speculation"
        Dim query4 = "select numero_de_commade, nom_speculation, sum(quantite) quantite from commande c 
                        inner join production p on p.id_production = c.id_production
                        inner join variete_institution vi on vi.id_variete_institution = p.id_variete_institution
                        inner join variete v on vi.id_variete = v.id_variete
                        inner join speculation s on s.id_speculation = v.id_speculation
                        where vi.id_institution = @id_institution
                        group by s.nom_speculation"
        FillChart(Chart2, query3, query4, "Quantité commandée en KG", "Quantité produite en KG", "nom_speculation", "quantite")

    End Sub

    Private Sub NomSpeculation_SelectedIndexChanged(sender As Object, e As EventArgs) Handles NomSpeculation.SelectedIndexChanged
        'Try
        LoadVarieteChart()
        FillVarieteCheckBoxList()
        'Catch ex As Exception

        'End Try
    End Sub

    Private Sub CheckedListBox1_ItemCheck(sender As CheckedListBox, e As ItemCheckEventArgs) Handles CheckedListBox1.ItemCheck
        Dim values = ""
        Dim items = CheckedListBox1.CheckedItems
        'CheckedListBox1.CheckedItems.CopyTo(items, 0)

        If items.Count > 0 Then
            For Each item In items
                values = $"{values}, '{item}'"
            Next
            MessageBox.Show(values.Substring(2))
            MessageBox.Show(e.Index)
            MessageBox.Show(e.NewValue)
            MessageBox.Show(e.CurrentValue)
            MessageBox.Show(CheckedListBox1.Items.Item(e.Index).ToString())
        End If
    End Sub
End Class

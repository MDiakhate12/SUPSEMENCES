<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormRapports
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ChartArea4 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend4 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series7 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title10 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim Title11 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim Title12 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea5 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend5 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series8 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series9 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title13 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim Title14 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim Title15 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea6 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend6 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series10 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title16 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim Title17 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim Title18 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SpeculationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CommandeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.General = New System.Windows.Forms.TabPage()
        Me.CommandeProductionChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Commandes = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DateFin = New System.Windows.Forms.DateTimePicker()
        Me.DateDebut = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ClientCommandeCheckedList = New System.Windows.Forms.CheckedListBox()
        Me.FiltrerParDate = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.VarieteCommandeCheckedList = New System.Windows.Forms.CheckedListBox()
        Me.NomSpeculationCommande = New System.Windows.Forms.ComboBox()
        Me.NomSpeculationLabel = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Tableau = New System.Windows.Forms.RadioButton()
        Me.Graphique = New System.Windows.Forms.RadioButton()
        Me.VarieteCommandeLivraisonChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.DataCommandeLivraison = New System.Windows.Forms.DataGridView()
        Me.TabRapports = New System.Windows.Forms.TabControl()
        Me.Production = New System.Windows.Forms.TabPage()
        Me.VarieteProductionCommandeChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DateFinProduction = New System.Windows.Forms.DateTimePicker()
        Me.DateDebutProduction = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.NiveauCheckedList = New System.Windows.Forms.CheckedListBox()
        Me.LocaliteLabel = New System.Windows.Forms.Label()
        Me.LocaliteCheckedList = New System.Windows.Forms.CheckedListBox()
        Me.FiltrerParDateProduction = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.VarieteProductionCheckedList = New System.Windows.Forms.CheckedListBox()
        Me.NomSpeculationProduction = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TableauProduction = New System.Windows.Forms.RadioButton()
        Me.GraphiqueProduction = New System.Windows.Forms.RadioButton()
        Me.DataVarieteProduction = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DateFinGen = New System.Windows.Forms.DateTimePicker()
        Me.DateDebutGen = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GenNiveauCheckedList = New System.Windows.Forms.CheckedListBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GenLocaliteCheckedList = New System.Windows.Forms.CheckedListBox()
        Me.FiltrerParDateGen = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GenVarieteCheckedList = New System.Windows.Forms.CheckedListBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TableauGen = New System.Windows.Forms.RadioButton()
        Me.GraphiqueGen = New System.Windows.Forms.RadioButton()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GenClientCheckedList = New System.Windows.Forms.CheckedListBox()
        Me.DataCommandeProduction = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        CType(Me.SpeculationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommandeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.General.SuspendLayout()
        CType(Me.CommandeProductionChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Commandes.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.VarieteCommandeLivraisonChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataCommandeLivraison, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabRapports.SuspendLayout()
        Me.Production.SuspendLayout()
        CType(Me.VarieteProductionCommandeChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataVarieteProduction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataCommandeProduction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CommandeBindingSource
        '
        Me.CommandeBindingSource.DataMember = "commande"
        '
        'General
        '
        Me.General.Controls.Add(Me.CommandeProductionChart)
        Me.General.Controls.Add(Me.DataCommandeProduction)
        Me.General.Controls.Add(Me.Panel1)
        Me.General.Location = New System.Drawing.Point(4, 44)
        Me.General.Name = "General"
        Me.General.Padding = New System.Windows.Forms.Padding(3)
        Me.General.Size = New System.Drawing.Size(1204, 701)
        Me.General.TabIndex = 1
        Me.General.Text = "Statistiques générales"
        Me.General.UseVisualStyleBackColor = True
        '
        'CommandeProductionChart
        '
        Me.CommandeProductionChart.BackSecondaryColor = System.Drawing.Color.White
        Me.CommandeProductionChart.BorderlineColor = System.Drawing.Color.Black
        Me.CommandeProductionChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
        ChartArea4.Name = "ChartArea1"
        Me.CommandeProductionChart.ChartAreas.Add(ChartArea4)
        Me.CommandeProductionChart.Cursor = System.Windows.Forms.Cursors.Hand
        Legend4.Alignment = System.Drawing.StringAlignment.Far
        Legend4.DockedToChartArea = "ChartArea1"
        Legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Legend4.IsDockedInsideChartArea = False
        Legend4.IsTextAutoFit = False
        Legend4.Name = "Legend1"
        Me.CommandeProductionChart.Legends.Add(Legend4)
        Me.CommandeProductionChart.Location = New System.Drawing.Point(0, 1)
        Me.CommandeProductionChart.Name = "CommandeProductionChart"
        Me.CommandeProductionChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent
        Series6.ChartArea = "ChartArea1"
        Series6.Color = System.Drawing.Color.PaleVioletRed
        Series6.EmptyPointStyle.BorderColor = System.Drawing.Color.DarkRed
        Series6.EmptyPointStyle.BorderWidth = 2
        Series6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series6.Label = "#VAL"
        Series6.LabelForeColor = System.Drawing.Color.DarkGreen
        Series6.Legend = "Legend1"
        Series6.Name = "Quantité commandée en KG"
        Series6.ToolTip = "#VAL KG"
        Series7.ChartArea = "ChartArea1"
        Series7.Color = System.Drawing.Color.PeachPuff
        Series7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series7.IsValueShownAsLabel = True
        Series7.Label = "#VAL"
        Series7.LabelForeColor = System.Drawing.Color.DarkGoldenrod
        Series7.Legend = "Legend1"
        Series7.Name = "Quantité produite en KG"
        Series7.ToolTip = "#VAL KG"
        Me.CommandeProductionChart.Series.Add(Series6)
        Me.CommandeProductionChart.Series.Add(Series7)
        Me.CommandeProductionChart.Size = New System.Drawing.Size(675, 536)
        Me.CommandeProductionChart.TabIndex = 4
        Me.CommandeProductionChart.Text = "Chart2"
        Title10.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left
        Title10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title10.ForeColor = System.Drawing.Color.DarkGreen
        Title10.Name = "Title1"
        Title10.Text = "Quantité en KG"
        Title11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title11.ForeColor = System.Drawing.Color.DarkGreen
        Title11.Name = "Title2"
        Title11.Text = "Quantité commandée / Quantité produite"
        Title12.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom
        Title12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title12.ForeColor = System.Drawing.Color.DarkGreen
        Title12.Name = "Title3"
        Title12.Text = "Spéculations"
        Me.CommandeProductionChart.Titles.Add(Title10)
        Me.CommandeProductionChart.Titles.Add(Title11)
        Me.CommandeProductionChart.Titles.Add(Title12)
        '
        'Commandes
        '
        Me.Commandes.Controls.Add(Me.Panel2)
        Me.Commandes.Controls.Add(Me.VarieteCommandeLivraisonChart)
        Me.Commandes.Controls.Add(Me.DataCommandeLivraison)
        Me.Commandes.Location = New System.Drawing.Point(4, 44)
        Me.Commandes.Name = "Commandes"
        Me.Commandes.Size = New System.Drawing.Size(1204, 701)
        Me.Commandes.TabIndex = 2
        Me.Commandes.Text = "Commandes"
        Me.Commandes.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.DateFin)
        Me.Panel2.Controls.Add(Me.DateDebut)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.ClientCommandeCheckedList)
        Me.Panel2.Controls.Add(Me.FiltrerParDate)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.VarieteCommandeCheckedList)
        Me.Panel2.Controls.Add(Me.NomSpeculationCommande)
        Me.Panel2.Controls.Add(Me.NomSpeculationLabel)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(887, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(317, 701)
        Me.Panel2.TabIndex = 5
        '
        'DateFin
        '
        Me.DateFin.CustomFormat = "yyyy-MM-dd"
        Me.DateFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFin.Location = New System.Drawing.Point(7, 522)
        Me.DateFin.Name = "DateFin"
        Me.DateFin.Size = New System.Drawing.Size(263, 26)
        Me.DateFin.TabIndex = 21
        Me.DateFin.Visible = False
        '
        'DateDebut
        '
        Me.DateDebut.CustomFormat = "yyyy-MM-dd"
        Me.DateDebut.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateDebut.Location = New System.Drawing.Point(7, 471)
        Me.DateDebut.Name = "DateDebut"
        Me.DateDebut.Size = New System.Drawing.Size(263, 26)
        Me.DateDebut.TabIndex = 20
        Me.DateDebut.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(4, 203)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Clients"
        '
        'ClientCommandeCheckedList
        '
        Me.ClientCommandeCheckedList.CheckOnClick = True
        Me.ClientCommandeCheckedList.FormattingEnabled = True
        Me.ClientCommandeCheckedList.Location = New System.Drawing.Point(7, 222)
        Me.ClientCommandeCheckedList.Name = "ClientCommandeCheckedList"
        Me.ClientCommandeCheckedList.Size = New System.Drawing.Size(263, 88)
        Me.ClientCommandeCheckedList.TabIndex = 18
        '
        'FiltrerParDate
        '
        Me.FiltrerParDate.AutoSize = True
        Me.FiltrerParDate.Location = New System.Drawing.Point(7, 431)
        Me.FiltrerParDate.Name = "FiltrerParDate"
        Me.FiltrerParDate.Size = New System.Drawing.Size(131, 24)
        Me.FiltrerParDate.TabIndex = 15
        Me.FiltrerParDate.Text = "Filtrer par date"
        Me.FiltrerParDate.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(4, 75)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Variétés"
        '
        'VarieteCommandeCheckedList
        '
        Me.VarieteCommandeCheckedList.CheckOnClick = True
        Me.VarieteCommandeCheckedList.FormattingEnabled = True
        Me.VarieteCommandeCheckedList.Location = New System.Drawing.Point(7, 94)
        Me.VarieteCommandeCheckedList.Name = "VarieteCommandeCheckedList"
        Me.VarieteCommandeCheckedList.Size = New System.Drawing.Size(263, 88)
        Me.VarieteCommandeCheckedList.TabIndex = 13
        '
        'NomSpeculationCommande
        '
        Me.NomSpeculationCommande.AutoCompleteCustomSource.AddRange(New String() {"IRAT 10", "Dj 8-341", "ITA 150", "WAB 56-50", "Nerica 1", "Nerica 5", "Nerica 6 ", "Dj 684 D", "Dj 11-509", "Dj 12-519", "BW 248-1", "BR 51-46-5", "ITA 123", "Tox 728-1", "BG 90-2 ", "Rok 5", "WAR 1", "WAR 77-3-2-2", "WAR 81-2-1-3-2", "Ikong Pao", "IR 8", "Jaya", "IR 1529-680-3", "IR 442", "KH 998", "Kwang She Shun", "Sahel 108", "Sahel 134", "Sahel 159", "Sahel 177", "Sahel 201", "Sahel 202 ", "Sahel 208", "Sahel 209", "Sahel 210", "Sahel 217", "Sahel 222", "Sahel 305", "Sahel 317", "Sahel 328", "Sahel 329", "Nerica-S-19", "Nerica-S-21", "Nerica-S-36", "Nerica-S-44", "Souna 3", "IBV 8001", "IBV 8004", "IBMV 8402", "ISMI 9507", "Gawane", "Thialack 2", "Xéewel Gi", "Noor 96", "Doo Mer", "Sooror", "Gaaw Na", "Jaboot", "Goor Yomboul", "Yaayi Séex ", "28-206", "756-A", "55-437", "57-313", "57-422", "69-101", "73-27", "73-28", "73-30", "73-33", "GC 8-35", "Fleur 11", "78-937", "55-33", "SRV 1-19", "73-9-11", "GH 119-20", "PC79-79", "H 75-0", "58-57", "Ndiambour", "Mougne", "Bambey 21", "TN 88-63", "CB-5", "Diongoma", "Mélakh", "Mouride", "Yacine", "Pakau ", "58-74 f", "66-35 f", "Noflaye", "Gandiole", "Gao", "Solara", "Sirocco", "Julio", "Damani", "Belami", "Alizé ", "CE 145-66", "CE 151-262", "CE 180-33", "CE 196-7-2-1", "F2-20", "Faourou", "Nguinte", "Nganda", "Darou "})
        Me.NomSpeculationCommande.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.NomSpeculationCommande.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.NomSpeculationCommande.DataSource = Me.SpeculationBindingSource
        Me.NomSpeculationCommande.DisplayMember = "id_speculation"
        Me.NomSpeculationCommande.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomSpeculationCommande.FormattingEnabled = True
        Me.NomSpeculationCommande.Location = New System.Drawing.Point(7, 32)
        Me.NomSpeculationCommande.Margin = New System.Windows.Forms.Padding(2)
        Me.NomSpeculationCommande.Name = "NomSpeculationCommande"
        Me.NomSpeculationCommande.Size = New System.Drawing.Size(125, 24)
        Me.NomSpeculationCommande.TabIndex = 10
        Me.NomSpeculationCommande.ValueMember = "id_speculation"
        '
        'NomSpeculationLabel
        '
        Me.NomSpeculationLabel.AutoSize = True
        Me.NomSpeculationLabel.BackColor = System.Drawing.Color.Transparent
        Me.NomSpeculationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomSpeculationLabel.ForeColor = System.Drawing.Color.Black
        Me.NomSpeculationLabel.Location = New System.Drawing.Point(4, 10)
        Me.NomSpeculationLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.NomSpeculationLabel.Name = "NomSpeculationLabel"
        Me.NomSpeculationLabel.Size = New System.Drawing.Size(79, 16)
        Me.NomSpeculationLabel.TabIndex = 11
        Me.NomSpeculationLabel.Text = "Spéculation"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Tableau)
        Me.GroupBox1.Controls.Add(Me.Graphique)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 316)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Affichage"
        '
        'Tableau
        '
        Me.Tableau.AutoSize = True
        Me.Tableau.Location = New System.Drawing.Point(6, 55)
        Me.Tableau.Name = "Tableau"
        Me.Tableau.Size = New System.Drawing.Size(84, 24)
        Me.Tableau.TabIndex = 17
        Me.Tableau.Text = "Tableau"
        Me.Tableau.UseVisualStyleBackColor = True
        '
        'Graphique
        '
        Me.Graphique.AutoSize = True
        Me.Graphique.Checked = True
        Me.Graphique.Location = New System.Drawing.Point(6, 25)
        Me.Graphique.Name = "Graphique"
        Me.Graphique.Size = New System.Drawing.Size(102, 24)
        Me.Graphique.TabIndex = 16
        Me.Graphique.TabStop = True
        Me.Graphique.Text = "Graphique"
        Me.Graphique.UseVisualStyleBackColor = True
        '
        'VarieteCommandeLivraisonChart
        '
        Me.VarieteCommandeLivraisonChart.BackSecondaryColor = System.Drawing.Color.White
        Me.VarieteCommandeLivraisonChart.BorderlineColor = System.Drawing.Color.Black
        Me.VarieteCommandeLivraisonChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
        ChartArea5.Name = "ChartArea1"
        Me.VarieteCommandeLivraisonChart.ChartAreas.Add(ChartArea5)
        Me.VarieteCommandeLivraisonChart.Cursor = System.Windows.Forms.Cursors.Hand
        Legend5.Alignment = System.Drawing.StringAlignment.Far
        Legend5.DockedToChartArea = "ChartArea1"
        Legend5.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Legend5.IsDockedInsideChartArea = False
        Legend5.IsTextAutoFit = False
        Legend5.Name = "Legend1"
        Me.VarieteCommandeLivraisonChart.Legends.Add(Legend5)
        Me.VarieteCommandeLivraisonChart.Location = New System.Drawing.Point(0, 0)
        Me.VarieteCommandeLivraisonChart.Name = "VarieteCommandeLivraisonChart"
        Me.VarieteCommandeLivraisonChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
        Series8.ChartArea = "ChartArea1"
        Series8.Color = System.Drawing.Color.LightSeaGreen
        Series8.EmptyPointStyle.BorderColor = System.Drawing.Color.DarkRed
        Series8.EmptyPointStyle.BorderWidth = 2
        Series8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series8.Label = "#VAL"
        Series8.LabelForeColor = System.Drawing.Color.DarkGray
        Series8.Legend = "Legend1"
        Series8.Name = "Quantité commandée en KG"
        Series8.ToolTip = "#VAL KG"
        Series9.ChartArea = "ChartArea1"
        Series9.Color = System.Drawing.Color.Aquamarine
        Series9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series9.IsValueShownAsLabel = True
        Series9.Label = "#VAL"
        Series9.LabelForeColor = System.Drawing.Color.DarkGray
        Series9.Legend = "Legend1"
        Series9.Name = "Quantité livrée en KG"
        Series9.ToolTip = "#VAL KG"
        Me.VarieteCommandeLivraisonChart.Series.Add(Series8)
        Me.VarieteCommandeLivraisonChart.Series.Add(Series9)
        Me.VarieteCommandeLivraisonChart.Size = New System.Drawing.Size(617, 419)
        Me.VarieteCommandeLivraisonChart.TabIndex = 4
        Me.VarieteCommandeLivraisonChart.Text = "Chart3"
        Title13.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left
        Title13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title13.ForeColor = System.Drawing.Color.DimGray
        Title13.Name = "Title1"
        Title13.Text = "Quantité en KG"
        Title14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title14.ForeColor = System.Drawing.Color.DarkGreen
        Title14.Name = "Title2"
        Title14.Text = "Quantité commandée / Quantité livrée"
        Title15.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom
        Title15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title15.ForeColor = System.Drawing.Color.DarkGreen
        Title15.Name = "Title3"
        Title15.Text = "Spéculations"
        Me.VarieteCommandeLivraisonChart.Titles.Add(Title13)
        Me.VarieteCommandeLivraisonChart.Titles.Add(Title14)
        Me.VarieteCommandeLivraisonChart.Titles.Add(Title15)
        '
        'DataCommandeLivraison
        '
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.White
        Me.DataCommandeLivraison.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle17
        Me.DataCommandeLivraison.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataCommandeLivraison.BackgroundColor = System.Drawing.Color.White
        Me.DataCommandeLivraison.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataCommandeLivraison.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle18.NullValue = "-"
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataCommandeLivraison.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle18
        Me.DataCommandeLivraison.ColumnHeadersHeight = 40
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataCommandeLivraison.DefaultCellStyle = DataGridViewCellStyle19
        Me.DataCommandeLivraison.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DataCommandeLivraison.EnableHeadersVisualStyles = False
        Me.DataCommandeLivraison.Location = New System.Drawing.Point(0, 1)
        Me.DataCommandeLivraison.Margin = New System.Windows.Forms.Padding(2)
        Me.DataCommandeLivraison.Name = "DataCommandeLivraison"
        Me.DataCommandeLivraison.ReadOnly = True
        Me.DataCommandeLivraison.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataCommandeLivraison.RowHeadersDefaultCellStyle = DataGridViewCellStyle20
        Me.DataCommandeLivraison.RowTemplate.Height = 24
        Me.DataCommandeLivraison.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataCommandeLivraison.Size = New System.Drawing.Size(617, 419)
        Me.DataCommandeLivraison.TabIndex = 25
        Me.DataCommandeLivraison.Visible = False
        '
        'TabRapports
        '
        Me.TabRapports.Controls.Add(Me.Production)
        Me.TabRapports.Controls.Add(Me.Commandes)
        Me.TabRapports.Controls.Add(Me.General)
        Me.TabRapports.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabRapports.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabRapports.ItemSize = New System.Drawing.Size(62, 40)
        Me.TabRapports.Location = New System.Drawing.Point(0, 0)
        Me.TabRapports.Name = "TabRapports"
        Me.TabRapports.SelectedIndex = 0
        Me.TabRapports.Size = New System.Drawing.Size(1212, 749)
        Me.TabRapports.TabIndex = 0
        '
        'Production
        '
        Me.Production.Controls.Add(Me.VarieteProductionCommandeChart)
        Me.Production.Controls.Add(Me.Panel3)
        Me.Production.Controls.Add(Me.DataVarieteProduction)
        Me.Production.Location = New System.Drawing.Point(4, 44)
        Me.Production.Name = "Production"
        Me.Production.Padding = New System.Windows.Forms.Padding(3)
        Me.Production.Size = New System.Drawing.Size(1204, 701)
        Me.Production.TabIndex = 3
        Me.Production.Text = "Production"
        Me.Production.UseVisualStyleBackColor = True
        '
        'VarieteProductionCommandeChart
        '
        Me.VarieteProductionCommandeChart.BackSecondaryColor = System.Drawing.Color.White
        Me.VarieteProductionCommandeChart.BorderlineColor = System.Drawing.Color.Black
        Me.VarieteProductionCommandeChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
        ChartArea6.Name = "ChartArea1"
        Me.VarieteProductionCommandeChart.ChartAreas.Add(ChartArea6)
        Me.VarieteProductionCommandeChart.Cursor = System.Windows.Forms.Cursors.Hand
        Legend6.Alignment = System.Drawing.StringAlignment.Far
        Legend6.DockedToChartArea = "ChartArea1"
        Legend6.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Legend6.IsDockedInsideChartArea = False
        Legend6.IsTextAutoFit = False
        Legend6.Name = "Legend1"
        Me.VarieteProductionCommandeChart.Legends.Add(Legend6)
        Me.VarieteProductionCommandeChart.Location = New System.Drawing.Point(0, 1)
        Me.VarieteProductionCommandeChart.Name = "VarieteProductionCommandeChart"
        Me.VarieteProductionCommandeChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent
        Series10.ChartArea = "ChartArea1"
        Series10.Color = System.Drawing.Color.PeachPuff
        Series10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series10.IsValueShownAsLabel = True
        Series10.Label = "#VAL"
        Series10.LabelForeColor = System.Drawing.Color.DarkGoldenrod
        Series10.Legend = "Legend1"
        Series10.Name = "Quantité produite en KG"
        Series10.ToolTip = "#VAL KG"
        Me.VarieteProductionCommandeChart.Series.Add(Series10)
        Me.VarieteProductionCommandeChart.Size = New System.Drawing.Size(617, 419)
        Me.VarieteProductionCommandeChart.TabIndex = 28
        Me.VarieteProductionCommandeChart.Text = "Chart3"
        Title16.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left
        Title16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title16.ForeColor = System.Drawing.Color.DarkGreen
        Title16.Name = "Title1"
        Title16.Text = "Quantité en KG"
        Title17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title17.ForeColor = System.Drawing.Color.DarkGreen
        Title17.Name = "Title2"
        Title17.Text = "Quantité produite / Quantité commandée "
        Title18.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom
        Title18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title18.ForeColor = System.Drawing.Color.DarkGreen
        Title18.Name = "Title3"
        Title18.Text = "Spéculations"
        Me.VarieteProductionCommandeChart.Titles.Add(Title16)
        Me.VarieteProductionCommandeChart.Titles.Add(Title17)
        Me.VarieteProductionCommandeChart.Titles.Add(Title18)
        '
        'Panel3
        '
        Me.Panel3.AutoScroll = True
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.DateFinProduction)
        Me.Panel3.Controls.Add(Me.DateDebutProduction)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.NiveauCheckedList)
        Me.Panel3.Controls.Add(Me.LocaliteLabel)
        Me.Panel3.Controls.Add(Me.LocaliteCheckedList)
        Me.Panel3.Controls.Add(Me.FiltrerParDateProduction)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.VarieteProductionCheckedList)
        Me.Panel3.Controls.Add(Me.NomSpeculationProduction)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.GroupBox2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(884, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(317, 695)
        Me.Panel3.TabIndex = 26
        '
        'DateFinProduction
        '
        Me.DateFinProduction.CustomFormat = "yyyy-MM-dd"
        Me.DateFinProduction.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFinProduction.Location = New System.Drawing.Point(13, 627)
        Me.DateFinProduction.Name = "DateFinProduction"
        Me.DateFinProduction.Size = New System.Drawing.Size(263, 26)
        Me.DateFinProduction.TabIndex = 23
        Me.DateFinProduction.Visible = False
        '
        'DateDebutProduction
        '
        Me.DateDebutProduction.CustomFormat = "yyyy-MM-dd"
        Me.DateDebutProduction.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateDebutProduction.Location = New System.Drawing.Point(13, 576)
        Me.DateDebutProduction.Name = "DateDebutProduction"
        Me.DateDebutProduction.Size = New System.Drawing.Size(263, 26)
        Me.DateDebutProduction.TabIndex = 22
        Me.DateDebutProduction.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(4, 300)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 16)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Niveau"
        '
        'NiveauCheckedList
        '
        Me.NiveauCheckedList.CheckOnClick = True
        Me.NiveauCheckedList.FormattingEnabled = True
        Me.NiveauCheckedList.Location = New System.Drawing.Point(7, 319)
        Me.NiveauCheckedList.Name = "NiveauCheckedList"
        Me.NiveauCheckedList.Size = New System.Drawing.Size(263, 88)
        Me.NiveauCheckedList.TabIndex = 20
        '
        'LocaliteLabel
        '
        Me.LocaliteLabel.AutoSize = True
        Me.LocaliteLabel.BackColor = System.Drawing.Color.Transparent
        Me.LocaliteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LocaliteLabel.ForeColor = System.Drawing.Color.Black
        Me.LocaliteLabel.Location = New System.Drawing.Point(4, 190)
        Me.LocaliteLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LocaliteLabel.Name = "LocaliteLabel"
        Me.LocaliteLabel.Size = New System.Drawing.Size(55, 16)
        Me.LocaliteLabel.TabIndex = 19
        Me.LocaliteLabel.Text = "Localité"
        '
        'LocaliteCheckedList
        '
        Me.LocaliteCheckedList.CheckOnClick = True
        Me.LocaliteCheckedList.FormattingEnabled = True
        Me.LocaliteCheckedList.Location = New System.Drawing.Point(7, 209)
        Me.LocaliteCheckedList.Name = "LocaliteCheckedList"
        Me.LocaliteCheckedList.Size = New System.Drawing.Size(263, 88)
        Me.LocaliteCheckedList.TabIndex = 18
        '
        'FiltrerParDateProduction
        '
        Me.FiltrerParDateProduction.AutoSize = True
        Me.FiltrerParDateProduction.Location = New System.Drawing.Point(7, 534)
        Me.FiltrerParDateProduction.Name = "FiltrerParDateProduction"
        Me.FiltrerParDateProduction.Size = New System.Drawing.Size(131, 24)
        Me.FiltrerParDateProduction.TabIndex = 15
        Me.FiltrerParDateProduction.Text = "Filtrer par date"
        Me.FiltrerParDateProduction.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(4, 75)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 16)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Variétés"
        '
        'VarieteProductionCheckedList
        '
        Me.VarieteProductionCheckedList.CheckOnClick = True
        Me.VarieteProductionCheckedList.FormattingEnabled = True
        Me.VarieteProductionCheckedList.Location = New System.Drawing.Point(7, 94)
        Me.VarieteProductionCheckedList.Name = "VarieteProductionCheckedList"
        Me.VarieteProductionCheckedList.Size = New System.Drawing.Size(263, 88)
        Me.VarieteProductionCheckedList.TabIndex = 13
        '
        'NomSpeculationProduction
        '
        Me.NomSpeculationProduction.AutoCompleteCustomSource.AddRange(New String() {"IRAT 10", "Dj 8-341", "ITA 150", "WAB 56-50", "Nerica 1", "Nerica 5", "Nerica 6 ", "Dj 684 D", "Dj 11-509", "Dj 12-519", "BW 248-1", "BR 51-46-5", "ITA 123", "Tox 728-1", "BG 90-2 ", "Rok 5", "WAR 1", "WAR 77-3-2-2", "WAR 81-2-1-3-2", "Ikong Pao", "IR 8", "Jaya", "IR 1529-680-3", "IR 442", "KH 998", "Kwang She Shun", "Sahel 108", "Sahel 134", "Sahel 159", "Sahel 177", "Sahel 201", "Sahel 202 ", "Sahel 208", "Sahel 209", "Sahel 210", "Sahel 217", "Sahel 222", "Sahel 305", "Sahel 317", "Sahel 328", "Sahel 329", "Nerica-S-19", "Nerica-S-21", "Nerica-S-36", "Nerica-S-44", "Souna 3", "IBV 8001", "IBV 8004", "IBMV 8402", "ISMI 9507", "Gawane", "Thialack 2", "Xéewel Gi", "Noor 96", "Doo Mer", "Sooror", "Gaaw Na", "Jaboot", "Goor Yomboul", "Yaayi Séex ", "28-206", "756-A", "55-437", "57-313", "57-422", "69-101", "73-27", "73-28", "73-30", "73-33", "GC 8-35", "Fleur 11", "78-937", "55-33", "SRV 1-19", "73-9-11", "GH 119-20", "PC79-79", "H 75-0", "58-57", "Ndiambour", "Mougne", "Bambey 21", "TN 88-63", "CB-5", "Diongoma", "Mélakh", "Mouride", "Yacine", "Pakau ", "58-74 f", "66-35 f", "Noflaye", "Gandiole", "Gao", "Solara", "Sirocco", "Julio", "Damani", "Belami", "Alizé ", "CE 145-66", "CE 151-262", "CE 180-33", "CE 196-7-2-1", "F2-20", "Faourou", "Nguinte", "Nganda", "Darou "})
        Me.NomSpeculationProduction.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.NomSpeculationProduction.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.NomSpeculationProduction.DataSource = Me.SpeculationBindingSource
        Me.NomSpeculationProduction.DisplayMember = "id_speculation"
        Me.NomSpeculationProduction.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomSpeculationProduction.FormattingEnabled = True
        Me.NomSpeculationProduction.Location = New System.Drawing.Point(7, 32)
        Me.NomSpeculationProduction.Margin = New System.Windows.Forms.Padding(2)
        Me.NomSpeculationProduction.Name = "NomSpeculationProduction"
        Me.NomSpeculationProduction.Size = New System.Drawing.Size(125, 24)
        Me.NomSpeculationProduction.TabIndex = 10
        Me.NomSpeculationProduction.ValueMember = "id_speculation"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(4, 10)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 16)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Spéculation"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TableauProduction)
        Me.GroupBox2.Controls.Add(Me.GraphiqueProduction)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 413)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Affichage"
        '
        'TableauProduction
        '
        Me.TableauProduction.AutoSize = True
        Me.TableauProduction.Location = New System.Drawing.Point(6, 55)
        Me.TableauProduction.Name = "TableauProduction"
        Me.TableauProduction.Size = New System.Drawing.Size(84, 24)
        Me.TableauProduction.TabIndex = 17
        Me.TableauProduction.Text = "Tableau"
        Me.TableauProduction.UseVisualStyleBackColor = True
        '
        'GraphiqueProduction
        '
        Me.GraphiqueProduction.AutoSize = True
        Me.GraphiqueProduction.Checked = True
        Me.GraphiqueProduction.Location = New System.Drawing.Point(6, 25)
        Me.GraphiqueProduction.Name = "GraphiqueProduction"
        Me.GraphiqueProduction.Size = New System.Drawing.Size(102, 24)
        Me.GraphiqueProduction.TabIndex = 16
        Me.GraphiqueProduction.TabStop = True
        Me.GraphiqueProduction.Text = "Graphique"
        Me.GraphiqueProduction.UseVisualStyleBackColor = True
        '
        'DataVarieteProduction
        '
        DataGridViewCellStyle21.BackColor = System.Drawing.Color.White
        Me.DataVarieteProduction.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle21
        Me.DataVarieteProduction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataVarieteProduction.BackgroundColor = System.Drawing.Color.White
        Me.DataVarieteProduction.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataVarieteProduction.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle22.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle22.NullValue = "-"
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataVarieteProduction.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle22
        Me.DataVarieteProduction.ColumnHeadersHeight = 40
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataVarieteProduction.DefaultCellStyle = DataGridViewCellStyle23
        Me.DataVarieteProduction.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DataVarieteProduction.EnableHeadersVisualStyles = False
        Me.DataVarieteProduction.Location = New System.Drawing.Point(0, 1)
        Me.DataVarieteProduction.Margin = New System.Windows.Forms.Padding(2)
        Me.DataVarieteProduction.Name = "DataVarieteProduction"
        Me.DataVarieteProduction.ReadOnly = True
        Me.DataVarieteProduction.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataVarieteProduction.RowHeadersDefaultCellStyle = DataGridViewCellStyle24
        Me.DataVarieteProduction.RowTemplate.Height = 24
        Me.DataVarieteProduction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataVarieteProduction.Size = New System.Drawing.Size(617, 419)
        Me.DataVarieteProduction.TabIndex = 27
        Me.DataVarieteProduction.Visible = False
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.AutoScrollMargin = New System.Drawing.Size(0, 15)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.GenClientCheckedList)
        Me.Panel1.Controls.Add(Me.DateFinGen)
        Me.Panel1.Controls.Add(Me.DateDebutGen)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.GenNiveauCheckedList)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.GenLocaliteCheckedList)
        Me.Panel1.Controls.Add(Me.FiltrerParDateGen)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.GenVarieteCheckedList)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(814, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(387, 695)
        Me.Panel1.TabIndex = 27
        '
        'DateFinGen
        '
        Me.DateFinGen.CustomFormat = "yyyy-MM-dd"
        Me.DateFinGen.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFinGen.Location = New System.Drawing.Point(7, 782)
        Me.DateFinGen.Name = "DateFinGen"
        Me.DateFinGen.Size = New System.Drawing.Size(263, 26)
        Me.DateFinGen.TabIndex = 23
        Me.DateFinGen.Visible = False
        '
        'DateDebutGen
        '
        Me.DateDebutGen.CustomFormat = "yyyy-MM-dd"
        Me.DateDebutGen.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateDebutGen.Location = New System.Drawing.Point(7, 731)
        Me.DateDebutGen.Name = "DateDebutGen"
        Me.DateDebutGen.Size = New System.Drawing.Size(263, 26)
        Me.DateDebutGen.TabIndex = 22
        Me.DateDebutGen.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(4, 300)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 16)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Niveau"
        '
        'GenNiveauCheckedList
        '
        Me.GenNiveauCheckedList.CheckOnClick = True
        Me.GenNiveauCheckedList.FormattingEnabled = True
        Me.GenNiveauCheckedList.Location = New System.Drawing.Point(7, 319)
        Me.GenNiveauCheckedList.Name = "GenNiveauCheckedList"
        Me.GenNiveauCheckedList.Size = New System.Drawing.Size(263, 88)
        Me.GenNiveauCheckedList.TabIndex = 20
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(4, 190)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 16)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Localité"
        '
        'GenLocaliteCheckedList
        '
        Me.GenLocaliteCheckedList.CheckOnClick = True
        Me.GenLocaliteCheckedList.FormattingEnabled = True
        Me.GenLocaliteCheckedList.Location = New System.Drawing.Point(7, 209)
        Me.GenLocaliteCheckedList.Name = "GenLocaliteCheckedList"
        Me.GenLocaliteCheckedList.Size = New System.Drawing.Size(263, 88)
        Me.GenLocaliteCheckedList.TabIndex = 18
        '
        'FiltrerParDateGen
        '
        Me.FiltrerParDateGen.AutoSize = True
        Me.FiltrerParDateGen.Location = New System.Drawing.Point(7, 690)
        Me.FiltrerParDateGen.Name = "FiltrerParDateGen"
        Me.FiltrerParDateGen.Size = New System.Drawing.Size(131, 24)
        Me.FiltrerParDateGen.TabIndex = 15
        Me.FiltrerParDateGen.Text = "Filtrer par date"
        Me.FiltrerParDateGen.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(4, 75)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 16)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Variétés"
        '
        'GenVarieteCheckedList
        '
        Me.GenVarieteCheckedList.CheckOnClick = True
        Me.GenVarieteCheckedList.FormattingEnabled = True
        Me.GenVarieteCheckedList.Location = New System.Drawing.Point(7, 94)
        Me.GenVarieteCheckedList.Name = "GenVarieteCheckedList"
        Me.GenVarieteCheckedList.Size = New System.Drawing.Size(263, 88)
        Me.GenVarieteCheckedList.TabIndex = 13
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteCustomSource.AddRange(New String() {"IRAT 10", "Dj 8-341", "ITA 150", "WAB 56-50", "Nerica 1", "Nerica 5", "Nerica 6 ", "Dj 684 D", "Dj 11-509", "Dj 12-519", "BW 248-1", "BR 51-46-5", "ITA 123", "Tox 728-1", "BG 90-2 ", "Rok 5", "WAR 1", "WAR 77-3-2-2", "WAR 81-2-1-3-2", "Ikong Pao", "IR 8", "Jaya", "IR 1529-680-3", "IR 442", "KH 998", "Kwang She Shun", "Sahel 108", "Sahel 134", "Sahel 159", "Sahel 177", "Sahel 201", "Sahel 202 ", "Sahel 208", "Sahel 209", "Sahel 210", "Sahel 217", "Sahel 222", "Sahel 305", "Sahel 317", "Sahel 328", "Sahel 329", "Nerica-S-19", "Nerica-S-21", "Nerica-S-36", "Nerica-S-44", "Souna 3", "IBV 8001", "IBV 8004", "IBMV 8402", "ISMI 9507", "Gawane", "Thialack 2", "Xéewel Gi", "Noor 96", "Doo Mer", "Sooror", "Gaaw Na", "Jaboot", "Goor Yomboul", "Yaayi Séex ", "28-206", "756-A", "55-437", "57-313", "57-422", "69-101", "73-27", "73-28", "73-30", "73-33", "GC 8-35", "Fleur 11", "78-937", "55-33", "SRV 1-19", "73-9-11", "GH 119-20", "PC79-79", "H 75-0", "58-57", "Ndiambour", "Mougne", "Bambey 21", "TN 88-63", "CB-5", "Diongoma", "Mélakh", "Mouride", "Yacine", "Pakau ", "58-74 f", "66-35 f", "Noflaye", "Gandiole", "Gao", "Solara", "Sirocco", "Julio", "Damani", "Belami", "Alizé ", "CE 145-66", "CE 151-262", "CE 180-33", "CE 196-7-2-1", "F2-20", "Faourou", "Nguinte", "Nganda", "Darou "})
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.DataSource = Me.SpeculationBindingSource
        Me.ComboBox1.DisplayMember = "id_speculation"
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(7, 32)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(125, 24)
        Me.ComboBox1.TabIndex = 10
        Me.ComboBox1.ValueMember = "id_speculation"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(4, 10)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 16)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Spéculation"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TableauGen)
        Me.GroupBox3.Controls.Add(Me.GraphiqueGen)
        Me.GroupBox3.Location = New System.Drawing.Point(7, 569)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Affichage"
        '
        'TableauGen
        '
        Me.TableauGen.AutoSize = True
        Me.TableauGen.Location = New System.Drawing.Point(6, 55)
        Me.TableauGen.Name = "TableauGen"
        Me.TableauGen.Size = New System.Drawing.Size(84, 24)
        Me.TableauGen.TabIndex = 17
        Me.TableauGen.Text = "Tableau"
        Me.TableauGen.UseVisualStyleBackColor = True
        '
        'GraphiqueGen
        '
        Me.GraphiqueGen.AutoSize = True
        Me.GraphiqueGen.Checked = True
        Me.GraphiqueGen.Location = New System.Drawing.Point(6, 25)
        Me.GraphiqueGen.Name = "GraphiqueGen"
        Me.GraphiqueGen.Size = New System.Drawing.Size(102, 24)
        Me.GraphiqueGen.TabIndex = 16
        Me.GraphiqueGen.TabStop = True
        Me.GraphiqueGen.Text = "Graphique"
        Me.GraphiqueGen.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(7, 431)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 16)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Clients"
        '
        'GenClientCheckedList
        '
        Me.GenClientCheckedList.CheckOnClick = True
        Me.GenClientCheckedList.FormattingEnabled = True
        Me.GenClientCheckedList.Location = New System.Drawing.Point(10, 450)
        Me.GenClientCheckedList.Name = "GenClientCheckedList"
        Me.GenClientCheckedList.Size = New System.Drawing.Size(263, 88)
        Me.GenClientCheckedList.TabIndex = 24
        '
        'DataCommandeProduction
        '
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.White
        Me.DataCommandeProduction.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.DataCommandeProduction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataCommandeProduction.BackgroundColor = System.Drawing.Color.White
        Me.DataCommandeProduction.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataCommandeProduction.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.NullValue = "-"
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataCommandeProduction.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.DataCommandeProduction.ColumnHeadersHeight = 40
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataCommandeProduction.DefaultCellStyle = DataGridViewCellStyle15
        Me.DataCommandeProduction.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DataCommandeProduction.EnableHeadersVisualStyles = False
        Me.DataCommandeProduction.Location = New System.Drawing.Point(0, 1)
        Me.DataCommandeProduction.Margin = New System.Windows.Forms.Padding(2)
        Me.DataCommandeProduction.Name = "DataCommandeProduction"
        Me.DataCommandeProduction.ReadOnly = True
        Me.DataCommandeProduction.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataCommandeProduction.RowHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.DataCommandeProduction.RowTemplate.Height = 24
        Me.DataCommandeProduction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataCommandeProduction.Size = New System.Drawing.Size(675, 536)
        Me.DataCommandeProduction.TabIndex = 26
        Me.DataCommandeProduction.Visible = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(368, 823)
        Me.TabControl1.TabIndex = 26
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 29)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(360, 790)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 29)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(192, 67)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'FormRapports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1212, 749)
        Me.Controls.Add(Me.TabRapports)
        Me.Name = "FormRapports"
        Me.Text = "FormRapports"
        CType(Me.SpeculationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommandeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.General.ResumeLayout(False)
        CType(Me.CommandeProductionChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Commandes.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.VarieteCommandeLivraisonChart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataCommandeLivraison, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabRapports.ResumeLayout(False)
        Me.Production.ResumeLayout(False)
        CType(Me.VarieteProductionCommandeChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataVarieteProduction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataCommandeProduction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SemencesDataSet As semencesDataSet
    Friend WithEvents CommandeBindingSource As BindingSource
    Friend WithEvents CommandeTableAdapter As semencesDataSetTableAdapters.commandeTableAdapter
    Friend WithEvents SpeculationBindingSource As BindingSource
    Friend WithEvents General As TabPage
    Friend WithEvents CommandeProductionChart As DataVisualization.Charting.Chart
    Friend WithEvents Commandes As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DateFin As DateTimePicker
    Friend WithEvents DateDebut As DateTimePicker
    Friend WithEvents Label4 As Label
    Friend WithEvents ClientCommandeCheckedList As CheckedListBox
    Friend WithEvents FiltrerParDate As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents VarieteCommandeCheckedList As CheckedListBox
    Friend WithEvents NomSpeculationCommande As ComboBox
    Friend WithEvents NomSpeculationLabel As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Tableau As RadioButton
    Friend WithEvents Graphique As RadioButton
    Friend WithEvents VarieteCommandeLivraisonChart As DataVisualization.Charting.Chart
    Friend WithEvents DataCommandeLivraison As DataGridView
    Friend WithEvents TabRapports As TabControl
    Friend WithEvents Production As TabPage
    Friend WithEvents VarieteProductionCommandeChart As DataVisualization.Charting.Chart
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DateFinProduction As DateTimePicker
    Friend WithEvents DateDebutProduction As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents NiveauCheckedList As CheckedListBox
    Friend WithEvents LocaliteLabel As Label
    Friend WithEvents LocaliteCheckedList As CheckedListBox
    Friend WithEvents FiltrerParDateProduction As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents VarieteProductionCheckedList As CheckedListBox
    Friend WithEvents NomSpeculationProduction As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TableauProduction As RadioButton
    Friend WithEvents GraphiqueProduction As RadioButton
    Friend WithEvents DataVarieteProduction As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label10 As Label
    Friend WithEvents GenClientCheckedList As CheckedListBox
    Friend WithEvents DateFinGen As DateTimePicker
    Friend WithEvents DateDebutGen As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents GenNiveauCheckedList As CheckedListBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GenLocaliteCheckedList As CheckedListBox
    Friend WithEvents FiltrerParDateGen As CheckBox
    Friend WithEvents Label8 As Label
    Friend WithEvents GenVarieteCheckedList As CheckedListBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TableauGen As RadioButton
    Friend WithEvents GraphiqueGen As RadioButton
    Friend WithEvents DataCommandeProduction As DataGridView
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
End Class

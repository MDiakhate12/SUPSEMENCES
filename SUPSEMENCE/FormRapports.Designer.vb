<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRapports
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRapports))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim Title2 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim Title3 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title4 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim Title5 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim Title6 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series6 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title7 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim Title8 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim Title9 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Varietes = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.NomSpeculation = New System.Windows.Forms.ComboBox()
        Me.SpeculationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NomSpeculationLabel = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Chart3 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Chart2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.ElementHost1 = New System.Windows.Forms.Integration.ElementHost()
        Me.CartesianChart1 = New LiveCharts.Wpf.CartesianChart()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.SemencesDataSet = New SUPSEMENCE.semencesDataSet()
        Me.CommandeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CommandeTableAdapter = New SUPSEMENCE.semencesDataSetTableAdapters.commandeTableAdapter()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TabControl1.SuspendLayout()
        Me.Varietes.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.SpeculationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.SemencesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommandeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Varietes)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.ItemSize = New System.Drawing.Size(62, 40)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1212, 881)
        Me.TabControl1.TabIndex = 0
        '
        'Varietes
        '
        Me.Varietes.Controls.Add(Me.Panel2)
        Me.Varietes.Controls.Add(Me.Chart3)
        Me.Varietes.Location = New System.Drawing.Point(4, 44)
        Me.Varietes.Name = "Varietes"
        Me.Varietes.Size = New System.Drawing.Size(1204, 833)
        Me.Varietes.TabIndex = 2
        Me.Varietes.Text = "Commandes"
        Me.Varietes.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.CheckedListBox1)
        Me.Panel2.Controls.Add(Me.NomSpeculation)
        Me.Panel2.Controls.Add(Me.NomSpeculationLabel)
        Me.Panel2.Controls.Add(Me.Button2)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Location = New System.Drawing.Point(906, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(298, 412)
        Me.Panel2.TabIndex = 5
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(26, 133)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.Size = New System.Drawing.Size(263, 88)
        Me.CheckedListBox1.TabIndex = 13
        '
        'NomSpeculation
        '
        Me.NomSpeculation.AutoCompleteCustomSource.AddRange(New String() {"IRAT 10", "Dj 8-341", "ITA 150", "WAB 56-50", "Nerica 1", "Nerica 5", "Nerica 6 ", "Dj 684 D", "Dj 11-509", "Dj 12-519", "BW 248-1", "BR 51-46-5", "ITA 123", "Tox 728-1", "BG 90-2 ", "Rok 5", "WAR 1", "WAR 77-3-2-2", "WAR 81-2-1-3-2", "Ikong Pao", "IR 8", "Jaya", "IR 1529-680-3", "IR 442", "KH 998", "Kwang She Shun", "Sahel 108", "Sahel 134", "Sahel 159", "Sahel 177", "Sahel 201", "Sahel 202 ", "Sahel 208", "Sahel 209", "Sahel 210", "Sahel 217", "Sahel 222", "Sahel 305", "Sahel 317", "Sahel 328", "Sahel 329", "Nerica-S-19", "Nerica-S-21", "Nerica-S-36", "Nerica-S-44", "Souna 3", "IBV 8001", "IBV 8004", "IBMV 8402", "ISMI 9507", "Gawane", "Thialack 2", "Xéewel Gi", "Noor 96", "Doo Mer", "Sooror", "Gaaw Na", "Jaboot", "Goor Yomboul", "Yaayi Séex ", "28-206", "756-A", "55-437", "57-313", "57-422", "69-101", "73-27", "73-28", "73-30", "73-33", "GC 8-35", "Fleur 11", "78-937", "55-33", "SRV 1-19", "73-9-11", "GH 119-20", "PC79-79", "H 75-0", "58-57", "Ndiambour", "Mougne", "Bambey 21", "TN 88-63", "CB-5", "Diongoma", "Mélakh", "Mouride", "Yacine", "Pakau ", "58-74 f", "66-35 f", "Noflaye", "Gandiole", "Gao", "Solara", "Sirocco", "Julio", "Damani", "Belami", "Alizé ", "CE 145-66", "CE 151-262", "CE 180-33", "CE 196-7-2-1", "F2-20", "Faourou", "Nguinte", "Nganda", "Darou "})
        Me.NomSpeculation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.NomSpeculation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.NomSpeculation.DataSource = Me.SpeculationBindingSource
        Me.NomSpeculation.DisplayMember = "id_speculation"
        Me.NomSpeculation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomSpeculation.FormattingEnabled = True
        Me.NomSpeculation.Location = New System.Drawing.Point(166, 58)
        Me.NomSpeculation.Margin = New System.Windows.Forms.Padding(2)
        Me.NomSpeculation.Name = "NomSpeculation"
        Me.NomSpeculation.Size = New System.Drawing.Size(125, 24)
        Me.NomSpeculation.TabIndex = 10
        Me.NomSpeculation.ValueMember = "id_speculation"
        '
        'NomSpeculationLabel
        '
        Me.NomSpeculationLabel.AutoSize = True
        Me.NomSpeculationLabel.BackColor = System.Drawing.Color.Transparent
        Me.NomSpeculationLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomSpeculationLabel.ForeColor = System.Drawing.Color.Black
        Me.NomSpeculationLabel.Location = New System.Drawing.Point(83, 61)
        Me.NomSpeculationLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.NomSpeculationLabel.Name = "NomSpeculationLabel"
        Me.NomSpeculationLabel.Size = New System.Drawing.Size(79, 16)
        Me.NomSpeculationLabel.TabIndex = 11
        Me.NomSpeculationLabel.Text = "Spéculation"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(36, 361)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(233, 37)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "Enregistrer"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(31, 33)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Chart3
        '
        Me.Chart3.BackSecondaryColor = System.Drawing.Color.White
        Me.Chart3.BorderlineColor = System.Drawing.Color.Black
        Me.Chart3.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
        ChartArea1.Name = "ChartArea1"
        Me.Chart3.ChartAreas.Add(ChartArea1)
        Me.Chart3.Cursor = System.Windows.Forms.Cursors.Hand
        Legend1.Alignment = System.Drawing.StringAlignment.Far
        Legend1.DockedToChartArea = "ChartArea1"
        Legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Legend1.IsDockedInsideChartArea = False
        Legend1.IsTextAutoFit = False
        Legend1.Name = "Legend1"
        Me.Chart3.Legends.Add(Legend1)
        Me.Chart3.Location = New System.Drawing.Point(0, 1)
        Me.Chart3.Name = "Chart3"
        Me.Chart3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
        Series1.ChartArea = "ChartArea1"
        Series1.Color = System.Drawing.Color.LightSeaGreen
        Series1.EmptyPointStyle.BorderColor = System.Drawing.Color.DarkRed
        Series1.EmptyPointStyle.BorderWidth = 2
        Series1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series1.Label = "#VAL"
        Series1.LabelForeColor = System.Drawing.Color.DarkGray
        Series1.Legend = "Legend1"
        Series1.Name = "Quantité commandée en KG"
        Series1.ToolTip = "#VAL KG"
        Series2.ChartArea = "ChartArea1"
        Series2.Color = System.Drawing.Color.Aquamarine
        Series2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series2.IsValueShownAsLabel = True
        Series2.Label = "#VAL"
        Series2.LabelForeColor = System.Drawing.Color.DarkGray
        Series2.Legend = "Legend1"
        Series2.Name = "Quantité livrée en KG"
        Series2.ToolTip = "#VAL KG"
        Me.Chart3.Series.Add(Series1)
        Me.Chart3.Series.Add(Series2)
        Me.Chart3.Size = New System.Drawing.Size(617, 419)
        Me.Chart3.TabIndex = 4
        Me.Chart3.Text = "Chart3"
        Title1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left
        Title1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title1.ForeColor = System.Drawing.Color.DimGray
        Title1.Name = "Title1"
        Title1.Text = "Quantité en KG"
        Title2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title2.ForeColor = System.Drawing.Color.DarkGreen
        Title2.Name = "Title2"
        Title2.Text = "Quantité commandée / Quantité livrée"
        Title3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom
        Title3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title3.ForeColor = System.Drawing.Color.DarkGreen
        Title3.Name = "Title3"
        Title3.Text = "Spéculations"
        Me.Chart3.Titles.Add(Title1)
        Me.Chart3.Titles.Add(Title2)
        Me.Chart3.Titles.Add(Title3)
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Chart2)
        Me.TabPage2.Controls.Add(Me.Chart1)
        Me.TabPage2.Controls.Add(Me.FlowLayoutPanel1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 44)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1204, 833)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Statistiques générales"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Chart2
        '
        Me.Chart2.BackSecondaryColor = System.Drawing.Color.White
        Me.Chart2.BorderlineColor = System.Drawing.Color.Black
        Me.Chart2.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
        ChartArea2.Name = "ChartArea1"
        Me.Chart2.ChartAreas.Add(ChartArea2)
        Me.Chart2.Cursor = System.Windows.Forms.Cursors.Hand
        Legend2.Alignment = System.Drawing.StringAlignment.Far
        Legend2.DockedToChartArea = "ChartArea1"
        Legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Legend2.IsDockedInsideChartArea = False
        Legend2.IsTextAutoFit = False
        Legend2.Name = "Legend1"
        Me.Chart2.Legends.Add(Legend2)
        Me.Chart2.Location = New System.Drawing.Point(612, 17)
        Me.Chart2.Name = "Chart2"
        Me.Chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent
        Series3.ChartArea = "ChartArea1"
        Series3.Color = System.Drawing.Color.PaleVioletRed
        Series3.EmptyPointStyle.BorderColor = System.Drawing.Color.DarkRed
        Series3.EmptyPointStyle.BorderWidth = 2
        Series3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series3.Label = "#VAL"
        Series3.LabelForeColor = System.Drawing.Color.DarkGreen
        Series3.Legend = "Legend1"
        Series3.Name = "Quantité commandée en KG"
        Series3.ToolTip = "#VAL KG"
        Series4.ChartArea = "ChartArea1"
        Series4.Color = System.Drawing.Color.PeachPuff
        Series4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series4.IsValueShownAsLabel = True
        Series4.Label = "#VAL"
        Series4.LabelForeColor = System.Drawing.Color.DarkGoldenrod
        Series4.Legend = "Legend1"
        Series4.Name = "Quantité produite en KG"
        Series4.ToolTip = "#VAL KG"
        Me.Chart2.Series.Add(Series3)
        Me.Chart2.Series.Add(Series4)
        Me.Chart2.Size = New System.Drawing.Size(586, 372)
        Me.Chart2.TabIndex = 4
        Me.Chart2.Text = "Chart2"
        Title4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left
        Title4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title4.ForeColor = System.Drawing.Color.DarkGreen
        Title4.Name = "Title1"
        Title4.Text = "Quantité en KG"
        Title5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title5.ForeColor = System.Drawing.Color.DarkGreen
        Title5.Name = "Title2"
        Title5.Text = "Quantité commandée / Quantité produite"
        Title6.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom
        Title6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title6.ForeColor = System.Drawing.Color.DarkGreen
        Title6.Name = "Title3"
        Title6.Text = "Spéculations"
        Me.Chart2.Titles.Add(Title4)
        Me.Chart2.Titles.Add(Title5)
        Me.Chart2.Titles.Add(Title6)
        '
        'Chart1
        '
        Me.Chart1.BackSecondaryColor = System.Drawing.Color.White
        Me.Chart1.BorderlineColor = System.Drawing.Color.Black
        Me.Chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
        ChartArea3.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea3)
        Me.Chart1.Cursor = System.Windows.Forms.Cursors.Hand
        Legend3.Alignment = System.Drawing.StringAlignment.Far
        Legend3.DockedToChartArea = "ChartArea1"
        Legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Legend3.IsDockedInsideChartArea = False
        Legend3.IsTextAutoFit = False
        Legend3.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend3)
        Me.Chart1.Location = New System.Drawing.Point(19, 17)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
        Series5.ChartArea = "ChartArea1"
        Series5.Color = System.Drawing.Color.LightSeaGreen
        Series5.EmptyPointStyle.BorderColor = System.Drawing.Color.DarkRed
        Series5.EmptyPointStyle.BorderWidth = 2
        Series5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series5.Label = "#VAL"
        Series5.LabelForeColor = System.Drawing.Color.DarkGreen
        Series5.Legend = "Legend1"
        Series5.Name = "Quantité commandée en KG"
        Series5.ToolTip = "#VAL KG"
        Series6.ChartArea = "ChartArea1"
        Series6.Color = System.Drawing.Color.Aquamarine
        Series6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series6.IsValueShownAsLabel = True
        Series6.Label = "#VAL"
        Series6.LabelForeColor = System.Drawing.Color.DarkGoldenrod
        Series6.Legend = "Legend1"
        Series6.Name = "Quantité livrée en KG"
        Series6.ToolTip = "#VAL KG"
        Me.Chart1.Series.Add(Series5)
        Me.Chart1.Series.Add(Series6)
        Me.Chart1.Size = New System.Drawing.Size(586, 372)
        Me.Chart1.TabIndex = 3
        Me.Chart1.Text = "Chart1"
        Title7.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left
        Title7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title7.ForeColor = System.Drawing.Color.DimGray
        Title7.Name = "Title1"
        Title7.Text = "Quantité en KG"
        Title8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title8.ForeColor = System.Drawing.Color.DarkGreen
        Title8.Name = "Title2"
        Title8.Text = "Quantité commandée / Quantité livrée"
        Title9.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom
        Title9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title9.ForeColor = System.Drawing.Color.DarkGreen
        Title9.Name = "Title3"
        Title9.Text = "Spéculations"
        Me.Chart1.Titles.Add(Title7)
        Me.Chart1.Titles.Add(Title8)
        Me.Chart1.Titles.Add(Title9)
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1198, 827)
        Me.FlowLayoutPanel1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.ElementHost1)
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 44)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1204, 833)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'ElementHost1
        '
        Me.ElementHost1.Location = New System.Drawing.Point(35, 31)
        Me.ElementHost1.Name = "ElementHost1"
        Me.ElementHost1.Size = New System.Drawing.Size(556, 329)
        Me.ElementHost1.TabIndex = 1
        Me.ElementHost1.Text = "ElementHost1"
        Me.ElementHost1.Child = Me.CartesianChart1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.DateTimePicker2)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Location = New System.Drawing.Point(704, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(302, 350)
        Me.Panel1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(59, 212)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(157, 60)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(45, 179)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(200, 26)
        Me.DateTimePicker2.TabIndex = 2
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(45, 120)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 26)
        Me.DateTimePicker1.TabIndex = 1
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(45, 56)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 28)
        Me.ComboBox1.TabIndex = 0
        '
        'SemencesDataSet
        '
        Me.SemencesDataSet.DataSetName = "semencesDataSet"
        Me.SemencesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CommandeBindingSource
        '
        Me.CommandeBindingSource.DataMember = "commande"
        Me.CommandeBindingSource.DataSource = Me.SemencesDataSet
        '
        'CommandeTableAdapter
        '
        Me.CommandeTableAdapter.ClearBeforeFill = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(26, 227)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(263, 100)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(10, 26)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(109, 24)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "CheckBox1"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'FormRapports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1212, 881)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FormRapports"
        Me.Text = "FormRapports"
        Me.TabControl1.ResumeLayout(False)
        Me.Varietes.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.SpeculationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.Chart2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.SemencesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommandeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents ElementHost1 As Integration.ElementHost
    Friend CartesianChart1 As LiveCharts.Wpf.CartesianChart
    Friend WithEvents Button1 As Button
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents SemencesDataSet As semencesDataSet
    Friend WithEvents CommandeBindingSource As BindingSource
    Friend WithEvents CommandeTableAdapter As semencesDataSetTableAdapters.commandeTableAdapter
    Friend WithEvents Chart2 As DataVisualization.Charting.Chart
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Varietes As TabPage
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Chart3 As DataVisualization.Charting.Chart
    Friend WithEvents NomSpeculation As ComboBox
    Friend WithEvents NomSpeculationLabel As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents SpeculationBindingSource As BindingSource
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents CheckBox1 As CheckBox
End Class

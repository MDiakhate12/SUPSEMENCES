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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title1 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim Title2 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim Title3 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series4 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title4 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim Title5 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim Title6 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series5 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title7 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim Title8 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim Title9 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Me.SpeculationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CommandeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.General = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.DataCommandeProduction = New System.Windows.Forms.DataGridView()
        Me.CommandeProductionChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.RapportSpeculation = New System.Windows.Forms.TabControl()
        Me.SpeculationTab = New System.Windows.Forms.TabPage()
        Me.VarieteTab = New System.Windows.Forms.TabPage()
        Me.GenNiveauCheckedList = New System.Windows.Forms.CheckedListBox()
        Me.GenClientCheckedList = New System.Windows.Forms.CheckedListBox()
        Me.GenLocaliteCheckedList = New System.Windows.Forms.CheckedListBox()
        Me.GenVarieteCheckedList = New System.Windows.Forms.CheckedListBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GraphiqueGen = New System.Windows.Forms.RadioButton()
        Me.TableauGen = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.NomSpeculationGen = New System.Windows.Forms.ComboBox()
        Me.DateDebutGen = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.FiltrerParDateGen = New System.Windows.Forms.CheckBox()
        Me.DateFinGen = New System.Windows.Forms.DateTimePicker()
        Me.Commandes = New System.Windows.Forms.TabPage()
        Me.DataCommandeLivraison = New System.Windows.Forms.DataGridView()
        Me.VarieteCommandeLivraisonChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Graphique = New System.Windows.Forms.RadioButton()
        Me.Tableau = New System.Windows.Forms.RadioButton()
        Me.NomSpeculationLabel = New System.Windows.Forms.Label()
        Me.NomSpeculationCommande = New System.Windows.Forms.ComboBox()
        Me.VarieteCommandeCheckedList = New System.Windows.Forms.CheckedListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FiltrerParDate = New System.Windows.Forms.CheckBox()
        Me.ClientCommandeCheckedList = New System.Windows.Forms.CheckedListBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DateDebut = New System.Windows.Forms.DateTimePicker()
        Me.DateFin = New System.Windows.Forms.DateTimePicker()
        Me.Production = New System.Windows.Forms.TabPage()
        Me.DataVarieteProduction = New System.Windows.Forms.DataGridView()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GraphiqueProduction = New System.Windows.Forms.RadioButton()
        Me.TableauProduction = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NomSpeculationProduction = New System.Windows.Forms.ComboBox()
        Me.VarieteProductionCheckedList = New System.Windows.Forms.CheckedListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.FiltrerParDateProduction = New System.Windows.Forms.CheckBox()
        Me.LocaliteCheckedList = New System.Windows.Forms.CheckedListBox()
        Me.LocaliteLabel = New System.Windows.Forms.Label()
        Me.NiveauCheckedList = New System.Windows.Forms.CheckedListBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DateDebutProduction = New System.Windows.Forms.DateTimePicker()
        Me.DateFinProduction = New System.Windows.Forms.DateTimePicker()
        Me.VarieteProductionCommandeChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.TabRapports = New System.Windows.Forms.TabControl()
        CType(Me.SpeculationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommandeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.General.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.DataCommandeProduction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommandeProductionChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.RapportSpeculation.SuspendLayout()
        Me.VarieteTab.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.Commandes.SuspendLayout()
        CType(Me.DataCommandeLivraison, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VarieteCommandeLivraisonChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Production.SuspendLayout()
        CType(Me.DataVarieteProduction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.VarieteProductionCommandeChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabRapports.SuspendLayout()
        Me.SuspendLayout()
        '
        'CommandeBindingSource
        '
        Me.CommandeBindingSource.DataMember = "commande"
        '
        'General
        '
        Me.General.Controls.Add(Me.Panel1)
        Me.General.Controls.Add(Me.Panel4)
        Me.General.Location = New System.Drawing.Point(4, 44)
        Me.General.Name = "General"
        Me.General.Padding = New System.Windows.Forms.Padding(3)
        Me.General.Size = New System.Drawing.Size(1204, 701)
        Me.General.TabIndex = 1
        Me.General.Text = "Statistiques générales"
        Me.General.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.CommandeProductionChart)
        Me.Panel4.Controls.Add(Me.DataCommandeProduction)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1198, 695)
        Me.Panel4.TabIndex = 28
        '
        'DataCommandeProduction
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DataCommandeProduction.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataCommandeProduction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataCommandeProduction.BackgroundColor = System.Drawing.Color.White
        Me.DataCommandeProduction.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataCommandeProduction.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.NullValue = "-"
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataCommandeProduction.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataCommandeProduction.ColumnHeadersHeight = 40
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataCommandeProduction.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataCommandeProduction.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DataCommandeProduction.EnableHeadersVisualStyles = False
        Me.DataCommandeProduction.Location = New System.Drawing.Point(4, 4)
        Me.DataCommandeProduction.Margin = New System.Windows.Forms.Padding(2)
        Me.DataCommandeProduction.Name = "DataCommandeProduction"
        Me.DataCommandeProduction.ReadOnly = True
        Me.DataCommandeProduction.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataCommandeProduction.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataCommandeProduction.RowTemplate.Height = 24
        Me.DataCommandeProduction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataCommandeProduction.Size = New System.Drawing.Size(675, 536)
        Me.DataCommandeProduction.TabIndex = 26
        Me.DataCommandeProduction.Visible = False
        '
        'CommandeProductionChart
        '
        Me.CommandeProductionChart.BackSecondaryColor = System.Drawing.Color.White
        Me.CommandeProductionChart.BorderlineColor = System.Drawing.Color.Black
        Me.CommandeProductionChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
        ChartArea1.Name = "ChartArea1"
        Me.CommandeProductionChart.ChartAreas.Add(ChartArea1)
        Me.CommandeProductionChart.Cursor = System.Windows.Forms.Cursors.Hand
        Legend1.Alignment = System.Drawing.StringAlignment.Far
        Legend1.DockedToChartArea = "ChartArea1"
        Legend1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Legend1.IsDockedInsideChartArea = False
        Legend1.IsTextAutoFit = False
        Legend1.Name = "Legend1"
        Me.CommandeProductionChart.Legends.Add(Legend1)
        Me.CommandeProductionChart.Location = New System.Drawing.Point(4, 4)
        Me.CommandeProductionChart.Name = "CommandeProductionChart"
        Me.CommandeProductionChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent
        Series1.ChartArea = "ChartArea1"
        Series1.Color = System.Drawing.Color.MediumTurquoise
        Series1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series1.IsValueShownAsLabel = True
        Series1.Label = "#VAL"
        Series1.LabelForeColor = System.Drawing.Color.DarkGoldenrod
        Series1.Legend = "Legend1"
        Series1.Name = "Quantité produite en KG"
        Series1.ToolTip = "#VAL KG"
        Series2.ChartArea = "ChartArea1"
        Series2.Color = System.Drawing.Color.LightCoral
        Series2.EmptyPointStyle.BorderColor = System.Drawing.Color.DarkRed
        Series2.EmptyPointStyle.BorderWidth = 2
        Series2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series2.Label = "#VAL"
        Series2.LabelForeColor = System.Drawing.Color.DarkGreen
        Series2.Legend = "Legend1"
        Series2.Name = "Quantité commandée en KG"
        Series2.ToolTip = "#VAL KG"
        Me.CommandeProductionChart.Series.Add(Series1)
        Me.CommandeProductionChart.Series.Add(Series2)
        Me.CommandeProductionChart.Size = New System.Drawing.Size(675, 536)
        Me.CommandeProductionChart.TabIndex = 4
        Me.CommandeProductionChart.Text = "Chart2"
        Title1.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left
        Title1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title1.ForeColor = System.Drawing.Color.DarkGreen
        Title1.Name = "Title1"
        Title1.Text = "Quantité en KG"
        Title2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title2.ForeColor = System.Drawing.Color.DarkGreen
        Title2.Name = "Title2"
        Title2.Text = "Quantité produite / Quantité commandée "
        Title3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom
        Title3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title3.ForeColor = System.Drawing.Color.DarkGreen
        Title3.Name = "Title3"
        Title3.Text = "Variétés"
        Me.CommandeProductionChart.Titles.Add(Title1)
        Me.CommandeProductionChart.Titles.Add(Title2)
        Me.CommandeProductionChart.Titles.Add(Title3)
        '
        'Panel1
        '
        Me.Panel1.AutoScrollMargin = New System.Drawing.Size(0, 15)
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.RapportSpeculation)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(883, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(318, 695)
        Me.Panel1.TabIndex = 27
        '
        'RapportSpeculation
        '
        Me.RapportSpeculation.Controls.Add(Me.VarieteTab)
        Me.RapportSpeculation.Controls.Add(Me.SpeculationTab)
        Me.RapportSpeculation.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RapportSpeculation.Location = New System.Drawing.Point(0, 0)
        Me.RapportSpeculation.Name = "RapportSpeculation"
        Me.RapportSpeculation.SelectedIndex = 0
        Me.RapportSpeculation.Size = New System.Drawing.Size(316, 693)
        Me.RapportSpeculation.TabIndex = 26
        '
        'SpeculationTab
        '
        Me.SpeculationTab.Location = New System.Drawing.Point(4, 29)
        Me.SpeculationTab.Name = "SpeculationTab"
        Me.SpeculationTab.Padding = New System.Windows.Forms.Padding(3)
        Me.SpeculationTab.Size = New System.Drawing.Size(308, 660)
        Me.SpeculationTab.TabIndex = 1
        Me.SpeculationTab.Text = "Spéculation"
        Me.SpeculationTab.UseVisualStyleBackColor = True
        '
        'VarieteTab
        '
        Me.VarieteTab.AutoScroll = True
        Me.VarieteTab.AutoScrollMargin = New System.Drawing.Size(0, 50)
        Me.VarieteTab.Controls.Add(Me.DateFinGen)
        Me.VarieteTab.Controls.Add(Me.FiltrerParDateGen)
        Me.VarieteTab.Controls.Add(Me.Label10)
        Me.VarieteTab.Controls.Add(Me.DateDebutGen)
        Me.VarieteTab.Controls.Add(Me.NomSpeculationGen)
        Me.VarieteTab.Controls.Add(Me.Label7)
        Me.VarieteTab.Controls.Add(Me.GroupBox3)
        Me.VarieteTab.Controls.Add(Me.Label9)
        Me.VarieteTab.Controls.Add(Me.Label8)
        Me.VarieteTab.Controls.Add(Me.Label5)
        Me.VarieteTab.Controls.Add(Me.GenVarieteCheckedList)
        Me.VarieteTab.Controls.Add(Me.GenLocaliteCheckedList)
        Me.VarieteTab.Controls.Add(Me.GenClientCheckedList)
        Me.VarieteTab.Controls.Add(Me.GenNiveauCheckedList)
        Me.VarieteTab.Location = New System.Drawing.Point(4, 29)
        Me.VarieteTab.Name = "VarieteTab"
        Me.VarieteTab.Padding = New System.Windows.Forms.Padding(3)
        Me.VarieteTab.Size = New System.Drawing.Size(308, 660)
        Me.VarieteTab.TabIndex = 0
        Me.VarieteTab.Text = "Variétés"
        Me.VarieteTab.UseVisualStyleBackColor = True
        '
        'GenNiveauCheckedList
        '
        Me.GenNiveauCheckedList.CheckOnClick = True
        Me.GenNiveauCheckedList.FormattingEnabled = True
        Me.GenNiveauCheckedList.Location = New System.Drawing.Point(17, 319)
        Me.GenNiveauCheckedList.Name = "GenNiveauCheckedList"
        Me.GenNiveauCheckedList.Size = New System.Drawing.Size(263, 88)
        Me.GenNiveauCheckedList.TabIndex = 20
        '
        'GenClientCheckedList
        '
        Me.GenClientCheckedList.CheckOnClick = True
        Me.GenClientCheckedList.FormattingEnabled = True
        Me.GenClientCheckedList.Location = New System.Drawing.Point(17, 446)
        Me.GenClientCheckedList.Name = "GenClientCheckedList"
        Me.GenClientCheckedList.Size = New System.Drawing.Size(263, 88)
        Me.GenClientCheckedList.TabIndex = 24
        '
        'GenLocaliteCheckedList
        '
        Me.GenLocaliteCheckedList.CheckOnClick = True
        Me.GenLocaliteCheckedList.FormattingEnabled = True
        Me.GenLocaliteCheckedList.Location = New System.Drawing.Point(17, 202)
        Me.GenLocaliteCheckedList.Name = "GenLocaliteCheckedList"
        Me.GenLocaliteCheckedList.Size = New System.Drawing.Size(263, 88)
        Me.GenLocaliteCheckedList.TabIndex = 18
        '
        'GenVarieteCheckedList
        '
        Me.GenVarieteCheckedList.CheckOnClick = True
        Me.GenVarieteCheckedList.FormattingEnabled = True
        Me.GenVarieteCheckedList.Location = New System.Drawing.Point(17, 85)
        Me.GenVarieteCheckedList.Name = "GenVarieteCheckedList"
        Me.GenVarieteCheckedList.Size = New System.Drawing.Size(263, 88)
        Me.GenVarieteCheckedList.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(14, 300)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 16)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Niveau"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(14, 66)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 16)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Variétés"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(14, 5)
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
        Me.GroupBox3.Location = New System.Drawing.Point(17, 540)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(200, 100)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Affichage"
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
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(14, 183)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 16)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Localité"
        '
        'NomSpeculationGen
        '
        Me.NomSpeculationGen.AutoCompleteCustomSource.AddRange(New String() {"IRAT 10", "Dj 8-341", "ITA 150", "WAB 56-50", "Nerica 1", "Nerica 5", "Nerica 6 ", "Dj 684 D", "Dj 11-509", "Dj 12-519", "BW 248-1", "BR 51-46-5", "ITA 123", "Tox 728-1", "BG 90-2 ", "Rok 5", "WAR 1", "WAR 77-3-2-2", "WAR 81-2-1-3-2", "Ikong Pao", "IR 8", "Jaya", "IR 1529-680-3", "IR 442", "KH 998", "Kwang She Shun", "Sahel 108", "Sahel 134", "Sahel 159", "Sahel 177", "Sahel 201", "Sahel 202 ", "Sahel 208", "Sahel 209", "Sahel 210", "Sahel 217", "Sahel 222", "Sahel 305", "Sahel 317", "Sahel 328", "Sahel 329", "Nerica-S-19", "Nerica-S-21", "Nerica-S-36", "Nerica-S-44", "Souna 3", "IBV 8001", "IBV 8004", "IBMV 8402", "ISMI 9507", "Gawane", "Thialack 2", "Xéewel Gi", "Noor 96", "Doo Mer", "Sooror", "Gaaw Na", "Jaboot", "Goor Yomboul", "Yaayi Séex ", "28-206", "756-A", "55-437", "57-313", "57-422", "69-101", "73-27", "73-28", "73-30", "73-33", "GC 8-35", "Fleur 11", "78-937", "55-33", "SRV 1-19", "73-9-11", "GH 119-20", "PC79-79", "H 75-0", "58-57", "Ndiambour", "Mougne", "Bambey 21", "TN 88-63", "CB-5", "Diongoma", "Mélakh", "Mouride", "Yacine", "Pakau ", "58-74 f", "66-35 f", "Noflaye", "Gandiole", "Gao", "Solara", "Sirocco", "Julio", "Damani", "Belami", "Alizé ", "CE 145-66", "CE 151-262", "CE 180-33", "CE 196-7-2-1", "F2-20", "Faourou", "Nguinte", "Nganda", "Darou "})
        Me.NomSpeculationGen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.NomSpeculationGen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.NomSpeculationGen.DataSource = Me.SpeculationBindingSource
        Me.NomSpeculationGen.DisplayMember = "id_speculation"
        Me.NomSpeculationGen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomSpeculationGen.FormattingEnabled = True
        Me.NomSpeculationGen.Location = New System.Drawing.Point(17, 26)
        Me.NomSpeculationGen.Margin = New System.Windows.Forms.Padding(2)
        Me.NomSpeculationGen.Name = "NomSpeculationGen"
        Me.NomSpeculationGen.Size = New System.Drawing.Size(125, 24)
        Me.NomSpeculationGen.TabIndex = 10
        Me.NomSpeculationGen.ValueMember = "id_speculation"
        '
        'DateDebutGen
        '
        Me.DateDebutGen.CustomFormat = "yyyy-MM-dd"
        Me.DateDebutGen.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateDebutGen.Location = New System.Drawing.Point(17, 688)
        Me.DateDebutGen.Name = "DateDebutGen"
        Me.DateDebutGen.Size = New System.Drawing.Size(263, 26)
        Me.DateDebutGen.TabIndex = 22
        Me.DateDebutGen.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(17, 427)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 16)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Clients"
        '
        'FiltrerParDateGen
        '
        Me.FiltrerParDateGen.AutoSize = True
        Me.FiltrerParDateGen.Location = New System.Drawing.Point(17, 658)
        Me.FiltrerParDateGen.Name = "FiltrerParDateGen"
        Me.FiltrerParDateGen.Size = New System.Drawing.Size(131, 24)
        Me.FiltrerParDateGen.TabIndex = 15
        Me.FiltrerParDateGen.Text = "Filtrer par date"
        Me.FiltrerParDateGen.UseVisualStyleBackColor = True
        '
        'DateFinGen
        '
        Me.DateFinGen.CustomFormat = "yyyy-MM-dd"
        Me.DateFinGen.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFinGen.Location = New System.Drawing.Point(17, 720)
        Me.DateFinGen.Name = "DateFinGen"
        Me.DateFinGen.Size = New System.Drawing.Size(263, 26)
        Me.DateFinGen.TabIndex = 23
        Me.DateFinGen.Visible = False
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
        'DataCommandeLivraison
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        Me.DataCommandeLivraison.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataCommandeLivraison.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataCommandeLivraison.BackgroundColor = System.Drawing.Color.White
        Me.DataCommandeLivraison.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataCommandeLivraison.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.NullValue = "-"
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataCommandeLivraison.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataCommandeLivraison.ColumnHeadersHeight = 40
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataCommandeLivraison.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataCommandeLivraison.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DataCommandeLivraison.EnableHeadersVisualStyles = False
        Me.DataCommandeLivraison.Location = New System.Drawing.Point(0, 1)
        Me.DataCommandeLivraison.Margin = New System.Windows.Forms.Padding(2)
        Me.DataCommandeLivraison.Name = "DataCommandeLivraison"
        Me.DataCommandeLivraison.ReadOnly = True
        Me.DataCommandeLivraison.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataCommandeLivraison.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DataCommandeLivraison.RowTemplate.Height = 24
        Me.DataCommandeLivraison.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataCommandeLivraison.Size = New System.Drawing.Size(617, 419)
        Me.DataCommandeLivraison.TabIndex = 25
        Me.DataCommandeLivraison.Visible = False
        '
        'VarieteCommandeLivraisonChart
        '
        Me.VarieteCommandeLivraisonChart.BackSecondaryColor = System.Drawing.Color.White
        Me.VarieteCommandeLivraisonChart.BorderlineColor = System.Drawing.Color.Black
        Me.VarieteCommandeLivraisonChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
        ChartArea2.Name = "ChartArea1"
        Me.VarieteCommandeLivraisonChart.ChartAreas.Add(ChartArea2)
        Me.VarieteCommandeLivraisonChart.Cursor = System.Windows.Forms.Cursors.Hand
        Legend2.Alignment = System.Drawing.StringAlignment.Far
        Legend2.DockedToChartArea = "ChartArea1"
        Legend2.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Legend2.IsDockedInsideChartArea = False
        Legend2.IsTextAutoFit = False
        Legend2.Name = "Legend1"
        Me.VarieteCommandeLivraisonChart.Legends.Add(Legend2)
        Me.VarieteCommandeLivraisonChart.Location = New System.Drawing.Point(0, 0)
        Me.VarieteCommandeLivraisonChart.Name = "VarieteCommandeLivraisonChart"
        Me.VarieteCommandeLivraisonChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
        Series3.ChartArea = "ChartArea1"
        Series3.Color = System.Drawing.Color.LightSeaGreen
        Series3.EmptyPointStyle.BorderColor = System.Drawing.Color.DarkRed
        Series3.EmptyPointStyle.BorderWidth = 2
        Series3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series3.Label = "#VAL"
        Series3.LabelForeColor = System.Drawing.Color.DarkGray
        Series3.Legend = "Legend1"
        Series3.Name = "Quantité commandée en KG"
        Series3.ToolTip = "#VAL KG"
        Series4.ChartArea = "ChartArea1"
        Series4.Color = System.Drawing.Color.Aquamarine
        Series4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series4.IsValueShownAsLabel = True
        Series4.Label = "#VAL"
        Series4.LabelForeColor = System.Drawing.Color.DarkGray
        Series4.Legend = "Legend1"
        Series4.Name = "Quantité livrée en KG"
        Series4.ToolTip = "#VAL KG"
        Me.VarieteCommandeLivraisonChart.Series.Add(Series3)
        Me.VarieteCommandeLivraisonChart.Series.Add(Series4)
        Me.VarieteCommandeLivraisonChart.Size = New System.Drawing.Size(617, 419)
        Me.VarieteCommandeLivraisonChart.TabIndex = 4
        Me.VarieteCommandeLivraisonChart.Text = "Chart3"
        Title4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left
        Title4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title4.ForeColor = System.Drawing.Color.DimGray
        Title4.Name = "Title1"
        Title4.Text = "Quantité en KG"
        Title5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title5.ForeColor = System.Drawing.Color.DarkGreen
        Title5.Name = "Title2"
        Title5.Text = "Quantité commandée / Quantité livrée"
        Title6.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom
        Title6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title6.ForeColor = System.Drawing.Color.DarkGreen
        Title6.Name = "Title3"
        Title6.Text = "Variétés"
        Me.VarieteCommandeLivraisonChart.Titles.Add(Title4)
        Me.VarieteCommandeLivraisonChart.Titles.Add(Title5)
        Me.VarieteCommandeLivraisonChart.Titles.Add(Title6)
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
        'VarieteCommandeCheckedList
        '
        Me.VarieteCommandeCheckedList.CheckOnClick = True
        Me.VarieteCommandeCheckedList.FormattingEnabled = True
        Me.VarieteCommandeCheckedList.Location = New System.Drawing.Point(7, 94)
        Me.VarieteCommandeCheckedList.Name = "VarieteCommandeCheckedList"
        Me.VarieteCommandeCheckedList.Size = New System.Drawing.Size(263, 88)
        Me.VarieteCommandeCheckedList.TabIndex = 13
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
        'ClientCommandeCheckedList
        '
        Me.ClientCommandeCheckedList.CheckOnClick = True
        Me.ClientCommandeCheckedList.FormattingEnabled = True
        Me.ClientCommandeCheckedList.Location = New System.Drawing.Point(7, 222)
        Me.ClientCommandeCheckedList.Name = "ClientCommandeCheckedList"
        Me.ClientCommandeCheckedList.Size = New System.Drawing.Size(263, 88)
        Me.ClientCommandeCheckedList.TabIndex = 18
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
        'DateDebut
        '
        Me.DateDebut.CustomFormat = "yyyy-MM-dd"
        Me.DateDebut.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateDebut.Location = New System.Drawing.Point(13, 461)
        Me.DateDebut.Name = "DateDebut"
        Me.DateDebut.Size = New System.Drawing.Size(263, 26)
        Me.DateDebut.TabIndex = 20
        Me.DateDebut.Visible = False
        '
        'DateFin
        '
        Me.DateFin.CustomFormat = "yyyy-MM-dd"
        Me.DateFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFin.Location = New System.Drawing.Point(13, 512)
        Me.DateFin.Name = "DateFin"
        Me.DateFin.Size = New System.Drawing.Size(263, 26)
        Me.DateFin.TabIndex = 21
        Me.DateFin.Visible = False
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
        'DataVarieteProduction
        '
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        Me.DataVarieteProduction.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.DataVarieteProduction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataVarieteProduction.BackgroundColor = System.Drawing.Color.White
        Me.DataVarieteProduction.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataVarieteProduction.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.NullValue = "-"
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataVarieteProduction.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.DataVarieteProduction.ColumnHeadersHeight = 40
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataVarieteProduction.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataVarieteProduction.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DataVarieteProduction.EnableHeadersVisualStyles = False
        Me.DataVarieteProduction.Location = New System.Drawing.Point(0, 1)
        Me.DataVarieteProduction.Margin = New System.Windows.Forms.Padding(2)
        Me.DataVarieteProduction.Name = "DataVarieteProduction"
        Me.DataVarieteProduction.ReadOnly = True
        Me.DataVarieteProduction.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataVarieteProduction.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.DataVarieteProduction.RowTemplate.Height = 24
        Me.DataVarieteProduction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataVarieteProduction.Size = New System.Drawing.Size(617, 419)
        Me.DataVarieteProduction.TabIndex = 27
        Me.DataVarieteProduction.Visible = False
        '
        'Panel3
        '
        Me.Panel3.AutoScroll = True
        Me.Panel3.AutoScrollMargin = New System.Drawing.Size(0, 50)
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
        'VarieteProductionCheckedList
        '
        Me.VarieteProductionCheckedList.CheckOnClick = True
        Me.VarieteProductionCheckedList.FormattingEnabled = True
        Me.VarieteProductionCheckedList.Location = New System.Drawing.Point(7, 94)
        Me.VarieteProductionCheckedList.Name = "VarieteProductionCheckedList"
        Me.VarieteProductionCheckedList.Size = New System.Drawing.Size(263, 88)
        Me.VarieteProductionCheckedList.TabIndex = 13
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
        'LocaliteCheckedList
        '
        Me.LocaliteCheckedList.CheckOnClick = True
        Me.LocaliteCheckedList.FormattingEnabled = True
        Me.LocaliteCheckedList.Location = New System.Drawing.Point(7, 209)
        Me.LocaliteCheckedList.Name = "LocaliteCheckedList"
        Me.LocaliteCheckedList.Size = New System.Drawing.Size(263, 88)
        Me.LocaliteCheckedList.TabIndex = 18
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
        'NiveauCheckedList
        '
        Me.NiveauCheckedList.CheckOnClick = True
        Me.NiveauCheckedList.FormattingEnabled = True
        Me.NiveauCheckedList.Location = New System.Drawing.Point(7, 319)
        Me.NiveauCheckedList.Name = "NiveauCheckedList"
        Me.NiveauCheckedList.Size = New System.Drawing.Size(263, 88)
        Me.NiveauCheckedList.TabIndex = 20
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
        'DateDebutProduction
        '
        Me.DateDebutProduction.CustomFormat = "yyyy-MM-dd"
        Me.DateDebutProduction.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateDebutProduction.Location = New System.Drawing.Point(7, 564)
        Me.DateDebutProduction.Name = "DateDebutProduction"
        Me.DateDebutProduction.Size = New System.Drawing.Size(263, 26)
        Me.DateDebutProduction.TabIndex = 22
        Me.DateDebutProduction.Visible = False
        '
        'DateFinProduction
        '
        Me.DateFinProduction.CustomFormat = "yyyy-MM-dd"
        Me.DateFinProduction.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFinProduction.Location = New System.Drawing.Point(7, 596)
        Me.DateFinProduction.Name = "DateFinProduction"
        Me.DateFinProduction.Size = New System.Drawing.Size(263, 26)
        Me.DateFinProduction.TabIndex = 23
        Me.DateFinProduction.Visible = False
        '
        'VarieteProductionCommandeChart
        '
        Me.VarieteProductionCommandeChart.BackSecondaryColor = System.Drawing.Color.White
        Me.VarieteProductionCommandeChart.BorderlineColor = System.Drawing.Color.Black
        Me.VarieteProductionCommandeChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
        ChartArea3.Name = "ChartArea1"
        Me.VarieteProductionCommandeChart.ChartAreas.Add(ChartArea3)
        Me.VarieteProductionCommandeChart.Cursor = System.Windows.Forms.Cursors.Hand
        Legend3.Alignment = System.Drawing.StringAlignment.Far
        Legend3.DockedToChartArea = "ChartArea1"
        Legend3.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Legend3.IsDockedInsideChartArea = False
        Legend3.IsTextAutoFit = False
        Legend3.Name = "Legend1"
        Me.VarieteProductionCommandeChart.Legends.Add(Legend3)
        Me.VarieteProductionCommandeChart.Location = New System.Drawing.Point(0, 1)
        Me.VarieteProductionCommandeChart.Name = "VarieteProductionCommandeChart"
        Me.VarieteProductionCommandeChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent
        Series5.ChartArea = "ChartArea1"
        Series5.Color = System.Drawing.Color.PeachPuff
        Series5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series5.IsValueShownAsLabel = True
        Series5.Label = "#VAL"
        Series5.LabelForeColor = System.Drawing.Color.DarkGoldenrod
        Series5.Legend = "Legend1"
        Series5.Name = "Quantité produite en KG"
        Series5.ToolTip = "#VAL KG"
        Me.VarieteProductionCommandeChart.Series.Add(Series5)
        Me.VarieteProductionCommandeChart.Size = New System.Drawing.Size(617, 419)
        Me.VarieteProductionCommandeChart.TabIndex = 28
        Me.VarieteProductionCommandeChart.Text = "Chart3"
        Title7.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left
        Title7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title7.ForeColor = System.Drawing.Color.DarkGreen
        Title7.Name = "Title1"
        Title7.Text = "Quantité en KG"
        Title8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title8.ForeColor = System.Drawing.Color.DarkGreen
        Title8.Name = "Title2"
        Title8.Text = "Quantité produite par variété"
        Title9.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom
        Title9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title9.ForeColor = System.Drawing.Color.DarkGreen
        Title9.Name = "Title3"
        Title9.Text = "Spéculations"
        Me.VarieteProductionCommandeChart.Titles.Add(Title7)
        Me.VarieteProductionCommandeChart.Titles.Add(Title8)
        Me.VarieteProductionCommandeChart.Titles.Add(Title9)
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
        Me.Panel4.ResumeLayout(False)
        CType(Me.DataCommandeProduction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommandeProductionChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.RapportSpeculation.ResumeLayout(False)
        Me.VarieteTab.ResumeLayout(False)
        Me.VarieteTab.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.Commandes.ResumeLayout(False)
        CType(Me.DataCommandeLivraison, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VarieteCommandeLivraisonChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Production.ResumeLayout(False)
        CType(Me.DataVarieteProduction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.VarieteProductionCommandeChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabRapports.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SemencesDataSet As semencesDataSet
    Friend WithEvents CommandeBindingSource As BindingSource
    Friend WithEvents CommandeTableAdapter As semencesDataSetTableAdapters.commandeTableAdapter
    Friend WithEvents SpeculationBindingSource As BindingSource
    Friend WithEvents General As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RapportSpeculation As TabControl
    Friend WithEvents VarieteTab As TabPage
    Friend WithEvents DateFinGen As DateTimePicker
    Friend WithEvents FiltrerParDateGen As CheckBox
    Friend WithEvents Label10 As Label
    Friend WithEvents DateDebutGen As DateTimePicker
    Friend WithEvents NomSpeculationGen As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TableauGen As RadioButton
    Friend WithEvents GraphiqueGen As RadioButton
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GenVarieteCheckedList As CheckedListBox
    Friend WithEvents GenLocaliteCheckedList As CheckedListBox
    Friend WithEvents GenClientCheckedList As CheckedListBox
    Friend WithEvents GenNiveauCheckedList As CheckedListBox
    Friend WithEvents SpeculationTab As TabPage
    Friend WithEvents Panel4 As Panel
    Friend WithEvents CommandeProductionChart As DataVisualization.Charting.Chart
    Friend WithEvents DataCommandeProduction As DataGridView
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
    Friend WithEvents TabRapports As TabControl
End Class

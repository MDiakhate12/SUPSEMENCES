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
        Dim ChartArea10 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend10 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series16 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series17 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title28 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim Title29 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim Title30 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim DataGridViewCellStyle37 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle38 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle39 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle40 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea11 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend11 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series18 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series19 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title31 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim Title32 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim Title33 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim DataGridViewCellStyle41 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle42 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle43 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle44 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea12 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend12 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series20 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Title34 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim Title35 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim Title36 As System.Windows.Forms.DataVisualization.Charting.Title = New System.Windows.Forms.DataVisualization.Charting.Title()
        Dim DataGridViewCellStyle45 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle46 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle47 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle48 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SpeculationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CommandeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.General = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.SplitContainer3 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.VueDetailleeGen = New System.Windows.Forms.RadioButton()
        Me.VueGlobaleGen = New System.Windows.Forms.RadioButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TableauGen = New System.Windows.Forms.RadioButton()
        Me.GraphiqueGen = New System.Windows.Forms.RadioButton()
        Me.PanelDetailGen = New System.Windows.Forms.Panel()
        Me.PanelDateGen = New System.Windows.Forms.Panel()
        Me.DateFinGen = New System.Windows.Forms.DateTimePicker()
        Me.FiltrerDateGen = New System.Windows.Forms.CheckBox()
        Me.DateDebutGen = New System.Windows.Forms.DateTimePicker()
        Me.PanelClientGen = New System.Windows.Forms.Panel()
        Me.FiltrerClientGen = New System.Windows.Forms.CheckBox()
        Me.GenClientCheckedList = New System.Windows.Forms.CheckedListBox()
        Me.PanelNiveauGen = New System.Windows.Forms.Panel()
        Me.FiltrerNiveauGen = New System.Windows.Forms.CheckBox()
        Me.GenNiveauCheckedList = New System.Windows.Forms.CheckedListBox()
        Me.PanelLocaliteGen = New System.Windows.Forms.Panel()
        Me.FiltrerLocaliteGen = New System.Windows.Forms.CheckBox()
        Me.GenLocaliteCheckedList = New System.Windows.Forms.CheckedListBox()
        Me.PanelVarieteGen = New System.Windows.Forms.Panel()
        Me.FiltrerVarieteGen = New System.Windows.Forms.CheckBox()
        Me.GenVarieteCheckedList = New System.Windows.Forms.CheckedListBox()
        Me.Panel = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NomSpeculationGen = New System.Windows.Forms.ComboBox()
        Me.CommandeProductionChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.DataCommandeProduction = New System.Windows.Forms.DataGridView()
        Me.Commandes = New System.Windows.Forms.TabPage()
        Me.VarieteCommandeLivraisonChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.VueDetailleeCommande = New System.Windows.Forms.RadioButton()
        Me.VueGlobaleCommande = New System.Windows.Forms.RadioButton()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Tableau = New System.Windows.Forms.RadioButton()
        Me.Graphique = New System.Windows.Forms.RadioButton()
        Me.PanelDetailCommande = New System.Windows.Forms.Panel()
        Me.PanelDateCommande = New System.Windows.Forms.Panel()
        Me.FiltrerDateCommande = New System.Windows.Forms.CheckBox()
        Me.DateDebut = New System.Windows.Forms.DateTimePicker()
        Me.DateFin = New System.Windows.Forms.DateTimePicker()
        Me.PanelClientCommande = New System.Windows.Forms.Panel()
        Me.FiltrerClientCommande = New System.Windows.Forms.CheckBox()
        Me.ClientCommandeCheckedList = New System.Windows.Forms.CheckedListBox()
        Me.PanelNiveauCommande = New System.Windows.Forms.Panel()
        Me.FiltrerNiveauCommande = New System.Windows.Forms.CheckBox()
        Me.NiveauCommandeCheckedList = New System.Windows.Forms.CheckedListBox()
        Me.PanelLocaliteCommande = New System.Windows.Forms.Panel()
        Me.FiltrerLocaliteCommande = New System.Windows.Forms.CheckBox()
        Me.LocaliteCommandeCheckedList = New System.Windows.Forms.CheckedListBox()
        Me.PanelVarieteCommande = New System.Windows.Forms.Panel()
        Me.VarieteCommandeCheckedList = New System.Windows.Forms.CheckedListBox()
        Me.FiltrerVarieteCommande = New System.Windows.Forms.CheckBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NomSpeculationCommande = New System.Windows.Forms.ComboBox()
        Me.DataCommandeLivraison = New System.Windows.Forms.DataGridView()
        Me.Production = New System.Windows.Forms.TabPage()
        Me.VarieteProductionCommandeChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.DataVarieteProduction = New System.Windows.Forms.DataGridView()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.VueParVariete = New System.Windows.Forms.RadioButton()
        Me.VueParSpeculation = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TableauProduction = New System.Windows.Forms.RadioButton()
        Me.GraphiqueProduction = New System.Windows.Forms.RadioButton()
        Me.PanelVueParVariete = New System.Windows.Forms.Panel()
        Me.PanelDate = New System.Windows.Forms.Panel()
        Me.FiltrerParDateProduction = New System.Windows.Forms.CheckBox()
        Me.DateDebutProduction = New System.Windows.Forms.DateTimePicker()
        Me.DateFinProduction = New System.Windows.Forms.DateTimePicker()
        Me.PanelNiveau = New System.Windows.Forms.Panel()
        Me.FiltrerNiveau = New System.Windows.Forms.CheckBox()
        Me.NiveauCheckedList = New System.Windows.Forms.CheckedListBox()
        Me.PanelLocalite = New System.Windows.Forms.Panel()
        Me.FiltrerLocalite = New System.Windows.Forms.CheckBox()
        Me.LocaliteCheckedList = New System.Windows.Forms.CheckedListBox()
        Me.PanelVariete = New System.Windows.Forms.Panel()
        Me.VarieteProductionCheckedList = New System.Windows.Forms.CheckedListBox()
        Me.FiltrerVariete = New System.Windows.Forms.CheckBox()
        Me.PanelSpeculation = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NomSpeculationProduction = New System.Windows.Forms.ComboBox()
        Me.TabRapports = New System.Windows.Forms.TabControl()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer4 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer6 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer7 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer8 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer9 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer10 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer11 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer12 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer13 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer14 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer15 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.SpeculationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CommandeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.General.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.PanelDetailGen.SuspendLayout()
        Me.PanelDateGen.SuspendLayout()
        Me.PanelClientGen.SuspendLayout()
        Me.PanelNiveauGen.SuspendLayout()
        Me.PanelLocaliteGen.SuspendLayout()
        Me.PanelVarieteGen.SuspendLayout()
        Me.Panel.SuspendLayout()
        CType(Me.CommandeProductionChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataCommandeProduction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Commandes.SuspendLayout()
        CType(Me.VarieteCommandeLivraisonChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.PanelDetailCommande.SuspendLayout()
        Me.PanelDateCommande.SuspendLayout()
        Me.PanelClientCommande.SuspendLayout()
        Me.PanelNiveauCommande.SuspendLayout()
        Me.PanelLocaliteCommande.SuspendLayout()
        Me.PanelVarieteCommande.SuspendLayout()
        Me.Panel9.SuspendLayout()
        CType(Me.DataCommandeLivraison, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Production.SuspendLayout()
        CType(Me.VarieteProductionCommandeChart, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataVarieteProduction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.PanelVueParVariete.SuspendLayout()
        Me.PanelDate.SuspendLayout()
        Me.PanelNiveau.SuspendLayout()
        Me.PanelLocalite.SuspendLayout()
        Me.PanelVariete.SuspendLayout()
        Me.PanelSpeculation.SuspendLayout()
        Me.TabRapports.SuspendLayout()
        Me.SuspendLayout()
        '
        'CommandeBindingSource
        '
        Me.CommandeBindingSource.DataMember = "commande"
        '
        'General
        '
        Me.General.Controls.Add(Me.Panel4)
        Me.General.Location = New System.Drawing.Point(4, 44)
        Me.General.Margin = New System.Windows.Forms.Padding(4)
        Me.General.Name = "General"
        Me.General.Padding = New System.Windows.Forms.Padding(4)
        Me.General.Size = New System.Drawing.Size(1596, 833)
        Me.General.TabIndex = 1
        Me.General.Text = "Statistiques générales"
        Me.General.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.SplitContainer3)
        Me.Panel4.Controls.Add(Me.CommandeProductionChart)
        Me.Panel4.Controls.Add(Me.DataCommandeProduction)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(4, 4)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1588, 825)
        Me.Panel4.TabIndex = 28
        '
        'SplitContainer3
        '
        Me.SplitContainer3.Dock = System.Windows.Forms.DockStyle.Right
        Me.SplitContainer3.Location = New System.Drawing.Point(1082, 0)
        Me.SplitContainer3.Name = "SplitContainer3"
        Me.SplitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.GroupBox1)
        Me.SplitContainer3.Panel1.Controls.Add(Me.GroupBox3)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.PanelDetailGen)
        Me.SplitContainer3.Size = New System.Drawing.Size(506, 825)
        Me.SplitContainer3.SplitterDistance = 86
        Me.SplitContainer3.TabIndex = 37
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.VueDetailleeGen)
        Me.GroupBox1.Controls.Add(Me.VueGlobaleGen)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(177, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(329, 86)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mode de filtrage"
        '
        'VueDetailleeGen
        '
        Me.VueDetailleeGen.AutoSize = True
        Me.VueDetailleeGen.Location = New System.Drawing.Point(8, 68)
        Me.VueDetailleeGen.Margin = New System.Windows.Forms.Padding(4)
        Me.VueDetailleeGen.Name = "VueDetailleeGen"
        Me.VueDetailleeGen.Size = New System.Drawing.Size(207, 24)
        Me.VueDetailleeGen.TabIndex = 17
        Me.VueDetailleeGen.Text = "Vue détaillée (par variété)"
        Me.VueDetailleeGen.UseVisualStyleBackColor = True
        '
        'VueGlobaleGen
        '
        Me.VueGlobaleGen.AutoSize = True
        Me.VueGlobaleGen.Checked = True
        Me.VueGlobaleGen.Location = New System.Drawing.Point(8, 31)
        Me.VueGlobaleGen.Margin = New System.Windows.Forms.Padding(4)
        Me.VueGlobaleGen.Name = "VueGlobaleGen"
        Me.VueGlobaleGen.Size = New System.Drawing.Size(233, 24)
        Me.VueGlobaleGen.TabIndex = 16
        Me.VueGlobaleGen.TabStop = True
        Me.VueGlobaleGen.Text = "Vue globale (par spéculation)"
        Me.VueGlobaleGen.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TableauGen)
        Me.GroupBox3.Controls.Add(Me.GraphiqueGen)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(177, 86)
        Me.GroupBox3.TabIndex = 17
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Affichage"
        '
        'TableauGen
        '
        Me.TableauGen.AutoSize = True
        Me.TableauGen.Checked = True
        Me.TableauGen.Location = New System.Drawing.Point(8, 31)
        Me.TableauGen.Margin = New System.Windows.Forms.Padding(4)
        Me.TableauGen.Name = "TableauGen"
        Me.TableauGen.Size = New System.Drawing.Size(84, 24)
        Me.TableauGen.TabIndex = 17
        Me.TableauGen.TabStop = True
        Me.TableauGen.Text = "Tableau"
        Me.TableauGen.UseVisualStyleBackColor = True
        '
        'GraphiqueGen
        '
        Me.GraphiqueGen.AutoSize = True
        Me.GraphiqueGen.Location = New System.Drawing.Point(8, 68)
        Me.GraphiqueGen.Margin = New System.Windows.Forms.Padding(4)
        Me.GraphiqueGen.Name = "GraphiqueGen"
        Me.GraphiqueGen.Size = New System.Drawing.Size(102, 24)
        Me.GraphiqueGen.TabIndex = 16
        Me.GraphiqueGen.Text = "Graphique"
        Me.GraphiqueGen.UseVisualStyleBackColor = True
        '
        'PanelDetailGen
        '
        Me.PanelDetailGen.AutoScroll = True
        Me.PanelDetailGen.AutoScrollMargin = New System.Drawing.Size(0, 30)
        Me.PanelDetailGen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelDetailGen.Controls.Add(Me.PanelDateGen)
        Me.PanelDetailGen.Controls.Add(Me.PanelClientGen)
        Me.PanelDetailGen.Controls.Add(Me.PanelNiveauGen)
        Me.PanelDetailGen.Controls.Add(Me.PanelLocaliteGen)
        Me.PanelDetailGen.Controls.Add(Me.PanelVarieteGen)
        Me.PanelDetailGen.Controls.Add(Me.Panel)
        Me.PanelDetailGen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDetailGen.Location = New System.Drawing.Point(0, 0)
        Me.PanelDetailGen.Name = "PanelDetailGen"
        Me.PanelDetailGen.Size = New System.Drawing.Size(506, 735)
        Me.PanelDetailGen.TabIndex = 34
        Me.PanelDetailGen.Visible = False
        '
        'PanelDateGen
        '
        Me.PanelDateGen.BackColor = System.Drawing.Color.Transparent
        Me.PanelDateGen.Controls.Add(Me.DateFinGen)
        Me.PanelDateGen.Controls.Add(Me.FiltrerDateGen)
        Me.PanelDateGen.Controls.Add(Me.DateDebutGen)
        Me.PanelDateGen.Cursor = System.Windows.Forms.Cursors.Default
        Me.PanelDateGen.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelDateGen.ForeColor = System.Drawing.Color.Black
        Me.PanelDateGen.Location = New System.Drawing.Point(0, 253)
        Me.PanelDateGen.MaximumSize = New System.Drawing.Size(500, 210)
        Me.PanelDateGen.MinimumSize = New System.Drawing.Size(500, 53)
        Me.PanelDateGen.Name = "PanelDateGen"
        Me.PanelDateGen.Size = New System.Drawing.Size(500, 53)
        Me.PanelDateGen.TabIndex = 33
        '
        'DateFinGen
        '
        Me.DateFinGen.CustomFormat = "yyyy-MM-dd"
        Me.DateFinGen.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFinGen.Location = New System.Drawing.Point(4, 95)
        Me.DateFinGen.Margin = New System.Windows.Forms.Padding(4)
        Me.DateFinGen.Name = "DateFinGen"
        Me.DateFinGen.Size = New System.Drawing.Size(349, 26)
        Me.DateFinGen.TabIndex = 23
        Me.DateFinGen.Visible = False
        '
        'FiltrerDateGen
        '
        Me.FiltrerDateGen.AutoSize = True
        Me.FiltrerDateGen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FiltrerDateGen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FiltrerDateGen.Location = New System.Drawing.Point(7, 6)
        Me.FiltrerDateGen.Margin = New System.Windows.Forms.Padding(4)
        Me.FiltrerDateGen.Name = "FiltrerDateGen"
        Me.FiltrerDateGen.Size = New System.Drawing.Size(147, 24)
        Me.FiltrerDateGen.TabIndex = 15
        Me.FiltrerDateGen.Text = "Filtrer par date"
        Me.FiltrerDateGen.UseVisualStyleBackColor = True
        '
        'DateDebutGen
        '
        Me.DateDebutGen.CustomFormat = "yyyy-MM-dd"
        Me.DateDebutGen.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateDebutGen.Location = New System.Drawing.Point(4, 55)
        Me.DateDebutGen.Margin = New System.Windows.Forms.Padding(4)
        Me.DateDebutGen.Name = "DateDebutGen"
        Me.DateDebutGen.Size = New System.Drawing.Size(349, 26)
        Me.DateDebutGen.TabIndex = 22
        Me.DateDebutGen.Visible = False
        '
        'PanelClientGen
        '
        Me.PanelClientGen.BackColor = System.Drawing.Color.Transparent
        Me.PanelClientGen.Controls.Add(Me.FiltrerClientGen)
        Me.PanelClientGen.Controls.Add(Me.GenClientCheckedList)
        Me.PanelClientGen.Cursor = System.Windows.Forms.Cursors.Default
        Me.PanelClientGen.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelClientGen.ForeColor = System.Drawing.Color.Black
        Me.PanelClientGen.Location = New System.Drawing.Point(0, 200)
        Me.PanelClientGen.MaximumSize = New System.Drawing.Size(500, 210)
        Me.PanelClientGen.MinimumSize = New System.Drawing.Size(500, 53)
        Me.PanelClientGen.Name = "PanelClientGen"
        Me.PanelClientGen.Size = New System.Drawing.Size(500, 53)
        Me.PanelClientGen.TabIndex = 33
        '
        'FiltrerClientGen
        '
        Me.FiltrerClientGen.AutoSize = True
        Me.FiltrerClientGen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FiltrerClientGen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FiltrerClientGen.Location = New System.Drawing.Point(7, 6)
        Me.FiltrerClientGen.Name = "FiltrerClientGen"
        Me.FiltrerClientGen.Size = New System.Drawing.Size(83, 24)
        Me.FiltrerClientGen.TabIndex = 26
        Me.FiltrerClientGen.Text = "Clients"
        Me.FiltrerClientGen.UseVisualStyleBackColor = True
        '
        'GenClientCheckedList
        '
        Me.GenClientCheckedList.CheckOnClick = True
        Me.GenClientCheckedList.FormattingEnabled = True
        Me.GenClientCheckedList.Location = New System.Drawing.Point(4, 55)
        Me.GenClientCheckedList.Margin = New System.Windows.Forms.Padding(4)
        Me.GenClientCheckedList.Name = "GenClientCheckedList"
        Me.GenClientCheckedList.Size = New System.Drawing.Size(368, 151)
        Me.GenClientCheckedList.TabIndex = 24
        '
        'PanelNiveauGen
        '
        Me.PanelNiveauGen.BackColor = System.Drawing.Color.Transparent
        Me.PanelNiveauGen.Controls.Add(Me.FiltrerNiveauGen)
        Me.PanelNiveauGen.Controls.Add(Me.GenNiveauCheckedList)
        Me.PanelNiveauGen.Cursor = System.Windows.Forms.Cursors.Default
        Me.PanelNiveauGen.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelNiveauGen.ForeColor = System.Drawing.Color.Black
        Me.PanelNiveauGen.Location = New System.Drawing.Point(0, 147)
        Me.PanelNiveauGen.MaximumSize = New System.Drawing.Size(500, 210)
        Me.PanelNiveauGen.MinimumSize = New System.Drawing.Size(500, 53)
        Me.PanelNiveauGen.Name = "PanelNiveauGen"
        Me.PanelNiveauGen.Size = New System.Drawing.Size(500, 53)
        Me.PanelNiveauGen.TabIndex = 32
        '
        'FiltrerNiveauGen
        '
        Me.FiltrerNiveauGen.AutoSize = True
        Me.FiltrerNiveauGen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FiltrerNiveauGen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FiltrerNiveauGen.Location = New System.Drawing.Point(7, 6)
        Me.FiltrerNiveauGen.Name = "FiltrerNiveauGen"
        Me.FiltrerNiveauGen.Size = New System.Drawing.Size(95, 24)
        Me.FiltrerNiveauGen.TabIndex = 26
        Me.FiltrerNiveauGen.Text = "Niveaux "
        Me.FiltrerNiveauGen.UseVisualStyleBackColor = True
        '
        'GenNiveauCheckedList
        '
        Me.GenNiveauCheckedList.CheckOnClick = True
        Me.GenNiveauCheckedList.FormattingEnabled = True
        Me.GenNiveauCheckedList.Location = New System.Drawing.Point(4, 55)
        Me.GenNiveauCheckedList.Margin = New System.Windows.Forms.Padding(4)
        Me.GenNiveauCheckedList.Name = "GenNiveauCheckedList"
        Me.GenNiveauCheckedList.Size = New System.Drawing.Size(368, 151)
        Me.GenNiveauCheckedList.TabIndex = 20
        '
        'PanelLocaliteGen
        '
        Me.PanelLocaliteGen.BackColor = System.Drawing.Color.Transparent
        Me.PanelLocaliteGen.Controls.Add(Me.FiltrerLocaliteGen)
        Me.PanelLocaliteGen.Controls.Add(Me.GenLocaliteCheckedList)
        Me.PanelLocaliteGen.Cursor = System.Windows.Forms.Cursors.Default
        Me.PanelLocaliteGen.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLocaliteGen.ForeColor = System.Drawing.Color.Black
        Me.PanelLocaliteGen.Location = New System.Drawing.Point(0, 94)
        Me.PanelLocaliteGen.MaximumSize = New System.Drawing.Size(500, 210)
        Me.PanelLocaliteGen.MinimumSize = New System.Drawing.Size(500, 53)
        Me.PanelLocaliteGen.Name = "PanelLocaliteGen"
        Me.PanelLocaliteGen.Size = New System.Drawing.Size(500, 53)
        Me.PanelLocaliteGen.TabIndex = 31
        '
        'FiltrerLocaliteGen
        '
        Me.FiltrerLocaliteGen.AutoSize = True
        Me.FiltrerLocaliteGen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FiltrerLocaliteGen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FiltrerLocaliteGen.Location = New System.Drawing.Point(7, 6)
        Me.FiltrerLocaliteGen.Name = "FiltrerLocaliteGen"
        Me.FiltrerLocaliteGen.Size = New System.Drawing.Size(100, 24)
        Me.FiltrerLocaliteGen.TabIndex = 25
        Me.FiltrerLocaliteGen.Text = "Localités"
        Me.FiltrerLocaliteGen.UseVisualStyleBackColor = True
        '
        'GenLocaliteCheckedList
        '
        Me.GenLocaliteCheckedList.CheckOnClick = True
        Me.GenLocaliteCheckedList.FormattingEnabled = True
        Me.GenLocaliteCheckedList.Location = New System.Drawing.Point(4, 55)
        Me.GenLocaliteCheckedList.Margin = New System.Windows.Forms.Padding(4)
        Me.GenLocaliteCheckedList.Name = "GenLocaliteCheckedList"
        Me.GenLocaliteCheckedList.Size = New System.Drawing.Size(368, 151)
        Me.GenLocaliteCheckedList.TabIndex = 18
        '
        'PanelVarieteGen
        '
        Me.PanelVarieteGen.BackColor = System.Drawing.Color.Transparent
        Me.PanelVarieteGen.Controls.Add(Me.FiltrerVarieteGen)
        Me.PanelVarieteGen.Controls.Add(Me.GenVarieteCheckedList)
        Me.PanelVarieteGen.Cursor = System.Windows.Forms.Cursors.Default
        Me.PanelVarieteGen.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelVarieteGen.ForeColor = System.Drawing.Color.Black
        Me.PanelVarieteGen.Location = New System.Drawing.Point(0, 41)
        Me.PanelVarieteGen.MaximumSize = New System.Drawing.Size(500, 210)
        Me.PanelVarieteGen.MinimumSize = New System.Drawing.Size(500, 53)
        Me.PanelVarieteGen.Name = "PanelVarieteGen"
        Me.PanelVarieteGen.Size = New System.Drawing.Size(500, 53)
        Me.PanelVarieteGen.TabIndex = 30
        '
        'FiltrerVarieteGen
        '
        Me.FiltrerVarieteGen.AutoSize = True
        Me.FiltrerVarieteGen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FiltrerVarieteGen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FiltrerVarieteGen.Location = New System.Drawing.Point(7, 6)
        Me.FiltrerVarieteGen.Name = "FiltrerVarieteGen"
        Me.FiltrerVarieteGen.Size = New System.Drawing.Size(95, 24)
        Me.FiltrerVarieteGen.TabIndex = 24
        Me.FiltrerVarieteGen.Text = "Variétés"
        Me.FiltrerVarieteGen.UseVisualStyleBackColor = True
        '
        'GenVarieteCheckedList
        '
        Me.GenVarieteCheckedList.CheckOnClick = True
        Me.GenVarieteCheckedList.FormattingEnabled = True
        Me.GenVarieteCheckedList.Location = New System.Drawing.Point(4, 55)
        Me.GenVarieteCheckedList.Margin = New System.Windows.Forms.Padding(4)
        Me.GenVarieteCheckedList.Name = "GenVarieteCheckedList"
        Me.GenVarieteCheckedList.Size = New System.Drawing.Size(368, 151)
        Me.GenVarieteCheckedList.TabIndex = 13
        '
        'Panel
        '
        Me.Panel.BackColor = System.Drawing.Color.Transparent
        Me.Panel.Controls.Add(Me.Label1)
        Me.Panel.Controls.Add(Me.NomSpeculationGen)
        Me.Panel.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel.ForeColor = System.Drawing.Color.Black
        Me.Panel.Location = New System.Drawing.Point(0, 0)
        Me.Panel.MaximumSize = New System.Drawing.Size(500, 75)
        Me.Panel.MinimumSize = New System.Drawing.Size(500, 41)
        Me.Panel.Name = "Panel"
        Me.Panel.Size = New System.Drawing.Size(500, 41)
        Me.Panel.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 20)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Spéculation"
        '
        'NomSpeculationGen
        '
        Me.NomSpeculationGen.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NomSpeculationGen.AutoCompleteCustomSource.AddRange(New String() {"IRAT 10", "Dj 8-341", "ITA 150", "WAB 56-50", "Nerica 1", "Nerica 5", "Nerica 6 ", "Dj 684 D", "Dj 11-509", "Dj 12-519", "BW 248-1", "BR 51-46-5", "ITA 123", "Tox 728-1", "BG 90-2 ", "Rok 5", "WAR 1", "WAR 77-3-2-2", "WAR 81-2-1-3-2", "Ikong Pao", "IR 8", "Jaya", "IR 1529-680-3", "IR 442", "KH 998", "Kwang She Shun", "Sahel 108", "Sahel 134", "Sahel 159", "Sahel 177", "Sahel 201", "Sahel 202 ", "Sahel 208", "Sahel 209", "Sahel 210", "Sahel 217", "Sahel 222", "Sahel 305", "Sahel 317", "Sahel 328", "Sahel 329", "Nerica-S-19", "Nerica-S-21", "Nerica-S-36", "Nerica-S-44", "Souna 3", "IBV 8001", "IBV 8004", "IBMV 8402", "ISMI 9507", "Gawane", "Thialack 2", "Xéewel Gi", "Noor 96", "Doo Mer", "Sooror", "Gaaw Na", "Jaboot", "Goor Yomboul", "Yaayi Séex ", "28-206", "756-A", "55-437", "57-313", "57-422", "69-101", "73-27", "73-28", "73-30", "73-33", "GC 8-35", "Fleur 11", "78-937", "55-33", "SRV 1-19", "73-9-11", "GH 119-20", "PC79-79", "H 75-0", "58-57", "Ndiambour", "Mougne", "Bambey 21", "TN 88-63", "CB-5", "Diongoma", "Mélakh", "Mouride", "Yacine", "Pakau ", "58-74 f", "66-35 f", "Noflaye", "Gandiole", "Gao", "Solara", "Sirocco", "Julio", "Damani", "Belami", "Alizé ", "CE 145-66", "CE 151-262", "CE 180-33", "CE 196-7-2-1", "F2-20", "Faourou", "Nguinte", "Nganda", "Darou "})
        Me.NomSpeculationGen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.NomSpeculationGen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.NomSpeculationGen.DataSource = Me.SpeculationBindingSource
        Me.NomSpeculationGen.DisplayMember = "id_speculation"
        Me.NomSpeculationGen.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomSpeculationGen.FormattingEnabled = True
        Me.NomSpeculationGen.Location = New System.Drawing.Point(184, 6)
        Me.NomSpeculationGen.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NomSpeculationGen.Name = "NomSpeculationGen"
        Me.NomSpeculationGen.Size = New System.Drawing.Size(165, 28)
        Me.NomSpeculationGen.TabIndex = 10
        Me.NomSpeculationGen.ValueMember = "id_speculation"
        '
        'CommandeProductionChart
        '
        Me.CommandeProductionChart.BackSecondaryColor = System.Drawing.Color.White
        Me.CommandeProductionChart.BorderlineColor = System.Drawing.Color.Black
        Me.CommandeProductionChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
        ChartArea10.Name = "ChartArea1"
        Me.CommandeProductionChart.ChartAreas.Add(ChartArea10)
        Me.CommandeProductionChart.Cursor = System.Windows.Forms.Cursors.Hand
        Legend10.Alignment = System.Drawing.StringAlignment.Far
        Legend10.DockedToChartArea = "ChartArea1"
        Legend10.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Legend10.IsDockedInsideChartArea = False
        Legend10.IsTextAutoFit = False
        Legend10.Name = "Legend1"
        Me.CommandeProductionChart.Legends.Add(Legend10)
        Me.CommandeProductionChart.Location = New System.Drawing.Point(5, 5)
        Me.CommandeProductionChart.Margin = New System.Windows.Forms.Padding(4)
        Me.CommandeProductionChart.Name = "CommandeProductionChart"
        Me.CommandeProductionChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent
        Series16.ChartArea = "ChartArea1"
        Series16.Color = System.Drawing.Color.MediumTurquoise
        Series16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series16.IsValueShownAsLabel = True
        Series16.Label = "#VAL"
        Series16.LabelForeColor = System.Drawing.Color.DarkGoldenrod
        Series16.Legend = "Legend1"
        Series16.Name = "Quantité produite en KG"
        Series16.ToolTip = "#VAL KG"
        Series17.ChartArea = "ChartArea1"
        Series17.Color = System.Drawing.Color.LightCoral
        Series17.EmptyPointStyle.BorderColor = System.Drawing.Color.DarkRed
        Series17.EmptyPointStyle.BorderWidth = 2
        Series17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series17.Label = "#VAL"
        Series17.LabelForeColor = System.Drawing.Color.DarkGreen
        Series17.Legend = "Legend1"
        Series17.Name = "Quantité commandée en KG"
        Series17.ToolTip = "#VAL KG"
        Me.CommandeProductionChart.Series.Add(Series16)
        Me.CommandeProductionChart.Series.Add(Series17)
        Me.CommandeProductionChart.Size = New System.Drawing.Size(900, 660)
        Me.CommandeProductionChart.TabIndex = 4
        Me.CommandeProductionChart.Text = "Chart2"
        Title28.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left
        Title28.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title28.ForeColor = System.Drawing.Color.DarkGreen
        Title28.Name = "Title1"
        Title28.Text = "Quantité en KG"
        Title29.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title29.ForeColor = System.Drawing.Color.DarkGreen
        Title29.Name = "Title2"
        Title29.Text = "Quantité produite / Quantité commandée "
        Title30.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom
        Title30.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title30.ForeColor = System.Drawing.Color.DarkGreen
        Title30.Name = "Title3"
        Title30.Text = "Variétés"
        Me.CommandeProductionChart.Titles.Add(Title28)
        Me.CommandeProductionChart.Titles.Add(Title29)
        Me.CommandeProductionChart.Titles.Add(Title30)
        '
        'DataCommandeProduction
        '
        DataGridViewCellStyle37.BackColor = System.Drawing.Color.White
        Me.DataCommandeProduction.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle37
        Me.DataCommandeProduction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataCommandeProduction.BackgroundColor = System.Drawing.Color.White
        Me.DataCommandeProduction.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataCommandeProduction.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle38.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        DataGridViewCellStyle38.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle38.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle38.NullValue = "-"
        DataGridViewCellStyle38.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle38.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        DataGridViewCellStyle38.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataCommandeProduction.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle38
        Me.DataCommandeProduction.ColumnHeadersHeight = 40
        DataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle39.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle39.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle39.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle39.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle39.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle39.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataCommandeProduction.DefaultCellStyle = DataGridViewCellStyle39
        Me.DataCommandeProduction.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DataCommandeProduction.EnableHeadersVisualStyles = False
        Me.DataCommandeProduction.Location = New System.Drawing.Point(5, 5)
        Me.DataCommandeProduction.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataCommandeProduction.Name = "DataCommandeProduction"
        Me.DataCommandeProduction.ReadOnly = True
        Me.DataCommandeProduction.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle40.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle40.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle40.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle40.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle40.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle40.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataCommandeProduction.RowHeadersDefaultCellStyle = DataGridViewCellStyle40
        Me.DataCommandeProduction.RowTemplate.Height = 24
        Me.DataCommandeProduction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataCommandeProduction.Size = New System.Drawing.Size(900, 660)
        Me.DataCommandeProduction.TabIndex = 26
        '
        'Commandes
        '
        Me.Commandes.Controls.Add(Me.VarieteCommandeLivraisonChart)
        Me.Commandes.Controls.Add(Me.SplitContainer2)
        Me.Commandes.Controls.Add(Me.DataCommandeLivraison)
        Me.Commandes.Location = New System.Drawing.Point(4, 44)
        Me.Commandes.Margin = New System.Windows.Forms.Padding(4)
        Me.Commandes.Name = "Commandes"
        Me.Commandes.Size = New System.Drawing.Size(1596, 833)
        Me.Commandes.TabIndex = 2
        Me.Commandes.Text = "Commandes"
        Me.Commandes.UseVisualStyleBackColor = True
        '
        'VarieteCommandeLivraisonChart
        '
        Me.VarieteCommandeLivraisonChart.BackSecondaryColor = System.Drawing.Color.White
        Me.VarieteCommandeLivraisonChart.BorderlineColor = System.Drawing.Color.Black
        Me.VarieteCommandeLivraisonChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
        ChartArea11.Name = "ChartArea1"
        Me.VarieteCommandeLivraisonChart.ChartAreas.Add(ChartArea11)
        Me.VarieteCommandeLivraisonChart.Cursor = System.Windows.Forms.Cursors.Hand
        Legend11.Alignment = System.Drawing.StringAlignment.Far
        Legend11.DockedToChartArea = "ChartArea1"
        Legend11.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Legend11.IsDockedInsideChartArea = False
        Legend11.IsTextAutoFit = False
        Legend11.Name = "Legend1"
        Me.VarieteCommandeLivraisonChart.Legends.Add(Legend11)
        Me.VarieteCommandeLivraisonChart.Location = New System.Drawing.Point(0, 1)
        Me.VarieteCommandeLivraisonChart.Margin = New System.Windows.Forms.Padding(4)
        Me.VarieteCommandeLivraisonChart.Name = "VarieteCommandeLivraisonChart"
        Me.VarieteCommandeLivraisonChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen
        Series18.ChartArea = "ChartArea1"
        Series18.Color = System.Drawing.Color.LightSeaGreen
        Series18.EmptyPointStyle.BorderColor = System.Drawing.Color.DarkRed
        Series18.EmptyPointStyle.BorderWidth = 2
        Series18.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series18.Label = "#VAL"
        Series18.LabelForeColor = System.Drawing.Color.DarkGray
        Series18.Legend = "Legend1"
        Series18.Name = "Quantité commandée en KG"
        Series18.ToolTip = "#VAL KG"
        Series19.ChartArea = "ChartArea1"
        Series19.Color = System.Drawing.Color.Aquamarine
        Series19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series19.IsValueShownAsLabel = True
        Series19.Label = "#VAL"
        Series19.LabelForeColor = System.Drawing.Color.DarkGray
        Series19.Legend = "Legend1"
        Series19.Name = "Quantité livrée en KG"
        Series19.ToolTip = "#VAL KG"
        Me.VarieteCommandeLivraisonChart.Series.Add(Series18)
        Me.VarieteCommandeLivraisonChart.Series.Add(Series19)
        Me.VarieteCommandeLivraisonChart.Size = New System.Drawing.Size(823, 516)
        Me.VarieteCommandeLivraisonChart.TabIndex = 4
        Me.VarieteCommandeLivraisonChart.Text = "Chart3"
        Title31.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left
        Title31.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title31.ForeColor = System.Drawing.Color.DimGray
        Title31.Name = "Title1"
        Title31.Text = "Quantité en KG"
        Title32.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title32.ForeColor = System.Drawing.Color.DarkGreen
        Title32.Name = "Title2"
        Title32.Text = "Quantité commandée / Quantité livrée"
        Title33.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom
        Title33.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title33.ForeColor = System.Drawing.Color.DarkGreen
        Title33.Name = "Title3"
        Title33.Text = "Variétés"
        Me.VarieteCommandeLivraisonChart.Titles.Add(Title31)
        Me.VarieteCommandeLivraisonChart.Titles.Add(Title32)
        Me.VarieteCommandeLivraisonChart.Titles.Add(Title33)
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Right
        Me.SplitContainer2.Location = New System.Drawing.Point(1090, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.GroupBox5)
        Me.SplitContainer2.Panel1.Controls.Add(Me.GroupBox6)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.PanelDetailCommande)
        Me.SplitContainer2.Size = New System.Drawing.Size(506, 833)
        Me.SplitContainer2.SplitterDistance = 87
        Me.SplitContainer2.TabIndex = 36
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.VueDetailleeCommande)
        Me.GroupBox5.Controls.Add(Me.VueGlobaleCommande)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox5.Location = New System.Drawing.Point(167, 0)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox5.Size = New System.Drawing.Size(339, 87)
        Me.GroupBox5.TabIndex = 18
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Mode de filtrage"
        '
        'VueDetailleeCommande
        '
        Me.VueDetailleeCommande.AutoSize = True
        Me.VueDetailleeCommande.Location = New System.Drawing.Point(8, 68)
        Me.VueDetailleeCommande.Margin = New System.Windows.Forms.Padding(4)
        Me.VueDetailleeCommande.Name = "VueDetailleeCommande"
        Me.VueDetailleeCommande.Size = New System.Drawing.Size(207, 24)
        Me.VueDetailleeCommande.TabIndex = 17
        Me.VueDetailleeCommande.Text = "Vue détaillée (par variété)"
        Me.VueDetailleeCommande.UseVisualStyleBackColor = True
        '
        'VueGlobaleCommande
        '
        Me.VueGlobaleCommande.AutoSize = True
        Me.VueGlobaleCommande.Checked = True
        Me.VueGlobaleCommande.Location = New System.Drawing.Point(8, 31)
        Me.VueGlobaleCommande.Margin = New System.Windows.Forms.Padding(4)
        Me.VueGlobaleCommande.Name = "VueGlobaleCommande"
        Me.VueGlobaleCommande.Size = New System.Drawing.Size(233, 24)
        Me.VueGlobaleCommande.TabIndex = 16
        Me.VueGlobaleCommande.TabStop = True
        Me.VueGlobaleCommande.Text = "Vue globale (par spéculation)"
        Me.VueGlobaleCommande.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Tableau)
        Me.GroupBox6.Controls.Add(Me.Graphique)
        Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox6.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox6.Size = New System.Drawing.Size(167, 87)
        Me.GroupBox6.TabIndex = 17
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Affichage"
        '
        'Tableau
        '
        Me.Tableau.AutoSize = True
        Me.Tableau.Checked = True
        Me.Tableau.Location = New System.Drawing.Point(8, 31)
        Me.Tableau.Margin = New System.Windows.Forms.Padding(4)
        Me.Tableau.Name = "Tableau"
        Me.Tableau.Size = New System.Drawing.Size(84, 24)
        Me.Tableau.TabIndex = 17
        Me.Tableau.TabStop = True
        Me.Tableau.Text = "Tableau"
        Me.Tableau.UseVisualStyleBackColor = True
        '
        'Graphique
        '
        Me.Graphique.AutoSize = True
        Me.Graphique.Location = New System.Drawing.Point(8, 68)
        Me.Graphique.Margin = New System.Windows.Forms.Padding(4)
        Me.Graphique.Name = "Graphique"
        Me.Graphique.Size = New System.Drawing.Size(102, 24)
        Me.Graphique.TabIndex = 16
        Me.Graphique.Text = "Graphique"
        Me.Graphique.UseVisualStyleBackColor = True
        '
        'PanelDetailCommande
        '
        Me.PanelDetailCommande.AutoScroll = True
        Me.PanelDetailCommande.AutoScrollMargin = New System.Drawing.Size(0, 30)
        Me.PanelDetailCommande.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelDetailCommande.Controls.Add(Me.PanelDateCommande)
        Me.PanelDetailCommande.Controls.Add(Me.PanelClientCommande)
        Me.PanelDetailCommande.Controls.Add(Me.PanelNiveauCommande)
        Me.PanelDetailCommande.Controls.Add(Me.PanelLocaliteCommande)
        Me.PanelDetailCommande.Controls.Add(Me.PanelVarieteCommande)
        Me.PanelDetailCommande.Controls.Add(Me.Panel9)
        Me.PanelDetailCommande.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelDetailCommande.Location = New System.Drawing.Point(0, 0)
        Me.PanelDetailCommande.Name = "PanelDetailCommande"
        Me.PanelDetailCommande.Size = New System.Drawing.Size(506, 742)
        Me.PanelDetailCommande.TabIndex = 34
        Me.PanelDetailCommande.Visible = False
        '
        'PanelDateCommande
        '
        Me.PanelDateCommande.BackColor = System.Drawing.Color.Transparent
        Me.PanelDateCommande.Controls.Add(Me.FiltrerDateCommande)
        Me.PanelDateCommande.Controls.Add(Me.DateDebut)
        Me.PanelDateCommande.Controls.Add(Me.DateFin)
        Me.PanelDateCommande.Cursor = System.Windows.Forms.Cursors.Default
        Me.PanelDateCommande.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelDateCommande.ForeColor = System.Drawing.Color.Black
        Me.PanelDateCommande.Location = New System.Drawing.Point(0, 253)
        Me.PanelDateCommande.MaximumSize = New System.Drawing.Size(500, 210)
        Me.PanelDateCommande.MinimumSize = New System.Drawing.Size(500, 53)
        Me.PanelDateCommande.Name = "PanelDateCommande"
        Me.PanelDateCommande.Size = New System.Drawing.Size(500, 53)
        Me.PanelDateCommande.TabIndex = 33
        '
        'FiltrerDateCommande
        '
        Me.FiltrerDateCommande.AutoSize = True
        Me.FiltrerDateCommande.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FiltrerDateCommande.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FiltrerDateCommande.Location = New System.Drawing.Point(7, 6)
        Me.FiltrerDateCommande.Margin = New System.Windows.Forms.Padding(4)
        Me.FiltrerDateCommande.Name = "FiltrerDateCommande"
        Me.FiltrerDateCommande.Size = New System.Drawing.Size(147, 24)
        Me.FiltrerDateCommande.TabIndex = 15
        Me.FiltrerDateCommande.Text = "Filtrer par date"
        Me.FiltrerDateCommande.UseVisualStyleBackColor = True
        '
        'DateDebut
        '
        Me.DateDebut.CustomFormat = "yyyy-MM-dd"
        Me.DateDebut.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateDebut.Location = New System.Drawing.Point(4, 55)
        Me.DateDebut.Margin = New System.Windows.Forms.Padding(4)
        Me.DateDebut.Name = "DateDebut"
        Me.DateDebut.Size = New System.Drawing.Size(339, 26)
        Me.DateDebut.TabIndex = 22
        '
        'DateFin
        '
        Me.DateFin.CustomFormat = "yyyy-MM-dd"
        Me.DateFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFin.Location = New System.Drawing.Point(4, 95)
        Me.DateFin.Margin = New System.Windows.Forms.Padding(4)
        Me.DateFin.Name = "DateFin"
        Me.DateFin.Size = New System.Drawing.Size(339, 26)
        Me.DateFin.TabIndex = 23
        '
        'PanelClientCommande
        '
        Me.PanelClientCommande.BackColor = System.Drawing.Color.Transparent
        Me.PanelClientCommande.Controls.Add(Me.FiltrerClientCommande)
        Me.PanelClientCommande.Controls.Add(Me.ClientCommandeCheckedList)
        Me.PanelClientCommande.Cursor = System.Windows.Forms.Cursors.Default
        Me.PanelClientCommande.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelClientCommande.ForeColor = System.Drawing.Color.Black
        Me.PanelClientCommande.Location = New System.Drawing.Point(0, 200)
        Me.PanelClientCommande.MaximumSize = New System.Drawing.Size(500, 210)
        Me.PanelClientCommande.MinimumSize = New System.Drawing.Size(500, 53)
        Me.PanelClientCommande.Name = "PanelClientCommande"
        Me.PanelClientCommande.Size = New System.Drawing.Size(500, 53)
        Me.PanelClientCommande.TabIndex = 33
        '
        'FiltrerClientCommande
        '
        Me.FiltrerClientCommande.AutoSize = True
        Me.FiltrerClientCommande.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FiltrerClientCommande.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FiltrerClientCommande.Location = New System.Drawing.Point(7, 6)
        Me.FiltrerClientCommande.Name = "FiltrerClientCommande"
        Me.FiltrerClientCommande.Size = New System.Drawing.Size(83, 24)
        Me.FiltrerClientCommande.TabIndex = 26
        Me.FiltrerClientCommande.Text = "Clients"
        Me.FiltrerClientCommande.UseVisualStyleBackColor = True
        '
        'ClientCommandeCheckedList
        '
        Me.ClientCommandeCheckedList.CheckOnClick = True
        Me.ClientCommandeCheckedList.FormattingEnabled = True
        Me.ClientCommandeCheckedList.Location = New System.Drawing.Point(4, 55)
        Me.ClientCommandeCheckedList.Margin = New System.Windows.Forms.Padding(4)
        Me.ClientCommandeCheckedList.Name = "ClientCommandeCheckedList"
        Me.ClientCommandeCheckedList.Size = New System.Drawing.Size(368, 151)
        Me.ClientCommandeCheckedList.TabIndex = 20
        '
        'PanelNiveauCommande
        '
        Me.PanelNiveauCommande.BackColor = System.Drawing.Color.Transparent
        Me.PanelNiveauCommande.Controls.Add(Me.FiltrerNiveauCommande)
        Me.PanelNiveauCommande.Controls.Add(Me.NiveauCommandeCheckedList)
        Me.PanelNiveauCommande.Cursor = System.Windows.Forms.Cursors.Default
        Me.PanelNiveauCommande.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelNiveauCommande.ForeColor = System.Drawing.Color.Black
        Me.PanelNiveauCommande.Location = New System.Drawing.Point(0, 147)
        Me.PanelNiveauCommande.MaximumSize = New System.Drawing.Size(500, 210)
        Me.PanelNiveauCommande.MinimumSize = New System.Drawing.Size(500, 53)
        Me.PanelNiveauCommande.Name = "PanelNiveauCommande"
        Me.PanelNiveauCommande.Size = New System.Drawing.Size(500, 53)
        Me.PanelNiveauCommande.TabIndex = 32
        '
        'FiltrerNiveauCommande
        '
        Me.FiltrerNiveauCommande.AutoSize = True
        Me.FiltrerNiveauCommande.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FiltrerNiveauCommande.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FiltrerNiveauCommande.Location = New System.Drawing.Point(7, 6)
        Me.FiltrerNiveauCommande.Name = "FiltrerNiveauCommande"
        Me.FiltrerNiveauCommande.Size = New System.Drawing.Size(95, 24)
        Me.FiltrerNiveauCommande.TabIndex = 26
        Me.FiltrerNiveauCommande.Text = "Niveaux "
        Me.FiltrerNiveauCommande.UseVisualStyleBackColor = True
        '
        'NiveauCommandeCheckedList
        '
        Me.NiveauCommandeCheckedList.CheckOnClick = True
        Me.NiveauCommandeCheckedList.FormattingEnabled = True
        Me.NiveauCommandeCheckedList.Location = New System.Drawing.Point(4, 55)
        Me.NiveauCommandeCheckedList.Margin = New System.Windows.Forms.Padding(4)
        Me.NiveauCommandeCheckedList.Name = "NiveauCommandeCheckedList"
        Me.NiveauCommandeCheckedList.Size = New System.Drawing.Size(368, 151)
        Me.NiveauCommandeCheckedList.TabIndex = 20
        '
        'PanelLocaliteCommande
        '
        Me.PanelLocaliteCommande.BackColor = System.Drawing.Color.Transparent
        Me.PanelLocaliteCommande.Controls.Add(Me.FiltrerLocaliteCommande)
        Me.PanelLocaliteCommande.Controls.Add(Me.LocaliteCommandeCheckedList)
        Me.PanelLocaliteCommande.Cursor = System.Windows.Forms.Cursors.Default
        Me.PanelLocaliteCommande.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLocaliteCommande.ForeColor = System.Drawing.Color.Black
        Me.PanelLocaliteCommande.Location = New System.Drawing.Point(0, 94)
        Me.PanelLocaliteCommande.MaximumSize = New System.Drawing.Size(500, 210)
        Me.PanelLocaliteCommande.MinimumSize = New System.Drawing.Size(500, 53)
        Me.PanelLocaliteCommande.Name = "PanelLocaliteCommande"
        Me.PanelLocaliteCommande.Size = New System.Drawing.Size(500, 53)
        Me.PanelLocaliteCommande.TabIndex = 31
        '
        'FiltrerLocaliteCommande
        '
        Me.FiltrerLocaliteCommande.AutoSize = True
        Me.FiltrerLocaliteCommande.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FiltrerLocaliteCommande.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FiltrerLocaliteCommande.Location = New System.Drawing.Point(7, 6)
        Me.FiltrerLocaliteCommande.Name = "FiltrerLocaliteCommande"
        Me.FiltrerLocaliteCommande.Size = New System.Drawing.Size(100, 24)
        Me.FiltrerLocaliteCommande.TabIndex = 25
        Me.FiltrerLocaliteCommande.Text = "Localités"
        Me.FiltrerLocaliteCommande.UseVisualStyleBackColor = True
        '
        'LocaliteCommandeCheckedList
        '
        Me.LocaliteCommandeCheckedList.CheckOnClick = True
        Me.LocaliteCommandeCheckedList.FormattingEnabled = True
        Me.LocaliteCommandeCheckedList.Location = New System.Drawing.Point(4, 55)
        Me.LocaliteCommandeCheckedList.Margin = New System.Windows.Forms.Padding(4)
        Me.LocaliteCommandeCheckedList.Name = "LocaliteCommandeCheckedList"
        Me.LocaliteCommandeCheckedList.Size = New System.Drawing.Size(368, 151)
        Me.LocaliteCommandeCheckedList.TabIndex = 18
        '
        'PanelVarieteCommande
        '
        Me.PanelVarieteCommande.BackColor = System.Drawing.Color.Transparent
        Me.PanelVarieteCommande.Controls.Add(Me.VarieteCommandeCheckedList)
        Me.PanelVarieteCommande.Controls.Add(Me.FiltrerVarieteCommande)
        Me.PanelVarieteCommande.Cursor = System.Windows.Forms.Cursors.Default
        Me.PanelVarieteCommande.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelVarieteCommande.ForeColor = System.Drawing.Color.Black
        Me.PanelVarieteCommande.Location = New System.Drawing.Point(0, 41)
        Me.PanelVarieteCommande.MaximumSize = New System.Drawing.Size(500, 210)
        Me.PanelVarieteCommande.MinimumSize = New System.Drawing.Size(500, 53)
        Me.PanelVarieteCommande.Name = "PanelVarieteCommande"
        Me.PanelVarieteCommande.Size = New System.Drawing.Size(500, 53)
        Me.PanelVarieteCommande.TabIndex = 30
        '
        'VarieteCommandeCheckedList
        '
        Me.VarieteCommandeCheckedList.CheckOnClick = True
        Me.VarieteCommandeCheckedList.FormattingEnabled = True
        Me.VarieteCommandeCheckedList.Location = New System.Drawing.Point(4, 55)
        Me.VarieteCommandeCheckedList.Margin = New System.Windows.Forms.Padding(4)
        Me.VarieteCommandeCheckedList.Name = "VarieteCommandeCheckedList"
        Me.VarieteCommandeCheckedList.Size = New System.Drawing.Size(368, 151)
        Me.VarieteCommandeCheckedList.TabIndex = 13
        '
        'FiltrerVarieteCommande
        '
        Me.FiltrerVarieteCommande.AutoSize = True
        Me.FiltrerVarieteCommande.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FiltrerVarieteCommande.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FiltrerVarieteCommande.Location = New System.Drawing.Point(7, 6)
        Me.FiltrerVarieteCommande.Name = "FiltrerVarieteCommande"
        Me.FiltrerVarieteCommande.Size = New System.Drawing.Size(95, 24)
        Me.FiltrerVarieteCommande.TabIndex = 24
        Me.FiltrerVarieteCommande.Text = "Variétés"
        Me.FiltrerVarieteCommande.UseVisualStyleBackColor = True
        '
        'Panel9
        '
        Me.Panel9.BackColor = System.Drawing.Color.Transparent
        Me.Panel9.Controls.Add(Me.Label3)
        Me.Panel9.Controls.Add(Me.NomSpeculationCommande)
        Me.Panel9.Cursor = System.Windows.Forms.Cursors.Default
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.ForeColor = System.Drawing.Color.Black
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.MaximumSize = New System.Drawing.Size(500, 75)
        Me.Panel9.MinimumSize = New System.Drawing.Size(500, 41)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(500, 41)
        Me.Panel9.TabIndex = 29
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 20)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Spéculation"
        '
        'NomSpeculationCommande
        '
        Me.NomSpeculationCommande.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NomSpeculationCommande.AutoCompleteCustomSource.AddRange(New String() {"IRAT 10", "Dj 8-341", "ITA 150", "WAB 56-50", "Nerica 1", "Nerica 5", "Nerica 6 ", "Dj 684 D", "Dj 11-509", "Dj 12-519", "BW 248-1", "BR 51-46-5", "ITA 123", "Tox 728-1", "BG 90-2 ", "Rok 5", "WAR 1", "WAR 77-3-2-2", "WAR 81-2-1-3-2", "Ikong Pao", "IR 8", "Jaya", "IR 1529-680-3", "IR 442", "KH 998", "Kwang She Shun", "Sahel 108", "Sahel 134", "Sahel 159", "Sahel 177", "Sahel 201", "Sahel 202 ", "Sahel 208", "Sahel 209", "Sahel 210", "Sahel 217", "Sahel 222", "Sahel 305", "Sahel 317", "Sahel 328", "Sahel 329", "Nerica-S-19", "Nerica-S-21", "Nerica-S-36", "Nerica-S-44", "Souna 3", "IBV 8001", "IBV 8004", "IBMV 8402", "ISMI 9507", "Gawane", "Thialack 2", "Xéewel Gi", "Noor 96", "Doo Mer", "Sooror", "Gaaw Na", "Jaboot", "Goor Yomboul", "Yaayi Séex ", "28-206", "756-A", "55-437", "57-313", "57-422", "69-101", "73-27", "73-28", "73-30", "73-33", "GC 8-35", "Fleur 11", "78-937", "55-33", "SRV 1-19", "73-9-11", "GH 119-20", "PC79-79", "H 75-0", "58-57", "Ndiambour", "Mougne", "Bambey 21", "TN 88-63", "CB-5", "Diongoma", "Mélakh", "Mouride", "Yacine", "Pakau ", "58-74 f", "66-35 f", "Noflaye", "Gandiole", "Gao", "Solara", "Sirocco", "Julio", "Damani", "Belami", "Alizé ", "CE 145-66", "CE 151-262", "CE 180-33", "CE 196-7-2-1", "F2-20", "Faourou", "Nguinte", "Nganda", "Darou "})
        Me.NomSpeculationCommande.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.NomSpeculationCommande.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.NomSpeculationCommande.DataSource = Me.SpeculationBindingSource
        Me.NomSpeculationCommande.DisplayMember = "id_speculation"
        Me.NomSpeculationCommande.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomSpeculationCommande.FormattingEnabled = True
        Me.NomSpeculationCommande.Location = New System.Drawing.Point(160, 6)
        Me.NomSpeculationCommande.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NomSpeculationCommande.Name = "NomSpeculationCommande"
        Me.NomSpeculationCommande.Size = New System.Drawing.Size(165, 28)
        Me.NomSpeculationCommande.TabIndex = 10
        Me.NomSpeculationCommande.ValueMember = "id_speculation"
        '
        'DataCommandeLivraison
        '
        DataGridViewCellStyle41.BackColor = System.Drawing.Color.White
        Me.DataCommandeLivraison.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle41
        Me.DataCommandeLivraison.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataCommandeLivraison.BackgroundColor = System.Drawing.Color.White
        Me.DataCommandeLivraison.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataCommandeLivraison.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle42.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle42.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        DataGridViewCellStyle42.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle42.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle42.NullValue = "-"
        DataGridViewCellStyle42.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle42.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        DataGridViewCellStyle42.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataCommandeLivraison.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle42
        Me.DataCommandeLivraison.ColumnHeadersHeight = 40
        DataGridViewCellStyle43.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle43.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle43.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle43.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle43.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle43.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle43.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataCommandeLivraison.DefaultCellStyle = DataGridViewCellStyle43
        Me.DataCommandeLivraison.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DataCommandeLivraison.EnableHeadersVisualStyles = False
        Me.DataCommandeLivraison.Location = New System.Drawing.Point(0, 1)
        Me.DataCommandeLivraison.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataCommandeLivraison.Name = "DataCommandeLivraison"
        Me.DataCommandeLivraison.ReadOnly = True
        Me.DataCommandeLivraison.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle44.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle44.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle44.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle44.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle44.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle44.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle44.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataCommandeLivraison.RowHeadersDefaultCellStyle = DataGridViewCellStyle44
        Me.DataCommandeLivraison.RowTemplate.Height = 24
        Me.DataCommandeLivraison.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataCommandeLivraison.Size = New System.Drawing.Size(823, 516)
        Me.DataCommandeLivraison.TabIndex = 25
        '
        'Production
        '
        Me.Production.Controls.Add(Me.VarieteProductionCommandeChart)
        Me.Production.Controls.Add(Me.DataVarieteProduction)
        Me.Production.Controls.Add(Me.SplitContainer1)
        Me.Production.Location = New System.Drawing.Point(4, 44)
        Me.Production.Margin = New System.Windows.Forms.Padding(4)
        Me.Production.Name = "Production"
        Me.Production.Padding = New System.Windows.Forms.Padding(4)
        Me.Production.Size = New System.Drawing.Size(1596, 833)
        Me.Production.TabIndex = 3
        Me.Production.Text = "Production"
        Me.Production.UseVisualStyleBackColor = True
        '
        'VarieteProductionCommandeChart
        '
        Me.VarieteProductionCommandeChart.BackSecondaryColor = System.Drawing.Color.White
        Me.VarieteProductionCommandeChart.BorderlineColor = System.Drawing.Color.Black
        Me.VarieteProductionCommandeChart.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash
        ChartArea12.Name = "ChartArea1"
        Me.VarieteProductionCommandeChart.ChartAreas.Add(ChartArea12)
        Me.VarieteProductionCommandeChart.Cursor = System.Windows.Forms.Cursors.Hand
        Legend12.Alignment = System.Drawing.StringAlignment.Far
        Legend12.DockedToChartArea = "ChartArea1"
        Legend12.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top
        Legend12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Legend12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Legend12.IsDockedInsideChartArea = False
        Legend12.IsTextAutoFit = False
        Legend12.Name = "Legend1"
        Me.VarieteProductionCommandeChart.Legends.Add(Legend12)
        Me.VarieteProductionCommandeChart.Location = New System.Drawing.Point(0, 1)
        Me.VarieteProductionCommandeChart.Margin = New System.Windows.Forms.Padding(4)
        Me.VarieteProductionCommandeChart.Name = "VarieteProductionCommandeChart"
        Me.VarieteProductionCommandeChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent
        Series20.ChartArea = "ChartArea1"
        Series20.Color = System.Drawing.Color.PeachPuff
        Series20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series20.IsValueShownAsLabel = True
        Series20.Label = "#VAL"
        Series20.LabelForeColor = System.Drawing.Color.DarkGoldenrod
        Series20.Legend = "Legend1"
        Series20.Name = "Quantité produite en KG"
        Series20.ToolTip = "#VAL KG"
        Me.VarieteProductionCommandeChart.Series.Add(Series20)
        Me.VarieteProductionCommandeChart.Size = New System.Drawing.Size(823, 516)
        Me.VarieteProductionCommandeChart.TabIndex = 28
        Me.VarieteProductionCommandeChart.Text = "Chart3"
        Title34.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Left
        Title34.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title34.ForeColor = System.Drawing.Color.DarkGreen
        Title34.Name = "Title1"
        Title34.Text = "Quantité en KG"
        Title35.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title35.ForeColor = System.Drawing.Color.DarkGreen
        Title35.Name = "Title2"
        Title35.Text = "Quantité produite par variété"
        Title36.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom
        Title36.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Title36.ForeColor = System.Drawing.Color.DarkGreen
        Title36.Name = "Title3"
        Title36.Text = "Spéculations"
        Me.VarieteProductionCommandeChart.Titles.Add(Title34)
        Me.VarieteProductionCommandeChart.Titles.Add(Title35)
        Me.VarieteProductionCommandeChart.Titles.Add(Title36)
        '
        'DataVarieteProduction
        '
        DataGridViewCellStyle45.BackColor = System.Drawing.Color.White
        Me.DataVarieteProduction.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle45
        Me.DataVarieteProduction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataVarieteProduction.BackgroundColor = System.Drawing.Color.White
        Me.DataVarieteProduction.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataVarieteProduction.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle46.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle46.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        DataGridViewCellStyle46.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle46.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle46.NullValue = "-"
        DataGridViewCellStyle46.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle46.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        DataGridViewCellStyle46.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataVarieteProduction.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle46
        Me.DataVarieteProduction.ColumnHeadersHeight = 40
        DataGridViewCellStyle47.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle47.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle47.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle47.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle47.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle47.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle47.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataVarieteProduction.DefaultCellStyle = DataGridViewCellStyle47
        Me.DataVarieteProduction.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DataVarieteProduction.EnableHeadersVisualStyles = False
        Me.DataVarieteProduction.Location = New System.Drawing.Point(0, 1)
        Me.DataVarieteProduction.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataVarieteProduction.Name = "DataVarieteProduction"
        Me.DataVarieteProduction.ReadOnly = True
        Me.DataVarieteProduction.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle48.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle48.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle48.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle48.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle48.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle48.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle48.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataVarieteProduction.RowHeadersDefaultCellStyle = DataGridViewCellStyle48
        Me.DataVarieteProduction.RowTemplate.Height = 24
        Me.DataVarieteProduction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataVarieteProduction.Size = New System.Drawing.Size(823, 516)
        Me.DataVarieteProduction.TabIndex = 27
        Me.DataVarieteProduction.Visible = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Right
        Me.SplitContainer1.Location = New System.Drawing.Point(1086, 4)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.GroupBox2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.PanelVueParVariete)
        Me.SplitContainer1.Size = New System.Drawing.Size(506, 825)
        Me.SplitContainer1.SplitterDistance = 90
        Me.SplitContainer1.TabIndex = 35
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.VueParVariete)
        Me.GroupBox4.Controls.Add(Me.VueParSpeculation)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Location = New System.Drawing.Point(167, 0)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox4.Size = New System.Drawing.Size(339, 90)
        Me.GroupBox4.TabIndex = 18
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Mode de filtrage"
        '
        'VueParVariete
        '
        Me.VueParVariete.AutoSize = True
        Me.VueParVariete.Location = New System.Drawing.Point(8, 68)
        Me.VueParVariete.Margin = New System.Windows.Forms.Padding(4)
        Me.VueParVariete.Name = "VueParVariete"
        Me.VueParVariete.Size = New System.Drawing.Size(207, 24)
        Me.VueParVariete.TabIndex = 17
        Me.VueParVariete.Text = "Vue détaillée (par variété)"
        Me.VueParVariete.UseVisualStyleBackColor = True
        '
        'VueParSpeculation
        '
        Me.VueParSpeculation.AutoSize = True
        Me.VueParSpeculation.Checked = True
        Me.VueParSpeculation.Location = New System.Drawing.Point(8, 31)
        Me.VueParSpeculation.Margin = New System.Windows.Forms.Padding(4)
        Me.VueParSpeculation.Name = "VueParSpeculation"
        Me.VueParSpeculation.Size = New System.Drawing.Size(233, 24)
        Me.VueParSpeculation.TabIndex = 16
        Me.VueParSpeculation.TabStop = True
        Me.VueParSpeculation.Text = "Vue globale (par spéculation)"
        Me.VueParSpeculation.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TableauProduction)
        Me.GroupBox2.Controls.Add(Me.GraphiqueProduction)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Left
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(167, 90)
        Me.GroupBox2.TabIndex = 17
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Affichage"
        '
        'TableauProduction
        '
        Me.TableauProduction.AutoSize = True
        Me.TableauProduction.Checked = True
        Me.TableauProduction.Location = New System.Drawing.Point(8, 31)
        Me.TableauProduction.Margin = New System.Windows.Forms.Padding(4)
        Me.TableauProduction.Name = "TableauProduction"
        Me.TableauProduction.Size = New System.Drawing.Size(84, 24)
        Me.TableauProduction.TabIndex = 17
        Me.TableauProduction.TabStop = True
        Me.TableauProduction.Text = "Tableau"
        Me.TableauProduction.UseVisualStyleBackColor = True
        '
        'GraphiqueProduction
        '
        Me.GraphiqueProduction.AutoSize = True
        Me.GraphiqueProduction.Location = New System.Drawing.Point(8, 68)
        Me.GraphiqueProduction.Margin = New System.Windows.Forms.Padding(4)
        Me.GraphiqueProduction.Name = "GraphiqueProduction"
        Me.GraphiqueProduction.Size = New System.Drawing.Size(102, 24)
        Me.GraphiqueProduction.TabIndex = 16
        Me.GraphiqueProduction.Text = "Graphique"
        Me.GraphiqueProduction.UseVisualStyleBackColor = True
        '
        'PanelVueParVariete
        '
        Me.PanelVueParVariete.AutoScroll = True
        Me.PanelVueParVariete.AutoScrollMargin = New System.Drawing.Size(0, 30)
        Me.PanelVueParVariete.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelVueParVariete.Controls.Add(Me.PanelDate)
        Me.PanelVueParVariete.Controls.Add(Me.PanelNiveau)
        Me.PanelVueParVariete.Controls.Add(Me.PanelLocalite)
        Me.PanelVueParVariete.Controls.Add(Me.PanelVariete)
        Me.PanelVueParVariete.Controls.Add(Me.PanelSpeculation)
        Me.PanelVueParVariete.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelVueParVariete.Location = New System.Drawing.Point(0, 0)
        Me.PanelVueParVariete.Name = "PanelVueParVariete"
        Me.PanelVueParVariete.Size = New System.Drawing.Size(506, 731)
        Me.PanelVueParVariete.TabIndex = 34
        Me.PanelVueParVariete.Visible = False
        '
        'PanelDate
        '
        Me.PanelDate.BackColor = System.Drawing.Color.Transparent
        Me.PanelDate.Controls.Add(Me.FiltrerParDateProduction)
        Me.PanelDate.Controls.Add(Me.DateDebutProduction)
        Me.PanelDate.Controls.Add(Me.DateFinProduction)
        Me.PanelDate.Cursor = System.Windows.Forms.Cursors.Default
        Me.PanelDate.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelDate.ForeColor = System.Drawing.Color.Black
        Me.PanelDate.Location = New System.Drawing.Point(0, 200)
        Me.PanelDate.MaximumSize = New System.Drawing.Size(500, 210)
        Me.PanelDate.MinimumSize = New System.Drawing.Size(500, 53)
        Me.PanelDate.Name = "PanelDate"
        Me.PanelDate.Size = New System.Drawing.Size(500, 53)
        Me.PanelDate.TabIndex = 33
        '
        'FiltrerParDateProduction
        '
        Me.FiltrerParDateProduction.AutoSize = True
        Me.FiltrerParDateProduction.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FiltrerParDateProduction.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FiltrerParDateProduction.Location = New System.Drawing.Point(7, 6)
        Me.FiltrerParDateProduction.Margin = New System.Windows.Forms.Padding(4)
        Me.FiltrerParDateProduction.Name = "FiltrerParDateProduction"
        Me.FiltrerParDateProduction.Size = New System.Drawing.Size(147, 24)
        Me.FiltrerParDateProduction.TabIndex = 15
        Me.FiltrerParDateProduction.Text = "Filtrer par date"
        Me.FiltrerParDateProduction.UseVisualStyleBackColor = True
        '
        'DateDebutProduction
        '
        Me.DateDebutProduction.CustomFormat = "yyyy-MM-dd"
        Me.DateDebutProduction.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateDebutProduction.Location = New System.Drawing.Point(4, 55)
        Me.DateDebutProduction.Margin = New System.Windows.Forms.Padding(4)
        Me.DateDebutProduction.Name = "DateDebutProduction"
        Me.DateDebutProduction.Size = New System.Drawing.Size(339, 26)
        Me.DateDebutProduction.TabIndex = 22
        '
        'DateFinProduction
        '
        Me.DateFinProduction.CustomFormat = "yyyy-MM-dd"
        Me.DateFinProduction.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateFinProduction.Location = New System.Drawing.Point(4, 95)
        Me.DateFinProduction.Margin = New System.Windows.Forms.Padding(4)
        Me.DateFinProduction.Name = "DateFinProduction"
        Me.DateFinProduction.Size = New System.Drawing.Size(339, 26)
        Me.DateFinProduction.TabIndex = 23
        '
        'PanelNiveau
        '
        Me.PanelNiveau.BackColor = System.Drawing.Color.Transparent
        Me.PanelNiveau.Controls.Add(Me.FiltrerNiveau)
        Me.PanelNiveau.Controls.Add(Me.NiveauCheckedList)
        Me.PanelNiveau.Cursor = System.Windows.Forms.Cursors.Default
        Me.PanelNiveau.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelNiveau.ForeColor = System.Drawing.Color.Black
        Me.PanelNiveau.Location = New System.Drawing.Point(0, 147)
        Me.PanelNiveau.MaximumSize = New System.Drawing.Size(500, 210)
        Me.PanelNiveau.MinimumSize = New System.Drawing.Size(500, 53)
        Me.PanelNiveau.Name = "PanelNiveau"
        Me.PanelNiveau.Size = New System.Drawing.Size(500, 53)
        Me.PanelNiveau.TabIndex = 32
        '
        'FiltrerNiveau
        '
        Me.FiltrerNiveau.AutoSize = True
        Me.FiltrerNiveau.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FiltrerNiveau.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FiltrerNiveau.Location = New System.Drawing.Point(7, 6)
        Me.FiltrerNiveau.Name = "FiltrerNiveau"
        Me.FiltrerNiveau.Size = New System.Drawing.Size(95, 24)
        Me.FiltrerNiveau.TabIndex = 26
        Me.FiltrerNiveau.Text = "Niveaux "
        Me.FiltrerNiveau.UseVisualStyleBackColor = True
        '
        'NiveauCheckedList
        '
        Me.NiveauCheckedList.CheckOnClick = True
        Me.NiveauCheckedList.FormattingEnabled = True
        Me.NiveauCheckedList.Location = New System.Drawing.Point(4, 55)
        Me.NiveauCheckedList.Margin = New System.Windows.Forms.Padding(4)
        Me.NiveauCheckedList.Name = "NiveauCheckedList"
        Me.NiveauCheckedList.Size = New System.Drawing.Size(368, 151)
        Me.NiveauCheckedList.TabIndex = 20
        '
        'PanelLocalite
        '
        Me.PanelLocalite.BackColor = System.Drawing.Color.Transparent
        Me.PanelLocalite.Controls.Add(Me.FiltrerLocalite)
        Me.PanelLocalite.Controls.Add(Me.LocaliteCheckedList)
        Me.PanelLocalite.Cursor = System.Windows.Forms.Cursors.Default
        Me.PanelLocalite.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelLocalite.ForeColor = System.Drawing.Color.Black
        Me.PanelLocalite.Location = New System.Drawing.Point(0, 94)
        Me.PanelLocalite.MaximumSize = New System.Drawing.Size(500, 210)
        Me.PanelLocalite.MinimumSize = New System.Drawing.Size(500, 53)
        Me.PanelLocalite.Name = "PanelLocalite"
        Me.PanelLocalite.Size = New System.Drawing.Size(500, 53)
        Me.PanelLocalite.TabIndex = 31
        '
        'FiltrerLocalite
        '
        Me.FiltrerLocalite.AutoSize = True
        Me.FiltrerLocalite.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FiltrerLocalite.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FiltrerLocalite.Location = New System.Drawing.Point(7, 6)
        Me.FiltrerLocalite.Name = "FiltrerLocalite"
        Me.FiltrerLocalite.Size = New System.Drawing.Size(100, 24)
        Me.FiltrerLocalite.TabIndex = 25
        Me.FiltrerLocalite.Text = "Localités"
        Me.FiltrerLocalite.UseVisualStyleBackColor = True
        '
        'LocaliteCheckedList
        '
        Me.LocaliteCheckedList.CheckOnClick = True
        Me.LocaliteCheckedList.FormattingEnabled = True
        Me.LocaliteCheckedList.Location = New System.Drawing.Point(4, 55)
        Me.LocaliteCheckedList.Margin = New System.Windows.Forms.Padding(4)
        Me.LocaliteCheckedList.Name = "LocaliteCheckedList"
        Me.LocaliteCheckedList.Size = New System.Drawing.Size(368, 151)
        Me.LocaliteCheckedList.TabIndex = 18
        '
        'PanelVariete
        '
        Me.PanelVariete.BackColor = System.Drawing.Color.Transparent
        Me.PanelVariete.Controls.Add(Me.VarieteProductionCheckedList)
        Me.PanelVariete.Controls.Add(Me.FiltrerVariete)
        Me.PanelVariete.Cursor = System.Windows.Forms.Cursors.Default
        Me.PanelVariete.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelVariete.ForeColor = System.Drawing.Color.Black
        Me.PanelVariete.Location = New System.Drawing.Point(0, 41)
        Me.PanelVariete.MaximumSize = New System.Drawing.Size(500, 210)
        Me.PanelVariete.MinimumSize = New System.Drawing.Size(500, 53)
        Me.PanelVariete.Name = "PanelVariete"
        Me.PanelVariete.Size = New System.Drawing.Size(500, 53)
        Me.PanelVariete.TabIndex = 30
        '
        'VarieteProductionCheckedList
        '
        Me.VarieteProductionCheckedList.CheckOnClick = True
        Me.VarieteProductionCheckedList.FormattingEnabled = True
        Me.VarieteProductionCheckedList.Location = New System.Drawing.Point(4, 55)
        Me.VarieteProductionCheckedList.Margin = New System.Windows.Forms.Padding(4)
        Me.VarieteProductionCheckedList.Name = "VarieteProductionCheckedList"
        Me.VarieteProductionCheckedList.Size = New System.Drawing.Size(368, 151)
        Me.VarieteProductionCheckedList.TabIndex = 13
        '
        'FiltrerVariete
        '
        Me.FiltrerVariete.AutoSize = True
        Me.FiltrerVariete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FiltrerVariete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FiltrerVariete.Location = New System.Drawing.Point(7, 6)
        Me.FiltrerVariete.Name = "FiltrerVariete"
        Me.FiltrerVariete.Size = New System.Drawing.Size(95, 24)
        Me.FiltrerVariete.TabIndex = 24
        Me.FiltrerVariete.Text = "Variétés"
        Me.FiltrerVariete.UseVisualStyleBackColor = True
        '
        'PanelSpeculation
        '
        Me.PanelSpeculation.BackColor = System.Drawing.Color.Transparent
        Me.PanelSpeculation.Controls.Add(Me.Label2)
        Me.PanelSpeculation.Controls.Add(Me.NomSpeculationProduction)
        Me.PanelSpeculation.Cursor = System.Windows.Forms.Cursors.Default
        Me.PanelSpeculation.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelSpeculation.ForeColor = System.Drawing.Color.Black
        Me.PanelSpeculation.Location = New System.Drawing.Point(0, 0)
        Me.PanelSpeculation.MaximumSize = New System.Drawing.Size(500, 75)
        Me.PanelSpeculation.MinimumSize = New System.Drawing.Size(500, 41)
        Me.PanelSpeculation.Name = "PanelSpeculation"
        Me.PanelSpeculation.Size = New System.Drawing.Size(500, 41)
        Me.PanelSpeculation.TabIndex = 29
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 20)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Spéculation"
        '
        'NomSpeculationProduction
        '
        Me.NomSpeculationProduction.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.NomSpeculationProduction.AutoCompleteCustomSource.AddRange(New String() {"IRAT 10", "Dj 8-341", "ITA 150", "WAB 56-50", "Nerica 1", "Nerica 5", "Nerica 6 ", "Dj 684 D", "Dj 11-509", "Dj 12-519", "BW 248-1", "BR 51-46-5", "ITA 123", "Tox 728-1", "BG 90-2 ", "Rok 5", "WAR 1", "WAR 77-3-2-2", "WAR 81-2-1-3-2", "Ikong Pao", "IR 8", "Jaya", "IR 1529-680-3", "IR 442", "KH 998", "Kwang She Shun", "Sahel 108", "Sahel 134", "Sahel 159", "Sahel 177", "Sahel 201", "Sahel 202 ", "Sahel 208", "Sahel 209", "Sahel 210", "Sahel 217", "Sahel 222", "Sahel 305", "Sahel 317", "Sahel 328", "Sahel 329", "Nerica-S-19", "Nerica-S-21", "Nerica-S-36", "Nerica-S-44", "Souna 3", "IBV 8001", "IBV 8004", "IBMV 8402", "ISMI 9507", "Gawane", "Thialack 2", "Xéewel Gi", "Noor 96", "Doo Mer", "Sooror", "Gaaw Na", "Jaboot", "Goor Yomboul", "Yaayi Séex ", "28-206", "756-A", "55-437", "57-313", "57-422", "69-101", "73-27", "73-28", "73-30", "73-33", "GC 8-35", "Fleur 11", "78-937", "55-33", "SRV 1-19", "73-9-11", "GH 119-20", "PC79-79", "H 75-0", "58-57", "Ndiambour", "Mougne", "Bambey 21", "TN 88-63", "CB-5", "Diongoma", "Mélakh", "Mouride", "Yacine", "Pakau ", "58-74 f", "66-35 f", "Noflaye", "Gandiole", "Gao", "Solara", "Sirocco", "Julio", "Damani", "Belami", "Alizé ", "CE 145-66", "CE 151-262", "CE 180-33", "CE 196-7-2-1", "F2-20", "Faourou", "Nguinte", "Nganda", "Darou "})
        Me.NomSpeculationProduction.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.NomSpeculationProduction.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.NomSpeculationProduction.DataSource = Me.SpeculationBindingSource
        Me.NomSpeculationProduction.DisplayMember = "id_speculation"
        Me.NomSpeculationProduction.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomSpeculationProduction.FormattingEnabled = True
        Me.NomSpeculationProduction.Location = New System.Drawing.Point(160, 6)
        Me.NomSpeculationProduction.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NomSpeculationProduction.Name = "NomSpeculationProduction"
        Me.NomSpeculationProduction.Size = New System.Drawing.Size(165, 28)
        Me.NomSpeculationProduction.TabIndex = 10
        Me.NomSpeculationProduction.ValueMember = "id_speculation"
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
        Me.TabRapports.Margin = New System.Windows.Forms.Padding(4)
        Me.TabRapports.Name = "TabRapports"
        Me.TabRapports.SelectedIndex = 0
        Me.TabRapports.Size = New System.Drawing.Size(1604, 881)
        Me.TabRapports.TabIndex = 0
        '
        'Timer1
        '
        Me.Timer1.Interval = 22
        '
        'Timer2
        '
        Me.Timer2.Interval = 16
        '
        'Timer3
        '
        Me.Timer3.Interval = 16
        '
        'Timer4
        '
        Me.Timer4.Interval = 16
        '
        'Timer5
        '
        Me.Timer5.Interval = 16
        '
        'Timer6
        '
        Me.Timer6.Interval = 22
        '
        'Timer7
        '
        Me.Timer7.Interval = 16
        '
        'Timer8
        '
        Me.Timer8.Interval = 16
        '
        'Timer9
        '
        Me.Timer9.Interval = 16
        '
        'Timer10
        '
        Me.Timer10.Interval = 16
        '
        'Timer11
        '
        Me.Timer11.Interval = 22
        '
        'Timer12
        '
        Me.Timer12.Interval = 16
        '
        'Timer13
        '
        Me.Timer13.Interval = 16
        '
        'Timer14
        '
        Me.Timer14.Interval = 16
        '
        'Timer15
        '
        Me.Timer15.Interval = 16
        '
        'FormRapports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1604, 881)
        Me.Controls.Add(Me.TabRapports)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FormRapports"
        Me.Text = "FormRapports"
        CType(Me.SpeculationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CommandeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.General.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.PanelDetailGen.ResumeLayout(False)
        Me.PanelDateGen.ResumeLayout(False)
        Me.PanelDateGen.PerformLayout()
        Me.PanelClientGen.ResumeLayout(False)
        Me.PanelClientGen.PerformLayout()
        Me.PanelNiveauGen.ResumeLayout(False)
        Me.PanelNiveauGen.PerformLayout()
        Me.PanelLocaliteGen.ResumeLayout(False)
        Me.PanelLocaliteGen.PerformLayout()
        Me.PanelVarieteGen.ResumeLayout(False)
        Me.PanelVarieteGen.PerformLayout()
        Me.Panel.ResumeLayout(False)
        Me.Panel.PerformLayout()
        CType(Me.CommandeProductionChart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataCommandeProduction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Commandes.ResumeLayout(False)
        CType(Me.VarieteCommandeLivraisonChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.PanelDetailCommande.ResumeLayout(False)
        Me.PanelDateCommande.ResumeLayout(False)
        Me.PanelDateCommande.PerformLayout()
        Me.PanelClientCommande.ResumeLayout(False)
        Me.PanelClientCommande.PerformLayout()
        Me.PanelNiveauCommande.ResumeLayout(False)
        Me.PanelNiveauCommande.PerformLayout()
        Me.PanelLocaliteCommande.ResumeLayout(False)
        Me.PanelLocaliteCommande.PerformLayout()
        Me.PanelVarieteCommande.ResumeLayout(False)
        Me.PanelVarieteCommande.PerformLayout()
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        CType(Me.DataCommandeLivraison, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Production.ResumeLayout(False)
        CType(Me.VarieteProductionCommandeChart, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataVarieteProduction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.PanelVueParVariete.ResumeLayout(False)
        Me.PanelDate.ResumeLayout(False)
        Me.PanelDate.PerformLayout()
        Me.PanelNiveau.ResumeLayout(False)
        Me.PanelNiveau.PerformLayout()
        Me.PanelLocalite.ResumeLayout(False)
        Me.PanelLocalite.PerformLayout()
        Me.PanelVariete.ResumeLayout(False)
        Me.PanelVariete.PerformLayout()
        Me.PanelSpeculation.ResumeLayout(False)
        Me.PanelSpeculation.PerformLayout()
        Me.TabRapports.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SemencesDataSet As semencesDataSet
    Friend WithEvents CommandeBindingSource As BindingSource
    Friend WithEvents CommandeTableAdapter As semencesDataSetTableAdapters.commandeTableAdapter
    Friend WithEvents SpeculationBindingSource As BindingSource
    Friend WithEvents General As TabPage
    Friend WithEvents DateFinGen As DateTimePicker
    Friend WithEvents DateDebutGen As DateTimePicker
    Friend WithEvents NomSpeculationGen As ComboBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TableauGen As RadioButton
    Friend WithEvents GraphiqueGen As RadioButton
    Friend WithEvents GenVarieteCheckedList As CheckedListBox
    Friend WithEvents GenLocaliteCheckedList As CheckedListBox
    Friend WithEvents GenClientCheckedList As CheckedListBox
    Friend WithEvents GenNiveauCheckedList As CheckedListBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents CommandeProductionChart As DataVisualization.Charting.Chart
    Friend WithEvents DataCommandeProduction As DataGridView
    Friend WithEvents Commandes As TabPage
    Friend WithEvents VarieteCommandeLivraisonChart As DataVisualization.Charting.Chart
    Friend WithEvents DataCommandeLivraison As DataGridView
    Friend WithEvents Production As TabPage
    Friend WithEvents VarieteProductionCommandeChart As DataVisualization.Charting.Chart
    Friend WithEvents DateFinProduction As DateTimePicker
    Friend WithEvents DateDebutProduction As DateTimePicker
    Friend WithEvents NiveauCheckedList As CheckedListBox
    Friend WithEvents LocaliteCheckedList As CheckedListBox
    Friend WithEvents FiltrerParDateProduction As CheckBox
    Friend WithEvents VarieteProductionCheckedList As CheckedListBox
    Friend WithEvents NomSpeculationProduction As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TableauProduction As RadioButton
    Friend WithEvents GraphiqueProduction As RadioButton
    Friend WithEvents DataVarieteProduction As DataGridView
    Friend WithEvents TabRapports As TabControl
    Friend WithEvents Timer1 As Timer
    Friend WithEvents FiltrerVariete As CheckBox
    Friend WithEvents FiltrerNiveau As CheckBox
    Friend WithEvents FiltrerLocalite As CheckBox
    Friend WithEvents PanelSpeculation As Panel
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Timer3 As Timer
    Friend WithEvents Timer4 As Timer
    Friend WithEvents Timer5 As Timer
    Friend WithEvents PanelDate As Panel
    Friend WithEvents PanelNiveau As Panel
    Friend WithEvents PanelLocalite As Panel
    Friend WithEvents PanelVariete As Panel
    Friend WithEvents PanelVueParVariete As Panel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents VueParVariete As RadioButton
    Friend WithEvents VueParSpeculation As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents VueDetailleeCommande As RadioButton
    Friend WithEvents VueGlobaleCommande As RadioButton
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Tableau As RadioButton
    Friend WithEvents Graphique As RadioButton
    Friend WithEvents PanelDetailCommande As Panel
    Friend WithEvents PanelDateCommande As Panel
    Friend WithEvents FiltrerDateCommande As CheckBox
    Friend WithEvents DateDebut As DateTimePicker
    Friend WithEvents DateFin As DateTimePicker
    Friend WithEvents PanelNiveauCommande As Panel
    Friend WithEvents FiltrerNiveauCommande As CheckBox
    Friend WithEvents NiveauCommandeCheckedList As CheckedListBox
    Friend WithEvents PanelLocaliteCommande As Panel
    Friend WithEvents FiltrerLocaliteCommande As CheckBox
    Friend WithEvents LocaliteCommandeCheckedList As CheckedListBox
    Friend WithEvents PanelVarieteCommande As Panel
    Friend WithEvents VarieteCommandeCheckedList As CheckedListBox
    Friend WithEvents FiltrerVarieteCommande As CheckBox
    Friend WithEvents Panel9 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents NomSpeculationCommande As ComboBox
    Friend WithEvents PanelClientCommande As Panel
    Friend WithEvents FiltrerClientCommande As CheckBox
    Friend WithEvents ClientCommandeCheckedList As CheckedListBox
    Friend WithEvents Timer6 As Timer
    Friend WithEvents Timer7 As Timer
    Friend WithEvents Timer8 As Timer
    Friend WithEvents Timer9 As Timer
    Friend WithEvents Timer10 As Timer
    Friend WithEvents SplitContainer3 As SplitContainer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents VueDetailleeGen As RadioButton
    Friend WithEvents VueGlobaleGen As RadioButton
    Friend WithEvents PanelDetailGen As Panel
    Friend WithEvents PanelDateGen As Panel
    Friend WithEvents FiltrerDateGen As CheckBox
    Friend WithEvents PanelClientGen As Panel
    Friend WithEvents FiltrerClientGen As CheckBox
    Friend WithEvents PanelNiveauGen As Panel
    Friend WithEvents FiltrerNiveauGen As CheckBox
    Friend WithEvents PanelLocaliteGen As Panel
    Friend WithEvents FiltrerLocaliteGen As CheckBox
    Friend WithEvents PanelVarieteGen As Panel
    Friend WithEvents FiltrerVarieteGen As CheckBox
    Friend WithEvents Panel As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Timer11 As Timer
    Friend WithEvents Timer12 As Timer
    Friend WithEvents Timer13 As Timer
    Friend WithEvents Timer14 As Timer
    Friend WithEvents Timer15 As Timer
End Class

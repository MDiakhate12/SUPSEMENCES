﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormSpeculations
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSpeculations))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.ProductionMainTabControl = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ChoixRecherche = New System.Windows.Forms.ComboBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.ClearRechercher = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Recherche = New System.Windows.Forms.TextBox()
        Me.DataProduction = New System.Windows.Forms.DataGridView()
        Me.DataVarieteInstitution = New System.Windows.Forms.DataGridView()
        Me.AjouterProduction = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ZoneProduction = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.ChoixVariete = New System.Windows.Forms.ComboBox()
        Me.VarieteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DateProductionLabel = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.QuantiteProduiteLabel = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.NiveauDeProduction = New System.Windows.Forms.ComboBox()
        Me.NiveauinstitutionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Magasin = New System.Windows.Forms.ComboBox()
        Me.MagasinBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Localisation = New System.Windows.Forms.ComboBox()
        Me.LocalisationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SemencesDataSet1 = New SUPSEMENCE.semencesDataSet()
        Me.DateProduction = New System.Windows.Forms.DateTimePicker()
        Me.PrixUnitaire = New System.Windows.Forms.NumericUpDown()
        Me.QuantiteProduite = New System.Windows.Forms.NumericUpDown()
        Me.EtatStocksSpeculation = New System.Windows.Forms.TabPage()
        Me.EtatStockVariete = New System.Windows.Forms.TabPage()
        Me.DataStockVarieteTab = New System.Windows.Forms.DataGridView()
        Me.DataStockVariete = New System.Windows.Forms.DataGridView()
        Me.SemencesDataSet = New SUPSEMENCE.semencesDataSet()
        Me.VarieteinstitutionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContextMenuProduction = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuItemModifier = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SupprimerMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ModifierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupprimerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Niveau_institutionTableAdapter = New SUPSEMENCE.semencesDataSetTableAdapters.niveau_institutionTableAdapter()
        Me.ProductionMainTabControl.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.ClearRechercher, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataProduction, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataVarieteInstitution, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AjouterProduction.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.VarieteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NiveauinstitutionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MagasinBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocalisationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SemencesDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrixUnitaire, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuantiteProduite, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EtatStockVariete.SuspendLayout()
        CType(Me.DataStockVarieteTab, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataStockVariete, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SemencesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VarieteinstitutionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuProduction.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(0, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 748)
        Me.Splitter1.TabIndex = 0
        Me.Splitter1.TabStop = False
        '
        'ProductionMainTabControl
        '
        Me.ProductionMainTabControl.Controls.Add(Me.TabPage1)
        Me.ProductionMainTabControl.Controls.Add(Me.AjouterProduction)
        Me.ProductionMainTabControl.Controls.Add(Me.EtatStocksSpeculation)
        Me.ProductionMainTabControl.Controls.Add(Me.EtatStockVariete)
        Me.ProductionMainTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProductionMainTabControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductionMainTabControl.ItemSize = New System.Drawing.Size(85, 40)
        Me.ProductionMainTabControl.Location = New System.Drawing.Point(3, 0)
        Me.ProductionMainTabControl.Name = "ProductionMainTabControl"
        Me.ProductionMainTabControl.SelectedIndex = 0
        Me.ProductionMainTabControl.Size = New System.Drawing.Size(1209, 748)
        Me.ProductionMainTabControl.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel4)
        Me.TabPage1.Controls.Add(Me.DataProduction)
        Me.TabPage1.Controls.Add(Me.DataVarieteInstitution)
        Me.TabPage1.Location = New System.Drawing.Point(4, 44)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1201, 700)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Productions"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1195, 140)
        Me.Panel4.TabIndex = 25
        '
        'Panel5
        '
        Me.Panel5.AutoScroll = True
        Me.Panel5.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel5.Controls.Add(Me.Label1)
        Me.Panel5.Controls.Add(Me.ChoixRecherche)
        Me.Panel5.Controls.Add(Me.Panel6)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.ForeColor = System.Drawing.Color.White
        Me.Panel5.Location = New System.Drawing.Point(921, 0)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(274, 140)
        Me.Panel5.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Gainsboro
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(14, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(138, 20)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Rechercher par:"
        '
        'ChoixRecherche
        '
        Me.ChoixRecherche.AutoCompleteCustomSource.AddRange(New String() {"IRAT 10", "Dj 8-341", "ITA 150", "WAB 56-50", "Nerica 1", "Nerica 5", "Nerica 6 ", "Dj 684 D", "Dj 11-509", "Dj 12-519", "BW 248-1", "BR 51-46-5", "ITA 123", "Tox 728-1", "BG 90-2 ", "Rok 5", "WAR 1", "WAR 77-3-2-2", "WAR 81-2-1-3-2", "Ikong Pao", "IR 8", "Jaya", "IR 1529-680-3", "IR 442", "KH 998", "Kwang She Shun", "Sahel 108", "Sahel 134", "Sahel 159", "Sahel 177", "Sahel 201", "Sahel 202 ", "Sahel 208", "Sahel 209", "Sahel 210", "Sahel 217", "Sahel 222", "Sahel 305", "Sahel 317", "Sahel 328", "Sahel 329", "Nerica-S-19", "Nerica-S-21", "Nerica-S-36", "Nerica-S-44", "Souna 3", "IBV 8001", "IBV 8004", "IBMV 8402", "ISMI 9507", "Gawane", "Thialack 2", "Xéewel Gi", "Noor 96", "Doo Mer", "Sooror", "Gaaw Na", "Jaboot", "Goor Yomboul", "Yaayi Séex ", "28-206", "756-A", "55-437", "57-313", "57-422", "69-101", "73-27", "73-28", "73-30", "73-33", "GC 8-35", "Fleur 11", "78-937", "55-33", "SRV 1-19", "73-9-11", "GH 119-20", "PC79-79", "H 75-0", "58-57", "Ndiambour", "Mougne", "Bambey 21", "TN 88-63", "CB-5", "Diongoma", "Mélakh", "Mouride", "Yacine", "Pakau ", "58-74 f", "66-35 f", "Noflaye", "Gandiole", "Gao", "Solara", "Sirocco", "Julio", "Damani", "Belami", "Alizé ", "CE 145-66", "CE 151-262", "CE 180-33", "CE 196-7-2-1", "F2-20", "Faourou", "Nguinte", "Nganda", "Darou "})
        Me.ChoixRecherche.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ChoixRecherche.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ChoixRecherche.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChoixRecherche.FormattingEnabled = True
        Me.ChoixRecherche.Items.AddRange(New Object() {"Variété", "Spéculation", "Niveau de production", "Magasin", "Quantite produite", "Prix unitaire"})
        Me.ChoixRecherche.Location = New System.Drawing.Point(14, 39)
        Me.ChoixRecherche.Margin = New System.Windows.Forms.Padding(2)
        Me.ChoixRecherche.Name = "ChoixRecherche"
        Me.ChoixRecherche.Size = New System.Drawing.Size(243, 28)
        Me.ChoixRecherche.TabIndex = 27
        Me.ChoixRecherche.Text = "Variété"
        '
        'Panel6
        '
        Me.Panel6.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.ClearRechercher)
        Me.Panel6.Controls.Add(Me.PictureBox3)
        Me.Panel6.Controls.Add(Me.Recherche)
        Me.Panel6.Location = New System.Drawing.Point(14, 86)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(246, 35)
        Me.Panel6.TabIndex = 22
        '
        'ClearRechercher
        '
        Me.ClearRechercher.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ClearRechercher.Dock = System.Windows.Forms.DockStyle.Right
        Me.ClearRechercher.Image = CType(resources.GetObject("ClearRechercher.Image"), System.Drawing.Image)
        Me.ClearRechercher.Location = New System.Drawing.Point(207, 0)
        Me.ClearRechercher.Margin = New System.Windows.Forms.Padding(2)
        Me.ClearRechercher.Name = "ClearRechercher"
        Me.ClearRechercher.Size = New System.Drawing.Size(37, 33)
        Me.ClearRechercher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.ClearRechercher.TabIndex = 4
        Me.ClearRechercher.TabStop = False
        Me.ClearRechercher.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Dock = System.Windows.Forms.DockStyle.Left
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(37, 33)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'Recherche
        '
        Me.Recherche.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Recherche.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Recherche.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Recherche.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Recherche.ForeColor = System.Drawing.Color.White
        Me.Recherche.Location = New System.Drawing.Point(48, 2)
        Me.Recherche.Margin = New System.Windows.Forms.Padding(2)
        Me.Recherche.Name = "Recherche"
        Me.Recherche.Size = New System.Drawing.Size(184, 22)
        Me.Recherche.TabIndex = 0
        Me.Recherche.Text = "Rechercher"
        '
        'DataProduction
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DataProduction.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataProduction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataProduction.BackgroundColor = System.Drawing.Color.White
        Me.DataProduction.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataProduction.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.NullValue = "-"
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataProduction.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataProduction.ColumnHeadersHeight = 40
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataProduction.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataProduction.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataProduction.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DataProduction.EnableHeadersVisualStyles = False
        Me.DataProduction.Location = New System.Drawing.Point(3, 143)
        Me.DataProduction.Margin = New System.Windows.Forms.Padding(2)
        Me.DataProduction.Name = "DataProduction"
        Me.DataProduction.ReadOnly = True
        Me.DataProduction.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataProduction.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataProduction.RowTemplate.Height = 24
        Me.DataProduction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataProduction.Size = New System.Drawing.Size(1195, 554)
        Me.DataProduction.TabIndex = 24
        '
        'DataVarieteInstitution
        '
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.White
        Me.DataVarieteInstitution.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        Me.DataVarieteInstitution.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataVarieteInstitution.BackgroundColor = System.Drawing.Color.White
        Me.DataVarieteInstitution.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataVarieteInstitution.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle6.NullValue = "-"
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataVarieteInstitution.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.DataVarieteInstitution.ColumnHeadersHeight = 40
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataVarieteInstitution.DefaultCellStyle = DataGridViewCellStyle7
        Me.DataVarieteInstitution.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataVarieteInstitution.EnableHeadersVisualStyles = False
        Me.DataVarieteInstitution.Location = New System.Drawing.Point(3, 3)
        Me.DataVarieteInstitution.Margin = New System.Windows.Forms.Padding(2)
        Me.DataVarieteInstitution.Name = "DataVarieteInstitution"
        Me.DataVarieteInstitution.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataVarieteInstitution.RowHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.DataVarieteInstitution.RowTemplate.Height = 24
        Me.DataVarieteInstitution.Size = New System.Drawing.Size(1195, 694)
        Me.DataVarieteInstitution.TabIndex = 23
        '
        'AjouterProduction
        '
        Me.AjouterProduction.Controls.Add(Me.Panel1)
        Me.AjouterProduction.Location = New System.Drawing.Point(4, 44)
        Me.AjouterProduction.Name = "AjouterProduction"
        Me.AjouterProduction.Padding = New System.Windows.Forms.Padding(3)
        Me.AjouterProduction.Size = New System.Drawing.Size(1201, 700)
        Me.AjouterProduction.TabIndex = 1
        Me.AjouterProduction.Text = "Ajouter Nouvelle Production"
        Me.AjouterProduction.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ZoneProduction)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.ChoixVariete)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.DateProductionLabel)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.QuantiteProduiteLabel)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.NiveauDeProduction)
        Me.Panel1.Controls.Add(Me.Magasin)
        Me.Panel1.Controls.Add(Me.Localisation)
        Me.Panel1.Controls.Add(Me.DateProduction)
        Me.Panel1.Controls.Add(Me.PrixUnitaire)
        Me.Panel1.Controls.Add(Me.QuantiteProduite)
        Me.Panel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(230, 74)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(737, 549)
        Me.Panel1.TabIndex = 0
        '
        'ZoneProduction
        '
        Me.ZoneProduction.AutoSize = True
        Me.ZoneProduction.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZoneProduction.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.ZoneProduction.Location = New System.Drawing.Point(233, 279)
        Me.ZoneProduction.Name = "ZoneProduction"
        Me.ZoneProduction.Size = New System.Drawing.Size(0, 13)
        Me.ZoneProduction.TabIndex = 22
        Me.ZoneProduction.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(26, 44)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 20)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Variété"
        '
        'ChoixVariete
        '
        Me.ChoixVariete.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ChoixVariete.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ChoixVariete.DataSource = Me.VarieteBindingSource
        Me.ChoixVariete.FormattingEnabled = True
        Me.ChoixVariete.Location = New System.Drawing.Point(236, 27)
        Me.ChoixVariete.Name = "ChoixVariete"
        Me.ChoixVariete.Size = New System.Drawing.Size(242, 28)
        Me.ChoixVariete.TabIndex = 19
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(26, 384)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(183, 20)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Niveau des semences"
        '
        'DateProductionLabel
        '
        Me.DateProductionLabel.AutoSize = True
        Me.DateProductionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateProductionLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.DateProductionLabel.Location = New System.Drawing.Point(26, 202)
        Me.DateProductionLabel.Name = "DateProductionLabel"
        Me.DateProductionLabel.Size = New System.Drawing.Size(163, 20)
        Me.DateProductionLabel.TabIndex = 16
        Me.DateProductionLabel.Text = "Date de production"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(26, 256)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(157, 20)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Localité de culture"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(26, 324)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(179, 20)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Magasin de stockage"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(26, 154)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Prix (FCFA/KG)"
        '
        'QuantiteProduiteLabel
        '
        Me.QuantiteProduiteLabel.AutoSize = True
        Me.QuantiteProduiteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantiteProduiteLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.QuantiteProduiteLabel.Location = New System.Drawing.Point(26, 102)
        Me.QuantiteProduiteLabel.Name = "QuantiteProduiteLabel"
        Me.QuantiteProduiteLabel.Size = New System.Drawing.Size(191, 20)
        Me.QuantiteProduiteLabel.TabIndex = 12
        Me.QuantiteProduiteLabel.Text = "Quantité produite (KG)"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(30, 452)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(448, 58)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Enregistrer"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(501, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(234, 547)
        Me.Panel2.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(58, 202)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(134, 120)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'NiveauDeProduction
        '
        Me.NiveauDeProduction.DataSource = Me.NiveauinstitutionBindingSource
        Me.NiveauDeProduction.DisplayMember = "id_niveau"
        Me.NiveauDeProduction.FormattingEnabled = True
        Me.NiveauDeProduction.Location = New System.Drawing.Point(236, 376)
        Me.NiveauDeProduction.Name = "NiveauDeProduction"
        Me.NiveauDeProduction.Size = New System.Drawing.Size(242, 28)
        Me.NiveauDeProduction.TabIndex = 6
        Me.NiveauDeProduction.ValueMember = "id_niveau"
        '
        'Magasin
        '
        Me.Magasin.DataSource = Me.MagasinBindingSource
        Me.Magasin.FormattingEnabled = True
        Me.Magasin.Location = New System.Drawing.Point(236, 316)
        Me.Magasin.Name = "Magasin"
        Me.Magasin.Size = New System.Drawing.Size(242, 28)
        Me.Magasin.TabIndex = 5
        '
        'Localisation
        '
        Me.Localisation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.Localisation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Localisation.DataSource = Me.LocalisationBindingSource
        Me.Localisation.FormattingEnabled = True
        Me.Localisation.Location = New System.Drawing.Point(236, 248)
        Me.Localisation.Name = "Localisation"
        Me.Localisation.Size = New System.Drawing.Size(242, 28)
        Me.Localisation.TabIndex = 4
        '
        'LocalisationBindingSource
        '
        Me.LocalisationBindingSource.DataMember = "localisation"
        Me.LocalisationBindingSource.DataSource = Me.SemencesDataSet1
        '
        'SemencesDataSet1
        '
        Me.SemencesDataSet1.DataSetName = "semencesDataSet"
        Me.SemencesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DateProduction
        '
        Me.DateProduction.Location = New System.Drawing.Point(236, 196)
        Me.DateProduction.Name = "DateProduction"
        Me.DateProduction.Size = New System.Drawing.Size(242, 26)
        Me.DateProduction.TabIndex = 3
        '
        'PrixUnitaire
        '
        Me.PrixUnitaire.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.PrixUnitaire.Location = New System.Drawing.Point(236, 148)
        Me.PrixUnitaire.Maximum = New Decimal(New Integer() {1215752192, 23, 0, 0})
        Me.PrixUnitaire.Name = "PrixUnitaire"
        Me.PrixUnitaire.Size = New System.Drawing.Size(242, 26)
        Me.PrixUnitaire.TabIndex = 2
        '
        'QuantiteProduite
        '
        Me.QuantiteProduite.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.QuantiteProduite.Location = New System.Drawing.Point(236, 96)
        Me.QuantiteProduite.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.QuantiteProduite.Name = "QuantiteProduite"
        Me.QuantiteProduite.Size = New System.Drawing.Size(242, 26)
        Me.QuantiteProduite.TabIndex = 1
        '
        'EtatStocksSpeculation
        '
        Me.EtatStocksSpeculation.Location = New System.Drawing.Point(4, 44)
        Me.EtatStocksSpeculation.Name = "EtatStocksSpeculation"
        Me.EtatStocksSpeculation.Padding = New System.Windows.Forms.Padding(3)
        Me.EtatStocksSpeculation.Size = New System.Drawing.Size(1201, 700)
        Me.EtatStocksSpeculation.TabIndex = 2
        Me.EtatStocksSpeculation.Text = "Etat des stocks des spéculations"
        Me.EtatStocksSpeculation.UseVisualStyleBackColor = True
        '
        'EtatStockVariete
        '
        Me.EtatStockVariete.Controls.Add(Me.DataStockVarieteTab)
        Me.EtatStockVariete.Controls.Add(Me.DataStockVariete)
        Me.EtatStockVariete.Location = New System.Drawing.Point(4, 44)
        Me.EtatStockVariete.Name = "EtatStockVariete"
        Me.EtatStockVariete.Size = New System.Drawing.Size(1201, 700)
        Me.EtatStockVariete.TabIndex = 3
        Me.EtatStockVariete.Text = "Etat des stock variété"
        Me.EtatStockVariete.UseVisualStyleBackColor = True
        '
        'DataStockVarieteTab
        '
        DataGridViewCellStyle9.BackColor = System.Drawing.Color.White
        Me.DataStockVarieteTab.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle9
        Me.DataStockVarieteTab.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataStockVarieteTab.BackgroundColor = System.Drawing.Color.White
        Me.DataStockVarieteTab.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataStockVarieteTab.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle10.NullValue = "-"
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        DataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataStockVarieteTab.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle10
        Me.DataStockVarieteTab.ColumnHeadersHeight = 40
        DataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataStockVarieteTab.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataStockVarieteTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataStockVarieteTab.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DataStockVarieteTab.EnableHeadersVisualStyles = False
        Me.DataStockVarieteTab.Location = New System.Drawing.Point(0, 0)
        Me.DataStockVarieteTab.Margin = New System.Windows.Forms.Padding(2)
        Me.DataStockVarieteTab.Name = "DataStockVarieteTab"
        Me.DataStockVarieteTab.ReadOnly = True
        Me.DataStockVarieteTab.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataStockVarieteTab.RowHeadersDefaultCellStyle = DataGridViewCellStyle12
        Me.DataStockVarieteTab.RowTemplate.Height = 24
        Me.DataStockVarieteTab.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataStockVarieteTab.Size = New System.Drawing.Size(1201, 700)
        Me.DataStockVarieteTab.TabIndex = 27
        '
        'DataStockVariete
        '
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.White
        Me.DataStockVariete.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.DataStockVariete.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataStockVariete.BackgroundColor = System.Drawing.Color.White
        Me.DataStockVariete.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataStockVariete.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.NullValue = "-"
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataStockVariete.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.DataStockVariete.ColumnHeadersHeight = 40
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataStockVariete.DefaultCellStyle = DataGridViewCellStyle15
        Me.DataStockVariete.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataStockVariete.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DataStockVariete.EnableHeadersVisualStyles = False
        Me.DataStockVariete.Location = New System.Drawing.Point(0, 0)
        Me.DataStockVariete.Margin = New System.Windows.Forms.Padding(2)
        Me.DataStockVariete.Name = "DataStockVariete"
        Me.DataStockVariete.ReadOnly = True
        Me.DataStockVariete.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataStockVariete.RowHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.DataStockVariete.RowTemplate.Height = 24
        Me.DataStockVariete.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataStockVariete.Size = New System.Drawing.Size(1201, 700)
        Me.DataStockVariete.TabIndex = 25
        '
        'SemencesDataSet
        '
        Me.SemencesDataSet.DataSetName = "semencesDataSet"
        Me.SemencesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VarieteinstitutionBindingSource
        '
        Me.VarieteinstitutionBindingSource.DataMember = "variete_institution"
        Me.VarieteinstitutionBindingSource.DataSource = Me.SemencesDataSet
        '
        'ContextMenuProduction
        '
        Me.ContextMenuProduction.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MenuItemModifier, Me.ToolStripSeparator1, Me.SupprimerMenuItem})
        Me.ContextMenuProduction.Name = "ContextMenuStrip1"
        Me.ContextMenuProduction.Size = New System.Drawing.Size(130, 54)
        '
        'MenuItemModifier
        '
        Me.MenuItemModifier.Name = "MenuItemModifier"
        Me.MenuItemModifier.Size = New System.Drawing.Size(129, 22)
        Me.MenuItemModifier.Text = "Modifier"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(126, 6)
        '
        'SupprimerMenuItem
        '
        Me.SupprimerMenuItem.Name = "SupprimerMenuItem"
        Me.SupprimerMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.SupprimerMenuItem.Text = "Supprimer"
        '
        'ContextMenuStrip2
        '
        Me.ContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModifierToolStripMenuItem, Me.SupprimerToolStripMenuItem})
        Me.ContextMenuStrip2.Name = "ContextMenuStrip2"
        Me.ContextMenuStrip2.Size = New System.Drawing.Size(130, 48)
        '
        'ModifierToolStripMenuItem
        '
        Me.ModifierToolStripMenuItem.Name = "ModifierToolStripMenuItem"
        Me.ModifierToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.ModifierToolStripMenuItem.Text = "Modifier"
        '
        'SupprimerToolStripMenuItem
        '
        Me.SupprimerToolStripMenuItem.Name = "SupprimerToolStripMenuItem"
        Me.SupprimerToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.SupprimerToolStripMenuItem.Text = "Supprimer"
        '
        'Niveau_institutionTableAdapter
        '
        Me.Niveau_institutionTableAdapter.ClearBeforeFill = True
        '
        'FormSpeculations
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1212, 748)
        Me.Controls.Add(Me.ProductionMainTabControl)
        Me.Controls.Add(Me.Splitter1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "FormSpeculations"
        Me.Text = "FormProduction"
        Me.ProductionMainTabControl.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.ClearRechercher, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataProduction, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataVarieteInstitution, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AjouterProduction.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.VarieteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NiveauinstitutionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MagasinBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocalisationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SemencesDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrixUnitaire, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuantiteProduite, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EtatStockVariete.ResumeLayout(False)
        CType(Me.DataStockVarieteTab, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataStockVariete, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SemencesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VarieteinstitutionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuProduction.ResumeLayout(False)
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ProductionBindingSource As BindingSource
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents SemencesDataSet As semencesDataSet
    Friend WithEvents ProductionTableAdapter As semencesDataSetTableAdapters.productionTableAdapter
    Friend WithEvents ProductionMainTabControl As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents DataVarieteInstitution As DataGridView
    Friend WithEvents AjouterProduction As TabPage
    Friend WithEvents NiveauDeProduction As ComboBox
    Friend WithEvents Magasin As ComboBox
    Friend WithEvents Localisation As ComboBox
    Friend WithEvents DateProduction As DateTimePicker
    Friend WithEvents PrixUnitaire As NumericUpDown
    Friend WithEvents QuantiteProduite As NumericUpDown
    Friend WithEvents Label8 As Label
    Friend WithEvents DateProductionLabel As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents QuantiteProduiteLabel As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents ChoixVariete As ComboBox
    Friend WithEvents VarieteinstitutionBindingSource As BindingSource
    Friend WithEvents Variete_institutionTableAdapter As semencesDataSetTableAdapters.variete_institutionTableAdapter
    Friend WithEvents VarieteBindingSource As BindingSource
    Friend WithEvents Niveau_de_productionTableAdapter As semencesDataSetTableAdapters.niveau_de_productionTableAdapter
    Friend WithEvents MagasinTableAdapter As semencesDataSetTableAdapters.magasinTableAdapter
    Friend WithEvents LocalisationTableAdapter As semencesDataSetTableAdapters.localisationTableAdapter
    Friend WithEvents ZoneProduction As Label
    Friend WithEvents DataProduction As DataGridView
    Friend WithEvents SemencesDataSet1 As semencesDataSet
    Friend WithEvents LocalisationBindingSource As BindingSource
    Friend WithEvents MagasinBindingSource As BindingSource
    Friend WithEvents EtatStocksSpeculation As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ContextMenuProduction As ContextMenuStrip
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ChoixRecherche As ComboBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Recherche As TextBox
    Friend WithEvents ClearRechercher As PictureBox
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents ModifierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SupprimerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuItemModifier As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents SupprimerMenuItem As ToolStripMenuItem
    Friend WithEvents EtatStockVariete As TabPage
    Friend WithEvents DataStockVariete As DataGridView
    Friend WithEvents DataStockVarieteTab As DataGridView
    Friend WithEvents NiveauinstitutionBindingSource As BindingSource
    Friend WithEvents Niveau_institutionTableAdapter As semencesDataSetTableAdapters.niveau_institutionTableAdapter
End Class
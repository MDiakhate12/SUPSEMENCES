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
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormSpeculations))
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle22 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle23 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle24 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.ProductionMainTabControl = New System.Windows.Forms.TabControl()
        Me.ProductionTab = New System.Windows.Forms.TabPage()
        Me.DataProduction = New System.Windows.Forms.DataGridView()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ChoixRecherche = New System.Windows.Forms.ComboBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.ClearRechercher = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Recherche = New System.Windows.Forms.TextBox()
        Me.AjouterProduction = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ChoixSpéculation = New System.Windows.Forms.ComboBox()
        Me.SpeculationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.ProductionTab.SuspendLayout()
        CType(Me.DataProduction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.ClearRechercher, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AjouterProduction.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.SpeculationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Splitter1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(4, 920)
        Me.Splitter1.TabIndex = 0
        Me.Splitter1.TabStop = False
        '
        'ProductionMainTabControl
        '
        Me.ProductionMainTabControl.Controls.Add(Me.ProductionTab)
        Me.ProductionMainTabControl.Controls.Add(Me.AjouterProduction)
        Me.ProductionMainTabControl.Controls.Add(Me.EtatStocksSpeculation)
        Me.ProductionMainTabControl.Controls.Add(Me.EtatStockVariete)
        Me.ProductionMainTabControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProductionMainTabControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductionMainTabControl.ItemSize = New System.Drawing.Size(85, 40)
        Me.ProductionMainTabControl.Location = New System.Drawing.Point(4, 0)
        Me.ProductionMainTabControl.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ProductionMainTabControl.Name = "ProductionMainTabControl"
        Me.ProductionMainTabControl.SelectedIndex = 0
        Me.ProductionMainTabControl.Size = New System.Drawing.Size(1612, 920)
        Me.ProductionMainTabControl.TabIndex = 1
        '
        'ProductionTab
        '
        Me.ProductionTab.Controls.Add(Me.DataProduction)
        Me.ProductionTab.Controls.Add(Me.Panel4)
        Me.ProductionTab.Location = New System.Drawing.Point(4, 44)
        Me.ProductionTab.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ProductionTab.Name = "ProductionTab"
        Me.ProductionTab.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ProductionTab.Size = New System.Drawing.Size(1604, 872)
        Me.ProductionTab.TabIndex = 0
        Me.ProductionTab.Text = "Productions"
        Me.ProductionTab.UseVisualStyleBackColor = True
        '
        'DataProduction
        '
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.White
        Me.DataProduction.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.DataProduction.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataProduction.BackgroundColor = System.Drawing.Color.White
        Me.DataProduction.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataProduction.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle14.NullValue = "-"
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataProduction.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle14
        Me.DataProduction.ColumnHeadersHeight = 40
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataProduction.DefaultCellStyle = DataGridViewCellStyle15
        Me.DataProduction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataProduction.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DataProduction.EnableHeadersVisualStyles = False
        Me.DataProduction.Location = New System.Drawing.Point(4, 217)
        Me.DataProduction.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataProduction.Name = "DataProduction"
        Me.DataProduction.ReadOnly = True
        Me.DataProduction.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataProduction.RowHeadersDefaultCellStyle = DataGridViewCellStyle16
        Me.DataProduction.RowTemplate.Height = 24
        Me.DataProduction.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataProduction.Size = New System.Drawing.Size(1596, 651)
        Me.DataProduction.TabIndex = 24
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(4, 4)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1596, 213)
        Me.Panel4.TabIndex = 26
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
        Me.Panel5.Location = New System.Drawing.Point(1231, 0)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(365, 213)
        Me.Panel5.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Gainsboro
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(19, 11)
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
        Me.ChoixRecherche.Location = New System.Drawing.Point(19, 48)
        Me.ChoixRecherche.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChoixRecherche.Name = "ChoixRecherche"
        Me.ChoixRecherche.Size = New System.Drawing.Size(323, 28)
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
        Me.Panel6.Location = New System.Drawing.Point(19, 123)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(327, 43)
        Me.Panel6.TabIndex = 22
        '
        'ClearRechercher
        '
        Me.ClearRechercher.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ClearRechercher.Dock = System.Windows.Forms.DockStyle.Right
        Me.ClearRechercher.Image = CType(resources.GetObject("ClearRechercher.Image"), System.Drawing.Image)
        Me.ClearRechercher.Location = New System.Drawing.Point(276, 0)
        Me.ClearRechercher.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ClearRechercher.Name = "ClearRechercher"
        Me.ClearRechercher.Size = New System.Drawing.Size(49, 41)
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
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(49, 41)
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
        Me.Recherche.Location = New System.Drawing.Point(55, 5)
        Me.Recherche.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Recherche.Name = "Recherche"
        Me.Recherche.Size = New System.Drawing.Size(245, 22)
        Me.Recherche.TabIndex = 0
        Me.Recherche.Text = "Rechercher"
        '
        'AjouterProduction
        '
        Me.AjouterProduction.Controls.Add(Me.Panel1)
        Me.AjouterProduction.Location = New System.Drawing.Point(4, 44)
        Me.AjouterProduction.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.AjouterProduction.Name = "AjouterProduction"
        Me.AjouterProduction.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.AjouterProduction.Size = New System.Drawing.Size(1604, 872)
        Me.AjouterProduction.TabIndex = 1
        Me.AjouterProduction.Text = "Ajouter Nouvelle Production"
        Me.AjouterProduction.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.ChoixSpéculation)
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
        Me.Panel1.Location = New System.Drawing.Point(307, 7)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(982, 669)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(33, 26)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 20)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Spéculation"
        '
        'ChoixSpéculation
        '
        Me.ChoixSpéculation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ChoixSpéculation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ChoixSpéculation.DataSource = Me.SpeculationBindingSource
        Me.ChoixSpéculation.FormattingEnabled = True
        Me.ChoixSpéculation.Location = New System.Drawing.Point(313, 16)
        Me.ChoixSpéculation.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChoixSpéculation.Name = "ChoixSpéculation"
        Me.ChoixSpéculation.Size = New System.Drawing.Size(321, 28)
        Me.ChoixSpéculation.TabIndex = 0
        '
        'ZoneProduction
        '
        Me.ZoneProduction.AutoSize = True
        Me.ZoneProduction.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZoneProduction.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.ZoneProduction.Location = New System.Drawing.Point(309, 378)
        Me.ZoneProduction.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
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
        Me.Label9.Location = New System.Drawing.Point(33, 90)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
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
        Me.ChoixVariete.Location = New System.Drawing.Point(313, 80)
        Me.ChoixVariete.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ChoixVariete.Name = "ChoixVariete"
        Me.ChoixVariete.Size = New System.Drawing.Size(321, 28)
        Me.ChoixVariete.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(33, 507)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
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
        Me.DateProductionLabel.Location = New System.Drawing.Point(33, 283)
        Me.DateProductionLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
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
        Me.Label5.Location = New System.Drawing.Point(33, 350)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
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
        Me.Label6.Location = New System.Drawing.Point(33, 433)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
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
        Me.Label3.Location = New System.Drawing.Point(33, 224)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
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
        Me.QuantiteProduiteLabel.Location = New System.Drawing.Point(33, 160)
        Me.QuantiteProduiteLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
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
        Me.Button1.Location = New System.Drawing.Point(39, 567)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(597, 71)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Enregistrer"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(668, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(312, 667)
        Me.Panel2.TabIndex = 8
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(77, 249)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(179, 148)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'NiveauDeProduction
        '
        Me.NiveauDeProduction.DataSource = Me.NiveauinstitutionBindingSource
        Me.NiveauDeProduction.FormattingEnabled = True
        Me.NiveauDeProduction.Location = New System.Drawing.Point(313, 497)
        Me.NiveauDeProduction.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.NiveauDeProduction.Name = "NiveauDeProduction"
        Me.NiveauDeProduction.Size = New System.Drawing.Size(321, 28)
        Me.NiveauDeProduction.TabIndex = 7
        '
        'Magasin
        '
        Me.Magasin.DataSource = Me.MagasinBindingSource
        Me.Magasin.FormattingEnabled = True
        Me.Magasin.Location = New System.Drawing.Point(313, 423)
        Me.Magasin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Magasin.Name = "Magasin"
        Me.Magasin.Size = New System.Drawing.Size(321, 28)
        Me.Magasin.TabIndex = 6
        '
        'Localisation
        '
        Me.Localisation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.Localisation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Localisation.DataSource = Me.LocalisationBindingSource
        Me.Localisation.FormattingEnabled = True
        Me.Localisation.Location = New System.Drawing.Point(313, 340)
        Me.Localisation.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Localisation.Name = "Localisation"
        Me.Localisation.Size = New System.Drawing.Size(321, 28)
        Me.Localisation.TabIndex = 5
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
        Me.DateProduction.Location = New System.Drawing.Point(313, 276)
        Me.DateProduction.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.DateProduction.Name = "DateProduction"
        Me.DateProduction.Size = New System.Drawing.Size(321, 26)
        Me.DateProduction.TabIndex = 4
        '
        'PrixUnitaire
        '
        Me.PrixUnitaire.Increment = New Decimal(New Integer() {25, 0, 0, 0})
        Me.PrixUnitaire.Location = New System.Drawing.Point(313, 217)
        Me.PrixUnitaire.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PrixUnitaire.Maximum = New Decimal(New Integer() {1215752192, 23, 0, 0})
        Me.PrixUnitaire.Name = "PrixUnitaire"
        Me.PrixUnitaire.Size = New System.Drawing.Size(323, 26)
        Me.PrixUnitaire.TabIndex = 3
        '
        'QuantiteProduite
        '
        Me.QuantiteProduite.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.QuantiteProduite.Location = New System.Drawing.Point(313, 153)
        Me.QuantiteProduite.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.QuantiteProduite.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.QuantiteProduite.Name = "QuantiteProduite"
        Me.QuantiteProduite.Size = New System.Drawing.Size(323, 26)
        Me.QuantiteProduite.TabIndex = 2
        '
        'EtatStocksSpeculation
        '
        Me.EtatStocksSpeculation.Location = New System.Drawing.Point(4, 44)
        Me.EtatStocksSpeculation.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.EtatStocksSpeculation.Name = "EtatStocksSpeculation"
        Me.EtatStocksSpeculation.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.EtatStocksSpeculation.Size = New System.Drawing.Size(1604, 873)
        Me.EtatStocksSpeculation.TabIndex = 2
        Me.EtatStocksSpeculation.Text = "Etat des stocks des spéculations"
        Me.EtatStocksSpeculation.UseVisualStyleBackColor = True
        '
        'EtatStockVariete
        '
        Me.EtatStockVariete.Controls.Add(Me.DataStockVarieteTab)
        Me.EtatStockVariete.Controls.Add(Me.DataStockVariete)
        Me.EtatStockVariete.Location = New System.Drawing.Point(4, 44)
        Me.EtatStockVariete.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.EtatStockVariete.Name = "EtatStockVariete"
        Me.EtatStockVariete.Size = New System.Drawing.Size(1604, 873)
        Me.EtatStockVariete.TabIndex = 3
        Me.EtatStockVariete.Text = "Etat des stock variété"
        Me.EtatStockVariete.UseVisualStyleBackColor = True
        '
        'DataStockVarieteTab
        '
        DataGridViewCellStyle17.BackColor = System.Drawing.Color.White
        Me.DataStockVarieteTab.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle17
        Me.DataStockVarieteTab.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataStockVarieteTab.BackgroundColor = System.Drawing.Color.White
        Me.DataStockVarieteTab.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataStockVarieteTab.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle18.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        DataGridViewCellStyle18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle18.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle18.NullValue = "-"
        DataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle18.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        DataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataStockVarieteTab.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle18
        Me.DataStockVarieteTab.ColumnHeadersHeight = 40
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataStockVarieteTab.DefaultCellStyle = DataGridViewCellStyle19
        Me.DataStockVarieteTab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataStockVarieteTab.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DataStockVarieteTab.EnableHeadersVisualStyles = False
        Me.DataStockVarieteTab.Location = New System.Drawing.Point(0, 0)
        Me.DataStockVarieteTab.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataStockVarieteTab.Name = "DataStockVarieteTab"
        Me.DataStockVarieteTab.ReadOnly = True
        Me.DataStockVarieteTab.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataStockVarieteTab.RowHeadersDefaultCellStyle = DataGridViewCellStyle20
        Me.DataStockVarieteTab.RowTemplate.Height = 24
        Me.DataStockVarieteTab.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.DataStockVarieteTab.Size = New System.Drawing.Size(1604, 873)
        Me.DataStockVarieteTab.TabIndex = 27
        '
        'DataStockVariete
        '
        DataGridViewCellStyle21.BackColor = System.Drawing.Color.White
        Me.DataStockVariete.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle21
        Me.DataStockVariete.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataStockVariete.BackgroundColor = System.Drawing.Color.White
        Me.DataStockVariete.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataStockVariete.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle22.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        DataGridViewCellStyle22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle22.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle22.NullValue = "-"
        DataGridViewCellStyle22.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle22.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        DataGridViewCellStyle22.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataStockVariete.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle22
        Me.DataStockVariete.ColumnHeadersHeight = 40
        DataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle23.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle23.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle23.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataStockVariete.DefaultCellStyle = DataGridViewCellStyle23
        Me.DataStockVariete.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataStockVariete.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter
        Me.DataStockVariete.EnableHeadersVisualStyles = False
        Me.DataStockVariete.Location = New System.Drawing.Point(0, 0)
        Me.DataStockVariete.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataStockVariete.Name = "DataStockVariete"
        Me.DataStockVariete.ReadOnly = True
        Me.DataStockVariete.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataStockVariete.RowHeadersDefaultCellStyle = DataGridViewCellStyle24
        Me.DataStockVariete.RowTemplate.Height = 24
        Me.DataStockVariete.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataStockVariete.Size = New System.Drawing.Size(1604, 873)
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
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1616, 920)
        Me.Controls.Add(Me.ProductionMainTabControl)
        Me.Controls.Add(Me.Splitter1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "FormSpeculations"
        Me.Text = "FormProduction"
        Me.ProductionMainTabControl.ResumeLayout(False)
        Me.ProductionTab.ResumeLayout(False)
        CType(Me.DataProduction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.ClearRechercher, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AjouterProduction.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.SpeculationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents ProductionTab As TabPage
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
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents ChoixRecherche As ComboBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents ClearRechercher As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Recherche As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ChoixSpéculation As ComboBox
    Friend WithEvents SpeculationBindingSource As BindingSource
End Class

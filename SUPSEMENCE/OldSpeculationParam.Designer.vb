﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OldSpeculationParam
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OldSpeculationParam))
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.NomspeculationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LieudestockageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypedestockageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantitespeculationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NiveaudeproductionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdsiteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.SearchPanel = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioNiveauProduction = New System.Windows.Forms.RadioButton()
        Me.RadioTypeStockage = New System.Windows.Forms.RadioButton()
        Me.RadioLieuStockage = New System.Windows.Forms.RadioButton()
        Me.RadioSpeculation = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AjouterImage = New System.Windows.Forms.Button()
        Me.ImageVariete = New System.Windows.Forms.PictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SiteStockage = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TypeStockage = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.NomSpeculation = New System.Windows.Forms.TextBox()
        Me.LieuStockage = New System.Windows.Forms.TextBox()
        Me.QuantiteSpeculation = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.AjouterSpeculation = New System.Windows.Forms.Button()
        Me.NiveauProduction = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.NiveauxCheckedList = New System.Windows.Forms.CheckedListBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.R2 = New System.Windows.Forms.CheckBox()
        Me.R1 = New System.Windows.Forms.CheckBox()
        Me.G2 = New System.Windows.Forms.CheckBox()
        Me.G1 = New System.Windows.Forms.CheckBox()
        Me.G0 = New System.Windows.Forms.CheckBox()
        Me.Base = New System.Windows.Forms.CheckBox()
        Me.Prébase = New System.Windows.Forms.CheckBox()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SearchPanel.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ImageVariete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.QuantiteSpeculation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView2
        '
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.White
        Me.DataGridView2.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle2.NullValue = "-"
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridView2.ColumnHeadersHeight = 40
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NomspeculationDataGridViewTextBoxColumn, Me.LieudestockageDataGridViewTextBoxColumn, Me.TypedestockageDataGridViewTextBoxColumn, Me.QuantitespeculationDataGridViewTextBoxColumn, Me.NiveaudeproductionDataGridViewTextBoxColumn, Me.IdsiteDataGridViewTextBoxColumn})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView2.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.EnableHeadersVisualStyles = False
        Me.DataGridView2.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(125, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView2.RowHeadersDefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(1469, 758)
        Me.DataGridView2.TabIndex = 22
        '
        'NomspeculationDataGridViewTextBoxColumn
        '
        Me.NomspeculationDataGridViewTextBoxColumn.DataPropertyName = "nom_speculation"
        Me.NomspeculationDataGridViewTextBoxColumn.HeaderText = "Spéculation"
        Me.NomspeculationDataGridViewTextBoxColumn.Name = "NomspeculationDataGridViewTextBoxColumn"
        '
        'LieudestockageDataGridViewTextBoxColumn
        '
        Me.LieudestockageDataGridViewTextBoxColumn.DataPropertyName = "lieu_de_stockage"
        Me.LieudestockageDataGridViewTextBoxColumn.HeaderText = "Stocké à"
        Me.LieudestockageDataGridViewTextBoxColumn.Name = "LieudestockageDataGridViewTextBoxColumn"
        '
        'TypedestockageDataGridViewTextBoxColumn
        '
        Me.TypedestockageDataGridViewTextBoxColumn.DataPropertyName = "type_de_stockage"
        Me.TypedestockageDataGridViewTextBoxColumn.HeaderText = "Stocké dans"
        Me.TypedestockageDataGridViewTextBoxColumn.Name = "TypedestockageDataGridViewTextBoxColumn"
        '
        'QuantitespeculationDataGridViewTextBoxColumn
        '
        Me.QuantitespeculationDataGridViewTextBoxColumn.DataPropertyName = "quantite_speculation"
        Me.QuantitespeculationDataGridViewTextBoxColumn.HeaderText = "Quantité"
        Me.QuantitespeculationDataGridViewTextBoxColumn.Name = "QuantitespeculationDataGridViewTextBoxColumn"
        '
        'NiveaudeproductionDataGridViewTextBoxColumn
        '
        Me.NiveaudeproductionDataGridViewTextBoxColumn.DataPropertyName = "niveau_de_production"
        Me.NiveaudeproductionDataGridViewTextBoxColumn.HeaderText = "Niveau"
        Me.NiveaudeproductionDataGridViewTextBoxColumn.Name = "NiveaudeproductionDataGridViewTextBoxColumn"
        '
        'IdsiteDataGridViewTextBoxColumn
        '
        Me.IdsiteDataGridViewTextBoxColumn.DataPropertyName = "id_site"
        Me.IdsiteDataGridViewTextBoxColumn.HeaderText = "Site de stockage"
        Me.IdsiteDataGridViewTextBoxColumn.Name = "IdsiteDataGridViewTextBoxColumn"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.White
        Me.TextBox1.Location = New System.Drawing.Point(65, 11)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(304, 22)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "Rechercher"
        '
        'SearchPanel
        '
        Me.SearchPanel.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.SearchPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.SearchPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SearchPanel.Controls.Add(Me.PictureBox2)
        Me.SearchPanel.Controls.Add(Me.TextBox1)
        Me.SearchPanel.Location = New System.Drawing.Point(23, 224)
        Me.SearchPanel.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SearchPanel.Name = "SearchPanel"
        Me.SearchPanel.Size = New System.Drawing.Size(374, 59)
        Me.SearchPanel.TabIndex = 20
        '
        'PictureBox2
        '
        Me.PictureBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(-1, 0)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(63, 58)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.Color.Gainsboro
        Me.GroupBox1.Controls.Add(Me.RadioNiveauProduction)
        Me.GroupBox1.Controls.Add(Me.RadioTypeStockage)
        Me.GroupBox1.Controls.Add(Me.RadioLieuStockage)
        Me.GroupBox1.Controls.Add(Me.RadioSpeculation)
        Me.GroupBox1.Controls.Add(Me.SearchPanel)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(1068, 68)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(404, 300)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Rechercher par :"
        '
        'RadioNiveauProduction
        '
        Me.RadioNiveauProduction.AutoSize = True
        Me.RadioNiveauProduction.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioNiveauProduction.Location = New System.Drawing.Point(23, 160)
        Me.RadioNiveauProduction.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RadioNiveauProduction.Name = "RadioNiveauProduction"
        Me.RadioNiveauProduction.Size = New System.Drawing.Size(75, 24)
        Me.RadioNiveauProduction.TabIndex = 24
        Me.RadioNiveauProduction.TabStop = True
        Me.RadioNiveauProduction.Text = "Niveau"
        Me.RadioNiveauProduction.UseVisualStyleBackColor = True
        '
        'RadioTypeStockage
        '
        Me.RadioTypeStockage.AutoSize = True
        Me.RadioTypeStockage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioTypeStockage.Location = New System.Drawing.Point(23, 121)
        Me.RadioTypeStockage.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RadioTypeStockage.Name = "RadioTypeStockage"
        Me.RadioTypeStockage.Size = New System.Drawing.Size(130, 24)
        Me.RadioTypeStockage.TabIndex = 23
        Me.RadioTypeStockage.TabStop = True
        Me.RadioTypeStockage.Text = "Type stockage"
        Me.RadioTypeStockage.UseVisualStyleBackColor = True
        '
        'RadioLieuStockage
        '
        Me.RadioLieuStockage.AutoSize = True
        Me.RadioLieuStockage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioLieuStockage.Location = New System.Drawing.Point(23, 81)
        Me.RadioLieuStockage.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RadioLieuStockage.Name = "RadioLieuStockage"
        Me.RadioLieuStockage.Size = New System.Drawing.Size(126, 24)
        Me.RadioLieuStockage.TabIndex = 22
        Me.RadioLieuStockage.TabStop = True
        Me.RadioLieuStockage.Text = "Lieu stockage"
        Me.RadioLieuStockage.UseVisualStyleBackColor = True
        '
        'RadioSpeculation
        '
        Me.RadioSpeculation.AutoSize = True
        Me.RadioSpeculation.Checked = True
        Me.RadioSpeculation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioSpeculation.Location = New System.Drawing.Point(23, 42)
        Me.RadioSpeculation.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.RadioSpeculation.Name = "RadioSpeculation"
        Me.RadioSpeculation.Size = New System.Drawing.Size(145, 24)
        Me.RadioSpeculation.TabIndex = 21
        Me.RadioSpeculation.TabStop = True
        Me.RadioSpeculation.Text = "Nom spéculation"
        Me.RadioSpeculation.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.AjouterImage)
        Me.Panel1.Controls.Add(Me.ImageVariete)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1469, 368)
        Me.Panel1.TabIndex = 21
        '
        'AjouterImage
        '
        Me.AjouterImage.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.AjouterImage.FlatAppearance.BorderSize = 0
        Me.AjouterImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AjouterImage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AjouterImage.ForeColor = System.Drawing.Color.White
        Me.AjouterImage.Location = New System.Drawing.Point(520, 194)
        Me.AjouterImage.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.AjouterImage.Name = "AjouterImage"
        Me.AjouterImage.Size = New System.Drawing.Size(221, 42)
        Me.AjouterImage.TabIndex = 38
        Me.AjouterImage.Text = "Ajouter image"
        Me.AjouterImage.UseVisualStyleBackColor = False
        '
        'ImageVariete
        '
        Me.ImageVariete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ImageVariete.Image = CType(resources.GetObject("ImageVariete.Image"), System.Drawing.Image)
        Me.ImageVariete.Location = New System.Drawing.Point(520, 6)
        Me.ImageVariete.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ImageVariete.Name = "ImageVariete"
        Me.ImageVariete.Size = New System.Drawing.Size(221, 175)
        Me.ImageVariete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ImageVariete.TabIndex = 39
        Me.ImageVariete.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel2.Controls.Add(Me.SiteStockage)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.TypeStockage)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.NomSpeculation)
        Me.Panel2.Controls.Add(Me.LieuStockage)
        Me.Panel2.Controls.Add(Me.QuantiteSpeculation)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.AjouterSpeculation)
        Me.Panel2.Controls.Add(Me.NiveauProduction)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(513, 368)
        Me.Panel2.TabIndex = 21
        '
        'SiteStockage
        '
        Me.SiteStockage.DisplayMember = "id_site"
        Me.SiteStockage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiteStockage.FormattingEnabled = True
        Me.SiteStockage.Location = New System.Drawing.Point(273, 160)
        Me.SiteStockage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SiteStockage.Name = "SiteStockage"
        Me.SiteStockage.Size = New System.Drawing.Size(213, 28)
        Me.SiteStockage.TabIndex = 19
        Me.SiteStockage.ValueMember = "id_site"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Gainsboro
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(15, 169)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Site de stockage"
        '
        'TypeStockage
        '
        Me.TypeStockage.AutoCompleteCustomSource.AddRange(New String() {"Magasin", "Chambre froide"})
        Me.TypeStockage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TypeStockage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.TypeStockage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TypeStockage.Location = New System.Drawing.Point(273, 257)
        Me.TypeStockage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TypeStockage.Name = "TypeStockage"
        Me.TypeStockage.Size = New System.Drawing.Size(213, 26)
        Me.TypeStockage.TabIndex = 10
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Gainsboro
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(15, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(178, 20)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Niveau de production"
        '
        'NomSpeculation
        '
        Me.NomSpeculation.AutoCompleteCustomSource.AddRange(New String() {"riz", "sorgho", "mil", "maïs ", "arachide", "niébé", "oignon", "tomate", "piment", "jaxatu", "terre", "douce", "gombo", "aubergine"})
        Me.NomSpeculation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.NomSpeculation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.NomSpeculation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NomSpeculation.Location = New System.Drawing.Point(273, 16)
        Me.NomSpeculation.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NomSpeculation.Name = "NomSpeculation"
        Me.NomSpeculation.Size = New System.Drawing.Size(213, 26)
        Me.NomSpeculation.TabIndex = 7
        '
        'LieuStockage
        '
        Me.LieuStockage.AutoCompleteCustomSource.AddRange(New String() {"Dakar", "Diourbel", "Fatick", "Kaffrine", "Kaolack", "Kédougou", "Kolda", "Louga", "Matam", "Saint-Louis", "Sédhiou", "Tambacounda", "Thiès", "Ziguinchor"})
        Me.LieuStockage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.LieuStockage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.LieuStockage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LieuStockage.Location = New System.Drawing.Point(273, 210)
        Me.LieuStockage.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.LieuStockage.Name = "LieuStockage"
        Me.LieuStockage.Size = New System.Drawing.Size(213, 26)
        Me.LieuStockage.TabIndex = 11
        '
        'QuantiteSpeculation
        '
        Me.QuantiteSpeculation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantiteSpeculation.Increment = New Decimal(New Integer() {25, 0, 0, 0})
        Me.QuantiteSpeculation.Location = New System.Drawing.Point(273, 113)
        Me.QuantiteSpeculation.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.QuantiteSpeculation.Maximum = New Decimal(New Integer() {100000000, 0, 0, 0})
        Me.QuantiteSpeculation.Name = "QuantiteSpeculation"
        Me.QuantiteSpeculation.Size = New System.Drawing.Size(213, 26)
        Me.QuantiteSpeculation.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Gainsboro
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(15, 117)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Quantité"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Gainsboro
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(15, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nom spéculation"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Gainsboro
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 262)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(150, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Type de stockage"
        '
        'AjouterSpeculation
        '
        Me.AjouterSpeculation.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.AjouterSpeculation.FlatAppearance.BorderSize = 0
        Me.AjouterSpeculation.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.AjouterSpeculation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AjouterSpeculation.ForeColor = System.Drawing.Color.White
        Me.AjouterSpeculation.Location = New System.Drawing.Point(19, 308)
        Me.AjouterSpeculation.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.AjouterSpeculation.Name = "AjouterSpeculation"
        Me.AjouterSpeculation.Size = New System.Drawing.Size(468, 46)
        Me.AjouterSpeculation.TabIndex = 4
        Me.AjouterSpeculation.Text = "Enregistrer"
        Me.AjouterSpeculation.UseVisualStyleBackColor = False
        '
        'NiveauProduction
        '
        Me.NiveauProduction.AutoCompleteCustomSource.AddRange(New String() {"Prébase", "Base", "R1", "R2"})
        Me.NiveauProduction.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.NiveauProduction.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.NiveauProduction.Cursor = System.Windows.Forms.Cursors.Hand
        Me.NiveauProduction.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NiveauProduction.FormattingEnabled = True
        Me.NiveauProduction.Items.AddRange(New Object() {"Prébase", "Base", "R1", "R2"})
        Me.NiveauProduction.Location = New System.Drawing.Point(273, 63)
        Me.NiveauProduction.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.NiveauProduction.Name = "NiveauProduction"
        Me.NiveauProduction.Size = New System.Drawing.Size(213, 28)
        Me.NiveauProduction.TabIndex = 13
        Me.NiveauProduction.Tag = ""
        Me.NiveauProduction.Text = "Prébase"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Gainsboro
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 215)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Lieu de stockage"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.White
        Me.Button4.Location = New System.Drawing.Point(931, 506)
        Me.Button4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(189, 46)
        Me.Button4.TabIndex = 53
        Me.Button4.Text = "Enregistrer niveaux"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'NiveauxCheckedList
        '
        Me.NiveauxCheckedList.CheckOnClick = True
        Me.NiveauxCheckedList.FormattingEnabled = True
        Me.NiveauxCheckedList.Location = New System.Drawing.Point(683, 506)
        Me.NiveauxCheckedList.Name = "NiveauxCheckedList"
        Me.NiveauxCheckedList.Size = New System.Drawing.Size(242, 208)
        Me.NiveauxCheckedList.TabIndex = 52
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(205, 692)
        Me.Button6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(417, 46)
        Me.Button6.TabIndex = 50
        Me.Button6.Text = "Enregistrer niveaux"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.R2)
        Me.GroupBox2.Controls.Add(Me.R1)
        Me.GroupBox2.Controls.Add(Me.G2)
        Me.GroupBox2.Controls.Add(Me.G1)
        Me.GroupBox2.Controls.Add(Me.G0)
        Me.GroupBox2.Controls.Add(Me.Base)
        Me.GroupBox2.Controls.Add(Me.Prébase)
        Me.GroupBox2.Location = New System.Drawing.Point(205, 418)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(417, 268)
        Me.GroupBox2.TabIndex = 51
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Niveaux de semence pris en charge"
        '
        'R2
        '
        Me.R2.AutoSize = True
        Me.R2.Location = New System.Drawing.Point(15, 218)
        Me.R2.Margin = New System.Windows.Forms.Padding(4)
        Me.R2.Name = "R2"
        Me.R2.Size = New System.Drawing.Size(44, 20)
        Me.R2.TabIndex = 6
        Me.R2.Text = "R2"
        Me.R2.UseVisualStyleBackColor = True
        '
        'R1
        '
        Me.R1.AutoSize = True
        Me.R1.Location = New System.Drawing.Point(15, 188)
        Me.R1.Margin = New System.Windows.Forms.Padding(4)
        Me.R1.Name = "R1"
        Me.R1.Size = New System.Drawing.Size(44, 20)
        Me.R1.TabIndex = 5
        Me.R1.Text = "R1"
        Me.R1.UseVisualStyleBackColor = True
        '
        'G2
        '
        Me.G2.AutoSize = True
        Me.G2.Location = New System.Drawing.Point(15, 159)
        Me.G2.Margin = New System.Windows.Forms.Padding(4)
        Me.G2.Name = "G2"
        Me.G2.Size = New System.Drawing.Size(44, 20)
        Me.G2.TabIndex = 4
        Me.G2.Text = "G2"
        Me.G2.UseVisualStyleBackColor = True
        '
        'G1
        '
        Me.G1.AutoSize = True
        Me.G1.Location = New System.Drawing.Point(15, 129)
        Me.G1.Margin = New System.Windows.Forms.Padding(4)
        Me.G1.Name = "G1"
        Me.G1.Size = New System.Drawing.Size(44, 20)
        Me.G1.TabIndex = 3
        Me.G1.Text = "G1"
        Me.G1.UseVisualStyleBackColor = True
        '
        'G0
        '
        Me.G0.AutoSize = True
        Me.G0.Location = New System.Drawing.Point(15, 100)
        Me.G0.Margin = New System.Windows.Forms.Padding(4)
        Me.G0.Name = "G0"
        Me.G0.Size = New System.Drawing.Size(44, 20)
        Me.G0.TabIndex = 2
        Me.G0.Text = "G0"
        Me.G0.UseVisualStyleBackColor = True
        '
        'Base
        '
        Me.Base.AutoSize = True
        Me.Base.Location = New System.Drawing.Point(15, 70)
        Me.Base.Margin = New System.Windows.Forms.Padding(4)
        Me.Base.Name = "Base"
        Me.Base.Size = New System.Drawing.Size(59, 20)
        Me.Base.TabIndex = 1
        Me.Base.Text = "Base"
        Me.Base.UseVisualStyleBackColor = True
        '
        'Prébase
        '
        Me.Prébase.AutoSize = True
        Me.Prébase.Location = New System.Drawing.Point(15, 41)
        Me.Prébase.Margin = New System.Windows.Forms.Padding(4)
        Me.Prébase.Name = "Prébase"
        Me.Prébase.Size = New System.Drawing.Size(79, 20)
        Me.Prébase.TabIndex = 0
        Me.Prébase.Text = "Prébase"
        Me.Prébase.UseVisualStyleBackColor = True
        '
        'OldSpeculationParam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1469, 758)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.NiveauxCheckedList)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.DataGridView2)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "OldSpeculationParam"
        Me.Text = "OldSpeculationParam"
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SearchPanel.ResumeLayout(False)
        Me.SearchPanel.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        CType(Me.ImageVariete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.QuantiteSpeculation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents NomspeculationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LieudestockageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TypedestockageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QuantitespeculationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NiveaudeproductionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents IdsiteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents SearchPanel As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioNiveauProduction As RadioButton
    Friend WithEvents RadioTypeStockage As RadioButton
    Friend WithEvents RadioLieuStockage As RadioButton
    Friend WithEvents RadioSpeculation As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents AjouterImage As Button
    Friend WithEvents ImageVariete As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents SiteStockage As ComboBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TypeStockage As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents NomSpeculation As TextBox
    Friend WithEvents LieuStockage As TextBox
    Friend WithEvents QuantiteSpeculation As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents AjouterSpeculation As Button
    Friend WithEvents NiveauProduction As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents NiveauxCheckedList As CheckedListBox
    Friend WithEvents Button6 As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents R2 As CheckBox
    Friend WithEvents R1 As CheckBox
    Friend WithEvents G2 As CheckBox
    Friend WithEvents G1 As CheckBox
    Friend WithEvents G0 As CheckBox
    Friend WithEvents Base As CheckBox
    Friend WithEvents Prébase As CheckBox
End Class

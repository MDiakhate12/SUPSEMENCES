<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUpdateProduction
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUpdateProduction))
        Me.ClientTableAdapter = New SUPSEMENCE.semencesDataSetTableAdapters.clientTableAdapter()
        Me.Enregistrer = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ClientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SemencesDataSet = New SUPSEMENCE.semencesDataSet()
        Me.LocalisationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LocalisationTableAdapter = New SUPSEMENCE.semencesDataSetTableAdapters.localisationTableAdapter()
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
        Me.NiveauDeProduction = New System.Windows.Forms.ComboBox()
        Me.NiveauinstitutionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Magasin = New System.Windows.Forms.ComboBox()
        Me.MagasinBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Localisation = New System.Windows.Forms.ComboBox()
        Me.DateProduction = New System.Windows.Forms.DateTimePicker()
        Me.PrixUnitaire = New System.Windows.Forms.NumericUpDown()
        Me.QuantiteProduite = New System.Windows.Forms.NumericUpDown()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SemencesDataSet1 = New SUPSEMENCE.semencesDataSet()
        Me.SemencesDataSet2 = New SUPSEMENCE.semencesDataSet()
        Me.VarieteinstitutionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ContextMenuProduction = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuItemModifier = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SupprimerMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip2 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ModifierToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SupprimerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Niveau_institutionTableAdapter = New SUPSEMENCE.semencesDataSetTableAdapters.niveau_institutionTableAdapter()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SemencesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LocalisationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VarieteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NiveauinstitutionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MagasinBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PrixUnitaire, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.QuantiteProduite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SemencesDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SemencesDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VarieteinstitutionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuProduction.SuspendLayout()
        Me.ContextMenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ClientTableAdapter
        '
        Me.ClientTableAdapter.ClearBeforeFill = True
        '
        'Enregistrer
        '
        Me.Enregistrer.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Enregistrer.FlatAppearance.BorderSize = 0
        Me.Enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Enregistrer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Enregistrer.ForeColor = System.Drawing.Color.White
        Me.Enregistrer.Location = New System.Drawing.Point(26, 510)
        Me.Enregistrer.Margin = New System.Windows.Forms.Padding(2)
        Me.Enregistrer.Name = "Enregistrer"
        Me.Enregistrer.Size = New System.Drawing.Size(508, 67)
        Me.Enregistrer.TabIndex = 29
        Me.Enregistrer.Text = "Enregistrer modification"
        Me.Enregistrer.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(443, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(117, 81)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(566, 88)
        Me.Panel1.TabIndex = 28
        '
        'ClientBindingSource
        '
        Me.ClientBindingSource.DataMember = "client"
        Me.ClientBindingSource.DataSource = Me.SemencesDataSet
        '
        'SemencesDataSet
        '
        Me.SemencesDataSet.DataSetName = "semencesDataSet"
        Me.SemencesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'LocalisationBindingSource
        '
        Me.LocalisationBindingSource.DataMember = "localisation"
        Me.LocalisationBindingSource.DataSource = Me.SemencesDataSet
        '
        'LocalisationTableAdapter
        '
        Me.LocalisationTableAdapter.ClearBeforeFill = True
        '
        'ZoneProduction
        '
        Me.ZoneProduction.AutoSize = True
        Me.ZoneProduction.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZoneProduction.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.ZoneProduction.Location = New System.Drawing.Point(229, 248)
        Me.ZoneProduction.Name = "ZoneProduction"
        Me.ZoneProduction.Size = New System.Drawing.Size(0, 15)
        Me.ZoneProduction.TabIndex = 44
        Me.ZoneProduction.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(22, 475)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 20)
        Me.Label9.TabIndex = 43
        Me.Label9.Text = "Variété"
        '
        'ChoixVariete
        '
        Me.ChoixVariete.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ChoixVariete.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ChoixVariete.DataSource = Me.VarieteBindingSource
        Me.ChoixVariete.Enabled = False
        Me.ChoixVariete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ChoixVariete.FormattingEnabled = True
        Me.ChoixVariete.Location = New System.Drawing.Point(232, 469)
        Me.ChoixVariete.Name = "ChoixVariete"
        Me.ChoixVariete.Size = New System.Drawing.Size(302, 28)
        Me.ChoixVariete.TabIndex = 42
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(22, 414)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(183, 20)
        Me.Label8.TabIndex = 41
        Me.Label8.Text = "Niveau des semences"
        '
        'DateProductionLabel
        '
        Me.DateProductionLabel.AutoSize = True
        Me.DateProductionLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateProductionLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.DateProductionLabel.Location = New System.Drawing.Point(22, 353)
        Me.DateProductionLabel.Name = "DateProductionLabel"
        Me.DateProductionLabel.Size = New System.Drawing.Size(163, 20)
        Me.DateProductionLabel.TabIndex = 40
        Me.DateProductionLabel.Text = "Date de production"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(22, 225)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(157, 20)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Localité de culture"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(22, 292)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(179, 20)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Magasin de stockage"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(22, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 20)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Prix (FCFA/KG)"
        '
        'QuantiteProduiteLabel
        '
        Me.QuantiteProduiteLabel.AutoSize = True
        Me.QuantiteProduiteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantiteProduiteLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.QuantiteProduiteLabel.Location = New System.Drawing.Point(22, 103)
        Me.QuantiteProduiteLabel.Name = "QuantiteProduiteLabel"
        Me.QuantiteProduiteLabel.Size = New System.Drawing.Size(191, 20)
        Me.QuantiteProduiteLabel.TabIndex = 36
        Me.QuantiteProduiteLabel.Text = "Quantité produite (KG)"
        '
        'NiveauDeProduction
        '
        Me.NiveauDeProduction.DataSource = Me.NiveauinstitutionBindingSource
        Me.NiveauDeProduction.DisplayMember = "id_niveau"
        Me.NiveauDeProduction.Enabled = False
        Me.NiveauDeProduction.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NiveauDeProduction.FormattingEnabled = True
        Me.NiveauDeProduction.Location = New System.Drawing.Point(232, 407)
        Me.NiveauDeProduction.Name = "NiveauDeProduction"
        Me.NiveauDeProduction.Size = New System.Drawing.Size(302, 28)
        Me.NiveauDeProduction.TabIndex = 35
        Me.NiveauDeProduction.ValueMember = "id_niveau"
        '
        'Magasin
        '
        Me.Magasin.DataSource = Me.MagasinBindingSource
        Me.Magasin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Magasin.FormattingEnabled = True
        Me.Magasin.Location = New System.Drawing.Point(232, 285)
        Me.Magasin.Name = "Magasin"
        Me.Magasin.Size = New System.Drawing.Size(302, 28)
        Me.Magasin.TabIndex = 34
        '
        'Localisation
        '
        Me.Localisation.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.Localisation.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Localisation.DataSource = Me.LocalisationBindingSource
        Me.Localisation.DisplayMember = "village"
        Me.Localisation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Localisation.FormattingEnabled = True
        Me.Localisation.Location = New System.Drawing.Point(232, 217)
        Me.Localisation.Name = "Localisation"
        Me.Localisation.Size = New System.Drawing.Size(302, 28)
        Me.Localisation.TabIndex = 33
        Me.Localisation.ValueMember = "id_localisation"
        '
        'DateProduction
        '
        Me.DateProduction.Enabled = False
        Me.DateProduction.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateProduction.Location = New System.Drawing.Point(232, 347)
        Me.DateProduction.Name = "DateProduction"
        Me.DateProduction.Size = New System.Drawing.Size(302, 26)
        Me.DateProduction.TabIndex = 32
        '
        'PrixUnitaire
        '
        Me.PrixUnitaire.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PrixUnitaire.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.PrixUnitaire.Location = New System.Drawing.Point(232, 157)
        Me.PrixUnitaire.Maximum = New Decimal(New Integer() {1215752192, 23, 0, 0})
        Me.PrixUnitaire.Name = "PrixUnitaire"
        Me.PrixUnitaire.Size = New System.Drawing.Size(302, 26)
        Me.PrixUnitaire.TabIndex = 31
        '
        'QuantiteProduite
        '
        Me.QuantiteProduite.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.QuantiteProduite.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.QuantiteProduite.Location = New System.Drawing.Point(232, 97)
        Me.QuantiteProduite.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.QuantiteProduite.Name = "QuantiteProduite"
        Me.QuantiteProduite.Size = New System.Drawing.Size(302, 26)
        Me.QuantiteProduite.TabIndex = 30
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "localisation"
        Me.BindingSource1.DataSource = Me.SemencesDataSet1
        '
        'SemencesDataSet1
        '
        Me.SemencesDataSet1.DataSetName = "semencesDataSet"
        Me.SemencesDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SemencesDataSet2
        '
        Me.SemencesDataSet2.DataSetName = "semencesDataSet"
        Me.SemencesDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VarieteinstitutionBindingSource
        '
        Me.VarieteinstitutionBindingSource.DataMember = "variete_institution"
        Me.VarieteinstitutionBindingSource.DataSource = Me.SemencesDataSet2
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
        'FormUpdateProduction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(566, 588)
        Me.Controls.Add(Me.ZoneProduction)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.ChoixVariete)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DateProductionLabel)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.QuantiteProduiteLabel)
        Me.Controls.Add(Me.NiveauDeProduction)
        Me.Controls.Add(Me.Magasin)
        Me.Controls.Add(Me.Localisation)
        Me.Controls.Add(Me.DateProduction)
        Me.Controls.Add(Me.PrixUnitaire)
        Me.Controls.Add(Me.QuantiteProduite)
        Me.Controls.Add(Me.Enregistrer)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FormUpdateProduction"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modification production"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SemencesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LocalisationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VarieteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NiveauinstitutionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MagasinBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PrixUnitaire, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.QuantiteProduite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SemencesDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SemencesDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VarieteinstitutionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuProduction.ResumeLayout(False)
        Me.ContextMenuStrip2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ClientTableAdapter As semencesDataSetTableAdapters.clientTableAdapter
    Friend WithEvents Enregistrer As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ClientBindingSource As BindingSource
    Friend WithEvents SemencesDataSet As semencesDataSet
    Friend WithEvents LocalisationBindingSource As BindingSource
    Friend WithEvents LocalisationTableAdapter As semencesDataSetTableAdapters.localisationTableAdapter
    Friend WithEvents ZoneProduction As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents ChoixVariete As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents DateProductionLabel As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents QuantiteProduiteLabel As Label
    Friend WithEvents NiveauDeProduction As ComboBox
    Friend WithEvents Magasin As ComboBox
    Friend WithEvents Localisation As ComboBox
    Friend WithEvents DateProduction As DateTimePicker
    Friend WithEvents PrixUnitaire As NumericUpDown
    Friend WithEvents QuantiteProduite As NumericUpDown
    Friend WithEvents VarieteBindingSource As BindingSource
    Friend WithEvents NiveauinstitutionBindingSource As BindingSource
    Friend WithEvents MagasinBindingSource As BindingSource
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents SemencesDataSet1 As semencesDataSet
    Friend WithEvents SemencesDataSet2 As semencesDataSet
    Friend WithEvents VarieteinstitutionBindingSource As BindingSource
    Friend WithEvents ContextMenuProduction As ContextMenuStrip
    Friend WithEvents MenuItemModifier As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents SupprimerMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStrip2 As ContextMenuStrip
    Friend WithEvents ModifierToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SupprimerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Niveau_institutionTableAdapter As semencesDataSetTableAdapters.niveau_institutionTableAdapter
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUpdateCommande
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUpdateCommande))
        Me.LocalisationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SemencesDataSet = New SUPSEMENCE.semencesDataSet()
        Me.ClientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.LocalisationTableAdapter = New SUPSEMENCE.semencesDataSetTableAdapters.localisationTableAdapter()
        Me.ClientTableAdapter = New SUPSEMENCE.semencesDataSetTableAdapters.clientTableAdapter()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DateExpressionBesoin = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Speculation = New System.Windows.Forms.ComboBox()
        Me.Production = New System.Windows.Forms.ComboBox()
        Me.ProductionBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MagasinEnlevement = New System.Windows.Forms.ComboBox()
        Me.EnregistrerCommande = New System.Windows.Forms.Button()
        Me.Client = New System.Windows.Forms.ComboBox()
        Me.DateEnlevement = New System.Windows.Forms.DateTimePicker()
        Me.Montant = New System.Windows.Forms.NumericUpDown()
        Me.Quantite = New System.Windows.Forms.NumericUpDown()
        Me.ProductionTableAdapter = New SUPSEMENCE.semencesDataSetTableAdapters.productionTableAdapter()
        CType(Me.LocalisationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SemencesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductionBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Montant, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Quantite, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LocalisationBindingSource
        '
        Me.LocalisationBindingSource.DataMember = "localisation"
        Me.LocalisationBindingSource.DataSource = Me.SemencesDataSet
        '
        'SemencesDataSet
        '
        Me.SemencesDataSet.DataSetName = "semencesDataSet"
        Me.SemencesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientBindingSource
        '
        Me.ClientBindingSource.DataMember = "client"
        Me.ClientBindingSource.DataSource = Me.SemencesDataSet
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(580, 88)
        Me.Panel1.TabIndex = 45
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(416, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(117, 81)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'LocalisationTableAdapter
        '
        Me.LocalisationTableAdapter.ClearBeforeFill = True
        '
        'ClientTableAdapter
        '
        Me.ClientTableAdapter.ClearBeforeFill = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(38, 332)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(206, 16)
        Me.Label10.TabIndex = 64
        Me.Label10.Text = "Date d'expression du besoin"
        '
        'DateExpressionBesoin
        '
        Me.DateExpressionBesoin.Enabled = False
        Me.DateExpressionBesoin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateExpressionBesoin.Location = New System.Drawing.Point(257, 327)
        Me.DateExpressionBesoin.Name = "DateExpressionBesoin"
        Me.DateExpressionBesoin.Size = New System.Drawing.Size(253, 22)
        Me.DateExpressionBesoin.TabIndex = 63
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(516, 245)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 16)
        Me.Label9.TabIndex = 62
        Me.Label9.Text = "FCFA"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(516, 203)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 16)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "KG"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(41, 419)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(164, 16)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "Magasin d'enlèvement"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(38, 291)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 16)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "Client "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(38, 374)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(203, 16)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Date enlèvement demandée"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(39, 245)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(166, 16)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "Montant correspondant"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(38, 203)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(154, 16)
        Me.Label3.TabIndex = 56
        Me.Label3.Text = "Quantité commandée"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(38, 161)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(203, 16)
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Spéculation correspondante"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(38, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(171, 16)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "Production commandée"
        '
        'Speculation
        '
        Me.Speculation.DataSource = Me.ProductionBindingSource
        Me.Speculation.Enabled = False
        Me.Speculation.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Speculation.FormattingEnabled = True
        Me.Speculation.Location = New System.Drawing.Point(257, 153)
        Me.Speculation.Name = "Speculation"
        Me.Speculation.Size = New System.Drawing.Size(253, 24)
        Me.Speculation.TabIndex = 53
        '
        'Production
        '
        Me.Production.DataSource = Me.ProductionBindingSource
        Me.Production.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Production.FormattingEnabled = True
        Me.Production.Location = New System.Drawing.Point(257, 109)
        Me.Production.Name = "Production"
        Me.Production.Size = New System.Drawing.Size(253, 24)
        Me.Production.TabIndex = 52
        '
        'ProductionBindingSource
        '
        Me.ProductionBindingSource.DataMember = "production"
        Me.ProductionBindingSource.DataSource = Me.SemencesDataSet
        '
        'MagasinEnlevement
        '
        Me.MagasinEnlevement.DataSource = Me.ProductionBindingSource
        Me.MagasinEnlevement.Enabled = False
        Me.MagasinEnlevement.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MagasinEnlevement.FormattingEnabled = True
        Me.MagasinEnlevement.Location = New System.Drawing.Point(257, 411)
        Me.MagasinEnlevement.Name = "MagasinEnlevement"
        Me.MagasinEnlevement.Size = New System.Drawing.Size(253, 24)
        Me.MagasinEnlevement.TabIndex = 51
        '
        'EnregistrerCommande
        '
        Me.EnregistrerCommande.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.EnregistrerCommande.FlatAppearance.BorderSize = 0
        Me.EnregistrerCommande.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.EnregistrerCommande.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EnregistrerCommande.ForeColor = System.Drawing.Color.White
        Me.EnregistrerCommande.Image = CType(resources.GetObject("EnregistrerCommande.Image"), System.Drawing.Image)
        Me.EnregistrerCommande.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.EnregistrerCommande.Location = New System.Drawing.Point(42, 468)
        Me.EnregistrerCommande.Margin = New System.Windows.Forms.Padding(2, 0, 2, 2)
        Me.EnregistrerCommande.Name = "EnregistrerCommande"
        Me.EnregistrerCommande.Padding = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.EnregistrerCommande.Size = New System.Drawing.Size(468, 64)
        Me.EnregistrerCommande.TabIndex = 50
        Me.EnregistrerCommande.Text = " Enregistrer modification"
        Me.EnregistrerCommande.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.EnregistrerCommande.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.EnregistrerCommande.UseVisualStyleBackColor = False
        '
        'Client
        '
        Me.Client.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Client.DataSource = Me.ClientBindingSource
        Me.Client.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Client.ForeColor = System.Drawing.Color.White
        Me.Client.FormattingEnabled = True
        Me.Client.Location = New System.Drawing.Point(257, 281)
        Me.Client.Name = "Client"
        Me.Client.Size = New System.Drawing.Size(253, 26)
        Me.Client.TabIndex = 49
        '
        'DateEnlevement
        '
        Me.DateEnlevement.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateEnlevement.Location = New System.Drawing.Point(257, 369)
        Me.DateEnlevement.Name = "DateEnlevement"
        Me.DateEnlevement.Size = New System.Drawing.Size(253, 22)
        Me.DateEnlevement.TabIndex = 48
        '
        'Montant
        '
        Me.Montant.Enabled = False
        Me.Montant.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Montant.Location = New System.Drawing.Point(257, 239)
        Me.Montant.Maximum = New Decimal(New Integer() {-727379968, 232, 0, 0})
        Me.Montant.Name = "Montant"
        Me.Montant.Size = New System.Drawing.Size(253, 22)
        Me.Montant.TabIndex = 47
        '
        'Quantite
        '
        Me.Quantite.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quantite.Increment = New Decimal(New Integer() {100, 0, 0, 0})
        Me.Quantite.Location = New System.Drawing.Point(257, 197)
        Me.Quantite.Maximum = New Decimal(New Integer() {1000000000, 0, 0, 0})
        Me.Quantite.Name = "Quantite"
        Me.Quantite.Size = New System.Drawing.Size(253, 22)
        Me.Quantite.TabIndex = 46
        '
        'ProductionTableAdapter
        '
        Me.ProductionTableAdapter.ClearBeforeFill = True
        '
        'FormUpdateCommande
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(580, 556)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.DateExpressionBesoin)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Speculation)
        Me.Controls.Add(Me.Production)
        Me.Controls.Add(Me.MagasinEnlevement)
        Me.Controls.Add(Me.EnregistrerCommande)
        Me.Controls.Add(Me.Client)
        Me.Controls.Add(Me.DateEnlevement)
        Me.Controls.Add(Me.Montant)
        Me.Controls.Add(Me.Quantite)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FormUpdateCommande"
        Me.Text = "Modification commande"
        CType(Me.LocalisationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SemencesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductionBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Montant, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Quantite, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LocalisationBindingSource As BindingSource
    Friend WithEvents SemencesDataSet As semencesDataSet
    Friend WithEvents ClientBindingSource As BindingSource
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents LocalisationTableAdapter As semencesDataSetTableAdapters.localisationTableAdapter
    Friend WithEvents ClientTableAdapter As semencesDataSetTableAdapters.clientTableAdapter
    Friend WithEvents Label10 As Label
    Friend WithEvents DateExpressionBesoin As DateTimePicker
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Speculation As ComboBox
    Friend WithEvents Production As ComboBox
    Friend WithEvents MagasinEnlevement As ComboBox
    Friend WithEvents EnregistrerCommande As Button
    Friend WithEvents Client As ComboBox
    Friend WithEvents DateEnlevement As DateTimePicker
    Friend WithEvents Montant As NumericUpDown
    Friend WithEvents Quantite As NumericUpDown
    Friend WithEvents ProductionBindingSource As BindingSource
    Friend WithEvents ProductionTableAdapter As semencesDataSetTableAdapters.productionTableAdapter
End Class

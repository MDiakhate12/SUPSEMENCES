<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormContact
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormContact))
        Me.Nom = New System.Windows.Forms.TextBox()
        Me.Prenom = New System.Windows.Forms.TextBox()
        Me.Telephone = New System.Windows.Forms.TextBox()
        Me.Mail = New System.Windows.Forms.TextBox()
        Me.Localisation = New System.Windows.Forms.ComboBox()
        Me.LocalisationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SemencesDataSet = New SUPSEMENCE.semencesDataSet()
        Me.Client = New System.Windows.Forms.ComboBox()
        Me.ClientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NomLabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Enregistrer = New System.Windows.Forms.Button()
        Me.LocalisationTableAdapter = New SUPSEMENCE.semencesDataSetTableAdapters.localisationTableAdapter()
        Me.ClientTableAdapter = New SUPSEMENCE.semencesDataSetTableAdapters.clientTableAdapter()
        CType(Me.LocalisationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SemencesDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Nom
        '
        Me.Nom.Location = New System.Drawing.Point(131, 102)
        Me.Nom.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Nom.Name = "Nom"
        Me.Nom.Size = New System.Drawing.Size(223, 26)
        Me.Nom.TabIndex = 1
        '
        'Prenom
        '
        Me.Prenom.Location = New System.Drawing.Point(131, 142)
        Me.Prenom.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Prenom.Name = "Prenom"
        Me.Prenom.Size = New System.Drawing.Size(223, 26)
        Me.Prenom.TabIndex = 2
        '
        'Telephone
        '
        Me.Telephone.Location = New System.Drawing.Point(131, 182)
        Me.Telephone.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Telephone.Name = "Telephone"
        Me.Telephone.Size = New System.Drawing.Size(223, 26)
        Me.Telephone.TabIndex = 4
        '
        'Mail
        '
        Me.Mail.Location = New System.Drawing.Point(131, 222)
        Me.Mail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Mail.Name = "Mail"
        Me.Mail.Size = New System.Drawing.Size(223, 26)
        Me.Mail.TabIndex = 5
        '
        'Localisation
        '
        Me.Localisation.DataSource = Me.LocalisationBindingSource
        Me.Localisation.DisplayMember = "village"
        Me.Localisation.FormattingEnabled = True
        Me.Localisation.Location = New System.Drawing.Point(131, 262)
        Me.Localisation.Name = "Localisation"
        Me.Localisation.Size = New System.Drawing.Size(223, 28)
        Me.Localisation.TabIndex = 6
        Me.Localisation.ValueMember = "id_localisation"
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
        'Client
        '
        Me.Client.DataSource = Me.ClientBindingSource
        Me.Client.DisplayMember = "nom_complet_structure"
        Me.Client.FormattingEnabled = True
        Me.Client.Location = New System.Drawing.Point(131, 304)
        Me.Client.Name = "Client"
        Me.Client.Size = New System.Drawing.Size(223, 28)
        Me.Client.TabIndex = 7
        Me.Client.ValueMember = "id_client"
        '
        'ClientBindingSource
        '
        Me.ClientBindingSource.DataMember = "client"
        Me.ClientBindingSource.DataSource = Me.SemencesDataSet
        '
        'NomLabel
        '
        Me.NomLabel.AutoSize = True
        Me.NomLabel.Location = New System.Drawing.Point(25, 108)
        Me.NomLabel.Name = "NomLabel"
        Me.NomLabel.Size = New System.Drawing.Size(42, 20)
        Me.NomLabel.TabIndex = 8
        Me.NomLabel.Text = "Nom"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Prenom"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 186)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 20)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Téléphone"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 225)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Mail"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 264)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 20)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Localité"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 303)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 20)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Client"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(386, 76)
        Me.Panel1.TabIndex = 14
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(275, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 70)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Enregistrer
        '
        Me.Enregistrer.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Enregistrer.FlatAppearance.BorderSize = 0
        Me.Enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Enregistrer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Enregistrer.ForeColor = System.Drawing.Color.White
        Me.Enregistrer.Location = New System.Drawing.Point(29, 376)
        Me.Enregistrer.Margin = New System.Windows.Forms.Padding(2)
        Me.Enregistrer.Name = "Enregistrer"
        Me.Enregistrer.Size = New System.Drawing.Size(325, 58)
        Me.Enregistrer.TabIndex = 15
        Me.Enregistrer.Text = "Enregistrer"
        Me.Enregistrer.UseVisualStyleBackColor = False
        '
        'LocalisationTableAdapter
        '
        Me.LocalisationTableAdapter.ClearBeforeFill = True
        '
        'ClientTableAdapter
        '
        Me.ClientTableAdapter.ClearBeforeFill = True
        '
        'FormContact
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(386, 461)
        Me.Controls.Add(Me.Enregistrer)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NomLabel)
        Me.Controls.Add(Me.Client)
        Me.Controls.Add(Me.Localisation)
        Me.Controls.Add(Me.Mail)
        Me.Controls.Add(Me.Telephone)
        Me.Controls.Add(Me.Prenom)
        Me.Controls.Add(Me.Nom)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "FormContact"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Contact"
        CType(Me.LocalisationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SemencesDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Nom As TextBox
    Friend WithEvents Prenom As TextBox
    Friend WithEvents Telephone As TextBox
    Friend WithEvents Mail As TextBox
    Friend WithEvents Localisation As ComboBox
    Friend WithEvents Client As ComboBox
    Friend WithEvents NomLabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Enregistrer As Button
    Friend WithEvents SemencesDataSet As semencesDataSet
    Friend WithEvents LocalisationBindingSource As BindingSource
    Friend WithEvents LocalisationTableAdapter As semencesDataSetTableAdapters.localisationTableAdapter
    Friend WithEvents ClientBindingSource As BindingSource
    Friend WithEvents ClientTableAdapter As semencesDataSetTableAdapters.clientTableAdapter
End Class

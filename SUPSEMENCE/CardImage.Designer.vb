<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CardImage
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CardImage))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DateProduction = New System.Windows.Forms.Label()
        Me.LabelProduitLe = New System.Windows.Forms.Label()
        Me.Institution = New System.Windows.Forms.Label()
        Me.Variete = New System.Windows.Forms.Label()
        Me.Cycle = New System.Windows.Forms.Label()
        Me.SiteStockage = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Prix = New System.Windows.Forms.Label()
        Me.Quantite = New System.Windows.Forms.Label()
        Me.ZoneAgro = New System.Windows.Forms.Label()
        Me.TypeStockage = New System.Windows.Forms.Label()
        Me.Speculation = New System.Windows.Forms.Label()
        Me.ImageVariete = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.ImageVariete, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DateProduction)
        Me.Panel1.Controls.Add(Me.LabelProduitLe)
        Me.Panel1.Controls.Add(Me.Institution)
        Me.Panel1.Controls.Add(Me.Variete)
        Me.Panel1.Controls.Add(Me.Cycle)
        Me.Panel1.Controls.Add(Me.SiteStockage)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Quantite)
        Me.Panel1.Controls.Add(Me.ZoneAgro)
        Me.Panel1.Controls.Add(Me.TypeStockage)
        Me.Panel1.Controls.Add(Me.Speculation)
        Me.Panel1.Controls.Add(Me.ImageVariete)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(275, 405)
        Me.Panel1.TabIndex = 0
        '
        'DateProduction
        '
        Me.DateProduction.AutoSize = True
        Me.DateProduction.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateProduction.Location = New System.Drawing.Point(75, 293)
        Me.DateProduction.Name = "DateProduction"
        Me.DateProduction.Size = New System.Drawing.Size(80, 18)
        Me.DateProduction.TabIndex = 22
        Me.DateProduction.Text = "01/02/2020"
        '
        'LabelProduitLe
        '
        Me.LabelProduitLe.AutoSize = True
        Me.LabelProduitLe.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelProduitLe.Location = New System.Drawing.Point(9, 293)
        Me.LabelProduitLe.Name = "LabelProduitLe"
        Me.LabelProduitLe.Size = New System.Drawing.Size(70, 18)
        Me.LabelProduitLe.TabIndex = 21
        Me.LabelProduitLe.Text = "Produit le"
        '
        'Institution
        '
        Me.Institution.AutoSize = True
        Me.Institution.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Institution.Location = New System.Drawing.Point(9, 221)
        Me.Institution.Name = "Institution"
        Me.Institution.Size = New System.Drawing.Size(49, 18)
        Me.Institution.TabIndex = 20
        Me.Institution.Text = "SUPS"
        '
        'Variete
        '
        Me.Variete.AutoSize = True
        Me.Variete.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Variete.Location = New System.Drawing.Point(9, 149)
        Me.Variete.Name = "Variete"
        Me.Variete.Size = New System.Drawing.Size(74, 18)
        Me.Variete.TabIndex = 19
        Me.Variete.Text = "Sahel-108"
        '
        'Cycle
        '
        Me.Cycle.AutoSize = True
        Me.Cycle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Cycle.Location = New System.Drawing.Point(9, 173)
        Me.Cycle.Name = "Cycle"
        Me.Cycle.Size = New System.Drawing.Size(69, 18)
        Me.Cycle.TabIndex = 18
        Me.Cycle.Text = "100 jours"
        '
        'SiteStockage
        '
        Me.SiteStockage.AutoSize = True
        Me.SiteStockage.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SiteStockage.Location = New System.Drawing.Point(9, 269)
        Me.SiteStockage.Name = "SiteStockage"
        Me.SiteStockage.Size = New System.Drawing.Size(50, 18)
        Me.SiteStockage.TabIndex = 17
        Me.SiteStockage.Text = "Kolda "
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Prix)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.ForeColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(0, 350)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(275, 55)
        Me.Panel2.TabIndex = 16
        '
        'Prix
        '
        Me.Prix.AutoSize = True
        Me.Prix.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Prix.ForeColor = System.Drawing.Color.Black
        Me.Prix.Location = New System.Drawing.Point(8, 23)
        Me.Prix.Name = "Prix"
        Me.Prix.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Prix.Size = New System.Drawing.Size(180, 20)
        Me.Prix.TabIndex = 0
        Me.Prix.Text = "150 000 FCFA/Tonne"
        Me.Prix.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Quantite
        '
        Me.Quantite.AutoSize = True
        Me.Quantite.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quantite.Location = New System.Drawing.Point(8, 327)
        Me.Quantite.Name = "Quantite"
        Me.Quantite.Size = New System.Drawing.Size(118, 20)
        Me.Quantite.TabIndex = 15
        Me.Quantite.Text = "134.7 Tonnes"
        Me.Quantite.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ZoneAgro
        '
        Me.ZoneAgro.AutoSize = True
        Me.ZoneAgro.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ZoneAgro.Location = New System.Drawing.Point(9, 245)
        Me.ZoneAgro.Name = "ZoneAgro"
        Me.ZoneAgro.Size = New System.Drawing.Size(120, 18)
        Me.ZoneAgro.TabIndex = 13
        Me.ZoneAgro.Text = "Zone Centre Sud"
        '
        'TypeStockage
        '
        Me.TypeStockage.AutoSize = True
        Me.TypeStockage.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TypeStockage.Location = New System.Drawing.Point(9, 197)
        Me.TypeStockage.Name = "TypeStockage"
        Me.TypeStockage.Size = New System.Drawing.Size(110, 18)
        Me.TypeStockage.TabIndex = 12
        Me.TypeStockage.Text = "Chambre froide"
        '
        'Speculation
        '
        Me.Speculation.AutoSize = True
        Me.Speculation.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Speculation.Location = New System.Drawing.Point(9, 125)
        Me.Speculation.Name = "Speculation"
        Me.Speculation.Size = New System.Drawing.Size(30, 18)
        Me.Speculation.TabIndex = 10
        Me.Speculation.Text = "Riz"
        '
        'ImageVariete
        '
        Me.ImageVariete.Dock = System.Windows.Forms.DockStyle.Top
        Me.ImageVariete.Image = CType(resources.GetObject("ImageVariete.Image"), System.Drawing.Image)
        Me.ImageVariete.Location = New System.Drawing.Point(0, 0)
        Me.ImageVariete.Name = "ImageVariete"
        Me.ImageVariete.Size = New System.Drawing.Size(275, 119)
        Me.ImageVariete.TabIndex = 9
        Me.ImageVariete.TabStop = False
        '
        'CardImage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Controls.Add(Me.Panel1)
        Me.Name = "CardImage"
        Me.Size = New System.Drawing.Size(275, 405)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.ImageVariete, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents SiteStockage As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Prix As Label
    Friend WithEvents Quantite As Label
    Friend WithEvents ZoneAgro As Label
    Friend WithEvents TypeStockage As Label
    Friend WithEvents Speculation As Label
    Friend WithEvents ImageVariete As PictureBox
    Friend WithEvents Cycle As Label
    Friend WithEvents Variete As Label
    Friend WithEvents Institution As Label
    Friend WithEvents LabelProduitLe As Label
    Friend WithEvents DateProduction As Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormStockCard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormStockCard))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.LabelStockDeSecurite = New System.Windows.Forms.Label()
        Me.Quantite = New System.Windows.Forms.Label()
        Me.Image = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.LabelSpeculation = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.SupprimerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel3.SuspendLayout()
        CType(Me.Image, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.LabelStockDeSecurite)
        Me.Panel3.Controls.Add(Me.Quantite)
        Me.Panel3.Controls.Add(Me.Image)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(176, 230)
        Me.Panel3.TabIndex = 1
        '
        'LabelStockDeSecurite
        '
        Me.LabelStockDeSecurite.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelStockDeSecurite.AutoSize = True
        Me.LabelStockDeSecurite.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelStockDeSecurite.ForeColor = System.Drawing.Color.Firebrick
        Me.LabelStockDeSecurite.Location = New System.Drawing.Point(10, 137)
        Me.LabelStockDeSecurite.Name = "LabelStockDeSecurite"
        Me.LabelStockDeSecurite.Size = New System.Drawing.Size(137, 19)
        Me.LabelStockDeSecurite.TabIndex = 5
        Me.LabelStockDeSecurite.Text = "Stock Sécurité"
        Me.LabelStockDeSecurite.Visible = False
        '
        'Quantite
        '
        Me.Quantite.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Quantite.AutoSize = True
        Me.Quantite.Font = New System.Drawing.Font("Stencil", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quantite.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Quantite.Location = New System.Drawing.Point(3, 102)
        Me.Quantite.Margin = New System.Windows.Forms.Padding(3, 4, 3, 0)
        Me.Quantite.Name = "Quantite"
        Me.Quantite.Size = New System.Drawing.Size(214, 57)
        Me.Quantite.TabIndex = 2
        Me.Quantite.Text = "2500 KG"
        '
        'Image
        '
        Me.Image.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Image.Dock = System.Windows.Forms.DockStyle.Top
        Me.Image.Image = CType(resources.GetObject("Image.Image"), System.Drawing.Image)
        Me.Image.Location = New System.Drawing.Point(0, 0)
        Me.Image.Name = "Image"
        Me.Image.Size = New System.Drawing.Size(176, 98)
        Me.Image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Image.TabIndex = 1
        Me.Image.TabStop = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Panel4.Controls.Add(Me.LabelSpeculation)
        Me.Panel4.Controls.Add(Me.Label)
        Me.Panel4.Controls.Add(Me.Panel5)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 156)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(176, 74)
        Me.Panel4.TabIndex = 0
        '
        'LabelSpeculation
        '
        Me.LabelSpeculation.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LabelSpeculation.AutoSize = True
        Me.LabelSpeculation.Font = New System.Drawing.Font("Stencil", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelSpeculation.ForeColor = System.Drawing.Color.White
        Me.LabelSpeculation.Location = New System.Drawing.Point(4, 44)
        Me.LabelSpeculation.Name = "LabelSpeculation"
        Me.LabelSpeculation.Size = New System.Drawing.Size(0, 19)
        Me.LabelSpeculation.TabIndex = 4
        Me.LabelSpeculation.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label
        '
        Me.Label.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label.AutoSize = True
        Me.Label.Font = New System.Drawing.Font("Stencil", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label.ForeColor = System.Drawing.Color.Linen
        Me.Label.Location = New System.Drawing.Point(4, 14)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(196, 34)
        Me.Label.TabIndex = 3
        Me.Label.Text = "Total Stock"
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 63)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(176, 11)
        Me.Panel5.TabIndex = 1
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SupprimerToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(181, 48)
        '
        'SupprimerToolStripMenuItem
        '
        Me.SupprimerToolStripMenuItem.Name = "SupprimerToolStripMenuItem"
        Me.SupprimerToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SupprimerToolStripMenuItem.Text = "Supprimer"
        '
        'FormStockCard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(176, 230)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximumSize = New System.Drawing.Size(225, 244)
        Me.Name = "FormStockCard"
        Me.Text = "FormStockCard"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.Image, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents Quantite As Label
    Friend WithEvents Image As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents LabelSpeculation As Label
    Friend WithEvents LabelStockDeSecurite As Label
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents SupprimerToolStripMenuItem As ToolStripMenuItem
End Class

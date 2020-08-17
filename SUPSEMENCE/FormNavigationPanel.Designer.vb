<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormNavigationPanel
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.CurrentPageMarker = New System.Windows.Forms.Panel()
        Me.ButtonStockVariete = New System.Windows.Forms.Button()
        Me.ButtonStockSpeculation = New System.Windows.Forms.Button()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.Panel3.Controls.Add(Me.CurrentPageMarker)
        Me.Panel3.Controls.Add(Me.ButtonStockVariete)
        Me.Panel3.Controls.Add(Me.ButtonStockSpeculation)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(612, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(188, 450)
        Me.Panel3.TabIndex = 1
        '
        'CurrentPageMarker
        '
        Me.CurrentPageMarker.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CurrentPageMarker.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.CurrentPageMarker.Location = New System.Drawing.Point(175, 0)
        Me.CurrentPageMarker.Margin = New System.Windows.Forms.Padding(2)
        Me.CurrentPageMarker.Name = "CurrentPageMarker"
        Me.CurrentPageMarker.Size = New System.Drawing.Size(14, 41)
        Me.CurrentPageMarker.TabIndex = 10
        '
        'ButtonStockVariete
        '
        Me.ButtonStockVariete.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.ButtonStockVariete.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonStockVariete.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.ButtonStockVariete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.ButtonStockVariete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonStockVariete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonStockVariete.ForeColor = System.Drawing.Color.White
        Me.ButtonStockVariete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonStockVariete.Location = New System.Drawing.Point(0, 41)
        Me.ButtonStockVariete.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonStockVariete.Name = "ButtonStockVariete"
        Me.ButtonStockVariete.Size = New System.Drawing.Size(188, 41)
        Me.ButtonStockVariete.TabIndex = 8
        Me.ButtonStockVariete.Text = "Par Variété"
        Me.ButtonStockVariete.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonStockVariete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonStockVariete.UseVisualStyleBackColor = False
        '
        'ButtonStockSpeculation
        '
        Me.ButtonStockSpeculation.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.ButtonStockSpeculation.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonStockSpeculation.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.ButtonStockSpeculation.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.ButtonStockSpeculation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonStockSpeculation.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonStockSpeculation.ForeColor = System.Drawing.Color.White
        Me.ButtonStockSpeculation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonStockSpeculation.Location = New System.Drawing.Point(0, 0)
        Me.ButtonStockSpeculation.Margin = New System.Windows.Forms.Padding(0)
        Me.ButtonStockSpeculation.Name = "ButtonStockSpeculation"
        Me.ButtonStockSpeculation.Size = New System.Drawing.Size(188, 41)
        Me.ButtonStockSpeculation.TabIndex = 7
        Me.ButtonStockSpeculation.Text = "Par Spéculation"
        Me.ButtonStockSpeculation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonStockSpeculation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonStockSpeculation.UseVisualStyleBackColor = False
        '
        'FormNavigationPanel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "FormNavigationPanel"
        Me.Text = "FormNavigationPanel"
        Me.Panel3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel3 As Panel
    Friend WithEvents CurrentPageMarker As Panel
    Friend WithEvents ButtonStockVariete As Button
    Friend WithEvents ButtonStockSpeculation As Button
End Class

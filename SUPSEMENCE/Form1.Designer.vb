<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.SideMenu = New System.Windows.Forms.Panel()
        Me.CurrentPageMarker = New System.Windows.Forms.Panel()
        Me.ButtonStats = New System.Windows.Forms.Button()
        Me.ButtonParam = New System.Windows.Forms.Button()
        Me.ButtonCommandes = New System.Windows.Forms.Button()
        Me.ButtonProductions = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TopMenu = New System.Windows.Forms.Panel()
        Me.BodyPanel = New System.Windows.Forms.Panel()
        Me.SideMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'SideMenu
        '
        Me.SideMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.SideMenu.Controls.Add(Me.CurrentPageMarker)
        Me.SideMenu.Controls.Add(Me.ButtonStats)
        Me.SideMenu.Controls.Add(Me.ButtonParam)
        Me.SideMenu.Controls.Add(Me.ButtonCommandes)
        Me.SideMenu.Controls.Add(Me.ButtonProductions)
        Me.SideMenu.Controls.Add(Me.Panel1)
        Me.SideMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.SideMenu.Location = New System.Drawing.Point(0, 0)
        Me.SideMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.SideMenu.Name = "SideMenu"
        Me.SideMenu.Size = New System.Drawing.Size(235, 819)
        Me.SideMenu.TabIndex = 0
        '
        'CurrentPageMarker
        '
        Me.CurrentPageMarker.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.CurrentPageMarker.Location = New System.Drawing.Point(0, 67)
        Me.CurrentPageMarker.Margin = New System.Windows.Forms.Padding(2)
        Me.CurrentPageMarker.Name = "CurrentPageMarker"
        Me.CurrentPageMarker.Size = New System.Drawing.Size(14, 67)
        Me.CurrentPageMarker.TabIndex = 7
        '
        'ButtonStats
        '
        Me.ButtonStats.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.ButtonStats.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonStats.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonStats.FlatAppearance.BorderSize = 0
        Me.ButtonStats.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue
        Me.ButtonStats.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonStats.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonStats.ForeColor = System.Drawing.Color.White
        Me.ButtonStats.Image = CType(resources.GetObject("ButtonStats.Image"), System.Drawing.Image)
        Me.ButtonStats.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonStats.Location = New System.Drawing.Point(0, 265)
        Me.ButtonStats.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonStats.Name = "ButtonStats"
        Me.ButtonStats.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.ButtonStats.Size = New System.Drawing.Size(235, 66)
        Me.ButtonStats.TabIndex = 6
        Me.ButtonStats.Text = "     Rapports et              Impressions"
        Me.ButtonStats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonStats.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonStats.UseVisualStyleBackColor = False
        '
        'ButtonParam
        '
        Me.ButtonParam.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.ButtonParam.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonParam.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonParam.FlatAppearance.BorderSize = 0
        Me.ButtonParam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue
        Me.ButtonParam.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonParam.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonParam.ForeColor = System.Drawing.Color.White
        Me.ButtonParam.Image = CType(resources.GetObject("ButtonParam.Image"), System.Drawing.Image)
        Me.ButtonParam.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonParam.Location = New System.Drawing.Point(0, 199)
        Me.ButtonParam.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonParam.Name = "ButtonParam"
        Me.ButtonParam.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.ButtonParam.Size = New System.Drawing.Size(235, 66)
        Me.ButtonParam.TabIndex = 5
        Me.ButtonParam.Text = "     Paramétres"
        Me.ButtonParam.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonParam.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonParam.UseVisualStyleBackColor = False
        '
        'ButtonCommandes
        '
        Me.ButtonCommandes.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.ButtonCommandes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonCommandes.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonCommandes.FlatAppearance.BorderSize = 0
        Me.ButtonCommandes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue
        Me.ButtonCommandes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonCommandes.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonCommandes.ForeColor = System.Drawing.Color.White
        Me.ButtonCommandes.Image = CType(resources.GetObject("ButtonCommandes.Image"), System.Drawing.Image)
        Me.ButtonCommandes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonCommandes.Location = New System.Drawing.Point(0, 133)
        Me.ButtonCommandes.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonCommandes.Name = "ButtonCommandes"
        Me.ButtonCommandes.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.ButtonCommandes.Size = New System.Drawing.Size(235, 66)
        Me.ButtonCommandes.TabIndex = 4
        Me.ButtonCommandes.Text = "     Commandes"
        Me.ButtonCommandes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonCommandes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonCommandes.UseVisualStyleBackColor = False
        '
        'ButtonProductions
        '
        Me.ButtonProductions.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(76, Byte), Integer))
        Me.ButtonProductions.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ButtonProductions.Dock = System.Windows.Forms.DockStyle.Top
        Me.ButtonProductions.FlatAppearance.BorderSize = 0
        Me.ButtonProductions.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PowderBlue
        Me.ButtonProductions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButtonProductions.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ButtonProductions.ForeColor = System.Drawing.Color.White
        Me.ButtonProductions.Image = CType(resources.GetObject("ButtonProductions.Image"), System.Drawing.Image)
        Me.ButtonProductions.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonProductions.Location = New System.Drawing.Point(0, 67)
        Me.ButtonProductions.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonProductions.Name = "ButtonProductions"
        Me.ButtonProductions.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.ButtonProductions.Size = New System.Drawing.Size(235, 66)
        Me.ButtonProductions.TabIndex = 3
        Me.ButtonProductions.Text = "     Productions"
        Me.ButtonProductions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ButtonProductions.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.ButtonProductions.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(55, Byte), Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(235, 67)
        Me.Panel1.TabIndex = 0
        '
        'TopMenu
        '
        Me.TopMenu.BackColor = System.Drawing.Color.FromArgb(CType(CType(118, Byte), Integer), CType(CType(209, Byte), Integer), CType(CType(125, Byte), Integer))
        Me.TopMenu.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopMenu.Location = New System.Drawing.Point(235, 0)
        Me.TopMenu.Margin = New System.Windows.Forms.Padding(2)
        Me.TopMenu.Name = "TopMenu"
        Me.TopMenu.Size = New System.Drawing.Size(1149, 67)
        Me.TopMenu.TabIndex = 1
        '
        'BodyPanel
        '
        Me.BodyPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BodyPanel.Location = New System.Drawing.Point(235, 67)
        Me.BodyPanel.Margin = New System.Windows.Forms.Padding(2)
        Me.BodyPanel.Name = "BodyPanel"
        Me.BodyPanel.Size = New System.Drawing.Size(1149, 752)
        Me.BodyPanel.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1384, 819)
        Me.Controls.Add(Me.BodyPanel)
        Me.Controls.Add(Me.TopMenu)
        Me.Controls.Add(Me.SideMenu)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimumSize = New System.Drawing.Size(1400, 858)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SideMenu.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SideMenu As Panel
    Friend WithEvents TopMenu As Panel
    Friend WithEvents ButtonProductions As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ButtonStats As Button
    Friend WithEvents ButtonParam As Button
    Friend WithEvents ButtonCommandes As Button
    Friend WithEvents BodyPanel As Panel
    Friend WithEvents CurrentPageMarker As Panel
End Class

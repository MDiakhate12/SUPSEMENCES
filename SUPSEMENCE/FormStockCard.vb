Imports MySql.Data.MySqlClient

Public Class FormStockCard

    Private connection = DBConnection.connection
    Public id
    Private nom_speculation As String
    Private card As Control

    Private Sub Image_Click(sender As PictureBox, e As EventArgs) Handles Image.Click
        If sender.Parent.Parent.Parent.Name.Equals(FormParametres.SpeculationFlowLayout.Name) Then
            Return
        End If
        OpenVariete(Me.id)
    End Sub

    '' Define the CS_DROPSHADOW constant
    'Private Const CS_DROPSHADOW As Integer = &H20000

    '' Override the CreateParams property

    'Protected Overrides ReadOnly Property CreateParams As CreateParams
    '    Get
    '        Dim cp = MyBase.CreateParams
    '        cp.ClassStyle = CS_DROPSHADOW
    '        Return cp
    '    End Get
    'End Property


    Private Sub OpenVariete(Optional id = "")
        Dim getQuantiteSpeculation As String
        If (id Is String.Empty) Then
            getQuantiteSpeculation = "select nom_variete, sum(quantite_produite) quantite_produite, sum(quantite_disponible) quantite_disponible,  stock_de_securite, nom_speculation
                                        from production
                                        inner join variete_institution on variete_institution.id_variete_institution=production.id_variete_institution
                                        inner join variete on variete.id_variete=variete_institution.id_variete
                                        inner join speculation on speculation.id_speculation=variete.id_speculation
                                        where production.id_institution=@id_institution 
                                        group by nom_variete"

        Else
            getQuantiteSpeculation = "select  nom_variete, sum(quantite_produite) quantite_produite, sum(quantite_disponible) quantite_disponible,  stock_de_securite, nom_speculation
                                        from production
                                        inner join variete_institution on variete_institution.id_variete_institution=production.id_variete_institution
                                        inner join variete on variete.id_variete=variete_institution.id_variete
                                        inner join speculation on speculation.id_speculation=variete.id_speculation
                                        where production.id_institution=@id_institution and 
                                        variete.id_speculation=@id
                                        group by nom_variete"

        End If
        Dim commandQuantiteSpeculation = New MySqlCommand(getQuantiteSpeculation, connection)
        commandQuantiteSpeculation.Parameters.AddWithValue("@id_institution", DBConnection.id_institution)
        If (id IsNot String.Empty) Then
            commandQuantiteSpeculation.Parameters.AddWithValue("@id", Integer.Parse(id))
        End If
        Dim dataAdapter = New MySqlDataAdapter(commandQuantiteSpeculation)
        Dim productionTable = New DataTable()
        dataAdapter.Fill(productionTable)
        Dim stockVariete = New FormStockVarieteSpeculation()
        stockVariete.DataStockVariete.DataSource = productionTable
        stockVariete.ShowDialog()
    End Sub

    Private Sub Image_Click(sender As Object, e As EventArgs) Handles Image.Click

    End Sub

    Private Sub Image_MouseUp(sender As PictureBox, e As MouseEventArgs) Handles Image.MouseUp
        nom_speculation = sender.Parent.Controls("Panel4").Controls("Label").Text
        card = sender.Parent.Parent
        ShowContextMenu(e, contextMenu:=ContextMenuStrip1)
    End Sub
    Private Sub ShowContextMenu(e As MouseEventArgs, contextMenu As ContextMenuStrip)
        If e.Button = MouseButtons.Right Then
            contextMenu.Items.Item("SupprimerToolStripMenuItem").Text = $"Supprimer la spéculation {nom_speculation}"
            contextMenu.Show(Cursor.Position)
        End If
    End Sub

    Private Sub SupprimerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupprimerToolStripMenuItem.Click
        Dim query = "select id_speculation_institution 
                        from speculation_institution 
                        inner join speculation 
                            on speculation.id_speculation=speculation_institution.id_speculation 
                        where speculation.nom_speculation=@nom_speculation and
                              speculation_institution.id_institution=@id_institution"

        Dim command = New MySqlCommand(query, connection)
        command.Parameters.AddWithValue("id_institution", DBConnection.id_institution)
        command.Parameters.AddWithValue("nom_speculation", nom_speculation)
        Dim reader = command.ExecuteReader()
        Dim id
        While reader.Read()
            id = reader.GetInt16("id_speculation_institution")
        End While
        reader.Close()
        Supprimer(
                tableName:="speculation_institution",
                idName:="id_speculation_institution",
                idValue:=id,
                errorMessage:=AddressOf SpeculationDeleteError,
                remove:=AddressOf RemoveCardFromScreen
                )

    End Sub

    Private Sub Supprimer(tableName As String, idName As String, idValue As Integer, errorMessage As Action, Optional tableData As DataGridView = Nothing, Optional remove As Action = Nothing)
        Dim result = MessageBox.Show("Confirmer ?", $"Suppression {tableName}", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If result = DialogResult.Yes Then
            Try
                Dim query = $"delete from {tableName} where {idName}=@{idName}"
                Dim command = New MySqlCommand(query, connection)
                command.Parameters.AddWithValue($"{idName}", idValue)
                command.ExecuteNonQuery()
                If remove IsNot Nothing Then
                    remove()
                End If
                FormParametres.FillChoixVariete()
                MessageBox.Show("Supprimé avec succés", "Suppression", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Catch ex As MySqlException When ex.Number = 1451
                errorMessage()
            End Try

        End If
    End Sub

    Private Sub RemoveCardFromScreen()
        card.Parent.Controls.Remove(card)
    End Sub
    Private Sub SpeculationDeleteError()
        MessageBox.Show("Cette spéculation possède actuellement des variétés et des productions.", "Suppression impossible", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

End Class
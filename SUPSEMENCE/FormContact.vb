Public Class FormContact
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'SemencesDataSet.client'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.ClientTableAdapter.FillBy(Me.SemencesDataSet.client)
        'TODO: cette ligne de code charge les données dans la table 'SemencesDataSet.localisation'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.LocalisationTableAdapter.Fill(Me.SemencesDataSet.localisation)

    End Sub

    Private Sub FormContact_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        If Me.DialogResult = DialogResult.OK Then
            Return
        End If
        Dim result = MessageBox.Show("Formulaire non sauvegardé." & Environment.NewLine & "Voulez vous vraiment fermer ?", "Annulation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Enregistrer.Click

        If (Nom.Text Is String.Empty Or Prenom.Text Is String.Empty Or Telephone.Text Is String.Empty Or Mail.Text Is String.Empty Or Localisation.SelectedValue Is String.Empty Or Client.SelectedValue Is String.Empty) Then
            Dim result = MessageBox.Show("Le formulaire est incomplet!" & Environment.NewLine & "Veuillez remplir tous les champs svp.", "Formulaire incomplet", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        Else
            Me.DialogResult = DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub FillByToolStripButton_Click_1(sender As Object, e As EventArgs)
        Try
            Me.ClientTableAdapter.FillBy(Me.SemencesDataSet.client)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class
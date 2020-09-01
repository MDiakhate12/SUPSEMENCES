Imports MySql.Data.MySqlClient

Public Class FormContact

    Private connection As MySqlConnection = DBConnection.connection
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: cette ligne de code charge les données dans la table 'SemencesDataSet.client'. Vous pouvez la déplacer ou la supprimer selon les besoins.
        Me.ClientTableAdapter.Fill(Me.SemencesDataSet.client)


        FillChoixLocalite()

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

    Private Sub FillChoixLocalite()
        Dim query = "Select zone_institution.id_localisation, village  from zone_institution
                     inner join localisation on localisation.id_localisation=zone_institution.id_localisation
                     inner join zone_agro_ecologique on zone_agro_ecologique.id_zone=localisation.id_zone
                     where zone_institution.id_institution=@id_institution"

        FillChoix(query:=query,
                  BindingSourceControl:=LocalisationBindingSource,
                  ChoixControl:=Localisation,
                  valueCol:="id_localisation",
                  displayCol:="village")
    End Sub

    Private Sub FillChoix(query, BindingSourceControl, ChoixControl, valueCol, displayCol)

        Dim command = New MySqlCommand(query, connection)
        command.Parameters.AddWithValue("@id_institution", DBConnection.id_institution)


        Dim adapter = New MySqlDataAdapter(command)
        Dim dataTable = New DataTable()
        adapter.Fill(dataTable)

        BindingSourceControl.DataSource = dataTable

        ChoixControl.ValueMember = dataTable.Columns(valueCol).ToString()
        ChoixControl.DisplayMember = dataTable.Columns(displayCol).ToString()
    End Sub
End Class
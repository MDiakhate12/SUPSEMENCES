Imports MySql.Data.MySqlClient

Public Class FormStockVariete

    Private Sub FormStockVariete_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddStockVariete()
    End Sub
    Private Sub AddStockVariete(Optional connectionEntry = Nothing)
        Dim connection As MySqlConnection

        If (connectionEntry Is Nothing) Then
            connection = New MySqlConnection(DBConnection.connectionString)
            connection.Open()
        Else
            connection = connectionEntry
        End If


        Dim getQuantiteSpeculation = "select nom_variete, nom_speculation, sum(quantite_produite) quantite_totale, stock_de_securite
                                        from production, variete_institution, variete, speculation 
                                        where (
                                        production.id_institution=@id_institution and 
                                        variete_institution.id_variete_institution=production.id_variete_institution and
                                        variete.id_variete=variete_institution.id_variete and
                                        variete.id_speculation=speculation.id_speculation
                                        )
                                        group by nom_variete;"

        Dim commandQuantiteSpeculation = New MySqlCommand(getQuantiteSpeculation, connection)
        commandQuantiteSpeculation.Parameters.AddWithValue("@id_institution", DBConnection.id_institution)


        Dim reader = commandQuantiteSpeculation.ExecuteReader()

        While reader.Read()
            Dim label = reader.GetString(0)
            Dim nom_speculation = reader.GetString(1)
            Dim quantite = reader.GetUInt16(2)
            Dim stockDeSecurite = reader.GetUInt16(3)

            Dim image = System.Drawing.Image.FromFile($"{DBConnection.imagePath}semences\{nom_speculation}.jpg", stockDeSecurite)

            AddCard(image, label, quantite, "(" & nom_speculation & ")", stockDeSecurite)
        End While

        If (connectionEntry Is Nothing) Then
            connection.Close()
        End If

    End Sub
    Private Sub AddCard(image As Drawing.Image, label As String, quantite As String, Optional labelSpeculation As String = "", Optional stockDeSecurite As String = "")
        Dim card = New FormStockCard()

        With card
            .Image.Image = image
            .Label.Text = label
            .Quantite.Text = quantite & " KG"
            .TopLevel = False
            .Size = New Size(200, 235)
            If labelSpeculation IsNot String.Empty Then
                .LabelSpeculation.Text = labelSpeculation
            End If
            If stockDeSecurite IsNot String.Empty Then
                .LabelStockDeSecurite.Visible = True
                .LabelStockDeSecurite.Text = "Stock Sécurité: " & stockDeSecurite & " KG"
            End If
        End With
        FlowLayoutPanel1.Controls.Add(card)
        card.BringToFront()
        card.Show()
    End Sub

End Class
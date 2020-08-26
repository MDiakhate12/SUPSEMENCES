Imports MySql.Data.MySqlClient
Public Class FormStockSpeculation
    Dim connection = DBConnection.connection

    Private Sub FormStockSpeculation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddStockSpeculation()
    End Sub

    Private Sub AddStockSpeculation()


        Dim getQuantiteTotal = "select sum(quantite_disponible) from production where production.id_institution=@id_institution"

        Dim commandQuantiteTotal = New MySqlCommand(getQuantiteTotal, connection)
        commandQuantiteTotal.Parameters.AddWithValue("@id_institution", DBConnection.id_institution)

        Dim quantiteTotal = commandQuantiteTotal.ExecuteScalar()
        Dim labelQuantiteTotal = "STOCK TOTAL"
        Dim imageQuantiteTotal = Image.FromFile($"{DBConnection.defaultImage}")

        AddCard(imageQuantiteTotal, labelQuantiteTotal, quantiteTotal)



        Dim getQuantiteSpeculation = "select nom_speculation, sum(quantite_disponible) quantite_totale, variete.id_speculation
                                        from production, variete_institution, variete, speculation 
                                        where (
                                        production.id_institution=@id_institution and 
                                        variete_institution.id_variete_institution=production.id_variete_institution and
                                        variete.id_variete=variete_institution.id_variete and
                                        variete.id_speculation=speculation.id_speculation
                                        )
                                        group by nom_speculation;"

        Dim commandQuantiteSpeculation = New MySqlCommand(getQuantiteSpeculation, connection)
        commandQuantiteSpeculation.Parameters.AddWithValue("@id_institution", DBConnection.id_institution)


        Dim reader = commandQuantiteSpeculation.ExecuteReader()

        While reader.Read()
            Dim label = reader.GetString("nom_speculation")
            Dim quantite = reader.GetUInt16("quantite_totale")
            Dim id = reader.GetUInt16("id_speculation")
            Dim image = System.Drawing.Image.FromFile($"{DBConnection.imagePath}semences\{label}.jpg")

            AddCard(image, label, quantite, id)
        End While
        reader.Close()
    End Sub
    Private Sub AddCard(image As Drawing.Image, label As String, quantite As String, Optional id As String = "")
        Dim card = New FormStockCard()

        With card
            .Image.Image = image
            .Label.Text = label
            .Label.Font = New Font("Stencil", 20)
            .Quantite.Text = quantite & " KG"
            .Quantite.Font = New Font("Stencil", 28)
            .Quantite.Location = New Point(.Quantite.Location.X, .Quantite.Location.Y + 20)
            .TopLevel = False
            .Size = New Size(180, 200)
            .Panel4.Height = 60
            .id = id
            If label.ToLower().Contains("total") Then
                .Label.ForeColor = Color.Gold
                .Quantite.ForeColor = Color.Firebrick
            End If
        End With
        FlowLayoutPanel1.Controls.Add(card)
        card.BringToFront()
        card.Show()
    End Sub

End Class
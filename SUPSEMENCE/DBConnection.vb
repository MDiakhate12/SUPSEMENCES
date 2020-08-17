Imports MySql.Data.MySqlClient

Public Class DBConnection
    Public Shared connectionString As String = "server=localhost;user id=root;password=droite15;database=semences"
    Public Shared id_institution As Integer = 1
    Public Shared imagePath = "C:\Users\DELL\Pictures\SUPSEMENCE\"
    Public Shared defaultImage = "semences\default.jpg"
    Public Shared connection As MySqlConnection = New MySqlConnection(connectionString)

    Public Shared Async Function StartConnectionAsync() As Task
        Try
            Await connection.OpenAsync()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            MessageBox.Show("Erreur inattendue, vérifier si MYSQL est bien installé sur votre machine ou contacter le fournisseur de service.", "Erreur de connexion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Public Shared Async Function StopConnectionAsync() As Task
        Try
            Await connection.CloseAsync()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
            MessageBox.Show("Erreur inattendue lors de la fermerture de la base de donnée. Veuilez ressayer ou contacter le fournisseur de service.", "Erreur de déconnexion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

End Class

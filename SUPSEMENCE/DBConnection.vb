Imports MySql.Data.MySqlClient
Imports System.IO.Path
Imports System.IO.Directory



Public Class DBConnection
    Public Shared connectionStringDebug As String = "server=localhost;user id=root;password=droite15;database=semences"
    'Public Shared connectionString As String = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database.mdf;Integrated Security=True"

    Public Shared id_institution As Integer = 1
    Public Shared rootDirDebug = GetParent(GetParent(GetParent(My.Computer.FileSystem.CurrentDirectory).FullName).FullName).FullName
    Public Shared rootDir = GetParent(GetParent(GetParent(My.Computer.FileSystem.CurrentDirectory).FullName).FullName).FullName


    'Public Shared imagePath = Combine("C:\Users\HP\source\repos\SUPSEMENCES", "Images\")
    Public Shared imagePath = Combine(rootDirDebug, "Images\")
    Public Shared defaultImage = Combine(imagePath, "semences", "default.jpg")
    Public Shared connection As MySqlConnection = New MySqlConnection(connectionStringDebug)

    Public Shared Async Function StartConnectionAsync() As Task
        MessageBox.Show(rootDir)
        'MessageBox.Show(imagePath)
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

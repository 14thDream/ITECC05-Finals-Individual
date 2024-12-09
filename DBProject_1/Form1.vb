Imports MySql.Data.MySqlClient

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim SqlConnection = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;password=;database=dbproject1"
        }

        Try
            SqlConnection.Open()

            MessageBox.Show("Connection Successful")

            SqlConnection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            SqlConnection.Dispose()
        End Try

    End Sub

End Class

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


    Private Sub Button_Login_Click(sender As Object, e As EventArgs) Handles Button_Login.Click
        Dim SqlConnection = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;password=;database=dbproject1"
        }

        Try
            SqlConnection.Open()

            Dim Query As String = $"SELECT * FROM edata WHERE username = '{TextBox_Username.Text}' AND password = '{TextBox_Password.Text}';"
            Dim Command = New MySqlCommand(Query, SqlConnection)
            Dim Reader = Command.ExecuteReader()

            Dim Count As Integer = 0
            While Reader.Read
                Count += 1
            End While

            If Count = 1 Then
                MessageBox.Show("Username and password are correct")
            ElseIf Count > 1 Then
                MessageBox.Show("Username and password are duplicates")
            Else
                MessageBox.Show("Username and password are not correct")
            End If

            SqlConnection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            SqlConnection.Dispose()
        End Try

    End Sub


End Class

Imports MySql.Data.MySqlClient

Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim SqlConnection = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;password=;database=dbproject1"
        }

        Try
            SqlConnection.Open()

            Dim Query = $"INSERT INTO edata(id, first_name, surname, age) VALUES ({TextBox_Id.Text}, '{TextBox_FirstName.Text}', '{TextBox_Surname.Text}', '{TextBox_Age.Text}');"
            Dim Command = New MySqlCommand(Query, SqlConnection)
            Command.ExecuteReader()

            MessageBox.Show("Data Saved")

            SqlConnection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            SqlConnection.Dispose()
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim SqlConnection = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;password=;database=dbproject1"
        }

        Try
            SqlConnection.Open()

            Dim Query = $"UPDATE edata SET first_name = '{TextBox_FirstName.Text}', surname = '{TextBox_Surname.Text}', age = {TextBox_Age.Text} WHERE id = {TextBox_Id.Text};"
            Dim Command = New MySqlCommand(Query, SqlConnection)
            Command.ExecuteReader()

            MessageBox.Show("Data Updated")

            SqlConnection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            SqlConnection.Dispose()
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim SqlConnection = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;password=;database=dbproject1"
        }

        Try
            SqlConnection.Open()

            Dim Query = $"DELETE FROM edata WHERE id = {TextBox_Id.Text};"
            Dim Command = New MySqlCommand(Query, SqlConnection)
            Command.ExecuteReader()

            MessageBox.Show("Data Deleted")

            SqlConnection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            SqlConnection.Dispose()
        End Try
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim SqlConnection = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;password=;database=dbproject1"
        }

        Try
            SqlConnection.Open()

            Dim Query = $"SELECT first_name FROM edata;"
            Dim Command = New MySqlCommand(Query, SqlConnection)
            Dim Reader = Command.ExecuteReader()

            While Reader.Read
                If Reader.IsDBNull("first_name") Then
                    Continue While
                End If

                Dim Name As String = Reader.GetString("first_name")
                ComboBox1.Items.Add(Name)
            End While

            SqlConnection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            SqlConnection.Dispose()
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim SqlConnection = New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;password=;database=dbproject1"
        }

        Try
            SqlConnection.Open()

            Dim Query = $"SELECT id, surname, age FROM edata WHERE first_name = '{ComboBox1.Text}';"
            Dim Command = New MySqlCommand(Query, SqlConnection)

            Dim Reader = Command.ExecuteReader()
            Reader.Read()

            TextBox_Id.Text = Reader.GetInt32("id")
            TextBox_FirstName.Text = ComboBox1.Text
            TextBox_Surname.Text = If(Reader.GetString("surname"), "")
            TextBox_Age.Text = If(Reader.GetInt32("age").ToString(), "")

            SqlConnection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            SqlConnection.Dispose()
        End Try
    End Sub
End Class
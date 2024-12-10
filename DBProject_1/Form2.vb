Imports MySql.Data.MySqlClient

Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim SqlConnection As New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;password=;database=dbproject1"
        }

        Try
            SqlConnection.Open()

            Dim Query = $"INSERT INTO edata(id, first_name, surname, age) VALUES ({TextBox_Id.Text}, '{TextBox_FirstName.Text}', '{TextBox_Surname.Text}', '{TextBox_Age.Text}');"
            Dim Command As New MySqlCommand(Query, SqlConnection)
            Command.ExecuteReader()

            LoadTable()
            MessageBox.Show("Data Saved")

            SqlConnection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            SqlConnection.Dispose()
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim SqlConnection As New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;password=;database=dbproject1"
        }

        Try
            SqlConnection.Open()

            Dim Query = $"UPDATE edata SET first_name = '{TextBox_FirstName.Text}', surname = '{TextBox_Surname.Text}', age = {TextBox_Age.Text} WHERE id = {TextBox_Id.Text};"
            Dim Command As New MySqlCommand(Query, SqlConnection)
            Command.ExecuteReader()

            LoadTable()
            MessageBox.Show("Data Updated")

            SqlConnection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            SqlConnection.Dispose()
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim SqlConnection As New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;password=;database=dbproject1"
        }

        Try
            SqlConnection.Open()

            Dim Query = $"DELETE FROM edata WHERE id = {TextBox_Id.Text};"
            Dim Command As New MySqlCommand(Query, SqlConnection)
            Command.ExecuteReader()

            LoadTable()
            MessageBox.Show("Data Deleted")

            SqlConnection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            SqlConnection.Dispose()
        End Try
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTable()

        Dim SqlConnection As New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;password=;database=dbproject1"
        }

        Try
            SqlConnection.Open()

            Dim Query = $"SELECT first_name FROM edata;"
            Dim Command As New MySqlCommand(Query, SqlConnection)
            Dim Reader = Command.ExecuteReader()

            While Reader.Read
                If Reader.IsDBNull("first_name") Then
                    Continue While
                End If

                Dim Name As String = Reader.GetString("first_name")
                ComboBox1.Items.Add(Name)
                ListBox1.Items.Add(Name)
            End While

            SqlConnection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            SqlConnection.Dispose()
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim SqlConnection As New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;password=;database=dbproject1"
        }

        Try
            SqlConnection.Open()

            Dim Query = $"SELECT id, surname, age FROM edata WHERE first_name = '{ComboBox1.Text}';"
            Dim Command As New MySqlCommand(Query, SqlConnection)

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

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim SqlConnection As New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;password=;database=dbproject1"
        }

        Try
            SqlConnection.Open()

            Dim Query = $"SELECT id, surname, age FROM edata WHERE first_name = '{ListBox1.Text}';"
            Dim Command As New MySqlCommand(Query, SqlConnection)

            Dim Reader = Command.ExecuteReader()
            Reader.Read()

            TextBox_Id.Text = Reader.GetInt32("id")
            TextBox_FirstName.Text = ListBox1.Text
            TextBox_Surname.Text = If(Reader.GetString("surname"), "")
            TextBox_Age.Text = If(Reader.GetInt32("age").ToString(), "")

            SqlConnection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            SqlConnection.Dispose()
        End Try
    End Sub

    Private Sub LoadTable()
        Dim SqlConnection As New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;password=;database=dbproject1"
        }

        Try
            SqlConnection.Open()

            Dim Query = "SELECT id, first_name, surname, age FROM edata;"
            Dim Command As New MySqlCommand(Query, SqlConnection)

            Dim dbDatatable As New DataTable
            Dim SDA As New MySqlDataAdapter With {
                .SelectCommand = Command
            }

            Dim bSource As New BindingSource With {
                .DataSource = dbDatatable
            }

            SDA.Fill(dbDatatable)
            DataGridView1.DataSource = bSource
            SDA.Update(dbDatatable)

            SqlConnection.Close()

            For Each c As DataGridViewColumn In DataGridView1.Columns
                c.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            Next

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            SqlConnection.Dispose()
        End Try
    End Sub

    Private Sub ButtonLoadTable_Click(sender As Object, e As EventArgs) Handles ButtonLoadTable.Click
        LoadTable()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        If e.RowIndex < 0 Then
            Return
        End If

        Dim Row = DataGridView1.Rows(e.RowIndex)
        Dim Id = Row.Cells("id").Value
        Dim FirstName = Row.Cells("first_name").Value
        Dim Surname = Row.Cells("surname").Value
        Dim Age = Row.Cells("surname").Value

        TextBox_Id.Text = Id
        TextBox_FirstName.Text = If(IsDBNull(FirstName), "", FirstName)
        TextBox_Surname.Text = If(IsDBNull(Surname), "", Surname)
        TextBox_Age.Text = If(IsDBNull(Age), "", Age)
    End Sub
End Class
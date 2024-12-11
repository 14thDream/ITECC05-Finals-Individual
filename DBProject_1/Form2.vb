Imports System.Diagnostics.Eventing
Imports System.Windows.Forms.DataVisualization.Charting
Imports MySql.Data.MySqlClient

Public Class Form2
    Private DbDataTable As New DataTable
    Private Gender As String

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

            Dim Query = $"INSERT INTO edata(id, first_name, surname, age, gender) VALUES ({TextBox_Id.Text}, '{TextBox_FirstName.Text}', '{TextBox_Surname.Text}', '{TextBox_Age.Text}', '{Gender}');"
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

            Dim Query = $"UPDATE edata SET first_name = '{TextBox_FirstName.Text}', surname = '{TextBox_Surname.Text}', age = {TextBox_Age.Text}, gender = '{Gender}' WHERE id = {TextBox_Id.Text};"
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

        RadioButtonMale.Checked = True
        RadioButtonMale_CheckedChanged(RadioButtonMale, Nothing)

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

    Private Sub CheckGender(gender As String)
        If gender = "Male" Then
            RadioButtonMale.Checked = True
            RadioButtonMale_CheckedChanged(RadioButtonMale, Nothing)
        Else
            RadioButtonFemale.Checked = True
            RadioButtonFemale_CheckedChanged(RadioButtonFemale, Nothing)
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Dim SqlConnection As New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;password=;database=dbproject1"
        }

        Try
            SqlConnection.Open()

            Dim Query = $"SELECT id, surname, age, gender FROM edata WHERE first_name = '{ComboBox1.Text}';"
            Dim Command As New MySqlCommand(Query, SqlConnection)

            Dim Reader = Command.ExecuteReader()
            Reader.Read()

            TextBox_Id.Text = Reader.GetInt32("id")
            TextBox_FirstName.Text = ComboBox1.Text
            TextBox_Surname.Text = If(Reader.GetString("surname"), "")
            TextBox_Age.Text = If(Reader.GetInt32("age").ToString(), "")

            CheckGender(Reader.GetString("gender"))

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

            Dim Query = $"SELECT id, surname, age, gender FROM edata WHERE first_name = '{ListBox1.Text}';"
            Dim Command As New MySqlCommand(Query, SqlConnection)

            Dim Reader = Command.ExecuteReader()
            Reader.Read()

            TextBox_Id.Text = Reader.GetInt32("id")
            TextBox_FirstName.Text = ListBox1.Text
            TextBox_Surname.Text = If(Reader.GetString("surname"), "")
            TextBox_Age.Text = If(Reader.GetInt32("age").ToString(), "")

            CheckGender(Reader.GetString("gender"))

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

            Dim Query = "SELECT id AS 'Employee Id', first_name AS 'First Name', surname AS 'Surname', age AS 'Age', gender as 'Gender' FROM edata;"
            Dim Command As New MySqlCommand(Query, SqlConnection)

            Dim SDA As New MySqlDataAdapter With {
                .SelectCommand = Command
            }

            Dim bSource As New BindingSource With {
                .DataSource = DbDataTable
            }

            DbDataTable.Rows.Clear()
            SDA.Fill(DbDataTable)

            DataGridView1.DataSource = bSource

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
        Dim Id = Row.Cells("Employee Id").Value
        Dim FirstName = Row.Cells("First Name").Value
        Dim Surname = Row.Cells("Surname").Value
        Dim Age = Row.Cells("Age").Value
        Dim gender = Row.Cells("Gender").Value

        TextBox_Id.Text = If(IsDBNull(Id), "", Id)
        TextBox_FirstName.Text = If(IsDBNull(FirstName), "", FirstName)
        TextBox_Surname.Text = If(IsDBNull(Surname), "", Surname)
        TextBox_Age.Text = If(IsDBNull(Age), "", Age)

        If Not IsDBNull(gender) Then
            CheckGender(gender)
        End If
    End Sub

    Private Sub TextBoxSearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxSearch.TextChanged
        Dim DV As New DataView(DbDataTable) With {
            .RowFilter = $"[First Name] LIKE '%{TextBoxSearch.Text}%'"
        }

        DataGridView1.DataSource = DV
    End Sub

    Private Sub ButtonLoadChart_Click(sender As Object, e As EventArgs) Handles ButtonLoadChart.Click
        Dim SqlConnection As New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;password=;database=dbproject1"
        }

        Try
            SqlConnection.Open()

            Dim Query = "SELECT first_name, age FROM edata;"
            Dim Command As New MySqlCommand(Query, SqlConnection)

            Chart1.Series("NAME_VS_AGE").Points.Clear()

            Dim Reader = Command.ExecuteReader()
            While Reader.Read
                If Reader.IsDBNull("first_name") OrElse Reader.IsDBNull("age") Then
                    Continue While
                End If

                Dim Name = Reader.GetString("first_name")
                Dim Age = Reader.GetInt32("age")

                Dim Index = Chart1.Series("NAME_VS_AGE").Points.AddXY(Name, Age)
                Chart1.Series("NAME_VS_AGE").Points.ElementAt(Index).XValue = Index + 1
            End While

            SqlConnection.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            SqlConnection.Dispose()
        End Try
    End Sub

    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim Dialog = MessageBox.Show("Do uou really want to close the app", "Exit", MessageBoxButtons.YesNo)
        If Dialog = DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub RadioButtonMale_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonMale.CheckedChanged
        Gender = "Male"
    End Sub

    Private Sub RadioButtonFemale_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonFemale.CheckedChanged
        Gender = "Female"
    End Sub
End Class
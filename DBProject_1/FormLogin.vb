﻿Imports MySql.Data.MySqlClient

Public Class FormLogin
    Private Sub ButtonCheckConnection_Click(sender As Object, e As EventArgs) Handles ButtonCheckConnection.Click
        Dim SqlConnection As New MySqlConnection With {
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
        Dim SqlConnection As New MySqlConnection With {
            .ConnectionString = "server=localhost;userid=root;password=;database=dbproject1"
        }

        Try
            SqlConnection.Open()

            Dim Query = $"SELECT * FROM accounts WHERE username = '{TextBox_Username.Text}' AND password = '{TextBox_Password.Text}';"
            Dim Command As New MySqlCommand(Query, SqlConnection)
            Dim Reader = Command.ExecuteReader

            Dim Count = 0
            While Reader.Read
                Count += 1
            End While

            If Count = 1 Then
                MessageBox.Show("Username and password are correct")

                Form2.Show()
                Close()
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
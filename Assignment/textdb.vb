Imports System.Data.OleDb

Public Class textdb
    Dim myConnection As New OleDbConnection
    Dim addQuery As String
    Dim adapter As New OleDbDataAdapter
    Dim dt As New DataTable

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim validation As New validation
        myConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""..\..\Car_Renting_System_Database.accdb"""
        Try
            myConnection.Open()


            If (validation.Is_Password(TextBox2.Text.ToString)) Then

                addQuery = "INSERT INTO Member_Security_information([MEMBER_ID],[PASSWORD],[RECOVER_QUESTION],[RECOVER_ANSWER]) VALUES('" & MaskedTextBox1.Text.ToString & "','" & TextBox2.Text.ToString & "','" & TextBox3.Text.ToString & "','" & TextBox4.Text.ToString & "')"


                Dim cmd As OleDbCommand = New OleDbCommand(addQuery, myConnection)

                cmd.ExecuteNonQuery()
                myConnection.Close()
                textdb_Load(Nothing, Nothing)
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try
        myConnection.Close()


    End Sub

    Private Sub textdb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        myConnection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=""..\..\Car_Renting_System_Database.accdb"""
        myConnection.Open()
        adapter = New OleDbDataAdapter("SELECT * FROM Member_Security_information", myConnection)

        adapter.Fill(dt)
        Member_Security_informationDataGridView.DataSource = dt.DefaultView
        myConnection.Close()




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        myConnection.Open()
        adapter = New OleDbDataAdapter("SELECT * FROM Member_Security_information", myConnection)


    End Sub
End Class
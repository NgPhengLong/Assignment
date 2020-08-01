Imports Microsoft.VisualBasic.Logging


Public Class registertesting
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Log_In As New Log_In("STAFF")

        Dim strPassword As String = String.Empty
        Dim strAnswer As String = String.Empty
        Dim intEncryptKey(,) As Integer = {
            {2, 6},
            {8, 15}
        }

        Identity_Select.Encryption(TextBox2.Text, intEncryptKey, strPassword)
        Identity_Select.Encryption(TextBox4.Text, intEncryptKey, strAnswer)

        Staff_Security_informationTableAdapter.Insert(TextBox1.Text, strPassword, TextBox3.Text, strAnswer, TextBox5.Text)

        Me.Close()
        Log_In.Show()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
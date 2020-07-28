Imports Microsoft.VisualBasic.Logging


Public Class registertesting
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Log_In As New Log_In("STAFF")

        Dim strPassword As String = String.Empty
        Dim intEncryptKey(,) As Integer = {
            {2, 6},
            {8, 15}
        }

        Identity_Select.Encryption(TextBox2.Text, intEncryptKey, strPassword)

        Staff_Security_informationTableAdapter.Insert(TextBox1.Text, strPassword, TextBox3.Text, TextBox4.Text, TextBox5.Text)

        Me.Close()
        Log_In.Show()
    End Sub

End Class
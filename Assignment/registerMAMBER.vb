Public Class registerMAMBER
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Log_In As New Log_In("MEMBER")

        Dim strPassword As String = String.Empty
        Dim strAnswer As String = String.Empty
        Dim intEncryptKey(,) As Integer = {
            {2, 6},
            {8, 15}
        }

        Identity_Select.Encryption(TextBox2.Text, intEncryptKey, strPassword)
        Identity_Select.Encryption(TextBox4.Text, intEncryptKey, strAnswer)

        Member_Security_informationTableAdapter.Insert(TextBox1.Text, strPassword, TextBox3.Text, strAnswer, Date.Now.ToString("dd/MM/yyyy"))

        Me.Close()
        Log_In.Show()
    End Sub
End Class
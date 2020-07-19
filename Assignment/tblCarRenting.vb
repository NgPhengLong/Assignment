Public Class tblCarRenting
    Dim tblCarRenting As DataTable
    Dim colTransactionNo As DataColumn
    Dim colCustomerId As DataColumn
    Dim colBookStart As DataColumn
    Dim colBookEnd As DataColumn
    Dim colDuration As DataColumn
    Dim colTotalPrice As DataColumn
    Dim colCarId As DataColumn
    Dim colDateModified As DataColumn
    Dim colStatus As DataColumn

    Private Sub txtSearchId_Enter(sender As Object, e As EventArgs) Handles txtSearchId.Enter

        If txtSearchId.Text = "Search with Id" Then
            txtSearchId.Text = ""
        End If
    End Sub

    Private Sub txtSearchId_Leave(sender As Object, e As EventArgs) Handles txtSearchId.Leave
        If txtSearchId.Text = "" Then
            txtSearchId.Text = "Search with Id"
        End If
    End Sub
End Class

'Transaction Red No. / ID
'Customer ID
'Bookdate start
'Bookdate end
'Duration
'Total price
'CarID
'Lasteditdate
'status - 出租中, 已歸還
'date modified
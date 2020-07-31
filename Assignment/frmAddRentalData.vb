Imports Assignment.Module1

Public Class frmAddRentalData
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim testTransaction As DataRow
        Dim table = New DataTable()
        Dim newTransaction = New Transaction()

        testTransaction = table.NewRow()
        table.Columns.Add("CUSTOMER_ID")
        table.Columns.Add("BOOKDATE_START")
        table.Columns.Add("BOOKDATE_END")
        table.Columns.Add("DURATION")
        table.Columns.Add("DATE_MODIFY")
        table.Columns.Add("TOTAL_PRICE")
        table.Columns.Add("STATUS")
        table.Columns.Add("CAR_ID")

        testTransaction.Item("CUSTOMER_ID") = txtCustomerId.Text
        testTransaction.Item("BOOKDATE_START") = dateBookStart.Value
        testTransaction.Item("BOOKDATE_END") = dateBookEnd.Value
        testTransaction.Item("DURATION") = lblDuration.Text.ToString
        testTransaction.Item("DATE_MODIFY") = ""
        testTransaction.Item("TOTAL_PRICE") = lblPrice.Text.ToString
        testTransaction.Item("STATUS") = lblStatus.Text
        testTransaction.Item("CAR_ID") = lblCarId.Text

        table.AcceptChanges()


        Me.TableTableAdapter.Update(testTransaction)
    End Sub
End Class
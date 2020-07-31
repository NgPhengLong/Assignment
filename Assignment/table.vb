Public Class table

    Private Sub table_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSet_Car_Rental.Table' table. You can move, or remove it, as needed.
        Me.TableTableAdapter.Fill(Me.DataSet_Car_Rental.Table)

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmAddRentalData.Show()
    End Sub
End Class
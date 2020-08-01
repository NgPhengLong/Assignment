Imports System.Data.SqlClient

Public Class Question
    Public Sub New(ByVal identity As String, ByVal id As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        lblIdentity.Text = identity
        lblUserId.Text = id
    End Sub

    'Back to previous form
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim Change_Password_Method As New Change_Password_Method(lblIdentity.Text, lblUserId.Text)

        Change_Password_Method.Show()
        Me.Close()
    End Sub

    'go to change password form
    Private Sub btnVerify_Click(sender As Object, e As EventArgs) Handles btnVerify.Click
        Dim intCount As Integer
        Dim information As New DataTable

        Dim strAnswer As String = String.Empty
        Dim strPassword As String = String.Empty
        Dim intEncryptKey(,) As Integer = {
            {2, 6},
            {8, 15}
        }

        If (txtAnswer.Text <> String.Empty) Then

            Identity_Select.Encryption(txtAnswer.Text, intEncryptKey, strAnswer)

            If LCase(lblIdentity.Text) = "staff" Then
                'staff database

                intCount = Staff_Security_informationTableAdapter.GetDataByIDandAnswer(lblUserId.Text, strAnswer).Count

                'check correct answer or not
                If (intCount > 0) Then

                    information = Staff_Security_informationTableAdapter.GetDataByIDandAnswer(lblUserId.Text, strAnswer)

                    Identity_Select.Decryption(information.Rows(0).Item(1), intEncryptKey, strPassword)

                    'open change password form
                    Dim Change_Password As New Change_Password(lblIdentity.Text, lblUserId.Text, strPassword)
                    Change_Password.Show()
                    Me.Close()
                Else
                    MessageBox.Show("wrong answer input")
                End If

            ElseIf LCase(lblIdentity.Text) = "member" Then
                'customer database

                intCount = Member_Security_informationTableAdapter.GetDataByIDandAnswer(lblUserId.Text, strAnswer).Count

                'check correct answer or not
                If (intCount > 0) Then

                    information = Member_Security_informationTableAdapter.GetDataByIDandAnswer(lblUserId.Text, strAnswer)

                    Identity_Select.Decryption(information.Rows(0).Item(1), intEncryptKey, strPassword)

                    'open change password form
                    Dim Change_Password As New Change_Password(lblIdentity.Text, lblUserId.Text, strPassword)
                    Change_Password.Show()
                    Me.Close()
                Else
                    MessageBox.Show("wrong answer input")
                End If

            End If

        Else
            MessageBox.Show("Answer require")
        End If


    End Sub

    Private Sub Question_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim intCount As Integer
        Dim information As New DataTable

        MessageBox.Show(lblUserId.Text)

        If LCase(lblIdentity.Text) = "staff" Then

            intCount = Staff_Security_informationTableAdapter.GetDataByID(lblUserId.Text).Count

            If (intCount > 0) Then
                lblQuestion.Text = Staff_Security_informationTableAdapter.GetDataByID(lblUserId.Text).Rows(0).Item(2).ToString
            End If

        ElseIf LCase(lblIdentity.Text) = "member" Then
            intCount = Member_Security_informationTableAdapter.GetDataByID(lblUserId.Text).Count

            If (intCount > 0) Then

                lblQuestion.Text = Member_Security_informationTableAdapter.GetDataByID(lblUserId.Text).Rows(0).Item(2).ToString

            End If
        End If

    End Sub

    Private Sub Staff_Security_informationBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Staff_Security_informationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Car_Renting_System_DatabaseDataSet)

    End Sub
End Class
Imports System.Data.SqlClient

Public Class Change_Password
    Public Sub New(ByVal identity As String, ByVal id As String, ByVal password As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        lblIdentity.Text = identity
        lblUserId.Text = id
        txtOriPass.Text = password
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim Change_Password_Method As New Change_Password_Method(lblIdentity.Text, lblUserId.Text)

        Change_Password_Method.Show()
        Me.Close()
    End Sub

    Private Sub Change_Password_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If txtOriPass.Text = String.Empty Then
            txtOriPass.Enabled = True
        Else
            txtOriPass.Enabled = False
        End If
    End Sub

    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click
        Dim Log_In As New Log_In(lblIdentity.Text)
        Dim intCount As Integer
        Dim reader As SqlDataReader

        Dim strOriPassword As String = String.Empty
        Dim strNewPassword As String = String.Empty
        Dim intEncryptKey(,) As Integer = {
            {2, 6},
            {8, 15}
        }

        'check have blank space not fill in or not
        If txtOriPass.Text <> String.Empty And txtNewPass.Text <> String.Empty And txtReType.Text <> String.Empty Then

            Identity_Select.Encryption(txtOriPass.Text, intEncryptKey, strOriPassword)

            'Check identity and open what database to verify original password
            If LCase(lblIdentity.Text) = "staff" Then
                intCount = Staff_Security_informationTableAdapter.GetDataByIDandPASSWORD(lblUserId.Text, strOriPassword).Count
            ElseIf LCase(lblIdentity.Text) = "member" Then
                intCount = Member_Security_informationTableAdapter.GetDataByIDPASS(lblUserId.Text, strOriPassword).Count
            End If

            'check the original password are correct or not
            If (intCount > 0) Then

                'check the new password and retype password are match or not
                If txtNewPass.Text = txtReType.Text Then

                    'Identity_Select.Encryption(txtOriPass.Text, encryptKey, password)
                    Identity_Select.Encryption(txtNewPass.Text, intEncryptKey, strNewPassword)

                    'Check identity and open what database to update
                    If LCase(lblIdentity.Text) = "staff" Then

                        Staff_Security_informationTableAdapter.UpdateQuery(strNewPassword, lblUserId.Text)

                    ElseIf LCase(lblIdentity.Text) = "member" Then

                        Member_Security_informationTableAdapter.UpdateQuery(strNewPassword, lblUserId.Text)

                    End If

                    Identity_Select.connection.Close()
                    MessageBox.Show("Update Successfuly")
                    Log_In.Show()
                    Me.Close()

                Else
                    MessageBox.Show("New password are not match with re-type password")
                End If

            Else
                MessageBox.Show("Original Password is incorrect")
            End If
        Else
            MessageBox.Show("All the blank space must be fill up")
        End If

    End Sub

    Private Sub Staff_Security_informationBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.Staff_Security_informationBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Car_Renting_System_DatabaseDataSet)

    End Sub
End Class
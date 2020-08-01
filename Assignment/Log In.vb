Imports System.Data.SqlClient
Public Class Log_In

    Public Sub New(ByVal userIdentity As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        lblIdentity.Text = userIdentity
    End Sub

    'decide identity
    Private Sub Log_In_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Car_Renting_System_DatabaseDataSet.USER_VISIT' table. You can move, or remove it, as needed.
        Me.USER_VISITTableAdapter.Fill(Me.Car_Renting_System_DatabaseDataSet.USER_VISIT)
        btnNewUser.Text = "NEW " & lblIdentity.Text
        lblUserId.Text = UCase(lblIdentity.Text) & " ID"

        ToolTip1.SetToolTip(txtId, "Please input your " & lblIdentity.Text & " ID")


    End Sub

    'show password
    Private Sub showPassBtn_MouseDown(sender As Object, e As EventArgs) Handles btnShowPass.MouseDown
        txtPass.PasswordChar = ""
        btnShowPass.Image = My.Resources.show
    End Sub

    'hide password
    Private Sub showPassBtn_MouseUp(sender As Object, e As EventArgs) Handles btnShowPass.MouseUp
        txtPass.PasswordChar = "•"
        btnShowPass.Image = My.Resources.hide
    End Sub

    'proceed to log in form
    Private Sub backBtn_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        Identity_Select.Show()
    End Sub

    'register as new user(member/staff)
    Private Sub newUserBtn_Click(sender As Object, e As EventArgs) Handles btnNewUser.Click
        If LCase(lblIdentity.Text) = "staff" Then
            lblAlertMsg.Visible = True

        ElseIf LCase(lblIdentity.Text) = "member" Then
            registerMAMBER.Show()
            Me.Close()
        End If

    End Sub

    'Transfer to Change Password Method Form
    Private Sub forgetPassBtn_Click(sender As Object, e As EventArgs) Handles btnForgetPass.Click
        Dim intCount As Integer
        Dim reader As SqlDataReader

        'Check is it the ID text box empty
        If (txtId.Text <> String.Empty) Then

            'decide using customer or staff database to verify
            If LCase(lblIdentity.Text) = "staff" Then
                intCount = Staff_Security_informationTableAdapter.GetDataByID(txtId.Text).Count

            ElseIf LCase(lblIdentity.Text) = "member" Then
                intCount = Member_Security_informationTableAdapter.GetDataByID(txtId.Text).Count

            End If

            'if have user ID then would process to change password method form
            If (intCount > 0) Then
                Dim Change_Password_Method As New Change_Password_Method(lblIdentity.Text, txtId.Text)

                Change_Password_Method.Show()
                Me.Close()

            Else
                MessageBox.Show(UCase(lblIdentity.Text) & " ID not found")
            End If

        Else
            MessageBox.Show(UCase(lblIdentity.Text) & " ID are required")
            txtId.Focus()
        End If
    End Sub

    Private Sub logInBtn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click

        Dim cmd As SqlCommand
        Dim reader As SqlDataReader
        Dim uniqueID As Integer

        Dim strUserID As String = txtId.Text
        Dim strPassword As String = String.Empty
        Dim intEncryptKey(,) As Integer = {
            {2, 6},
            {8, 15}
        }

        Try
            uniqueID = USER_VISITTableAdapter.getUniqueID()
        Catch ex As Exception
            uniqueID = 0
        End Try

        'check identity
        If (txtId.Text <> String.Empty) And (txtPass.Text <> String.Empty) Then

            'encrypted it to compare with the database record
            Identity_Select.Encryption(txtPass.Text, intEncryptKey, strPassword)

            If LCase(lblIdentity.Text) = "staff" Then


                'check is log in or register helping
                If lblAlertMsg.Visible = True Then
                    'staff database

                    'if have record inside the staff database
                    If (Staff_Security_informationTableAdapter.GetData().Count > 0) Then

                        'if all condition are correct transfer to staff registration form
                        If (Staff_Security_informationTableAdapter.GetDataByIdPassPrivilege(strUserID, strPassword, 2).Count > 0) Then
                            'temp
                            MessageBox.Show("(STAFF) go staff register form with user authorization")

                            USER_VISITTableAdapter.Insert(uniqueID + 1, txtId.Text, "STAFF", Date.Now.ToString("dd/MM/yyyy hh:mm"), "")

                            registertesting.Show()
                            lblAlertMsg.Visible = False
                            Me.Close()
                        Else
                            MessageBox.Show("Invalid ID or Password or staff previleges are not 2" & vbNewLine & "Please type again")
                        End If
                    Else
                        'system password
                        If (txtId.Text = "admin" And txtPass.Text = "1234") Then
                            'temp
                            MessageBox.Show("(STAFF) go staff register form with system password")

                            registertesting.Show()
                            lblAlertMsg.Visible = False
                            Me.Close()
                        Else
                            MessageBox.Show("Invalid ID or Password" & vbNewLine & "Please type again")
                        End If
                    End If
                Else
                    'if password and id correct
                    If (Staff_Security_informationTableAdapter.GetDataByIDandPASSWORD(strUserID, strPassword).Count > 0) Then
                        'temp
                        MessageBox.Show("(STAFF) go renting panel with user authorization")
                        USER_VISITTableAdapter.Insert(uniqueID + 1, txtId.Text, "STAFF", Date.Now.ToString("dd/MM/yyyy hh:mm"), "")

                        'log in
                        'renting control panel  open (that operate by staff)
                        'Me.Close()

                    Else
                        MessageBox.Show("Invalid ID or Password" & vbNewLine & "Please type again")
                    End If
                End If


            ElseIf LCase(lblIdentity.Text) = "member" Then
                'customer database

                'check whether input correct ID and password or not
                If (Member_Security_informationTableAdapter.GetDataByIDPASS(strUserID, strPassword).Count > 0) Then
                    'temp
                    MessageBox.Show("(MEMBER) go renting panel with user authorization")

                    USER_VISITTableAdapter.Insert(uniqueID + 1, txtId.Text, "MEMBER", Date.Now.ToString("dd/MM/yyyy hh:mm"), "")
                    'log in
                    'control panel for renting open (that operate by customer)
                    'Me.Close()
                Else
                    MessageBox.Show("Invalid ID or Password" & vbNewLine & "Please type again")

                End If

            End If

            txtId.Focus()
            txtId.SelectAll()
            txtPass.Focus()
            txtPass.SelectAll()
        Else
            MessageBox.Show("ID and password are required")
        End If
    End Sub

End Class
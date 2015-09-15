Public Class FormLogin 

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CloseBox = False
        LoginFunction()

    End Sub

    Private Sub buttonLogin_Click(sender As Object, e As EventArgs) Handles buttonLogin.Click
        'If textEditUserName.Text.Trim.Length = 0 Then
        '    XtraMessageBox.Show("Your username is empty", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    textEditUserName.Focus()
        '    Exit Sub
        'End If

        'If Len(Trim(textEditPassword.Text)) = 0 Then
        '    XtraMessageBox.Show("Your password is empty", "Incomplete Data", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    textEditPassword.Focus()
        '    Exit Sub
        'End If

    End Sub

    Private Sub buttonCancel_Click(sender As Object, e As EventArgs) Handles buttonCancel.Click
        'End
    End Sub

    Sub LoginFunction()

        oClassActiveUser.Username = "admin"
        oClassActiveUser.Password = "admin"


        Select Case oClassActiveUser.Verification
            Case ClassActiveUser.LoginResultEnum.Success
                'if success:
                '1. get all user information
                '2. get all Access Level list from user
                oClassActiveUser.GetUserInfo()
                oClassActiveUser.GetAccessLevel()
                Me.Close()
            Case ClassActiveUser.LoginResultEnum.FailedByUnregisterdID
                XtraMessageBox.Show("Username  was not registered.", "Unregistered Username", MessageBoxButtons.OK, MessageBoxIcon.Error)
                textEditUserName.Text = ""
                textEditPassword.Text = ""
                textEditUserName.Focus()
                Exit Sub
            Case ClassActiveUser.LoginResultEnum.FailedByUnMatchedPassword
                XtraMessageBox.Show("Wrong Password", "warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
                textEditPassword.Text = ""
                textEditPassword.Focus()
                Exit Sub

            Case Else
                XtraMessageBox.Show("Please Contact Your System Administrator, The application will now Shutdown", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End

        End Select
    End Sub
End Class
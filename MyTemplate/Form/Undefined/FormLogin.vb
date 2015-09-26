﻿Public Class FormLogin 

    Public Property iCount As Integer

    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CloseBox = False

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

        oClassActiveUser.Username = textEditUserName.Text
        oClassActiveUser.Password = textEditPassword.Text


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

                iCount += 1
                If iCount = 1 Then
                    alert.Show(Me, "", "2 Remaining Chances")
                ElseIf iCount = 2 Then
                    alert.Show(Me, "", "1 Remaining Chances")
                ElseIf iCount = 3 Then
                    oClassUser.username = textEditUserName.Text
                    oClassUser.LockUser()
                End If



                'Case Else
                '    XtraMessageBox.Show("Please Contact Your System Administrator, The application will now Shutdown", "Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                'End

        End Select

    End Sub

    Private Sub buttonCancel_Click(sender As Object, e As EventArgs) Handles buttonCancel.Click
        Application.Exit()
    End Sub
End Class
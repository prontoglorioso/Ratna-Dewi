Public Class FormUser

    Private Sub FormUser_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        SuspendLayout()
        MdiParent = MainForm
        ResumeLayout(True)
    End Sub

    Private Sub FormUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub startPoint()


    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        If textEditPassword.Text <> textEditReEnterPassword.Text Then
            MessageBox.Show("Password not Match")
            Exit Sub
        End If

        oClassUser.username = textEditUserName.Text
        oClassUser.userpassword = textEditPassword.Text
        oClassUser.userpassword2 = textEditReEnterPassword.Text
        oClassUser.RoleId = Convert.ToInt32(comboBoxRole.Text)

        oClassUser.EncryptPassword()
        oClassUser.set()


    End Sub
End Class
Public Class FormUser

    Public Property IsAll As Boolean

    Private Sub FormUser_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        SuspendLayout()
        MdiParent = MainForm
        ResumeLayout(True)
    End Sub

    Private Sub FormUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CanClose = True
        oClassUser.IsDeleted = False
        loadData()

    End Sub

    Sub startPoint()


    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        If textEditPassword.Text <> textEditReEnterPassword.Text Then MessageBox.Show("Password not Match")

        oClassUser.username = textEditUserName.Text
        oClassUser.userpassword = textEditPassword.Text
        oClassUser.userpassword2 = textEditReEnterPassword.Text
        oClassUser.RoleId = Convert.ToInt32(comboBoxRole.Text)

        oClassUser.EncryptPassword()
        oClassUser.set()
        CanClose = True
        loadData()
    End Sub

    Sub loadData()
        oClassUser.Get(IsAll)
        GridControl1.DataSource = Nothing
        GridControl1.DataSource = oClassUser.DataUser.Tables("DataUser")
        GridControl1.ResumeLayout()
        GridControl1.Refresh()
        GridView1.BestFitColumns(True)

        'GridView1.Columns(0).Visible = False
        'GridView1.Columns(2).Visible = False
        'GridView1.Columns(3).Visible = False

    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        oClassUser.id = Convert.ToInt32(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns(0)))

        If SimpleButton5.Text.ToLower = "restore" Then
            If XtraMessageBox.Show("Do You want to restore this data", "Perhatian", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                oClassUser.Del()
                loadData()
            End If
        Else
            If XtraMessageBox.Show("Do You want to delete this data", "Perhatian", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                oClassUser.Del()
                loadData()
            End If
        End If
        CanClose = True
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        SwitchMode(Me, True)


        IsNew = True
        CanClose = True
    End Sub

    Private Sub CheckEdit_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit.CheckedChanged
        If CheckEdit.CheckState = CheckState.Checked Then
            oClassUser.IsDeleted = True
            SimpleButton5.Text = "Restore"
        Else
            SimpleButton5.Text = "Delete"
            oClassUser.IsDeleted = False

        End If
        loadData()

    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        textEditUserName.Text = ""
        textEditPassword.Text = ""
        textEditReEnterPassword.Text = ""
        comboBoxRole.EditValue = ""

        CanClose = True
    End Sub
End Class
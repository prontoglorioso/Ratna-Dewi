Public Class DetailP1O

    Public Property idHeaderPO As Integer
    Private Sub DevTemplate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SetFormAttribute()
        CanClose = True
        LoadData()


    End Sub

    Private Sub buttonAdd_Click(sender As Object, e As EventArgs) Handles buttonAdd.Click
        SwitchMode(Me, True)
        IsNew = True

    End Sub


    Private Sub buttonDelete_Click(sender As Object, e As EventArgs) Handles buttonDelete.Click
        If XtraMessageBox.Show(String.Format("Do You really want to delete this data...?{0}{1}", vbNewLine, GridView1.GetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns(1))), "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then

            LoadData()

        End If
    End Sub

    Sub LoadData()

    End Sub

    Private Sub buttonSave_Click(sender As Object, e As EventArgs) Handles buttonSave.Click
        SwitchMode(Me, False)

        LoadData()

    End Sub


End Class

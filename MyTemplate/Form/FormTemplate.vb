Public Class FormTemplate 



    Private Sub FormTemplate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetFormAttribute()

        CanClose = True

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        SwitchMode(Me, True)
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Dim id As Integer = Convert.ToInt32(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns(0)))
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        If XtraMessageBox.Show("Apakah anda yakin akan menghapus data ini", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            
        End If
    End Sub

    Sub LoadData()
        GridControl1.SuspendLayout()
        GridControl1.DataSource = Nothing
        'Kelas.Get()
        'GridControl1.DataSource = Kelas.DataKelas.Tables("DataKelas")
        GridControl1.Refresh()
        GridControl1.Refresh()
        GridView1.BestFitColumns(True)
        GridView1.Columns(0).Visible = False
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        SwitchMode(Me, False)
        IsSaved = True
    End Sub
End Class
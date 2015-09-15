Public Class HeaderJV
    Sub LoadData()
        Me.JVHeaderTableAdapter.Fill(Me.DataSetJournalVoucher.JVHeaderDataTable)
        GridView1.BestFitColumns(True)
        GridView1.Columns(0).Visible = False
    End Sub
    Sub SaveData()
        Me.Validate()
        Me.JVHeaderDataTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetJournalVoucher)
    End Sub

    Private Sub HeaderJV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetJournalVoucher.JVHeaderDataTable' table. You can move, or remove it, as needed.
        LoadData()
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SimpleButton5_Click_1(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        If XtraMessageBox.Show("Apakah anda yakin akan menghapus data ini", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim row() As Integer = GridView1.GetSelectedRows
            If row.Count > 0 Then
                JVHeaderDataTableBindingSource.RemoveCurrent()
                SaveData()
                LoadData()
            End If
        End If
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        SaveData()
        SetMessage("Data Has Been Saved")
        LoadData()
    End Sub

    Private Sub ButtonDetail_Click(sender As Object, e As EventArgs) Handles ButtonDetail.Click
        idHeaderJV = Convert.ToInt32(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns(0)))
        DetailJV.IDHeaderJV = idHeaderJV
        DetailJV.ShowDialog()
    End Sub
End Class
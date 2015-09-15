Public Class HeaderSO 

    Sub LoadData()
        Me.SOHeaderTableAdapter.Fill(Me.DataSetSO.SOHeaderDataTable)
    End Sub
    Sub SaveData()
        Me.Validate()
        Me.SOHeaderDataTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetSO)
    End Sub

    Private Sub HeaderSO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetSO.SelectSubAccCOADataTable' table. You can move, or remove it, as needed.
        Me.SelectSubAccCOATableAdapter.Fill(Me.DataSetSO.SelectSubAccCOADataTable)
        'TODO: This line of code loads data into the 'DataSetSO.SelectCustomerDataTable' table. You can move, or remove it, as needed.
        Me.SelectCustomerTableAdapter.Fill(Me.DataSetSO.SelectCustomerDataTable)
        LoadData()

    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        If XtraMessageBox.Show("Apakah anda yakin akan menghapus data ini", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim row() As Integer = GridView1.GetSelectedRows
            If row.Count > 0 Then
                SOHeaderDataTableBindingSource.RemoveCurrent()
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
        Dim idHeaderSO As Integer
        idHeaderSO = Convert.ToInt32(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns(0)))
        DetailSO.idHeaderSO = idHeaderSO
        DetailSO.Show()

    End Sub
End Class
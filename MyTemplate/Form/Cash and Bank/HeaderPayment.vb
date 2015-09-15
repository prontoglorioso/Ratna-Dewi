Public Class HeaderPayment 
    Sub LoadData()
        Me.HeaderPaymentTableAdapter.Fill(Me.DataSetPayment.HeaderPaymentDataTable)
    End Sub
    Sub SaveData()
        Me.Validate()
        Me.HeaderPaymentDataTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetPayment)
    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click
        If XtraMessageBox.Show("Apakah anda yakin akan menghapus data ini", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Dim row() As Integer = GridView1.GetSelectedRows
            If row.Count > 0 Then
                HeaderPaymentDataTableBindingSource.RemoveCurrent()
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

    Private Sub HeaderPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetPayment.SelectSubAccCOADataTable' table. You can move, or remove it, as needed.
        Me.SelectSubAccCOATableAdapter.Fill(Me.DataSetPayment.SelectSubAccCOADataTable)
        'TODO: This line of code loads data into the 'DataSetPayment.SelectSubAccCOADataTable' table. You can move, or remove it, as needed.
        'Me.SelectSubAccCOADataTableTableAdapter.Fill(Me.DataSetPayment.SelectSubAccCOADataTable)
        LoadData()

    End Sub

    Private Sub ButtonDetail_Click(sender As Object, e As EventArgs) Handles ButtonDetail.Click
        Dim idHeaderPayment As Integer
        idHeaderPayment = Convert.ToInt32(GridView1.GetRowCellValue(GridView1.FocusedRowHandle, GridView1.Columns(0)))
        DetailPayment.idHeaderPayment = idHeaderPayment
        DetailPayment.Show()
    End Sub
End Class
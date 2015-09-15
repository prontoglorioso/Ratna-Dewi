Public Class DetailPayment 
    Public Property idHeaderPayment As Integer
#Region "DataHeader"
    Sub LoadHeader()
        Try
            Me.SelectHeaderPaymentDetailTableAdapter.Fill(Me.DataSetPayment.SelectHeaderPaymentDetailDataTable, New System.Nullable(Of Integer)(CType(idHeaderPayment, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region
    Private Sub DetailPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetPayment.SelectVendorDataTable' table. You can move, or remove it, as needed.
        Me.SelectVendorDataTableTableAdapter.Fill(Me.DataSetPayment.SelectVendorDataTable)
        'TODO: This line of code loads data into the 'DataSetPayment.SelectProjectDataTable' table. You can move, or remove it, as needed.
        Me.SelectProjectDataTableTableAdapter.Fill(Me.DataSetPayment.SelectProjectDataTable)
        'TODO: This line of code loads data into the 'DataSetPayment.SelectEmployeeDataTable' table. You can move, or remove it, as needed.
        Me.SelectEmployeeDataTableTableAdapter.Fill(Me.DataSetPayment.SelectEmployeeDataTable)
        'TODO: This line of code loads data into the 'DataSetPayment.SelectSubAccCOADataTable' table. You can move, or remove it, as needed.
        Me.SelectSubAccCOATableAdapter.Fill(Me.DataSetPayment.SelectSubAccCOADataTable)
        LoadHeader()
        LoadDetailPayment()

    End Sub
    Sub LoadDetailPayment()
        Try
            Me.PaymentDetailTableAdapter.Fill(Me.DataSetPayment.PaymentDetailDataTable, New System.Nullable(Of Integer)(CType(idHeaderPayment, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        GridView1.SetFocusedRowCellValue(colidHeaderPayment, IDTextBox.Text)
        GridView1.AddNewRow()
    End Sub

    Private Sub GridView1_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GridView1.InitNewRow
        GridView1.SetFocusedRowCellValue(colidHeaderPayment, IDTextBox.Text)
    End Sub
    Sub SaveDetailPayment()
        Me.Validate()
        Me.PaymentDetailDataTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetPayment)
    End Sub
    Sub DeleteDataDetail()
        Dim Row() As Integer = GridView1.GetSelectedRows
        If Row.Count > 0 Then
            PaymentDetailDataTableBindingSource.RemoveCurrent()
            SaveData()
        End If
    End Sub
    Sub SaveData()
        Me.Validate()
        Me.PaymentDetailDataTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetPayment)
    End Sub
    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        SaveDetailPayment()
    End Sub
    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        DeleteDataDetail()
    End Sub

    Private Sub LookUpEditEmployee_EditValueChanged(sender As Object, e As EventArgs) Handles LookUpEditEmployee.EditValueChanged
        'Dim editor As DevExpress.XtraEditors.LookUpEdit = CType(sender, DevExpress.XtraEditors.LookUpEdit)
        'Dim row As DataRowView = CType(editor.Properties.GetDataSourceRowByKeyValue(editor.EditValue), DataRowView)
        'Dim value As Object = row("id")
        'If value >= 0 Then
        '    LookUpEditVendor.e()
        'End If
    End Sub
End Class
Public Class DetailPO

    Public Property idHeaderPO As Integer

    Private Sub DetailPO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetPO.SelectProjectDataTable' table. You can move, or remove it, as needed.
        Me.SelectProjectTableAdapter.Fill(Me.DataSetPO.SelectProjectDataTable)
        'TODO: This line of code loads data into the 'DataSetPO.SelectTaxDataTable' table. You can move, or remove it, as needed.
        Me.SelectTaxTableAdapter.Fill(Me.DataSetPO.SelectTaxDataTable)
        'TODO: This line of code loads data into the 'DataSetPO.SelectItemPODetail' table. You can move, or remove it, as needed.
        Me.SelectItemPODetailTableAdapter.Fill(Me.DataSetPO.SelectItemPODetail)
        LoadDataHeader()
        LoadDataPODetail()
        Me.Text = "Purchase Order Detail"
    End Sub

    Sub LoadDataPODetail()
        Try
            Me.PODetailtableAdapter.Fill(Me.DataSetPO.PODetailDataTable, New System.Nullable(Of Integer)(CType(idHeaderPO, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Sub SaveDataPoDetail()
        Me.Validate()
        Me.PODetailDataTableBindingSource.EndEdit()
        Me.TableAdapterManagerPoDetail.UpdateAll(Me.DataSetPO)

    End Sub
    Sub LoadDataHeader()
        Try
            Me.SelectHeaderPO_DetailTableAdapter.Fill(Me.DataSetPO.SelectHeaderPO_Detail, New System.Nullable(Of Integer)(CType(idHeaderPO, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        GridView1.AddNewRow()

    End Sub

    Private Sub GridView1_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GridView1.InitNewRow
        GridView1.SetFocusedRowCellValue(colIDHeader, idHeaderPO)

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        SaveDataPoDetail()

    End Sub

    Sub DeleteDataDetail()
        Dim Row() As Integer = GridView1.GetSelectedRows
        If Row.Count > 0 Then
            PODetailDataTableBindingSource.RemoveCurrent()
            SaveDataPoDetail()

        End If
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        DeleteDataDetail()

    End Sub
End Class
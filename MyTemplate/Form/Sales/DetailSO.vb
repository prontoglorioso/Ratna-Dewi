Public Class DetailSO 
    Public Property idHeaderSO As Integer
    Sub SaveData()
        Me.Validate()
        Me.SODetailDataTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetSO)
    End Sub
    Sub LoadDataSODetail()
        Try
            Me.SODetailTableAdapter.Fill(Me.DataSetSO.SODetailDataTable, New System.Nullable(Of Integer)(CType(idHeaderSO, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub LoadDataHeader()
        Try
            Me.SelectHeaderSODetailTableAdapter.Fill(Me.DataSetSO.SelectHeaderSODetailDataTable, New System.Nullable(Of Integer)(CType(idHeaderSO, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub DetailSO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetSO.SelectProjectDataTable' table. You can move, or remove it, as needed.
        Me.SelectProjectDataTableTableAdapter.Fill(Me.DataSetSO.SelectProjectDataTable)
        'TODO: This line of code loads data into the 'DataSetSO.SelectTaxDataTable' table. You can move, or remove it, as needed.
        Me.SelectTaxTableAdapter.Fill(Me.DataSetSO.SelectTaxDataTable)
        'TODO: This line of code loads data into the 'DataSetSO.SelectItemDataTable' table. You can move, or remove it, as needed.
        Me.SelectItemTableAdapter.Fill(Me.DataSetSO.SelectItemDataTable)
        LoadDataHeader()
        LoadDataSODetail()

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        GridView1.SetFocusedRowCellValue(colIDHeader, TextEditIDHeaderSO.Text)
        GridView1.AddNewRow()

    End Sub

    Private Sub GridView1_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GridView1.InitNewRow
        GridView1.SetFocusedRowCellValue(colIDHeader, TextEditIDHeaderSO.Text)

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        SaveDetailSO()

    End Sub
    Sub SaveDetailSO()
        Me.Validate()
        Me.SODetailDataTableBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetSO)
    End Sub
    Sub DeleteDataDetail()
        Dim Row() As Integer = GridView1.GetSelectedRows
        If Row.Count > 0 Then
            SODetailDataTableBindingSource.RemoveCurrent()
            SaveDetailSO()

        End If
    End Sub
    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        DeleteDataDetail()
    End Sub
End Class
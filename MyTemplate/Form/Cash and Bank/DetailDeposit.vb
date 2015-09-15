Public Class DetailDeposit 
    Public Property idHeaderDeposit As Integer
#Region "DataHeader"
    Sub LoadHeader()
        Try
            Me.SelectHeaderDepositDetailTableAdapter.Fill(Me.DataSetDeposit.SelectHeaderDepositDetailDataTable, New System.Nullable(Of Integer)(CType(idHeaderDeposit, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
#End Region
    Sub LoadDetailDeposit()
        Try
            Me.DepositDetailTableAdapter.Fill(Me.DataSetDeposit.DepositDetailDataTable, New System.Nullable(Of Integer)(CType(idHeaderDeposit, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub DetailDeposit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetDeposit.SelectProjectDataTable' table. You can move, or remove it, as needed.
        Me.SelectProjectDataTableTableAdapter.Fill(Me.DataSetDeposit.SelectProjectDataTable)
        'TODO: This line of code loads data into the 'DataSetDeposit.SelectCustomerDataTable' table. You can move, or remove it, as needed.
        Me.SelectCustomerDataTableTableAdapter.Fill(Me.DataSetDeposit.SelectCustomerDataTable)
        'TODO: This line of code loads data into the 'DataSetDeposit.SelectEmployeeDataTable' table. You can move, or remove it, as needed.
        Me.SelectEmployeeDataTableTableAdapter.Fill(Me.DataSetDeposit.SelectEmployeeDataTable)
        'TODO: This line of code loads data into the 'DataSetDeposit.SelectSubAccCOADataTable' table. You can move, or remove it, as needed.
        Me.SelectSubAccCOADataTableTableAdapter.Fill(Me.DataSetDeposit.SelectSubAccCOADataTable)
        'TODO: This line of code loads data into the 'DataSetDeposit.HeaderDepositDataTable' table. You can move, or remove it, as needed.
        Me.HeaderDepositTableAdapter.Fill(Me.DataSetDeposit.HeaderDepositDataTable)
        LoadHeader()

        loadDetail()
    End Sub
   
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        GridView2.AddNewRow()
        GridView2.SetFocusedRowCellValue(colIDHeaderDeposit, IDTextBox.Text)
        'Me.DepositDetailDataTableBindingSource1.AddNew()


    End Sub

    Private Sub GridView2_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs)
        GridView2.SetFocusedRowCellValue(colIDHeaderDeposit, IDTextBox.Text)
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        SaveDetailDeposit()
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        DeleteDataDetail()
    End Sub
    Sub SaveDetailDeposit()
        Me.Validate()
        Me.DepositDetailDataTableBindingSource1.EndEdit()
        Me.TableAdapterManager1.UpdateAll(Me.DataSetDeposit1)

    End Sub
    Sub DeleteDataDetail()
        Dim Row() As Integer = GridView2.GetSelectedRows
        If Row.Count > 0 Then
            DepositDetailDataTableBindingSource1.RemoveCurrent()

        End If
    End Sub

    Sub loadDetail()
        Try
            Me.DepositDetailTableAdapter.Fill(Me.DataSetDeposit1.DepositDetailDataTable, New System.Nullable(Of Integer)(CType(idHeaderDeposit, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

End Class
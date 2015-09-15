Imports DevExpress.XtraReports.UI
Public Class DetailJV

    Public Property IDHeaderJV As Integer
    Public Property TotalCurrentDebit As Double
    Public Property TotalCurrentCredit As Double
    Public Property DifferencesBalance As Double

    Private Sub DetailJV_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetJournalVoucher.SelectEmployee' table. You can move, or remove it, as needed.
        Me.SelectEmployeeTableAdapter.Fill(Me.DataSetJournalVoucher.SelectEmployee)
        'TODO: This line of code loads data into the 'DataSetJournalVoucher.SelectVendor' table. You can move, or remove it, as needed.
        Me.SelectVendorTableAdapter.Fill(Me.DataSetJournalVoucher.SelectVendor)
        'TODO: This line of code loads data into the 'DataSetJournalVoucher.SelectCustomer' table. You can move, or remove it, as needed.
        Me.SelectCustomerTableAdapter.Fill(Me.DataSetJournalVoucher.SelectCustomer)
        'TODO: This line of code loads data into the 'DataSetJournalVoucher.SelectProjectDataTable' table. You can move, or remove it, as needed.
        Me.SelectProjectTableAdapter.Fill(Me.DataSetJournalVoucher.SelectProjectDataTable)
        'TODO: This line of code loads data into the 'DataSetJournalVoucher.SelectSubAccCOADataTable' table. You can move, or remove it, as needed.
        Me.SelectSubAccCOATableAdapter.Fill(Me.DataSetJournalVoucher.SelectSubAccCOADataTable)
        LoadDataHeader()
        LoadDataDetail()
    End Sub
    Sub LoadDataHeader()
        Try
            Me.SelectHeaderJVDetailTableAdapter.Fill(Me.DataSetJournalVoucher.SelectHeaderJVDetailDataTable, New System.Nullable(Of Integer)(CType(IDHeaderJV, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub LoadDataDetail()

        Try
            Me.JVDetailTableAdapter.Fill(Me.DataSetJournalVoucher.JVDetailDataTable, New System.Nullable(Of Integer)(CType(IDHeaderJV, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
        GridView1.BestFitColumns(True)
        GridView1.Columns(0).Visible = False
        GridView1.Columns(1).Visible = False
    End Sub
    Sub SaveDataJVDetail()
        ValidateAmount()

        If TotalCurrentDebit <> TotalCurrentCredit Then
            alert.Show(Me, "", "Unbalance By" & DifferencesBalance)

            Exit Sub

        End If
        Try
            Me.Validate()
            Me.JVDetailDataTableBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.DataSetJournalVoucher)
        Catch ex As Exception

        End Try


    End Sub
    Sub DeleteDataJVDetail()
        Dim Row() As Integer = GridView1.GetSelectedRows
        If Row.Count > 0 Then
            JVDetailDataTableBindingSource.RemoveCurrent()
        End If
    End Sub
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        GridView1.AddNewRow()
    End Sub

    Private Sub GridView1_CellValueChanged(sender As Object, e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        If e.Column.Name = "colDebit" Then
            Dim debit As Double = IIf(IsDBNull(GridView1.GetFocusedRowCellValue(colDebit)) = True, 0, GridView1.GetFocusedRowCellValue(colDebit))

            If debit > 0 Then
                GridView1.SetFocusedRowCellValue(colCredit, "")
            End If
        End If
        If e.Column.Name = "colCredit" Then
            Dim credit As Double = IIf(IsDBNull(GridView1.GetFocusedRowCellValue(colCredit)) = True, 0, GridView1.GetFocusedRowCellValue(colCredit))
            If credit > 0 Then
                GridView1.SetFocusedRowCellValue(colDebit, "")
            End If
        End If
    End Sub
    Private Sub GridView1_InitNewRow(sender As Object, e As DevExpress.XtraGrid.Views.Grid.InitNewRowEventArgs) Handles GridView1.InitNewRow
        GridView1.SetFocusedRowCellValue(colIDHeaderJV, IDHeaderJV)

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        SaveDataJVDetail()
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        DeleteDataJVDetail()
    End Sub
    Sub ValidateAmount()
        TotalCurrentDebit = GridView1.Columns(3).SummaryText
        TotalCurrentCredit = GridView1.Columns(4).SummaryText
        DifferencesBalance = TotalCurrentDebit - TotalCurrentCredit
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        LoadReport()
    End Sub
    Sub LoadReport()
        Try
            Me.ReportJVTableAdapter.Fill(Me.DataSetReport.ReportJV, LabelControl4.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

        Dim Report As New ReportJV With {.DataSource = DataSetReport.Tables("ReportJV"), .DataMember = "ReportJV"}
        Dim tool As New ReportPrintTool(Report)
        tool.ShowPreview()
    End Sub

End Class
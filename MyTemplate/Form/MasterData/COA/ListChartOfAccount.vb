Imports DevExpress.XtraReports.UI
Public Class ListChartOfAccount


    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        LoadPrint()

    End Sub
    Sub LoadPrint()
        Dim Report As New ReportChartOfAccount
        Dim tool As New ReportPrintTool(Report)
        tool.ShowPreview()
    End Sub

    Private Sub ListChartOfAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetList.SP_REPORT_BALANCE' table. You can move, or remove it, as needed.
        Me.SP_REPORT_BALANCETableAdapter.Fill(Me.DataSetList.SP_REPORT_BALANCE)

    End Sub
End Class
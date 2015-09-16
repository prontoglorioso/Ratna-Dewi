Imports DevExpress.XtraReports.UI
Public Class ListChartOfAccount


    Private Sub ListChartOfAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetList.ListSubAccountCOA' table. You can move, or remove it, as needed.
        Me.ListSubAccountCOATableAdapter.Fill(Me.DataSetList.ListSubAccountCOA)

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        LoadPrint()

    End Sub
    Sub LoadPrint()
        Me.ListSubAccountCOATableAdapter.Fill(Me.DataSetList.ListSubAccountCOA)
        Dim Report As New ReportChartOfAccount With {.DataSource = DataSetList.Tables("ListSubAccountCOA"), .DataMember = "ListSubAccountCOA"}
        Dim tool As New ReportPrintTool(Report)
        tool.ShowPreview()
    End Sub

End Class
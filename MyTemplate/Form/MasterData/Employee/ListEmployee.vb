Imports DevExpress.XtraReports.UI
Public Class ListEmployee

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        LoadPrint()
    End Sub

    Private Sub ListEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetList.ListEmployee' table. You can move, or remove it, as needed.
        Me.ListEmployeeTableAdapter.Fill(Me.DataSetList.ListEmployee)

    End Sub
    Sub LoadPrint()
        Me.ListEmployeeTableAdapter.Fill(Me.DataSetList.ListEmployee)
        Dim Report As New ReportEmployee With {.DataSource = DataSetList.Tables("ListEmployee"), .DataMember = "ListEmployee"}
        Dim tool As New ReportPrintTool(Report)
        tool.ShowPreview()
    End Sub
End Class
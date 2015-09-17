Imports DevExpress.XtraReports.UI
Public Class ListProject

    Private Sub ListProject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetList.ListProject' table. You can move, or remove it, as needed.
        Me.ListProjectTableAdapter.Fill(Me.DataSetList.ListProject)

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Loadprint()
    End Sub
    Sub Loadprint()
        Me.ListProjectTableAdapter.Fill(Me.DataSetList.ListProject)
        Dim Report As New ReportProject With {.DataSource = DataSetList.Tables("ListProject"), .DataMember = "ListProject"}
        Dim tool As New ReportPrintTool(Report)
        tool.ShowPreview()
    End Sub
End Class
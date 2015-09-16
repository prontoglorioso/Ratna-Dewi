Imports DevExpress.XtraReports.UI
Public Class ListItem

    Private Sub ListItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetList.ListItem' table. You can move, or remove it, as needed.
        Me.ListItemTableAdapter.Fill(Me.DataSetList.ListItem)

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        LoadPrint()

    End Sub
    Sub LoadPrint()
        Me.ListItemTableAdapter.Fill(Me.DataSetList.ListItem)
        Dim Report As New ReportListItem With {.DataSource = DataSetList.Tables("ListItem"), .DataMember = "ListItem"}
        Dim tool As New ReportPrintTool(Report)
        tool.ShowPreview()
    End Sub
End Class
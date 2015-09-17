Imports DevExpress.XtraReports.UI
Public Class ListTax

    Private Sub ListTax_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetList.ListTax' table. You can move, or remove it, as needed.
        Me.ListTaxTableAdapter.Fill(Me.DataSetList.ListTax)

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        LoadPrint()
    End Sub
    Sub LoadPrint()
        Me.ListTaxTableAdapter.Fill(Me.DataSetList.ListTax)
        Dim Report As New ReportTax With {.DataSource = DataSetList.Tables("ListTax"), .DataMember = "ListTax"}
        Dim tool As New ReportPrintTool(Report)
        tool.ShowPreview()
    End Sub
End Class
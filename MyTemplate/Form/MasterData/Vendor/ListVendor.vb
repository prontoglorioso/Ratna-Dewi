Imports DevExpress.XtraReports.UI
Public Class ListVendor

    Private Sub ListVendor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetList.ListVendor' table. You can move, or remove it, as needed.
        Me.ListVendorTableAdapter.Fill(Me.DataSetList.ListVendor)

    End Sub
    Sub LoadPrint()
        Me.ListVendorTableAdapter.Fill(Me.DataSetList.ListVendor)
        Dim Report As New ReportVendor With {.DataSource = DataSetList.Tables("ListVendor"), .DataMember = "ListVendor"}
        Dim tool As New ReportPrintTool(Report)
        tool.ShowPreview()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        LoadPrint()
    End Sub
End Class
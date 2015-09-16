Imports DevExpress.XtraReports.UI
Public Class ListCustomer

    Private Sub ListCustomer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetList.ListCustomer' table. You can move, or remove it, as needed.
        Me.ListCustomerTableAdapter.Fill(Me.DataSetList.ListCustomer)

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        LoadPrint()
    End Sub
    Sub LoadPrint()
        Me.ListCustomerTableAdapter.Fill(Me.DataSetList.ListCustomer)
        Dim Report As New ReportCustomer With {.DataSource = DataSetList.Tables("ListCustomer"), .DataMember = "ListCustomer"}
        Dim tool As New ReportPrintTool(Report)
        tool.ShowPreview()
    End Sub
End Class
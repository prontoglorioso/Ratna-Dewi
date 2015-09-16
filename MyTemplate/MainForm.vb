Public Class MainForm
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Shared Sub New()
        DevExpress.UserSkins.BonusSkins.Register()
        DevExpress.Skins.SkinManager.EnableFormSkins()

    End Sub
    Private Sub BarButtonItem2_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem2.ItemClick
        Dim newForm As New FormUser
        newForm.MdiParent = Me
        newForm.Show()
    End Sub
    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        StartPoint()
    End Sub
    Private Sub AppliedAL(ByVal e As Object)
        RibbonControl.Visible = True
        For Each item In e.items
            If IsNothing(item.Tag) OrElse item.Tag.ToString.Length = 0 Then
                Try
                    item.Enabled = True
                Catch ex As Exception

                End Try
                Continue For
            End If
            With oClassActiveUser.UserAccessLevel
                For iCount As Integer = 0 To .Rows.Count - 1
                    If item.Tag = .Rows(iCount)("IDModule").ToString Then
                        item.Enabled = Convert.ToBoolean(.Rows(iCount)("CanRead"))
                        Exit For
                    End If
                Next
            End With
        Next
    End Sub
    Sub StartPoint()
        RC.Read()
        sqlConn = New SqlClient.SqlConnection(RC.ConnectionString)
        FormLogin.ShowDialog()
        AppliedAL(RibbonControl)
    End Sub
    Private Sub BarButtonItem4_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem4.ItemClick
        Dim newForm As New FormTest
        newForm.MdiParent = Me
        newForm.Show()
    End Sub
    Private Sub BarButtonItem6_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem6.ItemClick
        Dim newForm As New FormVendor
        newForm.MdiParent = Me
        newForm.Show()
    End Sub
    Private Sub BarButtonItem10_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem10.ItemClick
        Dim newForm As New FormPosition
        newForm.MdiParent = Me
        newForm.Show()
    End Sub
    Private Sub BarButtonItem9_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem9.ItemClick
        Dim newForm As New FormEmployee
        newForm.MdiParent = Me
        newForm.Show()
    End Sub
    Private Sub BarButtonItem11_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem11.ItemClick
        Dim newForm As New FormProject
        newForm.MdiParent = Me
        newForm.Show()
    End Sub
    Private Sub BarButtonItem12_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem12.ItemClick
        Dim newForm As New COA
        newForm.MdiParent = Me
        newForm.Show()
    End Sub
    Private Sub BarButtonItem13_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem13.ItemClick
        Dim newForm As New FormTaxes
        newForm.MdiParent = Me
        newForm.Show()
    End Sub
    Private Sub BarButtonItem14_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem14.ItemClick
        Dim newForm As New FormItem
        newForm.MdiParent = Me
        newForm.Show()
    End Sub
    Private Sub BarButtonItem5_ItemClick_1(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem5.ItemClick
        Dim newForm As New FormCustomer
        newForm.MdiParent = Me
        newForm.Show()
    End Sub
    Private Sub BarButtonItem15_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem15.ItemClick
        Dim newForm As New FormHeaderItem
        newForm.MdiParent = Me
        newForm.Show()
    End Sub
    Private Sub BarButtonItem22_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem22.ItemClick
        Dim newForm As New HeaderPO
        newForm.MdiParent = Me
        newForm.Show()
    End Sub
    Private Sub BarButtonItem23_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem23.ItemClick
        'Dim newForm As New HeaderRI
        'newForm.MdiParent = Me
        'newForm.Show()
    End Sub
    Private Sub BarButtonItem24_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem24.ItemClick
        Dim newForm As New HeaderPI
        newForm.MdiParent = Me
        newForm.Show()
    End Sub
    Private Sub BarButtonItem25_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem25.ItemClick
        Dim newForm As New HeaderPP
        newForm.MdiParent = Me
        newForm.Show()
    End Sub
    Private Sub BarButtonItem39_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem39.ItemClick
        Dim newForm As New HeaderSO
        newForm.MdiParent = Me
        newForm.Show()
    End Sub
    Private Sub BarButtonItem40_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem40.ItemClick
        Dim newForm As New HeaderDO
        newForm.MdiParent = Me
        newForm.Show()
    End Sub
    Private Sub BarButtonItem41_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem41.ItemClick
        Dim newForm As New HeaderSI
        newForm.MdiParent = Me
        newForm.Show()
    End Sub
    Private Sub BarButtonItem42_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem42.ItemClick
        Dim newForm As New HeaderSR
        newForm.MdiParent = Me
        newForm.Show()
    End Sub
    Private Sub BarButtonItem28_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem28.ItemClick
        Dim newForm As New HeaderDeposit
        newForm.MdiParent = Me
        newForm.Show()
    End Sub
    Private Sub BarButtonItem27_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem27.ItemClick
        Dim newForm As New HeaderPayment
        newForm.MdiParent = Me
        newForm.Show()
    End Sub
    Private Sub BarButtonItem26_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem26.ItemClick
        Dim newForm As New HeaderJV
        newForm.MdiParent = Me
        newForm.Show()
    End Sub
    Private Sub BarButtonItem44_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem44.ItemClick

    End Sub
    Private Sub BarButtonItem49_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem49.ItemClick
        System.Diagnostics.Process.Start("calc.exe")
    End Sub
    Private Sub BarButtonItem48_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem48.ItemClick
        System.Diagnostics.Process.Start("notepad.exe")
    End Sub
    Private Sub BarButtonItem50_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem50.ItemClick
        Dim newForm As New RichEdit
        newForm.MdiParent = Me
        newForm.Show()
    End Sub
    Private Sub BarButtonItem46_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem46.ItemClick
        Dim newForm As New Spreadsheet
        newForm.MdiParent = Me
        newForm.Show()
    End Sub
    Private Sub BarButtonItem47_ItemClick(sender As Object, e As DevExpress.XtraBars.ItemClickEventArgs) Handles BarButtonItem47.ItemClick
        Dim newForm As New PDF_Reader
        newForm.MdiParent = Me
        newForm.Show()
    End Sub

    Private Sub NavBarItem13_LinkPressed(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem13.LinkPressed
        Dim newForm As New ListItem
        newForm.MdiParent = Me
        newForm.Show()
    End Sub

    Private Sub NavBarItem18_LinkPressed(sender As Object, e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem18.LinkPressed
        Dim newForm As New ListChartOfAccount
        newForm.MdiParent = Me
        newForm.Show()
    End Sub
End Class
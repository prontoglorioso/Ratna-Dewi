Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.SqlTypes

Module ModuleDeclaration

#Region "SQLClient Related Object"
    Public sqlConn As SqlConnection
    Public SqlCMD As SqlCommand
    Public sqldr As SqlDataReader
    Public sqlDA As SqlDataAdapter
    Public sqlTrn As SqlTransaction
#End Region

#Region "Public Variables"
    Public RC As New ReadConfig
    Public oClassUser As New ClassUser
    Public oClassActiveUser As New ClassActiveUser
    'Public oClassJabatan As New ClassJabatan
    Public oCustomer As New ClassCustomer
    Public oVendor As New ClassVendor
    Public oHelper As New ClassHelper
    Public oPosition As New ClassPosition
    Public oEmployee As New ClassEmployee
    Public oProject As New ClassProject
    Public oSubAccCOA As New ClassCOA
    Public oTax As New ClassTax
    Public oHeaderItem As New ClassHeaderItem
    Public oItem As New ClassItem
#End Region

#Region "Routine Database Connection"
    Public Function dbOpen() As Boolean
        Try
            If sqlConn.State <> ConnectionState.Open Then
                sqlConn.Open()
            End If
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Sub dbClose()
        If sqlConn.State = ConnectionState.Open Then
            sqlConn.Close()
        End If
    End Sub
#End Region
    Public alert As New AlertControl

#Region "Empty Text"
    Public Sub EmptyTxt(ByVal Frm As Form)
        Dim Ctl As Control
        For Each Ctl In Frm.Controls
            If TypeOf Ctl Is DevExpress.XtraEditors.TextEdit Then CType(Ctl, DevExpress.XtraEditors.TextEdit).EditValue = ""
            If TypeOf Ctl Is DevExpress.XtraEditors.GroupControl Then
                Dim Ctl1 As Control
                For Each Ctl1 In Ctl.Controls
                    If TypeOf Ctl1 Is DevExpress.XtraEditors.TextEdit Then
                        Ctl1.Text = ""
                    End If
                Next
            End If
        Next
    End Sub
#End Region

#Region "ToolTip"
    Public Sub SetMessage(ByVal x As String)
        MainForm.toolTip.HideHint()
        MainForm.toolTip.ShowHint(x, MainForm.RibbonStatusBar, DevExpress.Utils.ToolTipLocation.RightCenter)
    End Sub
#End Region
End Module

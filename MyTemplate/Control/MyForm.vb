Imports System.ComponentModel

Public Class MyForm
    Inherits DevExpress.XtraEditors.XtraForm

    Public Structure FormAttributesData
        Public CanAdd As Boolean
        Public CanEdit As Boolean
        Public CanDelete As Boolean

    End Structure

    Public Enum ViewModeEnum
        ReadMode = 1
        EditMode = 0

    End Enum


    <Browsable(False), DefaultValue(True)> _
    Public Property IsNew As Boolean
    Public Property ID As Integer
    <Browsable(False), DefaultValue(False)> _
    Public Property IsSaved As Boolean

    <Browsable(False), DefaultValue(False)> _
    Public Property CanClose As Boolean


    Public FormAttribute As FormAttributesData

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        StartPosition = FormStartPosition.CenterScreen

    End Sub

    Public Sub SetFormAttribute()
        If Me.Tag Is Nothing OrElse Me.Tag.ToString.Length = 0 Then Exit Sub

        Dim strFilter As String = "IDModule=" & Me.Tag
        Dim aRow() As DataRow = oClassActiveUser.UserAccessLevel.Select(strFilter)

        If aRow.Count = 0 Then
            With FormAttribute
                .CanAdd = False
                .CanDelete = False
                .CanEdit = False

            End With
        Else
            With FormAttribute
                .CanAdd = Convert.ToBoolean(aRow(0)("CanAdd"))
                .CanEdit = Convert.ToBoolean(aRow(0)("CanEdit"))
                .CanDelete = Convert.ToBoolean(aRow(0)("CanDelete"))
            End With
        End If

        AppliedAC(Me, True)
    End Sub

    Private Sub AppliedAC(ByVal _ControlContainer As Object, Optional ByVal ViewMode As ViewModeEnum = MyForm.ViewModeEnum.ReadMode)
        For Each oCtrl As Control In _ControlContainer.Controls
            If oCtrl.Tag Is Nothing OrElse oCtrl.Tag.ToString.Length = 0 Then
                If oCtrl.HasChildren Then
                    AppliedAC(oCtrl)
                End If
                Continue For
            End If

            Select Case oCtrl.Tag.ToString.ToLower
                Case "view"
                    oCtrl.Enabled = CBool(ViewMode)
                Case "input"
                    oCtrl.Enabled = Not CBool(ViewMode)
                Case "add"
                    oCtrl.Enabled = FormAttribute.CanAdd
                Case "edit"
                    oCtrl.Enabled = FormAttribute.CanEdit
                Case "save"
                    oCtrl.Enabled = Not CBool(ViewMode)
                Case "cancel"
                    oCtrl.Enabled = True
            End Select

            If TypeOf oCtrl Is LabelControl OrElse TypeOf oCtrl Is GroupControl Then
                oCtrl.Enabled = True
            End If

            If oCtrl.HasChildren Then
                AppliedAC(oCtrl)
            End If
        Next

    End Sub

    Public Sub SwitchMode(ByVal _ControlContainer As Object, Optional ByVal IsEditMode As Boolean = False)

        For Each oCtrl As Control In _ControlContainer.Controls
            If oCtrl.Tag Is Nothing OrElse oCtrl.Tag.ToString.Length = 0 Then
                If oCtrl.HasChildren Then
                    SwitchMode(oCtrl, IsEditMode)
                End If
                Continue For
            End If

            Select Case oCtrl.Tag.ToString.ToLower
                Case "view"
                    oCtrl.Enabled = Not IsEditMode
                Case "input"
                    oCtrl.Enabled = IsEditMode
                Case "add"
                    oCtrl.Enabled = Not IsEditMode
                Case "edit"
                    oCtrl.Enabled = Not IsEditMode
                Case "delete"
                    oCtrl.Enabled = Not IsEditMode
                Case "save"
                    oCtrl.Enabled = IsEditMode
                Case "cancel"
                    oCtrl.Enabled = True


            End Select

            If TypeOf oCtrl Is LabelControl OrElse TypeOf oCtrl Is GroupControl Then
                oCtrl.Enabled = True

            End If

            If oCtrl.HasChildren Then
                SwitchMode(oCtrl, IsEditMode)
            End If

        Next
        If Not IsEditMode Then
            AppliedAC(Me, ViewModeEnum.ReadMode)
        End If
    End Sub

    Private Sub MyForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        SuspendLayout()
        MdiParent = MainForm
        ResumeLayout(True)
    End Sub

    Private Sub MyForm_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Not CanClose Then e.Cancel = True

    End Sub

    Private Sub MyForm_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        Try
            'toostrip
        Catch ex As Exception

        End Try
    End Sub

    Private Sub MyForm_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        Try
            CanClose = False
            If Not Me.Tag Is Nothing Or Me.Tag.ToString.Length > 0 Then
                SetFormAttribute()

            End If
        Catch ex As Exception

        End Try
    End Sub
End Class

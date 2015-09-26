Imports System.ComponentModel
Imports DevExpress.LookAndFeel
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports Microsoft.VisualBasic.CompilerServices

<DesignerGenerated()> _
Partial Class FormUser
    Inherits MyForm

    'Form overrides dispose to clean up the component list.
    <DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUser))
        Me.GroupControl1 = New DevExpress.XtraEditors.GroupControl()
        Me.CheckEdit = New DevExpress.XtraEditors.CheckEdit()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GroupControl2 = New DevExpress.XtraEditors.GroupControl()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.GroupControl3 = New DevExpress.XtraEditors.GroupControl()
        Me.comboBoxRole = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.textEditReEnterPassword = New DevExpress.XtraEditors.TextEdit()
        Me.textEditPassword = New DevExpress.XtraEditors.TextEdit()
        Me.textEditUserName = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl1.SuspendLayout()
        CType(Me.CheckEdit.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl2.SuspendLayout()
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupControl3.SuspendLayout()
        CType(Me.comboBoxRole.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textEditReEnterPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textEditPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textEditUserName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupControl1
        '
        Me.GroupControl1.Controls.Add(Me.CheckEdit)
        Me.GroupControl1.Controls.Add(Me.GridControl1)
        Me.GroupControl1.Location = New System.Drawing.Point(434, 13)
        Me.GroupControl1.Name = "GroupControl1"
        Me.GroupControl1.Size = New System.Drawing.Size(688, 290)
        Me.GroupControl1.TabIndex = 0
        Me.GroupControl1.Text = "User List"
        '
        'CheckEdit
        '
        Me.CheckEdit.Location = New System.Drawing.Point(157, 2)
        Me.CheckEdit.Name = "CheckEdit"
        Me.CheckEdit.Properties.Caption = "Tampilkan User yang tidak aktif"
        Me.CheckEdit.Size = New System.Drawing.Size(209, 22)
        Me.CheckEdit.TabIndex = 3
        '
        'GridControl1
        '
        Me.GridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(2, 22)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(684, 266)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'GroupControl2
        '
        Me.GroupControl2.Controls.Add(Me.SimpleButton4)
        Me.GroupControl2.Controls.Add(Me.SimpleButton3)
        Me.GroupControl2.Controls.Add(Me.SimpleButton5)
        Me.GroupControl2.Controls.Add(Me.SimpleButton1)
        Me.GroupControl2.Location = New System.Drawing.Point(12, 225)
        Me.GroupControl2.Name = "GroupControl2"
        Me.GroupControl2.Size = New System.Drawing.Size(416, 78)
        Me.GroupControl2.TabIndex = 1
        Me.GroupControl2.Text = "Command Area"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Image = CType(resources.GetObject("SimpleButton4.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(249, 40)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton4.TabIndex = 2
        Me.SimpleButton4.Tag = "cancel"
        Me.SimpleButton4.Text = "Cancel"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(167, 40)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(76, 23)
        Me.SimpleButton3.TabIndex = 2
        Me.SimpleButton3.Tag = "save"
        Me.SimpleButton3.Text = "Save"
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Image = CType(resources.GetObject("SimpleButton5.Image"), System.Drawing.Image)
        Me.SimpleButton5.Location = New System.Drawing.Point(86, 40)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton5.TabIndex = 3
        Me.SimpleButton5.Tag = "delete"
        Me.SimpleButton5.Text = "Delete"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(5, 40)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 0
        Me.SimpleButton1.Tag = "add"
        Me.SimpleButton1.Text = "Add"
        '
        'GroupControl3
        '
        Me.GroupControl3.Controls.Add(Me.comboBoxRole)
        Me.GroupControl3.Controls.Add(Me.textEditReEnterPassword)
        Me.GroupControl3.Controls.Add(Me.textEditPassword)
        Me.GroupControl3.Controls.Add(Me.textEditUserName)
        Me.GroupControl3.Controls.Add(Me.LabelControl4)
        Me.GroupControl3.Controls.Add(Me.LabelControl3)
        Me.GroupControl3.Controls.Add(Me.LabelControl2)
        Me.GroupControl3.Controls.Add(Me.LabelControl1)
        Me.GroupControl3.Location = New System.Drawing.Point(12, 12)
        Me.GroupControl3.Name = "GroupControl3"
        Me.GroupControl3.Size = New System.Drawing.Size(416, 207)
        Me.GroupControl3.TabIndex = 2
        Me.GroupControl3.Text = "Editor"
        '
        'comboBoxRole
        '
        Me.comboBoxRole.Location = New System.Drawing.Point(142, 135)
        Me.comboBoxRole.Name = "comboBoxRole"
        Me.comboBoxRole.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.comboBoxRole.Properties.Items.AddRange(New Object() {"1", "2"})
        Me.comboBoxRole.Size = New System.Drawing.Size(263, 20)
        Me.comboBoxRole.TabIndex = 7
        Me.comboBoxRole.Tag = "input"
        '
        'textEditReEnterPassword
        '
        Me.textEditReEnterPassword.Location = New System.Drawing.Point(142, 102)
        Me.textEditReEnterPassword.Name = "textEditReEnterPassword"
        Me.textEditReEnterPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.textEditReEnterPassword.Properties.UseSystemPasswordChar = True
        Me.textEditReEnterPassword.Size = New System.Drawing.Size(263, 20)
        Me.textEditReEnterPassword.TabIndex = 6
        Me.textEditReEnterPassword.Tag = "input"
        '
        'textEditPassword
        '
        Me.textEditPassword.Location = New System.Drawing.Point(142, 69)
        Me.textEditPassword.Name = "textEditPassword"
        Me.textEditPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.textEditPassword.Properties.UseSystemPasswordChar = True
        Me.textEditPassword.Size = New System.Drawing.Size(263, 20)
        Me.textEditPassword.TabIndex = 5
        Me.textEditPassword.Tag = "input"
        '
        'textEditUserName
        '
        Me.textEditUserName.Location = New System.Drawing.Point(142, 36)
        Me.textEditUserName.Name = "textEditUserName"
        Me.textEditUserName.Size = New System.Drawing.Size(263, 20)
        Me.textEditUserName.TabIndex = 4
        Me.textEditUserName.Tag = "input"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(14, 138)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(21, 13)
        Me.LabelControl4.TabIndex = 3
        Me.LabelControl4.Text = "Role"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(14, 105)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(92, 13)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "Re-enter Password"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(14, 72)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Password"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(14, 39)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "User Name"
        '
        'FormUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1134, 310)
        Me.Controls.Add(Me.GroupControl3)
        Me.Controls.Add(Me.GroupControl2)
        Me.Controls.Add(Me.GroupControl1)
        Me.Name = "FormUser"
        Me.Tag = "1100"
        Me.Text = "FormUser"
        CType(Me.GroupControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl1.ResumeLayout(False)
        CType(Me.CheckEdit.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GroupControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl2.ResumeLayout(False)
        CType(Me.GroupControl3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupControl3.ResumeLayout(False)
        Me.GroupControl3.PerformLayout()
        CType(Me.comboBoxRole.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textEditReEnterPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textEditPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textEditUserName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupControl1 As GroupControl
    Friend WithEvents GridControl1 As GridControl
    Friend WithEvents GridView1 As GridView
    Friend WithEvents GroupControl2 As GroupControl
    Friend WithEvents SimpleButton4 As SimpleButton
    Friend WithEvents SimpleButton3 As SimpleButton
    Friend WithEvents SimpleButton5 As SimpleButton
    Friend WithEvents SimpleButton1 As SimpleButton
    Friend WithEvents GroupControl3 As GroupControl
    Friend WithEvents comboBoxRole As ComboBoxEdit
    Friend WithEvents textEditReEnterPassword As TextEdit
    Friend WithEvents textEditPassword As TextEdit
    Friend WithEvents textEditUserName As TextEdit
    Friend WithEvents LabelControl4 As LabelControl
    Friend WithEvents LabelControl3 As LabelControl
    Friend WithEvents LabelControl2 As LabelControl
    Friend WithEvents LabelControl1 As LabelControl
    Friend WithEvents CheckEdit As DevExpress.XtraEditors.CheckEdit
End Class

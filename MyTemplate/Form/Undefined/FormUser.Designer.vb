<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUser
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormUser))
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.comboBoxRole = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.textEditReEnterPassword = New DevExpress.XtraEditors.TextEdit()
        Me.textEditPassword = New DevExpress.XtraEditors.TextEdit()
        Me.textEditUserName = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.comboBoxRole.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textEditReEnterPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textEditPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textEditUserName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridControl1.Location = New System.Drawing.Point(12, 123)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(820, 360)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Image = CType(resources.GetObject("SimpleButton4.Image"), System.Drawing.Image)
        Me.SimpleButton4.Location = New System.Drawing.Point(346, 22)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton4.TabIndex = 2
        Me.SimpleButton4.Tag = "cancel"
        Me.SimpleButton4.Text = "Cancel"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Image = CType(resources.GetObject("SimpleButton3.Image"), System.Drawing.Image)
        Me.SimpleButton3.Location = New System.Drawing.Point(264, 22)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(76, 23)
        Me.SimpleButton3.TabIndex = 2
        Me.SimpleButton3.Tag = "save"
        Me.SimpleButton3.Text = "Save"
        '
        'SimpleButton5
        '
        Me.SimpleButton5.Image = CType(resources.GetObject("SimpleButton5.Image"), System.Drawing.Image)
        Me.SimpleButton5.Location = New System.Drawing.Point(183, 22)
        Me.SimpleButton5.Name = "SimpleButton5"
        Me.SimpleButton5.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton5.TabIndex = 3
        Me.SimpleButton5.Tag = "view"
        Me.SimpleButton5.Text = "Delete"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"), System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(102, 22)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton2.TabIndex = 1
        Me.SimpleButton2.Tag = "edit"
        Me.SimpleButton2.Text = "Edit"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(21, 22)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
        Me.SimpleButton1.TabIndex = 0
        Me.SimpleButton1.Tag = "add"
        Me.SimpleButton1.Text = "Add"
        '
        'comboBoxRole
        '
        Me.comboBoxRole.Location = New System.Drawing.Point(569, 97)
        Me.comboBoxRole.Name = "comboBoxRole"
        Me.comboBoxRole.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.comboBoxRole.Properties.Items.AddRange(New Object() {"1", "2"})
        ' = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.comboBoxRole.Size = New System.Drawing.Size(263, 20)
        Me.comboBoxRole.TabIndex = 7
        Me.comboBoxRole.Tag = "input"
        '
        'textEditReEnterPassword
        '
        Me.textEditReEnterPassword.Location = New System.Drawing.Point(569, 64)
        Me.textEditReEnterPassword.Name = "textEditReEnterPassword"
        ' = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.textEditReEnterPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.textEditReEnterPassword.Properties.UseSystemPasswordChar = True
        Me.textEditReEnterPassword.Size = New System.Drawing.Size(263, 20)
        Me.textEditReEnterPassword.TabIndex = 6
        Me.textEditReEnterPassword.Tag = "input"
        '
        'textEditPassword
        '
        Me.textEditPassword.Location = New System.Drawing.Point(149, 97)
        Me.textEditPassword.Name = "textEditPassword"
        ' = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.textEditPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.textEditPassword.Properties.UseSystemPasswordChar = True
        Me.textEditPassword.Size = New System.Drawing.Size(263, 20)
        Me.textEditPassword.TabIndex = 5
        Me.textEditPassword.Tag = "input"
        '
        'textEditUserName
        '
        Me.textEditUserName.Location = New System.Drawing.Point(149, 64)
        Me.textEditUserName.Name = "textEditUserName"
        ' = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.textEditUserName.Size = New System.Drawing.Size(263, 20)
        Me.textEditUserName.TabIndex = 4
        Me.textEditUserName.Tag = "input"
        '
        'LabelControl4
        '
        Me.LabelControl4.Location = New System.Drawing.Point(441, 100)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(21, 13)
        Me.LabelControl4.TabIndex = 3
        Me.LabelControl4.Text = "Role"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(441, 67)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(92, 13)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "Re-enter Password"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(21, 100)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Password"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(21, 67)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "User Name"
        '
        'FormUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(917, 520)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.comboBoxRole)
        Me.Controls.Add(Me.textEditReEnterPassword)
        Me.Controls.Add(Me.SimpleButton4)
        Me.Controls.Add(Me.textEditPassword)
        Me.Controls.Add(Me.textEditUserName)
        Me.Controls.Add(Me.SimpleButton3)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.SimpleButton5)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Name = "FormUser"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "1100"
        Me.Text = "FormUser"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.comboBoxRole.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textEditReEnterPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textEditPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textEditUserName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents comboBoxRole As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents textEditReEnterPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents textEditPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents textEditUserName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class

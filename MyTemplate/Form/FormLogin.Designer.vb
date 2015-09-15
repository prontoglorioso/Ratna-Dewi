<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormLogin))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.textEditUserName = New DevExpress.XtraEditors.TextEdit()
        Me.textEditPassword = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.buttonLogin = New DevExpress.XtraEditors.SimpleButton()
        Me.buttonCancel = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.textEditUserName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textEditPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 12)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(52, 13)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "User Name"
        '
        'textEditUserName
        '
        Me.textEditUserName.Location = New System.Drawing.Point(12, 31)
        Me.textEditUserName.Name = "textEditUserName"
        Me.textEditUserName.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.textEditUserName.Size = New System.Drawing.Size(380, 20)
        Me.textEditUserName.TabIndex = 1
        '
        'textEditPassword
        '
        Me.textEditPassword.Location = New System.Drawing.Point(12, 94)
        Me.textEditPassword.Name = "textEditPassword"
        Me.textEditPassword.Properties.LookAndFeel.TouchUIMode = DevExpress.LookAndFeel.TouchUIMode.[False]
        Me.textEditPassword.Size = New System.Drawing.Size(380, 20)
        Me.textEditPassword.TabIndex = 2
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 75)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(46, 13)
        Me.LabelControl2.TabIndex = 3
        Me.LabelControl2.Text = "Password"
        '
        'buttonLogin
        '
        Me.buttonLogin.Image = CType(resources.GetObject("buttonLogin.Image"), System.Drawing.Image)
        Me.buttonLogin.Location = New System.Drawing.Point(123, 130)
        Me.buttonLogin.Name = "buttonLogin"
        Me.buttonLogin.Size = New System.Drawing.Size(75, 23)
        Me.buttonLogin.TabIndex = 4
        Me.buttonLogin.Tag = ""
        Me.buttonLogin.Text = "Login"
        '
        'buttonCancel
        '
        Me.buttonCancel.Image = CType(resources.GetObject("buttonCancel.Image"), System.Drawing.Image)
        Me.buttonCancel.Location = New System.Drawing.Point(204, 130)
        Me.buttonCancel.Name = "buttonCancel"
        Me.buttonCancel.Size = New System.Drawing.Size(75, 23)
        Me.buttonCancel.TabIndex = 5
        Me.buttonCancel.Text = "Cancel"
        '
        'FormLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 164)
        Me.ControlBox = False
        Me.Controls.Add(Me.buttonCancel)
        Me.Controls.Add(Me.buttonLogin)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.textEditPassword)
        Me.Controls.Add(Me.textEditUserName)
        Me.Controls.Add(Me.LabelControl1)
        Me.Name = "FormLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.textEditUserName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textEditPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents textEditUserName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents textEditPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents buttonLogin As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents buttonCancel As DevExpress.XtraEditors.SimpleButton
End Class

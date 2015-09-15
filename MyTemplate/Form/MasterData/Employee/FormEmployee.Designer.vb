<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEmployee
    Inherits MyForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEmployee))
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.txtGapok = New DevExpress.XtraEditors.TextEdit()
        Me.txtNamaKaryawan = New DevExpress.XtraEditors.TextEdit()
        Me.LabelControl11 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.BtnCancelDept = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnSaveDept = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnDelDept = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnEditDept = New DevExpress.XtraEditors.SimpleButton()
        Me.BtnAddDept = New DevExpress.XtraEditors.SimpleButton()
        Me.DateTglBergabung = New DevExpress.XtraEditors.DateEdit()
        Me.LookUpDept = New DevExpress.XtraEditors.LookUpEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.TableAdapterManager = New MyTemplate.DataSetReportTableAdapters.TableAdapterManager()
        Me.DataSetReport = New MyTemplate.DataSetReport()
        Me.ReportEmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportEmployeeTableAdapter = New MyTemplate.DataSetReportTableAdapters.ReportEmployeeTableAdapter()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGapok.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNamaKaryawan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateTglBergabung.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DateTglBergabung.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LookUpDept.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetReport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReportEmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Cursor = System.Windows.Forms.Cursors.Default
        Me.GridControl1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridControl1.Location = New System.Drawing.Point(380, 50)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(793, 211)
        Me.GridControl1.TabIndex = 79
        Me.GridControl1.Tag = "view"
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsFind.AlwaysVisible = True
        '
        'txtGapok
        '
        Me.txtGapok.Location = New System.Drawing.Point(145, 139)
        Me.txtGapok.Name = "txtGapok"
        Me.txtGapok.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGapok.Properties.Appearance.Options.UseFont = True
        Me.txtGapok.Properties.DisplayFormat.FormatString = "n"
        Me.txtGapok.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtGapok.Properties.EditFormat.FormatString = "n"
        Me.txtGapok.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.txtGapok.Properties.Mask.EditMask = "c"
        Me.txtGapok.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.txtGapok.Size = New System.Drawing.Size(220, 20)
        Me.txtGapok.TabIndex = 8
        Me.txtGapok.Tag = "input"
        '
        'txtNamaKaryawan
        '
        Me.txtNamaKaryawan.Location = New System.Drawing.Point(145, 81)
        Me.txtNamaKaryawan.Name = "txtNamaKaryawan"
        Me.txtNamaKaryawan.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNamaKaryawan.Properties.Appearance.Options.UseFont = True
        Me.txtNamaKaryawan.Properties.MaxLength = 50
        Me.txtNamaKaryawan.Size = New System.Drawing.Size(220, 20)
        Me.txtNamaKaryawan.TabIndex = 6
        Me.txtNamaKaryawan.Tag = "input"
        '
        'LabelControl11
        '
        Me.LabelControl11.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl11.Location = New System.Drawing.Point(19, 84)
        Me.LabelControl11.Name = "LabelControl11"
        Me.LabelControl11.Size = New System.Drawing.Size(29, 13)
        Me.LabelControl11.TabIndex = 68
        Me.LabelControl11.Text = "Name"
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Location = New System.Drawing.Point(19, 142)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(73, 13)
        Me.LabelControl10.TabIndex = 67
        Me.LabelControl10.Text = "Salary Balance"
        '
        'LabelControl5
        '
        Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl5.Location = New System.Drawing.Point(19, 113)
        Me.LabelControl5.Name = "LabelControl5"
        Me.LabelControl5.Size = New System.Drawing.Size(110, 13)
        Me.LabelControl5.TabIndex = 63
        Me.LabelControl5.Text = "Started Worked From"
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(19, 54)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(42, 13)
        Me.LabelControl1.TabIndex = 59
        Me.LabelControl1.Text = "Position"
        '
        'BtnCancelDept
        '
        Me.BtnCancelDept.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnCancelDept.Appearance.Options.UseFont = True
        Me.BtnCancelDept.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.BtnCancelDept.Image = CType(resources.GetObject("BtnCancelDept.Image"), System.Drawing.Image)
        Me.BtnCancelDept.Location = New System.Drawing.Point(19, 221)
        Me.BtnCancelDept.Name = "BtnCancelDept"
        Me.BtnCancelDept.Size = New System.Drawing.Size(339, 21)
        Me.BtnCancelDept.TabIndex = 4
        Me.BtnCancelDept.Tag = "cancel"
        Me.BtnCancelDept.Text = "Cancel"
        '
        'BtnSaveDept
        '
        Me.BtnSaveDept.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSaveDept.Appearance.Options.UseFont = True
        Me.BtnSaveDept.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.BtnSaveDept.Image = CType(resources.GetObject("BtnSaveDept.Image"), System.Drawing.Image)
        Me.BtnSaveDept.Location = New System.Drawing.Point(278, 175)
        Me.BtnSaveDept.Name = "BtnSaveDept"
        Me.BtnSaveDept.Size = New System.Drawing.Size(80, 40)
        Me.BtnSaveDept.TabIndex = 3
        Me.BtnSaveDept.Tag = "save"
        Me.BtnSaveDept.Text = "Save"
        '
        'BtnDelDept
        '
        Me.BtnDelDept.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnDelDept.Appearance.Options.UseFont = True
        Me.BtnDelDept.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.BtnDelDept.Image = CType(resources.GetObject("BtnDelDept.Image"), System.Drawing.Image)
        Me.BtnDelDept.Location = New System.Drawing.Point(192, 175)
        Me.BtnDelDept.Name = "BtnDelDept"
        Me.BtnDelDept.Size = New System.Drawing.Size(80, 40)
        Me.BtnDelDept.TabIndex = 2
        Me.BtnDelDept.Tag = "view"
        Me.BtnDelDept.Text = "Delete"
        '
        'BtnEditDept
        '
        Me.BtnEditDept.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnEditDept.Appearance.Options.UseFont = True
        Me.BtnEditDept.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.BtnEditDept.Image = CType(resources.GetObject("BtnEditDept.Image"), System.Drawing.Image)
        Me.BtnEditDept.Location = New System.Drawing.Point(106, 175)
        Me.BtnEditDept.Name = "BtnEditDept"
        Me.BtnEditDept.Size = New System.Drawing.Size(80, 40)
        Me.BtnEditDept.TabIndex = 1
        Me.BtnEditDept.Tag = "edit"
        Me.BtnEditDept.Text = "Edit"
        '
        'BtnAddDept
        '
        Me.BtnAddDept.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAddDept.Appearance.Options.UseFont = True
        Me.BtnAddDept.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.BtnAddDept.Image = CType(resources.GetObject("BtnAddDept.Image"), System.Drawing.Image)
        Me.BtnAddDept.Location = New System.Drawing.Point(20, 175)
        Me.BtnAddDept.Name = "BtnAddDept"
        Me.BtnAddDept.Size = New System.Drawing.Size(80, 40)
        Me.BtnAddDept.TabIndex = 0
        Me.BtnAddDept.Tag = "add"
        Me.BtnAddDept.Text = "Add"
        '
        'DateTglBergabung
        '
        Me.DateTglBergabung.EditValue = Nothing
        Me.DateTglBergabung.Location = New System.Drawing.Point(145, 110)
        Me.DateTglBergabung.Name = "DateTglBergabung"
        Me.DateTglBergabung.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTglBergabung.Properties.Appearance.Options.UseFont = True
        Me.DateTglBergabung.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateTglBergabung.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.DateTglBergabung.Size = New System.Drawing.Size(220, 20)
        Me.DateTglBergabung.TabIndex = 7
        Me.DateTglBergabung.Tag = "input"
        '
        'LookUpDept
        '
        Me.LookUpDept.Location = New System.Drawing.Point(145, 51)
        Me.LookUpDept.Name = "LookUpDept"
        Me.LookUpDept.Properties.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LookUpDept.Properties.Appearance.Options.UseFont = True
        Me.LookUpDept.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.LookUpDept.Properties.NullText = "Choose the position"
        Me.LookUpDept.Size = New System.Drawing.Size(220, 20)
        Me.LookUpDept.TabIndex = 5
        Me.LookUpDept.Tag = "input"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"), System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(19, 248)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(339, 21)
        Me.SimpleButton1.TabIndex = 80
        Me.SimpleButton1.Tag = "cancel"
        Me.SimpleButton1.Text = "Print"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(145, 54)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(0, 13)
        Me.LabelControl2.TabIndex = 81
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.UpdateOrder = MyTemplate.DataSetReportTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DataSetReport
        '
        Me.DataSetReport.DataSetName = "DataSetReport"
        Me.DataSetReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportEmployeeBindingSource
        '
        Me.ReportEmployeeBindingSource.DataMember = "ReportEmployee"
        Me.ReportEmployeeBindingSource.DataSource = Me.DataSetReport
        '
        'ReportEmployeeTableAdapter
        '
        Me.ReportEmployeeTableAdapter.ClearBeforeFill = True
        '
        'FormEmployee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1184, 661)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.LookUpDept)
        Me.Controls.Add(Me.DateTglBergabung)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.txtGapok)
        Me.Controls.Add(Me.txtNamaKaryawan)
        Me.Controls.Add(Me.LabelControl11)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.LabelControl5)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.BtnCancelDept)
        Me.Controls.Add(Me.BtnSaveDept)
        Me.Controls.Add(Me.BtnDelDept)
        Me.Controls.Add(Me.BtnEditDept)
        Me.Controls.Add(Me.BtnAddDept)
        Me.Name = "FormEmployee"
        Me.Tag = "1100"
        Me.Text = "Employee"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGapok.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNamaKaryawan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateTglBergabung.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DateTglBergabung.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LookUpDept.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetReport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReportEmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents txtGapok As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtNamaKaryawan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LabelControl11 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents BtnCancelDept As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnSaveDept As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnDelDept As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnEditDept As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents BtnAddDept As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents DateTglBergabung As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LookUpDept As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents TableAdapterManager As MyTemplate.DataSetReportTableAdapters.TableAdapterManager
    Friend WithEvents DataSetReport As MyTemplate.DataSetReport
    Friend WithEvents ReportEmployeeBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ReportEmployeeTableAdapter As MyTemplate.DataSetReportTableAdapters.ReportEmployeeTableAdapter
End Class

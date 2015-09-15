<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DetailRI
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DetailRI))
        Me.DataSetRI = New MyTemplate.DataSetRI()
        Me.RIDetailDataTableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RIDetailTableAdapter = New MyTemplate.DataSetRITableAdapters.RIDetailTableAdapter()
        Me.TableAdapterRIDetail = New MyTemplate.DataSetRITableAdapters.TableAdapterManager()
        Me.RIDetailDataTableBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.RIDetailDataTableBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.RIDetailDataTableGridControl = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.DataSetRI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RIDetailDataTableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RIDetailDataTableBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RIDetailDataTableBindingNavigator.SuspendLayout()
        CType(Me.RIDetailDataTableGridControl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataSetRI
        '
        Me.DataSetRI.DataSetName = "DataSetRI"
        Me.DataSetRI.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RIDetailDataTableBindingSource
        '
        Me.RIDetailDataTableBindingSource.DataMember = "RIDetailDataTable"
        Me.RIDetailDataTableBindingSource.DataSource = Me.DataSetRI
        '
        'RIDetailTableAdapter
        '
        Me.RIDetailTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterRIDetail
        '
        Me.TableAdapterRIDetail.BackupDataSetBeforeUpdate = False
        Me.TableAdapterRIDetail.RIDetailTableAdapter = Me.RIDetailTableAdapter
        Me.TableAdapterRIDetail.UpdateOrder = MyTemplate.DataSetRITableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'RIDetailDataTableBindingNavigator
        '
        Me.RIDetailDataTableBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.RIDetailDataTableBindingNavigator.BindingSource = Me.RIDetailDataTableBindingSource
        Me.RIDetailDataTableBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.RIDetailDataTableBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.RIDetailDataTableBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.RIDetailDataTableBindingNavigatorSaveItem})
        Me.RIDetailDataTableBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.RIDetailDataTableBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.RIDetailDataTableBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.RIDetailDataTableBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.RIDetailDataTableBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.RIDetailDataTableBindingNavigator.Name = "RIDetailDataTableBindingNavigator"
        Me.RIDetailDataTableBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.RIDetailDataTableBindingNavigator.Size = New System.Drawing.Size(700, 25)
        Me.RIDetailDataTableBindingNavigator.TabIndex = 0
        Me.RIDetailDataTableBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'RIDetailDataTableBindingNavigatorSaveItem
        '
        Me.RIDetailDataTableBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.RIDetailDataTableBindingNavigatorSaveItem.Image = CType(resources.GetObject("RIDetailDataTableBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.RIDetailDataTableBindingNavigatorSaveItem.Name = "RIDetailDataTableBindingNavigatorSaveItem"
        Me.RIDetailDataTableBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.RIDetailDataTableBindingNavigatorSaveItem.Text = "Save Data"
        '
        'RIDetailDataTableGridControl
        '
        Me.RIDetailDataTableGridControl.Cursor = System.Windows.Forms.Cursors.Default
        Me.RIDetailDataTableGridControl.DataSource = Me.RIDetailDataTableBindingSource
        Me.RIDetailDataTableGridControl.Location = New System.Drawing.Point(0, 28)
        Me.RIDetailDataTableGridControl.MainView = Me.GridView1
        Me.RIDetailDataTableGridControl.Name = "RIDetailDataTableGridControl"
        Me.RIDetailDataTableGridControl.Size = New System.Drawing.Size(300, 220)
        Me.RIDetailDataTableGridControl.TabIndex = 1
        Me.RIDetailDataTableGridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.RIDetailDataTableGridControl
        Me.GridView1.Name = "GridView1"
        '
        'DetailRI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 393)
        Me.Controls.Add(Me.RIDetailDataTableGridControl)
        Me.Controls.Add(Me.RIDetailDataTableBindingNavigator)
        Me.Name = "DetailRI"
        Me.Text = "DetailRI"
        CType(Me.DataSetRI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RIDetailDataTableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RIDetailDataTableBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RIDetailDataTableBindingNavigator.ResumeLayout(False)
        Me.RIDetailDataTableBindingNavigator.PerformLayout()
        CType(Me.RIDetailDataTableGridControl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataSetRI As MyTemplate.DataSetRI
    Friend WithEvents RIDetailDataTableBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RIDetailTableAdapter As MyTemplate.DataSetRITableAdapters.RIDetailTableAdapter
    Friend WithEvents TableAdapterRIDetail As MyTemplate.DataSetRITableAdapters.TableAdapterManager
    Friend WithEvents RIDetailDataTableBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents RIDetailDataTableBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents RIDetailDataTableGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
End Class

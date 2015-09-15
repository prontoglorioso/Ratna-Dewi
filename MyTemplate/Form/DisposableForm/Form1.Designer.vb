<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SuspendLayout()
        '
        'Form1
        '
        Me.ClientSize = New System.Drawing.Size(810, 507)
        Me.Name = "Form1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DataSetRISelectItem As MyTemplate.DataSetRI
    Friend WithEvents SP_Select_Item_DetalRIBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents SP_Select_Item_DetalRITableAdapter As MyTemplate.DataSetRITableAdapters.SP_Select_Item_DetalRITableAdapter
    Friend WithEvents TableAdapterManagerSelectItem As MyTemplate.DataSetRITableAdapters.TableAdapterManager
    Friend WithEvents SP_Select_Item_DetalRIGridControl As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
End Class

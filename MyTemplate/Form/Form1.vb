Public Class Form1

    Private Sub HeaderRI_DataTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles HeaderRI_DataTableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.HeaderRI_DataTableBindingSource.EndEdit()
        Me.TableAdapterManagerHeaderRI.UpdateAll(Me.DataSetRI)

    End Sub

    Private Sub FillToolStripButton_Click(sender As Object, e As EventArgs) Handles FillToolStripButton.Click
        Try
            Me.HeaderRI_DataTableTableAdapter.Fill(Me.DataSetRI.HeaderRI_DataTable, New System.Nullable(Of Integer)(CType(IdHeaderPoToolStripTextBox.Text, Integer)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
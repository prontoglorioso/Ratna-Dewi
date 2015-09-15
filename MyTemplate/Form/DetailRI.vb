Public Class DetailRI 

    
    Private Sub RIDetailDataTableBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles RIDetailDataTableBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.RIDetailDataTableBindingSource.EndEdit()
        Me.TableAdapterRIDetail.UpdateAll(Me.DataSetRI)

    End Sub

    Private Sub DetailRI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetRI.RIDetailDataTable' table. You can move, or remove it, as needed.
        Me.RIDetailTableAdapter.Fill(Me.DataSetRI.RIDetailDataTable)

    End Sub
End Class
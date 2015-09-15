Public Class DetailPI 

    Private Sub PIDetail_SelectBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PIDetail_SelectBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PIDetail_SelectBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetSPPK)

    End Sub

    Private Sub DetailPI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetSPPK.SelectHeader_PO' table. You can move, or remove it, as needed.
        Me.SelectHeader_POTableAdapter.Fill(Me.DataSetSPPK.SelectHeader_PO)
        'TODO: This line of code loads data into the 'DataSetSPPK.PIDetail_Select' table. You can move, or remove it, as needed.
        Me.PIDetail_SelectTableAdapter.Fill(Me.DataSetSPPK.PIDetail_Select)

    End Sub
End Class
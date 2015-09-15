Public Class DetailPP 

    Private Sub PPDetail_SelectBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PPDetail_SelectBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PPDetail_SelectBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetSPPK)

    End Sub

    Private Sub DetailPP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetSPPK.SelectHeader_PO' table. You can move, or remove it, as needed.
        Me.SelectHeader_POTableAdapter.Fill(Me.DataSetSPPK.SelectHeader_PO)
        'TODO: This line of code loads data into the 'DataSetSPPK.PPDetail_Select' table. You can move, or remove it, as needed.
        Me.PPDetail_SelectTableAdapter.Fill(Me.DataSetSPPK.PPDetail_Select)

    End Sub
End Class
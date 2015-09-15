Public Class DetailDO 

    Private Sub DODetail_SelectBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles DODetail_SelectBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DODetail_SelectBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetSPPK)

    End Sub

    Private Sub DetailDO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetSPPK.SelectHeader_SO' table. You can move, or remove it, as needed.
        Me.SelectHeader_SOTableAdapter.Fill(Me.DataSetSPPK.SelectHeader_SO)
        'TODO: This line of code loads data into the 'DataSetSPPK.DODetail_Select' table. You can move, or remove it, as needed.
        Me.DODetail_SelectTableAdapter.Fill(Me.DataSetSPPK.DODetail_Select)

    End Sub
End Class
Public Class DetailSR 

    Private Sub SRDetail_SelectBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SRDetail_SelectBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SRDetail_SelectBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetSPPK)

    End Sub

    Private Sub DetailSR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetSPPK.SelectHeader_SO' table. You can move, or remove it, as needed.
        Me.SelectHeader_SOTableAdapter.Fill(Me.DataSetSPPK.SelectHeader_SO)
        'TODO: This line of code loads data into the 'DataSetSPPK.SRDetail_Select' table. You can move, or remove it, as needed.
        Me.SRDetail_SelectTableAdapter.Fill(Me.DataSetSPPK.SRDetail_Select)

    End Sub
End Class
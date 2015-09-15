Public Class DetailSI 

    Private Sub SIDetail_SelectBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SIDetail_SelectBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SIDetail_SelectBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetSPPK)

    End Sub

    Private Sub DetailSI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetSPPK.SelectHeader_SO' table. You can move, or remove it, as needed.
        Me.SelectHeader_SOTableAdapter.Fill(Me.DataSetSPPK.SelectHeader_SO)
        'TODO: This line of code loads data into the 'DataSetSPPK.SIDetail_Select' table. You can move, or remove it, as needed.
        Me.SIDetail_SelectTableAdapter.Fill(Me.DataSetSPPK.SIDetail_Select)

    End Sub
End Class
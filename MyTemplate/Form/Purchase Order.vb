Public Class Purchase_Order 

    Private Sub POHeader_SelectBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles POHeader_SelectBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.POHeader_SelectBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetSPPK)

    End Sub

    Private Sub Purchase_Order_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetSPPK.POHeader_Select' table. You can move, or remove it, as needed.
        Me.POHeader_SelectTableAdapter.Fill(Me.DataSetSPPK.POHeader_Select)

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorAddNewItem.Click

    End Sub

    Private Sub POHeader_SelectBindingNavigator_RefreshItems(sender As Object, e As EventArgs) Handles POHeader_SelectBindingNavigator.RefreshItems

    End Sub

    Private Sub POHeader_SelectGridControl_Click(sender As Object, e As EventArgs) Handles POHeader_SelectGridControl.Click

    End Sub
End Class
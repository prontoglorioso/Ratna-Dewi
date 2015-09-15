Public Class DetailSO 

    Private Sub SODetail_SelectBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles SODetail_SelectBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.SODetail_SelectBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DataSetSPPK)

    End Sub

    Private Sub DetailSO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DataSetSPPK.SelectProject' table. You can move, or remove it, as needed.
        Me.SelectProjectTableAdapter.Fill(Me.DataSetSPPK.SelectProject)
        'TODO: This line of code loads data into the 'DataSetSPPK.SelectTax' table. You can move, or remove it, as needed.
        Me.SelectTaxTableAdapter.Fill(Me.DataSetSPPK.SelectTax)
        'TODO: This line of code loads data into the 'DataSetSPPK.SelectItem' table. You can move, or remove it, as needed.
        Me.SelectItemTableAdapter.Fill(Me.DataSetSPPK.SelectItem)
        'TODO: This line of code loads data into the 'DataSetSPPK.SelectHeader_SO' table. You can move, or remove it, as needed.
        Me.SelectHeader_SOTableAdapter.Fill(Me.DataSetSPPK.SelectHeader_SO)
        'TODO: This line of code loads data into the 'DataSetSPPK.SODetail_Select' table. You can move, or remove it, as needed.
        Me.SODetail_SelectTableAdapter.Fill(Me.DataSetSPPK.SODetail_Select)

    End Sub
End Class
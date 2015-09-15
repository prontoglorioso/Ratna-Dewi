Public Class ClassHelper
    Public Property DataPosition As New DataSet
    Public Property DataMarketing As New DataSet
    Public Property DataCustomer As New DataSet
    Public Property DataMaster As New DataSet
    Public Property DataTypeAcc As New DataSet
    Public Property DataHeaderItem As New DataSet
    Public Property DataParentAccount As New DataSet
    Public Property TypeItem As Boolean
    Public Property idTypeAccount As Integer
    Public Property DataSalesTax As New DataSet
    Public Property DataPurchaseTax As New DataSet
#Region "IdHelper"
    Public Property idMaster As Integer
    Public Property idSubCOA As Integer

#End Region
    Sub [getPosition]()
         If Not dbOpen() Then
            Throw New Exception("Database Can't Open")
        End If
        DataPosition.Dispose()
        DataPosition = New DataSet
        sqlCMD = New SqlClient.SqlCommand With {.CommandType = CommandType.StoredProcedure, .Connection = sqlConn, .CommandText = "LoadComboPosition"}
        With sqlCMD.Parameters
            .Clear()
        End With
        Try
            sqlDA = New SqlClient.SqlDataAdapter With {.SelectCommand = sqlCMD}
            sqlDA.Fill(DataPosition, "TabelPosition")
            sqlDA.Dispose()
            sqlCMD.Dispose()
        Catch ex As SqlClient.SqlException
            Throw New Exception(ex.Message)
        Finally
            sqlConn.Close()
        End Try
    End Sub
    Sub [getCustomer]()
        If Not dbOpen() Then
            Throw New Exception("Database Can't Open")
        End If
        DataCustomer.Dispose()
        DataCustomer = New DataSet
        sqlCMD = New SqlClient.SqlCommand With {.CommandType = CommandType.StoredProcedure, .Connection = sqlConn, .CommandText = "LoadComboCustomer"}
        With sqlCMD.Parameters
            .Clear()
        End With
        Try
            sqlDA = New SqlClient.SqlDataAdapter With {.SelectCommand = sqlCMD}
            sqlDA.Fill(DataCustomer, "TabelCustomer")
            sqlDA.Dispose()
            sqlCMD.Dispose()
        Catch ex As SqlClient.SqlException
            Throw New Exception(ex.Message)
        Finally
            sqlConn.Close()
        End Try
    End Sub
    Sub [getMarketing]()
        If Not dbOpen() Then
            Throw New Exception("Database Can't Open")
        End If
        DataMarketing.Dispose()
        DataMarketing = New DataSet
        sqlCMD = New SqlClient.SqlCommand With {.CommandType = CommandType.StoredProcedure, .Connection = sqlConn, .CommandText = "LoadComboMarketing"}
        With sqlCMD.Parameters
            .Clear()
        End With
        Try
            sqlDA = New SqlClient.SqlDataAdapter With {.SelectCommand = sqlCMD}
            sqlDA.Fill(DataMarketing, "TabelMarketing")
            sqlDA.Dispose()
            sqlCMD.Dispose()
        Catch ex As SqlClient.SqlException
            Throw New Exception(ex.Message)
        Finally
            sqlConn.Close()
        End Try
    End Sub
    Sub getMasterCOA()
        If Not dbOpen() Then
            Throw New Exception("Database Can't Open")
        End If
        DataMaster.Dispose()
        DataMaster = New DataSet
        sqlCMD = New SqlClient.SqlCommand With {.CommandType = CommandType.StoredProcedure, .Connection = sqlConn, .CommandText = "LoadComboMaster"}
        With sqlCMD.Parameters
            .Clear()
        End With
        Try
            sqlDA = New SqlClient.SqlDataAdapter With {.SelectCommand = sqlCMD}
            sqlDA.Fill(DataMaster, "TabelMaster")
            sqlDA.Dispose()
            sqlCMD.Dispose()
        Catch ex As SqlClient.SqlException
            Throw New Exception(ex.Message)
        Finally
            sqlConn.Close()
        End Try
    End Sub
    Sub getTypeAccCOA()
        If Not dbOpen() Then
            Throw New Exception("Database Can't Open")
        End If
        DataTypeAcc.Dispose()
        DataTypeAcc = New DataSet
        sqlCMD = New SqlClient.SqlCommand With {.CommandType = CommandType.StoredProcedure, .Connection = sqlConn, .CommandText = "LoadComboTypeAccount"}
        With sqlCMD.Parameters
            .Clear()
        End With
        Try
            sqlDA = New SqlClient.SqlDataAdapter With {.SelectCommand = sqlCMD}
            sqlDA.Fill(DataTypeAcc, "TabelTypeAccount")
            sqlDA.Dispose()
            sqlCMD.Dispose()
        Catch ex As SqlClient.SqlException
            Throw New Exception(ex.Message)
        Finally
            sqlConn.Close()
        End Try
    End Sub
    Sub getHeaderItem()
        If Not dbOpen() Then
            Throw New Exception("Database Can't Open")
        End If
        DataHeaderItem.Dispose()
        DataHeaderItem = New DataSet

        sqlCMD = New SqlClient.SqlCommand With {.CommandType = CommandType.StoredProcedure, .Connection = sqlConn, .CommandText = "LoadComboHeaderItem"}
        With sqlCMD.Parameters
            .Clear()
            .AddWithValue("typeItem", typeItem)
        End With
        Try
            sqlDA = New SqlClient.SqlDataAdapter With {.SelectCommand = sqlCMD}
            sqlDA.Fill(DataHeaderItem, "TabelHeaderItem")
            sqlDA.Dispose()
            sqlCMD.Dispose()
        Catch ex As SqlClient.SqlException
            Throw New Exception(ex.Message)
        Finally
            sqlConn.Close()
        End Try
    End Sub
    Sub getParentAccount()
        If Not dbOpen() Then
            Throw New Exception("Database Can't Open")
        End If
        DataParentAccount.Dispose()
        DataParentAccount = New DataSet
        sqlCMD = New SqlClient.SqlCommand With {.CommandType = CommandType.StoredProcedure, .Connection = sqlConn, .CommandText = "LoadComboParentAccount"}
        With sqlCMD.Parameters
            .Clear()
            .AddWithValue("@idTypeAccount", idTypeAccount)
        End With
        Try
            sqlDA = New SqlClient.SqlDataAdapter With {.SelectCommand = sqlCMD}
            sqlDA.Fill(DataParentAccount, "TableParentAccount")
            sqlDA.Dispose()
            sqlCMD.Dispose()
        Catch ex As SqlClient.SqlException
            Throw New Exception(ex.Message)
        Finally
            sqlConn.Close()
        End Try
    End Sub
    Sub getSalesTax()
        If Not dbOpen() Then
            Throw New Exception("Database Can't Open")
        End If
        DataSalesTax.Dispose()
        DataSalesTax = New DataSet
        sqlCMD = New SqlClient.SqlCommand With {.CommandType = CommandType.StoredProcedure, .Connection = sqlConn, .CommandText = "LoadComboSalesTax"}
        With sqlCMD.Parameters
            .Clear()
        End With
        Try
            sqlDA = New SqlClient.SqlDataAdapter With {.SelectCommand = sqlCMD}
            sqlDA.Fill(DataSalesTax, "TableSalesTax")
            sqlDA.Dispose()
            sqlCMD.Dispose()
        Catch ex As SqlClient.SqlException
            Throw New Exception(ex.Message)
        Finally
            sqlConn.Close()
        End Try
    End Sub
    Sub getPurchaseTax()
        If Not dbOpen() Then
            Throw New Exception("Database Can't Open")
        End If
        DataPurchaseTax.Dispose()
        DataPurchaseTax = New DataSet
        sqlCMD = New SqlClient.SqlCommand With {.CommandType = CommandType.StoredProcedure, .Connection = sqlConn, .CommandText = "LoadComboPurchaseTax"}
        With sqlCMD.Parameters
            .Clear()
        End With
        Try
            sqlDA = New SqlClient.SqlDataAdapter With {.SelectCommand = sqlCMD}
            sqlDA.Fill(DataPurchaseTax, "TabelPurchaseTax")
            sqlDA.Dispose()
            sqlCMD.Dispose()
        Catch ex As SqlClient.SqlException
            Throw New Exception(ex.Message)
        Finally
            sqlConn.Close()
        End Try
    End Sub
End Class

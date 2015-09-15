Public Class ClassCOA
    Public Property id As Integer
    Public Property isNew As Boolean
    Public Property isAll As Boolean
    Public Property idTypeAcc As Integer
    Public Property kodeSubAccountCOA As String
    Public Property namaSubAccountCOA As String
    Public Property Status As Boolean
    Public Property idParentAccount As Integer
    Public Property balance As Decimal
    Public Property openingBalanceDate As Date
    Public Property isDeleted As Boolean
    Public Property DataCOA As New DataSet
    Sub Save(isNew As Boolean)
        If Not dbOpen() Then
            Throw New Exception("Database Can't Open")
        End If
        sqlCMD = New SqlClient.SqlCommand With {.CommandType = CommandType.StoredProcedure, .Connection = sqlConn, .CommandText = "SubAccountCOA_Set"}
        With sqlCMD.Parameters
            .Clear()
            .AddWithValue("id", id)
            .AddWithValue("idTypeAcc", idTypeAcc)
            .AddWithValue("kodeSubAccount", kodeSubAccountCOA)
            .AddWithValue("namaSubAccount", namaSubAccountCOA)
            .AddWithValue("status", Status)
            .AddWithValue("idParentAccount", idParentAccount)
            .AddWithValue("balance", balance)
            .AddWithValue("openingBalanceDate", openingBalanceDate)
            .AddWithValue("isDeleted", isDeleted)
            .AddWithValue("isNew", isNew)
        End With
        Try
            sqlCMD.ExecuteNonQuery()
        Catch ex As SqlClient.SqlException
            Throw New Exception(ex.Message)
        Finally
            sqlConn.Close()
        End Try
    End Sub
    Sub Load(ByVal isAll As Boolean)
        If Not dbOpen() Then
            Throw New Exception("Database Can't Open")
        End If
        DataCOA.Dispose()
        DataCOA = New DataSet
        SqlCMD = New SqlClient.SqlCommand With {.CommandType = CommandType.StoredProcedure, .Connection = sqlConn, .CommandText = "SubAccountCOA_Get"}
        With SqlCMD.Parameters
            .Clear()
            .AddWithValue("isAll", isAll)
            .AddWithValue("isDeleted", isDeleted)
            .AddWithValue("id", id)
        End With
        Try
            sqlDA = New SqlClient.SqlDataAdapter With {.SelectCommand = SqlCMD}
            sqlDA.Fill(DataCOA, "TabelCOA")
            sqlDA.Dispose()
            SqlCMD.Dispose()
            If isAll = False Then
                With DataCOA.Tables("TabelCOA")
                    idTypeAcc = .Rows(0).Item(1)
                    kodeSubAccountCOA = .Rows(0).Item(2)
                    namaSubAccountCOA = .Rows(0).Item(3)
                    Status = .Rows(0).Item(4)
                    idParentAccount = .Rows(0).Item(5)
                    balance = .Rows(0).Item(6)
                    openingBalanceDate = .Rows(0).Item(7)
                    isDeleted = .Rows(0).Item(8)
                End With
            End If
        Catch ex As SqlClient.SqlException
            Throw New Exception(ex.Message)
        Finally
            dbClose()
        End Try
    End Sub
    Sub del()
        If Not dbOpen() Then
            Throw New Exception("Database Can't Open")
        End If
        sqlCMD = New SqlClient.SqlCommand With {.CommandType = CommandType.StoredProcedure, .Connection = sqlConn, .CommandText = "SubAccountCOA_Del"}
        With sqlCMD.Parameters
            .Clear()
            .AddWithValue("id", id)
        End With
        Try
            sqlCMD.ExecuteNonQuery()
        Catch ex As SqlClient.SqlException
            Throw New Exception(ex.Message)
        Finally
            sqlConn.Close()
        End Try
    End Sub
End Class

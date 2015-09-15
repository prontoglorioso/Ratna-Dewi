Public Class ClassTax
    Public Property id As Integer
    Public Property isNew As Boolean
    Public Property isAll As Boolean
    Public Property kodePajak As String
    Public Property namaPajak As String
    Public Property description As String
    Public Property tarifPajak As Decimal
    Public Property penjId As Integer
    Public Property pemId As Integer
    Public Property isDeleted As Boolean
    Public Property DataTax As New DataSet
    Sub Save(isNew As Boolean)
        If Not dbOpen() Then
            Throw New Exception("Database Can't Open")
        End If
        SqlCMD = New SqlClient.SqlCommand With {.CommandType = CommandType.StoredProcedure, .Connection = sqlConn, .CommandText = "Tax_Set"}
        With SqlCMD.Parameters
            .Clear()
            .AddWithValue("id", id)
            .AddWithValue("kodePajak", kodePajak)
            .AddWithValue("namaPajak", namaPajak)
            .AddWithValue("description", description)
            .AddWithValue("tarifPajak", tarifPajak)
            .AddWithValue("penjId", penjId)
            .AddWithValue("pemId", pemId)
            .AddWithValue("isDeleted", isDeleted)
            .AddWithValue("isNew", isNew)
        End With
        Try
            SqlCMD.ExecuteNonQuery()
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
        DataTax.Dispose()
        DataTax = New DataSet

        SqlCMD = New SqlClient.SqlCommand With {.CommandType = CommandType.StoredProcedure, .Connection = sqlConn, .CommandText = "Tax_Get"}
        With SqlCMD.Parameters
            .Clear()
            .AddWithValue("isAll", isAll)
            .AddWithValue("isDeleted", isDeleted)
            .AddWithValue("id", id)
        End With
        Try
            sqlDA = New SqlClient.SqlDataAdapter With {.SelectCommand = SqlCMD}
            sqlDA.Fill(DataTax, "TabelTax")
            sqlDA.Dispose()
            SqlCMD.Dispose()
            If isAll = False Then
                With DataTax.Tables("TabelTax")
                    kodePajak = .Rows(0).Item(1)
                    namaPajak = .Rows(0).Item(2)
                    description = .Rows(0).Item(3)
                    tarifPajak = .Rows(0).Item(4)
                    penjId = .Rows(0).Item(5)
                    pemId = .Rows(0).Item(6)
                    isDeleted = .Rows(0).Item(7)
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
        SqlCMD = New SqlClient.SqlCommand With {.CommandType = CommandType.StoredProcedure, .Connection = sqlConn, .CommandText = "Tax_Del"}
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

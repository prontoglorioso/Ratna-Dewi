Public Class ClassVendor
    Public Property id As Integer
    Public Property isAll As Boolean
    Public Property isNew As Boolean
    Public Property kodevendor As String
    Public Property nama As String
    Public Property alamat As String
    Public Property telp As String
    Public Property fax As String
    Public Property contactPerson As String
    Public Property handphone As String
    Public Property email As String
    Public Property NPWP As String
    Public Property statusPajak As Boolean
    Public Property isDeleted As Boolean
    Public Property DataVendor As New DataSet
    Sub Save(isNew As Boolean)
        If Not dbOpen() Then
            Throw New Exception("Database Can't Open")
        End If
        sqlCMD = New SqlClient.SqlCommand With {.CommandType = CommandType.StoredProcedure, .Connection = sqlConn, .CommandText = "vendor_Set"}
        With sqlCMD.Parameters
            .Clear()
            .AddWithValue("id", id)
            .AddWithValue("kodevendor", kodevendor)
            .AddWithValue("nama", nama)
            .AddWithValue("alamat", alamat)
            .AddWithValue("telp", telp)
            .AddWithValue("fax", fax)
            .AddWithValue("contactPerson", contactPerson)
            .AddWithValue("handphone", handphone)
            .AddWithValue("email", email)
            .AddWithValue("NPWP", NPWP)
            .AddWithValue("statusPajak", statusPajak)
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
        DataVendor.Dispose()
        DataVendor = New DataSet
        SqlCMD = New SqlClient.SqlCommand With {.CommandType = CommandType.StoredProcedure, .Connection = sqlConn, .CommandText = "Vendor_Get"}
        With SqlCMD.Parameters
            .Clear()
            .AddWithValue("isAll", isAll)
            .AddWithValue("isDeleted", isDeleted)
            .AddWithValue("id", id)
        End With
        Try
            sqlDA = New SqlClient.SqlDataAdapter With {.SelectCommand = SqlCMD}
            sqlDA.Fill(DataVendor, "TabelVendor")
            sqlDA.Dispose()
            SqlCMD.Dispose()
            If isAll = False Then
                With DataVendor.Tables("TabelVendor")
                    kodevendor = .Rows(0).Item(1)
                    nama = .Rows(0).Item(2)
                    alamat = .Rows(0).Item(3)
                    telp = .Rows(0).Item(4)
                    fax = .Rows(0).Item(5)
                    contactPerson = .Rows(0).Item(6)
                    handphone = .Rows(0).Item(7)
                    email = .Rows(0).Item(8)
                    NPWP = .Rows(0).Item(9)
                    statusPajak = .Rows(0).Item(10)
                    isDeleted = .Rows(0).Item(11)
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
        sqlCMD = New SqlClient.SqlCommand With {.CommandType = CommandType.StoredProcedure, .Connection = sqlConn, .CommandText = "Vendor_Del"}
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

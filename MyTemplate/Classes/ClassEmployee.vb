Public Class ClassEmployee
    Public Property id As Integer
    Public Property isAll As Boolean
    Public Property isNew As Boolean
    Public Property idJabatan As Integer
    Public Property namaKaryawan As String
    Public Property tglBergabung As Date
    Public Property gajiPokok As Decimal
    Public Property isDeleted As Boolean
    Public Property DataEmployee As New DataSet
    Sub Save(isNew As Boolean)
        If Not dbOpen() Then
            Throw New Exception("Database Can't Open")
        End If
        SqlCMD = New SqlClient.SqlCommand With {.CommandType = CommandType.StoredProcedure, .Connection = sqlConn, .CommandText = "employee_Set"}
        With SqlCMD.Parameters
            .Clear()
            .AddWithValue("id", id)
            .AddWithValue("idJabatan", idJabatan)
            .AddWithValue("namaKaryawan", namaKaryawan)
            .AddWithValue("tglBergabung", tglBergabung)
            .AddWithValue("gajiPokok", gajiPokok)
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
        DataEmployee.Dispose()
        DataEmployee = New DataSet
        SqlCMD = New SqlClient.SqlCommand With {.CommandType = CommandType.StoredProcedure, .Connection = sqlConn, .CommandText = "Employee_Get"}
        With SqlCMD.Parameters
            .Clear()
            .AddWithValue("isAll", isAll)
            .AddWithValue("isDeleted", isDeleted)
            .AddWithValue("id", id)
        End With
        Try
            sqlDA = New SqlClient.SqlDataAdapter With {.SelectCommand = SqlCMD}
            sqlDA.Fill(DataEmployee, "TabelEmployee")
            sqlDA.Dispose()
            SqlCMD.Dispose()
            If isAll = False Then
                With DataEmployee.Tables("TabelEmployee")
                    idJabatan = .Rows(0).Item(1)
                    namaKaryawan = .Rows(0).Item(2)
                    tglBergabung = .Rows(0).Item(3)
                    gajiPokok = .Rows(0).Item(4)
                    isDeleted = .Rows(0).Item(5)
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
        SqlCMD = New SqlClient.SqlCommand With {.CommandType = CommandType.StoredProcedure, .Connection = sqlConn, .CommandText = "Employee_Del"}
        With SqlCMD.Parameters
            .Clear()
            .AddWithValue("id", id)
        End With
        Try
            SqlCMD.ExecuteNonQuery()
        Catch ex As SqlClient.SqlException
            Throw New Exception(ex.Message)
        Finally
            sqlConn.Close()
        End Try
    End Sub
End Class

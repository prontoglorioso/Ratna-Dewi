Imports System.Data.SqlClient

Public Class ClassUser
    Public Property id As Integer
    Public Property IsAll As Boolean
    Public Property username As String
    Public Property userpassword As String
    Public Property userpassword2 As String
    Public Property RoleId As Integer
    Public Property IsDeleted As Boolean
    Public Property EncryptedPassword As String
    Public Property DataUser As New DataSet


    Sub New()
        IsAll = True

    End Sub

    Public Sub EncryptPassword()
        Dim wrapper As New ClassEncrypt("ASIA1-AFRICA2-AUSTRALIA3-EUROPE4-AMERICA5")
        EncryptedPassword = wrapper.EncryptData(userpassword)
    End Sub

    Sub [set]()

        If Not dbOpen() Then
            Throw New Exception("Cannot Connect to Database")
        End If

        sqlCmd = New SqlCommand With {.Connection = sqlConn, .CommandType = CommandType.StoredProcedure, .CommandText = "sysUser_Set"}

        With sqlCmd.Parameters
            .AddWithValue("id", id)
            .AddWithValue("username", username)
            .AddWithValue("userpassword", EncryptedPassword)
            .AddWithValue("RoleId", RoleId)
            .AddWithValue("IsDeleted", IsDeleted)

        End With

        Try
            sqlCmd.ExecuteNonQuery()

        Catch ex As Exception

            If ex.Message.ToString.ToLower.Contains("unique") Then
                XtraMessageBox.Show("There is already object with same value in database")
            Else
                Throw New Exception("System Error with this MessageL " & ex.Message)
            End If
        End Try
    End Sub
    Sub [Get](ByVal isAll As Boolean)

        If Not dbOpen() Then
            Throw New Exception("Gagal menyambung ke Database")
        End If

        sqlCmd = New SqlCommand With {.CommandType = CommandType.StoredProcedure, .Connection = sqlConn, .CommandText = "sysUser_get"}

        With sqlCmd.Parameters

            .Clear()
            .AddWithValue("IsAll", isAll)
            .AddWithValue("id", id)
            .AddWithValue("IsDeleted", IsDeleted)

        End With

        DataUser.Dispose()
        DataUser = New DataSet

        sqlDa = New SqlDataAdapter With {.SelectCommand = sqlCmd}
        sqlDa.Fill(DataUser, "DataUser")

        sqlDa.Dispose()
        sqlCmd.Dispose()

        If isAll = True Then
            With DataUser.Tables("DataUser")
                username = .Rows(0).Item("username")
                userpassword = .Rows(0).Item("userpassword")
                RoleId = .Rows(0).Item("RoleId")
                IsDeleted = .Rows(0).Item("IsDeleted")

            End With
        End If
    End Sub


    Sub Del()
        If Not dbOpen() Then
            Throw New Exception("Tidak bisa terhubung ke database")
        End If

        sqlCmd = New SqlCommand With {.Connection = sqlConn, .CommandType = CommandType.StoredProcedure, .CommandText = "sysUser_Del"}

        With sqlCmd.Parameters
            .Clear()
            .AddWithValue("@ID", id)
            .AddWithValue("IsDeleted", IsDeleted)
        End With

        Try
            sqlCmd.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            dbClose()
            sqlCmd.Parameters.Clear()

        End Try



    End Sub

    Public Sub LockUser()
        If Not dbOpen() Then
            Throw New Exception("Tidak bisa terhubung ke database")
        End If

        SqlCMD = New SqlCommand With {.Connection = sqlConn, .CommandType = CommandType.StoredProcedure, .CommandText = "spLockUser"}

        With SqlCMD.Parameters
            .Clear()
            .AddWithValue("username", username)
        End With

        Try
            SqlCMD.ExecuteNonQuery()
        Catch ex As Exception
        Finally
            dbClose()
            SqlCMD.Parameters.Clear()

        End Try

    End Sub
End Class

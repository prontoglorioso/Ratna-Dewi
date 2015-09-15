Public Class ClassUser
    Public Property id As Integer
    Public Property username As String
    Public Property userpassword As String
    Public Property userpassword2 As String
    Public Property RoleId As Integer
    Public Property IsDeleted As Boolean
    Public Property EncryptedPassword As String
    Public Sub EncryptPassword()
        Dim wrapper As New ClassEncrypt(userpassword)
        EncryptedPassword = wrapper.EncryptData(userpassword2)
    End Sub
    Sub [set]()
        If Not dbOpen() Then
            Throw New Exception("Can't Connect to Database")
        End If
        sqlCmd = New SqlClient.SqlCommand With {.Connection = sqlConn, .CommandType = CommandType.StoredProcedure, .CommandText = "sysUser_Set"}
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
            Throw New Exception("System Error with this MessageL " & ex.Message)
        End Try
    End Sub

End Class

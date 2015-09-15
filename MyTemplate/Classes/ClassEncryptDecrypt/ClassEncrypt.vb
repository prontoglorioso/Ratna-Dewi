Imports System.Security.Cryptography
Public NotInheritable Class ClassEncrypt
    ''' <summary>
    ''' private field to store the 3DES cryptographic service provider.
    ''' </summary>
    ''' <remarks></remarks>
    Private TripleDes As New TripleDESCryptoServiceProvider

    ''' <summary>
    ''' creates a byte array of a specified length from the hash of the specified key.
    ''' </summary>
    ''' <param name="key"></param>
    ''' <param name="length"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function TruncateHash(ByVal key As String, ByVal length As Integer) As Byte()
        Dim sha1 As New SHA1CryptoServiceProvider

        'Hash The Key
        Dim keyBites() As Byte =
        System.Text.Encoding.Unicode.GetBytes(key)

        Dim hash() As Byte = sha1.ComputeHash(keyBites)

        'truncate the hash
        ReDim Preserve hash(length - 1)
        Return hash

    End Function
    Sub New(ByVal key As String)
        'initializing the crypto provider
        TripleDes.Key = TruncateHash(key, TripleDes.KeySize \ 8)
        TripleDes.IV = TruncateHash("", TripleDes.BlockSize \ 8)
    End Sub
    ''' <summary>
    ''' Encrypt Strng
    ''' </summary>
    ''' <param name="plaintext"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function EncryptData(ByVal plaintext As String) As String
        'convert the plaintext string to byte array.

        Dim plaintextBytes() As Byte = System.Text.Encoding.Unicode.GetBytes(plaintext)

        'create the stream
        Dim ms As New System.IO.MemoryStream

        'create the encoder to write to the stream
        Dim encStream As New CryptoStream(ms, TripleDes.CreateEncryptor(), System.Security.Cryptography.CryptoStreamMode.Write)

        ' Use the crypto stream to write the byte array to the stream.
        encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
        encStream.FlushFinalBlock()

        ' Convert the encrypted stream to a printable string. 
        Return Convert.ToBase64String(ms.ToArray)
    End Function

    ''' <summary>
    ''' Decrypt data
    ''' </summary>
    ''' <param name="encryptedtext"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function DecryptData(ByVal encryptedtext As String) As String

        ' Convert the encrypted text string to a byte array. 
        Dim encryptedBytes() As Byte = Convert.FromBase64String(encryptedtext)

        ' Create the stream. 
        Dim ms As New System.IO.MemoryStream
        ' Create the decoder to write to the stream. 
        Dim decStream As New CryptoStream(ms,
            TripleDes.CreateDecryptor(),
            System.Security.Cryptography.CryptoStreamMode.Write)

        ' Use the crypto stream to write the byte array to the stream.
        decStream.Write(encryptedBytes, 0, encryptedBytes.Length)
        decStream.FlushFinalBlock()

        ' Convert the plaintext stream to a string. 
        Return System.Text.Encoding.Unicode.GetString(ms.ToArray)
    End Function
End Class

Imports System.Security.Cryptography
Imports System.Text.UTF8Encoding
Imports System.Security.Cryptography.SHA1CryptoServiceProvider
Imports System.Text

Module Criptografia
    Public Function SHA1(ByVal s As String) As String
        Dim sha As New SHA1CryptoServiceProvider ' declare sha as a new SHA1CryptoServiceProvider
        Dim bytesToHash() As Byte ' and here is a byte variable

        bytesToHash = System.Text.Encoding.ASCII.GetBytes(s) ' covert the password into ASCII code

        bytesToHash = sha.ComputeHash(bytesToHash) ' this is where the magic starts and the encryption begins

        Dim encPassword As String = ""

        For Each b As Byte In bytesToHash
            encPassword += b.ToString("x2")
        Next

        Return encPassword
    End Function

End Module

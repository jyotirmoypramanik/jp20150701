Public Class EncDec
    Public Function Encrypt(ByRef pPassPhrase As String, ByVal pTextToEncrypt As String) As String

        If pPassPhrase.Length > 16 Then
            'limitation of the encryption mechanism
            pPassPhrase = pPassPhrase.Substring(0, 16)
        End If

        If pTextToEncrypt.Trim.Length = 0 Then
            'the Text to encrypt not set!!!
            Return String.Empty
        End If

        Dim skey As New JPEncrypt.Data(pPassPhrase)
        Dim sym As New JPEncrypt.Symmetric(JPEncrypt.Symmetric.Provider.Rijndael)
        Dim objEncryptedData As JPEncrypt.Data
        objEncryptedData = sym.Encrypt(New JPEncrypt.Data(pTextToEncrypt), skey)
        Return objEncryptedData.ToHex
    End Function
    Public Function Decrypt(ByRef pPassPhrase As String, ByVal pHexStream As String) As String
        Try
            Dim objSym As New JPEncrypt.Symmetric(JPEncrypt.Symmetric.Provider.Rijndael)
            Dim encryptedData As New JPEncrypt.Data
            encryptedData.Hex = pHexStream
            Dim decryptedData As JPEncrypt.Data
            decryptedData = objSym.Decrypt(encryptedData, New JPEncrypt.Data(pPassPhrase))
            Return decryptedData.Text
        Catch
            Return Nothing
        End Try
    End Function
End Class

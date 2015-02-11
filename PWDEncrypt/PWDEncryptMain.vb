Imports System
Imports System.Threading
Imports System.IO
Imports JPEncrypt

Module PWDEncryptMain
    Dim keycode As Int16 = 0
    Sub printheader()
        Console.WriteLine("---------------------------------------------------------------------------------")
        Console.WriteLine("-----------------------------W-E-L-C-O-M-E---------------------------------------")
        Console.WriteLine("----------------------  Password Encryption Program -----------------------------")
        Console.WriteLine()
        Console.WriteLine()
    End Sub
    Sub Main()
        Dim pwd As String = ""
        printheader()
        pwd = GetPassword()
        If pwd.Length = 0 Then
            If keycode = 1 Then
                pwd = "jpaccount"
                SaveEncryptedPWD(pwd)
            End If
        ElseIf pwd.Length > 0 And pwd = "EXIT" Then
            printfooter(-1)
            System.Environment.Exit(-1)
            Return
        Else
            SaveEncryptedPWD(pwd)
        End If

        printfooter(0)


    End Sub
    Sub SaveEncryptedPWD(ByVal pwd As String)
        'Dim key As String = 
        Dim encryptedpwd As String = ""
        Dim destpath As String
        Dim pwriter As StreamWriter
        'Dim preader As StreamReader
        Dim path As String
        Dim pfile As FileStream

        path = System.IO.Path.GetDirectoryName( _
           System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)
        destpath = Microsoft.VisualBasic.Strings.Right(path, Len(path) - 6)


        'Console.Write("Enter Password for BSDTADLS or BSDTA<PPP> User/default[bsdtadls]:")

#If DEBUG Then
        Console.WriteLine("Running in Debug Mode: Password " + pwd)
#End If

        encryptedpwd = Encrypt("TS-JDADJMDH-7175", pwd)

        Try

            'newEncryptedKey = Encrypt(newPass, txtNewPwd.Text.Trim)
            If keycode = 1 Then
                pfile = New FileStream(destpath + "\" + "dbpwd.dat", FileMode.OpenOrCreate, FileAccess.Write)
                'Else
                '    pfile = New FileStream(destpath + "\" + "lxDB.dat", FileMode.OpenOrCreate, FileAccess.Write)
            End If

            pwriter = New StreamWriter(pfile)
            pwriter.WriteLine(encryptedpwd)
            pwriter.Close()
            pfile.Close()
            Console.WriteLine("Password File dbpwd.dat  Saved Sucessfully for password: " + pwd)
#If DEBUG Then
            Console.WriteLine("Running in Debug Mode: Encrypted Password " + encryptedpwd)
#End If


        Catch ex As Exception
            Console.WriteLine("Error Saving New Password " + ex.Message)

        End Try
    End Sub
    Sub printfooter(ByVal exitcode As Integer)
        Console.WriteLine()
        Console.WriteLine()
        Console.WriteLine("---------------------------------------------------------------------------------")
        Console.WriteLine("-----------------------------G-O-0-D---B-Y-E-------------------------------------")
        Console.WriteLine("------------------------- Password Encryption Completed -------------------------")
        Console.WriteLine()
        Console.WriteLine()
        If exitcode = 0 Then
            Console.Write("Press Any Key to Close  ")
            Console.Read()
        End If



    End Sub
    Private Function GetPassword(Optional ByVal passwordMask As Char = "*"c) As String
        Dim pwd As String = String.Empty
        Dim sb As New System.Text.StringBuilder()
        Dim cki As ConsoleKeyInfo = Nothing
        Dim key
        key = ConsoleKey.D0

        'Get the password7.
        Console.WriteLine("1. Enter Password for JPACCOUNT  User")
        Console.WriteLine("2. Enter 2 to Exit")



        While True
            Console.WriteLine()
            Console.Write("Enter Choice  (1/2) :")
            key = Console.ReadKey()
            If key.Key = ConsoleKey.D1 Or key.Key = ConsoleKey.D2 Then
                Exit While
            End If
        End While
        Console.WriteLine()
        Console.WriteLine()
        If key.Key = ConsoleKey.D1 Then
            Console.Write("Please Enter Password for JPACCOUNT User/default[jpaccount]: ")
            keycode = 1
        Else
            'Console.Write("Please Enter 2 to Exit ")
            'Exit Function


            keycode = 2
            Return "EXIT"
        End If

        While (True)
            While Console.KeyAvailable() = False
                System.Threading.Thread.Sleep(50)
            End While
            cki = Console.ReadKey(True)
            If cki.Key = ConsoleKey.Enter Then
                Console.WriteLine()
                Exit While
            ElseIf cki.Key = ConsoleKey.Backspace Then
                If sb.Length > 0 Then
                    sb.Length -= 1
                    Console.Write(ChrW(8) & ChrW(32) & ChrW(8))
                End If
                Continue While
            ElseIf Asc(cki.KeyChar) < 32 OrElse Asc(cki.KeyChar) > 126 Then
                Continue While
            End If
            sb.Append(cki.KeyChar)
            Console.Write(passwordMask)
        End While
        pwd = sb.ToString()
        Return pwd
    End Function

    Private Function Encrypt(ByRef pPassPhrase As String, ByVal pTextToEncrypt As String) As String

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
    Public Function StrToHex(ByRef Data As String) As String
        Dim sVal As String
        Dim sHex As String = ""
        While Data.Length > 0
            sVal = Conversion.Hex(Strings.Asc(Data.Substring(0, 1).ToString()))
            Data = Data.Substring(1, Data.Length - 1)
            sHex = sHex & sVal
        End While
        Return sHex
    End Function
End Module

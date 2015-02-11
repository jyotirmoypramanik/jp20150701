Imports System.Xml
Imports System.IO
Imports JPEncrypt

Module readCfg
    Dim xmlDoc As New Xml.XmlDocument
    Dim xmlNode As Xml.XmlNode
    Dim xmlNodeR As Xml.XmlNode
    Dim xmlNodeS As Xml.XmlNode
    Dim xmlList As Xml.XmlNodeList
    Dim aRequiredVersion As String = ""
    Dim aSupportedVersion As String = ""
    Dim path As String
    Dim aConfigPath, aPwdPath As String
    Public mydsn, myuserid, mypwd As String
    Dim pfile As FileStream
    Dim preader As StreamReader
    Dim encryptedpwd, decryptedpwd As String
    Sub readdbconfig()
        Dim jpenc As New JPEncrypt.EncDec
        path = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().CodeBase)
        path = New Uri(path).LocalPath

        'path = System.IO.Path.GetDirectoryName( _
        '   System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase)
        aConfigPath = path + "\" + "dbconn.xml"
        If Not File.Exists(aConfigPath) Then
            Application.Exit()
            'Exit Sub
        End If

        xmlDoc.Load(aConfigPath)
        xmlNode = xmlDoc.DocumentElement.SelectSingleNode("dbconndsn")
        mydsn = xmlNode.InnerText
        xmlNode = xmlDoc.DocumentElement.SelectSingleNode("dbconnuserid")
        myuserid = xmlNode.InnerText
#If DEBUG Then
        Debug.WriteLine("Running in Debug Mode: DSN Name: " + mydsn + "User Id:" + myuserid)
#End If

        'xmlList = xmlNode.ChildNodes

        'For Each m_node In xmlList
        '    mydsn = m_node.Item("dbconndsn").InnerText
        '    myuserid = m_node.Item("dbconnuserid").InnerText
        '    mypwd = m_node.Item("dbconnpwd").InnerText
        'Next
        aPwdPath = path + "\" + "dbpwd.dat"
        If File.Exists(path + "\" + "dbpwd.dat") Then
            pfile = New FileStream(path + "\" + "dbpwd.dat", FileMode.Open)
        Else
            MessageBox.Show("The file : " & path & "\" & "dbpwd.dat" & " does not exists .. Application would close ")
            Exit Sub
        End If

        preader = New StreamReader(pfile)
        encryptedpwd = preader.ReadLine()
        If encryptedpwd = "" Then
            'Nothing to Decrypt
        Else
            'Decrypt Using Passcode

            decryptedpwd = jpenc.Decrypt("TS-JDADJMDH-7175", encryptedpwd)
            mypwd = decryptedpwd

            'Me.PasswordTextBox.Text = decryptedpwd
            'txtOutput.Text = decryptedpwd
#If DEBUG Then
            Debug.WriteLine("Running in Debug Mode: Encrypted Password " + encryptedpwd)
            Debug.WriteLine("Running in Debug Mode: Decrypted Password " + decryptedpwd)
#End If
        End If
        If mydsn <> "" Then
            Debug.WriteLine("Database DSN: " & mydsn)
        End If

        If myuserid <> "" Then
            Debug.WriteLine("Database User ID: " & myuserid)
        End If


    End Sub




End Module

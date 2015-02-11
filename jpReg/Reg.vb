
Imports Microsoft.VisualBasic
Imports System
Imports System.Security.Permissions
Imports Microsoft.Win32
'<Assembly: RegistryPermissionAttribute(SecurityAction.RequestMinimum, ViewAndModify:="HKEY_LOCAL_MACHINE")> 
Public Class Reg
    Public Uname As String
    Public Upwd As String
    Public Pass As String
    Public comp As String


    Sub readkey(ByVal ldsn As String)
        Dim regKey As RegistryKey
        Dim sw As RegistryKey
        'Dim ms As RegistryKey
        Dim odbc As RegistryKey
        Dim odbcini As RegistryKey

        'regKey = Registry.LocalMachine.OpenSubKey("HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\ODBC\ODBC.INI\" & ldsn, False)
        sw = Registry.LocalMachine.OpenSubKey("SOFTWARE", False)
        'ms = sw.OpenSubKey("Microsoft", False)
        odbc = sw.OpenSubKey("ODBC", False)
        odbcini = odbc.OpenSubKey("ODBC.INI", False)
        'rk = odbcini.OpenSubKey(ldsn)
        regKey = odbcini.OpenSubKey(ldsn, False)
        Uname = regKey.GetValue("Username").ToString
        Upwd = regKey.GetValue("Password").ToString
        'RegistryKey myKey = Registry.LocalMachine.OpenSubKey(  @"Software\MyCompany\MyAppName",   false);
        'regKey.Close()
        'For Each subKeyName As String In odbcini.GetSubKeyNames()
        '    Dim tempKey As RegistryKey = odbcini.OpenSubKey(subKeyName)
        '    MsgBox(vbCrLf & "There are " & tempKey.ValueCount.ToString() & " values for " & tempKey.Name)
        '    For Each valueName As String In tempKey.GetValueNames()
        '        MsgBox(valueName & tempKey.GetValue(valueName).ToString())
        '    Next
        'Next
        odbcini.Close()
        odbc.Close()
        'ms.Close()
        sw.Close()
        regKey.Close()


    End Sub
    Function RegKeyexists(ByVal ldsn As String) As Boolean
        Dim regKey As RegistryKey
        Dim sw As RegistryKey
        'Dim ms As RegistryKey
        Dim odbc As RegistryKey
        Dim odbcini As RegistryKey
        Dim dbcname As String
        Try
            sw = Registry.LocalMachine.OpenSubKey("SOFTWARE", False)
            'ms = sw.OpenSubKey("Microsoft", False)
            odbc = sw.OpenSubKey("ODBC", False)
            odbcini = odbc.OpenSubKey("ODBC.INI", False)
            'rk = odbcini.OpenSubKey(ldsn)
            regKey = odbcini.OpenSubKey(ldsn, False)
            dbcname = regKey.GetValue("DBCName").ToString
            If dbcname.Length > 0 Then
                Return True
            End If
        Catch ex As Exception
            Return False
        End Try
        odbcini.Close()
        odbc.Close()
        'ms.Close()
        sw.Close()
        regKey.Close()
        Return False

    End Function

    Sub ReadGenkey(ByVal Gen As String)
        'Dim regKey As RegistryKey
        Dim sw As RegistryKey
        'Dim ms As RegistryKey
        Dim acbs As RegistryKey
        Dim GenKey As RegistryKey
        ' Dim GenString As String
        ' Dim GenComp As String


        sw = Registry.LocalMachine.OpenSubKey("SOFTWARE", False)
        'ms = sw.OpenSubKey("Microsoft", False)
        acbs = sw.OpenSubKey("ACBS", False)
        'odbcini = odbc.OpenSubKey("GenAra", False)
        'rk = odbcini.OpenSubKey(ldsn)
        GenKey = acbs.OpenSubKey(Gen, False)
        Pass = GenKey.GetValue("GenKey").ToString
        comp = GenKey.GetValue("GenComp").ToString


        acbs.Close()
        'odbc.Close()
        'ms.Close()
        sw.Close()
        'regKey.Close()


    End Sub
    'Function RegGenKeyexists(ByVal Gen As String) As Boolean
    '    'Dim regKey As RegistryKey
    '    Dim sw As RegistryKey
    '    'Dim ms As RegistryKey
    '    Dim acbs As RegistryKey
    '    Dim GenKey As RegistryKey
    '    Dim GenString As String
    '    Dim GenComp As String

    '    Try
    '        sw = Registry.LocalMachine.OpenSubKey("SOFTWARE", False)
    '        'ms = sw.OpenSubKey("Microsoft", False)
    '        acbs = sw.OpenSubKey("ACBS", False)
    '        'odbcini = odbc.OpenSubKey("GenAra", False)
    '        'rk = odbcini.OpenSubKey(ldsn)
    '        GenKey = acbs.OpenSubKey(Gen, False)
    '        GenString = GenKey.GetValue("GenKey").ToString
    '        GenComp = GenKey.GetValue("GenComp").ToString
    '        If GenString.Length > 0 And GenComp.Length > 0 Then
    '            Return True
    '        End If
    '    Catch ex As Exception
    '        Return False
    '    End Try
    '    acbs.Close()
    '    'odbc.Close()
    '    'ms.Close()
    '    sw.Close()
    '    'regKey.Close()

    'End Function
End Class

Imports System
Imports System.Windows.Forms

Imports System.Data
Imports System.Data.Odbc
Imports System.Threading
Imports System.IO
'***************************************************************************
'Code    -  Main Code Behind for Database Logic
'Author  -  Jyotirmoy Pramanik
'Email   -  Jyotirmoy.Pramanik@outlook.com
'Date    -   01-JAN-2014
'Modified Date - 01-JAN-2014
'***************************************************************************
Public Class DBUsersGenClass
    Private Shared DSName As String
    Private Shared MainInvoked As Integer

    Public Property DSN() As String
        Get
            DSN = DSName
        End Get
        Set(ByVal value As String)
            DSName = value
        End Set
    End Property
    Public Property MainCounter() As Integer
        Get
            MainCounter = MainInvoked
        End Get
        Set(ByVal value As Integer)
            MainInvoked = value
        End Set
    End Property

    Sub CheckDBVersion()
        'MainCounter to Track New Instance or Existing Instance of the App

        MainCounter = MainCounter + 1
        If MainCounter > 1 Then
            'Developer Module is for User Session
            'Non Developer Module is for Admin Session
            If ModuleOwner = "Developer" Or ModuleOwner = "DEVELOPER" Then
                frmMainNav.RefreshForm()
                frmMainNav.Show()
                frmLogin.Hide()
            Else
                frmMainAdmNav.RefreshForm()
                frmMainAdmNav.Show()
                'frmLogin.MinimizeBox = True
                frmLogin.Hide()
            End If

        Else
            If ModuleOwner = "Developer" Or ModuleOwner = "DEVELOPER" Then
                'frmMainFormDev.RefreshForm()
                frmMainNav.Show()
                frmLogin.Hide()
            Else
                'frmMainForm.RefreshForm()
                frmMainAdmNav.Show()
                'frmLogin.MinimizeBox = True
                frmLogin.Hide()
            End If
        End If ' End If for MainCoutner
    End Sub
End Class

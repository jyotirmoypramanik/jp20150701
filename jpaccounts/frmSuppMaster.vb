Public Class frmSupplierMaster
    'form-frmSupplier Master
    'author-jpramanik
    'Date 23rd December
    'Modified 14th Feb 2015

    Public suppodbconn As Odbc.OdbcConnection


    Private Sub frmSupplierMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Supplier Master Main form Load
        ' Pre populates input fields
        ' DB Connection (optional)
        ' Associating DB appdbconn with suppodbconn
        suppodbconn = appdbconn.getDBConn



    End Sub

    Private Sub frmSupplierMaster_closed(sender As Object, e As EventArgs) Handles MyBase.FormClosed

        ' Supplier Master Main form Load
        If ModuleOwner = "Developer" Or ModuleOwner = "DEVELOPER" Then
            frmMainNav.RefreshForm()
            frmMainNav.Show()
            ' frmLogin.Hide()
        Else
            frmMainAdmNav.RefreshForm()
            frmMainAdmNav.Show()
            'frmLogin.MinimizeBox = True
            ' frmLogin.Hide()
        End If

    End Sub

    Sub CaptureInput()
        varSuppId = Me.txtSuppID.Text
        varSuppName = Me.txtSuppName.Text
        varSuppContact = Me.txtSuppContact.Text
        varSuppAddress = Me.txtSuppAddress.Text
        varSuppCity = Me.txtSuppCity.Text
        varSuppState = Me.cmbSuppState.Text
        varSuppCountry = Me.txtSuppCountry.Text
        varSuppPostCode = Me.txtSuppPostCode.Text
        varSuppPhone = Me.txtSuppPhone.Text
        varSuppCell = Me.txtSuppCellPhone.Text
        varSuppEmail = Me.txtSuppEmail.Text
        varSuppWeb = Me.txtSuppURL.Text
        varSuppCurrency = Me.cmbSuppCurrency.Text
        varSuppVAT = Me.txtSuppVAT.Text

    End Sub
 

    
    Private Sub btnSuppSave_Click(sender As Object, e As EventArgs) Handles btnSuppSave.Click
        'Call Capture input to get Input Values
        CaptureInput()
        AddNewSupplier(suppodbconn)

    End Sub
End Class
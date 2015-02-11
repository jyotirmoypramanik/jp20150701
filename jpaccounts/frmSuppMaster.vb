Public Class frmSupplierMaster
    'form-frmSupplier Master
    'author-jpramanik
    'Date 23rd December

    Private Sub frmSupplierMaster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Supplier Master Main form Load


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

  
 

    
End Class
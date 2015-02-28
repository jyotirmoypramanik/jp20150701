Module CommandObj
    Public secretphrase As String = "FIS-0007175-ACBS"
    Public newpwd As String
    Public ModuleOwner As String
#Region "Database"
    Public appdbconn As DBOra.db

#End Region
    
#Region "SupplierVariables"
    Public varSuppId As String

    Public varSuppName As String
    Public varSuppContact As String
    Public varSuppAddress As String

    Public varSuppCity As String
    Public varSuppState As String
    Public varSuppCountry As String
    Public varSuppPostCode As String

    Public varSuppPhone As String
    Public varSuppCell As String
    Public varSuppEmail As String
    Public varSuppWeb As String

    Public varSuppCurrency As String
    Public varSuppVAT As String

#End Region

End Module

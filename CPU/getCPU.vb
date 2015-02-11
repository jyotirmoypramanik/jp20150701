
Imports Microsoft.Win32

Public Class getCPU

    Public Shared Function GenerateArchitecture() As Int16
        If Registry.LocalMachine.OpenSubKey("Hardware\Description\System\CentralProcessor\0").GetValue("Identifier").ToString.Contains("x86") Then
            Return 32
        Else
            Return 64
        End If
    End Function



End Class

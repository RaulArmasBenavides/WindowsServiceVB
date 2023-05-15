
Imports System.ServiceProcess
Imports WindowsServiceVB

Module Module1
    Sub Main()
        Try
            Dim serv As New SMTPService
            serv.Connect()
        Catch ex As Exception
            ' LogOCService.LogErrorEx(ex, "Ocurrió un ERROR al iniciar el Servicio (Main)\n")
        End Try
    End Sub
End Module

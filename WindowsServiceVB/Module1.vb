Imports System.ServiceProcess

Module Module1
    Sub Main()
        Dim ServicesToRun As ServiceBase()
        ServicesToRun = New ServiceBase() {New Service1()}
        ServiceBase.Run(ServicesToRun)
    End Sub
End Module

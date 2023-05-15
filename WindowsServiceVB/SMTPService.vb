Imports System.Threading
Imports SmtpServer

Public Class SMTPService

    Public Sub New()

    End Sub
    Public Sub Connect()
        Try
            Dim optionsBuilder As New SmtpServerOptionsBuilder()
            optionsBuilder.ServerName("localhost")
            optionsBuilder.Port(25)
            optionsBuilder.MessageStore(New SampleMessageStore())
            optionsBuilder.MailboxFilter(New SampleMailboxFilter())
            optionsBuilder.UserAuthenticator(New SampleUserAuthenticator())
            Dim options = optionsBuilder.Build()
            Dim smtpServer As SmtpServer.SmtpServer = New SmtpServer.SmtpServer(options)
            smtpServer.StartAsync(CancellationToken.None)
            Console.WriteLine("Servidor SMTP iniciado. Presione cualquier tecla para detener...")
            Console.ReadKey()
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try

    End Sub
End Class

Imports System.Web.Mvc

Namespace Controllers
    Public Class HomeController
        Inherits Controller

        Function Index() As ActionResult
            ViewData("Title") = "RDLC on MVC VB.Net"
            Return View()
        End Function
    End Class
End Namespace
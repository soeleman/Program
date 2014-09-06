Imports System.Web.Mvc
Imports Microsoft.Reporting.WebForms

Namespace Pages

    Public Class RdlcViewer
        Inherits ViewUserControl

        Protected Overrides Sub OnInit(e As EventArgs)
            MyBase.OnInit(e)
            Context.Handler = Page
        End Sub

        Protected Overrides Sub OnLoad(e As EventArgs)
            MyBase.OnLoad(e)

            If IsPostBack Then
                Return
            End If

            Dim xmlFile = MapPath("~\App_Data\Base.xml")
            Dim rptFile = MapPath("~\App_Data\Base.rdlc")

            Dim dataSet = New DataSet()
            dataSet.ReadXml(xmlFile)

            With ReportViewer1.LocalReport
                .ReportPath = rptFile
                .DataSources.Add( _
                    New ReportDataSource() With { _
                        .Name = "VSales", _
                        .Value = dataSet.Tables(0) _
                    })
            End With
        End Sub
    End Class
End Namespace
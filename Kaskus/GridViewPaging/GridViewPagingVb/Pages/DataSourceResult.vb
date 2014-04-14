Imports System
Imports System.Collections

Namespace Pages

    Public MustInherit Class DataSourceResult
        Protected Sub New()
            TotalRecord = 0
        End Sub

        Public Property TotalRecord() As Int32

        Public Function GetList() As IList
            Return MyList()
        End Function

        Protected MustOverride Function MyList() As IList
    End Class
End Namespace
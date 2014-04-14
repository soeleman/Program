Imports System.Collections
Imports System.Collections.Generic

Namespace Pages

    Public NotInheritable Class DataGenericResult(Of T As Class)
        Inherits DataSourceResult
        Public Sub New()
            Records = New List(Of T)()
        End Sub

        Public Property Records() As List(Of T)

        Protected Overrides Function MyList() As IList
            Return Records
        End Function
    End Class
End Namespace
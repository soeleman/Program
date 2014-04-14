Imports System.Collections
Imports System.ComponentModel
Imports System.Data

Namespace Pages

    Public NotInheritable Class DataTableResult
        Inherits DataSourceResult
        Public Sub New()
            Records = New DataTable()
        End Sub

        Public Property Records() As DataTable

        Protected Overrides Function MyList() As IList
            Return (CType(Records, IListSource)).GetList()
        End Function
    End Class
End Namespace
Imports System
Imports System.Collections
Imports System.ComponentModel
Imports System.Linq

Namespace Pages

    Friend Class PageList
        Implements IListSource

        Private ReadOnly _pageSize As Int32

        Public Sub New(pageSize As Int32, totalrecord As Int64)
            Me.TotalRecord = totalrecord
            _pageSize = pageSize
        End Sub

        Public Property TotalRecord() As Int64

        Public ReadOnly Property ContainsListCollection() As [Boolean] Implements IListSource.ContainsListCollection
            Get
                Return (GetList().Count >= 1)
            End Get
        End Property

        Public Function GetList() As IList Implements IListSource.GetList
            Return Enumerable.Range(0, CType(Math.Ceiling(CType(TotalRecord, [Double]) / _pageSize), Int32)).Select(Function(pageidx) New ItemPage(_pageSize, pageidx * _pageSize)).ToList()
        End Function

        Public NotInheritable Class ItemPage

            Public ReadOnly PageSize As Int32

            Public ReadOnly CurrentPage As Int32

            Public Sub New(limit As Int32, offset As Int32)
                PageSize = limit
                CurrentPage = offset
            End Sub
        End Class
    End Class
End Namespace
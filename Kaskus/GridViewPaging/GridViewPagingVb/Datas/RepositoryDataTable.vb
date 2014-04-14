Imports System
Imports System.Data
Imports System.Globalization
Imports Dede.App.GridViewPaging.Pages

Namespace Datas

    Public NotInheritable Class RepositoryDataTable
        Implements IDataSourceRepository

        Private Shared _gridDataTable As New DataTable()

        Public Function GetData(pageSize As Int32, currentPage As Int32) _
            As DataSourceResult _
            Implements IDataSourceRepository.GetData

            InitGridDataTable()

            Return New DataTableResult() With { _
                .Records = _gridDataTable.AsEnumerable().Skip(currentPage).Take(pageSize).CopyToDataTable(), _
                .TotalRecord = _gridDataTable.Rows.Count _
                }
        End Function

        Private Shared Sub InitGridDataTable()
            If Not _gridDataTable.Rows.Count.Equals(0) Then
                Return
            End If

            _gridDataTable.Rows.Clear()
            _gridDataTable = GenerateGridDataTable()
        End Sub

        Private Shared Function GenerateGridDataTable() As DataTable
            Dim rnd = New Random(100000)
            Dim dat = DateTime.Now

            Dim dt = New DataTable()
            dt.Columns.Add("Id", GetType(Guid))
            dt.Columns.Add("ItemString", GetType([String]))
            dt.Columns.Add("ItemInt32", GetType(Int32))
            dt.Columns.Add("ItemBoolean", GetType([Boolean]))
            dt.Columns.Add("ItemDecimal", GetType([Decimal]))
            dt.Columns.Add("ItemDateTime", GetType(DateTime))

            For i As Int32 = 0 To 800 - 1
                Dim itemRandom = rnd.Next()
                Dim modulus = itemRandom Mod 2
                Dim dec = itemRandom * 0.2D
                dat = dat.AddDays(0 - (itemRandom / CType(dec, Int32)))

                dt.Rows.Add(Guid.NewGuid(), itemRandom.ToString(CultureInfo.InvariantCulture), i, modulus = 0, dec, dat)
            Next

            Return dt
        End Function
    End Class
End Namespace
Imports System.Globalization
Imports Dede.App.GridViewPaging.Domains
Imports Dede.App.GridViewPaging.Pages

Namespace Datas

    Public Class RepositoryItemGrid
        Implements IDataSourceRepository

        Private Shared ReadOnly ItemsGrids As New List(Of ItemGrid)()

        Public Function GetData(pageSize As Int32, currentPage As Int32) _
            As DataSourceResult _
            Implements IDataSourceRepository.GetData

            InitItemGrid()

            Return New DataGenericResult(Of ItemGrid)() With { _
                .Records = ItemsGrids.Skip(currentPage).Take(pageSize).ToList(), _
                .TotalRecord = ItemsGrids.Count }
        End Function

        Private Shared Sub InitItemGrid()
            If Not ItemsGrids.Count.Equals(0) Then
                Return
            End If

            ItemsGrids.Clear()
            ItemsGrids.AddRange(GenerateItemGrid())
        End Sub

        Private Shared Function GenerateItemGrid() As IEnumerable(Of ItemGrid)
            Dim rnd = New Random(100000)
            Dim dat = DateTime.Now

            Dim list = New List(Of ItemGrid)

            For i As Int32 = 0 To 1000 - 1
                Dim itemRandom = rnd.Next()
                Dim modular = itemRandom Mod 2
                Dim dec = itemRandom * 0.2D
                dat = dat.AddDays(0 - (itemRandom / CType(dec, Int32)))

                list.Add(New ItemGrid() With { _
                    .Id = Guid.NewGuid(), _
                    .ItemBoolean = modular = 0, _
                    .ItemDateTime = dat, _
                    .ItemDecimal = dec, _
                    .ItemInt32 = i, _
                    .ItemString = itemRandom.ToString(CultureInfo.InvariantCulture)})
            Next

            Return list
        End Function
    End Class
End Namespace
Imports Dede.App.GridViewPaging.Pages

Namespace Datas
    Public Interface IDataSourceRepository
        Function GetData(pageSize As Int32, currentPage As Int32) As DataSourceResult
    End Interface
End Namespace
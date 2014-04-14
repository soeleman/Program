Imports System
Imports Dede.App.GridViewPaging.Pages

Namespace Datas

    Public NotInheritable Class RepositoryFactory
        Private ReadOnly _dataSourceRepository As IDataSourceRepository

        Public Sub New(dataSourceRepository As IDataSourceRepository)
            _dataSourceRepository = dataSourceRepository
        End Sub

        Public Function GetData(pageSize As Int32, currentPage As Int32) As DataSourceResult
            Return _dataSourceRepository.GetData(pageSize, currentPage)
        End Function
    End Class
End Namespace
namespace Dede.App.GridViewPaging.Datas
{
    using System;

    using Dede.App.GridViewPaging.Pages;

    public interface IDataSourceRepository
    {
        DataSourceResult GetData(Int32 pageSize, Int32 currentPage);
    }
}
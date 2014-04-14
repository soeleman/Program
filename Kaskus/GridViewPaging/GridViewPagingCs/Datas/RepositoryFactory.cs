namespace Dede.App.GridViewPaging.Datas
{
    using System;

    using Dede.App.GridViewPaging.Pages;

    public sealed class RepositoryFactory
    {
        private readonly IDataSourceRepository dataSourceRepository;

        public RepositoryFactory(
            IDataSourceRepository dataSourceRepository)
        {
            this.dataSourceRepository = dataSourceRepository;
        }

        public DataSourceResult GetData(
            Int32 pageSize, 
            Int32 currentPage)
        {
            return this.dataSourceRepository.GetData(pageSize, currentPage);
        }
    }
}
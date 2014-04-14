namespace Dede.App.GridViewPaging.Pages
{
    using System.Collections;
    using System.ComponentModel;
    using System.Data;

    public sealed class DataTableResult
        : DataSourceResult
    {
        public DataTableResult()
        {
            this.Records = new DataTable();
        }

        public DataTable Records { get; set; }

        protected override IList MyList()
        {
            return ((IListSource)this.Records).GetList();
        }
    }
}
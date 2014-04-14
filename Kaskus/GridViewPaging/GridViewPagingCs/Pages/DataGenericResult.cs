namespace Dede.App.GridViewPaging.Pages
{
    using System.Collections;
    using System.Collections.Generic;

    public sealed class DataGenericResult<T>
        : DataSourceResult
        where T : class
    {
        public DataGenericResult()
        {
            this.Records = new List<T>();
        }

        public List<T> Records { get; set; }

        protected override IList MyList()
        {
            return this.Records;
        }
    }
}
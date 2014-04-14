namespace Dede.App.GridViewPaging.Pages
{
    using System;
    using System.Collections;

    public abstract class DataSourceResult
    {
        protected DataSourceResult()
        {
            this.TotalRecord = 0;
        }

        public Int32 TotalRecord { get; set; }

        public IList GetList()
        {
            return this.MyList();
        }

        protected abstract IList MyList();
    }
}
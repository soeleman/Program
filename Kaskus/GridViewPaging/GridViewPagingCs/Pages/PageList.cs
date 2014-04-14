namespace Dede.App.GridViewPaging.Pages
{
    using System;
    using System.Collections;
    using System.ComponentModel;
    using System.Linq;

    internal class PageList
        : IListSource
    {
        private readonly Int32 pageSize;

        public PageList(
            Int32 pageSize,
            Int64 totalrecord)
        {
            this.TotalRecord = totalrecord;
            this.pageSize    = pageSize;
        }

        public Int64 TotalRecord { get; set; }

        public Boolean ContainsListCollection { get; protected set; }

        public IList GetList()
        {
            return Enumerable
                .Range(0, (Int32)Math.Ceiling((Double)this.TotalRecord / this.pageSize))
                .Select(pageidx => new ItemPage(this.pageSize, pageidx * this.pageSize))
                .ToList();
        }

        public sealed class ItemPage
        {
            public readonly Int32 PageSize;

            public readonly Int32 CurrentPage;

            public ItemPage(
                Int32 limit,
                Int32 offset)
            {
                this.PageSize    = limit;
                this.CurrentPage = offset;
            }
        }
    }
}
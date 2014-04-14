namespace Dede.App.GridViewPaging.Datas
{
    using System;
    using System.Data;
    using System.Globalization;
    using System.Linq;

    using Dede.App.GridViewPaging.Pages;

    public sealed class RepositoryDataTable
        : IDataSourceRepository
    {
        private static DataTable gridDataTable = new DataTable();

        public DataSourceResult GetData(
            Int32 pageSize,
            Int32 currentPage)
        {
            InitGridDataTable();

            return new DataTableResult
            {
                Records = gridDataTable
                    .AsEnumerable()
                    .Skip(currentPage)
                    .Take(pageSize)
                    .CopyToDataTable(),
                TotalRecord = gridDataTable.Rows.Count
            };
        }

        private static void InitGridDataTable()
        {
            if (!gridDataTable.Rows.Count.Equals(0))
            {
                return;
            }

            gridDataTable.Rows.Clear();
            gridDataTable = GenerateGridDataTable();
        }

        private static DataTable GenerateGridDataTable()
        {
            var rnd = new Random(100000);
            var dat = DateTime.Now;

            var dt = new DataTable();

            dt.Columns.Add(@"Id", typeof(Guid));
            dt.Columns.Add(@"ItemString", typeof(String));
            dt.Columns.Add(@"ItemInt32", typeof(Int32));
            dt.Columns.Add(@"ItemBoolean", typeof(Boolean));
            dt.Columns.Add(@"ItemDecimal", typeof(Decimal));
            dt.Columns.Add(@"ItemDateTime", typeof(DateTime));

            for (var i = 0; i < 500; i++)
            {
                var itemRandom = rnd.Next();

                var mod = itemRandom % 2;
                var dec = itemRandom * 0.2M;
                dat = dat.AddDays(0 - (itemRandom / (Int32)dec));

                dt.Rows.Add(
                    Guid.NewGuid(),
                    itemRandom.ToString(CultureInfo.InvariantCulture),
                    i,
                    mod == 0,
                    dec,
                    dat);
            }

            return dt;
        }
    }
}
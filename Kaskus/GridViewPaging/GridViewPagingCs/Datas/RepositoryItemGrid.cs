namespace Dede.App.GridViewPaging.Datas
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    using Dede.App.GridViewPaging.Domains;
    using Dede.App.GridViewPaging.Pages;

    public sealed class RepositoryItemGrid
        : IDataSourceRepository
    {
        private static readonly List<ItemGrid> ItemsGrids = new List<ItemGrid>();

        public DataSourceResult GetData(
            Int32 pageSize, 
            Int32 currentPage)
        {
            InitItemGrid();

            return new DataGenericResult<ItemGrid>
            {
                Records = ItemsGrids
                    .Skip(currentPage)
                    .Take(pageSize)
                    .ToList(),
                TotalRecord = ItemsGrids.Count
            };
        }

        private static void InitItemGrid()
        {
            if (!ItemsGrids.Count.Equals(0))
            {
                return;
            }

            ItemsGrids.Clear();
            ItemsGrids.AddRange(GenerateItemGrid().ToList());
        }

        private static IEnumerable<ItemGrid> GenerateItemGrid()
        {
            var rnd = new Random(100000);
            var dat = DateTime.Now;

            for (var i = 0; i < 1200; i++)
            {
                var itemRandom = rnd.Next();

                var mod = itemRandom % 2;
                var dec = itemRandom * 0.2M;
                dat = dat.AddDays(0 - (itemRandom / (Int32)dec));

                yield return
                    new ItemGrid
                    {
                        Id           = Guid.NewGuid(),
                        ItemBoolean  = mod == 0,
                        ItemDateTime = dat,
                        ItemDecimal  = dec,
                        ItemInt32    = i,
                        ItemString   = itemRandom.ToString(CultureInfo.InvariantCulture)
                    };
            }
        }
    }
}
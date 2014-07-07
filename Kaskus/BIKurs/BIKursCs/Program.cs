namespace Dede.App.BIKurs
{
    using System;
    using System.Linq;

    // http://dotnetfiddle.net/U21IBg
    internal static class Program
    {
        private const String UrlBiKurs = @"http://www.bi.go.id/id/moneter/informasi-kurs/transaksi-bi/Default.aspx";

        private const String XpathTable = @"//table[@class=""table1""]";

        internal static void Main()
        {
            var doc = (new HtmlAgilityPack.HtmlWeb()).Load(UrlBiKurs);

            (from table in doc.DocumentNode.SelectNodes(XpathTable)
             where table.Attributes.Contains(@"id")
             from row in table.SelectNodes(@"tr")
             where row.ChildNodes.Count >= 2 && row.ChildNodes.Any(p => p.Name.Equals(@"td"))
             select row)
            .ToList()
            .ForEach(node =>
                Console.WriteLine(
                    @"{1}{0}{2}{0}{3}",
                    "\t",
                    node.ChildNodes[1].ChildNodes[0].InnerText,
                    node.ChildNodes[3].ChildNodes[0].InnerText,
                    node.ChildNodes[4].ChildNodes[0].InnerText));

            doc
                .DocumentNode
                .SelectNodes(XpathTable)
                .Where(table => table.Attributes.Contains(@"id"))
                .SelectMany(table => table.SelectNodes(@"tr"), (table, row) => new { table, row })
                .Where(p => p.row.ChildNodes.Count >= 2 && p.row.ChildNodes.Any(pn => pn.Name.Equals(@"td")))
                .Select(s => s.row)
                .ToList()
                .ForEach(node =>
                    Console.WriteLine(
                        @"{1}{0}{2}{0}{3}",
                        "\t",
                        node.ChildNodes[1].ChildNodes[0].InnerText,
                        node.ChildNodes[3].ChildNodes[0].InnerText,
                        node.ChildNodes[4].ChildNodes[0].InnerText));

            Console.Read();
        }
    }
}
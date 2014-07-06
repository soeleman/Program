namespace IndexdiKoding
{
    using System;
    using System.Linq;

    using Hap = HtmlAgilityPack;

    internal class Program
    {
        private const String UrlTarget = @"http://dikoding.cloudapp.net/";
        private const String XpathTable = @"//a[@href]";

        public static void Main()
        {
            var doc = (new Hap.HtmlWeb()).Load(UrlTarget);

            // Linq to XML
            var nodes =
                from n in doc.DocumentNode.Descendants(@"a")
                where 
                    n.HasAttributes && 
                    n.Attributes.Contains(@"class") == false && 
                    n.Attributes.Contains(@"title")
                select n;

            nodes
                .ToList()
                .ForEach(n => Console.WriteLine(n.InnerText.Trim()));

            Console.WriteLine("------------------------------");

            // XPath
            doc
                .DocumentNode
                .SelectNodes(XpathTable)
                .Where(p =>
                    p.HasAttributes &&
                    p.Attributes.Contains(@"class") == false &&
                    p.Attributes.Contains(@"title"))
                .ToList()
                .ForEach(n => Console.WriteLine(n.InnerText.Trim()));
        }
    }
}
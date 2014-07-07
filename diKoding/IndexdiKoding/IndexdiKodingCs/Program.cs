namespace IndexdiKoding
{
    using System;
    using System.Linq;

    internal class Program
    {
        public static void Main()
        {
            var doc = (new HtmlAgilityPack.HtmlWeb()).Load(@"http://dikoding.cloudapp.net/");

            // Linq to XML
            var nodes =
                from htmlnode in doc.DocumentNode.Descendants(@"a")
                where 
                    htmlnode.HasAttributes && 
                    htmlnode.Attributes.Contains(@"class") == false && 
                    htmlnode.Attributes.Contains(@"title")
                select htmlnode;

            nodes
                .ToList()
                .ForEach(htmlnode => Console.WriteLine(htmlnode.InnerText.Trim()));

            Console.WriteLine("------------------------------");

            // XPath
            doc
                .DocumentNode
                .SelectNodes(@"//a[@href]")
                .Where(p =>
                    p.HasAttributes &&
                    p.Attributes.Contains(@"class") == false &&
                    p.Attributes.Contains(@"title"))
                .ToList()
                .ForEach(htmlnode => Console.WriteLine(htmlnode.InnerText.Trim()));
        }
    }
}
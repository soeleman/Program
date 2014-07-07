Imports System
Imports System.Linq

Imports Hap = HtmlAgilityPack

Module ModuleMain

    Private Const UrlBiKurs As [String] = "http://www.bi.go.id/id/moneter/informasi-kurs/transaksi-bi/Default.aspx"

    Private Const XpathTable As [String] = "//table[@class=""table1""]"

    Sub Main()
        Dim doc = (New HtmlAgilityPack.HtmlWeb()).Load(UrlBiKurs)

        Dim nodes =
            (From table In doc.DocumentNode.SelectNodes(XpathTable)
            Where table.Attributes.Contains("id")
            From row In table.SelectNodes("tr")
            Where row.ChildNodes.Count >= 2 AndAlso row.ChildNodes.Any(Function(p) p.Name.Equals("td"))
            Select row) _
            .ToList()

        nodes.ForEach( _
            Sub(node)
                Console.WriteLine( _
                    "{1}{0}{2}{0}{3}", _
                    vbTab, _
                    node.ChildNodes(1).ChildNodes(0).InnerText, _
                    node.ChildNodes(3).ChildNodes(0).InnerText, _
                    node.ChildNodes(4).ChildNodes(0).InnerText)
            End Sub)

        doc.DocumentNode _
            .SelectNodes(XpathTable) _
            .Where(Function(table) table.Attributes.Contains("id")) _
            .SelectMany(Function(table) table.SelectNodes("tr"), Function(table, row) New With {table, row}) _
            .Where(Function(p) p.row.ChildNodes.Count >= 2 AndAlso p.row.ChildNodes.Any(Function(pn) pn.Name.Equals("td"))) _
            .Select(Function(s) s.row) _
            .ToList() _
            .ForEach( _
                Sub(node)
                    Console.WriteLine( _
                        "{1}{0}{2}{0}{3}", _
                        vbTab, _
                        node.ChildNodes(1).ChildNodes(0).InnerText, _
                        node.ChildNodes(3).ChildNodes(0).InnerText, _
                        node.ChildNodes(4).ChildNodes(0).InnerText)
                End Sub)

        Console.Read()
    End Sub
End Module
Imports System
Imports System.Linq

Imports Hap = HtmlAgilityPack

Module ModuleMain
    Private Const UrlTarget As [String] = "http://dikoding.cloudapp.net/"
    Private Const XpathTable As [String] = "//a[@href]"

    Public Sub Main()
        Dim doc = (New Hap.HtmlWeb()).Load(UrlTarget)

        ' Linq to XML
        Dim nodes =
            From n In doc.DocumentNode.Descendants("a")
            Where
                n.HasAttributes AndAlso
                n.Attributes.Contains("class") = False AndAlso
                n.Attributes.Contains("title")
            Select n

        nodes _
            .ToList() _
            .ForEach(Sub(n) Console.WriteLine(n.InnerText.Trim()))

        Console.WriteLine("------------------------------")

        ' XPath
        doc _
            .DocumentNode() _
            .SelectNodes(XpathTable) _
            .Where(Function(p) _
                p.HasAttributes AndAlso _
                p.Attributes.Contains("class") = False AndAlso _
                p.Attributes.Contains("title")) _
            .ToList() _
            .ForEach(Sub(n) Console.WriteLine(n.InnerText.Trim()))
    End Sub

End Module

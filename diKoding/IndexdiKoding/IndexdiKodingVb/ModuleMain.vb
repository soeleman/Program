Imports System
Imports System.Linq

Module ModuleMain

    Public Sub Main()
        Dim doc = (New HtmlAgilityPack.HtmlWeb()).Load("http://dikoding.cloudapp.net/")

        ' Linq to XML
        Dim nodes =
            From htmlnode In doc.DocumentNode.Descendants("a")
            Where
                htmlnode.HasAttributes AndAlso
                htmlnode.Attributes.Contains("class") = False AndAlso
                htmlnode.Attributes.Contains("title")
            Select htmlnode

        nodes _
            .ToList() _
            .ForEach(Sub(n) Console.WriteLine(n.InnerText.Trim()))

        Console.WriteLine("------------------------------")

        ' XPath
        doc _
            .DocumentNode() _
            .SelectNodes("//a[@href]") _
            .Where(Function(p) _
                p.HasAttributes AndAlso _
                p.Attributes.Contains("class") = False AndAlso _
                p.Attributes.Contains("title")) _
            .ToList() _
            .ForEach(Sub(htmlnode) Console.WriteLine(htmlnode.InnerText.Trim()))
    End Sub
End Module

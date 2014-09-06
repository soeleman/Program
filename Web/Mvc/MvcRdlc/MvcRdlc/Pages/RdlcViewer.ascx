<%@ Control 
    Language="C#" 
    AutoEventWireup="true" 
    CodeBehind="RdlcViewer.ascx.cs" 
    Inherits="MvcRdlc.Pages.RdlcViewer" %>
<%@ Register 
    Assembly="Microsoft.ReportViewer.WebForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" 
    Namespace="Microsoft.Reporting.WebForms" 
    TagPrefix="rsweb" %>
<form id="form1" runat="server">
    <asp:ScriptManager 
        ID="ScriptManager1" 
        runat="server" 
        EnablePartialRendering="False" />
    <div>
        <rsweb:ReportViewer 
            ID="ReportViewer1" 
            runat="server" 
            AsyncRendering ="False" 
            SizeToReportContent="True" />
    </div>
</form>
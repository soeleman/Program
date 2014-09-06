namespace MvcRdlc.Pages
{
    using System;
    using System.Data;
    using System.Web.Mvc;

    using Microsoft.Reporting.WebForms;

    public partial class RdlcViewer
        : ViewUserControl
    {
        protected override void OnInit(
            EventArgs e)
        {
            base.OnInit(e);
            this.Context.Handler = this.Page;
        }

        protected override void OnLoad(
            EventArgs e)
        {
            base.OnLoad(e);

            if (this.IsPostBack)
            {
                return;
            }

            var xmlFile =
                this.MapPath(@"~\App_Data\Base.xml");

            var dataSet = new DataSet();
            dataSet.ReadXml(xmlFile);

            this.ReportViewer1.LocalReport.ReportPath =
                this.MapPath(@"~\App_Data\Base.rdlc");

            this.ReportViewer1.LocalReport.DataSources.Add(
                new ReportDataSource(
                    @"VSales",
                    dataSet.Tables[0]));
        }
    }
}
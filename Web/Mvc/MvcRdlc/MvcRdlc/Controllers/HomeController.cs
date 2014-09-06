namespace MvcRdlc.Controllers
{
    using System.Web.Mvc;

    public class HomeController 
        : Controller
    {
        public ActionResult Index()
        {
            this.ViewBag.Title = @"RDLC on MVC C#";
            return this.View();
        }
    }
}
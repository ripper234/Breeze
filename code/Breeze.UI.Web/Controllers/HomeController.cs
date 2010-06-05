using System.Web.Mvc;

namespace Breeze.UI.Web.Controllers
{
    [HandleError]
    public class HomeController : BreezeControllerBase
    {
        public ActionResult Index()
        {
            ViewData["Message"] = "Welcome to ASP.NET MVC!";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}

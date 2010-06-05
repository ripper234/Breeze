using System.Web.Mvc;

namespace Breeze.UI.Web.Controllers
{
    public abstract class BreezeControllerBase : Controller
    {
        protected override JsonResult Json(object data, string contentType, System.Text.Encoding contentEncoding, JsonRequestBehavior behavior)
        {
            return base.Json(data, contentType, contentEncoding, JsonRequestBehavior.AllowGet);
        }
    }
}

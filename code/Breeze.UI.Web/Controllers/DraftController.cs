using System.Web.Mvc;
using Breeze.Core.Services;
using Breeze.Model.DataObjects;

namespace Breeze.UI.Web.Controllers
{
    public class DraftController : BreezeControllerBase
    {
        private readonly IDraftManager _draftManager;

        public DraftController(IDraftManager draftManager)
        {
            _draftManager = draftManager;
        }

        [HttpPost]
        public int Create(int ownerId, DraftOptions options)
        {
            var draftId =_draftManager.Create(ownerId, options);
            return draftId;
        }

        public JsonResult GetDrafts()
        {
            var drafts = _draftManager.GetAll();
            return Json(drafts);
        }
    }
}

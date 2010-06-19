using System.Web.Mvc;
using Breeze.Core.Services;
using Breeze.Model.DataObjects;
using System.Linq;
using Breeze.Model.Dtos;

namespace Breeze.UI.Web.Controllers
{
    public class DraftController : BreezeControllerBase
    {
        private readonly IDraftManager _draftManager;
        private readonly IPlayersService _playerService;

        public DraftController(IDraftManager draftManager, IPlayersService playerService)
        {
            _draftManager = draftManager;
            _playerService = playerService;
        }

        [HttpPost]
        public int Create(int ownerId, DraftOptionsDto options)
        {
            var draftId =_draftManager.Create(ownerId, new DraftOptions(options));
            return draftId;
        }

        public JsonResult GetDrafts()
        {
            var drafts = _draftManager.GetAll();
            return Json(drafts.Select(d => new DraftDto(d, _playerService.Get(d.OwnerId).Nick)));
        }
    }
}

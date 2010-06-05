using System.Web.Mvc;
using Breeze.Core.Services;

namespace Breeze.UI.Web.Controllers
{
    public class LobbyController : BreezeControllerBase
    {
        private readonly IPlayersService _playersService;

        public LobbyController(IPlayersService playersService)
        {
            _playersService = playersService;
        }

        //
        // GET: /Lobby/

        public ActionResult Index()
        {
            return View();
        }

    }
}

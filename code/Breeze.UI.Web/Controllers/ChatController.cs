using System.Web.Mvc;
using Breeze.Core.Services;
using Breeze.Model.Dtos;

namespace Breeze.UI.Web.Controllers
{
    public class ChatController : BreezeControllerBase
    {
        private readonly IPlayersService _playersService;

        public ChatController(IPlayersService playersService)
        {
            _playersService = playersService;
        }

        public JsonResult GetPlayersInLobby()
        {
            return Json(new PlayersDto(_playersService.GetPlayersInLobby()));
        }

        [HttpPost]
        public void Ping(int playerId)
        {
            _playersService.PingReceived(playerId);
        }
    }
}

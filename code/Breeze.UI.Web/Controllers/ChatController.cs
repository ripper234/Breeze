using System.Web.Mvc;
using Breeze.Core.Services;
using Breeze.Model.Dtos;

namespace Breeze.UI.Web.Controllers
{
    public class ChatController : BreezeControllerBase
    {
        private readonly IPlayersService _playersService;
        private readonly IChatService _chatService;

        public ChatController(IPlayersService playersService, IChatService chatService)
        {
            _playersService = playersService;
            _chatService = chatService;
        }

        public JsonResult GetPlayersInLobby()
        {
            return Json(new PlayersDto(_playersService.GetPlayersInLobby()));
        }

        [HttpPost]
        public void SendMessage(int playerId, string text)
        {
            var player = _playersService.Get(playerId);
            if (player == null)
            {
                // non-existent player
                return;
            }

            _chatService.SendMessage(player.Id, player.Nick, text);
        }

        public JsonResult GetMessagesDelta(int playerId, int lastChatRow)
        {
            _playersService.PingReceived(playerId);
            return Json(_chatService.GetMessagesDelta(lastChatRow));
        }
    }
}

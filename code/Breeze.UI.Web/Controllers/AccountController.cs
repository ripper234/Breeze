using System;
using System.Web.Mvc;
using Breeze.Core.Services;
using Breeze.UI.Web.Utils;

namespace Breeze.UI.Web.Controllers
{
    public class AccountController : Controller
    {
        private readonly IPlayersService _playersService;

        public AccountController(IPlayersService playersService)
        {
            _playersService = playersService;
        }
        
        /// <summary>
        /// Choose a nick, store
        /// </summary>
        /// <param name="nickname"></param>
        public ActionResult ChooseNick(string nickname)
        {
            if (string.IsNullOrEmpty(nickname))
                throw new Exception("Empty nickname");

            var id = _playersService.RegisterNewPlayer(nickname);

            Session.Add(SessionConsts.Nickname, nickname);
            Session.Add(SessionConsts.PlayerID, id);

            return RedirectToAction("Index", "Lobby");
        }
    }
}

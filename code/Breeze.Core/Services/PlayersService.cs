using System;
using Breeze.Common;
using Breeze.Common.Model;

namespace Breeze.Core.Services
{
    public class PlayersService : IPlayersService
    {
        private readonly IIDService _idService;
        private readonly PlayersData _allPlayers = new PlayersData();

        public PlayersService(IIDService idService)
        {
            _idService = idService;
        }

        public int RegisterNewPlayer(string nick)
        {
            var id = _idService.CreateID();
            var playerData = new PlayerData(nick, id);

            _allPlayers.AddPlayer(playerData);
            return id;
        }

        public PlayersData GetPlayersInLobby()
        {
            return _allPlayers;
        }

        public PlayersData GetPlayersInDraft(int draftId)
        {
            throw new NotImplementedException();
        }
    }
}

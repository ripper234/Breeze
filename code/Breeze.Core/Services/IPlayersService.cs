using System.Collections.Generic;
using Breeze.Model.DataObjects;

namespace Breeze.Core.Services
{
    public interface IPlayersService
    {
        int RegisterNewPlayer(string nick);
        ICollection<PlayerData> GetPlayersInLobby();
        PlayersData GetPlayersInDraft(int draftId);
        void PingReceived(int id);
        PlayerData Get(int id);
    }
}

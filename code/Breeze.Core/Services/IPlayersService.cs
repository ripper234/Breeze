using Breeze.Common.Model;

namespace Breeze.Core.Services
{
    public interface IPlayersService
    {
        int RegisterNewPlayer(string nick);
        PlayersData GetPlayersInLobby();
        PlayersData GetPlayersInDraft(int draftId);
    }
}

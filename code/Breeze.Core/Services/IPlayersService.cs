using Breeze.Common;

namespace Breeze.Core.Services
{
    public interface IPlayersService
    {
        PlayersData GetPlayersInLobby();
        PlayersData GetPlayersInDraft(int draftId);
    }
}

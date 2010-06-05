using System.Collections.Generic;

namespace Breeze.Common.Model
{
    public class PlayersData
    {
        private readonly List<PlayerData> _players = new List<PlayerData>();

        public List<PlayerData> Players
        {
            get { return _players; }
        }

        public void AddPlayer(PlayerData player)
        {
            lock (_players)
                _players.Add(player);
        }
    }
}
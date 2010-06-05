using System;
using System.Collections.Generic;

namespace Breeze.Model.DataObjects
{
    /// <summary>
    /// Not thread safe
    /// 
    /// // todo - move to .Net 4.0 and ConcurrentDictionary
    /// </summary>
    public class PlayersData
    {
        private readonly Dictionary<int, PlayerData> _players = new Dictionary<int, PlayerData>();

        public ICollection<PlayerData> PlayersCopy
        {
            get
            {
                return new List<PlayerData>(_players.Values);
            }
        }

        public void AddPlayer(PlayerData player)
        {
            _players.Add(player.Id, player);
        }

        public PlayerData Get(int id)
        {
            PlayerData retval;
            return _players.TryGetValue(id, out retval) ? retval : null;
        }

        public void RemovePlayer(int id)
        {
            _players.Remove(id);
        }
    }
}
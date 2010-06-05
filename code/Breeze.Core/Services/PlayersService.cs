using System;
using System.Collections.Generic;
using System.Threading;
using Breeze.Model.DataObjects;

namespace Breeze.Core.Services
{
    public class PlayersService : IPlayersService, IDisposable
    {
        private readonly IIDService _idService;
        private readonly PlayersData _allPlayers = new PlayersData();
        private readonly TimeSpan _timeoutPlayersPeriod = TimeSpan.FromSeconds(5); // todo change this
        private readonly Timer _timer;

        public PlayersService(IIDService idService)
        {
            _idService = idService;
            _timer = new Timer(CleanTimeoutPlayers, null, 0, (int)_timeoutPlayersPeriod.TotalMilliseconds);
        }

        private void CleanTimeoutPlayers(object state)
        {
            lock (_allPlayers)
            {
                foreach (var player in _allPlayers.PlayersCopy)
                {
                    if (DateTime.Now.Subtract(player.LastPingReceived).CompareTo(_timeoutPlayersPeriod) > 0)
                        _allPlayers.RemovePlayer(player.Id);
                }
            }
        }

        public int RegisterNewPlayer(string nick)
        {
            var id = _idService.CreateID();
            var playerData = new PlayerData(nick, id);

            lock (_allPlayers)
                _allPlayers.AddPlayer(playerData);

            return id;
        }

        public ICollection<PlayerData> GetPlayersInLobby()
        {
            lock (_allPlayers)
                return _allPlayers.PlayersCopy;
        }

        public void PingReceived(int id)
        {
            PlayerData player;
            lock (_allPlayers)
            {
                player = _allPlayers.Get(id);
            }
            if (player == null)
                return;

            player.LastPingReceived = DateTime.Now;
        }

        public PlayerData Get(int id)
        {
            lock (_allPlayers)
                return _allPlayers.Get(id);
        }

        public PlayersData GetPlayersInDraft(int draftId)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _timer.Dispose();
        }
    }
}

using System;

namespace Breeze.Model.DataObjects
{
    public class PlayerData
    {
        public PlayerData(string nick, int id)
        {
            Nick = nick;
            Id = id;
            LastPingReceived = DateTime.Now;
        }

        public string Nick { get; set; }
        public int Id { get; set; }
        public string IP { get; set; }
        public DateTime LastPingReceived { get; set; }
    }
}
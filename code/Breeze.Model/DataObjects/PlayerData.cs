namespace Breeze.Common
{
    public class PlayerData
    {
        public PlayerData(string nick, int id)
        {
            Nick = nick;
            Id = id;
        }

        public string Nick { get; set; }
        public int Id { get; set; }
        public string IP { get; set; }
    }
}
using Breeze.Common;

namespace Breeze.Model.Dtos
{
    public class PlayerDto
    {
        public string Nick { get; set; }

        public PlayerDto(PlayerData player)
        {
            Nick = player.Nick;
        }
    }
}
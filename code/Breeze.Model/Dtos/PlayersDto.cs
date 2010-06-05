using System.Collections.Generic;
using System.Linq;
using Breeze.Model.DataObjects;

namespace Breeze.Model.Dtos
{
    public class PlayersDto
    {
        public List<PlayerDto> Players { get; set; }
        public PlayersDto(IEnumerable<PlayerData> playersData)
        {
            Players = (from p in playersData select new PlayerDto(p)).ToList();
        }
    }
}
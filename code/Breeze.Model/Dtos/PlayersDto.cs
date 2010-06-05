using System.Collections.Generic;
using System.Linq;
using Breeze.Common.Model;

namespace Breeze.Model.Dtos
{
    public class PlayersDto
    {
        public List<PlayerDto> Players { get; set; }
        public PlayersDto(PlayersData playersData)
        {
            Players = (from p in playersData.Players select new PlayerDto(p)).ToList();
        }
    }
}
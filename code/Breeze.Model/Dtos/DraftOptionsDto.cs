using System.Collections.Generic;

namespace Breeze.Model.Dtos
{
    public class DraftOptionsDto
    {
        public string Title {get; set;}
        public int PickTime { get; set; }
        public int TargetPlayers { get; set; }
        public List<string> Packs { get; set; }
    }
}

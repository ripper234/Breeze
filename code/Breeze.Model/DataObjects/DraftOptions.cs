using System.Collections.Generic;

namespace Breeze.Model.DataObjects
{
    public class DraftOptions
    {
        public List<Expansion> Packs { get; set; }
        public string Title { get; set; }
        public int PickTime { get; set; }
        public int TargetPlayers { get; set; }
    }
}

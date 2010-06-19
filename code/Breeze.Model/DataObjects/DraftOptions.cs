using System;
using System.Collections.Generic;
using Breeze.Model.Dtos;

namespace Breeze.Model.DataObjects
{
    public class DraftOptions
    {
        public DraftOptions(DraftOptionsDto options)
        {
            Title = options.Title;
            PickTime = options.PickTime;
            TargetPlayers = options.TargetPlayers;
            
        }

        public List<Expansion> Packs { get; set; }
        public string Title { get; set; }
        public int PickTime { get; set; }
        public int TargetPlayers { get; set; }
    }
}

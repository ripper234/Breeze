using System.Collections.Generic;
using Breeze.Model.DataObjects;
using System.Linq;

namespace Breeze.Model.Dtos
{
    public class DraftDto
    {
        public DraftDto(Draft draft, string ownerNick)
        {
            Owner = ownerNick;
            Title = draft.Options.Title;
            BoosterAcronyms = draft.Options.Packs.Select(p => p.Acronym).ToList();
        }

        public string Owner { get; set; }
        public string Title { get; set; }
        public List<string> BoosterAcronyms { get; set;}
    }
}

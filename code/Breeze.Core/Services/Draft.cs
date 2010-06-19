using Breeze.Model.DataObjects;

namespace Breeze.Core.Services
{
    public class Draft
    {
        public Draft(int id, DraftOptions options)
        {
            Id = id;
            Options = options;
        }

        public int Id {get; private set;}
        public DraftOptions Options { get; set; }
    }
}
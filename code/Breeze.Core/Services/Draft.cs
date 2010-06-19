using Breeze.Model.DataObjects;

namespace Breeze.Core.Services
{
    public class Draft
    {
        public Draft(int draftId, int ownerId, DraftOptions options)
        {
            DraftId = draftId;
            Options = options;
            OwnerId = ownerId;
        }

        public int DraftId {get; private set;}
        public int OwnerId { get; private set; }
        public DraftOptions Options { get; set; }
    }
}
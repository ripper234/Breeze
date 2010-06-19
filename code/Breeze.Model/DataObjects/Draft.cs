using System;

namespace Breeze.Model.DataObjects
{
    public class Draft
    {
        public Draft(int draftId, int ownerId, DraftOptions options)
        {
            if (options == null)
                throw new NullReferenceException("options");

            DraftId = draftId;
            Options = options;
            OwnerId = ownerId;
        }

        public int DraftId {get; private set;}
        public int OwnerId { get; private set; }
        public DraftOptions Options { get; set; }
    }
}
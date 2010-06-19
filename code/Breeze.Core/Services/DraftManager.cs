using System.Collections.Generic;
using Breeze.Model.DataObjects;

namespace Breeze.Core.Services
{
    public class DraftManager : IDraftManager
    {
        private readonly IIDService _idService;
        private readonly Dictionary<int, Draft> _drafts = new Dictionary<int, Draft>();

        public DraftManager(IIDService idService)
        {
            _idService = idService;
        }

        public int Create(DraftOptions options)
        {
            int draftId = _idService.CreateID();
            var draft = new Draft(draftId, options);
            lock (_drafts)
                _drafts[draftId] = draft;

            return draftId;
        }

        public IList<Draft> GetAll()
        {
            lock (_drafts)
                return new List<Draft>(_drafts.Values);
        }
    }
}
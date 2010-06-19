using System.Collections.Generic;
using Breeze.Model.DataObjects;

namespace Breeze.Core.Services
{
    public interface IDraftManager
    {
        /// <summary>
        /// Returns the draft id
        /// </summary>
        /// <param name="ownerId"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        int Create(int ownerId, DraftOptions options);

        IList<Draft> GetAll();
    }
}

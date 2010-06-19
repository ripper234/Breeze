using Breeze.Model.DataObjects;

namespace Breeze.Core.Services
{
    public interface IDraftManager
    {
        /// <summary>
        /// Returns the draft id
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        int Create(DraftOptions options);
    }
}

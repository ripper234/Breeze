namespace Breeze.Core.Services
{
    public class IDService : IIDService
    {
        private int _lastID;
        private readonly object _lockObject = new object();

        public int CreateID()
        {
            lock (_lockObject)
            {
                return ++_lastID;
            }
        }
    }
}
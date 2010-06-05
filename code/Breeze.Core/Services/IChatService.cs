namespace Breeze.Core.Services
{
    public interface IChatService
    {
        void SendMessage(string name, string message);

        /// <summary>
        /// Get all the messages (delta) since rowIndex
        /// </summary>
        /// <param name="rowIndex"></param>
        /// <returns></returns>
        MessagesDelta GetMessagesDelta(int rowIndex);
    }
}
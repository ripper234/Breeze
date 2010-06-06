namespace Breeze.Core.Services
{
    public interface IChatService
    {
        void SendMessage(int senderId, string senderName, string message);

        /// <summary>
        /// Get all the messages (delta) since rowIndex
        /// </summary>
        /// <param name="rowIndex"></param>
        /// <returns></returns>
        MessagesDelta GetMessagesDelta(int rowIndex);
    }
}
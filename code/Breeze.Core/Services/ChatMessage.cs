namespace Breeze.Core.Services
{
    public class ChatMessage
    {
        public string Text { get; private set; }
        public string SenderName { get; private set; }
        public int SenderId { get; private set; }

        public ChatMessage(int senderId, string senderName, string text)
        {
            SenderName = senderName;
            Text = text;
            SenderId = senderId;
        }
    }
}
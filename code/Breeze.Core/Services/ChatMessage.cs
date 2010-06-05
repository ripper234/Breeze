namespace Breeze.Core.Services
{
    public class ChatMessage
    {
        public string Text { get; private set; }
        public string Sender { get; private set; }

        public ChatMessage(string sender, string text)
        {
            Sender = sender;
            Text = text;
        }
    }
}
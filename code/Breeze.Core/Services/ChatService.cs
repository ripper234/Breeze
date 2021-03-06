using System.Collections.Generic;
using Breeze.Common.Extensions;

namespace Breeze.Core.Services
{
    public class ChatService : IChatService
    {
        private readonly List<ChatMessage> _messages = new List<ChatMessage>();
        private int _oldestRowIndex = 0;

        public void SendMessage(int senderId, string senderName, string text)
        {
            var message = new ChatMessage(senderId, senderName, text);
            lock (_messages)
                _messages.Add(message);
        }

        public MessagesDelta GetMessagesDelta(int rowIndex)
        {
            lock (_messages)
            {
                int startIndex;
                if (rowIndex > _oldestRowIndex)
                    startIndex = rowIndex - _oldestRowIndex;
                else
                    startIndex = 0;

                int endIndex = _messages.Count;
                List<ChatMessage> messages = _messages.SubList(startIndex, endIndex);
                return new MessagesDelta(messages, rowIndex + messages.Count, rowIndex);
            }
        }

    }
}
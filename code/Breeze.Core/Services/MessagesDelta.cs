using System.Collections.Generic;

namespace Breeze.Core.Services
{
    public class MessagesDelta
    {
        public MessagesDelta(List<ChatMessage> messages, int newRowIndex, int oldRowIndex)
        {
            Messages = messages;
            NewRowIndex = newRowIndex;
            OldRowIndex = oldRowIndex;
        }

        public int NewRowIndex {get; private set;}
        public int OldRowIndex { get; private set; }
        public List<ChatMessage> Messages { get; private set; }
    }
}
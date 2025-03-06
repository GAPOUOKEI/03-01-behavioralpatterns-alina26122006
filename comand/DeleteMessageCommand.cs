using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comand
{
    class DeleteMessageCommand : ICommand
    {
        private Chat chat;
        private int index;
        private string deletedMessage;

        public DeleteMessageCommand(Chat chat, int index)
        {
            this.chat = chat;
            this.index = index;
        }

        public void Execute()
        {
            if (index >= 0 && index < chat.MessageCount)
            {
                deletedMessage = chat.GetMessage(index);
                chat.DeleteMessage(index);
            }
        }

        public void Undo()
        {
            if (deletedMessage != null)
            {
                chat.SendMessageAt(index, deletedMessage);
            }
        }
    }
}

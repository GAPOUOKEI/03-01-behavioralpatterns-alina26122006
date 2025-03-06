using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comand
{
    class EditMessageCommand : ICommand
    {
        private Chat chat;
        private int index;
        private string oldMessage;
        private string newMessage;

        public EditMessageCommand(Chat chat, int index, string newMessage)
        {
            this.chat = chat;
            this.index = index;
            this.newMessage = newMessage;
        }

        public void Execute()
        {
            if (index >= 0 && index < chat.MessageCount)
            {
                oldMessage = chat.GetMessage(index);
                chat.EditMessage(index, newMessage);
            }
        }

        public void Undo()
        {
            chat.EditMessage(index, oldMessage);
        }
    }
}

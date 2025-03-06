using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comand
{
    class SendMessageCommand : ICommand
    {
        private Chat chat;
        private string message;

        public SendMessageCommand(Chat chat, string message)
        {
            this.chat = chat;
            this.message = message;
        }

        public void Execute()
        {
            chat.SendMessage(message);
        }

        public void Undo()
        {
            chat.DeleteMessage(chat.MessageCount - 1);
        }
    }
}

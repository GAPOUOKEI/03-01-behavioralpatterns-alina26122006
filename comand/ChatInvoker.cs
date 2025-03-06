using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comand
{
    class ChatInvoker
    {
        private Stack<ICommand> undoStack = new Stack<ICommand>();

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            undoStack.Push(command);
        }

        public void UndoLastCommand()
        {
            if (undoStack.Count > 0)
            {
                ICommand command = undoStack.Pop();
                command.Undo();
                Console.WriteLine("Отмена последнего действия.");
            }
            else
            {
                Console.WriteLine("Нет действий для отмены.");
            }
        }
    }
}

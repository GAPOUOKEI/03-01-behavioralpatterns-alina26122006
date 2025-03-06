using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comand
{
    using System;
    using System.Collections.Generic;

    class Chat
    {
        private List<string> messages = new List<string>();

        public void SendMessage(string message)
        {
            messages.Add(message);
            Console.WriteLine($"Сообщение отправлено: {message}");
        }

        public void EditMessage(int index, string newMessage)
        {
            if (index >= 0 && index < messages.Count)
            {
                Console.WriteLine($"Сообщение изменено: {messages[index]} -> {newMessage}");
                messages[index] = newMessage;
            }
            else
            {
                Console.WriteLine("Ошибка: сообщение не найдено.");
            }
        }

        public void DeleteMessage(int index)
        {
            if (index >= 0 && index < messages.Count)
            {
                Console.WriteLine($"Сообщение удалено: {messages[index]}");
                messages.RemoveAt(index);
            }
            else
            {
                Console.WriteLine("Ошибка: сообщение не найдено.");
            }
        }

        public int MessageCount => messages.Count;

        public string GetMessage(int index)
        {
            if (index >= 0 && index < messages.Count)
                return messages[index];
            return null;
        }

        public void SendMessageAt(int index, string message)
        {
            if (index >= 0 && index <= messages.Count)
            {
                messages.Insert(index, message);
                Console.WriteLine($"Сообщение восстановлено: {message}");
            }
        }

        public void ShowMessages()
        {
            Console.WriteLine("\n История сообщений:");
            for (int i = 0; i < messages.Count; i++)
            {
                Console.WriteLine($"[{i}] {messages[i]}");
            }
        }
    }
}


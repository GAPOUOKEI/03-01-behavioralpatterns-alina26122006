
/*Создайте консольное
или WPF приложение
для
чата,
поддерживающее
команды "Отправить
сообщение", "Удалить
сообщение"
и
"Редактировать
сообщение"
с
возможностью*/
namespace comand;

class Program
{
    static void Main()
    {
        Chat chat = new Chat();
        ChatInvoker invoker = new ChatInvoker();

        while (true)
        {
            Console.WriteLine("\nДоступные команды:");
            Console.WriteLine("1 - Отправить сообщение");
            Console.WriteLine("2 - Редактировать сообщение");
            Console.WriteLine("3 - Удалить сообщение");
            Console.WriteLine("4 - Отменить последнее действие");
            Console.WriteLine("5 - Показать историю сообщений");
            Console.WriteLine("0 - Выйти");

            Console.Write("\nВведите команду: ");
            string command = Console.ReadLine();

            switch (command)
            {
                case "1":
                    Console.Write("Введите сообщение: ");
                    string message = Console.ReadLine();
                    invoker.ExecuteCommand(new SendMessageCommand(chat, message));
                    break;

                case "2":
                    chat.ShowMessages();
                    Console.Write("Введите индекс сообщения для редактирования: ");
                    if (int.TryParse(Console.ReadLine(), out int editIndex))
                    {
                        Console.Write("Введите новое сообщение: ");
                        string newMessage = Console.ReadLine();
                        invoker.ExecuteCommand(new EditMessageCommand(chat, editIndex, newMessage));
                    }
                    break;

                case "3":
                    chat.ShowMessages();
                    Console.Write("Введите индекс сообщения для удаления: ");
                    if (int.TryParse(Console.ReadLine(), out int deleteIndex))
                    {
                        invoker.ExecuteCommand(new DeleteMessageCommand(chat, deleteIndex));
                    }
                    break;

                case "4":
                    invoker.UndoLastCommand();
                    break;

                case "5":
                    chat.ShowMessages();
                    break;

                case "0":
                    return;

                default:
                    Console.WriteLine("❌ Неверная команда.");
                    break;
            }
        }
    }
}
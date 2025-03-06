using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Создайте
менеджер
задач, где каждая
задача может иметь
состояния (новая, в
работе,
завершена,
отменена).
Логика
задачи изменяется в
зависимости от ее
состояния*/
namespace patternsostoinia
{
    class Program
    {
        static void Main()
        {
            Task task = new Task();

            // Попробуем изменить состояния задачи
            task.Start();    
            task.Complete(); // Завершаем задачу
            task.Cancel();   // Попытка отменить (не сработает, так как уже завершена)

            Console.WriteLine("\n--- Новая задача ---\n");

            Task task2 = new Task();
            task2.Cancel();  // Отменяем сразу
            task2.Start();   // Попытка запустить (не сработает, так как отменена)
        }
    }
}
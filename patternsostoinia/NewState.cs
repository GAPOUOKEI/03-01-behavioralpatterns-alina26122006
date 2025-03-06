using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternsostoinia
{
    class NewState : TaskState
    {
        public override void Start()
        {
            Console.WriteLine("Задача переведена в состояние 'В работе'.");
            task.SetState(new InProgressState());
        }

        public override void Complete()
        {
            Console.WriteLine("Нельзя завершить новую задачу. Сначала начните её.");
        }

        public override void Cancel()
        {
            Console.WriteLine("Задача отменена.");
            task.SetState(new CanceledState());
        }
    }
}

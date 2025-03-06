using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternsostoinia
{
    class InProgressState : TaskState
    {
        public override void Start()
        {
            Console.WriteLine("Задача уже в работе.");
        }

        public override void Complete()
        {
            Console.WriteLine("Задача завершена.");
            task.SetState(new CompletedState());
        }

        public override void Cancel()
        {
            Console.WriteLine("Задача отменена.");
            task.SetState(new CanceledState());
        }
    }
}

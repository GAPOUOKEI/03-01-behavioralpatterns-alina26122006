using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternsostoinia
{
    class CompletedState : TaskState
    {
        public override void Start()
        {
            Console.WriteLine("Нельзя начать заново завершённую задачу.");
        }

        public override void Complete()
        {
            Console.WriteLine("Задача уже завершена.");
        }

        public override void Cancel()
        {
            Console.WriteLine("Нельзя отменить завершённую задачу.");
        }
    }
}

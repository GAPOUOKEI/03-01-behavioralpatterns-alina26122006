using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternsostoinia
{
    class CanceledState : TaskState
    {
        public override void Start()
        {
            Console.WriteLine("Нельзя начать отменённую задачу.");
        }

        public override void Complete()
        {
            Console.WriteLine("Нельзя завершить отменённую задачу.");
        }

        public override void Cancel()
        {
            Console.WriteLine("Задача уже отменена.");
        }
    }
}

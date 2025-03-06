using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternsostoinia
{
    abstract class TaskState
    {
        protected Task task;

        public void SetTask(Task task)
        {
            this.task = task;
        }

        public abstract void Start();
        public abstract void Complete();
        public abstract void Cancel();
    }
}

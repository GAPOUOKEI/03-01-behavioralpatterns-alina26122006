using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace patternsostoinia
{
    class Task
    {
        private TaskState _state;

        public Task()
        {
            _state = new NewState();
            _state.SetTask(this);
        }

        public void SetState(TaskState state)
        {
            _state = state;
            _state.SetTask(this);
        }

        public void Start() => _state.Start();
        public void Complete() => _state.Complete();
        public void Cancel() => _state.Cancel();
    }
}

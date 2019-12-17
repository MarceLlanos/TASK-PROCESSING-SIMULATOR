using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class RoundRobin : IFactory
    {
        public T Create()
        {
            throw new NotImplementedException();
        }

        public bool VerifyNextExecute(ITask firstTask, ITask secondTask)
        {
            throw new NotImplementedException();
        }

    }
}

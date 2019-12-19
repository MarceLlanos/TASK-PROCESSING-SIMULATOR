using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class Adder : IAdder
    {
        public int Calculate(int valueExecuteQueue, int valueExecutedTask)
        {
            return valueExecuteQueue - valueExecutedTask;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class Procesor : IProcessor
    {
        IExecutor executor;
        public Procesor(IExecutor executor)
        {
            this.executor = executor;
        }

        public ITask Process(ITask[] tasks)
        public ITask Process(ITask[] tasks)
        {
            for (int i = 0; i < tasks.Length; )
            {
                if (executor.Execute())
                {
                    
                }
                else
                {
                    i++;
                }
            }
        }
    }
}

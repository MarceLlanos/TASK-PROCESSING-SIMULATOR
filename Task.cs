using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class Task : ITask
    {
        IDataTask dataTask;
        INInstructions n;
        IExecutor executor;

        public Task(IDataTask dataTask, INInstructions n, IExecutor executor)
        {
            this.dataTask = dataTask;
            this.n = n;
            this.executor = executor;
        }
        public int ActualNExecute(int actual)
        {
            return actual;
        }

        public int GetIdTask()
        {
            return dataTask.GetIdTask();
        }

        public int GetInstructionsTask()
        {
            return dataTask.GetInstructionsTask();
        }

        public int GetN()
        {
            return n.GetNInstructions();
        }

        public int GetPriorityTask()
        {
            return dataTask.GetPriorityTask();
        }
    }
}

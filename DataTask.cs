using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class DataTask: IDataTask
    {
        int idTask;
        int priorityTask;
        int instructionsTask;

        public DataTask( int idTask, int priorityTask, int instructionsTask)
        {
            this.idTask = idTask;
            this.priorityTask = priorityTask;
            this.instructionsTask = instructionsTask; 
        }

        public int GetIdTask()
        {
            return idTask;
        }

        public int GetInstructionsTask()
        {
            return priorityTask;
        }

        public int GetPriorityTask()
        {
            return instructionsTask;
        }
    }
}

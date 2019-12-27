using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class DataTask: IDataTask
    {
        int priorityTask;
        int instructionsTask;

        public DataTask( int priorityTask, int instructionsTask)
        {
            this.priorityTask = priorityTask;
            this.instructionsTask = instructionsTask; 
        }

        public int GetTaskInstructionsValue()
        {
            return instructionsTask;
        }

        public int GetTaskPriorityValue()
        {
            return priorityTask;
        }
    }
}

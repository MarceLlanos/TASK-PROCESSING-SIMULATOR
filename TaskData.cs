using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class TaskData: ITaskData
    {
        int priorityNumber;
        int instructionsNumber;

        public TaskData( int priorityNumber, int instructionsNumber)
        {
            this.priorityNumber = priorityNumber;
            this.instructionsNumber = instructionsNumber; 
        }

        public int GetTaskInstructionsValue()
        {
            return instructionsNumber;
        }

        public int GetTaskPriorityNumber()
        {
            return priorityNumber;
        }
    }
}

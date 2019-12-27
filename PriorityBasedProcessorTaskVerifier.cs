﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class PriorityBasedProcessorTaskVerifier : IProcessorTasksVerifier
    {
        public bool IsBestTaskToProcess(ITask firstTask, ITask secondTask)
        {
            var firstTaskPriorityValue = firstTask.GetDataTask().GetTaskPriorityValue();
            var secondTaskPriorityValue = secondTask.GetDataTask().GetTaskPriorityValue();

            return ( firstTaskPriorityValue < secondTaskPriorityValue);
        }
    }
}
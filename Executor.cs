﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class Executor : IExecutor
    {
        public int Execute(INInstructions nInstructions, ITask task)
        {
            if (task.GetInstructionsTask() - nInstructions.GetNInstructions() > 0)
            {
                return task.GetInstructionsTask() - nInstructions.GetNInstructions();
            }
            else
            {
                return (task.GetInstructionsTask() - nInstructions.GetNInstructions()) *-1;

            }

        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class Task : ITask
    {
        IDataTask dataTask;
        IDataQueue dataQueue;
        int executedInstruction;
        public Task(IDataTask dataTask, IDataQueue dataQueue)
        {
            this.dataTask = dataTask;
            this.dataQueue = dataQueue;
            executedInstruction = 0;
        }

        public int GetExecutedInstructions()
        {
            return executedInstruction;
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
            return dataQueue.GetNValue();
        }

        public int GetPriorityTask()
        {
            return dataTask.GetPriorityTask();
        }

        public void SetExecutedInstructions(int executedInstructions)
        {
            this.executedInstruction = executedInstructions;
        }

        public void Show()
        {

        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class InformationTaskDisplayer
    {
        public string NumberNDisplay()
        {
            Console.WriteLine("What is the value for N:");
            return Console.ReadLine();
        }

        public string ExecuteNumber()
        {
            Console.WriteLine("number of executions:");
            return Console.ReadLine();
        }

        public string InstructionsNumber()
        {
            Console.WriteLine("Add task's instructions");
            return Console.ReadLine();

        }

        public string PriorityNumber()
        {
            Console.WriteLine("Add task's priority:");
            return Console.ReadLine();
        }

        
    }
}

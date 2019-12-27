using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class Displayer : IDisplayer
    {
        public string AlgorithmMenuDisplay()
        {
            Console.WriteLine("Choose the Algorithm:");
            Console.WriteLine("1 = FIFO");
            Console.WriteLine("2 = Priority Based");
            Console.WriteLine("3 = Shortest Task First");
            Console.WriteLine("4 = Round Robin");
            Console.WriteLine("5 = Round Robin - Priority Based");
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

        public string NumberNDisplay()
        {
            Console.WriteLine("What is the value for N:");
            return Console.ReadLine();
        }

        public string PriorityNumber()
        {
            Console.WriteLine("Add task's priority:");
            return Console.ReadLine();
        }

        public string SettingMenuDisplay()
        {
            Console.WriteLine("ADD");
            Console.WriteLine("EXECUTE");
            Console.WriteLine("SHOW");
            Console.WriteLine("ESC");

            return Console.ReadLine();
        }
    }
}

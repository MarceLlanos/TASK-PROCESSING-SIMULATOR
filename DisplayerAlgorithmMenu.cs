using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class DisplayerAlgorithmMenu : IDisplayer
    {
        public string MenuDisplay()
        {
            Console.WriteLine("Choose the Algorithm:");
            Console.WriteLine("1 = FIFO");
            Console.WriteLine("2 = Priority Based");
            Console.WriteLine("3 = Shortest Task First");
            Console.WriteLine("4 = Round Robin");
            Console.WriteLine("5 = Round Robin - Priority Based");
            return Console.ReadLine();
        }

        
    }
}

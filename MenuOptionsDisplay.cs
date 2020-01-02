using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class MenuOptionsDisplay : IDisplayer
    {
        public string MenuDisplay()
        {
            Console.WriteLine("ADD");
            Console.WriteLine("EXECUTE");
            Console.WriteLine("SHOW");
            Console.WriteLine("ESC");

            return Console.ReadLine();
        }
    }
}

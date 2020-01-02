using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class NumericMenu : IMenuFactory<string>
    {
        public string CreateMenu(string option)
        {
            switch (option)
            {
                case "1":
                    return "FIFO";
                case "2":
                    return "Priority Based";
                case "3":
                    return "Shortest Task First";
                case "4":
                    return "Round Robin";
                case "5":
                    return "Round Robin - Priority Based";
                default:
                    return "FIFO";
            }
        }
    }
}

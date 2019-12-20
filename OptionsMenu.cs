using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class OptionsMenu : IOptionsMenu
    {
        public string MenuOption(string option)
        {
            switch (option)
            {
                case "1":
                    return "FIFO";
                case "2":
                    return "Priority Based";
                case "3":
                    return "Shortest Task First";
                default:
                    return "FIFO";
            }
        }
    }
}

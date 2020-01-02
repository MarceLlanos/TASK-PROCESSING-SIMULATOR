using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class EscWrittenAction : IReceiver
    {
        public bool Action(string option)
        {
            if (option == "ESC")
            {
                return false;
            }
            return true;
        }
    }
}

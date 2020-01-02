using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class OptionWrittenCommand : ICommand
    {
        IReceiver writtenRequest;

        public OptionWrittenCommand(IReceiver writtenRequest)
        {
            this.writtenRequest = writtenRequest;
        }

        public bool Execute(string option)
        {
            return writtenRequest.Action(option);
        }
    }
}

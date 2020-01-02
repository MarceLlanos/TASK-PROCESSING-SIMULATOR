using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class ControlOptions
    {
        ICommand[] writtenCommand;

        public ControlOptions()
        {
            writtenCommand = new OptionWrittenCommand[4];
        }

        public void SetMenuSelection(int index, ICommand writtenCommand)
        {
            this.writtenCommand[index] = writtenCommand; 
        }

        public bool OptionWasWritten(int index, string option)
        {
            return writtenCommand[index].Execute(option);
        }
    }
}

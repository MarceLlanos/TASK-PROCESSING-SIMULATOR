using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class NInstructions : INInstructions
    {
        int nInstructions;

        public NInstructions(int nInstructions)
        {
            this.nInstructions = nInstructions;
        }

        public int GetNInstructions()
        {
            return nInstructions;
        }
    }
}

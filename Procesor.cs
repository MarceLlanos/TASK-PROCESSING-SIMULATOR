using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class Procesor : IProcessor
    {
        public ITask Process(ITask[] tasks)
        {
            foreach (var item in tasks)
            {
                if (item.ActualNExecute()==0)
                {
                    return null;
                }
                if (true)
                {

                }
            }
            return null;
        }
    }
}

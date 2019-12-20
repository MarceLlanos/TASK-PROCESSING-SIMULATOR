using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class GeneratorId : IGenerateId
    {
        int idTask;

        public GeneratorId()
        {
            idTask = 0;
        }
        public int GenerateId()
        {
            return idTask +=1;
        } 
    }
}

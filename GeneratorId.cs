using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class GeneratorId : IGenerateId
    {
        int id;

        public GeneratorId(int id)
        {
            this.id = id;
        }
        public int GenerateId()
        {
            return id += 1;
        }
    }
}

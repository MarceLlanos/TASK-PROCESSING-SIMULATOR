using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class DirectorTasksFactory : IDirectorTasksFactory
    {
        public IDirectorTask CreateDirectorTasks(string algorithm, IQueueTask queueTask)
        {
            var optionPlanner = new OptionMenuFactory().OptionFactory(algorithm);

            return new DirectorTask(optionPlanner, queueTask);
        }
    }
}

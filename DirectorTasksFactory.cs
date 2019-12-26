using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class DirectorTasksFactory : IDirectorTasksFactory
    {
        public IDirectorTask CreateDirectorTasks(string algorithm)
        {
            var optionPlanner = new OptionMenuFactory().Option(algorithm);
            var processorTask = new ProcessorTask();
            var roundRobinProcessorTask = new RoundRobinProcessorTask();

            if (algorithm == "4")
            {
                return new DirectorTask(optionPlanner, roundRobinProcessorTask);
            }

            return new DirectorTask(optionPlanner, processorTask);
        }
    }
}

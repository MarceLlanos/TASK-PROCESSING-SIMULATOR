using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class DirectorTasksFactory : IDirectorFactory
    {
        public IDirector CreateDirectorTasks(string algorithm)
        {
            var optionPlanner = new OptionMenuFactory().CreateOption(algorithm);
            var processorTask = new ProcessorTask();
            var roundRobinProcessorTask = new RoundRobinProcessorTask();

            if (algorithm == "4")
            {
                return new Director(optionPlanner, roundRobinProcessorTask);
            }

            return new Director(optionPlanner, processorTask);
        }
    }
}

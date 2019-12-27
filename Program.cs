using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK_PROCESSING_SIMULATOR
{
    class Program
    {
        static void Main(string[] args)
        {
            bool notEsc = true;

            ITaskQueueFactory queueTaskFactory = new QueueTaskFactory();
            IDirectorFactory directorTaskFactory = new DirectorTasksFactory();
            ITaskFactory task = new TaskFactory(new GeneratorId());
            IDisplayer display = new Displayer();

            var algorithmMenu = display.AlgorithmMenuDisplay();
            var numberN = display.NumberNDisplay();

            IProcessorData dataQueue = new ProcessorData(int.Parse(numberN));
            var queueTask = queueTaskFactory.CreateQueueTaskFatory(int.Parse(numberN));
            var directorTask  = directorTaskFactory.CreateDirectorTasks(algorithmMenu);

            while (notEsc)
            {
                var option = display.SettingMenuDisplay();

                if (option == "ADD")
                {
                    var priorityNumber = display.PriorityNumber();
                    var instructionsNumber = display.InstructionsNumber();

                    task.CreateTask(int.Parse(priorityNumber), int.Parse(instructionsNumber), dataQueue);

                    notEsc = true;
                }

                if (option == "EXECUTE")
                {
                    var executionsNumber = display.ExecuteNumber();

                    dataQueue.SetNumberOfExecutions(int.Parse(executionsNumber));
                    directorTask.DigestProcess(dataQueue, queueTask);

                    notEsc = true;
                }

                if (option == "SHOW")
                {
                    Console.WriteLine("");
                    queueTask.ShowQueue();
                    Console.WriteLine("");
                    notEsc = true;
                }

                if (option == "ESC")
                {
                    notEsc = false;
                }
            }
            

            Console.ReadKey();

        }
    }
}

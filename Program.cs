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

            var queueTaskFactory = new QueueTaskFactory();
            var orchestratorFactory = new OrchestratorFactory();
            var task = new TaskFactory(new GeneratorId());
            var displayAlgorithmsMenu = new DisplayerAlgorithmMenu();
            var displayInformationTask = new InformationTaskDisplayer();
            var displayMenuOption = new MenuOptionsDisplay();
            var taskInformation = new TaskInformation(0, 0);
            var algorithmMenu = displayAlgorithmsMenu.MenuDisplay();
            var numberN = displayInformationTask.NumberNDisplay();

            var orchestraInformation = new OrchestraInformation(int.Parse(numberN));
            var queueTask = queueTaskFactory.CreateQueueTaskFatory(int.Parse(numberN));
            var directorTask  = orchestratorFactory.CreateOrchestra(algorithmMenu);
            
            var executeWrittenAction = new ExecuteWrittenAction(orchestraInformation, queueTask);
            var showWrittenAction = new ShowWrittenAction(queueTask);
            var escWrittenAction = new EscWrittenAction();

            var executeWrittenCommand = new OptionWrittenCommand(executeWrittenAction);
            var showWrittenCommand = new OptionWrittenCommand(showWrittenAction);
            var escWrittenCommand = new OptionWrittenCommand(escWrittenAction);

            var controlOptions = new ControlOptions();

            while (notEsc)
            {
                string option = displayMenuOption.MenuDisplay();

                if (option == "ADD")
                {
                    var priorityNumber = displayInformationTask.PriorityNumber();
                    var instructionsNumber = displayInformationTask.InstructionsNumber();

                    queueTask.AddTask(task.CreateTask(int.Parse(priorityNumber), int.Parse(instructionsNumber), orchestraInformation));

                    notEsc = true;
                }

                if (option == "EXECUTE")
                {
                    var executionsNumber = displayInformationTask.ExecuteNumber();

                    orchestraInformation.SetNumberOfExecutions(int.Parse(executionsNumber));
                    directorTask.DirectOrchestra(orchestraInformation, queueTask);

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

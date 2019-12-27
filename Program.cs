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
            IDirectorTasksFactory directorTaskFactory = new DirectorTasksFactory();
            ITaskFactory task = new TaskFactory(new GeneratorId());
            
            Console.WriteLine("Choose the Algorithm:");
            Console.WriteLine("1 = FIFO");
            Console.WriteLine("2 = Priority Based");
            Console.WriteLine("3 = Shortest Task First");
            Console.WriteLine("4 = Round Robin");
            Console.WriteLine("5 = Round Robin - Priority Based");
            string planner = Console.ReadLine();

            Console.WriteLine("What is the value for N:");
            string valueN = Console.ReadLine();

            IProcessorData dataQueue = new ProcessorData(int.Parse(valueN));

            var queueTask = queueTaskFactory.CreateTaskQueueFatory(int.Parse(valueN));

            var directorTask  = directorTaskFactory.CreateDirectorTasks(planner);

            while (notEsc)
            {
                Console.WriteLine("ADD");
                Console.WriteLine("EXECUTE");
                Console.WriteLine("SHOW");
                Console.WriteLine("ESC");

                string actionOption = Console.ReadLine();

                if (actionOption == "ADD")
                {
                    Console.WriteLine("Add task's priority:");
                    string priorityTask = Console.ReadLine();
                    Console.WriteLine("Add task's instructions");
                    string instructionsTask = Console.ReadLine();

                    Console.WriteLine("ADD {0} {1}", priorityTask, instructionsTask);

                    var newTask = task.CreateTask(int.Parse(priorityTask), int.Parse(instructionsTask), dataQueue);

                    if (queueTask.AddTask(newTask))
                    {
                        
                        Console.WriteLine("ADDED!");
                        Console.WriteLine("");
                    }
                    else
                    {
                        Console.WriteLine("FAIL TO ADDED");
                        Console.WriteLine("");

                    }

                    notEsc = true;
                }

                if (actionOption == "EXECUTE")
                {
                    Console.WriteLine("number of executions:");
                    string execute = Console.ReadLine();

                    Console.WriteLine("EXECUTE {0}", execute);
                    Console.WriteLine("");

                    dataQueue.SetNumberOfExecutions(int.Parse(execute));
                    directorTask.DigestProcess(dataQueue, queueTask);

                    notEsc = true;

                }

                if (actionOption == "SHOW")
                {
                    Console.WriteLine("");
                    queueTask.ShowQueue();
                    Console.WriteLine("");
                    notEsc = true;
                }

                if (actionOption == "ESC")
                {
                    notEsc = false;
                }
            }
            

            Console.ReadKey();

        }
    }
}

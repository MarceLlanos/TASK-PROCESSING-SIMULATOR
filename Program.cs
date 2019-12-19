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

            Console.WriteLine("Choose the Algorithm:");
            Console.WriteLine("1 = FIFO");
            Console.WriteLine("2 = Priority Based");
            Console.WriteLine("3 = Shortest Task First");
            Console.WriteLine("4 = Round Robin");
            Console.WriteLine("5 = Round Robin - Priority Based");
            string processor = Console.ReadLine();

            Console.WriteLine("What is the value for N:");
            string valueN = Console.ReadLine();
            Console.WriteLine(valueN);
            string execution = string.Empty;

            var dataQueue = new DataQueue(int.Parse(valueN), int.Parse(execution));

            var queueTask = new QueueTaskFactory().CreateQueueTaskFatory(processor, dataQueue);

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
                    var dataTask = new DataTask(int.Parse(priorityTask), int.Parse(instructionsTask));
                    var task = new TaskFactory().Create(dataTask, dataQueue);

                    notEsc = true;

                }

                if (actionOption == "EXECUTE")
                {
                    Console.WriteLine("number of executions:");
                    execution = Console.ReadLine();

                    Console.WriteLine("EXECUTE {0}", execution);

                    dataQueue.SetExecuteValue(int.Parse(execution));
                    notEsc = true;

                }

                if (actionOption == "SHOW")
                {
                    notEsc = true;
                    queueTask.ShowQueue();
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

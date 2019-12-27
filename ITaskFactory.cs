namespace TASK_PROCESSING_SIMULATOR
{
    internal interface ITaskFactory
    {
        ITask CreateTask(int priority, int instructions, IProcessorData dataQueue);

    }
}
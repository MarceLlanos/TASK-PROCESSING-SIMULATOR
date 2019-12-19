namespace TASK_PROCESSING_SIMULATOR
{
    internal interface ITaskFactory
    {
        ITask Create(IDataTask dataTask, IDataQueue dataQueue);

    }
}
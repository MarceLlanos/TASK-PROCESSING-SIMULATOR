namespace TASK_PROCESSING_SIMULATOR
{
    public interface IQueueTaskFactory
    {
        IQueueTask CreateQueueTaskFatory(string plannerSort, IDataQueue dataQueue);

    }
}
namespace TASK_PROCESSING_SIMULATOR
{
    public interface ITaskFactory
    {
        ITask CreateTask(int priority, int instructions, IOrchestraInformation orchestraInformation);

    }
}
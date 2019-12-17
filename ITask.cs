namespace TASK_PROCESSING_SIMULATOR
{
    public interface ITask
    {
        int GetIdTask();
        int GetPriorityTask();
        int GetInstructionsTask();
        int GetN();
        int ActualNExecute(int actual);
    }
}
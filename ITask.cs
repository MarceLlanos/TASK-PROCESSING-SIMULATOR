namespace TASK_PROCESSING_SIMULATOR
{
    public interface ITask
    {
        ITaskInformation GetTaskData();
        int GetPendingInstructions();
        int GetId();
        void SetExecutedInstructions(int executedInstructions);
        void Show();
        void ExecuteTaskLimitedByN(int instructionsToExecute);
        IOrchestraInformation GetOrchestraInformation();
        void ExecuteTask(int minInstructionsToExecute);
        bool IsTaskCompleteExecuted();
        int GetExecutedInstructions();
    }
}
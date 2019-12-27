namespace TASK_PROCESSING_SIMULATOR
{
    public interface ITask
    {
        IDataTask GetDataTask();
        int GetPendingInstructions();
        int GetId();
        void SetExecutedInstructions(int executedInstructions);
        void Show();
        void ExecuteTaskLimitedByN(int instructionsToExecute);
        IDataQueue GetDataQueueTask();
        void ExecuteTask(int minInstructionsToExecute);
        bool IsTaskCompletedExecuted();
        int GetExecutedInstructions();
    }
}
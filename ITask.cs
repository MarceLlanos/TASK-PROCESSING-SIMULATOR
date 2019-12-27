namespace TASK_PROCESSING_SIMULATOR
{
    public interface ITask
    {
        ITaskData GetTaskData();
        int GetPendingInstructions();
        int GetId();
        void SetExecutedInstructions(int executedInstructions);
        void Show();
        void ExecuteTaskLimitedByN(int instructionsToExecute);
        IProcessorData GetProcessorData();
        void ExecuteTask(int minInstructionsToExecute);
        bool IsTaskCompletedExecuted();
        int GetExecutedInstructions();
    }
}
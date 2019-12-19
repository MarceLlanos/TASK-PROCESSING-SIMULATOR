namespace TASK_PROCESSING_SIMULATOR
{
    public interface ITask
    {
        int GetIdTask();
        int GetPriorityTask();
        int GetInstructionsTask();
        int GetN();
        int GetExecutedInstructions();
        void SetExecutedInstructions(int executedInstructions);
        void Show();
        IDataQueue GetDataQueueTask();
    }
}
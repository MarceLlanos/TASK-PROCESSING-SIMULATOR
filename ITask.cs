namespace TASK_PROCESSING_SIMULATOR
{
    public interface ITask
    {
        IGenerateId GetIdTask();
        int GetPriorityTask();
        int GetInstructionsTask();
        int GetN();
        int GetExecutedInstructions();
        void SetExecutedInstructions(int executedInstructions);
        void Show();
        IDataQueue GetDataQueueTask();
    }
}
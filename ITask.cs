namespace TASK_PROCESSING_SIMULATOR
{
    public interface ITask
    {
        IDataTask GetDataTask();
        int GetExecutedInstructions();
        int GetId();
        void SetId(int id);
        void SetExecutedInstructions(int executedInstructions);
        void Show();
        IDataQueue GetDataQueueTask();
    }
}
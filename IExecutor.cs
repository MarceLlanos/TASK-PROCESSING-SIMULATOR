namespace TASK_PROCESSING_SIMULATOR
{
    internal interface IExecutor
    {
        int Execute(INInstructions nInstructions, ITask task);
    }
}
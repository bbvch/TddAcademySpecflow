namespace TddAcademy
{
    public interface ITaskDisdpatcher
    {
        string GetTask();

        void FinishedTask(string task);
    }
}
namespace Project_Euler_Tasks.Interfaces
{
    public interface ITask
    {
        int TaskID { get; }
        ITask ShowInfo();
        void Run();
    }


}

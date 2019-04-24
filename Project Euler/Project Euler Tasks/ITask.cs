namespace Project_Euler_Tasks
{
    public interface ITask
    {
        int TaskID { get; }
        ITask ShowInfo();
        void Run();
    }


}


namespace DynamicBinding
{
    class Program
    {
        static void Main(string[] args)
        {
            object obj = "aledx";

            var methodInfo = obj.GetType().GetMethod("GetHashCode");
            methodInfo.Invoke(null, null);

            dynamic lol = "bob";
            lol.Hi();
        }
    }
}

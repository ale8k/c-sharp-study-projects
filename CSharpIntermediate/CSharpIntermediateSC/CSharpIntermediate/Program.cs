namespace CSharpIntermediate
{

    class Program
    {
        static void Main(string[] args)
        {
            HttpCookie cookie = new HttpCookie();
            cookie["name"] = "Alex";
            cookie["test"] = "my test";
            cookie.test["lol"] = "test";
            System.Console.WriteLine(cookie["test"] + cookie.test["lol"] + cookie.test.Count);
            System.Console.ReadLine();

        }
    }
}

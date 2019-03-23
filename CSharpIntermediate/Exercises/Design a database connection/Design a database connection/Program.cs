namespace Design_a_database_connection
{
    class Program
    {
        static void Main(string[] args)
        {
            DbCommand sql = new DbCommand(new SqlConnection("idk lol"));
            sql.Execute();
            DbCommand oracle = new DbCommand(new OracleConnection("oracle?"));
            oracle.Execute();
            System.Console.ReadLine();
        }
    }
}

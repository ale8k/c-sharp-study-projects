using System;

namespace Design_a_database_connection
{
    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
            Console.WriteLine("Validating...");
        }

        public override void OpenDbConnection()
        {
            Console.WriteLine("Opening oracle connection");
        }

        public override void CloseDbConnection()
        {
            Console.WriteLine("Closing oracle connection");
        }
    }
}



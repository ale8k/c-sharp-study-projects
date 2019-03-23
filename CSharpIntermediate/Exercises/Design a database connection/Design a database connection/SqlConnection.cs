using System;

namespace Design_a_database_connection
{
    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
            Console.WriteLine("Validating...");
        }

        public override void OpenDbConnection()
        {
            Console.WriteLine("Opening SQL connection");
        }

        public override void CloseDbConnection()
        {
            Console.WriteLine("Closing SQL connection");
        }

    }
}



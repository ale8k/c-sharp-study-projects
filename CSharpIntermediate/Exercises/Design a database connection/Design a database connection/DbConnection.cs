using System;

namespace Design_a_database_connection
{
    public class DbConnection
    {

        private string _connectionString;
        private TimeSpan timeout;

        public DbConnection(string connectionString)
        {
            _connectionString = ConnectionStringValidator(connectionString);
        }

        private string ConnectionStringValidator(string connString)
        {
            if (connString is null || connString.Length == 0)
                throw new ArgumentException("Connection string cannot be null or empty");
            else
                return connString;
        }
    }
}

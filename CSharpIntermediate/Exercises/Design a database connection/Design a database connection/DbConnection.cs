using System;

namespace Design_a_database_connection
{
    public abstract class DbConnection
    {

        private TimeSpan timeout;

        public DbConnection(string connectionString)
        {
            ConnectionStringValidator(connectionString);
        }

        private void ConnectionStringValidator(string connString)
        {
            if (connString is null || connString.Length == 0)
                throw new ArgumentException("Connection string cannot be null or empty");
        }

        public abstract void OpenDbConnection();
        public abstract void CloseDbConnection();
    }
}



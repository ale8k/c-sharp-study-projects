using System;

namespace Design_a_database_connection
{
    public class DbCommand
    {

        private DbConnection _dbConnection; // is Oracle or SQL
        private string _instruction;

        public DbCommand(DbConnection dbConnection)
        {
            _dbConnection = CheckForNull(dbConnection);
            if (dbConnection as SqlConnection != null)
            {
                _instruction = "T-SQL";
            }
            else if (dbConnection as OracleConnection != null)
            {
                _instruction = "Oracle";
            }
        }

        private DbConnection CheckForNull(DbConnection dbConnection)
        {
            if (dbConnection is null)
                throw new ArgumentException("DbConnection cannot be null");
            else
                return dbConnection;
        }

        public void Execute()
        {
            _dbConnection.OpenDbConnection();
            Console.WriteLine($"Running {_instruction} db connection");
            _dbConnection.CloseDbConnection();
        }

    }
}



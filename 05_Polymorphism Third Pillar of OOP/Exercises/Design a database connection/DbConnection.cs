using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DatabaseConnection
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            if (Timeout > TimeSpan.FromMilliseconds(180))
            {
                throw new TimeoutException("The connection timed out");
            }

            else if (connectionString != null)
            {
                this.ConnectionString = connectionString;
            }
            else
            {
                throw new NullReferenceException("Connection string cannot be null.");
            }
        }

        public abstract void OpenConnection();

        public abstract void CloseConnection();
    }

    public class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString)
            : base(connectionString)
        {
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Opening connection to SQL server");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Closing connection to SQL server");
        }
    }

    public class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString)
            : base(connectionString)
        {
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Opening connection to Oracle database");
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Closing connection to Oracle database");
        }
    }
}

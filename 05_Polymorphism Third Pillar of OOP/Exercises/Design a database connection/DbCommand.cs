using System;
using System.Collections.Generic;
using System.Text;

namespace DatabaseConnection
{
    public class DbCommand
    {
        public string Instruction { get; set; }
        private readonly DbConnection _dbConnection;

        public DbCommand(DbConnection dbConnection, string instruction)
        {
            if (dbConnection != null)
            {
                _dbConnection = dbConnection;
            }
            else
            {
                throw new NullReferenceException("Cannot be null.");
            }

            if (String.IsNullOrWhiteSpace(instruction))
            {
                throw new ArgumentException("Instructions cannot be null or empty.");
            }
            else
            {
                this.Instruction = instruction;
            }
        }

        public void Execute()
        {
            _dbConnection.OpenConnection();
            Console.WriteLine(Instruction);
            _dbConnection.CloseConnection();
        }

    }
}

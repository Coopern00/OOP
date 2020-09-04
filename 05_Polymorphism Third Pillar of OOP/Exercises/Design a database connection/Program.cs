using System;

namespace DatabaseConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbcommandSql = new DbCommand(new SqlConnection("sql connection"), "sql test");
            dbcommandSql.Execute();

            Console.WriteLine();

            var dbcommandOracle = new DbCommand(new OracleConnection("oracle connection"), "oracle test");
            dbcommandOracle.Execute();
        }
    }
}

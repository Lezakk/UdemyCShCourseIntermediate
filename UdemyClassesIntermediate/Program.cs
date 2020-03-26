using System;

namespace UdemyClassesIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection sqlConnection = new SqlConnection("Path");
            OracleConnection oracleConnection = new OracleConnection("Path");

            DatabaseCommand databaseCommandSql = new DatabaseCommand(sqlConnection, "PUT");
            DatabaseCommand databaseCommandOracle = new DatabaseCommand(oracleConnection, "DELETE");
            databaseCommandSql.Execute();
            databaseCommandOracle.Execute();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace UdemyClassesIntermediate
{
    public abstract class DatabaseConnection
    {
        private string _connectionString;

        public string ConnectionString
        {
            get { return ConnectionString; }
            set 
            {
                if (String.IsNullOrEmpty(value)) throw new ArgumentNullException("Wrong format");
                _connectionString = value;
            }
        }

        protected TimeSpan Duration;

        protected DatabaseConnection(string ConnectionString)
        {
            this.ConnectionString = ConnectionString;
        }

        public abstract void OpenConnection();
        public abstract void CloseConnection();
    }

    public class SqlConnection : DatabaseConnection
    {
        public SqlConnection(string ConnectionString) : base(ConnectionString)
        {

        }

        public override void OpenConnection()
        {
           Console.WriteLine("Open connection with SQL Server");
        }
        public override void CloseConnection()
        {
            Console.WriteLine("Close connection with SQL Server");
        }
    }
    public class OracleConnection : DatabaseConnection
    {
        public OracleConnection(string ConnectionString) : base(ConnectionString)
        {

        }

        public override void OpenConnection()
        {
            Console.WriteLine("Open connection with Oracle Server");
        }
        public override void CloseConnection()
        {
            Console.WriteLine("Close connection with Oracle Server");
        }
    }

    public class DatabaseCommand
    {
        private string _instruction;
        private DatabaseConnection _DBC;

        public string Instruction
        {
            get { return _instruction; }
            set
            {
                if (String.IsNullOrEmpty(value)) throw new ArgumentNullException("Wrong format");
                _instruction = value; 
            }
        }

        public DatabaseConnection DBC
        {
            get { return _DBC; }  
            set 
            { 
                if(value == null) throw new ArgumentNullException("Wrong format");
                _DBC = value;
            }
        }

        public DatabaseCommand(DatabaseConnection DBC, string instruction)
        {
            this._DBC = DBC;
            this._instruction = instruction;
        }

        public void Execute()
        {
            _DBC.OpenConnection();
            Console.WriteLine("Instructions: {0}", _instruction);
            _DBC.CloseConnection();
        }
    }
}

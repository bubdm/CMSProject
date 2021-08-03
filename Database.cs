using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace CMSProject
{
    public class Database
    {
        private string _host;
        private string _database;
        private string _username;
        private string _password;
        private string _connString;

        private MySqlConnection conn;
        //private static Database _instance = null;

        public Database(string theHost, string theDatabase, string theUsername, string thePassword)
        {
            this._host = theHost;
            this._database = theDatabase;
            this._username = theUsername;
            this._password = thePassword;
        }

        /*public static Database Instance()
        {
            if (_instance == null)
            {
                _instance = new Database();
            }

            return _instance;
        }*/

        private bool OpenConnection()
        {
            this._connString = String.Format("server={0};uid={1};pwd={2};database={3};", _host, _username, _password, _database);
            this.conn = new MySqlConnection(_connString);

            try
            {
                Console.WriteLine("Attempting connection to MySQL..");
                conn.Open();
                Console.WriteLine("CONNECTION SUCCESSFUL");
                return true;
            }
            catch (MySqlException e)
            {
                Console.WriteLine("CONNECTION FAILED: ");
                Console.WriteLine(e.Message);
                return false;
            }
        }

        private void CloseConnection()
        {
            try
            {
                conn.Close();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void Execute(string sql)
        {
            try
            {
                OpenConnection();
                
                Console.WriteLine("Executing query...");

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

                Console.WriteLine("Query executed successfully!");
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            CloseConnection();
        }

        public DataTable Select(string sql)
        {
            try
            {
                OpenConnection();

                Console.WriteLine("Executing query...");

                MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);
                DataTable result = new DataTable();

                adapter.Fill(result);

                CloseConnection();

                return result;
            }

            catch (Exception e)
            {
                Console.WriteLine($"ERROR: {e.Message}");

                CloseConnection();

                return null;
            }
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestController
{
    public class DBManager
    {
        private static DBManager dbManager;
        private MySqlConnection con;
        private const String host = "pruebadb.c5s044w8ei2l.us-east-1.rds.amazonaws.com";
        private const String port = "3306";
        private const String db = "prueba";
        private const String username = "admin";
        private const String password = "12345678";

        private DBManager() { }

        public MySqlConnection Connection
        {
            get
            {
                if (con == null)
                {
                    string cadenaConexion = $"server={host};database={db};user={username};password={password};port={port}";
                    con = new MySqlConnection(cadenaConexion);
                }
                con.Open();
                return con;
            }
        }

        public static DBManager Instance {
            get { 
                if (dbManager == null)
                    dbManager = new DBManager();
                return dbManager; 
            }
        }
    }
}

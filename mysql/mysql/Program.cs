using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace mysql
{
    class Program
    {
        static void Main(string[] args)
        {
            string constr = "User Id=root;Host=localhost;Database=test;password=123456";
            MySqlConnection conn = new MySqlConnection(constr);
            conn.Open();
            conn.Close();

        }
    }
}

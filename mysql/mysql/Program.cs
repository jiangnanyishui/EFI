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
            string constr = "User Id=root;Host=localhost;Database=world;password=123456";
            MySqlConnection conn = new MySqlConnection(constr);
            conn.Open();
            MySqlCommand mycm = new MySqlCommand("select * from city", conn);
            MySqlDataReader mysdr = mycm.ExecuteReader();
            Console.ReadKey();
            conn.Close();

        }
    }
}

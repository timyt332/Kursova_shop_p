using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursovoi
{
    public static class Bd
    {
        static string connectionString = "server=localhost;port=3308;username=root;password=2726011013;database=plumbers_shop;";
        public static string get_st() {  return connectionString; }
        public static void in_datable(string queryString, DataTable dataTable) 
        {
            using (MySqlConnection connection = new MySqlConnection(Bd.get_st()))
            {
                using (MySqlCommand command = new MySqlCommand(queryString, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
        }
    }
}

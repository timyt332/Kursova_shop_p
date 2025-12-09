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
        public static void add_tovar(string name, int cat, int kraina, decimal price, int kil)
        {
            int i = 0;
            using (MySqlConnection connection = new MySqlConnection(Bd.get_st()))
            {
                connection.Open();
                string queryString = "call add_tovar(@name,@cat,@kraina,@price,@Kilkist);";

                using (MySqlCommand command = new MySqlCommand(queryString, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@cat", cat);
                    command.Parameters.AddWithValue("@kraina", kraina);
                    command.Parameters.AddWithValue("@price", price);
                    command.Parameters.AddWithValue("@Kilkist", kil);

                    i = command.ExecuteNonQuery();

                }
            }
        }
        public static void add_postachalnik(string name, string cat, string kraina, string price, string kil)
        {
            int i = 0;
            using (MySqlConnection connection = new MySqlConnection(Bd.get_st()))
            {
                connection.Open();
                string queryString = "call add_postachalnik(@name,@cat,@kraina,@price,@Kilkist);";

                using (MySqlCommand command = new MySqlCommand(queryString, connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@cat", cat);
                    command.Parameters.AddWithValue("@kraina", kraina);
                    command.Parameters.AddWithValue("@price", price);
                    command.Parameters.AddWithValue("@Kilkist", kil);

                    i = command.ExecuteNonQuery();

                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace kursovoi
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            string queryString = "SELECT * FROM plumber_shop.tovare";

            DataTable dataTable = new DataTable();

            
            using (MySqlConnection connection = new MySqlConnection(Bd.get_st()))
            {
                using (MySqlCommand command = new MySqlCommand(queryString, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                        dataGridView1.DataSource = dataTable;
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Получаем первую выделенную строку
                var selectedRow = dataGridView1.SelectedRows[0].Cells[0].Value;
                MessageBox.Show(selectedRow.ToString());
                Product a = new Product(Int32.Parse(selectedRow.ToString()));
                cor.Products.Add(a);
                
            }
            else { Console.WriteLine("AAAAAAAAAAAAAAa"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = cor.Products;
            //foreach p in cor.Products
        }
    }
}

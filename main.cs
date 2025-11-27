using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace kursovoi
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            string queryString = "SELECT * FROM tovar";

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
                var selectedRow = dataGridView1.SelectedRows[0];
                //MessageBox.Show(selectedRow.ToString());
                Product a = new Product(selectedRow.Cells[0].Value.ToString(), (int)kilkist_t.Value, decimal.Parse( selectedRow.Cells[1].Value.ToString()));
                cor.Products.Add(a);
                
            }
            else { Console.WriteLine("AAAAAAAAAAAAAAa"); }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {

            // Создаем список объектов
            /*List<Product> people = new List<Product>
            {
                new Product ("1", 3,  30 ),
                new Product ("23",2,  25 ),
                new Product ( "131ds",1, 35 )
            };*/
            
            // Связываем DataGridView с источником данных
            dataGridView2.DataSource = cor.Products;
            Console.WriteLine("12313");
            //dataGridView2.DataSource = cor.Products;
            //foreach p in cor.Products
        }
    }
}

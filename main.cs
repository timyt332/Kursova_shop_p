using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
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
                if ((int)kilkist_t.Value < Int32.Parse(dataGridView1.SelectedRows[0].Cells[4].Value.ToString()))
                { 
                    var selectedRow = dataGridView1.SelectedRows[0];
                    //MessageBox.Show(selectedRow.ToString());
                    Product a = new Product(selectedRow.Cells[0].Value.ToString(), (int)kilkist_t.Value, decimal.Parse( selectedRow.Cells[1].Value.ToString()));
                    cor.Products.Add(a);
                }
                else { MessageBox.Show("Кількість повинна бути менша "+ dataGridView1.SelectedRows[0].Cells[4].Value.ToString()); }
            }
            else { Console.WriteLine("Нічого не виділено"); }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = cor.Products;
            decimal summa = 0;
            foreach (var Product in cor.Products)
            {
                summa=Product.price* Product.quantity;
            }
            label1.Text = "Загальна ціна:"+ summa.ToString();
        }
    }
}

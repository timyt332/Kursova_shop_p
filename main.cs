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
        string bez_fil = "Усі";
        public main()
        {
            InitializeComponent();
            
        }
        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Console.WriteLine("6. FormClosing - форма закривається");

            // Можливість скасувати закриття
            DialogResult result = MessageBox.Show(
                "Ви впевнені, що хочете закрити форму?",
                "Підтвердження",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true; // Скасувати закриття
            }
        }

        
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if ((int)kilkist_t.Value <= Int32.Parse(dataGridView1.SelectedRows[0].Cells[4].Value.ToString()))
                { 

                    var selectedRow = dataGridView1.SelectedRows[0];
                    //MessageBox.Show(selectedRow.ToString());
                    Product a = new Product(selectedRow.Cells[0].Value.ToString(), (int)kilkist_t.Value, decimal.Parse( selectedRow.Cells[1].Value.ToString()));
                    cor.Products.Add(a);
                }
                else { MessageBox.Show("Кількість повинна бути менша "+ dataGridView1.SelectedRows[0].Cells[4].Value.ToString()); }
            }
            else { Console.WriteLine("Нічого не виділено"); }
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = cor.Products;
            decimal summa = 0;
            foreach (var Product in cor.Products)
            {
                summa += Product.price * Product.quantity;
            }
            label1.Text = "Загальна ціна:" + summa.ToString() + " (грн)";
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = cor.Products;
            decimal summa = 0;
            foreach (var Product in cor.Products)
            {
                summa+=Product.price* Product.quantity;
            }
            label1.Text = "Загальна ціна:"+ summa.ToString()+ " (грн)";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            int i = 0;
            using (MySqlConnection connection = new MySqlConnection(Bd.get_st()))
            {
                connection.Open();
                string queryString = "call add_prodag(@CustomerID);";

                    using (MySqlCommand command = new MySqlCommand(queryString, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerID", cor.id);
                    
                        i =command.ExecuteNonQuery();

                    }
                    string queryString2 = "call add_prodag_list(@n,@k);";
                foreach (var Product in cor.Products)
                {
                    using (MySqlCommand command = new MySqlCommand(queryString2, connection))
                    {
                        
                        command.Parameters.AddWithValue("@n", Product.name);
                        command.Parameters.AddWithValue("@k", Product.quantity);
                        i =command.ExecuteNonQuery();
                    }
                }
                cor.Products.Clear();
                dataGridView2.DataSource = null;
                dataGridView2.DataSource = cor.Products;
                label1.Text = "Загальна ціна:" ;
                dataGridView1.DataSource = null;
                string queryString4 = "SELECT * FROM tovar";

                DataTable dataTable1 = new DataTable();


                using (MySqlConnection connection2 = new MySqlConnection(Bd.get_st()))
                {
                    using (MySqlCommand command = new MySqlCommand(queryString4, connection2))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable1);
                            dataGridView1.DataSource = dataTable1;
                        }
                    }
                }

            }
        }
        private void filt_g1()
        {
            string p = $" AND ";
            string kat = $"Категорія Like '%{box_kat.Text}%'";
            string fil = $"Назва Like '%{text_serch.Text}%'";
            if (box_kat.Text.ToString() != bez_fil)
                fil += p + kat;
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = fil;
        }
        private void text_serch_TextChanged(object sender, EventArgs e)
        {
            filt_g1();
        }

        private void main_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Form1.Close();
        }

        private void box_kat_SelectedIndexChanged(object sender, EventArgs e)
        {
            filt_g1();
        }

        private void main_Load(object sender, EventArgs e)
        {
            string queryString = "SELECT * FROM tovar";

            DataTable dataTable = new DataTable();
            Bd.in_datable(queryString, dataTable);
            dataGridView1.DataSource = dataTable;
                    
                        
            string queryString2 = "SELECT * FROM kategoria";

            DataTable dataTable2 = new DataTable();

            box_kat.Items.Add(bez_fil);
            using (MySqlConnection connection = new MySqlConnection(Bd.get_st()))
            {
                using (MySqlCommand command = new MySqlCommand(queryString2, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable2);
                        foreach (DataRow row in dataTable2.Rows)
                        box_kat.Items.Add(row[1].ToString());
                    }
                }
            }
            
            box_kat.SelectedIndex = 0;
        }
    }
}

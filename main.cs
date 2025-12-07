using MySql.Data.MySqlClient;
using Mysqlx.Resultset;
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
        private void main_Load(object sender, EventArgs e)
        {
            dataupdate1();
            dataupdate2();

            string queryString = "SELECT * FROM kategoria";
            DataTable dataTable2 = new DataTable();
            Bd.in_datable(queryString, dataTable2);
            box_kat.Items.Add(bez_fil);
            foreach (DataRow row in dataTable2.Rows) box_kat.Items.Add(row[1].ToString());
            box_kat.SelectedIndex = 0;

            queryString = "SELECT * FROM centures";
            DataTable dataTable3 = new DataTable();
            Bd.in_datable(queryString, dataTable3);
            box_kra.Items.Add(bez_fil);
            foreach (DataRow row in dataTable3.Rows) box_kra.Items.Add(row[1].ToString());
            box_kra.SelectedIndex = 0;

            queryString = "SELECT concat(\"Посада: \",s_pos,\"     Робітник: \",s_fnam,\" \",s_nam,\" \",s_mnam) FROM spivrobitnik where s_id=@id";

            DataTable dataTable4 = new DataTable();


            using (MySqlConnection connection = new MySqlConnection(Bd.get_st()))
            {
                using (MySqlCommand command = new MySqlCommand(queryString, connection))
                {
                    command.Parameters.AddWithValue("@id", cor.id);
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable4);
                    }
                }

            }
            label_spiv.Text = dataTable4.Rows[0][0].ToString();


        }
        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Можливість скасувати закриття
            DialogResult result = MessageBox.Show(
                "Ви впевнені, що хочете вийти?",
                "Підтвердження",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.No)
            {
                e.Cancel = true; // Скасувати закриття
            }
        }
        public void dataupdate1()
        {
            string queryString = "SELECT * FROM tovares";
            DataTable dataTable = new DataTable();
            Bd.in_datable(queryString, dataTable);
            dataGridView1.DataSource = dataTable;
            //dataGridView1.Columns["t_nam"].HeaderText = "Назва";
            dataGridView1.Columns["t_cost"].HeaderText = "Ціна";
            dataGridView1.Columns["t_kilkist"].HeaderText = "Кількість";
            dataGridView1.Columns["t_id"].Visible=false;
            dataGridView1.Columns["t_vik"].Visible = false;/*
            dataGridView1.Columns["c_id"].HeaderText = "Країна";
            dataGridView1.Columns["k_id"].HeaderText = "Категорія";
            //*/
        }
        public void dataupdate2()
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = cor.Products;
            dataGridView2.Columns["kilkist"].HeaderText = "Кількість";
            dataGridView2.Columns["Name"].HeaderText = "Назва";
            dataGridView2.Columns["Price"].HeaderText = "Ціна";
            dataGridView2.Columns["Summa"].HeaderText = "Сума";
            dataGridView2.Columns["id"].Visible = false;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if ((int)kilkist_t.Value <= Int32.Parse(dataGridView1.SelectedRows[0].Cells["t_kilkist"].Value.ToString()))
                { 

                    var selectedRow = dataGridView1.SelectedRows[0];
                    int idT = Int32.Parse(selectedRow.Cells["t_id"].Value.ToString());
                    foreach (var Product in cor.Products)
                    {
                        if (Product.id == idT) { MessageBox.Show("Цей товар вже був доданий"); return ; }
                    }
                    Tovare a = new Tovare(idT, selectedRow.Cells["Назва"].Value.ToString(), decimal.Parse( selectedRow.Cells["t_cost"].Value.ToString()), (int)kilkist_t.Value);
                    cor.Products.Add(a);
                }
                else { MessageBox.Show("Кількість повинна бути менша "+ dataGridView1.SelectedRows[0].Cells["t_kilkist"].Value.ToString()); }
                decimal summa = 0;
                foreach (var Product in cor.Products)
                {
                    summa += Product.price * Product.kilkist;
                }
                label1.Text = "Загальна ціна:" + summa.ToString() + " (грн)";
                kilkist_t.Value = 1;
                dataupdate2();
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
                summa+=Product.price* Product.kilkist;
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
                        command.Parameters.AddWithValue("@k", Product.kilkist);
                        i =command.ExecuteNonQuery();
                    }
                }
                cor.Products.Clear();
                dataupdate1();
                dataupdate2();

            }
        }
        private void filt_g1()
        {
            int storinka_roz = 50;
            string p = $" AND ";
            string s = $" t_id > {((int)pag_n.Value-1) * storinka_roz} AND t_id <= {(int)pag_n.Value* storinka_roz}";
            string kat = $"Категорія Like '%{box_kat.Text}%'";
            string fil = $"Назва Like '%{text_serch.Text}%'";
            //fil += p + s;
            string kra = $"Країна Like '%{box_kra.Text}%'";
            if (box_kat.Text.ToString() != bez_fil)
                fil += p + kat;
            if (box_kra.Text.ToString() != bez_fil)
                fil += p + kra;
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = fil;
        }
        private void text_serch_TextChanged(object sender, EventArgs e)
        {
            filt_g1();
        }

        private void box_kat_SelectedIndexChanged(object sender, EventArgs e)
        {
            filt_g1();
        }

        

        private void box_kra_SelectedIndexChanged(object sender, EventArgs e)
        {
            filt_g1();
        }

        private void button_fil_Click(object sender, EventArgs e)
        {
            box_kat.SelectedIndex = 0;
            box_kra.SelectedIndex = 0;
            text_serch.Text = "";
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = "";
        }

        private void pag_n_ValueChanged(object sender, EventArgs e)
        {
            filt_g1(); 
            
        }

        private void but_ad_post_Click(object sender, EventArgs e)
        {
            string name = "";
            using (Postach form = new Postach())
            {
                
                if (form.ShowDialog() == DialogResult.OK)
                {
                        name = form.get_n().ToString();
                    using (Postachanna form1 = new Postachanna())
                    {
                        form1.post(name);
                        form1.ShowDialog();
                    }
                }

            }
        }
    }
}

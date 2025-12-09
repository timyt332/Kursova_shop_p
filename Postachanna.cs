using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursovoi
{
    public partial class Postachanna : Form
    {
        int postid=0;
        string bez_fil = "Усі";
        public Postachanna()
        {
            InitializeComponent();
        }
        public void post(string a) { label5.Text = "Постачальник: "+a; }
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
                        if (Product.id == idT) { MessageBox.Show("Цей товар вже був доданий"); return; }
                    }
                    Tovare a = new Tovare(idT, selectedRow.Cells["Назва"].Value.ToString(), (decimal)price_z.Value, (int)kilkist_t.Value);
                    cor.Products.Add(a);
                }
                else { MessageBox.Show("Кількість повинна бути менша " + dataGridView1.SelectedRows[0].Cells["t_kilkist"].Value.ToString()); }
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

        private void Postachanna_Load(object sender, EventArgs e)
        {
            cor.Products.Clear();
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
            cor.Products.Clear();
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
            dataGridView1.Columns["t_id"].Visible = false;
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

        private void button3_Click(object sender, EventArgs e)
        {
            //DataTable dataTable = new DataTable();
            int i = 0;
            if (postid == 0)
            {
                using (Postach f = new Postach()) { if (f.ShowDialog() == DialogResult.OK) postid = f.get_id(); else { return; } }
            } 
            using (MySqlConnection connection = new MySqlConnection(Bd.get_st()))
            {
                connection.Open();
                string queryString = "call add_nakladna(@CustomerID,@PostId);";

                using (MySqlCommand command = new MySqlCommand(queryString, connection))
                {
                    command.Parameters.AddWithValue("@CustomerID", cor.id);
                    command.Parameters.AddWithValue("@PostId", postid);
                    i = command.ExecuteNonQuery();

                }
                string queryString2 = "call add_post_list(@n,@k,@p);";
                foreach (var Product in cor.Products)
                {
                    using (MySqlCommand command = new MySqlCommand(queryString2, connection))
                    {

                        command.Parameters.AddWithValue("@n", Product.name);
                        command.Parameters.AddWithValue("@k", Product.kilkist);
                        command.Parameters.AddWithValue("@p", Product.price);
                        i = command.ExecuteNonQuery();
                    }
                }
                cor.Products.Clear();
                dataupdate1();
                dataupdate2();
                postid = 0;
            }
        }

        private void Postachanna_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(cor.Products.Count > 0) 
            { 
                DialogResult result = MessageBox.Show(
                    "Ви впевнені, що хочете вийти?" +
                    "\nВ вас залишилисася незакрита накладна!",
                    "Підтвердження",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    e.Cancel = true; // Скасувати закриття
                }
            }
            postid = 0;
            cor.Products.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (add_post add = new add_post())
            { if (add.ShowDialog() == DialogResult.OK) postid = add.id_post(); }
        }
    }
}

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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kursovoi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string queryString = "SELECT * FROM plumber_shop.spivrobitnik";

            DataTable dataTable = new DataTable();


            using (MySqlConnection connection = new MySqlConnection(Bd.get_st()))
            {
                using (MySqlCommand command = new MySqlCommand(queryString, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                        listcor.DataSource = dataTable;
                        listcor.DisplayMember = "s_pos";
                        listcor.ValueMember = "s_id";
                    }
                }
            }
        }

        private void buttonvhid_Click(object sender, EventArgs e)
        {

            if (parol.Text != "")
            {
                string queryString = "SELECT * FROM plumber_shop.spivrobitnik where s_id=@id";

                DataTable dataTable = new DataTable();


                using (MySqlConnection connection = new MySqlConnection(Bd.get_st()))
                {
                    using (MySqlCommand command = new MySqlCommand(queryString, connection))
                    {
                        command.Parameters.Add("@id",MySqlDbType.UInt32).Value = Int32.Parse((listcor.SelectedValue.ToString()));
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            adapter.Fill(dataTable);
                        }
                    }
                }
                
                if (parol.Text == dataTable.Rows[0][5].ToString())
                {
                    MessageBox.Show(listcor.SelectedValue.ToString());
                    cor.id = Int32.Parse((listcor.SelectedValue.ToString()));
                    main myForm = new main();
                    myForm.Show();
                    this.Hide();
                }
                else { MessageBox.Show("Невірний пароль"); }
            }
            else { MessageBox.Show("Введіть пароль"); }
        }
    }
}

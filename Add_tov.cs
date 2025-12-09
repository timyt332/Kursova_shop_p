using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace kursovoi
{
    public partial class Add_tov : Form
    {
        public Add_tov()
        {
            InitializeComponent();
        }
        private void Add_tov_Load(object sender, EventArgs e)
        {
            string queryString = "SELECT * FROM kategoria";
            DataTable dataTable = new DataTable();
            Bd.in_datable(queryString, dataTable);
            box_kat.DataSource = dataTable;
            box_kat.DisplayMember = "k_nam";
            box_kat.ValueMember = "k_id";
            queryString = "SELECT * FROM centures";
            DataTable dataTable2 = new DataTable();
            Bd.in_datable(queryString, dataTable2);
            box_kra.DataSource = dataTable2;
            box_kra.DisplayMember = "c_nam";
            box_kra.ValueMember = "c_id";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Bd.add_tovar(name.Text, Int32.Parse((box_kat.SelectedValue.ToString())), Int32.Parse((box_kra.SelectedValue.ToString())), (decimal)price_z.Value, (int)kilkist_t.Value);
            MessageBox.Show("Товар доданий");
        }
    }
}

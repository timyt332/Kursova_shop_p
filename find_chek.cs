using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace kursovoi
{
    public partial class find_chek : Form
    {
        public find_chek()
        {
            InitializeComponent();
        }
        private void find_chek_Load(object sender, EventArgs e)
        {
            string queryString = "SELECT * FROM prodagis";
            DataTable dataTable = new DataTable();
            Bd.in_datable(queryString, dataTable);
            dataGridView1.DataSource = dataTable;
            rButV.Checked = true;
            date1.Hide();
            date2.Hide(); 
            int w;
            int nc;

            nc = dataGridView1.Columns.Count;

            if (nc > 0)
            {
                w = dataGridView1.Columns[0].Width;
                MessageBox.Show(w.ToString());
            }
        }

        private void posh_dat(DateTime datS,DateTime datE) 
        {

            string queryString = "SELECT * FROM prodagis where `Дата`  >= @StartDate AND `Дата` < @EndDate";

            DataTable dataTable = new DataTable();
            using (MySqlConnection connection = new MySqlConnection(Bd.get_st()))
            {
                using (MySqlCommand command = new MySqlCommand(queryString, connection))
                {
                    command.Parameters.AddWithValue("@StartDate", datS);
                    command.Parameters.AddWithValue("@EndDate", datE);
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                    }
                }
            }
            dataGridView1.DataSource = dataTable;
        }
        private void rbut_d(object sender, EventArgs e)
        {
            if (rButDay.Checked)
            {
                date1.Show();
                date2.Hide();
            }
            else if (rButPr.Checked)
            {
                date1.Show();
                date2.Show();
            }
            else if (rButV.Checked)
            {
                date1.Hide();
                date2.Hide();
            }
        }
        private void data_p(object sender, DateRangeEventArgs e) 
        {
            if (rButDay.Checked) 
            { 
                string d = date1.SelectionStart.ToString();
                DateTime datS;
                DateTime datE ;
                datS = date1.SelectionStart;
                datE = date1.SelectionStart.AddDays(1);
                posh_dat(datS, datE);
            }
            else if (rButPr.Checked) 
            {
                string d = date1.SelectionStart.ToString();
                DateTime datS;
                DateTime datE;
                if (date1.SelectionStart < date2.SelectionStart)
                {
                    datS = date1.SelectionStart;
                    datE = date2.SelectionStart.AddDays(1);
                }
                else
                {
                    datE = date1.SelectionStart.AddDays(1);
                    datS = date2.SelectionStart;
                }
                posh_dat(datS, datE);
            }
            else if (rButV.Checked) 
            {
                string queryString = "SELECT * FROM prodagis";
                DataTable dataTable = new DataTable();
                Bd.in_datable(queryString, dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }
    }
}

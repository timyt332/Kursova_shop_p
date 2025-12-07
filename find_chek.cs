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
    public partial class find_chek : Form
    {
        public find_chek()
        {
            InitializeComponent();
        }

        private void rButDay_CheckedChanged(object sender, EventArgs e)
        {
            //data_p();
            filt_g1();
        }
        private void data_p() 
        {
            if (rButDay.Checked) 
            { 
                MessageBox.Show("Один");
                string d = date1.SelectionStart.ToString();
                string queryString = "SELECT * FROM prodagis where \"Дата\" < "+d;

                DataTable dataTable = new DataTable();
                Bd.in_datable(queryString, dataTable);
                dataGridView1.DataSource = dataTable;
            }
        }
        private void filt_g1()
        {
            string fil = $"Data <{date1.SelectionStart.ToString()}";
            try 
            { 
                (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = fil;
            }
            else(Exception ex){ MessageBox.Show(date1.SelectionStart.ToString()+"    ",ex)}
        }
        private void find_chek_Load(object sender, EventArgs e)
        {
            string queryString = "SELECT * FROM prodagis";
            DataTable dataTable = new DataTable();
            Bd.in_datable(queryString, dataTable);
            dataGridView1.DataSource = dataTable;
        }
    }
}

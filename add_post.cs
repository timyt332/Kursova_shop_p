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
    public partial class add_post : Form
    {
        public add_post()
        {
            InitializeComponent();
        }
        public int id_post() 
        {
            string queryString = "Select p_id from postachalnik order by p_id desc limite 1";
            DataTable dataTable = new DataTable();
            Bd.in_datable(queryString, dataTable);
            return Int32.Parse(dataTable.Rows[0][0].ToString());
        }
        private void add_postacalnik_Click(object sender, EventArgs e)
        {
            Bd.add_postachalnik(name.Text, fone.Text, rahunok.Text,edr.Text, adres.Text);
            MessageBox.Show("Постачальник доданий");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

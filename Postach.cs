using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kursovoi
{
    public partial class Postach : Form
    {
        string name = "";
        int id;
        public string get_n() { return name; }
        public int get_id() { return id; }
        public Postach()
        {
            InitializeComponent();
        }
        public void dataupdate1()
        {
            string queryString = "SELECT * FROM postachalniki";
            DataTable dataTable = new DataTable();
            Bd.in_datable(queryString, dataTable);
            dataGridView1.DataSource = dataTable;
            //*/
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                name = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                id= Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                this.DialogResult = DialogResult.OK;
                this.Close();

            }
            else { Console.WriteLine("Нічого не виділено"); }
            
        }

        private void Postach_Load(object sender, EventArgs e)
        {
            dataupdate1();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Close();
        }

        private void text_serch_TextChanged(object sender, EventArgs e)
        {
            string fil = $"Назва Like '%{text_serch.Text}%'";
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = fil;
        }
    }
}

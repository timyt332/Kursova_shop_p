using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace kursovoi
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            string queryString = "SELECT * FROM plumber_shop.tovar";

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
                // Получаем первую выделенную строку
                var selectedRow = dataGridView1.SelectedRows[0];

                // Создаем новую строку в dataGridView2
                dataGridView2.Rows.Add(selectedRow);

                // Переносим данные из выделенной строки в новую строку
                for (int i = 0; i < selectedRow.Cells.Count; i++)
                {
                    dataGridView2.Rows[dataGridView2.Rows.Count - 1].Cells[i].Value = selectedRow.Cells[i].Value;
                }
                // Опционально: удалить строку из исходной таблицы
                // dataGridView1.Rows.Remove(selectedRow);
            }
            else { Console.WriteLine("AAAAAAAAAAAAAAa"); }
        }
    }
}

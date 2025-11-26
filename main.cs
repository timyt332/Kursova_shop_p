using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace kursovoi
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
            string queryString = "SELECT * FROM tovare";

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
        }/*
        public static string HashPassword(string password)
        {
            byte[] salt;
            byte[] buffer2;
            if (password == null)
            {
                throw new ArgumentNullException("password");
            }
            using (Rfc2898DeriveBytes bytes = new Rfc2898DeriveBytes(password, 0x10, 0x3e8))
            {
                salt = bytes.Salt;
                buffer2 = bytes.GetBytes(0x20);
            }
            byte[] dst = new byte[0x31];
            Buffer.BlockCopy(salt, 0, dst, 1, 0x10);
            Buffer.BlockCopy(buffer2, 0, dst, 0x11, 0x20);
            return Convert.ToBase64String(dst);
        }
        public static bool VerifyHashedPassword(string hashedPassword, string password)
        {
            byte[] buffer4;
            if (hashedPassword == null)
            {
                return false;
            }
            if (password == null)
            {
                throw new ArgumentNullException("password");
            }
            byte[] src = Convert.FromBase64String(hashedPassword);
            if ((src.Length != 0x31) || (src[0] != 0))
            {
                return false;
            }
            byte[] dst = new byte[0x10];
            Buffer.BlockCopy(src, 1, dst, 0, 0x10);
            byte[] buffer3 = new byte[0x20];
            Buffer.BlockCopy(src, 0x11, buffer3, 0, 0x20);
            using (Rfc2898DeriveBytes bytes = new Rfc2898DeriveBytes(password, dst, 0x3e8))
            {
                buffer4 = bytes.GetBytes(0x20);
            }
            return buffer3.SequenceEqual( buffer4);
             //true;return buffer3.ByteArraysEqual( buffer4);
        }/*
        internal static class Program
        {
            static void Main()
            {
                string p = 123;
                string h_p;
                h_p = HashPassword(p);
                //MessageBox.Show(h_p);
                Console.WriteLine(h_p);
                if (VerifyHashedPassword(h_p, p))
                {
                    //MessageBox.Show("Вірно");
                    Console.WriteLine("AAAAAAAAAAAAAAa");
                }
                else
                {//MessageBox.Show("НЕ");
                    Console.WriteLine("/");
                }
            }
        }*/
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Получаем первую выделенную строку
                var selectedRow = dataGridView1.SelectedRows[0].Cells[0].Value;
                MessageBox.Show(selectedRow.ToString());
                Product a = new Product(Int32.Parse(selectedRow.ToString()));
                cor.Products.Add(a);
                
            }
            else { Console.WriteLine("AAAAAAAAAAAAAAa"); }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = cor.Products;
            //foreach p in cor.Products
        }
    }
}

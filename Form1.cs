using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
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
            string queryString = "SELECT s_id, concat(s_pos,\" \",s_fnam,\" \",s_nam,\" \",s_mnam) as s_spiv FROM spivrobitnik;";

            DataTable dataTable = new DataTable();


            using (MySqlConnection connection = new MySqlConnection(Bd.get_st()))
            {
                using (MySqlCommand command = new MySqlCommand(queryString, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                        listcor.DataSource = dataTable;
                        listcor.DisplayMember = "s_spiv";
                        listcor.ValueMember = "s_id";
                    }
                }
            }
        }
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
            return buffer3.SequenceEqual(buffer4);
            //true;return buffer3.ByteArraysEqual( buffer4);
        }
        private void buttonvhid_Click(object sender, EventArgs e)
        {

            if (parol.Text != "")
            {
                string queryString = "SELECT * FROM spivrobitnik where s_id=@id";

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
                if (VerifyHashedPassword( dataTable.Rows[0][7].ToString(),parol.Text))
                {
                    //MessageBox.Show(listcor.SelectedValue.ToString());
                    cor.id = Int32.Parse((listcor.SelectedValue.ToString()));
                    this.Hide();
                }
                else { MessageBox.Show("Невірний пароль ");
                    Console.WriteLine(dataTable.Rows[0][7].ToString());
                    Console.WriteLine(HashPassword(parol.Text));
                }
            }
            else { Console.WriteLine("Введіть пароль"); }
        }
    }
}

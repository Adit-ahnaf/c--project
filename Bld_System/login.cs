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

namespace Bld_System
{
    public partial class login : Form
    {

        MySqlConnection connection = new MySqlConnection("server=localhost;database=bloodmanagement;port=3306;username=root;password=123456");

        MySqlDataAdapter adapter;

        DataTable table = new DataTable();


        public static string e_mail;
        private void button1_Click(object sender, EventArgs e)

        {
            if (String.IsNullOrEmpty(email.Text) || String.IsNullOrEmpty(p_assword.Text))
            {
                MessageBox.Show("Please fill up all fields ");
            }
            else
            {
                e_mail = email.Text;
                adapter = new MySqlDataAdapter("SELECT `email`, `password` FROM `donor` WHERE `email` = '" + email.Text + "' AND `password` = '" + p_assword.Text + "'", connection);
                adapter.Fill(table);
                if (table.Rows.Count <= 0)
                {
                    MessageBox.Show("username or password invalid ");

                }
                else
                {
                    MessageBox.Show("Login successfull");
                    Option o = new Option();
                    o.Show();
                    this.Hide();

                }
                table.Clear();

            }
        }

        public login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
           
           
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}

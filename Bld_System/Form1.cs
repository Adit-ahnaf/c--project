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
    public partial class Form1 : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;database=bloodmanagement;port=3306;username=root;password=123456");
        public Form1()
        {
            InitializeComponent();
        }

    
        

        private void button2_Click(object sender, EventArgs e)

        {

            if (String.IsNullOrEmpty(n_ame.Text) || String.IsNullOrEmpty(a_dress.Text) || String.IsNullOrEmpty(b_loodgroup.Text) || String.IsNullOrEmpty(p_hone.Text) || String.IsNullOrEmpty(regemail.Text) || String.IsNullOrEmpty(regpassword.Text))
            {
                MessageBox.Show("Please fill up all fields");
            }
            else
            { 

            string insertQuery = "INSERT INTO bloodmanagement.donor(name,adress,bloodgroup,phone,email,password) VALUES('" + n_ame.Text + "','" + a_dress.Text + "','" + b_loodgroup.Text + "','" + p_hone.Text + "','" + regemail.Text + "','" + regpassword.Text + "')";
                connection.Open();
                MySqlCommand command = new MySqlCommand(insertQuery, connection);

           
                try
                {
                    if (command.ExecuteNonQuery() == 1)
                    {
                        MessageBox.Show("Data Inserted");
                    }
                    else
                    {
                        MessageBox.Show("Data Not Inserted");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                connection.Close();

                login l = new login();
                l.Show();
                this.Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Bld_System
{
    public partial class Option : Form
    {
        public Option()
        {
            InitializeComponent();
        }

        private void donateblood_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Your data have been stored will be contacted for further activities");
        }

        private void requestblood_Click(object sender, EventArgs e)
        {
            Donordata d = new Donordata();
            d.Show();
            this.Hide();
        }


        private void Option_Load(object sender, EventArgs e)
        {
            login l = new login();
           
           MySqlConnection connection = new MySqlConnection("server=localhost;database=bloodmanagement;port=3306;username=root;password=123456");
            string query = "SELECT name,adress,bloodgroup,phone,email FROM bloodmanagement.donor WHERE email='" +login.e_mail+ "'";
            MySqlDataAdapter rd = new MySqlDataAdapter(query, connection);
            DataTable d = new DataTable();
            rd.Fill(d);
            name.Text = d.Rows[0]["name"].ToString();
            adress.Text = d.Rows[0]["adress"].ToString();
            bloodgroup.Text = d.Rows[0]["bloodgroup"].ToString();
            phone.Text = d.Rows[0]["phone"].ToString();
            email.Text = d.Rows[0]["email"].ToString();

        }

        private void update_Click(object sender, EventArgs e)
        {
            MySqlConnection connection = new MySqlConnection("server=localhost;database=bloodmanagement;port=3306;username=root;password=123456");
          
              MySqlCommand  cmd = new MySqlCommand("update donor set name=@name,adress=@adress,bloodgroup=@bloodgroup,phone=@phone,email=@email where email=@email", connection);
                connection.Open();
                cmd.Parameters.AddWithValue("@name", name.Text);
                cmd.Parameters.AddWithValue("@adress", adress.Text);
                cmd.Parameters.AddWithValue("@bloodgroup", bloodgroup.Text);
                cmd.Parameters.AddWithValue("@phone", phone.Text);
                cmd.Parameters.AddWithValue("@email", email.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Updated Successfully");
                connection.Close();
                Option o = new Option();
                o.Hide();
               
           
        }


        
        
    }
}

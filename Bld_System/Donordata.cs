using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Bld_System
{
    public partial class Donordata : Form
    {
        MySqlConnection connection = new MySqlConnection("server=localhost;database=bloodmanagement;port=3306;username=root;password=12345");
        MySqlCommand command;
        MySqlDataReader mdr;
        public Donordata()
        {
            InitializeComponent();
        }
        private void search_Click(object sender, EventArgs e)
        {
           MySqlConnection connection = new MySqlConnection("server=localhost;database=bloodmanagement;port=3306;username=root;password=123456");
           string query = "SELECT name,adress,bloodgroup,phone FROM bloodmanagement.donor WHERE bloodgroup='"+searchbloodgroup.Text+"'";
            connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, connection);
            MySqlDataAdapter adr = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adr.Fill(dt);
            dataGridView1.DataSource = dt;
            connection.Close();
            
        }
        
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                name.Text = row.Cells["name"].Value.ToString();
                adress.Text = row.Cells["adress"].Value.ToString();
                bloodgroup.Text = row.Cells["bloodgroup"].Value.ToString();
                phone.Text = row.Cells["phone"].Value.ToString();


            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for your response ");
            login l = new login();
            l.Show();
            this.Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace Wholesale_System
{
    public partial class cart : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\admin\Documents\wholesaledb.mdf;Integrated Security=True;Connect Timeout=30");
        
        public cart()
        {

            InitializeComponent();
            
        }

        private void cart_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home x = new Home();
            this.Hide();
            x.Show();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select product,price,id from tblCart where id = 9", connection);
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {

                label2.Text = da.GetValue(0).ToString();
                label3.Text = da.GetValue(1).ToString();
            }
            connection.Close();

        }

        private void category_Panel_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void panel6_Paint(object sender, PaintEventArgs e)
        {

            connection.Open();
            SqlCommand cmd = new SqlCommand("Select product,price,id from tblCart where id = 10", connection);
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {

                label14.Text = da.GetValue(0).ToString();
                label13.Text = da.GetValue(1).ToString();
            }
            connection.Close();

        
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cart_Load(object sender, EventArgs e)
        {
            
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select product,price,id from tblCart where id = 11", connection);
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {

                label17.Text = da.GetValue(0).ToString();
                label16.Text = da.GetValue(1).ToString();
            }
            connection.Close();

        }
    }
}

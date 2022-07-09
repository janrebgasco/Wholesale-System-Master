using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Wholesale_System
{
    public partial class Seller : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\admin\Documents\wholesaledb.mdf;Integrated Security=True;Connect Timeout=30");

        public Seller()
        {
            InitializeComponent();
        }
        public void display_data()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [tblAdminAdd]";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
            dataadp.Fill(dta);
            dataGridView1.DataSource = dta;
            connection.Close();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Seller_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            display_data();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update [tblAdminAdd] set Price = '" + textBox4.Text + "' where Product= '" + textBox3.Text + "'";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "update [tblAdminAdd] set Stocks = '" + textBox6.Text + "' where Product= '" + textBox3.Text + "'";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "update [tblAdminAdd] set Description = '" + textBox7.Text + "' where Product= '" + textBox3.Text + "'";
            cmd.ExecuteNonQuery();
            connection.Close();
            textBox3.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            display_data();
            MessageBox.Show("Data Updated Successfully");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from [tblAdminAdd] where Product = '" + textBox3.Text + "'";
            cmd.ExecuteNonQuery();
            connection.Close();
            textBox3.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            display_data();
            MessageBox.Show("Data Deleted Successfully");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] images = null;
            FileStream Stream = new FileStream(imgLocation,FileMode.Open,FileAccess.Read);
            BinaryReader brs = new BinaryReader(Stream);
            images = brs.ReadBytes((int)Stream.Length);

            connection.Open();
            string sqlQuery ="insert into[tblAdminAdd] (Product,Price,Stocks,Description,Image) values('" + textBox3.Text + "','" + textBox4.Text + "','" + textBox6.Text + "','" + textBox7.Text + "',@image)";
            cmd =new SqlCommand(sqlQuery,connection);
            cmd.Parameters.Add(new SqlParameter("@image", images));
            int n = cmd.ExecuteNonQuery();
            connection.Close();
            textBox3.Text = "";
            textBox4.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            display_data();
            MessageBox.Show("Data Inserted Successfully");

            
        }


        
        

        private void Seller_Load(object sender, EventArgs e)
        {
            display_data();
        }
        string imgLocation = "";
        SqlCommand cmd;
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pictureBox3.ImageLocation = imgLocation;
            }
        }
    }
}

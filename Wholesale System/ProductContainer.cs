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
    public partial class ProductContainer : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\admin\Documents\wholesaledb.mdf;Integrated Security=True;Connect Timeout=30");

        public ProductContainer()
        {
            InitializeComponent();
        }

        private void Form5_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home x = new Home();
            x.Show();
            this.Hide();
        }

        private void catergory1_Click(object sender, EventArgs e)
        {
            category_Panel.Show();
        }

        private void category2_Click(object sender, EventArgs e)
        {
            category_Panel.Hide();
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select product,price,image from tblAdminAdd where id = 2", connection);
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                Byte[] byteBLOBData = new Byte[2];
                byteBLOBData = (Byte[])((byte[])da["image"]);
                System.IO.MemoryStream ms = new System.IO.MemoryStream(byteBLOBData);
                pictureBox20.Image = System.Drawing.Image.FromStream(ms);
                label27.Text = da.GetValue(0).ToString();
                label28.Text = da.GetValue(1).ToString();
            }
            connection.Close();
        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select product,price,image from tblAdminAdd where id = 3", connection);
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                Byte[] byteBLOBData = new Byte[2];
                byteBLOBData = (Byte[])((byte[])da["image"]);
                System.IO.MemoryStream ms = new System.IO.MemoryStream(byteBLOBData);
                pictureBox13.Image = System.Drawing.Image.FromStream(ms);
                label11.Text = da.GetValue(0).ToString();
                label12.Text = da.GetValue(1).ToString();
            }
            connection.Close();
        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select product,price,image from tblAdminAdd where id = 4", connection);
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                Byte[] byteBLOBData = new Byte[2];
                byteBLOBData = (Byte[])((byte[])da["image"]);
                System.IO.MemoryStream ms = new System.IO.MemoryStream(byteBLOBData);
                pictureBox16.Image = System.Drawing.Image.FromStream(ms);
                label17.Text = da.GetValue(0).ToString();
                label18.Text = da.GetValue(1).ToString();
            }
            connection.Close();
        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select product,price,image from tblAdminAdd where id = 5", connection);
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                Byte[] byteBLOBData = new Byte[2];
                byteBLOBData = (Byte[])((byte[])da["image"]);
                System.IO.MemoryStream ms = new System.IO.MemoryStream(byteBLOBData);
                pictureBox19.Image = System.Drawing.Image.FromStream(ms);
                label23.Text = da.GetValue(0).ToString();
                label24.Text = da.GetValue(1).ToString();
            }
            connection.Close();
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select product,price,image from tblAdminAdd where id = 6", connection);
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                Byte[] byteBLOBData = new Byte[2];
                byteBLOBData = (Byte[])((byte[])da["image"]);
                System.IO.MemoryStream ms = new System.IO.MemoryStream(byteBLOBData);
                pictureBox2.Image = System.Drawing.Image.FromStream(ms);
                label2.Text = da.GetValue(0).ToString();
                label3.Text = da.GetValue(1).ToString();
            }
            connection.Close();
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select product,price,image from tblAdminAdd where id = 7", connection);
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                Byte[] byteBLOBData = new Byte[2];
                byteBLOBData = (Byte[])((byte[])da["image"]);
                System.IO.MemoryStream ms = new System.IO.MemoryStream(byteBLOBData);
                pictureBox12.Image = System.Drawing.Image.FromStream(ms);
                label9.Text = da.GetValue(0).ToString();
                label10.Text = da.GetValue(1).ToString();
            }
            connection.Close();
        }

        private void panel11_Paint(object sender, PaintEventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select product,price,image from tblAdminAdd where id = 8", connection);
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                Byte[] byteBLOBData = new Byte[2];
                byteBLOBData = (Byte[])((byte[])da["image"]);
                System.IO.MemoryStream ms = new System.IO.MemoryStream(byteBLOBData);
                pictureBox15.Image = System.Drawing.Image.FromStream(ms);
                label15.Text = da.GetValue(0).ToString();
                label16.Text = da.GetValue(1).ToString();
            }
            connection.Close();
        }

        private void pictureBox20_Click(object sender, EventArgs e)
        {
            this.Hide();
            dataContainer nextpage = new dataContainer(3);
            nextpage.ShowDialog();
        }

        private void label27_Click(object sender, EventArgs e)
        {
            this.Hide();
            dataContainer nextpage = new dataContainer(3);
            nextpage.ShowDialog();
        }

        private void label28_Click(object sender, EventArgs e)
        {
            this.Hide();
            dataContainer nextpage = new dataContainer(3);
            nextpage.ShowDialog();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            this.Hide();
            dataContainer nextpage = new dataContainer(4);
            nextpage.ShowDialog();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            this.Hide();
            dataContainer nextpage = new dataContainer(4);
            nextpage.ShowDialog();
        }

        private void label12_Click(object sender, EventArgs e)
        {
            this.Hide();
            dataContainer nextpage = new dataContainer(4);
            nextpage.ShowDialog();
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            this.Hide();
            dataContainer nextpage = new dataContainer(5);
            nextpage.ShowDialog();
        }

        private void label17_Click(object sender, EventArgs e)
        {
            this.Hide();
            dataContainer nextpage = new dataContainer(5);
            nextpage.ShowDialog();
        }

        private void label18_Click(object sender, EventArgs e)
        {
            this.Hide();
            dataContainer nextpage = new dataContainer(5);
            nextpage.ShowDialog();
        }

        private void pictureBox19_Click(object sender, EventArgs e)
        {
            this.Hide();
            dataContainer nextpage = new dataContainer(6);
            nextpage.ShowDialog();
        }

        private void label23_Click(object sender, EventArgs e)
        {
            this.Hide();
            dataContainer nextpage = new dataContainer(6);
            nextpage.ShowDialog();
        }

        private void label24_Click(object sender, EventArgs e)
        {
            this.Hide();
            dataContainer nextpage = new dataContainer(6);
            nextpage.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            dataContainer nextpage = new dataContainer(7);
            nextpage.ShowDialog();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Hide();
            dataContainer nextpage = new dataContainer(7);
            nextpage.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Hide();
            dataContainer nextpage = new dataContainer(7);
            nextpage.ShowDialog();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            this.Hide();
            dataContainer nextpage = new dataContainer(8);
            nextpage.ShowDialog();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            this.Hide();
            dataContainer nextpage = new dataContainer(8);
            nextpage.ShowDialog();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Hide();
            dataContainer nextpage = new dataContainer(8);
            nextpage.ShowDialog();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            this.Hide();
            dataContainer nextpage = new dataContainer(9);
            nextpage.ShowDialog();
        }

        private void label15_Click(object sender, EventArgs e)
        {
            this.Hide();
            dataContainer nextpage = new dataContainer(9);
            nextpage.ShowDialog();
        }

        private void label16_Click(object sender, EventArgs e)
        {
            this.Hide();
            dataContainer nextpage = new dataContainer(9);
            nextpage.ShowDialog();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
           
        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {
            this.Hide();
            dataContainer nextpage = new dataContainer(10);
            nextpage.ShowDialog();
        }

        private void label21_Click(object sender, EventArgs e)
        {
            this.Hide();
            dataContainer nextpage = new dataContainer(10);
            nextpage.ShowDialog();
        }

        private void label22_Click(object sender, EventArgs e)
        {
            this.Hide();
            dataContainer nextpage = new dataContainer(10);
            nextpage.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            dataContainer nextpage = new dataContainer(11);
            nextpage.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
            dataContainer nextpage = new dataContainer(11);
            nextpage.ShowDialog();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Hide();
            dataContainer nextpage = new dataContainer(11);
            nextpage.ShowDialog();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            this.Hide();
            dataContainer nextpage = new dataContainer(12);
            nextpage.ShowDialog();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            this.Hide();
            dataContainer nextpage = new dataContainer(12);
            nextpage.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            dataContainer nextpage = new dataContainer(12);
            nextpage.ShowDialog();
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            this.Hide();
            dataContainer nextpage = new dataContainer(13);
            nextpage.ShowDialog();
        }

        private void label13_Click(object sender, EventArgs e)
        {
            this.Hide();
            dataContainer nextpage = new dataContainer(13);
            nextpage.ShowDialog();
        }

        private void label14_Click(object sender, EventArgs e)
        {
            this.Hide();
            dataContainer nextpage = new dataContainer(13);
            nextpage.ShowDialog();
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            this.Hide();
            dataContainer nextpage = new dataContainer(14);
            nextpage.ShowDialog();
        }

        private void label19_Click(object sender, EventArgs e)
        {
            this.Hide();
            dataContainer nextpage = new dataContainer(14);
            nextpage.ShowDialog();
        }

        private void label20_Click(object sender, EventArgs e)
        {
            this.Hide();
            dataContainer nextpage = new dataContainer(14);
            nextpage.ShowDialog();
        }
    }
}

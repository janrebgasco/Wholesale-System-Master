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
    public partial class Home : Form
    {
        
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\admin\Documents\wholesaledb.mdf;Integrated Security=True;Connect Timeout=30");
        string cs = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\admin\Documents\wholesaledb.mdf;Integrated Security=True;Connect Timeout=30"; 
        SqlConnection con;
        SqlDataAdapter adapt;
        DataTable dt;
        public Home()
        {
            InitializeComponent();
        }


        private void Home_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pic1.Visible == true)
            {
                pic1.Visible = false;
                pic2.Visible = true;
            }
            else if (pic2.Visible == true)
            {
                pic2.Visible = false;
                pic3.Visible = true;
            }
            else if (pic3.Visible == true)
            {
                pic3.Visible = false;
                pic4.Visible = true;
            }
            else if (pic4.Visible == true)
            {
                pic4.Visible = false;
                pic5.Visible = true;
            }
            else if (pic5.Visible == true)
            {
                pic5.Visible = false;
                pic6.Visible = true;
            }
            else if (pic6.Visible == true)
            {
                pic6.Visible = false;
                pic1.Visible = true;
            }

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Show();
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from tblAdminAdd where product like '%" + textBox1.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();  
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void category2_Click(object sender, EventArgs e)
        {
            category_Panel.Hide();
        }

        private void catergory1_Click(object sender, EventArgs e)
        {
            category_Panel.Show();
        }

        private void category2_MouseHover(object sender, EventArgs e)
        {
            
        }

        

        

        private void pictureBox9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            log_in x = new log_in();
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to log out?", "Log Out", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                x.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            
        }
        
        private void pictureBox9_Click_1(object sender, EventArgs e)
        {
            
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            
        }
        private void label8_Click(object sender, EventArgs e)
        {
            
        }

        public void label7_Click(object sender, EventArgs e)
        {
            
        }

        private void category_Panel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ProductContainer x= new ProductContainer();
            x.Show();
            this.Hide();

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select product,selling_price,image from tblAdminAdd where id = 7", connection);
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

        private void panel11_Paint(object sender, PaintEventArgs e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select product,selling_price,image from tblAdminAdd where id = (select max(id) from tblAdminAdd)", connection);
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                Byte[] byteBLOBData = new Byte[2];
                byteBLOBData = (Byte[])((byte[])da["image"]);
                System.IO.MemoryStream ms = new System.IO.MemoryStream(byteBLOBData);
                pictureBox21.Image = System.Drawing.Image.FromStream(ms);
                label29.Text = da.GetValue(0).ToString();
                label30.Text = da.GetValue(1).ToString();
            }
            connection.Close();
        }

        private void pic2_Click(object sender, EventArgs e)
        {
            dataGridView1.Hide();
        }

        private void pic2_Click_1(object sender, EventArgs e)
        {
            dataGridView1.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            dataGridView1.Hide();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            dataGridView1.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
        private void pictureBox20_Click(object sender, EventArgs e)
        {
            this.Hide();
            dataContainer nextpage = new dataContainer(1);
            nextpage.ShowDialog();
        }
        
        private void label27_Click(object sender, EventArgs e)
        {
            this.Hide();
            dataContainer nextpage = new dataContainer(1);
            nextpage.ShowDialog();
        }

        private void label28_Click(object sender, EventArgs e)
        {
            this.Hide();
            dataContainer nextpage = new dataContainer(1);
            nextpage.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox21_Click(object sender, EventArgs e)
        {
            this.Hide();
            dataContainer nextpage = new dataContainer(2);
            nextpage.ShowDialog();
        }

        private void label29_Click(object sender, EventArgs e)
        {
            this.Hide();
            dataContainer nextpage = new dataContainer(2);
            nextpage.ShowDialog();
        }

        private void label30_Click(object sender, EventArgs e)
        {
            this.Hide();
            dataContainer nextpage = new dataContainer(2);
            nextpage.ShowDialog();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            cart x = new cart();
            this.Hide();
            x.Show();
        }

    }
}

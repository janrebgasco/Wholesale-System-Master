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
    public partial class Admin : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\admin\Documents\wholesaledb.mdf;Integrated Security=True;Connect Timeout=30");
        string cs = @"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\admin\Documents\wholesaledb.mdf;Integrated Security=True;Connect Timeout=30";
        SqlConnection con;
        SqlDataAdapter adapt;
        DataTable dt;

        public Admin()
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
        private void Form2_Load(object sender, EventArgs e)
        {
            display_data();
            comboBox1.Items.Clear();
            SqlCommand mcd = connection.CreateCommand();
            connection.Open();
            mcd = connection.CreateCommand();
            mcd.CommandType = CommandType.Text;
            mcd.CommandText = "SELECT category FROM tblCategory";
            mcd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(mcd);
            ad.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["category"].ToString());
            }
            connection.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home x = new Home();
            this.Hide();
            x.Show();

           
        }
        

        private void label4_Click(object sender, EventArgs e)
        {  

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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

        private void button5_Click_1(object sender, EventArgs e)
        {
            /*connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into[tblAdminAdd] (Product,Price,Stocks,Description) values('" + textBox3.Text + "','" + textBox4.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')";
            cmd.ExecuteNonQuery();
            connection.Close();*/
            
            

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


        string imgLocation = "";
        SqlCommand cmd;
        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if(dialog.ShowDialog()==DialogResult.OK){
                imgLocation = dialog.FileName.ToString();
                pictureBox3.ImageLocation = imgLocation;
            }
        }


       
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Show();
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from tblAdminAdd where product like '%" + textBox5.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();  

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        public void display_user_data()
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from [Login_Table]";
            cmd.ExecuteNonQuery();
            DataTable dta = new DataTable();
            SqlDataAdapter dataadp = new SqlDataAdapter(cmd);
            dataadp.Fill(dta);
            dataGridView1.DataSource = dta;
            connection.Close();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            display_user_data();
            Signup_panel.Show();
            button5.Hide();
            button6.Hide();
            button7.Hide();
            button8.Hide();
            button9.Show();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from [Login_Table] where id = '" + idTxtBox.Text + "'";
            cmd.ExecuteNonQuery();
            connection.Close();
            display_user_data();
            MessageBox.Show("Data Deleted Successfully");
            
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button5.Show();
            button6.Show();
            button7.Show();
            button8.Show();
            button9.Hide();
            Signup_panel.Hide();
            display_data();
        }
    }
}

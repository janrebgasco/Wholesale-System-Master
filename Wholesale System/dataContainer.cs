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
        
    public partial class dataContainer : Form
    {
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\admin\Documents\wholesaledb.mdf;Integrated Security=True;Connect Timeout=30");

        public void get_data(int number)
        {
            int choice = number;
            connection.Open();
            SqlCommand cmd = new SqlCommand("Select image,product,selling_price,description,stocks,id from tblAdminAdd where id = '" + choice + "'", connection);
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                Byte[] byteBLOBData = new Byte[0];
                byteBLOBData = (Byte[])((byte[])da["image"]);
                System.IO.MemoryStream ms = new System.IO.MemoryStream(byteBLOBData);
                pictureBox2.Image = System.Drawing.Image.FromStream(ms);
                label2.Text = da.GetValue(1).ToString();
                label3.Text = da.GetValue(2).ToString();
                groupBox1.Text = da.GetValue(3).ToString();
                label5.Text = da.GetValue(4).ToString();
                label30.Text = da.GetValue(5).ToString();
            }
            connection.Close();
        }
        public dataContainer(int number)
        {
            InitializeComponent();

            int choice = number;
            if (choice == 1)
            {
                get_data(7);
            }
            if (choice == 2)
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("Select image,product,price,description,stocks from tblAdminAdd where id = (select max(id) from tblAdminAdd)", connection);
                SqlDataReader da = cmd.ExecuteReader();
                while (da.Read())
                {
                    Byte[] byteBLOBData = new Byte[0];
                    byteBLOBData = (Byte[])((byte[])da["image"]);
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(byteBLOBData);
                    pictureBox2.Image = System.Drawing.Image.FromStream(ms);
                    label2.Text = da.GetValue(1).ToString();
                    label3.Text = da.GetValue(2).ToString();
                    groupBox1.Text = da.GetValue(3).ToString();
                    label5.Text = da.GetValue(4).ToString();
                }
                connection.Close();
            }
            if (choice == 3)
            {
                get_data(2);
            }
            if (choice == 4)
            {
                get_data(3);
            }
            if (choice == 5)
            {
                get_data(4);
            }
            if (choice == 6)
            {
                get_data(5);
            }
            if (choice == 7)
            {
                get_data(6);
            }
            if (choice == 8)
            {
                get_data(7);
            }
            if (choice == 9)
            {
                get_data(8);
            }
            if (choice == 10)
            {
                get_data(9);
            }
            if (choice == 11)
            {
                get_data(10);
            }
            if (choice == 12)
            {
                get_data(11);
            }
            if (choice == 13)
            {
                get_data(12);
            }
            if (choice == 14)
            {
                get_data(13);
            }
            else { }
            
        }
        
        private void Form3_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Image img = pictureBox2.Image;
            byte[] images;
            ImageConverter converter = new ImageConverter();
            images = (byte[])converter.ConvertTo(img, typeof(byte[]));

            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            string sqlQuery = "insert into[tblCart] (Product,Price,Stocks,Description,Image) values('" + label2.Text + "','" + label3.Text + "','" + label5.Text + "','" + groupBox1.Text + "','" + images + "')";
            cmd = new SqlCommand(sqlQuery, connection);
            cmd.Parameters.Add(new SqlParameter("@image", images));
            int n = cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Added to Cart");
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel5.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home x = new Home();
            x.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            /*connection.Open();
            SqlCommand cmd = new SqlCommand("Select image,product,price,description,stocks from tblAdminAdd where id = 2", connection);
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                Byte[] byteBLOBData = new Byte[0];
                byteBLOBData = (Byte[])((byte[])da["image"]);
                System.IO.MemoryStream ms = new System.IO.MemoryStream(byteBLOBData);
                pictureBox2.Image = System.Drawing.Image.FromStream(ms);
                label2.Text = da.GetValue(1).ToString();
                label3.Text = da.GetValue(2).ToString();
                groupBox1.Text = da.GetValue(3).ToString();
                label5.Text = da.GetValue(4).ToString();
            }
            connection.Close();
             */
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        int quantity=1;
        int total;
        private void Form3_Load(object sender, EventArgs e)
        {

            connection.Open();
            SqlCommand cmd = new SqlCommand("Select firstname,lastname,address,phonenumber from tblLogin where id = 1", connection);
            SqlDataReader da = cmd.ExecuteReader();
            while (da.Read())
            {
                label12.Text = da.GetValue(0).ToString();
                label19.Text = da.GetValue(1).ToString();
                label14.Text = da.GetValue(2).ToString();
                label16.Text = da.GetValue(3).ToString();
            }
            connection.Close();

            comboBox1.Items.Clear();
            SqlCommand mcd = connection.CreateCommand();
            connection.Open();
            mcd = connection.CreateCommand();
            mcd.CommandType = CommandType.Text;
            mcd.CommandText = "SELECT payment FROM cboPayment";
            mcd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter ad = new SqlDataAdapter(mcd);
            ad.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["payment"].ToString());
            }
            connection.Close();

            
            
        }
        private void category2_Click(object sender, EventArgs e)
        {
            category_Panel.Hide();
        }
        private void catergory1_Click(object sender, EventArgs e)
        {
            category_Panel.Show();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            ProductContainer x = new ProductContainer();
            x.Show();
            this.Hide();
        }

        private void close2_Click(object sender, EventArgs e)
        {
            panel5.Hide();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            int price = Int32.Parse(label3.Text);
            label27.Text = price.ToString();
            label18.Text = quantity.ToString();
            int fee = 199;
            total = (price * quantity) + fee;
            label23.Text = total.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            quantity++;
            label25.Text = quantity.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            quantity--;
            label25.Text = quantity.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(label30.Text);
            int stocks = Int32.Parse(label5.Text);
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update [tblAdminAdd] set stocks = stocks - '" + quantity + "' where id= '" + id + "'";
            cmd.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Order Successful");
            
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void category_Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            cart x = new cart();
            this.Hide();
            x.Show();
        }
    }
}

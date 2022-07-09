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
using System.Data.OleDb;

namespace Wholesale_System
{
    public partial class log_in : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;
        SqlConnection connection = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\admin\Documents\wholesaledb.mdf;Integrated Security=True;Connect Timeout=30");

        public log_in()
        {
            InitializeComponent();
            passwordtxtbox.PasswordChar = '*';
            passtxtbox.PasswordChar = '*';
            
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void log_in_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnsignup;
            this.AcceptButton = btnLogin;
            comboBox1.Items.Clear();
            SqlCommand cmd = connection.CreateCommand();
            comboBox1.Items.Clear();
            connection.Open();
            cmd=connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT position FROM ComboBox_Table";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da= new SqlDataAdapter(cmd);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["position"].ToString());
            }
            connection.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login_panel.Show();
            Signup_panel.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Signup_panel.Show();
            Login_panel.Hide();
        }

        private void close1_Click(object sender, EventArgs e)
        {
            Login_panel.Hide();
        }

        private void close2_Click(object sender, EventArgs e)
        {
            Signup_panel.Hide();
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, pictureBox2.ClientRectangle, Color.White, ButtonBorderStyle.Solid);
        }

        private void pictureBox3_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, pictureBox3.ClientRectangle, Color.White, ButtonBorderStyle.Solid);
        }

        private void pictureBox4_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, pictureBox4.ClientRectangle, Color.White, ButtonBorderStyle.Solid);
        }

        private void pictureBox5_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, pictureBox5.ClientRectangle, Color.White, ButtonBorderStyle.Solid);
        }

        private void pictureBox6_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, pictureBox6.ClientRectangle, Color.White, ButtonBorderStyle.Solid);
        }

        private void pictureBox7_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, pictureBox7.ClientRectangle, Color.White, ButtonBorderStyle.Solid);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            
            connection.Open();
            SqlCommand cmd = connection.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into[tblLogin] (username,password,firstname,lastname,address,phonenumber) values('" + usernametxtbox.Text + "','" + passwordtxtbox.Text + "','" + firstnametxtbox.Text + "','" + lastnametxtbox.Text + "','" + addresstxtbox.Text + "','" + phonenumbertxtbox.Text + "')";
            cmd.ExecuteNonQuery();
            connection.Close();
            usernametxtbox.Text = "";
            passwordtxtbox.Text = "";
            firstnametxtbox.Text = "";
            lastnametxtbox.Text = "";
            addresstxtbox.Text = "";
            phonenumbertxtbox.Text = "";
            MessageBox.Show("Data Inserted Successfully");
            
        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\admin\Documents\wholesaledb.mdf;Integrated Security=True;Connect Timeout=30"); // making connection   
            SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM tblLogin WHERE username='" + unametxtbox.Text + "' AND password='" + passtxtbox.Text + "'", con);
            
            DataTable dt = new DataTable();  
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                new Home().Show();
            }
            else
                MessageBox.Show("Invalid username or password");  
        }

        private void log_in_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void unametxtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Signup_panel_Paint(object sender, PaintEventArgs e)
        {

        }
        /*string admin,seller,customer,result;
        public void logger(){
            
            if(usernametxtbox.Text==admin){
                label3.Text = usernametxtbox.Text;
            }
            else if (usernametxtbox.Text == seller)
            {
                label3.Text = usernametxtbox.Text;
            }
            else if (usernametxtbox.Text == customer)
            {
                label3.Text = usernametxtbox.Text;
            }
            else{}

            }*/
    }
}

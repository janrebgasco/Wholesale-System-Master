using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace Wholesale_System
{
    class allclass
    {
        public void signup()
        {
            log_in l = new log_in();
            try
            {
                string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=application.accdb;Persist Security Info=True";
                OleDbConnection conn = new OleDbConnection();
                conn.ConnectionString = connStr;

                OleDbDataAdapter adapter = new OleDbDataAdapter();
                adapter.InsertCommand = new OleDbCommand();
                adapter.InsertCommand.CommandText = "INSERT INTO login (username, [password], firsname)" + " VALUES('" + l.usernametxtbox.Text + "', '" + l.passwordtxtbox.Text + "', '" + l.firstnametxtbox.Text + "');";
                conn.Open();
                adapter.InsertCommand.Connection = conn;
                adapter.InsertCommand.ExecuteNonQuery();
                MessageBox.Show("Data inserted Successfully");
            }
            catch (OleDbException exp)
            {

                MessageBox.Show(exp.ToString());
            }
        }


    
    
    
    
    }
}

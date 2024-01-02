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

namespace WindowsForm_DatabaseConnection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = DatabaseConnection.getConnection();

            if (con != null)
            {
                MessageBox.Show  ("Connected Successfully...");
                con .Close ();
            }
            else
            {
                MessageBox.Show("Could not be connected to sqlserver...");
            }
        }
    }
}


/* 
  internal class DatabaseConnection
{
        public static string strcon = "server = LAPTOP-SUPR1U1K\\SQLEXPRESS; integreated security=true; database=MkpSample";
        public static SqlConnection getConnection()
{
    SqlConnection con = null;
    try
    {
        con = new SqlConnection(strcon);
        con.Open();
        return con;
    }
    catch (Exception ee)
    {
        return null;
    }
} 
}
*/
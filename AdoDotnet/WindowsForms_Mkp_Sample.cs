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


namespace WindowsForms_Mkp_Sample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = "server= LAPTOP-SUPR1U1K\\SQLEXPRESS;integrated security=true;database=MkpSample";
            SqlConnection con = null;

            try
            {
                con = new SqlConnection(str);
                con.Open();
                MessageBox.Show("Connected Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close();
            }
        }
    }
}

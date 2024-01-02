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

namespace WindowsForm_DataConection_SUID
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string constr = "server=.\\sqlexpress;integrated security=true;database=MkpSample";
            SqlConnection con = new SqlConnection(constr);
            try
            {
                con.Open();
                string strcmd = "Insert into users values (' " + textBox1.Text + "','" + textBox2.Text + "')";
                SqlCommand command = new SqlCommand(strcmd, con);
                command.ExecuteNonQuery();
                con.Close();
                label3.Text = "Record inserted successfully";
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show (ex . ToString ());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string constr = "server=.\\sqlexpress;integrated security=true;database=MkpSample";
            SqlConnection con = new SqlConnection(constr);
            try
            {
                con.Open();
                string strcmd = "Update users set Password= '" + textBox2.Text + "' where User_Name= '" + textBox1.Text +"'";
                SqlCommand command = new SqlCommand(strcmd, con);
                command.ExecuteNonQuery();
                con.Close();
                label3.Text = "Record updated successfully";
                textBox1.Clear();   
                textBox2.Clear();
                textBox1.Focus();
            }
            catch ( Exception ex )
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string constr = "server=.\\sqlexpress;integrated security=true;database=MkpSample";
            SqlConnection con = new SqlConnection(constr);
            try
            {
                con.Open();
                string strcmd = "delete from  users where User_Name='" + textBox1.Text + "' or Password ='" + textBox2.Text + "'";
                SqlCommand command = new SqlCommand(strcmd, con);
                command.ExecuteNonQuery();
                con.Close();
                label3.Text = "record deleted successfully";
                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();

            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string constr = "server=.\\sqlexpress;integrated security=true;database=MkpSample";
            SqlConnection con = new SqlConnection(constr);
            try
            {
                con.Open();
                string strcmd = "Select * from users where User_Name= '" + textBox1.Text + "'";
                SqlCommand command = new SqlCommand(strcmd, con);
                SqlDataReader dr;
                dr = command.ExecuteReader();
                int flag = 0;
                while (dr.Read())
                {
                    flag = 1;
                    textBox2.Text = dr ["Password"].ToString();
                }
                dr.Close();
                con.Close();
                if (flag == 0)
                {
                    label3.Text = "Record not found";
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }
    }
}


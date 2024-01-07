using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_DataConnectionWithCustomer_IUDS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string str = "server=.\\SQLEXPRESS;integrated security=true;database=MkpSample";
        SqlConnection con = null;
        SqlCommand command = null;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(str);
                //with sqlparametters
                string qr = "Insert into Customer (CustID,CustName,CustAddress,MobileNo,EmailID) values (@CustID,@CustName,@CustAddress,@MobileNo,@EmailID)";
                command = new SqlCommand(qr, con);
                command.Parameters.Add("@CustID", SqlDbType.VarChar, 50).Value = Convert.ToInt32(textBox1.Text);
                command.Parameters.Add("@CustName", SqlDbType.VarChar, 50).Value = textBox2.Text;
                command.Parameters.Add("@CustAddress", SqlDbType.VarChar, 50).Value = textBox3.Text;
                command.Parameters.Add("@MobileNo", SqlDbType.VarChar, 50).Value = textBox4.Text;
                command.Parameters.Add("@EmailID", SqlDbType.VarChar, 50).Value = textBox5.Text;

                con.Open();  //in connected env. you have to explicitly open the connection using open method 
                command.ExecuteNonQuery();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox1.Focus();
                MessageBox.Show("Record Save Successfully...");
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(str);
                string qr = "Update Customer set CustName=@CustName,CustAddress=@CustAddress,MobileNo=@MobileNo ,EmailID=@EmailID where CustID=@CustID";
                command = new SqlCommand(qr, con);
                command.Parameters.Add("@CustName", SqlDbType.VarChar, 50).Value = textBox2.Text;
                command.Parameters.Add("@CustAddress", SqlDbType.VarChar, 50).Value = textBox3.Text;
                command.Parameters.Add("@MobileNo", SqlDbType.VarChar, 50).Value = textBox4.Text;
                command.Parameters.Add("@EmailId", SqlDbType.VarChar,50).Value = textBox5.Text;
                command.Parameters.Add("@CustID", SqlDbType.VarChar, 50).Value = Convert.ToInt32(textBox1.Text);
                con.Open();
                command.ExecuteNonQuery();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox1.Focus();
                MessageBox.Show("Record Updated Successfully...");
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(str);
                string qr = "Delete Customer set CustName=@CustName or CustAddress=@CustAddress or MobileNo=@MobileNo or EmailID=@EmailID where CustID=@CustID";
                command = new SqlCommand(qr, con);
                command.Parameters.Add("@CustName", SqlDbType.VarChar, 50).Value = textBox2.Text;
                command.Parameters.Add("@CustAddress", SqlDbType.VarChar, 50).Value = textBox3.Text;
                command.Parameters.Add("@MobileNo", SqlDbType.VarChar, 50).Value = textBox4.Text;
                command.Parameters.Add("@EmailId", SqlDbType.VarChar, 50).Value = textBox5.Text;
                command.Parameters.Add("@CustID", SqlDbType.VarChar, 50).Value = Convert.ToInt32(textBox1.Text);
                con.Open();
                command.ExecuteNonQuery();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox1.Focus();
                MessageBox.Show("Record Deleted Successfully...");

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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(str);
                string qr = "select * from Customer where CustID=@CustID";
                command = new SqlCommand(qr, con);
                command.Parameters.Add("@CustID", SqlDbType.VarChar).Value = Convert.ToInt32(textBox1.Text);
                con.Open();
                SqlDataReader dr = command.ExecuteReader();
                int flag = 0;
                textBox2.Clear();
                while (dr.Read())
                {
                    flag = 1;
                    textBox2.Text = dr["CustName"].ToString();
                    textBox3.Text = dr["Address"].ToString();
                    textBox4.Text = dr["MobileNo"].ToString();
                    textBox5.Text = dr["EmailID"].ToString();
                }
                dr.Close();
                if (flag == 0)
                {
                    MessageBox.Show("Record Not Found");
                }
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

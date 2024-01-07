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

namespace WindowsForm_Ass_DataconnectionWithProduct_IUDS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //1- create a connection string 

        string str = "server=.\\SQLEXPRESS;integrated security=true;database=MkpSample";
        SqlConnection con = null;
        SqlCommand command = null;
        private void button1_Click(object sender, EventArgs e)
        {
            //2 - use sqlconnection class to connect to sqlserver database
            try
            {
                con = new SqlConnection(str);
                //with sqlparametters
                string qr = "Insert into Products (Product_ID,Product_Name,Price,Quantity) values (@Product_ID,@Product_Name,@Price,@Quantity)";
                command = new SqlCommand(qr,con);
                command.Parameters.Add("@Product_ID", SqlDbType.VarChar, 50).Value = textBox1.Text;
                command.Parameters.Add("@Product_Name", SqlDbType.VarChar, 50).Value = textBox2.Text;
                command.Parameters.Add("@Price", SqlDbType.VarChar, 50).Value = textBox3.Text;
                command.Parameters.Add("@Quantity", SqlDbType.VarChar, 50).Value = textBox4.Text;

                con.Open();  //in connected env. you have to explicitly open the connection using open method 
                command.ExecuteNonQuery();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
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
                string qr = "Update Products set Product_Name=@Product_Name,Price=@Price,Quantity=@Quantity where Product_ID=@Product_ID";
                command = new SqlCommand(qr,con);
                command.Parameters.Add("@Product_Name", SqlDbType.VarChar, 50).Value = textBox2.Text;
                command.Parameters.Add("@Price", SqlDbType.VarChar, 50).Value = textBox3.Text;
                command.Parameters.Add("@Quantity", SqlDbType.VarChar, 50).Value = textBox4.Text;
                command.Parameters.Add("@Product_ID", SqlDbType.VarChar, 50).Value = textBox1.Text;
                con.Open();
                command.ExecuteNonQuery();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox1.Focus();
                MessageBox.Show("Record Updated Successfully...");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close() ;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(str);
                string qr = "Delete from Products where Product_ID=@Product_ID or Product_Name=@Product_Name or Price=@Price or Quantity=@Quantity";
                command = new SqlCommand(qr,con);
                command.Parameters.Add("@Product_ID", SqlDbType.VarChar, 50).Value = Convert.ToInt32(textBox1.Text);
                command.Parameters.Add("@Product_Name", SqlDbType.VarChar, 50).Value = textBox2.Text;
                command.Parameters.Add("@Price", SqlDbType.VarChar, 50).Value = textBox3.Text;
                command.Parameters.Add("@Quantity", SqlDbType.VarChar, 50).Value = textBox4.Text;
                con.Open();
                command.ExecuteNonQuery();
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox1.Focus();
                MessageBox.Show("Record Deleted Successfully...");

            }
            catch(Exception ex)
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
                string qr = "select * from Products where Product_ID=@Product_ID";
                command = new SqlCommand(qr, con);
                command.Parameters.Add("@Product_ID", SqlDbType.VarChar).Value = Convert.ToInt32(textBox1.Text);
                con.Open();
                SqlDataReader dr = command.ExecuteReader();
                int flag = 0;
                textBox2.Clear();
                while(dr.Read())
                {
                    flag = 1;
                    textBox2.Text = dr["Product_Name"].ToString();
                    textBox3.Text = dr["Price"].ToString();
                    textBox4.Text = dr["Quantity"].ToString();
                }
                dr.Close();
                if(flag == 0)
                {
                    MessageBox.Show("Record Not Found");
                }
            }
            catch(Exception ex)
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

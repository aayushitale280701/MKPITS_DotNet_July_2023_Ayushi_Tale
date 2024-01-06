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

namespace WindowsForm_DataconnectionMDI_Login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string str = "server=.\\SQLEXPRESS; integrated security=true; database=MkpSample";
        SqlConnection con = null;
        SqlCommand command = null;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con = new SqlConnection(str);
                string qr = "Select count(*) from users where User_Name=@username or Password=@password";
                command = new SqlCommand(qr, con);
                command.Parameters.AddWithValue("@username", textBox1.Text);
                command.Parameters.AddWithValue("@password", textBox2.Text);
                con.Open();
                int cnt = Convert.ToInt32(command.ExecuteScalar());
                if (cnt > 0)
                {
                    label3.Text = "Login Successfully....!";
                    
                }
                else
                    label3.Text = "Invalide Credentail, Try Again....!";
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
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
        }

        private void registerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }
    }
}


/* form 2 registration form code
 
public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string str = "Server=.\\SQLEXPRESS;integrated security=true;database=MkpSample";
        SqlConnection con = null;
        SqlCommand command = null;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string Gender = null;
                if (radioButton1.Checked == true)
                    Gender = radioButton1.Text;
                else if (radioButton2.Checked == true)
                    Gender = radioButton2.Text;
                string Hobby = null;
                if (checkBox1.Checked == true)
                    Hobby = checkBox1.Text;
                else if (checkBox2.Checked == true)
                    Hobby += " " + checkBox2.Text;
                con = new SqlConnection(str);
                string qr = "insert into students(Rno,StudentName,Gender,Hobby,City,Dob) values('" + textBox1.Text + "','" + textBox2.Text + "','" + Gender + "','" + Hobby + "','" + comboBox1.Text + "','" + dateTimePicker1.Text + "')";
                command = new SqlCommand(qr, con);
                con.Open();
                command.ExecuteNonQuery();
                textBox1.Clear(); 
                textBox2.Clear();
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                comboBox1.Text = " ";

                label8.Text = "Record saved successfully....";
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
                string Gender = null;
                if (radioButton1.Checked == true)
                    Gender = radioButton1.Text;
                else if (radioButton2.Checked == true)
                    Gender = radioButton2.Text;

                string Hobby = null;
                if (checkBox1.Checked)
                    Hobby = checkBox1.Text;
                if (checkBox2.Checked)
                    Hobby += "  " + checkBox2.Text;
                con = new SqlConnection(str);

                string qr = "Update students set StudentName='" + "',Gender='" + "',Hobby='" + "',City='" + comboBox1.Text + "',Dob='" + dateTimePicker1.Text + "' where Rno='" + textBox1.Text + "'";
                command = new SqlCommand(qr, con);
                con.Open();
                command.ExecuteNonQuery();
                textBox1.Clear();
                textBox2.Clear();
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                comboBox1.Text = " ";
                label8.Text = "Record updated succ.";
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
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
                string qr = "Delete from Students where Rno='" + textBox1.Text + "'  or StudentName= '" + textBox2.Text + "' ";
                command = new SqlCommand(qr, con);
                con.Open();
                command.ExecuteNonQuery();
                textBox1.Clear();
                textBox2.Clear();
                radioButton1.Checked = false;
                radioButton2.Checked = false;
                checkBox1.Checked = false;
                checkBox2.Checked = false;
                comboBox1.Text = " ";
                label8.Text = "Record deleted succ.";
            }
            catch (Exception ee)
            {
                MessageBox.Show(ee.ToString());
            }
            finally
            {
                con.Close();
            }
        }
    }
*/
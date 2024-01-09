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

namespace WindowsForms_InstitudeCourseRegistration_DB
{
    public partial class Form1 : Form
    {
        string strcon = "server=.\\SQLEXPRESS; integrated security=true; database=InstituteCourseRegistration_DataBase";
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Text = DateTime.Now.ToShortDateString();
            getnation();
            getstate();
            getcity();
            if (radioButton1.Checked)
            {
                textBox3.Text = "1000";
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            getstate();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            getcity();
        }

        public void getnation()
        {
            try
            {
                con = new SqlConnection(strcon);
                da = new SqlDataAdapter("select * from TableNation1 order by NationID", con);
                ds = new DataSet();
                da.Fill(ds, "TableNation1");
                comboBox1.DataSource = ds.Tables["TableNation1"];
                comboBox1.DisplayMember = "NationName";
                comboBox1.ValueMember = "NationID";
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void getstate()
        {
            if (comboBox1.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                try
                {
                    con = new SqlConnection(strcon);
                    da = new SqlDataAdapter("select * from TableState1 where NationID=@NationID", con);
                    da.SelectCommand.Parameters.AddWithValue("NationID", comboBox1.SelectedValue);
                    ds = new DataSet();
                    ds.Clear();
                    da.Fill(ds, "TableState1");
                    comboBox2.DataSource = ds.Tables["TableState1"];
                    comboBox2.DisplayMember = "StateName";
                    comboBox2.ValueMember = "StateID";
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        public void getcity()
        {
            if (comboBox2.SelectedValue.ToString() != "System.Data.DataRowView")
            {
                try
                {
                    con = new SqlConnection(strcon);
                    da = new SqlDataAdapter("Select * from TableCity1 where StateID=@StateID", con);
                    da.SelectCommand.Parameters.AddWithValue("@StateID", comboBox2.SelectedValue);
                    ds = new DataSet();
                    ds.Clear();
                    da.Fill(ds,"TableCity1");
                    comboBox3.DataSource = ds.Tables["TableCity1"];
                    comboBox3.DisplayMember = "CityName";
                    comboBox3.ValueMember = "CityID";
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        public enum Category { Student, IT_Professional }
        public enum Gender { Male, Female, Other }
        Category cat;
        Gender gen;

        private void button1_Click(object sender, EventArgs e)
        {
            //get the selected Payment date from the dateTimePicker
            DateTime selectedDate = dateTimePicker1.Value;
            //Validate that the selected date is not earlier than today
            if (selectedDate.Date < DateTime.Today)
            {
                MessageBox.Show("Please select a Payment date that is on or after today's date. ", "Invalid date Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBox2.Text == " ")
            {
                MessageBox.Show("Full Name can't be blank ");
            }
            else
            {
                //for category
                if (radioButton1.Checked)
                {
                    cat = Category.Student;
                }
                else if (radioButton2.Checked)
                {
                    cat = Category.IT_Professional;
                }
                MessageBox.Show("Category " + cat);
            }
            //for gender 
            if (radioButton3.Checked)
            {
                gen = Gender.Male;
            }
            else if (radioButton4.Checked)
            {
                gen = Gender.Female;
            }
            else if (radioButton5.Checked)
            {
                gen = Gender.Other;
            }
            //MessageBox.Show("Gender Selected " + gen);
            // code to save record in courseregdetail table
            savecourseregdetail(cat, gen);
        }


        public void savecourseregdetail(Category c, Gender g)
        {
            try
            {
                string str = "Insert into TableCourseRegDetail1 values(@CategoryID, @FullName, @GenderID)";
                SqlCommand command = new SqlCommand(str, con);
                command.Parameters.AddWithValue("@CategoryID", Convert.ToInt32(c));
                command.Parameters.AddWithValue("@FullName", textBox2.Text);
                command.Parameters.AddWithValue("GenderID", Convert.ToInt32(g));
                con.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Record Save");
                con.Close();
                InsertRegAddress();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        public void InsertRegAddress()
        {
            con.Open();
            string str = "select max(CourseRegID) from TableCourseRegDetail1";
            SqlCommand cmd11 = new SqlCommand(str, con);
            int mcid = Convert.ToInt32(cmd11.ExecuteScalar());
            //MessageBox.Show(mcid.Tostring());
            string s2 = "insert into TableRegAddress101 values(@CourseRegID, @NationID, @StateID, @CityID)";
            SqlCommand cmd1 = new SqlCommand(s2, con);
            cmd1.Parameters.Add("@CourseRegID", SqlDbType.Int).Value = mcid;
            cmd1.Parameters.Add("@NationID", SqlDbType.Int).Value = comboBox1.SelectedValue;
            cmd1.Parameters.Add("@StateID", SqlDbType.Int).Value = comboBox2.SelectedValue;
            cmd1.Parameters.Add("@CityID", SqlDbType.Int).Value = comboBox3.SelectedValue;
            cmd1.ExecuteNonQuery();
            MessageBox.Show("Stored TableRegAddess101");
            con.Close();
            insertFeeDetail();
        }
        public void insertFeeDetail()
        {
            con.Open();

            string str = "select max(CourseRegID) from TableCourseRegDetail1";
            SqlCommand cmd11 = new SqlCommand(str, con);
            int mcid = Convert.ToInt32(cmd11.ExecuteScalar());

            string s2 = "insert into TableFeeDetail1 values(@CourseRegID,@TotalAmount,@MinPer,@PaidAmount,@BalAmount,@PaidDate)";
            SqlCommand cmd1 = new SqlCommand(s2, con);
            cmd1.Parameters.Add("@CourseRegID", SqlDbType.Int).Value = mcid;
            cmd1.Parameters.Add("@TotalAmount", SqlDbType.Decimal).Value = textBox3.Text;
            cmd1.Parameters.AddWithValue("@MinPer", fp);
            cmd1.Parameters.Add("@PaidAmount", SqlDbType.Int).Value = textBox4.Text;
            cmd1.Parameters.Add("@BalAmount", SqlDbType.Int).Value = textBox5.Text;
            cmd1.Parameters.Add("@PaidDate", SqlDbType.DateTime).Value = dateTimePicker1.Value;
            cmd1.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Stored TableFeeDetail1");
        }


        private void textBox3_Leave(object sender, EventArgs e)
        {
            calculatefees();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                cat = Category.IT_Professional;
                textBox3.Text = "3000";
                textBox4.Text = "0";
                textBox5.Text = "0";
                // calculatefees();
            }
        }
        float fp = 0;
        float bamt = 0;
        public void calculatefees()
        {
            if (cat.ToString() == "Student")
            {
                textBox3.Text = "1000";

                float ta = Convert.ToSingle(textBox3.Text);
                 fp = ta * 0.5f;
                float amt = Convert.ToSingle(textBox4.Text);

                if (amt < fp)
                {
                    MessageBox.Show("minimum amount to be paid is 50 per");
                }
                else
                {
                     bamt = ta - amt;
                    textBox5.Text = bamt.ToString();
                }
            }
            else if (cat.ToString() == "IT_Professional")
            {
                textBox3.Text = "3000";

                float ta = Convert.ToSingle(textBox3.Text);
                 fp = ta * 0.8f;
                float amt = Convert.ToSingle(textBox4.Text);

                if (amt < fp)
                {
                    MessageBox.Show("minimum amount to be paid is 80 per");
                }
                else
                {
                     bamt = ta - amt;
                    textBox5.Text = bamt.ToString();
                }
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                cat = Category.Student;
                textBox3.Text = "1000";
                textBox4.Text = "0";
                textBox5.Text = "0";
                //  calculatefees();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            clear();
        }

        public void clear()
        {
            getnation();
            getcity();
            getcity();
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            radioButton3.Checked = true;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            comboBox1.Text = " ";
            comboBox2.Text = " ";
            comboBox3.Text = " ";
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            dateTimePicker1.Text = DateTime.Now.ToString();
        }
    }
}

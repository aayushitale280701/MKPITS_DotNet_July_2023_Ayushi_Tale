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

namespace WindowsForm_InstituteCourseRegistration_DB
{
    public partial class Form1 : Form
    {
        string strcon = "server=.\\sqlexpress;integrated security=true;database=Nation";
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
                textBox2.Text = "1000";

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
                da = new SqlDataAdapter("select * from TableNation order by NationId ", con);
                ds = new DataSet();
                da.Fill(ds, "TableNation");
                comboBox1.DataSource = ds.Tables["TableNation"];
                comboBox1.ValueMember = "NationId";
                comboBox1.DisplayMember = "NationName";

            }
            catch (SqlException ee)
            {
                MessageBox.Show(ee.ToString());
            }
        }

        public void getstate()
        {
            if (comboBox1.SelectedValue.ToString() != "System.Data.DataRowView")
            {

                //   MessageBox.Show("nation id " + comboBox1.SelectedValue.ToString());
                try
                {

                    con = new SqlConnection(strcon);
                    da = new SqlDataAdapter("select * from TableState  where NationId=@NationId", con);
                    da.SelectCommand.Parameters.AddWithValue("@NationID", comboBox1.SelectedValue);
                    ds = new DataSet();
                    ds.Clear();
                    da.Fill(ds, "TableState");
                    comboBox2.DataSource = ds.Tables["TableState"];
                    comboBox2.ValueMember = "StateId";
                    comboBox2.DisplayMember = "StateName";

                }
                catch (SqlException ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
        }

        public void getcity()
        {
            if (comboBox2.SelectedValue.ToString() != "System.Data.DataRowView")
            {

                //   MessageBox.Show("nation id " + comboBox1.SelectedValue.ToString());
                try
                {

                    con = new SqlConnection(strcon);
                    da = new SqlDataAdapter("select * from TableCity  where StateId=@StateId", con);
                    da.SelectCommand.Parameters.AddWithValue("@StateID", comboBox2.SelectedValue);
                    ds = new DataSet();
                    ds.Clear();
                    da.Fill(ds, "TableCity");
                    comboBox3.DataSource = ds.Tables["TableCity"];
                    comboBox3.ValueMember = "CityId";
                    comboBox3.DisplayMember = "CityName";

                }
                catch (SqlException ee)
                {
                    MessageBox.Show(ee.ToString());
                }
            }
        }

        public enum category { student, it_professional }
        public enum Gender  {Male,Female,Other}

        category cat;
        Gender ge;

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the selected payment date from the DateTimePicker
            DateTime selectedDate = dateTimePicker1.Value;

            // Validate that the selected date is not earlier than today
            if (selectedDate.Date < DateTime.Today)
            {
                MessageBox.Show("Please select a payment date that is on or after today's date.", "Invalid Date Selection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (textBox1.Text == "")
            {
                MessageBox.Show("Full name cant be blank");
            }
            else
            {
                //for category
                if (radioButton1.Checked)
                {
                    cat = category.student;
                }
                else if (radioButton2.Checked)
                {
                    cat = category.it_professional;
                }
                MessageBox.Show("Category " + cat);
                //for gender
                 if(radioButton3.Checked)
                {
                    ge = Gender.Male;
                }
                 else if (radioButton4.Checked)
                {
                    ge = Gender.Female;
                }
                else if (radioButton5.Checked)
                {
                    ge = Gender.Other;
                }

                MessageBox.Show("gender selected " + ge);
                //code to save record in courseregdetail table
                savecourseregdetail(cat, ge);
            }
        }

        public void savecourseregdetail(category c, Gender g)
        {
            try
            {
                string str = "insert into TableCourseRegDetail values(@CategoryId,@FullName,@GenderID)";
                SqlCommand command = new SqlCommand(str, con);
                command.Parameters.AddWithValue("@CategoryID", Convert.ToInt32(c));
                command.Parameters.AddWithValue("@FullName", textBox1.Text);
                command.Parameters.AddWithValue("@GenderID", Convert.ToInt32(g));
                con.Open();
                command.ExecuteNonQuery();
                MessageBox.Show("Record saved");
                con.Close();
                insertRegAddress();

            }
            catch (SqlException ee)
            {
                MessageBox.Show(ee.ToString());
            }

        }
        public void insertRegAddress()
        {
            con.Open();
            string str1 = "select max(CourseRegID) from TableCourseRegDetail";
            SqlCommand cmd1 = new SqlCommand(str1, con);
            int mcid = Convert.ToInt32(cmd1.ExecuteScalar());
            // MessageBox.Show(mcid.ToString());
            string str2 = "insert into TableRegAddress values(@CourseRegId,@NationId,@StateId,@CityId)";
            SqlCommand cmd2 = new SqlCommand(str2, con);
            cmd2.Parameters.AddWithValue("@CourseRegId", mcid);
            cmd2.Parameters.AddWithValue("@NationId", comboBox1.SelectedValue);
            cmd2.Parameters.AddWithValue("@StateId", comboBox2.SelectedValue);
            cmd2.Parameters.AddWithValue("@CityId", comboBox3.SelectedValue);
            cmd2.ExecuteNonQuery();
           
            MessageBox.Show("Stored TableRegAddress");
            con.Close();
            insertFeeDetail();
        }

        public void insertFeeDetail()
        {
            con.Open();
            string str = "select max(CourseRegID) from TableCourseRegDetail";
            SqlCommand cmd11 = new SqlCommand(str, con);
            int mcid = Convert.ToInt32(cmd11.ExecuteScalar());
            string s2 = "insert into TableFeeDetail values(@CourseRegId,@TotalAmount,@MiniPer,@PaidAmount,@BalAmount,@PaidDate)";
            SqlCommand cmd1 = new SqlCommand(s2, con);
            cmd1.Parameters.AddWithValue("@CourseRegID", mcid);
            cmd1.Parameters.AddWithValue("@TotalAmount", textBox2.Text);
            cmd1.Parameters.AddWithValue("@MiniPer", fp);
            cmd1.Parameters.AddWithValue("@PaidAmount", textBox3.Text);
            cmd1.Parameters.AddWithValue("@BalAmount", textBox4.Text);
            cmd1.Parameters.AddWithValue("@PaidDate", dateTimePicker1.Value);
            cmd1.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Stored TableFeeDetail");
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            calculatefees();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                cat = category.it_professional;
                textBox2.Text = "3000";
                textBox3.Text = "0";
                textBox4.Text = "0";
                // calculatefees();
            }
        }

        float fp = 0;
        float bamt = 0;
        public void calculatefees()
        {
            if (cat.ToString() == "student")
            {
                textBox2.Text = "1000";

                float ta = Convert.ToSingle(textBox2.Text);
                fp = ta * 0.5f;
                float amt = Convert.ToSingle(textBox3.Text);

                if (amt < fp)
                {
                    MessageBox.Show("minimum amount to be paid is 50 per");
                }
                else
                {
                    bamt = ta - amt;
                    textBox4.Text = bamt.ToString();
                }
            }
            else if (cat.ToString() == "it_professional")
            {
                textBox2.Text = "3000";

                float ta = Convert.ToSingle(textBox2.Text);
                fp = ta * 0.8f;
                float amt = Convert.ToSingle(textBox3.Text);

                if (amt < fp)
                {
                    MessageBox.Show("minimum amount to be paid is 80 per");
                }
                else
                {
                    bamt = ta - amt;
                    textBox4.Text = bamt.ToString();
                }
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                cat = category.student;
                textBox2.Text = "1000";
                textBox3.Text = "0";
                textBox4.Text = "0";
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
            getstate();
            getcity();
            radioButton1.Checked = true;
            radioButton2.Checked = false;
            radioButton3.Checked = true;
            radioButton4.Checked = false;
            radioButton5.Checked = false;
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            dateTimePicker1.Text = DateTime.Now.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

      
    }
}


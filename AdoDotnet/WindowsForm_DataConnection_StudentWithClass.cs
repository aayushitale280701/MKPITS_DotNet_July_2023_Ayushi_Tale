using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_DataConnection_StudentWithClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            string g = null;
            if (radioButton1.Checked)
            {
                g = "Male";
            }
            if (radioButton2.Checked)
            {
                g = "Female";
            }
            string h = null;
            if (checkBox1.Checked)
            {
                h = "Music";
            }
            if (checkBox2.Checked)
            {
               if (h != null)
                {
                    h = h +" " + "Reading Book";
                }
                else
                {
                    h = "Reading Book";
                }
            }

            string result = s.InsertStudents(Convert.ToInt32(textBox1.Text), textBox2.Text, g, h, comboBox1.Text, dateTimePicker1.Value.ToShortDateString());
            label7.Text = result;
            cleartext();
        }
        public void cleartext()
        {
            textBox1.Clear();
            textBox2.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            comboBox1.Text = " ";
            dateTimePicker1.Value = DateTime.Now;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            string g = null;
            if (radioButton1.Checked)
            {
                g = "Male";
            }
            if (radioButton2.Checked)
            {
                g = "Female";
            }
            string h = null;
            if (checkBox1.Checked)
            {
                h = "Music";
            }
            if (checkBox2.Checked)
            {
                if (h != null)
                {
                    h = h + "  " + "ReadingBook";
                }
                else
                {
                    h = "Reading Book";
                }
            }
            string result = s.UpdateStudent(Convert.ToInt32(textBox1.Text), textBox2.Text, g, h, comboBox1.Text, dateTimePicker1.Value.ToShortDateString());
            label7.Text = result;
            cleartext();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            string result = s.DeleteStudent(Convert.ToInt32(textBox1.Text), textBox2.Text);
            label7.Text = result;
            cleartext();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List <Students> li = new List<Students>();
            Student s = new Student();
            li = s.searchStudent(Convert.ToInt32(textBox1.Text));
            textBox2.Text = li[0].StudentName;
            string g = li[0].Gender;
            if (g == "Male")
            {
                radioButton1.Checked = true;
            }
            else if (g == "Female")
            {
                 radioButton2.Checked = true;
            }
            string h = li[0].Hobby;
            if (h=="Music")
            {
               checkBox1.Checked = true;
            }
            else if (h=="Reading_Book")
            {
                checkBox2.Checked = true;
            }
            comboBox1.Text = li[0].City;
            dateTimePicker1.Text = li[0].Dob;
            
        }
    }
}

/*class Student
    {
        string srtcon = "server = LAPTOP-SUPR1U1K\\SQLEXPRESS; integrated security=true; database=MkpSample";

        public object Hobby { get; private set; }

        //creating a method to insert record in student table

        public string InsertStudents(int Rno, string StudentName, string Gender, string Hobby, string City, string Dob)
        {
            using (SqlConnection con = new SqlConnection(srtcon))
            {
                con.Open();
                string srt = "insert into Students values(@Rno,@StudentName,@Gender,@Hobby,@City,@Dob)";
                using (SqlCommand command=new SqlCommand(srt, con))
                {
                    command.Parameters.AddWithValue("@Rno", Rno);
                    command.Parameters.AddWithValue("@StudentName", StudentName);
                    command.Parameters.AddWithValue("@Gender", Gender);
                    command.Parameters.AddWithValue("@Hobby", Hobby);
                    command.Parameters.AddWithValue("@City", City);
                    command.Parameters.AddWithValue("@Dob", Dob);
                    command.ExecuteNonQuery();
                    con.Close();
                    return "Record Saved Successfully.... ";
                }
            }
        }
        //method to update record
        public string UpdateStudent(int Rno,string StudentName , string Gender, string Hobby, string City, string Dob)
        {
            using (SqlConnection con = new SqlConnection(srtcon))
            {
                con.Open();
                string str = "Update Students set StudentName=@StudentName, Gender=@Gender , Hobby=@Hobby, City=@City, Dob=@Dob where Rno=@Rno";
                using (SqlCommand command = new SqlCommand(str, con))
                {
                    command.Parameters.AddWithValue("@StudentName", StudentName);
                    command.Parameters.AddWithValue("@Gender", Gender);
                    command.Parameters.AddWithValue("@Hobby", Hobby);
                    command.Parameters.AddWithValue("@City", City);
                    command.Parameters.AddWithValue("@Dob", Dob);
                    command.Parameters.AddWithValue("@Rno", Rno);
                    command.ExecuteNonQuery();
                    con.Close();
                    return "Record Update Successfully.... ";
                }
            }
        }

        //method to delete record from student table
        //method to update record

        public string DeleteStudent(int Rno, string StudentName)
        {
            using (SqlConnection con = new SqlConnection(srtcon))
            {
                con.Open();
                string str = "Delete from Students where Rno=@Rno or StudentName=@StudentName";
                using (SqlCommand command = new SqlCommand(str, con))
                {
                    command.Parameters.AddWithValue("@Rno", Rno);
                    command.Parameters.AddWithValue("@StudentName", StudentName);
                    command.ExecuteNonQuery();
                    con.Close();
                    return "Record Deleted successfully..... ";
                }
            }
        }

        // search method
        public List <Students> searchStudent(int Rno)
        {
            using (SqlConnection con = new SqlConnection(srtcon))
            {
                con.Open();
                String str = "Select * from Students where Rno=@Rno";
                using (SqlCommand command = new SqlCommand(str, con))
                {
                    command.Parameters.AddWithValue("@Rno", Rno);
                    SqlDataReader dr = command.ExecuteReader();
                    List<Students> li = new List<Students>();
                    while(dr.Read())
                    {
                        li.Add(new Students(Convert.ToInt32(dr["Rno"].ToString()),
                            dr["StudentName"].ToString(), dr["Gender"].ToString(), dr["Hobby"].ToString(), dr["City"].ToString(), dr["Dob"].ToString()));
                    }
                    return li;
                }
            }
        }
    }
*/



//class search
/*class Students
    {
        public int Rno { get; set; }
        public string StudentName { get; set; }
        public string Gender { get; set; }
        public string Hobby { get; set; }
        public string City { get; set; }
        public string Dob {  get; set; }

        public Students (int Rno, string StudentName, string Gender, string Hobby, string City, string Dob)
        {
            this.Rno = Rno;
            this.StudentName = StudentName;
            this.Gender = Gender;
            this.Hobby = Hobby;
            this.City = City;
            this.Dob = Dob;
        }
    }
*/

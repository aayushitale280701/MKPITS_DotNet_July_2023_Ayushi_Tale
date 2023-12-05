using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_CreatedRegistrationForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Username:  " + textBox1.Text + "\n");
            sb.Append("Password:  " + textBox2.Text + "\n");
            string gender = null;
            if (radioButton1.Checked)
            
                gender = radioButton1.Text;
            
            else if (radioButton2.Checked)
            
                gender = radioButton2.Text;
            
            sb.Append("Gender:  " + gender + "\n");

            string course = null;

            if (checkBox1.Checked)

                course = checkBox1.Text;

            if (checkBox2.Checked)

                course = course + " " + checkBox2.Text;

            sb.Append("Course:  " + course + "\n");

            sb.Append("Country:  " + comboBox1.Text + "\n");

            sb.Append("City:  " + comboBox2.Text + "\n");
            label7.Text = sb.ToString();


        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = "";
            switch(comboBox1.Text)
            {
                case "India":
                    comboBox2.Items.Add("Nagpur");
                    comboBox2.Items.Add("Pune");
                    break;

                case "USA":
                    comboBox2.Items.Add("LA");
                    comboBox2.Items.Add("California");
                    break;
            }
        }
    }
}

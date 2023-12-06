using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_MDI_forms
{
    public partial class FormRegistration : Form
    {
        public FormRegistration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Name: " + textBox1.Text + "\n");
            sb.Append("Email ID: " + textBox1.Text + "\n");
            sb.Append("Mo.No: " + maskedTextBox1.Text + "\n");
            string gender = null;
            if (radioButton1.Checked)
            {
                gender = radioButton1.Text;
            }
            else if(radioButton2.Checked)
            {
                gender = radioButton2.Text;
            }
            sb.Append("Gendre: " + gender + "\n");
            sb.Append("Cuntry: " + comboBox1.Text + "\n");
            sb.Append("City: "+ comboBox2.Text + "\n");
            label8.Text = sb.ToString();
            label9.Text = dateTimePicker1.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = " ";
            switch (comboBox1.Text)
            {
                case "India":
                    comboBox2.Items.Add("Mumbai");
                    comboBox2.Items.Add("Nagpur");
                    break;

                case "U.S.A":
                    comboBox2.Items.Add("LA");
                    comboBox2.Items.Add("California");
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = " ";
        }
    }
}

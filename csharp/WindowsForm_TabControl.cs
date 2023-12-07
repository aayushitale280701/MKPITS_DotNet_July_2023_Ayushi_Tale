using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_TabControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Name: " + textBox1.Text + "\n");
            sb.Append("Addres: "+ textBox2.Text + "\n");
            sb.Append("Phone No: " + maskedTextBox1 + "\n");
            sb.Append("Email: "+ textBox3.Text + "\n");
            sb.Append("Occupation" + textBox4.Text + "\n");
            sb.Append("Gender: "+radioButton1.Text + "\n");
            string gender = null;
            if (radioButton1.Checked)
            {
                gender = radioButton1.Text;
            }
            else if(radioButton2.Checked)
            {
                gender = radioButton2.Text;
            } 
            sb.Append("State: "+comboBox1.Text+ "\n");
            sb.Append("City: "+comboBox2.Text+ "\n");
            label9.Text = sb.ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = "";
            switch (comboBox1.Text)
            {
                case "Maharashtra":
                    comboBox2.Items.Add("Mumbai");
                    comboBox2.Items.Add("Akola");
                    comboBox2.Items.Add("Pune");
                    break; 

                case "M.P":
                    comboBox2.Items.Add("Balaghat");
                    comboBox2.Items.Add("Khandwa");
                    comboBox2.Items.Add("Betul");
                    break;

                case "J&K":
                    comboBox2.Items.Add("Ladakh");
                    comboBox2.Items.Add("Kargil");
                    comboBox2.Items.Add("Kupwara");
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Name: "+textBox5.Text+ "\n");
            sb.Append("Date: "+maskedTextBox3.Text+ "\n");
            sb.Append("Phone No: "+ maskedTextBox2.Text+ "\n");
            sb.Append("Email: "+textBox6.Text+ "\n");
            sb.Append("Address: " + textBox7.Text + "\n");
            sb.Append("Company Name: "+textBox8.Text + "\n");
            label17.Text = sb.ToString();
        }

        
    }
}

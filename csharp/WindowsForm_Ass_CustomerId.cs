using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_Ass_CustomerId
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Customer Name: " + textBox1.Text + "\n");
            sb.Append("Customer Mo.No: " + maskedTextBox1.Text + "\n");
            sb.Append("Product Category: " + comboBox1.Text + "\n");
            sb.Append("Product Item: " + comboBox2.Text + "\n");
            sb.Append("Quantity: " + textBox2.Text + "\n");
            sb.Append("Rate: " + textBox3.Text + "\n");


            int Quantity = Convert.ToInt32(textBox2.Text);
            int Rate = Convert.ToInt32(textBox3.Text);
            int total = Quantity * Rate;

            label7.Text = sb.ToString();
            label9.Text = ("Total: " + total + "\n");
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to Guruji Mart...!");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox2.Text = " ";
            switch (comboBox1.Text)
            {
                case "Electronics":
                    comboBox2.Items.Add("Mobile");
                    comboBox2.Items.Add("T.V");
                    comboBox2.Items.Add("Spekar");
                    comboBox2.Items.Add("Microoven");
                    break;

                case "Sports":
                    comboBox2.Items.Add("Nutrition");
                    comboBox2.Items.Add("Bat");
                    comboBox2.Items.Add("Shoes");
                    comboBox2.Items.Add("Fitness Equipment");
                   break;

                case "House Hold":
                    comboBox2.Items.Add("Decorate");
                    comboBox2.Items.Add("Clocks");
                    comboBox2.Items.Add("Mirrors");
                    comboBox2.Items.Add("Wall Art");
                    break;
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

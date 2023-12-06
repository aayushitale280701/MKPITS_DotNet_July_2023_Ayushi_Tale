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
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int bal = 1000;
            int amount = Convert.ToInt32(textBox2.Text);
            StringBuilder sb = new StringBuilder();
            sb.Append("Account No: " +textBox1.Text +"\n");
            sb.Append("Ammount: " + amount + "\n");

            if (radioButton1.Checked)
            {
                bal = bal + amount;
                //sb.Append("Ammount deposit successfully...!" + bal + "\n");
            }
            else if (radioButton2.Checked)
            {
                bal = bal - amount;


                sb.Append("Amount withdrawl successfully...!");
            }


            else
            {

                sb.Append("Insufficent balance...!");
            }
            sb.Append("Balance: " + bal+"\n");
            label4.Text = sb.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
            textBox2.Text = " ";
            
        }
    }
}

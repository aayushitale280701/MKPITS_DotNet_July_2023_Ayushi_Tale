using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_vowel_or_not
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char ch;
            ch=Convert.ToChar(textBox1.Text);

            if(ch=='a'|| ch=='e' ||  ch=='i' || ch=='o' || ch=='u')
            {
                label2.Text = "Character are vowel.";
            }
            else if (ch == 'A' || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')
            {
                label2.Text = "Character are vowel.";
            }
            else
            {
                label2.Text = "Character are not vowel.";
            }
        }
    }
}

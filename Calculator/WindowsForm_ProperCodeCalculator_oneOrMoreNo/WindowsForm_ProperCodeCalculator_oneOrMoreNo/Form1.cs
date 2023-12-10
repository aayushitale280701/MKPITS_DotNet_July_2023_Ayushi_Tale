using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForm_ProperCodeCalculator_oneOrMoreNo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            int res = 0;
            switch(op)
            {
                case "+":
                    res = pn + Convert.ToInt32(textBox1.Text);
                    break;

                case "-":
                    res = pn - Convert.ToInt32(textBox1.Text);
                    break;

                case "*":
                    res = pn * Convert.ToInt32(textBox1.Text);
                    break;

                case "/":
                    res = pn / Convert.ToInt32(textBox1.Text);
                    break;

                case "%":
                    res = pn % Convert.ToInt32(textBox1.Text);
                    break;

                case "Cube":
                    res = pn * pn * pn;
                    break;
            }
            textBox1.Text = res.ToString();
        }
        string op = null;
        int pn = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="")
            {
                textBox1.Text = "1";
            }
            else
            {
                if(op != null)
                {
                    if(textBox1.Text == "+" ||  textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/" || textBox1.Text == "%")
                    {
                        textBox1.Clear();
                        textBox1.Text = textBox1.Text + "1";
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + "1";
                    }
                }
                else
                {
                    textBox1.Text = textBox1.Text + "1";
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "2";
            }
            else
            {
                if (op != null)
                {
                    if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/" || textBox1.Text == "%")
                    {
                        textBox1.Clear();
                        textBox1.Text = textBox1.Text + "2";
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + "2";
                    }
                }
                else
                {
                    textBox1.Text = textBox1.Text + "2";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "3";
            }
            else
            {
                if (op != null)
                {
                    if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/" || textBox1.Text == "%")
                    {
                        textBox1.Clear();
                        textBox1.Text = textBox1.Text + "3";
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + "3";
                    }
                }
                else
                {
                    textBox1.Text = textBox1.Text + "3";
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "4";
            }
            else
            {
                if (op != null)
                {
                    if (textBox1.Text == "4" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/" || textBox1.Text == "%")
                    {
                        textBox1.Clear();
                        textBox1.Text = textBox1.Text + "4";
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + "4";
                    }
                }
                else
                {
                    textBox1.Text = textBox1.Text + "4";
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "5";
            }
            else
            {
                if (op != null)
                {
                    if (textBox1.Text == "+" || textBox1.Text == "-"|| textBox1.Text == "*" || textBox1.Text == "/" || textBox1.Text =="%")
                    {
                        textBox1.Clear();
                        textBox1.Text = textBox1.Text + "5";
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + "5";
                    }
                }
                else
                {
                    textBox1.Text = textBox1.Text + "5";
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "6";
            }
            else
            {
                if (op != null)
                {
                    if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/" || textBox1.Text == "%")
                    {
                        textBox1.Clear();
                        textBox1.Text = textBox1.Text + "6";
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + "6";
                    }
                }
                else
                {
                    textBox1.Text = textBox1.Text + "6";
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "7";
            }
            else
            {
                if (op != null)
                {
                    if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/" || textBox1.Text == "%")
                    {
                        textBox1.Clear();
                        textBox1.Text = textBox1.Text + "7";
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + "7";
                    }
                }
                else
                {
                    textBox1.Text = textBox1.Text + "7";
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "8";
            }
            else
            {
                if (op != null)
                {
                    if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/" || textBox1.Text == "%")
                    {
                        textBox1.Clear();
                        textBox1.Text = textBox1.Text + "8";
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + "8";
                    }
                }
                else
                {
                    textBox1.Text = textBox1.Text + "8";
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "9";
            }
            else
            {
                if (op != null)
                {
                    if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/" || textBox1.Text == "%")
                    {
                        textBox1.Clear();
                        textBox1.Text = textBox1.Text + "9";
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + "9";
                    }
                }
                else
                {
                    textBox1.Text = textBox1.Text + "9";
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
            }
            else
            {
                if (op != null)
                {
                    if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/" || textBox1.Text == "%")
                    {
                        textBox1.Clear();
                        textBox1.Text = textBox1.Text + "0";
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + "0";
                    }
                }
                else
                {
                    textBox1.Text = textBox1.Text + "0";
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
        }
        
        private void button12_Click(object sender, EventArgs e)
        {
            pn = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "%";
            op = "%";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            pn = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "*";
            op = "*";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            pn = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "+";
            op = "+";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            pn = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "-";
            op = "-";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            pn = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "/";
            op = "/";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = ".";
            }
            else
            {
                if (op != null)
                {
                    if (textBox1.Text == "+" || textBox1.Text == "-" || textBox1.Text == "*" || textBox1.Text == "/" || textBox1.Text == "%")
                    {
                        textBox1.Clear();
                        textBox1.Text = textBox1.Text + ".";
                    }
                    else
                    {
                        textBox1.Text = textBox1.Text + ".";
                    }
                }
                else
                {
                    textBox1.Text = textBox1.Text + ".";
                }
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            pn = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "Cube";
            op = "Cube";
        }
    }
}

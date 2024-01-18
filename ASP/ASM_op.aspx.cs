using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication_AMS_op
{
    public partial class ASM_op : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            System.Text.StringBuilder sb = new System.Text.StringBuilder(); 
            int num1 = Convert.ToInt32(TextBox1.Text);
            int num2 = Convert.ToInt32(TextBox2.Text);
            int add = 0;
            int mul = 0;
            int sub = 0;

            if (CheckBox1.Checked)
            {
                add = num1 + num2;
            }
            if (CheckBox2.Checked)
            {
                mul = num2 * num1;
            }
            if (CheckBox3.Checked)
            {
                sub = num1 - num2;
            }
            sb.Append("Addition is : " + add.ToString() + "<br>");
            sb.Append("Multiplication is : " + mul.ToString() + "<br>");
            sb.Append("Substration is : " + sub.ToString() + "<br>");
        }
    }
}
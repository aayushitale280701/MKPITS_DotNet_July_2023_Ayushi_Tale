using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication_ass_Account
{
    public partial class Account : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int bal = 1000;
            int act = Convert.ToInt32(TextBox1.Text);
            int amt = Convert.ToInt32(TextBox2.Text);

            if (RadioButton1.Checked)
            {
                bal = bal + amt;
            }
            else if(RadioButton2.Checked)
            {
                bal = bal - amt;
            }
            Label1.Text = "Balance is " + bal.ToString();
        }
    }
}
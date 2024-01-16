using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication_doWhile_N_no
{
    public partial class DoWhile_N_no : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(TextBox1.Text);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            int i = 1;

            do
            {
                sb.Append(i + "<br>");
                i++;
            }
            while (i <= num);
            Label1.Text = sb.ToString();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication_area_OFrectangle
{
    public partial class AREAofRECTANGLE : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int length = Convert.ToInt32(TextBox1.Text);
            int breadth = Convert.ToInt32(TextBox2.Text);
            //int res = 1;
            int area = length * breadth;
            Label1.Text = area.ToString();
        }
    }
}
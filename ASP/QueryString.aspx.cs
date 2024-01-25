using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QueryString
{
    public partial class QueryString : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string username = Request.QueryString["Uname"].ToString();
            Label1.Text = username;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("QueryString.aspx?uname: " + TextBox1.Text);
        }
    }
}
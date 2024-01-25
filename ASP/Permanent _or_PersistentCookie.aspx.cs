using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ClintSideStateManagement_Temporary_cookie
{
    public partial class Permanent__or_PersistentCookie : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            HttpCookie C11 = new HttpCookie("Cook");
            C11.Values.Add("Username",TextBox1.Text);
            C11.Values.Add("Email",TextBox2.Text);
            DateTime dt = DateTime.Now;
            TimeSpan ts = new TimeSpan(0, 2, 0);
            C11.Expires = dt.Add(ts);
            Label1.Text ="Permanent cookies added to client machine...";
            Response.Cookies.Add(C11);  

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            HttpCookie C11 = Request.Cookies["Cook"];
            if (C11 != null)
            {
                string name = C11.Values["Username"].ToString();
                string email = C11.Values["Email"].ToString();
                Label1.Text = "Username: " + name;
                Label2.Text = "Email: " + email;
            }
            else
            {
                Label1.Text ="No Permanent Cookies Exits...";
            }
        }
    }
}
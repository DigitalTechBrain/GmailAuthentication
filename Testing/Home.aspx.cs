using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Testing
{
    public partial class Home : System.Web.UI.Page
    {
       

        protected void Page_Load(object sender, EventArgs e)
        {

            Label1.Text = Cache["id"].ToString();
            Label2.Text = Cache["name"].ToString();
            Label3.Text = Cache["given_name"].ToString();
            Label4.Text = Cache["picture"].ToString();

        }
    }
}
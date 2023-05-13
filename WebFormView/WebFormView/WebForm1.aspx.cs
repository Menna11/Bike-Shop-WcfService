using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormView
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.ViewAndUpdateServicesClient obj = new ServiceReference1.ViewAndUpdateServicesClient();
            string addy = obj.viewAddress(0);
            Label1.Text=addy;

            string name = obj.viewName(0);
            Label2.Text = name;
        }
    }
}
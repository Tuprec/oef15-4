using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace oef15_4
{
    public partial class Kalender : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack)
            {
                lblDATE.Text = Convert.ToString(Calendar.SelectedDate.ToLongDateString());
            }
        }
    }
}
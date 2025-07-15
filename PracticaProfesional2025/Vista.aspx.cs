using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticaProfesional2025
{
    public partial class Vista : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string idSession = Session["Usuario"].ToString();

            if (idSession == String.Empty)
                Response.Redirect("Login.aspx");
        }
    }
}
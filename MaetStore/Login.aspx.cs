using MaetStore.Database_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MaetStore
{
    public partial class Login : System.Web.UI.Page
    {
        DatabaseLogin dbLogin = new DatabaseLogin();

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void ProceedLogin(object sender, EventArgs e)
        {
            if (dbLogin.Login(username.Text, password.Text))
            {
                Response.Redirect("~/Default.aspx");
            }

        }
    }
}
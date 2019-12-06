using MaetStore.Database_Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MaetStore
{
    public partial class Register : System.Web.UI.Page
    {
        DatabaseLogin db = new DatabaseLogin();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ProceedRegister(object sender, EventArgs e)
        {
            if (username.Text.Length > 5 && password.Text.Length > 5)
            {
                db.Register(username.Text, password.Text);
            }
        }
    }
}
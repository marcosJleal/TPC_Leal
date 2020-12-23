using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;

namespace TPC_Leal
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        public Usuario user;
        protected void Page_Load(object sender, EventArgs e)
        {
         
            if (!Page.IsPostBack)
            {
                
                user = new Usuario();
                user = (Usuario)Session[Session.SessionID + "Login"];
                
            }
            if (user == null)
            {
                user = new Usuario();
            }
        }
    }
}
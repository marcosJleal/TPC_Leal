using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;
namespace TPC_Leal
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        public List<Articulo> listado;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            try
            {
                //Usuario usuario = (Usuario)Session["Login"];
                //if(usuario == null)
                //{
                //    Response.Redirect("Login.aspx");
                //}
                ArticuloNegocio negocio = new ArticuloNegocio();
                listado = negocio.listarDestacados();
            }
            catch (Exception)
            {

                throw;
            }

        }

    }

}

       
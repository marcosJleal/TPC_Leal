using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;
namespace TPC_Leal
{
    public partial class PruebaEliminarUsuario : System.Web.UI.Page
    {
        public Usuario usuario { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            usuario = new Usuario();
            UsuarioNegocio negocio = new UsuarioNegocio();
            usuario.IdUsuario = Convert.ToInt32(txtID.Text);
            negocio.EliminarUsuario(usuario);
            Response.Redirect("default.aspx");
        }
    }
}
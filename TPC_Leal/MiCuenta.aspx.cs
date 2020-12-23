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
    public partial class MiCuenta : System.Web.UI.Page
    {
        Usuario user;
        List<Usuario> lista;
        protected void Page_Load(object sender, EventArgs e)
        {
            Usuario usuario = (Usuario)Session[Session.SessionID+"Login"];
            if (usuario == null)
            {
                Response.Redirect("Login.aspx");
            }
            try
            {
                //user = new Usuario();
                user =(Usuario)Session[Session.SessionID+"Login"];
                //UsuarioNegocio negocio = new UsuarioNegocio();
                //user = negocio.Listar(user);
                //Session[Session.SessionID + "Login"] = user;
                lblApellido.Text = user.Apellido;
                lblNombre.Text = user.Nombre;
                lblDni.Text = user.DNI;
                lblEmail.Text = user.Email;

                
            }
            catch (Exception)
            {

                throw;
            }

        }

        protected void btnPedidos_Click(object sender, EventArgs e)
        {
            Response.Redirect("MisPedidos.aspx");
        }
    }
}
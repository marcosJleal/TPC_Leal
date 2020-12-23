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
    public partial class WebForm5 : System.Web.UI.Page
    {
        public Usuario user = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCrear_Click(object sender, EventArgs e)
        {
            UsuarioNegocio negocio = new UsuarioNegocio();
            if(user==null)
            {
                user = new Usuario();
            }
            user.Nombre = txtNombre.Text;
            user.Apellido = txtApellido.Text;
            user.DNI = txtDNI.Text;
            user.Email = txtEmail.Text;
            user.Contraseña = TxtContraseña.Text;
            negocio.AltaUsuario(user);
            Response.Redirect("Login.aspx");
        }
    }
}
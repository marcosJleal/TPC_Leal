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
    public partial class Login : System.Web.UI.Page
    {
        public List<Usuario> listado;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGO_Click(object sender, EventArgs e)
        {
            try
            {
                
                Usuario usuario = new Usuario();
                UsuarioNegocio negocio = new UsuarioNegocio();
                usuario.Email = txtEmail.Text;
                usuario.Contraseña = txtContraseña.Text;
                negocio.Login(usuario);
                
                if (usuario.IdUsuario != 0)
                {
                    listado = negocio.Listar();
                    usuario= listado.Find(J => J.Email == Convert.ToString(txtEmail.Text));
                    Session.Add(Session.SessionID+"Login", usuario);
                    Response.Redirect("Productos.aspx");
                }
                else
                {
                    Response.Redirect("ErrorLogin.aspx");
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
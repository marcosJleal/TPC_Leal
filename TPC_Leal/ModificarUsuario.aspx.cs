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
    public partial class PruebaModificarUsuario : System.Web.UI.Page
    {
        public Usuario UserDetalle { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            UsuarioNegocio negocio = new UsuarioNegocio();
            List<Usuario> listado;
            try
            {
                listado = negocio.Listar();
                var user = Request.QueryString["iduser"];
                UserDetalle = listado.Find(J => J.IdUsuario == Int64.Parse(user));
                if (!Page.IsPostBack)
                {
                    txtNombre.Text = UserDetalle.Nombre;
                    txtApellido.Text = UserDetalle.Apellido;
                    txtEmail.Text = UserDetalle.Email;
                    TxtContraseña.Text = UserDetalle.Contraseña;
                    txtDNI.Text= UserDetalle.DNI;
                    
                   
                    
                }
            }
            catch (Exception ex)
            {

                throw ex;

            }

        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Usuario usuarioModificado = new Usuario();
                usuarioModificado.IdUsuario = UserDetalle.IdUsuario;
                usuarioModificado.Nombre = txtNombre.Text;
                usuarioModificado.Apellido = txtApellido.Text;
                usuarioModificado.DNI = txtDNI.Text;
                usuarioModificado.Email = txtEmail.Text;
                usuarioModificado.Contraseña = TxtContraseña.Text;
               

                UsuarioNegocio negocio = new UsuarioNegocio();
                negocio.ModificarUsuario(usuarioModificado);
                Response.Redirect("ABMUsuarios.aspx");

            }
            catch (Exception ex)
            {

                throw ex;
            }


        }
    }
}
using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPC_Leal
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        List<Usuario> listado;
        public Usuario Usuario { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
			try
			{
				UsuarioNegocio negocio = new UsuarioNegocio();
				listado = negocio.Listar();
				dgvUsuarios.DataSource = listado;
				dgvUsuarios.DataBind();
			}
			catch (Exception)
			{

				throw;
			}
		}
		protected void dgvUsuarios_SelectedIndexChanged(object sender, EventArgs e)
		{


		}
		protected void dgvUsuarios_RowCommand(object sender, GridViewCommandEventArgs e)
		{
			if (e.CommandName == "Select")
			{
				int index = Convert.ToInt32(e.CommandArgument);
				string idUser = dgvUsuarios.Rows[index].Cells[0].Text;
				Usuario = new Usuario ();
				Usuario = listado.Find(J => J.IdUsuario == Convert.ToInt64(idUser));
				UsuarioNegocio negocio = new UsuarioNegocio();
				negocio.EliminarUsuario(Usuario);
				Response.Redirect("ABMUsuarios.aspx");
			}
			else
			{
				int index = Convert.ToInt32(e.CommandArgument);
				string idUser = dgvUsuarios.Rows[index].Cells[0].Text;
				Usuario = new Usuario();
				Usuario = listado.Find(J => J.IdUsuario == Convert.ToInt64(idUser));
				Response.Redirect("ModificarUsuario.aspx?iduser=" + Usuario.IdUsuario);

			}
		}
	}
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;


namespace TPC_Leal
{
    public partial class AMBArticulos : System.Web.UI.Page
    {
		List<Articulo> listado;
		public Articulo articulo { get; set; }
		protected void Page_Load(object sender, EventArgs e)
        {
			try
			{
				if (!Page.IsPostBack)
				{
					ArticuloNegocio negocio = new ArticuloNegocio();
					listado = negocio.listar();
					dgvArticulos.DataSource = listado;
					dgvArticulos.DataBind();
				}
			}
			catch (Exception)
			{

				throw;
			}
        }

		protected void dgvArticulos_SelectedIndexChanged(object sender, EventArgs e)
		{
			
		
		}
		protected void dgvArticulos_RowCommand(object sender, GridViewCommandEventArgs e)
		{
			if (e.CommandName == "Select")
			{
				ArticuloNegocio negocio = new ArticuloNegocio();
				listado = negocio.listar();
				int index = Convert.ToInt32(e.CommandArgument);
				string idArt = dgvArticulos.Rows[index].Cells[0].Text;
				articulo = new Articulo();
				articulo = listado.Find(J => J.IdArticulo == Convert.ToInt64(idArt));
				
				negocio.Eliminar(articulo);
				Response.Redirect("ABMArticulos.aspx");
			}
			if(e.CommandName == "Select2")
			{
				ArticuloNegocio negocio = new ArticuloNegocio();
				listado = negocio.listar();
				int index = Convert.ToInt32(e.CommandArgument);
				string idArt = dgvArticulos.Rows[index].Cells[0].Text;
				articulo = new Articulo();
				articulo = listado.Find(J => J.IdArticulo == Convert.ToInt64(idArt));
				Response.Redirect("ModificarArticulo.aspx?idart="+articulo.IdArticulo);

			}
			if (e.CommandName == "Select3")
			{
				ArticuloNegocio negocioEliminado = new ArticuloNegocio();
				listado = negocioEliminado.listarEliminados();
				int index = Convert.ToInt32(e.CommandArgument);
				string idArt = dgvArticulos.Rows[index].Cells[0].Text;
				articulo = new Articulo();
				articulo = listado.Find(J => J.IdArticulo == Convert.ToInt64(idArt));
				ArticuloNegocio negocio = new ArticuloNegocio();
				negocio.Restaurar(articulo);
				Response.Redirect("ABMArticulos.aspx");
			}
			else
			{
				ArticuloNegocio negocio = new ArticuloNegocio();
				listado = negocio.listar();
				int index = Convert.ToInt32(e.CommandArgument);
				string idArt = dgvArticulos.Rows[index].Cells[0].Text;
				articulo = new Articulo();
				articulo = listado.Find(J => J.IdArticulo == Convert.ToInt64(idArt));
				if(articulo.Destacado == false)
				{
					articulo.Destacado = true;
				}
				else
				{
					articulo.Destacado = false;
				}
				negocio.Destacar(articulo);
				Response.Redirect("ABMArticulos.aspx");
			}
		}

		protected void btnEliminados_Click(object sender, EventArgs e)
		{
			ArticuloNegocio negocio = new ArticuloNegocio();
			dgvArticulos.DataSource = negocio.listarEliminados();
			dgvArticulos.DataBind();
		}
	}
}
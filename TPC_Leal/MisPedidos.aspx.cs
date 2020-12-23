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
	public partial class MisPedidos : System.Web.UI.Page
	{
		public Usuario user;
		public List<Pedido> listado;
		public Pedido pedido;
		protected void Page_Load(object sender, EventArgs e)
		{
			try
			{
				Usuario usuario = (Usuario)Session[Session.SessionID + "Login"];
				if (usuario == null)
				{
					Response.Redirect("Login.aspx");
				}
				user = new Usuario();
				user = (Usuario)Session[Session.SessionID + "Login"];
				PedidoNegocio negocio = new PedidoNegocio();
				listado = negocio.listar(user);
				dgvPedidos.DataSource = listado;
				dgvPedidos.DataBind();
			}
			catch (Exception)
			{
				Response.Redirect("ErrorSinPedidos.aspx");
				
			}
		

		}

		protected void dgvPedidos_SelectedIndexChanged(object sender, EventArgs e)
		{


		}
		protected void dgvPedidos_RowCommand(object sender, GridViewCommandEventArgs e)
		{
			if (e.CommandName == "Select")
			{

				int index = Convert.ToInt32(e.CommandArgument);
				string idPedido = dgvPedidos.Rows[index].Cells[0].Text;
				pedido = new Pedido();
				pedido = listado.Find(J => J.ID == Convert.ToInt64(idPedido));
				Session.Add(Session.SessionID + "pedido", pedido);
				Response.Redirect("DetallePedido.aspx");
			}
		}
	}
}
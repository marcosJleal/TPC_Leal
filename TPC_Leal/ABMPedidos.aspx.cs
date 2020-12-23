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
    public partial class ABMPedidos : System.Web.UI.Page
    {
		public Pedido pedido { get; set; }
		public List<Pedido> listado;
		protected void Page_Load(object sender, EventArgs e)
        {
			PedidoNegocio negocio = new PedidoNegocio();
			listado = negocio.listar();
			dgvPedidos.DataSource = listado;
			dgvPedidos.DataBind();
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
				pedido.Estado.IdEstado += 1;
				PedidoNegocio negocio = new PedidoNegocio();
				negocio.actualizar(pedido);
				Response.Redirect("ABMPedidos.aspx");
			}
			else
			{
				int index = Convert.ToInt32(e.CommandArgument);
				string idPedido = dgvPedidos.Rows[index].Cells[0].Text;
				pedido = new Pedido();
				pedido = listado.Find(J => J.ID == Convert.ToInt64(idPedido));
				Session.Add(Session.SessionID+"pedido",pedido);
				Response.Redirect("DetallePedido.aspx");


				
			}
		}
	}
}
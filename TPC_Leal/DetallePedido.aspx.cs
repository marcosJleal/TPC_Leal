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
    public partial class DetallePedido : System.Web.UI.Page
    {
        public List<Detalle> listado;
        public List<Estado> seguimiento;
        public Detalle detalle;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Pedido pedido = new Pedido();
                DetalleNegocio detallenegocio = new DetalleNegocio();
                pedido = (Pedido)Session[Session.SessionID + "pedido"];
                listado = detallenegocio.listar(pedido);
                Session.Add("listaDetalles", listado);
                dgvDetalles.DataSource = listado;
                dgvDetalles.DataBind();
                EstadoNegocio estadonegocio = new EstadoNegocio();
                seguimiento = estadonegocio.listar(pedido);
                dgvSeguimiento.DataSource = seguimiento;
                dgvSeguimiento.DataBind();

            }
            catch (Exception)
            {

                throw;
            }
        }
        protected void dgvDetalles_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
        protected void dgvDetalles_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            //if (e.CommandName == "Select")
            //{
            //	int index = Convert.ToInt32(e.CommandArgument);
            //	string idDetalle = dgvDetalles.Rows[index].Cells[0].Text;
            //	detalle = new Detalle();
            //	listado =(List<Detalle>)Session["listaDetalles"];
            //	detalle = listado.Find(J => J.ID == Convert.ToInt64(idDetalle));
            //	DetalleNegocio negocio = new DetalleNegocio();

            //	if(detalle.pedido.Estado.IdEstado == 3)
            //	{
            //		negocio.DescontarStock(detalle);
            //	}




        }

    }
}

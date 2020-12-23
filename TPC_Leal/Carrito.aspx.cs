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
    public partial class Carrito : System.Web.UI.Page
    {
        public List<ItemCarro> listaCarro;
        public Usuario user { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (listaCarro == null)
                {
                    listaCarro = new List<ItemCarro>();
                    user = new Usuario();
                    
                }
                if((List<ItemCarro>)Session[Session.SessionID + "carro"]!=null)
                {
                    listaCarro = (List<ItemCarro>)Session[Session.SessionID + "carro"];
                    user = (Usuario)Session[Session.SessionID+"Login"];
                }

                //Quitar producto
                var quitar = Request.QueryString["idquitar"];
                if (quitar != null)
                {
                    ItemCarro carroremover = new ItemCarro();
                    ItemCarro remover = listaCarro.Find(J => J.articulo.IdArticulo == int.Parse(quitar));
                    listaCarro.Remove(remover);
                    Session[Session.SessionID + "carro"] = listaCarro;
                }

                //Sumar cantidad
                var cant = Request.QueryString["idsumcantidad"];
                if (cant != null)
                {
                    ItemCarro sumarcant = listaCarro.Find(J => J.articulo.IdArticulo == int.Parse(cant));
                    sumarcant.Cantidad = sumarcant.Cantidad + 1;
                    sumarcant.subtotal = sumarcant.articulo.Precio * sumarcant.Cantidad;
                    Session[Session.SessionID + "carro"] = listaCarro;

                }

                //Restar cantidad
                var resta = Request.QueryString["idrestcantidad"];
                if (resta != null)
                {
                    ItemCarro restarcant = listaCarro.Find(J => J.articulo.IdArticulo == int.Parse(resta));
                    if (restarcant.Cantidad > 1)
                    {
                        restarcant.Cantidad = restarcant.Cantidad - 1;
                        restarcant.subtotal = restarcant.articulo.Precio * restarcant.Cantidad;
                        Session[Session.SessionID + "carro"] = listaCarro;
                    }
                }


                //Acumulador de total
                decimal total = 0;
                foreach (var prod in listaCarro)
                {
                    total = prod.subtotal + total;

                }
                lblTotal.Text = /*"$" + */total.ToString();
            }
            catch (Exception)
            {

                throw;
            }
            

        }

        protected void btnFinalizarCompra_Click(object sender, EventArgs e)
        {
            if (listaCarro.Count() != 0)
            {
                Pedido pedido = new Pedido();
                PedidoNegocio pedidoNegocio = new PedidoNegocio();
                Carro carro = new Carro();
                carro.listaItems = new List<ItemCarro>();
                carro.listaItems = listaCarro;
                carro.Subtotal = Convert.ToDecimal(lblTotal.Text);
                pedido.Usuario = new Usuario();
                user= (Usuario)Session[Session.SessionID+"Login"];
                pedido.Usuario = user;
                pedido.Carro = new Carro();
                pedido.Carro = carro;
                pedido.Estado = new Estado();
                pedido.Estado.IdEstado = 8;
                pedido.Fecha = DateTime.Today;
                pedidoNegocio.Enviar(pedido);
                Response.Redirect("PedidoRealizado.aspx");
            }
            else
            {
                lblCarro.Text = "El carro esta vacio!!";
            }

        }
    }
}
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
    public partial class WebForm3 : System.Web.UI.Page
    {
        public Articulo ProdDetalle { get; set; }
        public List<ItemCarro> listaCarro;
        protected void Page_Load(object sender, EventArgs e)
        {

            Usuario usuario = (Usuario)Session[Session.SessionID + "Login"];
            if (usuario == null)
            {
                Response.Redirect("Login.aspx");
            }
            ArticuloNegocio negocio = new ArticuloNegocio();
            List<Articulo> listado;
            try
            {
                listado = negocio.listar();
                var prod = Request.QueryString["idart"];
               ProdDetalle = listado.Find(J => J.IdArticulo == Int64.Parse(prod));
                if(!Page.IsPostBack)
                {
                    txtCantidad.Text =Convert.ToString(1);
                    cboColores.DataSource = ProdDetalle.Colores;
                    cboColores.DataTextField = "Nombre";
                    cboColores.DataValueField = "IdColor"; 
                    cboColores.DataBind();
                }
            }
            catch (Exception ex)
            {

                throw ex;

            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if ((List<ItemCarro>)Session[Session.SessionID + "carro"] == null)
                {
                    listaCarro = new List<ItemCarro>();
                }
                else
                {
                    listaCarro = (List<ItemCarro>)Session[Session.SessionID + "carro"];
                }
                ItemCarro item = new ItemCarro();
                item.Color = new Color();
                item.articulo = new Articulo();
                item.articulo = ProdDetalle;
                item.Color.IdColor= int.Parse(cboColores.SelectedItem.Value);
                item.Cantidad = Convert.ToInt32(txtCantidad.Text);
                item.subtotal = Convert.ToDecimal(item.articulo.Precio * item.Cantidad);
                listaCarro.Add(item);
                Session[Session.SessionID + "carro"] = listaCarro;
                Response.Redirect("Carrito.aspx");

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
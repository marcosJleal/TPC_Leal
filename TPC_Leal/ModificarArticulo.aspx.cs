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
    public partial class WebForm4 : System.Web.UI.Page
    {
        public Articulo ProdDetalle { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            List<Articulo> listado;
            try
            {
                listado = negocio.listar();
                var prod = Request.QueryString["idart"];
                ProdDetalle = listado.Find(J => J.IdArticulo == Int64.Parse(prod));
                if(!Page.IsPostBack)
                { 
                txtDescripcion.Text = ProdDetalle.Descripcion;
                txtNombre.Text = ProdDetalle.Nombre;
                txtPrecio.Text = ProdDetalle.Precio.ToString();
                txtStock.Text = ProdDetalle.Stock.ToString();
                txtUrlImagen.Text = ProdDetalle.UrlImagen;
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
                Articulo articuloModificado = new Articulo();
                articuloModificado.IdArticulo = ProdDetalle.IdArticulo;
                articuloModificado.Nombre = txtNombre.Text;
                articuloModificado.Stock = Convert.ToInt32(txtStock.Text);
                articuloModificado.Descripcion = txtDescripcion.Text;
                articuloModificado.UrlImagen = txtUrlImagen.Text;
                articuloModificado.Precio = Convert.ToDecimal(txtPrecio.Text);

                ArticuloNegocio negocio = new ArticuloNegocio();
                negocio.Modificar(articuloModificado);
                Response.Redirect("ABMArticulos.aspx");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
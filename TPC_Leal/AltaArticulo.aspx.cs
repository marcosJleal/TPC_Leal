using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Protocols;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace TPC_Leal
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        private Articulo articulo = null;
        List<Color> colores;
        List<Color> listadoColores;
        List<Categoria> listaCategoria;
        protected void Page_Load(object sender, EventArgs e)
        {
           
            try
            {
                CategoriaNegocio categorianegocio = new CategoriaNegocio();
                ColorNegocio colornegocio = new ColorNegocio();
                List<Color> listadoColores = new List<Color>();
                listadoColores = colornegocio.Listar();
                Session[Session.SessionID + "listadoColores"] = listadoColores;
                listaCategoria = categorianegocio.Listar();
                if (!Page.IsPostBack)
                {
                    cboColores.DataSource = listadoColores;
                    cboColores.DataTextField = "Nombre";
                    cboColores.DataValueField = "IdColor";
                    cboColores.DataBind();
                    cboCategorias.DataSource = listaCategoria;
                    cboCategorias.DataTextField = "Nombre";
                    cboCategorias.DataValueField = "IdCategoria";
                    cboCategorias.DataBind();
                  
                }
               
            }
            catch (Exception)
            {

                throw;
            }
        
          
        }
        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if(articulo==null)
                {
                    articulo = new Articulo();
                }
                articulo.Nombre = txtNombre.Text;
                articulo.Destacado = false;
                articulo.Stock = Convert.ToInt32(txtStock.Text);
                articulo.Descripcion = txtDescripcion.Text;
                articulo.UrlImagen = txtUrlImagen.Text;
                articulo.Precio = Convert.ToDecimal(txtPrecio.Text);
                articulo.Colores = new List<Color>();
                colores= (List<Color>)Session[Session.SessionID + "Colores"];
                articulo.Colores = colores;
                articulo.Categoria = new Categoria();
                articulo.Categoria.IdCategoria = int.Parse(cboCategorias.SelectedItem.Value);
                ArticuloNegocio negocio = new ArticuloNegocio();
                negocio.agregar(articulo);
                colores = new List<Color>();
                Session[Session.SessionID + "Colores"]=colores;
                Response.Redirect("ABMArticulos.aspx");

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        protected void btnAgregarColor_Click(object sender, EventArgs e)
        {
            listadoColores= (List<Color>)Session[Session.SessionID + "listadoColores"];
            colores =(List<Color>)Session[Session.SessionID + "Colores"];
            if (colores ==null)
            {
                colores = new List<Color>();
            }
            Color aux = new Color();
            aux = listadoColores.Find(J=>J.IdColor == int.Parse(cboColores.SelectedItem.Value));
            aux.Cantidad =Convert.ToInt32(txtCantidad.Text);
            colores.Add(aux);
          Session[Session.SessionID + "Colores"] = colores;
            dgvColores.DataSource = colores;
            dgvColores.DataBind();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;
namespace TPC_Leal
{
    public partial class Productos : System.Web.UI.Page
    {
        public List<Articulo> listado;
        public List<Categoria> listaCat;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
               
                ArticuloNegocio negocio = new ArticuloNegocio();
                listado = negocio.listar();
                if(!Page.IsPostBack)
                {
                    CategoriaNegocio catnegocio = new CategoriaNegocio();
                    listaCat = catnegocio.Listar();
                    ddlCategorias.DataSource = listaCat;
                    ddlCategorias.DataTextField = "Nombre";
                    ddlCategorias.DataValueField = "IdCategoria";
                    ddlCategorias.DataBind();
                    

                }

            }
            catch (Exception)
            {

                throw;
            }
         

        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negociofiltro = new ArticuloNegocio();
            int filtro = int.Parse(ddlCategorias.SelectedItem.Value);
            listado = negociofiltro.listar(filtro);
            
        }
    }
}
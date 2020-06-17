using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
   public class ArticuloNegocio
    {
       

        public List<Articulo> listar()
        {
            List<Articulo> listado = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            Articulo aux;


            try
            {
                datos.SetQuery("select ID,Nombre,Stock,Precio,Estado,Descripcion,UrlImagen from Articulos");
                datos.EjecutarLector();
                while (datos.lector.Read())
                {
                    aux = new Articulo();
                 
                    aux.Nombre = (string)datos.lector["Nombre"];
                    aux.Precio = (decimal)datos.lector["Precio"];
                    aux.Estado = (bool)datos.lector["Estado"];
                    aux.UrlImagen = (string)datos.lector["UrlImagen"];
                    aux.Stock = (int)datos.lector["Stock"];
                    aux.Descripcion=(string)datos.lector["Descripcion"];
                    aux.IdArticulo = 1;
                    listado.Add(aux);
                }

                return listado;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        finally
            {
                datos.CerrarConexion();
            }




        }
    }
}

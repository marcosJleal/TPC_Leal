using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class DetalleNegocio
    {

        public List<Detalle> listar(Pedido pedido)
        {

            List<Detalle> listado = new List<Detalle>();
            AccesoDatos datos = new AccesoDatos();
            Detalle aux;
            try
            {
                datos.SetQuery("select * from DetallePedidos_VW where  IdPedido=@Idpedido");
                datos.comando.Parameters.Clear();
                datos.AgregarParametro("@Email", pedido.Usuario.Email);
                datos.AgregarParametro("@Idpedido", pedido.ID);
                datos.EjecutarLector();
                while (datos.lector.Read())
                {
                    aux = new Detalle();
                    aux.ID =(Int32)datos.lector["ID"];
                    aux.pedido = new Pedido();
                    aux.pedido.ID =(Int64) datos.lector["IdPedido"];
                    aux.item = new ItemCarro();
                    aux.item.articulo = new Articulo();
                    aux.item.articulo.IdArticulo = (Int64)datos.lector["IdArticulo"];
                    aux.item.articulo.Nombre =(string)datos.lector["Articulo"];
                    aux.item.Color = new Color();
                    aux.item.Color.Nombre =(string)datos.lector["Color"];
                    aux.item.Cantidad =(int)datos.lector["cantidad"];
                    //aux.pedido.Usuario = new Usuario();
                    //aux.pedido.Usuario.Email =(string)datos.lector["Email"];
                    aux.item.articulo.Precio = (decimal)datos.lector["Precio"];
                    listado.Add(aux);

                }

                return listado;

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.CerrarConexion();
            }
        }

        public void DescontarStock(Detalle detalle)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearSP("DescontarStock_SP");
                datos.comando.Parameters.Clear();
                datos.AgregarParametro("@IdArticulo",detalle.item.articulo.IdArticulo);
                datos.AgregarParametro("@Cantidad", detalle.item.Cantidad);
                datos.EjecutarAccion();
                

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.CerrarConexion();
            }
           

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class PedidoNegocio
    {
        public void Enviar(Pedido pedido)
        {
            AccesoDatos datos = new AccesoDatos();
            AccesoDatos datos2 = new AccesoDatos();
            AccesoDatos datos3 = new AccesoDatos();
            AccesoDatos datos4 = new AccesoDatos();
            Int64 idpedido;
            try
            {
                datos.setearSP("NuevoPedido_SP");
                datos.comando.Parameters.Clear();
                datos.AgregarParametro("@Fecha", pedido.Fecha);
                datos.AgregarParametro("@IdUsuario",pedido.Usuario.IdUsuario);
                datos.AgregarParametro("@Total",pedido.Carro.Subtotal);
                datos.EjecutarAccion();
                datos.CerrarConexion();
                datos3.SetQuery("select ID from Pedidos where IDUsuario=@IdUsuario and Fecha=@Fecha");
                datos3.comando.Parameters.Clear();
                datos3.AgregarParametro("@IdUsuario",pedido.Usuario.IdUsuario);
                datos3.AgregarParametro("@Fecha",pedido.Fecha);
                datos3.EjecutarLector();
                datos3.lector.Read();
                idpedido = (Int64)datos3.lector["ID"];
                datos3.CerrarConexion();
                datos4.SetQuery("insert into Detalle_Estados (IdEstado,IdPedido,Fecha) values(@IdEstado,@IdPedido,@Fecha)");
                datos4.comando.Parameters.Clear();
                datos4.AgregarParametro("@IdEstado",pedido.Estado.IdEstado);
                datos4.AgregarParametro("@IdPedido",idpedido);
                datos4.AgregarParametro("@Fecha",pedido.Fecha);
                datos4.EjecutarAccion();
                datos4.CerrarConexion();
       //Necesito enviar articulos individuales con su idart su idcolor y cantidad
                    foreach (var item in pedido.Carro.listaItems)
                {
                    datos2.setearSP("NuevoDetalle_SP");
                    datos2.comando.Parameters.Clear();
                    datos2.AgregarParametro("@IdArticulo",item.articulo.IdArticulo);
                    datos2.AgregarParametro("@IdColor", item.Color.IdColor);
                    datos2.AgregarParametro("@IdPedido",idpedido);
                    datos2.AgregarParametro("@Cantidad", item.Cantidad);
                    datos2.EjecutarAccion();
                    datos2.CerrarConexion();


                }

               


            }
            catch (Exception)
            {

                throw;
            }
           
        }

        public List<Pedido> listar()
        {
            AccesoDatos datos = new AccesoDatos();
            List<Pedido> listado=new List<Pedido>();
            Pedido pedido;
            try
            {
                datos.SetQuery("Select * from PedidosAbm_VW ");
                datos.EjecutarLector();
                while(datos.lector.Read())
                {
                    pedido = new Pedido();
                    pedido.Carro = new Carro();
                    pedido.Usuario = new Usuario();
                    pedido.Estado = new Estado();
                    pedido.ID = (Int64)datos.lector["ID"];
                    pedido.Usuario.Email = (string)datos.lector["Email"];
                    pedido.Estado.IdEstado = (Int16)datos.lector["IdEstado"];
                    pedido.Estado.estado = (string)datos.lector["Estado"];
                    pedido.Fecha = (DateTime)datos.lector["Fecha"];
                    pedido.Carro.Subtotal =(decimal)datos.lector["Total"];
                    listado.Add(pedido);
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
        public List<Pedido> listar(Usuario user)
        {
            AccesoDatos datos = new AccesoDatos();
            AccesoDatos datos1 = new AccesoDatos();
            List<Pedido> listado = new List<Pedido>();
            Pedido pedido;
            try
            {
                datos.SetQuery("Select * from Pedidos_VW where Email=@Email ");
                datos.comando.Parameters.Clear();
                datos.AgregarParametro("@Email",user.Email);
                datos.EjecutarLector();
                while (datos.lector.Read())
                {
                    pedido = new Pedido();
                    pedido.Carro = new Carro();
                    pedido.Usuario = new Usuario();
                    pedido.ID = (Int64)datos.lector["ID"];
                    pedido.Usuario = user;
                    pedido.Estado = new Estado();
                    datos1.SetQuery("select * from Detalle_Estado_VW where IdPedido=@IdPedido");
                    datos1.comando.Parameters.Clear();
                    datos1.AgregarParametro("@IdPedido",pedido.ID);
                    datos1.EjecutarLector();
                    datos1.lector.Read();
                    pedido.Estado.IdEstado = (Int16)datos1.lector["IdEstado"];
                    pedido.Estado.estado = (string)datos1.lector["Estado"];
                    datos1.CerrarConexion();
                    pedido.Fecha = (DateTime)datos.lector["Fecha"];
                    pedido.Carro.Subtotal = (decimal)datos.lector["Total"];
                    listado.Add(pedido);
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

        public void actualizar(Pedido pedido)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearSP("ActualizarEstado_SP");
                datos.comando.Parameters.Clear();
                datos.AgregarParametro("@IdEstado",pedido.Estado.IdEstado);
                datos.AgregarParametro("@IdPedido",pedido.ID);
                datos.EjecutarAccion();

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

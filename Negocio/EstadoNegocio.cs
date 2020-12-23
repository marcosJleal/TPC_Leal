using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class EstadoNegocio
    {
        public List<Estado>listar(Pedido pedido)
        {
            List<Estado> listado = new List<Estado>();
            Estado aux;
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.SetQuery("select * from Seguimiento_VW  where IdPedido=@IdPedido order by IdEstado asc");
                datos.comando.Parameters.Clear();
                datos.AgregarParametro("@IdPedido",pedido.ID);
                datos.EjecutarLector();
                while(datos.lector.Read())
                {
                    aux = new Estado();
                    aux.estado =(string)datos.lector["Estado"];
                    aux.Fecha =(DateTime)datos.lector["Fecha"];
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
    }
}

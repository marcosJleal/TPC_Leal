using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
   public class ColorNegocio
    {
		public List<Color> listado;
		public Color aux;
        public List<Color> Listar()
        {
			listado = new List<Color>();
			AccesoDatos datos = new AccesoDatos();
			try
			{
				datos.SetQuery("Select * from Colores");
				datos.EjecutarLector();
				while(datos.lector.Read())
				{
					aux = new Color();
					aux.IdColor = (Int32)datos.lector["ID"];
					aux.Nombre = (string)datos.lector["Nombre"];
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

		public List<Color> ListarDisponible()
		{
			listado = new List<Color>();
			AccesoDatos datos = new AccesoDatos();
			try
			{
				datos.SetQuery("Select * from Colores");
				datos.EjecutarLector();
				while (datos.lector.Read())
				{
					aux = new Color();
					aux.IdColor = (Int32)datos.lector["ID"];
					aux.Nombre = (string)datos.lector["Nombre"];
					aux.Cantidad = (int)datos.lector["Cantidad"];
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

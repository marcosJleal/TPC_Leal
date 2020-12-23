using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class CategoriaNegocio
    {
		public List<Categoria> listado;
		public Categoria aux;
		public List<Categoria> Listar()
		{
			listado = new List<Categoria>();
			AccesoDatos datos = new AccesoDatos();
			try
			{
				datos.SetQuery("Select * from Categoria");
				datos.EjecutarLector();
				while (datos.lector.Read())
				{
					aux = new Categoria();
					aux.IdCategoria = (Int32)datos.lector["ID"];
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
	}
}

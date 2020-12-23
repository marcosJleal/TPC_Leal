using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
            AccesoDatos datos2 = new AccesoDatos();


            try
            {
                datos.SetQuery("select * from Articulos Where Estado=1");
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
                    aux.IdArticulo = (Int64)datos.lector["ID"];
                    aux.Destacado = (bool)datos.lector["Destacado"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.IdCategoria = (Int32)datos.lector["IdCategoria"];
                    {
                        //prueba colores
                        datos2.setearSP("Colores_SP");
                        datos2.comando.Parameters.Clear();
                        datos2.AgregarParametro("@ID", aux.IdArticulo);
                        datos2.EjecutarLector();
                        aux.Colores = new List<Color>();
                        while (datos2.lector.Read())
                        {
                            Color color = new Color();
                            color.IdColor = (int)datos2.lector["IDColor"];
                            color.Nombre = (string)datos2.lector["Color"];
                            color.Cantidad = (int)datos2.lector["Cantidad"];
                            if(color.Cantidad>0)
                            {
                                aux.Colores.Add(color);
                            }
                        
                        }
                        datos2.CerrarConexion();

                    }

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
        public List<Articulo> listar(int filtro)
        {
            List<Articulo> listado = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            Articulo aux;
            AccesoDatos datos2 = new AccesoDatos();


            try
            {
                datos.SetQuery("select * from Articulos Where Estado=1 and IdCategoria=@categoria");
                datos.comando.Parameters.Clear();
                datos.AgregarParametro("@categoria",filtro);
                datos.EjecutarLector();
                while (datos.lector.Read())
                {
                    aux = new Articulo();

                    aux.Nombre = (string)datos.lector["Nombre"];
                    aux.Precio = (decimal)datos.lector["Precio"];
                    aux.Estado = (bool)datos.lector["Estado"];
                    aux.UrlImagen = (string)datos.lector["UrlImagen"];
                    aux.Stock = (int)datos.lector["Stock"];
                    aux.Descripcion = (string)datos.lector["Descripcion"];
                    aux.IdArticulo = (Int64)datos.lector["ID"];
                    aux.Destacado = (bool)datos.lector["Destacado"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.IdCategoria = (Int32)datos.lector["IdCategoria"];
                    {
                        //prueba colores
                        datos2.setearSP("Colores_SP");
                        datos2.comando.Parameters.Clear();
                        datos2.AgregarParametro("@ID", aux.IdArticulo);
                        datos2.EjecutarLector();
                        aux.Colores = new List<Color>();
                        while (datos2.lector.Read())
                        {
                            Color color = new Color();
                            color.IdColor = (int)datos2.lector["IDColor"];
                            color.Nombre = (string)datos2.lector["Color"];
                            color.Cantidad = (int)datos2.lector["Cantidad"];
                            aux.Colores.Add(color);
                        }
                        datos2.CerrarConexion();

                    }

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
        public List<Articulo> listarDestacados()
        {
            List<Articulo> listado = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            Articulo aux;
            AccesoDatos datos2 = new AccesoDatos();


            try
            {
                datos.SetQuery("select * from Articulos Where Estado=1 and Destacado=1");
                datos.EjecutarLector();
                while (datos.lector.Read())
                {
                    aux = new Articulo();

                    aux.Nombre = (string)datos.lector["Nombre"];
                    aux.Precio = (decimal)datos.lector["Precio"];
                    aux.Estado = (bool)datos.lector["Estado"];
                    aux.UrlImagen = (string)datos.lector["UrlImagen"];
                    aux.Stock = (int)datos.lector["Stock"];
                    aux.Descripcion = (string)datos.lector["Descripcion"];
                    aux.IdArticulo = (Int64)datos.lector["ID"];
                    aux.Destacado = (bool)datos.lector["Destacado"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.IdCategoria = (Int32)datos.lector["IdCategoria"];
                    {
                        //prueba colores
                        datos2.setearSP("Colores_SP");
                        datos2.comando.Parameters.Clear();
                        datos2.AgregarParametro("@ID", aux.IdArticulo);
                        datos2.EjecutarLector();
                        aux.Colores = new List<Color>();
                        while (datos2.lector.Read())
                        {
                            Color color = new Color();
                            color.IdColor = (int)datos2.lector["IDColor"];
                            color.Nombre = (string)datos2.lector["Color"];
                            color.Cantidad = (int)datos2.lector["Cantidad"];
                            aux.Colores.Add(color);
                        }
                        datos2.CerrarConexion();

                    }

                    listado.Add(aux);
                }

                return listado;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<Articulo> listarEliminados()
        {
            List<Articulo> listado = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            Articulo aux;
            AccesoDatos datos2 = new AccesoDatos();


            try
            {
                datos.SetQuery("select * from Articulos Where Estado=0");
                datos.EjecutarLector();
                while (datos.lector.Read())
                {
                    aux = new Articulo();

                    aux.Nombre = (string)datos.lector["Nombre"];
                    aux.Precio = (decimal)datos.lector["Precio"];
                    aux.Estado = (bool)datos.lector["Estado"];
                    aux.UrlImagen = (string)datos.lector["UrlImagen"];
                    aux.Stock = (int)datos.lector["Stock"];
                    aux.Descripcion = (string)datos.lector["Descripcion"];
                    aux.IdArticulo = (Int64)datos.lector["ID"];
                    {
                        //prueba colores
                        datos2.setearSP("Colores_SP");
                        datos2.comando.Parameters.Clear();
                        datos2.AgregarParametro("@ID", aux.IdArticulo);
                        datos2.EjecutarLector();
                        aux.Colores = new List<Color>();
                        while (datos2.lector.Read())
                        {
                            Color color = new Color();
                            color.IdColor = (int)datos2.lector["IDColor"];
                            color.Nombre = (string)datos2.lector["Color"];
                            color.Cantidad = (int)datos2.lector["Cantidad"];
                            aux.Colores.Add(color);
                        }
                        datos2.CerrarConexion();

                    }

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

        public void agregar(Articulo aux)
        {
            Int64 idart;
            AccesoDatos datos= new AccesoDatos();
            AccesoDatos datos2 = new AccesoDatos();
            AccesoDatos datos3 = new AccesoDatos();
            try
            {
                datos.setearSP("NuevoArticulo_SP");
                datos.comando.Parameters.Clear();
                datos.AgregarParametro("@Nombre", aux.Nombre);
                datos.AgregarParametro("@Stock", aux.Stock);
                datos.AgregarParametro("@Precio", aux.Precio);
                datos.AgregarParametro("@Estado", 1);
                datos.AgregarParametro("@Descripcion", aux.Descripcion);
                datos.AgregarParametro("@UrlImagen", aux.UrlImagen);
                datos.AgregarParametro("@Categoria", aux.Categoria.IdCategoria);
                datos.AgregarParametro("@Destacado", aux.Destacado);
                 datos.EjecutarAccion();
                datos.CerrarConexion();

                datos3.SetQuery("select ID from Articulos where Nombre=@NombreArt");
                datos3.comando.Parameters.Clear();
                datos3.AgregarParametro("@NombreArt",aux.Nombre);
                datos3.EjecutarLector();
                datos3.lector.Read();
                idart =(Int64)datos3.lector["ID"];

                foreach (var item in aux.Colores)
                {
                    datos2.setearSP("NuevoColorXArticulo_SP"); 
                    datos2.comando.Parameters.Clear();
                    datos2.AgregarParametro("@IDArticulo", idart);
                    datos2.AgregarParametro("@IDColor", item.IdColor);
                    datos2.AgregarParametro("@Cantidad",item.Cantidad);
                    datos2.EjecutarAccion();
                    datos2.CerrarConexion();


                }

                datos3.CerrarConexion();
               

            }
            catch (Exception ex)
            {

                throw ex;
            }
            
        }

        public void Eliminar(Articulo aux)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearSP("EliminarArticulo_SP");
                datos.comando.Parameters.Clear();
                datos.AgregarParametro("@ID", aux.IdArticulo);
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
        public void Restaurar(Articulo aux)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearSP("RestaurarArticulo_SP");
                datos.comando.Parameters.Clear();
                datos.AgregarParametro("@ID", aux.IdArticulo);
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

        public void Modificar(Articulo aux)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearSP("ModificarArticulo_SP");
                datos.comando.Parameters.Clear();
                datos.AgregarParametro("@ID",aux.IdArticulo);
                datos.AgregarParametro("@Nombre",aux.Nombre);
                datos.AgregarParametro("@Stock",aux.Stock);
                datos.AgregarParametro("@Precio",aux.Precio);
                datos.AgregarParametro("@Estado",aux.Estado);
                datos.AgregarParametro("@Descripcion",aux.Descripcion);
                datos.AgregarParametro("@UrlImagen",aux.UrlImagen);
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
        public void Destacar(Articulo aux)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearSP("Destacar_SP");
                datos.comando.Parameters.Clear();
                datos.AgregarParametro("@IdArticulo",aux.IdArticulo);
                datos.AgregarParametro("@Destacado",aux.Destacado);
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

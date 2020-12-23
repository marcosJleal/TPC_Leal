using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class UsuarioNegocio
    {


        public void AltaUsuario(Usuario usuario)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearSP("AltaUsuario_SP ");
                datos.comando.Parameters.Clear();
                datos.AgregarParametro("@Nombre", usuario.Nombre);
                datos.AgregarParametro("@Apellido", usuario.Apellido);
                datos.AgregarParametro("@DNI", usuario.DNI);
                datos.AgregarParametro("@Email", usuario.Email);
                datos.AgregarParametro("@Contraseña", usuario.Contraseña);
                datos.AgregarParametro("@TipoUsuario", 2);
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

        public void ModificarUsuario(Usuario usuario)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearSP("ModificarUsuario_SP");
                datos.comando.Parameters.Clear();
                datos.AgregarParametro("@ID", usuario.IdUsuario);
                datos.AgregarParametro("@Nombre", usuario.Nombre);
                datos.AgregarParametro("@Apellido", usuario.Apellido);
                datos.AgregarParametro("@DNI", usuario.DNI);
                datos.AgregarParametro("@Email", usuario.Email);
                datos.AgregarParametro("@Contraseña", usuario.Contraseña);
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

        public void EliminarUsuario(Usuario usuario)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearSP("EliminarUsuario_SP");
                datos.comando.Parameters.Clear();
                datos.AgregarParametro("@ID", usuario.IdUsuario);
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

        public List<Usuario> Listar()
        {
            AccesoDatos datos = new AccesoDatos();
            List<Usuario> listado = new List<Usuario>();
            Usuario aux;
            try
            {
                datos.SetQuery("select * from Usuarios_VW");
                datos.EjecutarLector();
                while (datos.lector.Read())
                {
                    aux = new Usuario();

                    aux.Nombre = (string)datos.lector["Nombre"];
                    aux.Apellido = (string)datos.lector["Apellido"];
                    aux.DNI = (string)datos.lector["DNI"];
                    aux.Email = (string)datos.lector["Email"];
                    aux.Contraseña = (string)datos.lector["Contraseña"];
                    aux.IdUsuario = (Int64)datos.lector["ID"];
                    aux.TipoUsuario = (string)datos.lector["Tipo"];

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
        public Usuario Listar(Usuario user)
        {
            AccesoDatos datos = new AccesoDatos();
            Usuario aux;
            try
            {
                datos.SetQuery("select * from Usuarios_VW where Email=@Email");
                datos.comando.Parameters.Clear();
                datos.AgregarParametro("@Email", user.Email);
                datos.EjecutarLector();
                datos.lector.Read();

                aux = new Usuario();
                aux.Nombre = (string)datos.lector["Nombre"];
                aux.Apellido = (string)datos.lector["Apellido"];
                aux.DNI = (string)datos.lector["DNI"];
                aux.Email = (string)datos.lector["Email"];
                aux.Contraseña = (string)datos.lector["Contraseña"];
                aux.IdUsuario = (Int64)datos.lector["ID"];
                aux.TipoUsuario = (string)datos.lector["Tipo"];

                return aux;

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

        public Usuario Login(Usuario usuario)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {

                datos.SetQuery("select ID from Usuarios Where Email=@Email and Contraseña=@Contraseña ");
                datos.comando.Parameters.Clear();
                datos.AgregarParametro("@Email", usuario.Email);
                datos.AgregarParametro("@Contraseña", usuario.Contraseña);
                datos.EjecutarLector();

                if (datos.lector.Read())
                {
                    usuario.IdUsuario = (Int64)datos.lector["ID"];
                }

                return usuario;

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

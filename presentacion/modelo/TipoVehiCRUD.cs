using System;
using System.Data.SqlClient;
using System.Data;

namespace modelo
{
    internal class TipoVehiCRUD
    {

        // UPDATE
        //crear
        public static SqlCommand crearProcAct()
        {
            string _cadenaConexion = Configuracion.CadenaConexion;
            SqlConnection _conexion = new SqlConnection(_cadenaConexion);
            SqlCommand _comando = new SqlCommand("ActReg", _conexion);
            _comando.CommandType = CommandType.StoredProcedure;
            return _comando;
        }

        //ejecutar
        public static int EjecutarcomandoUpdate(SqlCommand comando)
        {
            try
            {
                comando.Connection.Open();
                return comando.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {
                comando.Connection.Dispose();
                comando.Connection.Close();
            }
        }

        // INSERTAR
        // ejecutar
        public static int EjecutarComandoInsert(SqlCommand comando)
        {
            try
            {
                comando.Connection.Open();
                return comando.ExecuteNonQuery();
            }
            catch { throw; }
            finally
            {
                comando.Connection.Dispose();
                comando.Connection.Close();
            }
        }

        // crear
        public static SqlCommand CrearComandoProc()
        {
            string _cadenaConexion = Configuracion.CadenaConexion;
            SqlConnection _conexion = new SqlConnection(_cadenaConexion);
            SqlCommand _comando = new SqlCommand("regisTipoVehic", _conexion);
            _comando.CommandType = CommandType.StoredProcedure;
            return _comando;
        }

        // LISTAR
        // crear
        public static SqlCommand CrearComandoListar()
        {
            string _cadenaConexion = Configuracion.CadenaConexion;
            SqlConnection _conexion = new SqlConnection();
            _conexion.ConnectionString = _cadenaConexion;
            SqlCommand _comando = new SqlCommand();
            _comando = _conexion.CreateCommand();
            _comando.CommandType = CommandType.Text;
            return _comando;
        }

        // ejecutar
        public static DataTable EjecutarComandoSelect(SqlCommand comando)
        {
            DataTable _tabla = new DataTable();
            try
            {
                comando.Connection.Open();
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                adaptador.Fill(_tabla);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                comando.Connection.Close();
            }
            return _tabla;
        }

        public static SqlCommand crearProcDelt()
        {
            string _cadenaConexion = Configuracion.CadenaConexion;
            SqlConnection _conexion = new SqlConnection(_cadenaConexion);
            SqlCommand _comando = new SqlCommand("elimiTipoVehic", _conexion);
            _comando.CommandType = CommandType.StoredProcedure;
            return _comando;
        }

        public static int EjecutarcomandoDelete(SqlCommand comando)
        {
            try
            {
                comando.Connection.Open();
                return comando.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                comando.Connection.Dispose();
                comando.Connection.Close();
            }
        }
    }
}
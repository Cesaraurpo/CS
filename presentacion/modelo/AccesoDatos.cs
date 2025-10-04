using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace modelo
{
    public class AccesoDatos
    {

        public int Insert(int idtipo, string nombretipo)
        {
            SqlCommand _comando = TipoVehiCRUD.CrearComandoProc();
            _comando.Parameters.AddWithValue("@Idtipo", idtipo);
            _comando.Parameters.AddWithValue("@Nombretipo", nombretipo);

            return TipoVehiCRUD.EjecutarComandoInsert(_comando);
        }

        public static DataTable obtenerTiposVehi()
        {
            SqlCommand _comando = TipoVehiCRUD.CrearComandoListar();
            _comando.CommandText = "SELECT * FROM Tipo_Vehiculo";
            return TipoVehiCRUD.EjecutarComandoSelect(_comando);
        }

        public int updateTipoVehi(int idtipo, string nombretipo)
        {
            SqlCommand _comando = TipoVehiCRUD.crearProcAct();
            _comando.Parameters.AddWithValue("IdTipo", idtipo);
            _comando.Parameters.AddWithValue("@NombreTipo", nombretipo);

            return TipoVehiCRUD.EjecutarcomandoUpdate(_comando);
        }

        public int deleteTipoVehi(int idtipo)
        {
            SqlCommand _comando = TipoVehiCRUD.crearProcDelt();
            _comando.Parameters.AddWithValue("IdTipo", idtipo);

            return TipoVehiCRUD.EjecutarcomandoDelete(_comando);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using System.Data;
using modelo;

namespace controlador
{
    public class AccesoLogica
    {
        public int Insert(int idtipo, string nombretipo)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.Insert(idtipo, nombretipo);
        }


        //Listar
        public static DataTable ObtenerTiposVehiculos()
        {
            return AccesoDatos.obtenerTiposVehi();
        }

        public int Update(int idtipo, string nombretipo)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.updateTipoVehi(idtipo, nombretipo);
        }
        
        public int delete(int idtipo)
        {
            AccesoDatos acceso = new AccesoDatos();
            return acceso.deleteTipoVehi(idtipo);
        }
    }
}
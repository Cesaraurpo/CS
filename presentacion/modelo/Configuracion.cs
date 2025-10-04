using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo
{
    public class Configuracion
    {

        static string cadenaConexion = @"Data Source=LAPTOP_MSI_GL75\SQLEXPRESS; Initial Catalog=Trasnportes; Trusted_Connection=true";
        public static string CadenaConexion
        {
            get { return cadenaConexion; }
        }
    }
}
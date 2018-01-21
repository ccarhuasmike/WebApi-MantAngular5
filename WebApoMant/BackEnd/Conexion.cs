using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace WebApoMant.BackEnd
{
    public class Conexion
    {
        
        public static string ConexionBD()
        {
            var strCadena = ConfigurationManager.ConnectionStrings["ConexionBDMant"].ConnectionString.ToString();
            return strCadena;
        }
    }
}
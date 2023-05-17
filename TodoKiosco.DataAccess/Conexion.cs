using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TodoKiosco.DataAccess
{
    public class Conexion
    {
        protected string _cadena = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
    }
}

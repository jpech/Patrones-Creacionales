using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Conexion
    {
        private Conexion()
        {

        }

        private static Conexion _instance;

        public static Conexion GetConexion()
        {
            if (_instance == null)
                _instance = new Conexion();

            return _instance;
        }

    }
}

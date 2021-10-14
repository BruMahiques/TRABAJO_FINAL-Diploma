using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICIOS
{
    public class Singleton
    {
        private static Sesion _instancia;
        private static Object _lock = new object();

        public static Sesion Instancia
        {
            get
            {
                lock (_lock)
                {
                    if (_instancia == null)
                        _instancia = new Sesion();
                }

                return _instancia;
            }

        }
        /*
        private static Singleton _intancia = null;

        private Singleton()
        {

        }

        public static Singleton Instancia
        {

            get
            {
                if (_intancia == null)
                {
                    _intancia = new Singleton();
                }

                return _intancia;
            }

        }*/

    }
}

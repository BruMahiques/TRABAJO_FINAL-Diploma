using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SERVICIOS
{
    public class Singleton
    {
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

        }

    }
}

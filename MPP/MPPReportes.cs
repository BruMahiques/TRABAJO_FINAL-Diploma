using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Data;

namespace MPP
{
    public class MPPReportes
    {

        public DataSet ReporteA()
        {
            Acceso oDAtos = new Acceso();
            return oDAtos.Leer("ReporteA", null);
        }

        public DataSet ReporteB()
        {
            Acceso oDAtos = new Acceso();
            return oDAtos.Leer("ReporteB", null);
        }

        public DataSet ReporteC()
        {
            Acceso oDAtos = new Acceso();
            return oDAtos.Leer("ReporteC", null);
        }
    }
}

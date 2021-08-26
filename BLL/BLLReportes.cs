using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MPP;

namespace BLL
{
    public class BLLReportes
    {
        public DataSet ReporteA()
        {
            MPPReportes oMPPReport = new MPPReportes();
            return oMPPReport.ReporteA();
        }
        public DataSet ReporteB()
        {
            MPPReportes oMPPReport = new MPPReportes();
            return oMPPReport.ReporteB();
        }
        public DataSet ReporteC()
        {
            MPPReportes oMPPReport = new MPPReportes();
            return oMPPReport.ReporteC();
        }
    }
}

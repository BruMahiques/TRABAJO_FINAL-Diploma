using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using System.Collections;

namespace SERVICIOS.BackUp
{
    public class BackUp
    {
        string db = "JUEGOMES";
        public void NuevoBackup(string Ruta)

        {
            DateTime Fecha = DateTime.Now;
            string Path = Ruta + Fecha.Day + "-" + Fecha.Month + "-" + Fecha.Year + "_" + Fecha.Hour + "hs" + Fecha.Minute + "min" + ".bak";

            string Query = "BACKUP DATABASE " + db + " TO DISK ='" + Path + "'";

            Acceso AccesoDB = new Acceso();
            AccesoDB.EjecutarQuerysBackup(Query);

        }

        public void Restaurar(string Path)

        {
            string Query = " ALTER DATABASE " + db + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE; DROP DATABASE " + db + " RESTORE DATABASE " + db + "  FROM DISK ='" + Path + "'";
            Acceso AccesoDB = new Acceso();
            AccesoDB.EjecutarQuerysBackup(Query);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EE
{
    public class EEClienteVersionado
    {
        public int Cod_Cliente { get; set; }

        public string Apellido { get; set; }
        public string Nombre { get; set; }

        public int DNI { get; set; }
        public DateTime FechaNac { get; set; }
        public string Correo { get; set; }
        public float Saldo { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }


        public EEClienteVersionado() { }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EE
{
     public class EEProducto
    {
        public int Cod_Producto { get; set; }
        public string Tipo_Poducto { get; set; }
        public string Nombre_Producto { get; set; }
        public string Genero { get; set; }

        public string Edad_Producto { get; set; }

        public string Nacionalidad_Producto { get; set; }

        public string Empresa { get; set; }
        public double Importe { get; set; }
        public bool Alquilado { get; set; }

        public EEProducto() { }

        public override string ToString()
        {
            return Tipo_Poducto + " - " + Nombre_Producto + " - " + Genero + " - " + Edad_Producto + " - " + Nacionalidad_Producto + " - " + Empresa + " - " + Importe;
        }
    }
}

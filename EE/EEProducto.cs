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

        public string Nombre_Producto { get; set; }
        public string Duracion { get; set; }

        public string Edad_Producto { get; set; }
        public float Precio_Compra { get; set; }

        public float Precio_Venta { get; set; }

        public string Categoria { get; set; }
                               
        public int Stock { get; set; }
        public string Cant_Jugadores { get; set; }

        public EEProducto() { }
        public override string ToString()
        {
            return Cod_Producto + "-" + Nombre_Producto;
        }

    }
}

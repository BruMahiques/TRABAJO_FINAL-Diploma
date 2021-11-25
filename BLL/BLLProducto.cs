using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EE;
using MPP;
using System.Data;

namespace BLL
{
    public class BLLProducto
    {
        MPPProducto Map = new MPPProducto();
       
        public void ALta_Mod_Producto(EEProducto Producto)
        {
            Map.Alta_Mod_Producto(Producto);
        }

        public void BAjaProducto(EEProducto Producto)
        {
            Map.BajaProducto(Producto);
        }

        public List<EEProducto> ListarProductos()
        {
            return Map.ListarProductos();
        }

    }
}

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

        public List<EEProducto> ListarProductosFiltrado(string textbox, int num)
        {
            return Map.ListarProductosFiltrado(textbox, num);
        }
        public int ExisteProductoEnComprobante(EEProducto producto)
        {
            return Map.ExisteProductoEnComprobante(producto);
        }

        public int ExisteProductoEnReserva(EEProducto producto)
        {
            return Map.ExisteProductoEnReserva(producto);
        }
        public EEProducto BuscarID(int cod)
        {
            return Map.BuscarID(cod);
        }

        

    }
}

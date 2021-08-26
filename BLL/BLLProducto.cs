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
        public DataSet Listar()
        {
            MPPProducto MPPProducto = new MPPProducto();

            return MPPProducto.Listar();
        }

        public List<EEProducto> ListarProductos()
        {
            MPPProducto Map = new MPPProducto();
            return Map.ListarProductos();
        }
        public DataSet ListarAlquilados()
        {
            MPPProducto MPPProducto = new MPPProducto();

            return MPPProducto.ListarAlquilados();
        }

}
}

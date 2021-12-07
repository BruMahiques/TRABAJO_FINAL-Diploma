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
    public class BLLCliente
    {
        MPPCliente Map = new MPPCliente();
        public void ALta_Mod_Cliente(EECliente Cliente)
        {
            Map.Alta_Mod_Cliente(Cliente);
        }

        public void BAjaCliente(EECliente Cliente)
        {
            Map.BajaCliente(Cliente);
        }

        public List<EECliente> ListarClientes()
        {
            return Map.ListarCliente();
        }

        public List<EEClienteVersionado> ListarClientesVersionado()
        {
            return Map.ListarClienteVersionado();
        }

        public DataTable ListarClientesFiltrado(string textbox, string textbox2, int num)
        {
            return Map.ListarClientesFiltrado(textbox, textbox2, num);
        }

        public DataTable ListarClientesHistoricoFiltrado(string textbox, string desde, string hasta, int num)
        {
            return Map.ListarClientesHistoricoFiltrado(textbox, desde, hasta, num);
        }

        public int ExisteCliente(EECliente Cliente)
        {
           return Map.ExisteCliente(Cliente);
        }
        public void RecuperarClientePerdido(EECliente EECliente)
        {
            Map.RecuperarClientePerdido(EECliente);
        }


    }
}

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
    public class BLLReservas
    {
        MPPReservas Map = new MPPReservas();
       

        public void Alta_Reserva(EEReservas Reserva)
        {
            Map.Alta_Reserva(Reserva);
        }
        public void Alta_Reserva_Det(EEVentaDet EEVentaDet)
        {
            Map.Alta_Reserva_Det(EEVentaDet);
        }
        public DataTable ListarReservasFiltrado(string textbox, string desde, string hasta, int num)
        {
            return Map.ListarReservasFiltrado(textbox, desde, hasta, num);
        }
        public DataTable ListarResDet(string codigo)
        {
            return Map.ListarResDet(codigo);
        }
    }
}

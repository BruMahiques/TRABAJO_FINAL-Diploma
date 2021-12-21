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
        MPPReserva Map = new MPPReserva();
       

        public void Alta_Reserva(EEReserva Reserva)
        {
            Map.Alta_Reserva(Reserva);
        }
        public List<EEReserva> ListarReserva()
        {
            return Map.ListarReserva();
        }
        public EEReserva BuscarID(int id)
        {
            return Map.BuscarID(id);
        }

        /*
         public DataTable ListarReservasFiltrado(string textbox, string desde, string hasta, int num)
         {
             return Map.ListarReservasFiltrado(textbox, desde, hasta, num);
         }
         public DataTable ListarResDet(string codigo)
         {
             return Map.ListarResDet(codigo);
         }
         */
    }
}

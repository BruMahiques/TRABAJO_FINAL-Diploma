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
    public class BLLReservasDet
    {
        MPPReservaDet Map = new MPPReservaDet();

        public void ALta_Reserva_Det(EEReservaDet ReservaDet)
        {
            Map.Alta_Reserva_Det(ReservaDet);
        }

        public List<EEReservaDet> ListarVentaDet(int id)
        {
            return Map.ListarVentaDet(id);
        }

        
    }
}

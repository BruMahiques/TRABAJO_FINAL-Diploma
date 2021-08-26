using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EE;
using MPP;

namespace BLL
{
    public class BLLReservas
    {
        MPPReservas Map = new MPPReservas();
        public void Alta_Alquiler(EEReservas Reserva)
        {
            Map.Alta_Reserva(Reserva);
        }

        public void BajaProducto(EEReservas Reserva)
        {
            Map.BajaReserva(Reserva);
        }

        public List<EEReservas> ListarReserva()
        {
            return Map.ListarReserva();
        }
    }
}

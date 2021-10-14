using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EE;

namespace SERVICIOS.Bitacora
{
    public class BitacoraActividadEE
    {
        public int Id { get; set; }

        private BitacoraActividadTipoEE _tipo;
        public BitacoraActividadEE()

        {
            _tipo = new BitacoraActividadTipoEE();
        }
        public DateTime Fecha { get; set; }
        public string Detalle { get; set; }

        public BitacoraActividadTipoEE Tipo { get { return _tipo; } }

        public void SetTipo(BitacoraActividadTipoEE tipo) { _tipo = tipo; }

        public EE.EEUsuario Usuario = new EEUsuario();

        public EEUsuario usuario { get { return Usuario; } }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EE;
using MPP;

namespace BLL
{
    public static class BLLIdiomaTraductor
    {
        public static EE.EEIdioma ObtenerIdiomaPorDefecto()

        {
            return ObtenerIdiomas().Where(i => i.Por_Defecto).FirstOrDefault();

        }
        public static List<EEIdioma> ObtenerIdiomas()

        {
            MPPTraductor MPPTraductor = new MPPTraductor();
            return MPPTraductor.ObtenerIdiomas();
        }

        public static Dictionary<string, EEIdiomaTraduccion> ObtenerTraducciones(EEIdioma Idioma)
        {
            if (Idioma == null) Idioma = ObtenerIdiomaPorDefecto();

            MPPTraductor MPPTraductor = new MPPTraductor();

            return MPPTraductor.ObtenerTraducciones(Idioma);

        }

        public static void InsertarEditarTraduccion(EEIdioma Idioma, EEIdiomaTraduccion Traduccion, int Op)

        {
            MPPTraductor MPPTraductor = new MPPTraductor();

            MPPTraductor.InsertarEditarTraduccion(Idioma, Traduccion, Op);
        }

        public static void EditarIdioma(EEIdioma Idioma, bool SetDefault)

        {
            MPPTraductor MPPTraductor = new MPPTraductor();
            MPPTraductor.EditarIdioma(Idioma, SetDefault);
        }
        public static void Insetaridioma(EEIdioma Idioma, bool SetDefault)

        {
            MPPTraductor MPPTraductor = new MPPTraductor();
            MPPTraductor.Insetaridioma(Idioma, SetDefault);
        }

        public static void EliminarIdioma(EEIdioma Idioma)

        {
            MPPTraductor MPPTraductor = new MPPTraductor();
            MPPTraductor.EliminarIdioma(Idioma);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EE;
using Datos;


namespace SERVICIOS.DV
{
    public class DigitoVerificador
    {
        public int CalcularDigitoHorizontal(EEUsuario User)
        {
            int DVH = 0;

            DVH = GenerarAscii(User.Nombre, 1) + GenerarAscii(User.Apellido, 2) + GenerarAscii(User.Mail, 3) + GenerarAscii(User.Clave, 4);
            return DVH;
        }

        public int CalcularDigitoVertical(List<EEUsuario> Users)
        {
            int dvv = 0;

            foreach (EEUsuario item in Users)

            {
                dvv = dvv + item.dvh;
            }

            return dvv;
        }

        public void ActualizarDigitoVertical(int Dv)
        {

            SERVICIOS.DV.DigitoVerificadorDAL dalDv = new SERVICIOS.DV.DigitoVerificadorDAL();
            dalDv.ActualizarVertical(Dv);
        }

        public int GenerarAscii(string atributo, int pos)

        {
            int valor = 0;
            int flag = 1;
            byte[] ValoresASCII = Encoding.ASCII.GetBytes(atributo);
            foreach (byte b in ValoresASCII)
            {
                valor = valor + (b * flag);
                flag++;
            }

            return valor + pos;
        }

        public void VerificarIntegridadHorizonal(List<EEUsuario> Users)
        {
            SERVICIOS.Bitacora.BitacoraBLL bllBit = new SERVICIOS.Bitacora.BitacoraBLL();

            SERVICIOS.Bitacora.BitacoraActividadEE nInicioVerificacionHorizontal = new SERVICIOS.Bitacora.BitacoraActividadEE();
            SERVICIOS.Bitacora.BitacoraActividadTipoEE tipo = new SERVICIOS.Bitacora.BitacoraActividadTipoEE();
            tipo = bllBit.ListarTipos().First(item => item.Tipo == "Mensaje");
            nInicioVerificacionHorizontal.SetTipo(tipo);
            nInicioVerificacionHorizontal.Detalle = "Se inició el porceso de verificación de Dígito Horizontal";
            bllBit.NuevaActividad(nInicioVerificacionHorizontal);

            foreach (EEUsuario u in Users)
            {
                int dvh = CalcularDigitoHorizontal(u);

                if (u.dvh != dvh)
                {
                    SERVICIOS.Bitacora.BitacoraActividadEE nActividad = new SERVICIOS.Bitacora.BitacoraActividadEE();

                    tipo = bllBit.ListarTipos().First(item => item.Tipo == "Error");
                    nInicioVerificacionHorizontal.SetTipo(tipo);
                    nActividad.SetTipo(tipo);
                    nActividad.Detalle = "El Proceso de Verificación de DB detectó inconsistencias en el usuario: " + u.Id;
                    bllBit.NuevaActividad(nActividad);

                }

            }

            SERVICIOS.Bitacora.BitacoraActividadEE nFinVerificacionHorizontal = new SERVICIOS.Bitacora.BitacoraActividadEE();

            tipo = bllBit.ListarTipos().First(item => item.Tipo == "Mensaje");
            nFinVerificacionHorizontal.SetTipo(tipo);
            nFinVerificacionHorizontal.Detalle = "Finalizó el porceso de verificación de Dígito Horizontal";
            bllBit.NuevaActividad(nFinVerificacionHorizontal);

        }

        public void VerificarIntegridadVertical(List<EEUsuario> Users)
        {
            SERVICIOS.Bitacora.BitacoraBLL bllBit = new SERVICIOS.Bitacora.BitacoraBLL();

            SERVICIOS.Bitacora.BitacoraActividadEE nInicioVerificacionVertical = new SERVICIOS.Bitacora.BitacoraActividadEE();
            SERVICIOS.Bitacora.BitacoraActividadTipoEE tipo = new SERVICIOS.Bitacora.BitacoraActividadTipoEE();
            tipo = bllBit.ListarTipos().First(item => item.Tipo == "Mensaje");
            nInicioVerificacionVertical.SetTipo(tipo);
            nInicioVerificacionVertical.Detalle = "Se inició el porceso de verificación de Dígito Vertical";
            bllBit.NuevaActividad(nInicioVerificacionVertical);

            int dvv = CalcularDigitoVertical(Users);

            SERVICIOS.DV.DigitoVerificadorDAL dvdal = new SERVICIOS.DV.DigitoVerificadorDAL();
            int dvv_db = dvdal.ObtenerVertical();

            if (dvv != dvv_db)
            {
                SERVICIOS.Bitacora.BitacoraActividadEE nError = new SERVICIOS.Bitacora.BitacoraActividadEE();
                tipo = bllBit.ListarTipos().First(item => item.Tipo == "Error");
                nError.SetTipo(tipo);
                nError.Detalle = "El Proceso de Verificación de DB detectó que se agregaron o quitaron Usuarios";
                bllBit.NuevaActividad(nError);

            }

            SERVICIOS.Bitacora.BitacoraActividadEE nFinVerificacionVertical = new SERVICIOS.Bitacora.BitacoraActividadEE();
            tipo = bllBit.ListarTipos().First(item => item.Tipo == "Mensaje");
            nFinVerificacionVertical.SetTipo(tipo);
            nFinVerificacionVertical.Detalle = "Finalizó el porceso de verificación de Dígito Vertical";
            bllBit.NuevaActividad(nFinVerificacionVertical);

        }
    }
}

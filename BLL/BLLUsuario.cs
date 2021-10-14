using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EE;
using SERVICIOS;
using MPP;

namespace BLL
{
    public class BLLUsuario
    {

        private MPPUsuario dUsuario = new MPPUsuario();
        private SERVICIOS.DV.DigitoVerificador DigitoVerificador = new SERVICIOS.DV.DigitoVerificador();
        private SERVICIOS.Bitacora.BitacoraActividadEE nActividad = new SERVICIOS.Bitacora.BitacoraActividadEE();
        private SERVICIOS.Bitacora.BitacoraBLL bllBit = new SERVICIOS.Bitacora.BitacoraBLL();
        private SERVICIOS.Bitacora.BitacoraActividadTipoEE tipo = new SERVICIOS.Bitacora.BitacoraActividadTipoEE();

        public List<EEUsuario> ListarUsuarios() // Traer Lista de usuarios para ABM
        {
            List<EEUsuario> Lista = new List<EEUsuario>();
            return Lista = dUsuario.ListarUsuarios();
        }

        public EE.EEUsuario GetUsuarioLogin(string Mail) // Traer usuario para luego validar el login

        {
            EEUsuario oUsuario = new EEUsuario();
            oUsuario = dUsuario.LeerUsuario(Mail);
            return oUsuario;
        }

        public EE.EEUsuario SeleccionarUsuarioPorId(int Id)
        {
            return dUsuario.SeleccionarUsuarioPorId(Id);
        }
        public SERVICIOS.Inicio.ResultadoLogin Login(string Mail, string Password)

        {
            if (Singleton.Instancia.Estalogueado())
                throw new Exception("La sesión ya está iniciada");

            EEUsuario oUsuario = new EEUsuario();
            BLLPerfilComponente bllComp = new BLLPerfilComponente();
            oUsuario = GetUsuarioLogin(Mail);
            bllComp.CargarPerfilUsuario(oUsuario);

            if (oUsuario.Mail == null) throw new SERVICIOS.Inicio.ExceptionLogin(SERVICIOS.Inicio.ResultadoLogin.UsuarioInvalido);


            if (!oUsuario.Clave.Equals(SERVICIOS.Inicio.Encriptador.Hash(Password)))
                throw new SERVICIOS.Inicio.ExceptionLogin(SERVICIOS.Inicio.ResultadoLogin.PasswordInvalido);
            else

            {
                Singleton.Instancia.Login(oUsuario);
                return SERVICIOS.Inicio.ResultadoLogin.UsuarioValido;
            }
        }
        public void GuardarPermisos(EEUsuario Usuario)

        {
            dUsuario.GuardarPermisos(Usuario);
        }
        public void Alta(EEUsuario Usuario)

        {
            Usuario.dvh = DigitoVerificador.CalcularDigitoHorizontal(Usuario);
            string Id = dUsuario.Alta(Usuario);
            int dvv = DigitoVerificador.CalcularDigitoVertical(dUsuario.ListarUsuarios());
            DigitoVerificador.ActualizarDigitoVertical(dvv);

            tipo = bllBit.ListarTipos().First(item => item.Tipo == "Mensaje");
            nActividad.SetTipo(tipo);
            nActividad.Detalle = "Se agregó el Usuario " + Id;
            bllBit.NuevaActividad(nActividad);

        }

        public void Editar(EEUsuario Usuario)

        {
            Usuario.dvh = DigitoVerificador.CalcularDigitoHorizontal(Usuario);
            dUsuario.Editar(Usuario);
            int dvv = DigitoVerificador.CalcularDigitoVertical(dUsuario.ListarUsuarios());
            DigitoVerificador.ActualizarDigitoVertical(dvv);

            tipo = bllBit.ListarTipos().First(item => item.Tipo == "Mensaje");
            nActividad.SetTipo(tipo);
            nActividad.Detalle = "Se modificó el Usuario " + Usuario.Id;
            bllBit.NuevaActividad(nActividad);

        }

        public void Eliminar(EEUsuario Usuario)

        {
            dUsuario.Eliminar(Usuario);
            int dvv = DigitoVerificador.CalcularDigitoVertical(dUsuario.ListarUsuarios());
            DigitoVerificador.ActualizarDigitoVertical(dvv);

            tipo = bllBit.ListarTipos().First(item => item.Tipo == "Mensaje");
            nActividad.SetTipo(tipo);
            nActividad.Detalle = "Se Eliminó el Usuario " + Usuario.Id;
            bllBit.NuevaActividad(nActividad);

        }

        public void Logut()

        {
            nActividad.Detalle = "Sesión cerrada con éxito";
            tipo = bllBit.ListarTipos().First(item => item.Tipo == "Mensaje");
            nActividad.SetTipo(tipo);
            bllBit.NuevaActividad(nActividad);
            Singleton.Instancia.Logout();
        }

        public bool ExisteUsuario(EEUsuario us)

        {
            List<EEUsuario> Lista = new List<EEUsuario>(ListarUsuarios());

            return Lista.Exists(x => x.Mail == us.Mail);
        }


    }
}

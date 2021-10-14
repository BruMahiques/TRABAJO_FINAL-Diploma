using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EE;
using SERVICIOS;
using BLL;

namespace TRABAJO_FINAL
{
    public partial class Bitacora : Form
    {
        public Bitacora()
        {
            InitializeComponent();
            CargarUsuarios();
            CargarTipos();
            dateTimePicker2.Value = DateTime.Now;
            MostrarDatos(dateTimePicker1.Value, DateTime.Now, 0, 0);
        }

        private SERVICIOS.Bitacora.BitacoraBLL bllBit = new SERVICIOS.Bitacora.BitacoraBLL();
        public void Filtrar()

        {
            EEUsuario sel = new EEUsuario();
            sel = (EEUsuario)comboUsuario.SelectedItem;
            SERVICIOS.Bitacora.BitacoraActividadTipoEE tipo = new SERVICIOS.Bitacora.BitacoraActividadTipoEE();
            tipo = (SERVICIOS.Bitacora.BitacoraActividadTipoEE)comboTipo.SelectedItem;
            DateTime desde = dateTimePicker1.Value;
            DateTime hasta = dateTimePicker2.Value;

            MostrarDatos(desde, hasta, sel.Id, tipo.Id);
        }

        public void CargarUsuarios()

        {
            BLLUsuario bllus = new BLLUsuario();
            List<EEUsuario> Usuarios = new List<EEUsuario>();
            EEUsuario defecto = new EEUsuario(); defecto.Nombre = "Todos"; defecto.Id = 0;

            Usuarios = bllus.ListarUsuarios();
            Usuarios.Insert(0, defecto);
            comboUsuario.DataSource = null;
            comboUsuario.DataSource = Usuarios;

        }

        public void CargarTipos()

        {
            List<SERVICIOS.Bitacora.BitacoraActividadTipoEE> Tipos = new List<SERVICIOS.Bitacora.BitacoraActividadTipoEE>();
            SERVICIOS.Bitacora.BitacoraActividadTipoEE defecto = new SERVICIOS.Bitacora.BitacoraActividadTipoEE(); defecto.Tipo = "Todos"; defecto.Id = 0;

            Tipos = bllBit.ListarTipos();
            Tipos.Insert(0, defecto);
            comboTipo.DataSource = null;
            comboTipo.DataSource = Tipos;
        }

        public void MostrarDatos(DateTime Desde, DateTime Hasta, int IdU, int IdT)

        {
            List<SERVICIOS.Bitacora.BitacoraActividadEE> Eventos = new List<SERVICIOS.Bitacora.BitacoraActividadEE>();
            Eventos = bllBit.ListarEventos();

            if (IdU != 0) { Eventos = Eventos.Where(Item => Item.Usuario.Id == IdU).ToList(); }

            if (IdT != 0) { Eventos = Eventos.Where(Item => Item.Tipo.Id == IdT).ToList(); }

            Eventos = Eventos.Where(Item => Item.Fecha.Date >= Desde && Item.Fecha.Date <= Hasta).ToList();

            dataGridViewEventos.DataSource = null;
            dataGridViewEventos.DataSource = Eventos;

        }
    }
}

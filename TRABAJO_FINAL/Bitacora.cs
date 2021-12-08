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
    public partial class Bitacora : Form, InterfazIdiomaObserver
    {
        public Bitacora()
        {
            InitializeComponent();
            Traducir();
            CargarUsuarios();
            CargarTipos();
            dateTimePicker2.Value = DateTime.Now;
            MostrarDatos(dateTimePicker1.Value, DateTime.Now, 0, 0);
        }

        public void UpdateLanguage(EEIdioma idioma)
        {
            Traducir();
        }

        private void Traducir()

        {
            EEIdioma Idioma = null;

            if (Singleton.Instancia.Estalogueado()) Idioma = Singleton.Instancia.Usuario.Idioma;

            var Traducciones = BLLIdiomaTraductor.ObtenerTraducciones(Idioma);

            if (Traducciones != null) // Al crear un idioma nuevo y utilizarlo no habrá traducciones, por lo tanto es necesario consultar si es null
            {

                if (this.Tag != null && Traducciones.ContainsKey(this.Tag.ToString()))  // Título del form
                    this.Text = Traducciones[this.Tag.ToString()].Texto;

                foreach (Control x in this.Controls) // Todos los controles

                {

                   

                    if (label1.Tag != null && Traducciones.ContainsKey(label1.Tag.ToString()))
                        label1.Text = Traducciones[label1.Tag.ToString()].Texto;

                    if (label2.Tag != null && Traducciones.ContainsKey(label2.Tag.ToString()))
                        label2.Text = Traducciones[label2.Tag.ToString()].Texto;

                    if (label4.Tag != null && Traducciones.ContainsKey(label4.Tag.ToString()))
                        label4.Text = Traducciones[label4.Tag.ToString()].Texto;

                    if (label3.Tag != null && Traducciones.ContainsKey(label3.Tag.ToString()))
                        label3.Text = Traducciones[label3.Tag.ToString()].Texto;


                }

            }

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

       
        private void btnfiltrar_Click(object sender, EventArgs e)
        {
            EEUsuario sel = new EEUsuario();
            sel = (EEUsuario)comboUsuario.SelectedItem;
            SERVICIOS.Bitacora.BitacoraActividadTipoEE tipo = new SERVICIOS.Bitacora.BitacoraActividadTipoEE();
            tipo = (SERVICIOS.Bitacora.BitacoraActividadTipoEE)comboTipo.SelectedItem;
            DateTime desde = dateTimePicker1.Value;
            DateTime hasta = dateTimePicker2.Value;

            MostrarDatos(desde, hasta, sel.Id, tipo.Id);
        }
    }
}

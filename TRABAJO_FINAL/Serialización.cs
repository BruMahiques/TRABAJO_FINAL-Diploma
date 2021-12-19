using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using SERVICIOS;
using EE;
using BLL;


namespace TRABAJO_FINAL
{
    public partial class Serialización : Form, InterfazIdiomaObserver
    {
        public Serialización()
        {
            InitializeComponent();
            Traducir();
        }
        private SERVICIOS.Bitacora.BitacoraBLL bllBit = new SERVICIOS.Bitacora.BitacoraBLL();

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

              

            }

        }

        private void AbrirSerialización_Load(object sender, EventArgs e)
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                var path = fileDialog.FileName;
                XmlSerializer serializer = new XmlSerializer(typeof(List<SERVICIOS.Bitacora.BitacoraActividadEE>));
                StreamWriter writer = new StreamWriter(path);

                List<SERVICIOS.Bitacora.BitacoraActividadEE> Eventos = new List<SERVICIOS.Bitacora.BitacoraActividadEE>();
                Eventos = bllBit.ListarEventos();

                List<SERVICIOS.Bitacora.BitacoraActividadEE> EventosEliminados = Eventos.Where(x=>x.Tipo.Tipo=="Error").ToList();



                serializer.Serialize(writer, EventosEliminados);
                writer.Close();

                dgvSerializacion.DataSource = EventosEliminados;

            }
            Traducir();
            Singleton.Instancia.SuscribirObs(this);
        }
        private void AbrirSerialización_FormClosing(object sender, FormClosingEventArgs e)
        {
            Singleton.Instancia.DesuscribirObs(this);
        }
    }
}

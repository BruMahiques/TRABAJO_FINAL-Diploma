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


namespace TRABAJO_FINAL
{
    public partial class AbrirSerialización : Form
    {
        public AbrirSerialización()
        {
            InitializeComponent();
        }
        private SERVICIOS.Bitacora.BitacoraBLL bllBit = new SERVICIOS.Bitacora.BitacoraBLL();

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
        }
    }
}

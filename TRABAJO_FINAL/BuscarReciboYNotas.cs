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
using BLL;
using SERVICIOS;

namespace TRABAJO_FINAL
{
    public partial class BuscarReciboYNotas : Form, InterfazIdiomaObserver
    {
        public BuscarReciboYNotas()
        {
            InitializeComponent();
            Traducir();
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

                if (groupBox1.Tag != null && Traducciones.ContainsKey(groupBox1.Tag.ToString()))
                    groupBox1.Text = Traducciones[groupBox1.Tag.ToString()].Texto;

               

                if (Filtrar.Tag != null && Traducciones.ContainsKey(Filtrar.Tag.ToString()))
                    Filtrar.Text = Traducciones[Filtrar.Tag.ToString()].Texto;

               

                if (rbComprobante.Tag != null && Traducciones.ContainsKey(rbComprobante.Tag.ToString()))
                    rbComprobante.Text = Traducciones[rbComprobante.Tag.ToString()].Texto;

                if (rbNDoc.Tag != null && Traducciones.ContainsKey(rbNDoc.Tag.ToString()))
                    rbNDoc.Text = Traducciones[rbNDoc.Tag.ToString()].Texto;

                if (rbcliente.Tag != null && Traducciones.ContainsKey(rbcliente.Tag.ToString()))
                    rbcliente.Text = Traducciones[rbcliente.Tag.ToString()].Texto;

                if (rbEstado.Tag != null && Traducciones.ContainsKey(rbEstado.Tag.ToString()))
                    rbEstado.Text = Traducciones[rbEstado.Tag.ToString()].Texto;

                if (label6.Tag != null && Traducciones.ContainsKey(label6.Tag.ToString()))
                    label6.Text = Traducciones[label6.Tag.ToString()].Texto;

                if (label8.Tag != null && Traducciones.ContainsKey(label8.Tag.ToString()))
                    label8.Text = Traducciones[label8.Tag.ToString()].Texto;

                if (label1.Tag != null && Traducciones.ContainsKey(label1.Tag.ToString()))
                    label1.Text = Traducciones[label1.Tag.ToString()].Texto;

                if (label2.Tag != null && Traducciones.ContainsKey(label2.Tag.ToString()))
                    label2.Text = Traducciones[label2.Tag.ToString()].Texto;

                if (label3.Tag != null && Traducciones.ContainsKey(label3.Tag.ToString()))
                    label3.Text = Traducciones[label3.Tag.ToString()].Texto;

            }

        }

        BLLVenta BLLVenta = new BLLVenta();
        BLLVentaDet BLLVentaDet = new BLLVentaDet();

        BLLRecibo bLLRecib = new BLLRecibo();
        BLLReciboDet BLLReciboDet = new BLLReciboDet();
        BLLNotaDeCredito BLLNotaDeCredito = new BLLNotaDeCredito();
        BLLNotaDeCreditoDet BLLNotaDeCreditoDet = new BLLNotaDeCreditoDet();

        private void BuscarReciboYNotas_Load(object sender, EventArgs e)
        {
            ObtenerComprobante();
            rbIdVenta.Checked = true;


            Singleton.Instancia.SuscribirObs(this);

            var bounds = Screen.FromControl(this).Bounds;
            this.Width = bounds.Width - 5;
            this.Height = bounds.Height - 110;
        }

        private void BuscarComprobante_FormClosing(object sender, FormClosingEventArgs e)
        {
            Singleton.Instancia.DesuscribirObs(this);
        }

        private void ObtenerComprobante()
        {

            List<EEVenta> comprobantes = BLLVenta.ListarVenta();
            dgvComprobante.DataSource = null;
            dgvComprobante.DataSource = comprobantes;
        }

        private void Filtrar_Click(object sender, EventArgs e)
        {
            List<EEVenta> comprobantes;

            string desde = dateTimeDesde.Value.ToString("yyyy-MM-dd");
            string hasta = dateTimeHasta.Value.ToString("yyyy-MM-dd");



            if (rbIdVenta.Checked == true)
            {
                comprobantes = BLLVenta.ListarVentasFiltrado(txtBusqComprobante.Text, desde, hasta, 1);


            }
            else
            {
                if (rbComprobante.Checked == true)
                {
                    comprobantes = BLLVenta.ListarVentasFiltrado(txtBusqComprobante.Text, desde, hasta, 2);

                }
                else
                {
                    if (rbNDoc.Checked == true)
                    {
                        comprobantes = BLLVenta.ListarVentasFiltrado(txtBusqComprobante.Text, desde, hasta, 3);

                    }
                    else
                    {
                        if (rbcliente.Checked == true)
                        {
                            comprobantes = BLLVenta.ListarVentasFiltrado(txtBusqComprobante.Text, desde, hasta, 4);

                        }
                        else
                        {
                            comprobantes = BLLVenta.ListarVentasFiltrado(txtBusqComprobante.Text, desde, hasta, 5);

                        }

                    }
                }
            }
            dgvComprobante.DataSource = null;
            dgvComprobante.DataSource = comprobantes;

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (txtComprobante.Text != "-")
            {
                List<EERecibo> Recibos;

                Recibos = bLLRecib.ListarRecibosDeVenta(Convert.ToInt32(txtComprobante.Text));

                dgvRecibos.DataSource = null;
                dgvRecibos.DataSource = Recibos;

                List<EENotaDeCredito> Notas;

                Notas = BLLNotaDeCredito.ListarNotasDeVenta(Convert.ToInt32(txtComprobante.Text));

                dataNotas.DataSource = null;
                dataNotas.DataSource = Notas;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textRecibo.Text != "-")
            {
                List<EEReciboDet> RecibosDet;

                RecibosDet = BLLReciboDet.ListarReciboDet(Convert.ToInt32(textRecibo.Text));

                dataRecibosDet.DataSource = null;
                dataRecibosDet.DataSource = RecibosDet;

            }

        }

        private void btnselectNota_Click(object sender, EventArgs e)
        {
            
                if (textNota.Text != "-")
            {
                List<EENotaDeCreditoDet> NotaDet;

                NotaDet = BLLNotaDeCreditoDet.ListarNotaDeCreditoDet(Convert.ToInt32(textNota.Text));

                dataNotasDet.DataSource = null;
                dataNotasDet.DataSource = NotaDet;
            }
        }

        private void dgvComprobante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtComprobante.Text = dgvComprobante.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void dgvItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textRecibo.Text = dgvRecibos.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void dataNotas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textNota.Text = dataNotas.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
    }
}

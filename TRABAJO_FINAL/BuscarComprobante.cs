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
    public partial class BuscarComprobante : Form, InterfazIdiomaObserver
    {
        public BuscarComprobante()
        {
            InitializeComponent();
            Traducir();
        }

        private void BuscarComprobante_Load(object sender, EventArgs e)
        {
            rbIdVenta.Checked = true;
            ObtenerComprobante();
            btnEmitido.Enabled = false;
            btnEntrega.Enabled = false;
            btnCancelado.Enabled = false;
            Singleton.Instancia.SuscribirObs(this);
            var bounds = Screen.FromControl(this).Bounds;
            this.Width = bounds.Width - 5;
            this.Height = bounds.Height - 110;



        }
        private void BuscarComprobante_FormClosing(object sender, FormClosingEventArgs e)
        {
            Singleton.Instancia.DesuscribirObs(this);
        }


        BLLVenta BLLVenta = new BLLVenta();
        BLLVentaDet BLLVentaDet = new BLLVentaDet();

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

                if (btnSeleccionar.Tag != null && Traducciones.ContainsKey(btnSeleccionar.Tag.ToString()))
                    btnSeleccionar.Text = Traducciones[btnSeleccionar.Tag.ToString()].Texto;

                if (btnEmitido.Tag != null && Traducciones.ContainsKey(btnEmitido.Tag.ToString()))
                    btnEmitido.Text = Traducciones[btnEmitido.Tag.ToString()].Texto;

                if (Filtrar.Tag != null && Traducciones.ContainsKey(Filtrar.Tag.ToString()))
                    Filtrar.Text = Traducciones[Filtrar.Tag.ToString()].Texto;

                if (btnEntrega.Tag != null && Traducciones.ContainsKey(btnEntrega.Tag.ToString()))
                    btnEntrega.Text = Traducciones[btnEntrega.Tag.ToString()].Texto;

                if (btnCancelado.Tag != null && Traducciones.ContainsKey(btnCancelado.Tag.ToString()))
                    btnCancelado.Text = Traducciones[btnCancelado.Tag.ToString()].Texto;

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

        private void ObtenerComprobante()
        {
            DataTable comprobantes;
            string desde = dateTimeDesde.Value.ToString("yyyy-MM-dd");
            string hasta = dateTimeHasta.Value.ToString("yyyy-MM-dd");

            comprobantes = BLLVenta.ListarVentasFiltrado(txtBusqComprobante.Text, desde, hasta, 6);
            dgvComprobante.DataSource = null;
            dgvComprobante.DataSource = comprobantes;
        }

        private void Filtrar_Click(object sender, EventArgs e)
        {
            DataTable comprobantes;

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
            btnEmitido.Enabled = true;
            btnEntrega.Enabled = true;
            btnCancelado.Enabled = true;

            if (txtComprobante.Text != "-")
            { 
            DataTable items;

            items = BLLVentaDet.ListarVentaDet(txtComprobante.Text);

            dgvItems.DataSource = null;
            dgvItems.DataSource = items;
            }
        }

        private void dgvComprobante_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtComprobante.Text = dgvComprobante.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
        private bool ValidarCampos()
        {

            bool respuesta = true;

            if (txtComprobante.Text == "-")
            {
                respuesta = false;

            }
            return respuesta;
        }

        private void btnEmitido_Click(object sender, EventArgs e)
        {
            Cambiar_estado("Emitido");
        }

        private void btnEntrega_Click(object sender, EventArgs e)
        {
            Cambiar_estado("Entregado");
        }

        private void btnCancelado_Click(object sender, EventArgs e)
        {
            Cambiar_estado("Cancelado");
        }

        private void Cambiar_estado(string Estado)
        {

            try
            {
                if (ValidarCampos())
                {
                    EEVenta Venta = new EEVenta();
                    Venta.Id_Venta = Convert.ToInt32(txtComprobante.Text);
                    Venta.Estado = Estado;

                    BLLVenta.Mod_Estado(Venta);

                    ObtenerComprobante();
                    btnEmitido.Enabled = false;
                    btnEntrega.Enabled = false;
                    btnCancelado.Enabled = false;
                    txtComprobante.Text = "-";
                }
                else
                {
                    MessageBox.Show("Datos mal ingresados");
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
                return;
            }
        }
    }
}

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
            btnDevolucion.Enabled = false;
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

                if (btnDevolucion.Tag != null && Traducciones.ContainsKey(btnDevolucion.Tag.ToString()))
                    btnDevolucion.Text = Traducciones[btnDevolucion.Tag.ToString()].Texto;

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
            btnDevolucion.Enabled = true;
            btnEntrega.Enabled = true;
            btnCancelado.Enabled = true;

            if (txtComprobante.Text != "-")
            { 
            List<EEVentaDet> items;

            items = BLLVenta.BuscarID(Convert.ToInt32(txtComprobante.Text)).LDetalle;

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
            NotaDeCredito bus = new NotaDeCredito();
            EENotaDeCredito NotaCre = new EENotaDeCredito();
            EEVenta Venta = new EEVenta();
            BLLVenta bllventa = new BLLVenta();
            EECliente cliente = new EECliente();
            BLLCliente bllcliente = new BLLCliente();


            Venta = bllventa.BuscarID(Convert.ToInt32(txtComprobante.Text));
            cliente = bllcliente.BuscarID(Venta.Cliente.Cod_Cliente);
            if (Venta.Estado == "Entregado")
            {
                NotaCre.Venta = Venta;



                bus.NotaCredito = NotaCre;


                this.Close();
                bus.Show();
            }
            else
            {
                MessageBox.Show("La Venta todavía ni se había pagado");
            }
        }

        private void btnEntrega_Click(object sender, EventArgs e)
        {
            Recibo bus = new Recibo();
            EERecibo recibos = new EERecibo();
            EEVenta Venta = new EEVenta();
            BLLVenta bllventa = new BLLVenta();
            EECliente cliente = new EECliente();
            BLLCliente bllcliente = new BLLCliente();


            Venta = bllventa.BuscarID(Convert.ToInt32(txtComprobante.Text));
            cliente = bllcliente.BuscarID(Venta.Cliente.Cod_Cliente);
            if (Venta.Estado == "Emitido")
            {
                recibos.Venta = Venta;



                bus.recibo = recibos;


                this.Close();
                bus.Show();
            }
            else
            {
                MessageBox.Show("La Venta ya se entregó");
            }

        }

        private void btnCancelado_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro que desea Cancelar la venta? , no hay vuelta atras", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {

                Cambiar_estado("Cancelado");

                
            }
            
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

                   // BLLVenta.Mod_Estado(Venta);

                    ObtenerComprobante();
                    btnDevolucion.Enabled = false;
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

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
using Datos;
using SERVICIOS;

namespace TRABAJO_FINAL
{
    public partial class Reservas : Form, InterfazIdiomaObserver
    {
        public Reservas()
        {
            InitializeComponent();
            Traducir();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            BuscarCliente buscliente = new BuscarCliente();
            buscliente.lista4 = listaRes;
            this.Close();
            buscliente.Show();
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
                              
                if (label7.Tag != null && Traducciones.ContainsKey(label7.Tag.ToString()))
                    label7.Text = Traducciones[label7.Tag.ToString()].Texto;

                if (label10.Tag != null && Traducciones.ContainsKey(label10.Tag.ToString()))
                    label10.Text = Traducciones[label10.Tag.ToString()].Texto;

                if (label12.Tag != null && Traducciones.ContainsKey(label12.Tag.ToString()))
                    label12.Text = Traducciones[label12.Tag.ToString()].Texto;

                if (label13.Tag != null && Traducciones.ContainsKey(label13.Tag.ToString()))
                    label13.Text = Traducciones[label13.Tag.ToString()].Texto;

                
                                
                if (label2.Tag != null && Traducciones.ContainsKey(label2.Tag.ToString()))
                    label2.Text = Traducciones[label2.Tag.ToString()].Texto;

                if (label14.Tag != null && Traducciones.ContainsKey(label14.Tag.ToString()))
                    label14.Text = Traducciones[label14.Tag.ToString()].Texto;

                if (label19.Tag != null && Traducciones.ContainsKey(label19.Tag.ToString()))
                    label19.Text = Traducciones[label19.Tag.ToString()].Texto;

                if (label17.Tag != null && Traducciones.ContainsKey(label17.Tag.ToString()))
                    label17.Text = Traducciones[label17.Tag.ToString()].Texto;
                             
                if (lblNumdesc.Tag != null && Traducciones.ContainsKey(lblNumdesc.Tag.ToString()))
                    lblNumdesc.Text = Traducciones[lblNumdesc.Tag.ToString()].Texto;

                if (label2.Tag != null && Traducciones.ContainsKey(label2.Tag.ToString()))
                    label2.Text = Traducciones[label2.Tag.ToString()].Texto;

            }

        }
        private void Reservas_Load(object sender, EventArgs e)
        {
            txtCodUsuario.Text = Cliente.Cod_Cliente.ToString();
            txtNombreCliente.Text = Cliente.Nombre;
            txtNumDoc.Text = Cliente.DNI.ToString();
            txtCorreo.Text = Cliente.Correo;

            
            

            foreach (var dato in listaRes)
            {
                dgvDetalleBoleta.Rows.Add(dato.Cod_Producto, dato.Nombre_Producto, dato.Precio_Venta, dato.Stock);
            }

            foreach (DataGridViewColumn c in dgvDetalleBoleta.Columns)
            {
                if (c.Name != "Cantidad")
                {
                    c.ReadOnly = true;
                }
            }

            ArmarTotalyDesc();


            
            lblCorrelativo.Text = ObtenerNumeroComprobante();
            
            btnImprimir.Enabled = false;

            btnGuardar.Enabled = ValidarCampos();

            cboTipoPago.DataSource = BLLTipoDePago.ListarTipoDePago();

            Singleton.Instancia.SuscribirObs(this);

        }
        private void Reservas_FormClosing(object sender, FormClosingEventArgs e)
        {
            Singleton.Instancia.DesuscribirObs(this);
        }

        public List<EEProducto> listaRes = new List<EEProducto>();
        public EECliente Cliente = new EECliente();
        public EEReserva Reserva = new EEReserva();

        public BLLCliente bllcliente = new BLLCliente();
        public BLLProducto BLLProducto = new BLLProducto();
        public BLLReservas BLLReservas = new BLLReservas();
        public BLLReservasDet BLLReservasDet = new BLLReservasDet();
        public BLLTipoDePago BLLTipoDePago = new BLLTipoDePago();

        private void button2_Click(object sender, EventArgs e)
        {

            txtCodUsuario.Text = "-";
            txtNombreCliente.Text = string.Empty;
            txtNumDoc.Text = string.Empty;
            txtCorreo.Text = string.Empty;

            Cliente.Cod_Cliente = 0;
            Cliente.Nombre = string.Empty;
            Cliente.DNI = 0;
            Cliente.Correo = string.Empty;

            btnImprimir.Enabled = false;
            btnGuardar.Enabled = ValidarCampos();
            btnGuardar.Enabled = false;
        }

        private void btnAgregarItem_Click(object sender, EventArgs e)
        {
            BuscarProducto buspro = new BuscarProducto();
            buspro.listaRes2 = listaRes;
            buspro.ClienRes2 = Cliente;
            this.Close();
            buspro.Show();

        }
        
        private bool ValidarCampos()
        {
            bool respuesta;

            respuesta = true;

            if (txtCodUsuario.Text == "-" || txtCodUsuario.Text == "0")
            {
                respuesta = false;

            }

            if (txtTotal.Text == "-" || txtTotal.Text == "0")
            {
                respuesta = false;
            }



            return respuesta;
        }

        private void btnQuitarItem_Click(object sender, EventArgs e)
        {
            if (lbleliminar.Text != "-")
            {
                foreach (var producto in listaRes)
                {
                    if (producto.Cod_Producto == Convert.ToInt32(lbleliminar.Text))
                    {
                        listaRes.Remove(producto);
                        break;
                    }
                }
                dgvDetalleBoleta.Rows.Remove(dgvDetalleBoleta.CurrentRow);
                lbleliminar.Text = "-";
            }
            btnGuardar.Enabled = ValidarCampos();
            ArmarTotalyDesc();
        }

        void ArmarTotalyDesc()
        {

            double total = 0;

            foreach (DataGridViewRow row in dgvDetalleBoleta.Rows)
            {
                row.Cells["Subtotal"].Value = Convert.ToSingle(row.Cells["Precio"].Value) * Convert.ToSingle(row.Cells["Cantidad"].Value);
                total += Convert.ToSingle(row.Cells["Subtotal"].Value);

            }
            
            txtTotal.Text = total.ToString();
        }

        private void dgvDetalleBoleta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lbleliminar.Text = dgvDetalleBoleta.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Imprimiendo en Impresora Epson-5830");
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            dgvDetalleBoleta.Rows.Clear();
            listaRes.Clear();
            txtCodUsuario.Text = string.Empty;
            txtNombreCliente.Text = string.Empty;
            txtNumDoc.Text = string.Empty;
            txtCorreo.Text = string.Empty;

            Cliente.Cod_Cliente = 0;
            Cliente.Nombre = string.Empty;
            Cliente.DNI = 0;
            Cliente.Correo = string.Empty;
            btnImprimir.Enabled = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Reservas Nueva = new Reservas();
            this.Close();
            Nueva.Show();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            btnImprimir.Enabled = true;
            if (txtseña.Text != "-" && Convert.ToSingle(txtseña.Text) > 0)
            {
                if (Convert.ToSingle(txtseña.Text) < Convert.ToSingle(txtTotal.Text))
                {
                    if (Validar())
                    {
                        try
                        {

                            
                            BLLTipoDePago blltipodepago = new BLLTipoDePago();
                            List<EEReservaDet> Ldetalle = new List<EEReservaDet>();

                            Reserva.Cod_Comprobante = lblSerie.Text + lblCorrelativo.Text;
                            Reserva.TipoDePago = blltipodepago.BuscarID(Convert.ToInt32(cboTipoPago.Text.Substring(0, 1)));
                            Reserva.Fecha = Convert.ToDateTime(dtpFechaEmision.Value);
                            Reserva.Estado = "Emitido";
                            Reserva.Cliente = bllcliente.BuscarID(Convert.ToInt32(txtCodUsuario.Text));
                            Reserva.Seña = Convert.ToInt32(txtseña.Text);
                            Reserva.Total = Convert.ToInt32(txtTotal.Text);
                            BLLReservas.Alta_Reserva(Reserva);



                            foreach (DataGridViewRow r in dgvDetalleBoleta.Rows)
                            {

                                EEReservaDet Reserva_Det = new EEReservaDet();
                                Reserva_Det.Producto = BLLProducto.BuscarID(Convert.ToInt32(r.Cells[0].Value));
                                Reserva_Det.Id_Reserva = Convert.ToInt32(lblCorrelativo.Text);
                                Reserva_Det.Cantidad = Convert.ToInt32(r.Cells[3].Value);
                                Reserva_Det.Sub_total = Convert.ToInt32(r.Cells[4].Value);
                                Ldetalle.Add(Reserva_Det);
                                BLLReservasDet.ALta_Reserva_Det(Reserva_Det);


                            }

                            Reserva.LDetalle = Ldetalle;




                            btnBuscarCliente.Enabled = false;
                            btnGuardar.Enabled = false;
                            btnAgregarItem.Enabled = false;
                            btnQuitarItem.Enabled = false;
                            btnAnular.Enabled = false;
                            dgvDetalleBoleta.ReadOnly = true;
                            pagar.Enabled = true;




                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Debe introducir una seña");
                            return;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("La seña no puede superar el total");
                }
            }
            else
            {
                MessageBox.Show("Debe introducir una seña");
            }
        }
        string ObtenerNumeroComprobante()
        {
            Acceso Datos = new Acceso();
            DataTable dt = new DataTable();
            DataSet DS = new DataSet();

            string query = "select TOP 1 Id_Reserva from Reservas order by Id_Reserva DESC";



            dt = Datos.EjecutarCualquierQuerys(query);

            DS.Tables.Add(dt);
            EETipoDePago Codigo = new EETipoDePago();

            foreach (DataRow Item in DS.Tables[0].Rows)
            {

                Codigo.Descripcion = Item[0].ToString().Trim();

            }

            if (Codigo.Descripcion is null)
            {
                Codigo.Descripcion = "0";
            }



            var suma = Convert.ToInt32(Codigo.Descripcion.ToString()) + 1;






            return suma.ToString();


        }
        private bool Validar()
        {
            bool respuesta = true;
            if (Convert.ToInt32(ObtenerNumeroComprobante()) != Convert.ToInt32(lblCorrelativo.Text))
            {
                respuesta = false;
                MessageBox.Show("El numero de comprobante ya ha sido emitido anteriormente , porfavor crear una nueva factura ");

            }

            return respuesta;
        }

        private void pagar_Click(object sender, EventArgs e)
        {
            Pagos buspago = new Pagos();
            buspago.Reserva = Reserva;
            buspago.TotalAPagar = Convert.ToSingle(txtseña.Text);
            buspago.condicion = 2;
            this.Close();
            buspago.Show();
        }
    }
}

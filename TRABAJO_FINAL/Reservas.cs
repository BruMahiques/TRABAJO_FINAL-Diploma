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
    public partial class Reservas : Form
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

                if (label15.Tag != null && Traducciones.ContainsKey(label15.Tag.ToString()))
                    label15.Text = Traducciones[label15.Tag.ToString()].Texto;

                if (label15.Tag != null && Traducciones.ContainsKey(label15.Tag.ToString()))
                    label15.Text = Traducciones[label15.Tag.ToString()].Texto;
                                
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
            
            ObtenerEnum(1, cboTipoPago);
            ObtenerEnum(3, cboTipDoc);
            /*
            label6.Text = cboComprobante.Text.Substring(2);
            lblSerie.Text = "000" + cboComprobante.Text.Substring(0, 2);
            */
            ObtenerNumeroComprobante();
            
            btnImprimir.Enabled = false;

            btnGuardar.Enabled = ValidarCampos();
            
        }

        public List<EEProducto> listaRes = new List<EEProducto>();
        public EECliente Cliente = new EECliente();
        public List<EEEnum> Enum;
        public BLLReservas BLLReservas = new BLLReservas();
        public BLLVentaDet BLLVentaDet = new BLLVentaDet();

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
        }

        private void btnAgregarItem_Click(object sender, EventArgs e)
        {
            BuscarProducto buspro = new BuscarProducto();
            buspro.listaRes2 = listaRes;
            buspro.ClienRes2 = Cliente;
            this.Close();
            buspro.Show();

        }
        public void ObtenerEnum(int constante, ComboBox combo)
        {
            Enum = new List<EEEnum>();
            Enum = BLLEnum.ObtenerEnum(constante);

            combo.DataSource = Enum;
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
                row.Cells["Total"].Value = Convert.ToDecimal(row.Cells["Precio"].Value) * Convert.ToDecimal(row.Cells["Cantidad"].Value);
                total += Convert.ToDouble(row.Cells["Total"].Value);

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
            try
            {
                
                EEReservas Reserva = new EEReservas();
                Reserva.Cod_Comprobante = lblSerie.Text + lblCorrelativo.Text;
                Reserva.Id_TipoDePago = Convert.ToInt32(cboTipoPago.Text.Substring(0, 1));
                Reserva.Id_TipoDeDoc = Convert.ToInt32(cboTipDoc.Text.Substring(0, 1));
                Reserva.Fecha = Convert.ToDateTime(dtpFechaEmision.Value);
                Reserva.Estado = "Reservado";
                Reserva.Id_Cliente_Reserva = Convert.ToInt32(txtCodUsuario.Text);
                Reserva.Seña = Convert.ToInt32(txtseña.Text);
                Reserva.Total = Convert.ToInt32(txtTotal.Text);

                BLLReservas.Alta_Reserva(Reserva);



                    foreach (DataGridViewRow r in dgvDetalleBoleta.Rows)
                    {
                        EEVentaDet Venta_Det = new EEVentaDet();
                        Venta_Det.Id_Producto_Det = Convert.ToInt32(r.Cells[0].Value);
                        Venta_Det.Id_Venta_Det = Convert.ToInt32(lblCorrelativo.Text);
                        Venta_Det.Precio_Prod_Det = Convert.ToInt32(r.Cells[2].Value);
                        Venta_Det.Cantidad_Det = Convert.ToInt32(r.Cells[3].Value);
                        Venta_Det.Total_Det = Convert.ToInt32(r.Cells[4].Value);
                        BLLReservas.Alta_Reserva_Det(Venta_Det);
                        
                    }

                    btnBuscarCliente.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnAgregarItem.Enabled = false;
                    btnQuitarItem.Enabled = false;
                    btnAnular.Enabled = false;
                    dgvDetalleBoleta.ReadOnly = true;

                
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("Debe introducir una seña");
                return;
            }
        }
        void ObtenerNumeroComprobante()
        {
            Acceso Datos = new Acceso();
            DataTable ds = new DataTable();
            DataSet DS = new DataSet();

            string query = "select TOP 1 Cod_Comprobante from Reservas order by Id_Reserva DESC";


            ds = Datos.EjecutarCualquierQuerys(query);

            DS.Tables.Add(ds);


            foreach (DataRow Item in DS.Tables[0].Rows)
            {
                EEEnum Comprobante = new EEEnum();
                Comprobante.Descripcion = Item[0].ToString().Trim();
                query = Comprobante.Descripcion;
            }

            query = query.Substring(2);
            int suma;
            suma = Convert.ToInt32(query) + 1;





            lblCorrelativo.Text = suma.ToString();


        }
    }
}

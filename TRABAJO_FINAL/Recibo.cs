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
    public partial class Recibo : Form, InterfazIdiomaObserver
    {
        public Recibo()
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


                if (label2.Tag != null && Traducciones.ContainsKey(label2.Tag.ToString()))
                    label2.Text = Traducciones[label2.Tag.ToString()].Texto;


                if (label1.Tag != null && Traducciones.ContainsKey(label1.Tag.ToString()))
                    label1.Text = Traducciones[label1.Tag.ToString()].Texto;




            }

        }

        public EERecibo recibo = new EERecibo();
        public EECliente Client = new EECliente();
        
        private void Recibo_Load(object sender, EventArgs e)
        {
            recibo.Cliente = recibo.Venta.Cliente;
            txtCodUsuario.Text = recibo.Cliente.Cod_Cliente.ToString();
            txtNombreCliente.Text = recibo.Cliente.Nombre;
            txtNumDoc.Text = recibo.Cliente.DNI.ToString();
            txtCorreo.Text = recibo.Cliente.Correo;
            cod_venta.Text = recibo.Venta.Id_Venta.ToString();
            lblCorrelativo.Text = ObtenerNumeroComprobante();

           
            

            foreach (var dato in recibo.Venta.LDetalle)
            {
                dgvDetalleBoleta.Rows.Add(dato.Producto.Cod_Producto, dato.Producto.Nombre_Producto, dato.Producto.Precio_Venta, dato.Producto.Stock, dato.Sub_total);
            }

            double total = 0;

            foreach (DataGridViewRow row in dgvDetalleBoleta.Rows)
            {
                
                total += Convert.ToSingle(row.Cells["Subtotal"].Value);

            }

            txtTotal.Text = total.ToString();

            btnImprimir.Enabled = false;

            Singleton.Instancia.SuscribirObs(this);

        }
        private void Recibo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Singleton.Instancia.DesuscribirObs(this);
        }
        string ObtenerNumeroComprobante()
        {
            Acceso Datos = new Acceso();
            DataTable dt = new DataTable();
            DataSet DS = new DataSet();

            string query = "select TOP 1 Id_Recibo from Recibo order by Id_Recibo DESC";

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

        private void btnAnular_Click(object sender, EventArgs e)
        {
            dgvDetalleBoleta.Rows.Clear();
            
            txtCodUsuario.Text = string.Empty;
            txtNombreCliente.Text = string.Empty;
            txtNumDoc.Text = string.Empty;
            txtCorreo.Text = string.Empty;

            
            btnImprimir.Enabled = false;
            btnGuardar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(ObtenerNumeroComprobante()) != Convert.ToInt32(lblCorrelativo.Text))
            {
                
                MessageBox.Show("El numero de comprobante ya ha sido emitido anteriormente , porfavor crear otro recibo ");

            }
            else
            {
                BLLProducto bllProducto = new BLLProducto();
                BLLReciboDet bLLReciboDet = new BLLReciboDet();
                BLLRecibo bllrecibo = new BLLRecibo();
                List<EEReciboDet> ldetallerec = new List<EEReciboDet>();
                BLLVenta BLLVenta = new BLLVenta();


                recibo.Id_Recibo = Convert.ToInt32(lblCorrelativo.Text);
                recibo.Cod_Comprobante = lblSerie.Text + lblCorrelativo.Text;
                recibo.Fecha = Convert.ToDateTime(dtpFechaEmision.Value);
                recibo.Estado = "Emitido";

                recibo.Total = Convert.ToInt32(txtTotal.Text);
                bllrecibo.Alta_Recibo(recibo);

                recibo.Venta.Estado = "Entregado";
                BLLVenta.Mod_Estado(recibo.Venta);

                foreach (DataGridViewRow r in dgvDetalleBoleta.Rows)
                {
                    EEReciboDet ReciboDet = new EEReciboDet();
                    ReciboDet.Producto = bllProducto.BuscarID(Convert.ToInt32(r.Cells[0].Value));
                    ReciboDet.Id_Recibo = Convert.ToInt32(lblCorrelativo.Text);
                    ReciboDet.Cantidad = Convert.ToInt32(r.Cells[3].Value);
                    ReciboDet.Sub_total = Convert.ToInt32(r.Cells[4].Value);
                    ldetallerec.Add(ReciboDet);
                    bLLReciboDet.Alta_Recibo_Det(ReciboDet);

                }

                recibo.LDetalle = ldetallerec;

                bllrecibo.CambiarEstadoVenta(recibo.Venta.Id_Venta);

                btnImprimir.Enabled = true;
                btnGuardar.Enabled = false;
                btnAnular.Enabled = false;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Imprimiendo en Impresora Epson-5830");
           

        }
    }
}

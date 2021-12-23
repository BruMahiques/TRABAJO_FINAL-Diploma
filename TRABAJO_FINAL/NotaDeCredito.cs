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
    public partial class NotaDeCredito : Form, InterfazIdiomaObserver
    {
        public NotaDeCredito()
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

                if (label1.Tag != null && Traducciones.ContainsKey(label1.Tag.ToString()))
                    label1.Text = Traducciones[label1.Tag.ToString()].Texto;

                
                if (label2.Tag != null && Traducciones.ContainsKey(label2.Tag.ToString()))
                    label2.Text = Traducciones[label2.Tag.ToString()].Texto;


                if (label14.Tag != null && Traducciones.ContainsKey(label14.Tag.ToString()))
                    label14.Text = Traducciones[label14.Tag.ToString()].Texto;

                if (label19.Tag != null && Traducciones.ContainsKey(label19.Tag.ToString()))
                    label19.Text = Traducciones[label19.Tag.ToString()].Texto;

                if (label17.Tag != null && Traducciones.ContainsKey(label17.Tag.ToString()))
                    label17.Text = Traducciones[label17.Tag.ToString()].Texto;

                if (label6.Tag != null && Traducciones.ContainsKey(label6.Tag.ToString()))
                    label6.Text = Traducciones[label6.Tag.ToString()].Texto;


            }

        }
        public EENotaDeCredito NotaCredito = new EENotaDeCredito();
        public EECliente Clientee = new EECliente();
        public EEVentaDet EEVentaDet = new EEVentaDet();
        public List<EEVentaDet> LEEVentaDet = new List<EEVentaDet>();
        private void NotaDeCredito_Load(object sender, EventArgs e)
        {
            NotaCredito.Cliente = NotaCredito.Venta.Cliente;
            txtCodUsuario.Text = NotaCredito.Cliente.Cod_Cliente.ToString();
            txtNombreCliente.Text = NotaCredito.Cliente.Nombre;
            txtNumDoc.Text = NotaCredito.Cliente.DNI.ToString();
            txtCorreo.Text = NotaCredito.Cliente.Correo;
            cod_venta.Text = NotaCredito.Venta.Id_Venta.ToString();
            lblCorrelativo.Text = ObtenerNumeroComprobante();

            foreach (var dato in NotaCredito.Venta.LDetalle)
            {
                dgvDetalleBoleta.Rows.Add(dato.Producto.Cod_Producto, dato.Producto.Nombre_Producto, dato.Producto.Precio_Venta, dato.Cantidad, dato.Sub_total);
                                
            }

            //double total = 0;

            ArmarTotal();

            btnImprimir.Enabled = false;

            Singleton.Instancia.SuscribirObs(this);
        }

        private void NotaDeCredito_FormClosing(object sender, FormClosingEventArgs e)
        {
            Singleton.Instancia.DesuscribirObs(this);
        }

        string ObtenerNumeroComprobante()
        {
            Acceso Datos = new Acceso();
            DataTable dt = new DataTable();
            DataSet DS = new DataSet();

            string query = "select TOP 1 Id_NotaDeCredito from Nota_De_Credito order by Id_NotaDeCredito DESC";

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
        void ArmarTotal()
        {

            float total = 0;

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
            ArmarTotal();
        }

        private void dgvDetalleBoleta_KeyPress(object sender, KeyPressEventArgs e)
        {
            ArmarTotal();
        }

        private void dgvDetalleBoleta_SelectionChanged(object sender, EventArgs e)
        {
            
            try
            {

                ArmarTotal();

                dgvDetalleBoleta.CurrentCell = dgvDetalleBoleta.CurrentRow.Cells["Cantidad"];
                dgvDetalleBoleta.BeginEdit(true);
            }
            catch (Exception ex) //bloque catch para captura de error
            {
                MessageBox.Show("Acaba de borrar el último producto de la factura");
                txtTotal.Text = "-";
                btnGuardar.Enabled = false;
               
            }
        }
        

        private void btnQuitarItem_Click(object sender, EventArgs e)
        {
            if (lbleliminar.Text != "-")
            {
                foreach (var producto in NotaCredito.Venta.LDetalle)
                {
                    if (producto.Producto.Cod_Producto == Convert.ToInt32(lbleliminar.Text))
                    {
                        NotaCredito.Venta.LDetalle.Remove(producto);
                        break;
                    }
                }
                dgvDetalleBoleta.Rows.Remove(dgvDetalleBoleta.CurrentRow);
                lbleliminar.Text = "-";
            }
            //btnGuardar.Enabled = ValidarCampos();
            ArmarTotal();
        }
        bool Validar()
        {
            bool respuesta = true;
            


            foreach (DataGridViewRow row in dgvDetalleBoleta.Rows)
            {
                int codigo = Convert.ToInt32(row.Cells["Codigo"].Value);
               if( Convert.ToInt32(row.Cells["Cantidad"].Value) < 0)
                {
                    respuesta = false;
                }
                LEEVentaDet.Reverse();
                foreach (var fila in LEEVentaDet)
                {
                    if (fila.Producto.Cod_Producto == codigo && fila.Cantidad > Convert.ToInt32(row.Cells["Cantidad"].Value))
                    {
                        respuesta = false;
                    }
                }
                

            }
            return respuesta;


        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                if (Convert.ToInt32(ObtenerNumeroComprobante()) != Convert.ToInt32(lblCorrelativo.Text))
                {

                    MessageBox.Show("El numero de comprobante ya ha sido emitido anteriormente , porfavor crear otro recibo ");

                }
                else
                {
                    BLLProducto bllProducto = new BLLProducto();
                    BLLCliente bllCliente = new BLLCliente();
                    BLLNotaDeCreditoDet bllNotaDeCreditoDet = new BLLNotaDeCreditoDet();
                    BLLNotaDeCredito bllNotaDeCredito = new BLLNotaDeCredito();
                    List<EENotaDeCreditoDet> ldetallenot = new List<EENotaDeCreditoDet>();
                    BLLVenta BLLVenta = new BLLVenta();


                    NotaCredito.Id_NotaDeCredito = Convert.ToInt32(lblCorrelativo.Text);
                    NotaCredito.Cod_Comprobante = lblSerie.Text + lblCorrelativo.Text;
                    NotaCredito.Fecha = Convert.ToDateTime(dtpFechaEmision.Value);
                    NotaCredito.Estado = "Emitido";
                    NotaCredito.Cliente.Saldo= Convert.ToSingle(NotaCredito.Cliente.Saldo) + Convert.ToSingle(txtTotal.Text);
                    NotaCredito.Total = Convert.ToInt32(txtTotal.Text);
                    bllNotaDeCredito.Alta_Nota_Credito(NotaCredito);
                    bllCliente.ALta_Mod_Cliente(NotaCredito.Cliente);

                    NotaCredito.Venta.Estado = "Con Devolucion";
                    BLLVenta.Mod_Estado(NotaCredito.Venta);


                    foreach (DataGridViewRow r in dgvDetalleBoleta.Rows)
                    {
                        EENotaDeCreditoDet NotaDeCreditoDet = new EENotaDeCreditoDet();
                        NotaDeCreditoDet.Producto = bllProducto.BuscarID(Convert.ToInt32(r.Cells[0].Value));
                        NotaDeCreditoDet.Id_NotaDeCredito = Convert.ToInt32(lblCorrelativo.Text);
                        NotaDeCreditoDet.Cantidad = Convert.ToInt32(r.Cells[3].Value);
                        NotaDeCreditoDet.Sub_total = Convert.ToInt32(r.Cells[4].Value);
                        ldetallenot.Add(NotaDeCreditoDet);
                        bllNotaDeCreditoDet.Alta_NotaCredito_Det(NotaDeCreditoDet);
                        NotaDeCreditoDet.Producto.Stock = NotaDeCreditoDet.Producto.Stock + Convert.ToInt32(r.Cells[3].Value); ;
                        bllProducto.ALta_Mod_Producto(NotaDeCreditoDet.Producto);

                    }

                    NotaCredito.LDetalle = ldetallenot;

                    //bllNotaDeCredito.CambiarEstadoVenta(NotaCredito.Venta.Id_Venta);

                    btnImprimir.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnAnular.Enabled = false;
                    btnQuitarItem.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Edite la cantidad de sus productos");
            }
        }
    }
}

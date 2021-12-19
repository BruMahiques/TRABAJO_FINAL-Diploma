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
    public partial class Factura : Form, InterfazIdiomaObserver
    {
        public Factura()
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

                if (label4.Tag != null && Traducciones.ContainsKey(label4.Tag.ToString()))
                    label4.Text = Traducciones[label4.Tag.ToString()].Texto;

                if (label5.Tag != null && Traducciones.ContainsKey(label5.Tag.ToString()))
                    label5.Text = Traducciones[label5.Tag.ToString()].Texto;

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

                if (label14.Tag != null && Traducciones.ContainsKey(label14.Tag.ToString()))
                    label14.Text = Traducciones[label14.Tag.ToString()].Texto;

                if (label19.Tag != null && Traducciones.ContainsKey(label19.Tag.ToString()))
                    label19.Text = Traducciones[label19.Tag.ToString()].Texto;

                if (label17.Tag != null && Traducciones.ContainsKey(label17.Tag.ToString()))
                    label17.Text = Traducciones[label17.Tag.ToString()].Texto;

                if (Seña.Tag != null && Traducciones.ContainsKey(Seña.Tag.ToString()))
                    Seña.Text = Traducciones[Seña.Tag.ToString()].Texto;

                if (lblNumdesc.Tag != null && Traducciones.ContainsKey(lblNumdesc.Tag.ToString()))
                    lblNumdesc.Text = Traducciones[lblNumdesc.Tag.ToString()].Texto;

                if (groupBoxReserva.Tag != null && Traducciones.ContainsKey(groupBoxReserva.Tag.ToString()))
                    groupBoxReserva.Text = Traducciones[groupBoxReserva.Tag.ToString()].Texto;
                                
            }

        }

        public List<EEProducto> lista = new List<EEProducto>();
        public EECliente Clien = new EECliente();
        public List<EEEnum> Enum;
        public BLLVenta BLLVenta = new BLLVenta();
        public BLLVentaDet BLLVentaDet = new BLLVentaDet();

        public EEEnum Reservas = new EEEnum(); 


        private void Factura_Load(object sender, EventArgs e)
        {
            txtCodUsuario.Text = Clien.Cod_Cliente.ToString();
            txtNombreCliente.Text = Clien.Nombre;
            txtNumDoc.Text = Clien.DNI.ToString();
            txtCorreo.Text = Clien.Correo;

            foreach (var dato in lista)
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
            ObtenerEnum(2, cboComprobante);
            ObtenerEnum(3, cboTipDoc);

            label6.Text = cboComprobante.Text.Substring(2);
            lblSerie.Text = "000" + cboComprobante.Text.Substring(0, 2);

            ObtenerNumeroComprobante();

            btnImprimir.Enabled = false;

            btnGuardar.Enabled = ValidarCampos();

            txtSeña.Enabled = false;
            txttotalconseña.Enabled = false;

            if(Reservas.Cod_Enum!=0)
            {
                int total_con_seña = 0;
                txtSeña.Text = Reservas.Descripcion;
                total_con_seña = Convert.ToInt32(txtTotal.Text) - Convert.ToInt32(txtSeña.Text);
                txttotalconseña.Text = total_con_seña.ToString();
                DesactivarTodo();
            }

            Singleton.Instancia.SuscribirObs(this);

        }

        private void Factura_FormClosing(object sender, FormClosingEventArgs e)
        {
            Singleton.Instancia.DesuscribirObs(this);
        }


        private void ContarItems()
        {
            try
            {
                int num = 0;
                foreach (DataGridViewRow row in dgvDetalleBoleta.Rows)
                {
                    num++;
                }
                lblNumdesc.Text = "Nº Items:  " + num;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void ObtenerEnum(int constante , ComboBox combo)
        {
            Enum = new List<EEEnum>();
            Enum = BLLEnum.ObtenerEnum(constante);

            combo.DataSource = Enum;
        }
        private void CargarSerie_correlativo()
        {
           
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            BuscarCliente buscli = new BuscarCliente();
            buscli.lista3 = lista;
            this.Close();
            buscli.Show();
        }

        private void btnAgregarItem_Click(object sender, EventArgs e)
        {
            BuscarProducto buspro = new BuscarProducto();
            buspro.lista2 = lista;
            buspro.Clien2 = Clien;
            this.Close();
            buspro.Show();
            
        }

        private void btnQuitarItem_Click(object sender, EventArgs e)
        {
            if (lbleliminar.Text != "-")
            {
                foreach (var producto in lista)
                {
                    if (producto.Cod_Producto == Convert.ToInt32(lbleliminar.Text))
                    {
                        lista.Remove(producto);
                        break;
                    }
                }
                dgvDetalleBoleta.Rows.Remove(dgvDetalleBoleta.CurrentRow);
                lbleliminar.Text = "-";
            }
            btnGuardar.Enabled = ValidarCampos();
            ArmarTotalyDesc();
        }

        private void dgvDetalleBoleta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lbleliminar.Text = dgvDetalleBoleta.Rows[e.RowIndex].Cells[0].Value.ToString();
            
        }

        private void dgvDetalleBoleta_SelectionChanged(object sender, EventArgs e)
        {
            try
            {

                ArmarTotalyDesc();

                dgvDetalleBoleta.CurrentCell = dgvDetalleBoleta.CurrentRow.Cells["Cantidad"];
                dgvDetalleBoleta.BeginEdit(true);
            }
            catch (Exception ex) //bloque catch para captura de error
            {
                MessageBox.Show("Acaba de borrar el último producto de la factura");
                txtTotal.Text = "-";
                btnGuardar.Enabled = ValidarCampos();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            txtCodUsuario.Text = "-";
            txtNombreCliente.Text = string.Empty;
            txtNumDoc.Text = string.Empty;
            txtCorreo.Text = string.Empty;

            Clien.Cod_Cliente = 0;
            Clien.Nombre = string.Empty;
            Clien.DNI = 0;
            Clien.Correo = string.Empty;

            btnImprimir.Enabled = false;
            btnGuardar.Enabled = ValidarCampos();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            dgvDetalleBoleta.Rows.Clear();
            lista.Clear();
            txtCodUsuario.Text = string.Empty;
            txtNombreCliente.Text = string.Empty;
            txtNumDoc.Text = string.Empty;
            txtCorreo.Text = string.Empty;

            Clien.Cod_Cliente = 0;
            Clien.Nombre = string.Empty;
            Clien.DNI = 0;
            Clien.Correo = string.Empty;
            btnImprimir.Enabled = false;
            btnGuardar.Enabled = false;
        }

        private void cboComprobante_SelectedValueChanged(object sender, EventArgs e)
        {
            label6.Text = cboComprobante.Text.Substring(2);
            lblSerie.Text= "000"+cboComprobante.Text.Substring(0,2);
        }

        private void txtdesc_Enter(object sender, EventArgs e)
        {
            ArmarTotalyDesc();
        }

        private void txtdesc_KeyPress(object sender, KeyPressEventArgs e)
        {
            ArmarTotalyDesc();
        }

        private void dgvDetalleBoleta_KeyPress(object sender, KeyPressEventArgs e)
        {
            ArmarTotalyDesc();

        }
        void ObtenerNumeroComprobante()
        {
            Acceso Datos = new Acceso();
            DataTable ds = new DataTable();
            DataSet DS = new DataSet();

            string query = "select TOP 1 Cod_Comprobante from Venta order by Id_Venta DESC";
            

            ds = Datos.EjecutarCualquierQuerys(query);

            DS.Tables.Add(ds);

          
                foreach (DataRow Item in DS.Tables[0].Rows)
                {
                    EEEnum Comprobante = new EEEnum();
                    Comprobante.Descripcion = Item[0].ToString().Trim();
                    query = Comprobante.Descripcion;
                }

            query= query.Substring(5);
            int suma;
            suma = Convert.ToInt32(query) + 1;
            




            lblCorrelativo.Text = suma.ToString();

           
        }

        void ArmarTotalyDesc()
        {

            double total = 0;

            foreach (DataGridViewRow row in dgvDetalleBoleta.Rows)
            {
                row.Cells["Total"].Value = Convert.ToDecimal(row.Cells["Precio"].Value) * Convert.ToDecimal(row.Cells["Cantidad"].Value);
                total += Convert.ToDouble(row.Cells["Total"].Value);

            }
            if (txtdesc.Text != "-")
            {
                total = total - (total * Convert.ToDouble(txtdesc.Text)) / 100;
            }
            txtTotal.Text = total.ToString();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Factura Nueva = new Factura();
            this.Close();
            Nueva.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Imprimiendo en Impresora Epson-5830");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            btnImprimir.Enabled = true;
            try
            {
                if (ValidarStock())
                {
                    EEVenta Venta = new EEVenta();
                    Venta.Cod_Comprobante = lblSerie.Text + lblCorrelativo.Text;
                    Venta.TipoDePago.Id = Convert.ToInt32(cboTipoPago.Text.Substring(0,1));
                    Venta.TipoDeDoc.Id = Convert.ToInt32(cboTipDoc.Text.Substring(0, 1));
                    Venta.TipoDeComprobante.Id = Convert.ToInt32(cboComprobante.Text.Substring(0, 1));
                    Venta.Fecha = Convert.ToDateTime(dtpFechaEmision.Value); 
                    Venta.Estado = "Emitido";
                    Venta.Cliente.Cod_Cliente = Convert.ToInt32(txtCodUsuario.Text);
                    Venta.Total_Venta = Convert.ToInt32(txtTotal.Text);

                    BLLVenta.Alta_Venta(Venta);

                    

                    foreach (DataGridViewRow r in dgvDetalleBoleta.Rows)
                    {
                        EEVentaDet Venta_Det = new EEVentaDet();
                        Venta_Det.Producto.Cod_Producto = Convert.ToInt32(r.Cells[0].Value);
                        Venta_Det.Venta.Id_Venta = Convert.ToInt32(lblCorrelativo.Text);
                        Venta_Det.Producto.Precio_Venta = Convert.ToInt32(r.Cells[2].Value);
                        Venta_Det.Cantidad = Convert.ToInt32(r.Cells[3].Value);
                        Venta_Det.Sub_total = Convert.ToInt32(r.Cells[4].Value);
                        BLLVentaDet.Alta_Venta_Det(Venta_Det);
                        if (Venta.TipoDeComprobante.Id == 1) //Solo si es factura que reste el stock
                        {
                            BLLVentaDet.Stock_Producto(Venta_Det);
                        }
                    }
                    if (Reservas.Cod_Enum != 0)
                    {
                        
                        Mod_Estado_Reserva(Reservas.Cod_Enum);
                        
                    }

                    btnBuscarCliente.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnAgregarItem.Enabled = false;
                    btnQuitarItem.Enabled = false;
                    btnAnular.Enabled = false;
                    dgvDetalleBoleta.ReadOnly = true;

                }
                else
                {
                    MessageBox.Show("Editar la cantidad solicitada de los juegos indicados");
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
                return;
            }
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

        
        private bool ValidarStock()
        {
            Acceso Datos = new Acceso();
            

            bool respuesta = true;

            foreach (DataGridViewRow r in dgvDetalleBoleta.Rows)
            {
                DataTable dt = new DataTable();
                DataSet DS = new DataSet();

                string query = "select Stock from Productos where Cod_Producto = " + r.Cells[0].Value + " ";
                                          
                EEVentaDet Venta_Det = new EEVentaDet();
                Venta_Det.Producto.Cod_Producto = Convert.ToInt32(r.Cells[0].Value);
                Venta_Det.Venta.Id_Venta = Convert.ToInt32(lblCorrelativo.Text);
                Venta_Det.Producto.Precio_Venta = Convert.ToInt32(r.Cells[2].Value);
                Venta_Det.Cantidad = Convert.ToInt32(r.Cells[3].Value);
                Venta_Det.Sub_total = Convert.ToInt32(r.Cells[4].Value);

                dt = Datos.EjecutarCualquierQuerys(query);

                DS.Tables.Add(dt);

                foreach (DataRow Item in DS.Tables[0].Rows)
                {

                    if (Convert.ToInt32(Item[0].ToString().Trim()) < Venta_Det.Cantidad )
                    {
                        respuesta = false;
                        MessageBox.Show("La cantidad que se ingreso en el producto "+ r.Cells[1].Value + " , es mayor al stock que se tiene del mismo. El stock que queda del producto es de: "+ Item[0].ToString().Trim() );

                    }
                    
                }


            }
           

          
            return respuesta;
        }
        private void DesactivarTodo()
        {
            txtCorreo.Enabled = false;
            txtDireccion.Enabled = false;
            txtNombreCliente.Enabled = false;
            txtNumDoc.Enabled = false;
            txtSeña.Enabled = false;
            txtTotal.Enabled = false;
            txttotalconseña.Enabled = false;
            dgvDetalleBoleta.Enabled = false;
            btnAgregarItem.Enabled = false;
            btnBuscarCliente.Enabled = false;
            btnQuitarItem.Enabled = false;
            cboComprobante.Enabled = false;
        }
        void Mod_Estado_Reserva(int cod)
        {
            Acceso Datos = new Acceso();
            DataTable ds = new DataTable();
            DataSet DS = new DataSet();

            string query = "update Reservas set Estado = 'Facturado'  where Id_Reserva = ('" + cod +"')";


            ds = Datos.EjecutarCualquierQuerys(query);

            
        }
    }
}


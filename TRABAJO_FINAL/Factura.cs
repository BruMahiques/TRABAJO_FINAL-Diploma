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



namespace TRABAJO_FINAL
{
    public partial class Factura : Form
    {
        public Factura()
        {
            InitializeComponent();

            


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
                    Venta.Id_TipoDePago = Convert.ToInt32(cboTipoPago.Text.Substring(0,1));
                    Venta.Id_TipoDeDoc = Convert.ToInt32(cboTipDoc.Text.Substring(0, 1));
                    Venta.Id_TipoDeComprobante = Convert.ToInt32(cboComprobante.Text.Substring(0, 1));
                    Venta.Fecha = Convert.ToDateTime(dtpFechaEmision.Value); 
                    Venta.Estado = "Emitido";
                    Venta.Id_Cliente_Venta = Convert.ToInt32(txtCodUsuario.Text);
                    Venta.Total_Venta = Convert.ToInt32(txtTotal.Text);

                    BLLVenta.Alta_Venta(Venta);

                    

                    foreach (DataGridViewRow r in dgvDetalleBoleta.Rows)
                    {
                        EEVentaDet Venta_Det = new EEVentaDet();
                        Venta_Det.Id_Producto_Det = Convert.ToInt32(r.Cells[0].Value);
                        Venta_Det.Id_Venta_Det = Convert.ToInt32(lblCorrelativo.Text);
                        Venta_Det.Precio_Prod_Det = Convert.ToInt32(r.Cells[2].Value);
                        Venta_Det.Cantidad_Det = Convert.ToInt32(r.Cells[3].Value);
                        Venta_Det.Total_Det = Convert.ToInt32(r.Cells[4].Value);
                        BLLVentaDet.Alta_Venta_Det(Venta_Det);
                        if (Venta.Id_TipoDeComprobante == 1) //Solo si es factura que reste el stock
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
                Venta_Det.Id_Producto_Det = Convert.ToInt32(r.Cells[0].Value);
                Venta_Det.Id_Venta_Det = Convert.ToInt32(lblCorrelativo.Text);
                Venta_Det.Precio_Prod_Det = Convert.ToInt32(r.Cells[2].Value);
                Venta_Det.Cantidad_Det = Convert.ToInt32(r.Cells[3].Value);
                Venta_Det.Total_Det = Convert.ToInt32(r.Cells[4].Value);

                dt = Datos.EjecutarCualquierQuerys(query);

                DS.Tables.Add(dt);

                foreach (DataRow Item in DS.Tables[0].Rows)
                {

                    if (Convert.ToInt32(Item[0].ToString().Trim()) < Venta_Det.Cantidad_Det )
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


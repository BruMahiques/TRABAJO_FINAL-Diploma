﻿using System;
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

                
                if (label6.Tag != null && Traducciones.ContainsKey(label6.Tag.ToString()))
                    label6.Text = Traducciones[label6.Tag.ToString()].Texto;

                if (label8.Tag != null && Traducciones.ContainsKey(label8.Tag.ToString()))
                    label8.Text = Traducciones[label8.Tag.ToString()].Texto;

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

                if (Seña.Tag != null && Traducciones.ContainsKey(Seña.Tag.ToString()))
                    Seña.Text = Traducciones[Seña.Tag.ToString()].Texto;

                if (lblNumdesc.Tag != null && Traducciones.ContainsKey(lblNumdesc.Tag.ToString()))
                    lblNumdesc.Text = Traducciones[lblNumdesc.Tag.ToString()].Texto;

                if (groupBoxReserva.Tag != null && Traducciones.ContainsKey(groupBoxReserva.Tag.ToString()))
                    groupBoxReserva.Text = Traducciones[groupBoxReserva.Tag.ToString()].Texto;
                
                if (label3.Tag != null && Traducciones.ContainsKey(label3.Tag.ToString()))
                    label3.Text = Traducciones[label3.Tag.ToString()].Texto;


            }

        }

        public List<EEProducto> lista = new List<EEProducto>();
        public EECliente Clien = new EECliente();
      
        public BLLVenta BLLVenta = new BLLVenta();
        public BLLVentaDet BLLVentaDet = new BLLVentaDet();

        public BLLTipoDePago BLLTipoDePago = new BLLTipoDePago();
        public BLLProducto bllProducto = new BLLProducto();

        public EEReserva reserva = new EEReserva();

        public EEVenta VentaAPagar = new EEVenta();




        private void Factura_Load(object sender, EventArgs e)
        {
            txtCodUsuario.Text = Clien.Cod_Cliente.ToString();
            txtNombreCliente.Text = Clien.Nombre;
            txtNumDoc.Text = Clien.DNI.ToString();
            txtCorreo.Text = Clien.Correo;
            txtsaldo.Text = Clien.Saldo.ToString() ;


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

            if (btnGuardar.Enabled == true)
            {
                ArmarTotalyDesc();
            }



            lblCorrelativo.Text = ObtenerNumeroComprobante();

            btnImprimir.Enabled = false;

            btnGuardar.Enabled = ValidarCampos();

            txtSeña.Enabled = false;
            txttotalconseña.Enabled = false;
            cboTipoPago.DataSource = BLLTipoDePago.ListarTipoDePago();

            if(reserva.Id_Reserva != 0)
            {
                float total_con_seña = 0;
                txtSeña.Text = reserva.Seña.ToString() ;
                total_con_seña = Convert.ToSingle(txtTotal.Text) - Convert.ToSingle(txtSeña.Text) - Convert.ToSingle(txtsaldo.Text);
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
            btnGuardar.Enabled = false;
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
        string ObtenerNumeroComprobante()
        {
            Acceso Datos = new Acceso();
            DataTable dt = new DataTable();
            DataSet DS = new DataSet();

            string query = "select TOP 1 Id_Venta from Venta order by Id_Venta DESC";
            
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

        void ArmarTotalyDesc()
        {

            double total = 0;
            double total2 = 0;

            foreach (DataGridViewRow row in dgvDetalleBoleta.Rows)
            {
                row.Cells["Subtotal"].Value = Convert.ToSingle(row.Cells["Precio"].Value) * Convert.ToSingle(row.Cells["Cantidad"].Value);
                total += Convert.ToSingle(row.Cells["Subtotal"].Value);

            }
            if (txtdesc.Text != "-")
            {
                total = total - (total * Convert.ToSingle(txtdesc.Text)) / 100;
            }
            total2 = total;
            total2 = total2 - Convert.ToSingle(txtsaldo.Text);


            txttotalconseña.Text = total2.ToString();
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
                if (ValidarStockYCodigo())
                {

                    EEVenta Venta = new EEVenta();
                    BLLCliente bLLCliente = new BLLCliente();
                    BLLTipoDePago bLLTipoDePago = new BLLTipoDePago();
                    List<EEVentaDet> Ldetalle = new List<EEVentaDet>();

                    Venta.Cod_Comprobante = lblSerie.Text + lblCorrelativo.Text;
                    Venta.TipoDePago = bLLTipoDePago.BuscarID(Convert.ToInt32(cboTipoPago.Text.Substring(0, 1)));
                    Venta.Fecha = Convert.ToDateTime(dtpFechaEmision.Value);
                    Venta.Estado = "Emitido";
                    Venta.Cliente = bLLCliente.BuscarID(Convert.ToInt32(txtCodUsuario.Text));
                    Venta.Total_Venta = Convert.ToInt32(txtTotal.Text);
                    BLLVenta.Alta_Venta(Venta);
                   

                    foreach (DataGridViewRow r in dgvDetalleBoleta.Rows)
                    {
                        EEVentaDet Venta_Det = new EEVentaDet();
                        Venta_Det.Producto = bllProducto.BuscarID(Convert.ToInt32(r.Cells[0].Value));
                        Venta_Det.Id_Venta = Convert.ToInt32(lblCorrelativo.Text);
                        Venta_Det.Cantidad = Convert.ToInt32(r.Cells[3].Value);
                        Venta_Det.Sub_total = Convert.ToInt32(r.Cells[4].Value);
                        Ldetalle.Add(Venta_Det);
                        BLLVentaDet.Alta_Venta_Det(Venta_Det);
                        Venta_Det.Producto.Stock = Venta_Det.Producto.Stock- Convert.ToInt32(r.Cells[3].Value); ;
                        bllProducto.ALta_Mod_Producto(Venta_Det.Producto);
                    }
                    Venta.LDetalle = Ldetalle;
                    
                    

                    
                    /*if (Reservas.Cod_Enum != 0)
                    {
                        
                        Mod_Estado_Reserva(Reservas.Cod_Enum);
                        
                    }*/

                   

                    btnBuscarCliente.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnAgregarItem.Enabled = false;
                    btnQuitarItem.Enabled = false;
                    btnAnular.Enabled = false;
                    dgvDetalleBoleta.ReadOnly = true;
                    pagar.Enabled = true;
                    VentaAPagar = Venta;
                }
                else
                {
                  //  MessageBox.Show("Editar la cantidad solicitada de los juegos indicados");
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

        
        private bool ValidarStockYCodigo()
        {
            Acceso Datos = new Acceso();
            

            bool respuesta = true;

            foreach (DataGridViewRow r in dgvDetalleBoleta.Rows)
            {
                DataTable dt = new DataTable();
                DataSet DS = new DataSet();


                

                EEVentaDet Venta_Det = new EEVentaDet();
                Venta_Det.Producto = bllProducto.BuscarID(Convert.ToInt32(r.Cells[0].Value));
                Venta_Det.Id_Venta = Convert.ToInt32(lblCorrelativo.Text);
                Venta_Det.Cantidad = Convert.ToInt32(r.Cells[3].Value);
                Venta_Det.Sub_total = Convert.ToInt32(r.Cells[4].Value);

                string query = "select Stock from Productos where Cod_Producto = " + Venta_Det.Producto.Cod_Producto + " ";

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
            if (Convert.ToInt32(ObtenerNumeroComprobante()) != Convert.ToInt32(lblCorrelativo.Text))
            {
                respuesta = false;
                MessageBox.Show("El numero de comprobante ya ha sido emitido anteriormente , porfavor crear una nueva factura ");

            }
            if (txtdesc.Text != "-")
            {
                if (Convert.ToSingle(txtdesc.Text) > 50)
                {
                    respuesta = false;
                    MessageBox.Show("No se puede hacer un descuento mayor al 50%");

                }
                if (Convert.ToSingle(txtdesc.Text) < 0)
                {
                    respuesta = false;
                    MessageBox.Show("Puso un número negativo en el descuento");

                }

            }

            if (Convert.ToSingle(txttotalconseña.Text) < 0)
            {
                respuesta = false;
                MessageBox.Show("Por favor utilice todo su saldo, no puede quedar saldo a favor nuevamente");
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
            txtdesc.Enabled = false;
            
        }
        void Mod_Estado_Reserva(int cod)
        {
            Acceso Datos = new Acceso();
            DataTable ds = new DataTable();
            DataSet DS = new DataSet();

            string query = "update Reservas set Estado = 'Facturado'  where Id_Reserva = ('" + cod +"')";


            ds = Datos.EjecutarCualquierQuerys(query);

            
        }

        private void pagar_Click(object sender, EventArgs e)
        {
            Pagos buspago = new Pagos();
            buspago.Venta = VentaAPagar;
            buspago.TotalAPagar = Convert.ToSingle(txttotalconseña.Text);
            this.Close();
            buspago.Show();
        }
    }
}


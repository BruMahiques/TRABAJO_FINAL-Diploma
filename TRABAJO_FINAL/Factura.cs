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
            cboTipoPago.Items.Add("Efectivo");
            cboTipoPago.Items.Add("Código QR");
            cboTipDoc.Items.Add("DNI");
            cboTipDoc.Items.Add("CUIL");
            cboTipDoc.Items.Add("CUIT");
            cboTipDoc.Items.Add("PASAPORTE");

            double total = 0;

            foreach (DataGridViewRow row in dgvDetalleBoleta.Rows)
            {
                row.Cells["Total"].Value = Convert.ToDecimal(row.Cells["Precio"].Value) * Convert.ToDecimal(row.Cells["Cantidad"].Value);
                total += Convert.ToDouble(row.Cells["Total"].Value);

            }
            txtTotal.Text = total.ToString();




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
                lblNumItems.Text = "Nº Items:  " + num;
            }
            catch (Exception)
            {

                throw;
            }
        }
       /* private void CrearGrid()
        {
            try
            {
                dgvDetalleBoleta.Columns.Add("ColumnIdProd", "Idprod");
                dgvDetalleBoleta.Columns.Add("ColumnNombreProd", "Producto");
                dgvDetalleBoleta.Columns.Add("ColumnCantidad", "Cantidad");
                dgvDetalleBoleta.Columns.Add("ColumnPrecio", "Precio");
                dgvDetalleBoleta.Columns.Add("ColumnTotal", "Total");

                dgvDetalleBoleta.Columns[0].Visible = false;
                dgvDetalleBoleta.Columns[1].Width = 315;
                dgvDetalleBoleta.Columns[2].Width = 70;
                dgvDetalleBoleta.Columns[3].Width = 70;
                dgvDetalleBoleta.Columns[4].Width = 70;

                dgvDetalleBoleta.Columns[1].ReadOnly = true;
                dgvDetalleBoleta.Columns[2].ReadOnly = false;
                dgvDetalleBoleta.Columns[3].ReadOnly = false;
                dgvDetalleBoleta.Columns[4].ReadOnly = true;

                dgvDetalleBoleta.Columns[4].DefaultCellStyle.BackColor = Color.GreenYellow;

                DataGridViewCellStyle cssabecera = new DataGridViewCellStyle();
                cssabecera.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgvDetalleBoleta.ColumnHeadersDefaultCellStyle = cssabecera;

                dgvDetalleBoleta.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
                dgvDetalleBoleta.DefaultCellStyle.Font = new Font("Arial", 9);


                dgvDetalleBoleta.AllowUserToAddRows = false;
                dgvDetalleBoleta.MultiSelect = false;
                dgvDetalleBoleta.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            }
            catch (Exception)
            {

                throw;
            }
        }
        */
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
        }

        private void dgvDetalleBoleta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lbleliminar.Text = dgvDetalleBoleta.Rows[e.RowIndex].Cells[0].Value.ToString();
            
        }

        private void dgvDetalleBoleta_SelectionChanged(object sender, EventArgs e)
        {
            try
            {

                double total = 0;

                foreach (DataGridViewRow row in dgvDetalleBoleta.Rows)
                {
                    row.Cells["Total"].Value = Convert.ToDecimal(row.Cells["Precio"].Value) * Convert.ToDecimal(row.Cells["Cantidad"].Value);
                    total += Convert.ToDouble(row.Cells["Total"].Value);

                }
                txtTotal.Text = total.ToString();

                dgvDetalleBoleta.CurrentCell = dgvDetalleBoleta.CurrentRow.Cells["Cantidad"];
                dgvDetalleBoleta.BeginEdit(true);
            }
            catch (Exception ex) //bloque catch para captura de error
            {
                MessageBox.Show("Acaba de borrar el último producto de la factura");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtCodUsuario.Text = string.Empty;
            txtNombreCliente.Text = string.Empty;
            txtNumDoc.Text = string.Empty;
            txtCorreo.Text = string.Empty;

            Clien.Cod_Cliente = 0;
            Clien.Nombre = string.Empty;
            Clien.DNI = 0;
            Clien.Correo = string.Empty;

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
        }

        
    }
}

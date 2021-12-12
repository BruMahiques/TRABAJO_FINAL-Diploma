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
    public partial class BuscarReserva : Form
    {
        public BuscarReserva()
        {
            InitializeComponent();
        }

        BLLReservas BLLReservas = new BLLReservas();
        BLLVentaDet BLLVentaDet = new BLLVentaDet();

        private void BuscarReserva_Load(object sender, EventArgs e)
        {
            rbIdReserva.Checked = true;
            ObtenerComprobante();
            btnFacturar.Enabled = false;
            btnEntrega.Enabled = false;
        }

        private void ObtenerComprobante()
        {
            DataTable Reservas;
            string desde = dateTimeDesde.Value.ToString("yyyy-MM-dd");
            string hasta = dateTimeHasta.Value.ToString("yyyy-MM-dd");

            Reservas = BLLReservas.ListarReservasFiltrado(txtBusqComprobante.Text, desde, hasta, 7);
            dgvReserva.DataSource = null;
            dgvReserva.DataSource = Reservas;
        }

        private void Filtrar_Click(object sender, EventArgs e)
        {
            DataTable Reservas;

            string desde = dateTimeDesde.Value.ToString("yyyy-MM-dd");
            string hasta = dateTimeHasta.Value.ToString("yyyy-MM-dd");



            if (rbIdReserva.Checked == true)
            {
                Reservas = BLLReservas.ListarReservasFiltrado(txtBusqComprobante.Text, desde, hasta, 1);

            }
            else
            {
                if (rbComprobante.Checked == true)
                {
                    Reservas = BLLReservas.ListarReservasFiltrado(txtBusqComprobante.Text, desde, hasta, 2);

                }
                else
                {
                    if (rbNDoc.Checked == true)
                    {
                        Reservas = BLLReservas.ListarReservasFiltrado(txtBusqComprobante.Text, desde, hasta, 3);

                    }
                    else
                    {
                        if (rbcliente.Checked == true)
                        {
                            Reservas = BLLReservas.ListarReservasFiltrado(txtBusqComprobante.Text, desde, hasta, 4);

                        }
                        else
                        {
                            Reservas = BLLReservas.ListarReservasFiltrado(txtBusqComprobante.Text, desde, hasta, 5);

                        }

                    }
                }
            }
            dgvReserva.DataSource = null;
            dgvReserva.DataSource = Reservas;

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
           
            btnFacturar.Enabled = true;


            if (txtComprobante.Text != "-")
            {
                DataTable items;
                DataTable Reservas;

                string desde = dateTimeDesde.Value.ToString("yyyy-MM-dd");
                string hasta = dateTimeHasta.Value.ToString("yyyy-MM-dd");

                items = BLLReservas.ListarResDet(txtComprobante.Text);

                dgvItems.DataSource = null;
                dgvItems.DataSource = items;
                Reservas = BLLReservas.ListarReservasFiltrado(txtComprobante.Text, desde, hasta, 6);
                dgvReserva.DataSource = null;
                dgvReserva.DataSource = Reservas;

                foreach (DataGridViewRow fila in dgvReserva.Rows) // Para saber el estado
                {
                    if (Convert.ToInt32(fila.Cells[index: 7].Value) != 0 && fila.Cells[index: 6].Value.ToString() != "Reservado")
                    {
                        btnFacturar.Enabled = false;
                        btnEntrega.Enabled = true;
                       
                    }
                }
            }
        }

        private void dgvComprobante_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtComprobante.Text = dgvReserva.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            Factura bus = new Factura();

            int condicional = 0;

            foreach (DataGridViewRow filas in dgvItems.Rows) //Para saber si un producto no tiene stock
            {
                
                    if (Convert.ToInt32(filas.Cells[index: 0].Value) != 0)
                    {
                       
                        int stock;
                        stock = ObtenerStockProducto(Convert.ToInt32(filas.Cells[index: 0].Value));

                         if (stock == 0)
                            {
                        string codigo = filas.Cells[index: 0].Value.ToString();
                        string nombre = filas.Cells[index: 1].Value.ToString();
                        condicional = 1;

                        MessageBox.Show("El producto " + nombre + " aún no tiene stock , código: " + codigo);
                         }
                    }
                

            }
            

            foreach (DataGridViewRow fila in dgvReserva.Rows)
            {
                if (Convert.ToInt32(fila.Cells[index: 7].Value) != 0)
                {
                    EECliente dt = new EECliente();

                    dt.Cod_Cliente = Convert.ToInt32(fila.Cells[index: 7].Value);
                    dt.Nombre = fila.Cells[index: 8].Value.ToString();
                    dt.DNI = Convert.ToInt32(fila.Cells[index: 4].Value.ToString());
                    // dt.Categoria = fila.Cells[index: 3].Value.ToString();
                    dt.Correo = fila.Cells[index: 9].Value.ToString();
                    bus.Reservas.Descripcion = fila.Cells[index: 10].Value.ToString();
                    bus.Clien = dt;

                }



                
            }

            if (condicional == 0)
            {


                foreach (DataGridViewRow fila in dgvItems.Rows)
                {
                    EEProducto dt = new EEProducto();
                    if (Convert.ToInt32(fila.Cells[index: 0].Value) != 0)
                    {
                        dt.Cod_Producto = Convert.ToInt32(fila.Cells[index: 0].Value);
                        dt.Nombre_Producto = fila.Cells[index: 1].Value.ToString();
                        dt.Precio_Venta = Convert.ToDouble(fila.Cells[index: 4].Value.ToString());
                        dt.Stock = 1;//Convert.ToInt32(fila.Cells[index: 7].Value);
                        bus.lista.Add(dt);


                    }
                }

                bus.Reservas.Cod_Enum = Convert.ToInt32(txtComprobante.Text);
                
                

                this.Close();
                bus.Show();

            }
        }
        int ObtenerStockProducto(int cod)
        {
            Acceso Datos = new Acceso();
            DataTable ds = new DataTable();
            DataSet DS = new DataSet();

            string query = "select Stock from Productos where Cod_Producto = ('" + cod + "') ";


            ds = Datos.EjecutarCualquierQuerys(query);

            DS.Tables.Add(ds);

            int stock=1;

            foreach (DataRow Item in DS.Tables[0].Rows)
            {
                EEEnum Comprobante = new EEEnum();
                Comprobante.Cod_Enum = Convert.ToInt32(Item[0].ToString().Trim());
                stock = Comprobante.Cod_Enum;
            }






            return stock;
        }

        private void btnEntrega_Click(object sender, EventArgs e)
        {
            Mod_Estado_Reserva(Convert.ToInt32(txtComprobante.Text));
            btnEntrega.Enabled = false;
            ObtenerComprobante();

        }
        void Mod_Estado_Reserva(int cod)
        {
            Acceso Datos = new Acceso();
            DataTable ds = new DataTable();
            DataSet DS = new DataSet();

            string query = "update Reservas set Estado = 'Entregado'  where Id_Reserva = ('" + cod + "')";


            ds = Datos.EjecutarCualquierQuerys(query);


        }
    }
}

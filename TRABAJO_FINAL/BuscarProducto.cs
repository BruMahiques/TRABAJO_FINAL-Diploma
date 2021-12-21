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
    public partial class BuscarProducto : Form, InterfazIdiomaObserver
    {

        public BuscarProducto()
        {
            
            InitializeComponent();
            Traducir();


        }

        public List<EEProducto> lista2 = new List<EEProducto>();
        public List<EEProducto> listaRes2 = new List<EEProducto>();
        public EECliente Clien2 = new EECliente();
        public EECliente ClienRes2 = new EECliente();

        private void BuscarProducto_Load(object sender, EventArgs e)
        {
            ObtenerProductos();

            rbNombreProd.Checked = true;
            Singleton.Instancia.SuscribirObs(this);
            var bounds = Screen.FromControl(this).Bounds;
            this.Width = bounds.Width - 5;
            this.Height = bounds.Height - 110;

        }
        private void BuscarProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            Singleton.Instancia.DesuscribirObs(this);
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

                foreach (Control x in this.Controls) // Todos los controles

                {

                    if (groupBox1.Tag != null && Traducciones.ContainsKey(groupBox1.Tag.ToString()))
                        groupBox1.Text = Traducciones[groupBox1.Tag.ToString()].Texto;

                    if (rbNombreProd.Tag != null && Traducciones.ContainsKey(rbNombreProd.Tag.ToString()))
                        rbNombreProd.Text = Traducciones[rbNombreProd.Tag.ToString()].Texto;

                    if (rbCategoria.Tag != null && Traducciones.ContainsKey(rbCategoria.Tag.ToString()))
                        rbCategoria.Text = Traducciones[rbCategoria.Tag.ToString()].Texto;

                    if (Filtrar.Tag != null && Traducciones.ContainsKey(Filtrar.Tag.ToString()))
                        Filtrar.Text = Traducciones[Filtrar.Tag.ToString()].Texto;

                    if (btnCargar.Tag != null && Traducciones.ContainsKey(btnCargar.Tag.ToString()))
                        btnCargar.Text = Traducciones[btnCargar.Tag.ToString()].Texto;

                    if (btnSalir.Tag != null && Traducciones.ContainsKey(btnSalir.Tag.ToString()))
                        btnSalir.Text = Traducciones[btnSalir.Tag.ToString()].Texto;

                    if (rbPrecio.Tag != null && Traducciones.ContainsKey(rbPrecio.Tag.ToString()))
                        rbPrecio.Text = Traducciones[rbPrecio.Tag.ToString()].Texto;

                    if (rCant.Tag != null && Traducciones.ContainsKey(rCant.Tag.ToString()))
                        rCant.Text = Traducciones[rCant.Tag.ToString()].Texto;
                }
                
            }

        }

        BLLProducto BLLProducto = new BLLProducto();

        private void ObtenerProductos()
        {
            List<EEProducto> productos = BLLProducto.ListarProductos();

            dgvProductos.DataSource = null;
            dgvProductos.DataSource = productos;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            ObtenerProductos();
        }

        private void Filtrar_Click(object sender, EventArgs e)
        {
            DataTable productos;

            if (rbNombreProd.Checked == true)
            {
                productos = BLLProducto.ListarProductosFiltrado(txtBusqProd.Text, 1);

            }
            else
            {
                if (rbCategoria.Checked == true)
                {
                    productos = BLLProducto.ListarProductosFiltrado(txtBusqProd.Text, 2);

                }
                else
                {
                    if (rbPrecio.Checked == true)
                    {
                        productos = BLLProducto.ListarProductosFiltrado(txtBusqProd.Text, 3);

                    }
                    else
                    {
                        productos = BLLProducto.ListarProductosFiltrado(txtBusqProd.Text, 4);

                    }
                }
            }
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = productos;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            Factura bus = new Factura();

            bus.lista = lista2;
            bus.Clien = Clien2;

            int condicional = 0;

            foreach (DataGridViewRow filas in dgvProductos.Rows) //Para saber si un producto no tiene stock
            {
                if (filas.Selected)
                {
                    if (Convert.ToInt32(filas.Cells[index: 7].Value) == 0)
                    {
                        condicional = 1;

                        string codigo = filas.Cells[index: 0].Value.ToString();
                        string nombre = filas.Cells[index: 1].Value.ToString();

                        MessageBox.Show("El producto " + nombre + " no tiene stock , código: " + codigo);
                    }
                }

            }

            foreach (DataGridViewRow filas in dgvProductos.Rows) //Para saber si ya se eligió el mismo producto 
            {
                if (filas.Selected)
                {
                    string codigo = filas.Cells[index: 0].Value.ToString();
                    string nombre = filas.Cells[index: 1].Value.ToString();

                    foreach (var v in bus.lista)
                    {
                        if (v.Cod_Producto.ToString() == codigo)
                        {
                            condicional = 1;
                            MessageBox.Show("El producto " + nombre + " ya fue elegido para agregar a la misma factura , código: " + codigo);
                        }
                    }

                }

            }




            if (condicional == 0)
            {


                foreach (DataGridViewRow fila in dgvProductos.Rows)
                {
                    EEProducto dt = new EEProducto();
                    if (fila.Selected)
                    {
                        dt.Cod_Producto = Convert.ToInt32(fila.Cells[index: 0].Value);
                        dt.Nombre_Producto = fila.Cells[index: 1].Value.ToString();
                        dt.Precio_Venta = Convert.ToDouble(fila.Cells[index: 5].Value.ToString());
                        dt.Stock = 1;//Convert.ToInt32(fila.Cells[index: 7].Value);
                        bus.lista.Add(dt);


                    }
                }
                this.Close();
                bus.Show();

            }

        }

        private void btnReserva_Click(object sender, EventArgs e)
        {
            Reservas res = new Reservas();

            res.listaRes = listaRes2;
            res.Cliente = ClienRes2;

            int condicional = 0;



            foreach (DataGridViewRow filas in dgvProductos.Rows) //Para saber si ya se eligió el mismo producto 
            {
                if (filas.Selected)
                {
                    string codigo = filas.Cells[index: 0].Value.ToString();
                    string nombre = filas.Cells[index: 1].Value.ToString();

                    foreach (var v in res.listaRes)
                    {
                        if (v.Cod_Producto.ToString() == codigo)
                        {
                            condicional = 1;
                            MessageBox.Show("El producto " + nombre + " ya fue elegido para agregar a la misma factura , código: " + codigo);
                        }
                    }

                }

            }




            if (condicional == 0)
            {


                foreach (DataGridViewRow fila in dgvProductos.Rows)
                {
                    EEProducto dt = new EEProducto();
                    if (fila.Selected)
                    {
                        dt.Cod_Producto = Convert.ToInt32(fila.Cells[index: 0].Value);
                        dt.Nombre_Producto = fila.Cells[index: 1].Value.ToString();
                        dt.Precio_Venta = Convert.ToDouble(fila.Cells[index: 5].Value.ToString());
                        dt.Stock = 1;//Convert.ToInt32(fila.Cells[index: 7].Value);
                        res.listaRes.Add(dt);


                    }
                }
                this.Close();
                res.Show();

            }
        }
        

       
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using EE;
using System.Text.RegularExpressions;
using SERVICIOS;

namespace TRABAJO_FINAL
{
    public partial class Productos : Form, InterfazIdiomaObserver
    {
        public Productos()
        {
            InitializeComponent();
            Traducir();
        }

        BLLProducto BLLProducto = new BLLProducto();
        private void ObtenerProductos()
        {
            List<EEProducto> productos = BLLProducto.ListarProductos();

            dgvProductos.DataSource = null;
            dgvProductos.DataSource = productos;
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

                if (button2.Tag != null && Traducciones.ContainsKey(button2.Tag.ToString()))
                    button2.Text = Traducciones[button2.Tag.ToString()].Texto;

                if (btnNuevoP.Tag != null && Traducciones.ContainsKey(btnNuevoP.Tag.ToString()))
                    btnNuevoP.Text = Traducciones[btnNuevoP.Tag.ToString()].Texto;

                if (button1.Tag != null && Traducciones.ContainsKey(button1.Tag.ToString()))
                    button1.Text = Traducciones[button1.Tag.ToString()].Texto;

                if (btnEditarP.Tag != null && Traducciones.ContainsKey(btnEditarP.Tag.ToString()))
                    btnEditarP.Text = Traducciones[btnEditarP.Tag.ToString()].Texto;

                if (btnEliminarP.Tag != null && Traducciones.ContainsKey(btnEliminarP.Tag.ToString()))
                    btnEliminarP.Text = Traducciones[btnEliminarP.Tag.ToString()].Texto;

                if (btnSalirP.Tag != null && Traducciones.ContainsKey(btnSalirP.Tag.ToString()))
                    btnSalirP.Text = Traducciones[btnSalirP.Tag.ToString()].Texto;

                if (label1.Tag != null && Traducciones.ContainsKey(label1.Tag.ToString()))
                    label1.Text = Traducciones[label1.Tag.ToString()].Texto;

                if (label2.Tag != null && Traducciones.ContainsKey(label2.Tag.ToString()))
                    label2.Text = Traducciones[label2.Tag.ToString()].Texto;
                          
                if (label3.Tag != null && Traducciones.ContainsKey(label3.Tag.ToString()))
                    label3.Text = Traducciones[label3.Tag.ToString()].Texto;
                
                if (label4.Tag != null && Traducciones.ContainsKey(label4.Tag.ToString()))
                    label4.Text = Traducciones[label4.Tag.ToString()].Texto;

                if (label5.Tag != null && Traducciones.ContainsKey(label5.Tag.ToString()))
                    label5.Text = Traducciones[label5.Tag.ToString()].Texto;

                if (label6.Tag != null && Traducciones.ContainsKey(label6.Tag.ToString()))
                    label6.Text = Traducciones[label6.Tag.ToString()].Texto;

                if (label8.Tag != null && Traducciones.ContainsKey(label8.Tag.ToString()))
                    label8.Text = Traducciones[label8.Tag.ToString()].Texto;

                if (label7.Tag != null && Traducciones.ContainsKey(label7.Tag.ToString()))
                    label7.Text = Traducciones[label7.Tag.ToString()].Texto;

                if (label9.Tag != null && Traducciones.ContainsKey(label9.Tag.ToString()))
                    label9.Text = Traducciones[label9.Tag.ToString()].Texto;

               


            }

        }

        private bool ValidarCampos()
        {

            string Stock = txtStock.Text;
            bool respuesta = Regex.IsMatch(Stock, "^([0-9]+$)");
            if (respuesta == false)
            {
                MessageBox.Show("No escribio solo números en Stock", "ERROR");
                return respuesta;
            }
            
            string Precio_Venta = txtPrecioVenta.Text;
            bool respuesta8 = false;
            respuesta8 = Regex.IsMatch(Precio_Venta, "^[0-9]+([,][0-9]+)?$");
            if (respuesta8 == false)
            {
                MessageBox.Show("No escribio un numero real en Precio Venta", "ERROR");
                return respuesta8;
            }

            string Precio_Compra = txtPrecioCompra.Text;
            bool respuesta9 = false;
            respuesta9 = Regex.IsMatch(Precio_Compra, "^[0-9]+([,][0-9]+)?$");
            if (respuesta9 == false)
            {
                MessageBox.Show("No escribio un numero real en Precio Compra", "ERROR");
                return respuesta9;
            }

            double Precio_Compra2 = Convert.ToDouble(txtPrecioCompra.Text);
            double Precio_Venta2 = Convert.ToDouble(txtPrecioVenta.Text);
            bool respuesta10 = false;
            
            if (Precio_Compra2 >= Precio_Venta2)
            {

                MessageBox.Show("El Precio de compra no puede ser mayor al de la venta", "ERROR");
                return respuesta10;
            }



            return respuesta;

        }



        private void btnNuevoP_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    EEProducto Producto = new EEProducto();
                    Producto.Nombre_Producto = txtNombre.Text;
                    Producto.Duracion = txtDuracion.Text;
                    Producto.Categoria = textCategoria.Text;
                    Producto.Edad_Producto = textEdad.Text.ToString();
                    Producto.Cant_Jugadores = textCant.Text.ToString();
                    Producto.Precio_Compra = Convert.ToDouble(txtPrecioCompra.Text);
                    Producto.Precio_Venta = Convert.ToDouble(txtPrecioVenta.Text);
                    Producto.Stock = Convert.ToInt32(txtStock.Text);

                    BLLProducto.ALta_Mod_Producto(Producto);

                    ObtenerProductos();
                }
                else
                {
                    MessageBox.Show("Datos mal ingresados");
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
                return;
            }
        }

        private void btnEliminarP_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    if (ExisteClienteEnComprobante())
                    {
                        EEProducto Producto = new EEProducto();
                    Producto.Cod_Producto = Convert.ToInt32(txtCodigoP.Text);
                    Producto.Nombre_Producto = txtNombre.Text;
                    Producto.Duracion = txtDuracion.Text;
                    Producto.Categoria = textCategoria.Text;
                    Producto.Edad_Producto = textEdad.Text.ToString();
                    Producto.Cant_Jugadores = textCant.Text.ToString();
                    Producto.Precio_Compra = Convert.ToDouble(txtPrecioCompra.Text);
                    Producto.Precio_Venta = Convert.ToDouble(txtPrecioVenta.Text);
                    Producto.Stock = Convert.ToInt32(txtStock.Text);

                    BLLProducto.BAjaProducto(Producto);

                    ObtenerProductos();
                    }
                    else
                    {
                        MessageBox.Show("No se puede eliminar porque el producto se encuentra en comprobantes ya emitidos");
                    }

                }
                else
                {
                    MessageBox.Show("Datos mal ingresados");
                    return;
                }
              

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
                return;
            }
        }

        private void btnEditarP_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    EEProducto Producto = new EEProducto();
                    Producto.Cod_Producto = Convert.ToInt32(txtCodigoP.Text);
                    Producto.Nombre_Producto = txtNombre.Text;
                    Producto.Duracion = txtDuracion.Text;
                    Producto.Categoria = textCategoria.Text;
                    Producto.Edad_Producto = textEdad.Text.ToString();
                    Producto.Cant_Jugadores = textCant.Text.ToString();
                    Producto.Precio_Compra = Convert.ToDouble(txtPrecioCompra.Text);
                    Producto.Precio_Venta = Convert.ToDouble(txtPrecioVenta.Text);
                    Producto.Stock = Convert.ToInt32(txtStock.Text);

                    BLLProducto.ALta_Mod_Producto(Producto);

                    ObtenerProductos();


                }
                else
                {
                    MessageBox.Show("Datos mal ingresados");
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
                return;
            }
        }

        private void ABMProductos_Load(object sender, EventArgs e)
        {
            ObtenerProductos();
            Singleton.Instancia.SuscribirObs(this);
            var bounds = Screen.FromControl(this).Bounds;
            this.Width = bounds.Width - 5;
            this.Height = bounds.Height - 110;
        }
        private void ABMProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Singleton.Instancia.DesuscribirObs(this);
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigoP.Text = dgvProductos.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtDuracion.Text = dgvProductos.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtNombre.Text = dgvProductos.Rows[e.RowIndex].Cells[1].Value.ToString();
            textCategoria.Text = dgvProductos.Rows[e.RowIndex].Cells[6].Value.ToString();
            textEdad.Text = dgvProductos.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtPrecioCompra.Text = dgvProductos.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtPrecioVenta.Text = dgvProductos.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtStock.Text = dgvProductos.Rows[e.RowIndex].Cells[7].Value.ToString();
            textCant.Text = dgvProductos.Rows[e.RowIndex].Cells[8].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtCodigoP.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtDuracion.Text = string.Empty;
            textCategoria.Text = string.Empty;
            textEdad.Text = string.Empty;
            textCant.Text = string.Empty;
            txtPrecioVenta.Text = string.Empty;
            txtPrecioCompra.Text = string.Empty;
            txtStock.Text = string.Empty;
            
        }

        private void btnSalirP_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtCodigoP.Text = string.Empty;
        }
        private bool ExisteClienteEnComprobante() //Validamos si el producto tiene comprobantes asignados
        {
            bool respuesta3;

            EEProducto Producto = new EEProducto();
            Producto.Cod_Producto = Convert.ToInt32(txtCodigoP.Text);

            if (BLLProducto.ExisteProductoEnComprobante(Producto) == 0)
            {
                respuesta3 = true;
            }
            else
            {
                respuesta3 = false;
            }



            return respuesta3;
        }
    }
}

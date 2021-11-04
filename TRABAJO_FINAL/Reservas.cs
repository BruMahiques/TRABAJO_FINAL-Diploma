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
using System.Text.RegularExpressions;

namespace TRABAJO_FINAL
{
    public partial class Reservas : Form
    {
        public Reservas()
        {
            InitializeComponent();
            
        }

        
        BLLCliente obllCLiente = new BLLCliente();
        BLLReservas obllReservas = new BLLReservas();
        EEReservas oEEReservas = new EEReservas();
        BLLProducto BLLProducto = new BLLProducto();
        DataSet dsPrd = new DataSet();

        private void Reservas_Load(object sender, EventArgs e)
        {
            CargarComboClientes();
            Enlazar();
            CargarComboPrd();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    AsignarAlquiler();
                    obllReservas.Alta_Alquiler(oEEReservas);
                    Limpiar();
                    Enlazar();
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
        public void Limpiar()
        {
            txtCantDias.Text = string.Empty;
            txtPrecio.Text = string.Empty;
        }
        public void Enlazar()
        {
            gridAlquiler.DataSource = null;
            gridAlquiler.DataSource = obllReservas.ListarReserva();
        }
        public void CargarComboPrd()
        {

            dsPrd = BLLProducto.ListarAlquilados();
            
            comboPrd.DataSource = null;
            comboPrd.DataSource = dsPrd.Tables[0];

            comboPrd.ValueMember = "Cod_Producto"; 
            
            comboPrd.DisplayMember = "Cod_Producto";
            comboPrd.Refresh();
            
        }
        public void CargarComboClientes()
        {
            comboClientes.DataSource = null;
            comboClientes.DataSource = obllCLiente.ListarClientes();
            comboClientes.ValueMember = "Cod_Cliente";
            comboClientes.DisplayMember = "DNI";
            comboClientes.Refresh();

        }
        public void AsignarAlquiler()
        {
            oEEReservas.Cod_Cliente = Convert.ToInt16(comboClientes.SelectedValue);
            oEEReservas.Cod_Producto = Convert.ToInt16(comboPrd.SelectedValue);
            oEEReservas.Dias = Convert.ToInt32(txtCantDias.Text);
            oEEReservas.Importe = Convert.ToDouble(txtPrecio.Text);

        }
        void CambiarIdiomaEspañol(string Cultura)
        {


            label1.Text = Resource1.DNI_Cliente;
            label2.Text = Resource1.CodigoProd;
            label3.Text = Resource1.Dias;
            label4.Text = Resource1.Importe;
            btnAgregar.Text = Resource1.btnAgregar;
            button5.Text = Resource1.Salir;



        }
        void CambiarIdiomaIngles(string Cultura)
        {
            label1.Text = Resource2.DNI_Cliente;
            label2.Text = Resource2.CodigoProd;
            label3.Text = Resource2.Dias;
            label4.Text = Resource2.Importe;
            btnAgregar.Text = Resource2.btnAgregar;
            button5.Text = Resource2.Salir;

        }
       
       

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            CambiarIdiomaEspañol("Resource1");
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            CambiarIdiomaIngles("Resource2");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool ValidarCampos()
        {

            string Cant = txtCantDias.Text.Trim();

            bool respuesta3 = Regex.IsMatch(Cant, "^([0-9]+$)");
            if (respuesta3 == false)
            {
                MessageBox.Show("No escribio solo números en Cantidad de personas", "ERROR");
                return respuesta3;
            }




            string precio = txtPrecio.Text.Trim();
            bool respuesta2 = false;
            respuesta2 = Regex.IsMatch(precio, "^([0-9]+$)");
            if (respuesta2 == false)
            {
                MessageBox.Show("No escribio solo letras en Precio", "ERROR");
                return respuesta2;
            }

            return respuesta3;

        }
    }
}

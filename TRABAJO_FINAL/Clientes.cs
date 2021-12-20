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
    public partial class Clientes : Form, InterfazIdiomaObserver
    {
        public Clientes()
        {
            InitializeComponent();
            Traducir();
           
        }
        BLLCliente BLLCliente = new BLLCliente();

        private void ObtenerClientes()
        {
            List<EECliente> clientes = BLLCliente.ListarClientes();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = clientes;
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

                if (btnNuevoP.Tag != null && Traducciones.ContainsKey(btnNuevoP.Tag.ToString()))
                    btnNuevoP.Text = Traducciones[btnNuevoP.Tag.ToString()].Texto;

                if (btnEditarP.Tag != null && Traducciones.ContainsKey(btnEditarP.Tag.ToString()))
                    btnEditarP.Text = Traducciones[btnEditarP.Tag.ToString()].Texto;

                if (btnEliminarP.Tag != null && Traducciones.ContainsKey(btnEliminarP.Tag.ToString()))
                    btnEliminarP.Text = Traducciones[btnEliminarP.Tag.ToString()].Texto;

                if (label1.Tag != null && Traducciones.ContainsKey(label1.Tag.ToString()))
                    label1.Text = Traducciones[label1.Tag.ToString()].Texto;

                if (label2.Tag != null && Traducciones.ContainsKey(label2.Tag.ToString()))
                    label2.Text = Traducciones[label2.Tag.ToString()].Texto;

                if (button4.Tag != null && Traducciones.ContainsKey(button4.Tag.ToString()))
                    button4.Text = Traducciones[button4.Tag.ToString()].Texto;

                if (label3.Tag != null && Traducciones.ContainsKey(label3.Tag.ToString()))
                    label3.Text = Traducciones[label3.Tag.ToString()].Texto;

               
                if (label4.Tag != null && Traducciones.ContainsKey(label4.Tag.ToString()))
                    label4.Text = Traducciones[label4.Tag.ToString()].Texto;

                if (label5.Tag != null && Traducciones.ContainsKey(label5.Tag.ToString()))
                    label5.Text = Traducciones[label5.Tag.ToString()].Texto;

                if (label6.Tag != null && Traducciones.ContainsKey(label6.Tag.ToString()))
                    label6.Text = Traducciones[label6.Tag.ToString()].Texto;

                if (label7.Tag != null && Traducciones.ContainsKey(label7.Tag.ToString()))
                    label7.Text = Traducciones[label7.Tag.ToString()].Texto;


            }

        }

        

        private bool ValidarCampos()
        {
            
                string DNI = textBox3.Text;

                bool respuesta3 = Regex.IsMatch(DNI, "^([0-9]+$)");
                if (respuesta3 == false)
                {
                    MessageBox.Show("No escribio solo números en DNI", "ERROR");
                    return respuesta3;
                }



                string Nombre = textBox1.Text;
                bool respuesta = false;
                respuesta = Regex.IsMatch(Nombre, "^([a-zA-Z]+$)");
                if (respuesta == false)
                {
                    MessageBox.Show("No escribio solo letras en Nombre", "ERROR");
                    return respuesta;
                }


                string Apellido = textBox2.Text;
                bool respuesta2 = false;
                respuesta2 = Regex.IsMatch(Apellido, "^([a-zA-Z]+$)");
                if (respuesta2 == false)
                {
                    MessageBox.Show("No escribio solo letras en Apellido", "ERROR");
                    return respuesta2;
                }

                string Fecha = Convert.ToDateTime(dateTimePicker1.Text).ToString("dd/MM/yyyy");
                bool Respuesta5 = Regex.IsMatch(Fecha, "^[0-9]{2}/[0-9]{2}/[0-9]{4}$");

                if (respuesta2 == false)
                {
                    MessageBox.Show("No escribio bien la fecha", "ERROR");
                    return Respuesta5;
                }

                string correo = textBox4.Text;

                bool respuesta4 = false;
                respuesta4 = Regex.IsMatch(correo, "^[_a-z0-9-]+(.[_a-z0-9-]+)*@[a-z0-9-]+(.[a-z0-9-]+)*(.[a-z]{2,4})$");
                if (respuesta4 == false)
                {
                    MessageBox.Show("Escribio mal el correo ", "ERROR");
                    return respuesta4;
                }

                return respuesta;
            
        }

        private void ABMClienteConectado_Load(object sender, EventArgs e)
        {
            ObtenerClientes();
            Singleton.Instancia.SuscribirObs(this);
            var bounds = Screen.FromControl(this).Bounds;
            this.Width = bounds.Width - 5;
            this.Height = bounds.Height - 110;
        }
        private void ABMClienteConectado_FormClosing(object sender, FormClosingEventArgs e)
        {
            Singleton.Instancia.DesuscribirObs(this);
        }




        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox4.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            dateTimePicker1.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
        }

        private void btnNuevoP_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    EECliente Cliente = new EECliente();
                    Cliente.Nombre = textBox1.Text;
                    Cliente.Apellido = textBox2.Text;
                    Cliente.DNI = Convert.ToInt32(textBox3.Text);
                    Cliente.FechaNac = Convert.ToDateTime(dateTimePicker1.Text);
                    Cliente.Correo = textBox4.Text;

                    BLLCliente.ALta_Mod_Cliente(Cliente);

                    ObtenerClientes();
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
                        EECliente Cliente = new EECliente();
                        Cliente.Cod_Cliente = Convert.ToInt32(textBox5.Text);
                        Cliente.Nombre = textBox1.Text;
                        Cliente.Apellido = textBox2.Text;
                        Cliente.DNI = Convert.ToInt32(textBox3.Text);
                        Cliente.FechaNac = Convert.ToDateTime(dateTimePicker1.Text);
                        Cliente.Correo = textBox4.Text;

                        BLLCliente.BAjaCliente(Cliente);

                        ObtenerClientes();
                    }
                    else
                    {
                        MessageBox.Show("No se puede eliminar porque el cliente tiene comprobantes ya emitidos");
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
                    EECliente Cliente = new EECliente();
                    Cliente.Cod_Cliente = Convert.ToInt32(textBox5.Text);
                    Cliente.Nombre = textBox1.Text;
                    Cliente.Apellido = textBox2.Text;
                    Cliente.DNI = Convert.ToInt32(textBox3.Text);
                    Cliente.FechaNac = Convert.ToDateTime(dateTimePicker1.Text);
                    Cliente.Correo = textBox4.Text;

                    BLLCliente.ALta_Mod_Cliente(Cliente);

                    ObtenerClientes();
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
        private bool ExisteClienteEnComprobante() //Validamos si el cliente tiene comprobantes asignados
        {
            bool respuesta3;

            EECliente Cliente = new EECliente();
            Cliente.Cod_Cliente = Convert.ToInt32(textBox5.Text);

            if (BLLCliente.ExisteClienteEnComprobante(Cliente) == 0)
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

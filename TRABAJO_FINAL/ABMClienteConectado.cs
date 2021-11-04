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

namespace TRABAJO_FINAL
{
    public partial class ABMClienteConectado : Form
    {
        public ABMClienteConectado()
        {
            InitializeComponent();
           
        }
        BLLCliente BLLCliente = new BLLCliente();

        private void ObtenerClientes()
        {
            List<EECliente> clientes = BLLCliente.ListarClientes();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = clientes;
        }

        private void button1_Click(object sender, EventArgs e)
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

        private bool ValidarCampos()
        {
            
                string Cod = textBox5.Text;

                bool respuesta = Regex.IsMatch(Cod, "^([0-9]+$)");
                if (respuesta == false)
                {
                    MessageBox.Show("No escribio un número en Cod_Cliente", "ERROR");
                    return respuesta;
                }
            
            
         
                string DNI = textBox3.Text;

                bool respuesta3 = Regex.IsMatch(DNI, "^([0-9]+$)");
                if (respuesta3 == false)
                {
                    MessageBox.Show("No escribio solo números en DNI", "ERROR");
                    return respuesta3;
                }



                string Nombre = textBox1.Text;
                bool respuesta1 = false;
                respuesta1 = Regex.IsMatch(Nombre, "^([a-zA-Z]+$)");
                if (respuesta1 == false)
                {
                    MessageBox.Show("No escribio solo letras en Nombre", "ERROR");
                    return respuesta1;
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
        }

        private void button2_Click(object sender, EventArgs e)
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

                    BLLCliente.BAjaCliente(Cliente);

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

        private void button3_Click(object sender, EventArgs e)
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox5.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
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

        void CambiarIdiomaEspañol(string Cultura)
        {


            label1.Text = Resource1.Nombre;
            label2.Text = Resource1.Apellido;
            label3.Text = Resource1.DNI;
            label4.Text = Resource1.Fecha_de_Nacimiento;
            label5.Text = Resource1.Correo;
            label6.Text = Resource1.Codigo_del_Cliente;
            label7.Text = Resource1.ModoBaja;
            button1.Text = Resource1.btnAlta;
            button2.Text = Resource1.btnBaja;
            button3.Text = Resource1.btnModificar;
            button4.Text = Resource1.btnLimpiar;
            button5.Text = Resource1.Salir;

        }
        void CambiarIdiomaIngles(string Cultura)
        {



            label1.Text = Resource2.Nombre;
            label2.Text = Resource2.Apellido;
            label3.Text = Resource2.DNI;
            label4.Text = Resource2.Fecha_de_Nacimiento;
            label5.Text = Resource2.Correo;
            label6.Text = Resource2.Codigo_del_Cliente;
            label7.Text = Resource2.ModoBaja;
            button1.Text = Resource2.btnAlta;
            button2.Text = Resource2.btnBaja;
            button3.Text = Resource2.btnModificar;
            button4.Text = Resource2.btnLimpiar;
            button5.Text = Resource2.Salir;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            CambiarIdiomaEspañol("Resource1");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            CambiarIdiomaIngles("Resource2");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
           
            
        }
    }
}

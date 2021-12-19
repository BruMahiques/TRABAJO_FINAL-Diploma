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
    public partial class Versionado : Form, InterfazIdiomaObserver
    {
        public Versionado()
        {
            InitializeComponent();
            Traducir();
        }

        private void Versionado_Load(object sender, EventArgs e)
        {
            rbCodigoDelCliente.Checked = true;
            ObtenerClientes();
            ObtenerClientesVersionado();
            Recuperar.Enabled = false;
            Singleton.Instancia.SuscribirObs(this);
        }
        private void Versionado_FormClosing(object sender, FormClosingEventArgs e)
        {
            Singleton.Instancia.DesuscribirObs(this);
        }
        BLLCliente BLLCliente = new BLLCliente();
        private void ObtenerClientes()
        {
            List<EECliente> clientes = BLLCliente.ListarClientes();

            dgvclientes.DataSource = null;
            dgvclientes.DataSource = clientes;
        }

        private void ObtenerClientesVersionado()
        {
            List<EEClienteVersionado> clientesversionado = BLLCliente.ListarClientesVersionado();

            dgvCambios.DataSource = null;
            dgvCambios.DataSource = clientesversionado;
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

                if (groupBox1.Tag != null && Traducciones.ContainsKey(groupBox1.Tag.ToString()))
                    groupBox1.Text = Traducciones[groupBox1.Tag.ToString()].Texto;

                if (rbCodigoDelCliente.Tag != null && Traducciones.ContainsKey(rbCodigoDelCliente.Tag.ToString()))
                    rbCodigoDelCliente.Text = Traducciones[rbCodigoDelCliente.Tag.ToString()].Texto;

                if (rbApellido.Tag != null && Traducciones.ContainsKey(rbApellido.Tag.ToString()))
                    rbApellido.Text = Traducciones[rbApellido.Tag.ToString()].Texto;

                if (rbNombre.Tag != null && Traducciones.ContainsKey(rbNombre.Tag.ToString()))
                    rbNombre.Text = Traducciones[rbNombre.Tag.ToString()].Texto;

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

                if (rbDNI.Tag != null && Traducciones.ContainsKey(rbDNI.Tag.ToString()))
                    rbDNI.Text = Traducciones[rbDNI.Tag.ToString()].Texto;

                if (rbCorreo.Tag != null && Traducciones.ContainsKey(rbCorreo.Tag.ToString()))
                    rbCorreo.Text = Traducciones[rbCorreo.Tag.ToString()].Texto;

                if (label9.Tag != null && Traducciones.ContainsKey(label9.Tag.ToString()))
                    label9.Text = Traducciones[label9.Tag.ToString()].Texto;

                if (Recuperar.Tag != null && Traducciones.ContainsKey(Recuperar.Tag.ToString()))
                    Recuperar.Text = Traducciones[Recuperar.Tag.ToString()].Texto;

                if (Filtrar.Tag != null && Traducciones.ContainsKey(Filtrar.Tag.ToString()))
                    Filtrar.Text = Traducciones[Filtrar.Tag.ToString()].Texto;

            }

        }

        private void Filtrar_Click(object sender, EventArgs e)
        {
            DataTable Clientes_Filtrado;

            string desde = dateTimeDesdeH.Value.ToString("yyyy-MM-dd");
            string hasta = dateTimeHastaH.Value.ToString("yyyy-MM-dd");


            if (rbCodigoDelCliente.Checked == true)
            {
                Clientes_Filtrado = BLLCliente.ListarClientesHistoricoFiltrado(txtBusqCliente.Text, desde, hasta, 1);

            }
            else
            {
                if (rbApellido.Checked == true)
                {
                    Clientes_Filtrado = BLLCliente.ListarClientesHistoricoFiltrado(txtBusqCliente.Text, desde, hasta, 2);

                }
                else
                {
                    if (rbNombre.Checked == true)
                    {
                        Clientes_Filtrado = BLLCliente.ListarClientesHistoricoFiltrado(txtBusqCliente.Text, desde, hasta, 3);

                    }
                    else
                    {
                        if (rbDNI.Checked == true)
                        {
                            Clientes_Filtrado = BLLCliente.ListarClientesHistoricoFiltrado(txtBusqCliente.Text, desde, hasta, 4);
                        }
                        else
                        {
                            Clientes_Filtrado = BLLCliente.ListarClientesHistoricoFiltrado(txtBusqCliente.Text, desde, hasta, 5);
                        }

                    }
                }
            }
            dgvCambios.DataSource = null;
            dgvCambios.DataSource = Clientes_Filtrado;
        }

        private void dgvCambios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox5.Text = dgvCambios.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox1.Text = dgvCambios.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBox2.Text = dgvCambios.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBox3.Text = dgvCambios.Rows[e.RowIndex].Cells[3].Value.ToString();
            dateTimePicker1.Text = dgvCambios.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBox4.Text = dgvCambios.Rows[e.RowIndex].Cells[5].Value.ToString();
            Recuperar.Enabled = true;
        }

        private void Recuperar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Quiere recuperar esta version?", "Seguro?", MessageBoxButtons.YesNo);

            switch (result)
            {
                case DialogResult.Yes:
                    try
                    {
                        if (ValidarExiste())
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
                            ObtenerClientesVersionado();
                            Recuperar.Enabled = false;
                        }
                        else
                        {
                            EECliente Cliente = new EECliente();
                            Cliente.Cod_Cliente = Convert.ToInt32(textBox5.Text);
                            Cliente.Nombre = textBox1.Text;
                            Cliente.Apellido = textBox2.Text;
                            Cliente.DNI = Convert.ToInt32(textBox3.Text);
                            Cliente.FechaNac = Convert.ToDateTime(dateTimePicker1.Text);
                            Cliente.Correo = textBox4.Text;

                            BLLCliente.RecuperarClientePerdido(Cliente);

                            ObtenerClientes();
                            ObtenerClientesVersionado();
                            Recuperar.Enabled = false;

                        }



                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Se recuperó un cliente que se había eliminado");
                        ObtenerClientes();
                        ObtenerClientesVersionado();
                        Recuperar.Enabled = false;
                        return;
                    }
                    break;
                case DialogResult.No:
                    break;
                
            }
        }
        private bool ValidarExiste()
        {
            bool respuesta3;

            EECliente Cliente = new EECliente();
            Cliente.Cod_Cliente = Convert.ToInt32(textBox5.Text);

            if (BLLCliente.ExisteCliente(Cliente) == 1)
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

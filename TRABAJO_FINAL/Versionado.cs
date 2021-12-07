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

namespace TRABAJO_FINAL
{
    public partial class Versionado : Form
    {
        public Versionado()
        {
            InitializeComponent();
        }

        private void Versionado_Load(object sender, EventArgs e)
        {
            rbCodigoDelCliente.Checked = true;
            ObtenerClientes();
            ObtenerClientesVersionado();
            Recuperar.Enabled = false;
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

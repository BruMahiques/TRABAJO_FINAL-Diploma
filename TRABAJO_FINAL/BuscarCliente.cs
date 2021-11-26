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
    public partial class BuscarCliente : Form
    {
        public BuscarCliente()
        {
            InitializeComponent();
        }

        private void BuscarCliente_Load(object sender, EventArgs e)
        {
            ObtenerClientes();
        }

        BLLCliente BLLCliente = new BLLCliente();

        private void ObtenerClientes()
        {
            List<EECliente> clientes = BLLCliente.ListarClientes();

            dgvCliente.DataSource = null;
            dgvCliente.DataSource = clientes;
        }

        private void Filtrar_Click(object sender, EventArgs e)
        {
            DataTable clientes;

            if (txtNroDoc.Text != null && txtNomRazSocial.Text != null)
            {
                clientes = BLLCliente.ListarClientesFiltrado(txtNroDoc.Text, txtNomRazSocial.Text, 1);

            }
            else
            {
                if (txtNomRazSocial.Text != null)
                {
                    clientes = BLLCliente.ListarClientesFiltrado(txtNomRazSocial.Text,null, 2);

                }
                else
                {
                    clientes = BLLCliente.ListarClientesFiltrado(txtNroDoc.Text,null, 3);

                }
            }
            dgvCliente.DataSource = null;
            dgvCliente.DataSource = clientes;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            ObtenerClientes();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

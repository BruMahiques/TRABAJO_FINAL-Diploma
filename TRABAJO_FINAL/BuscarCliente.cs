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
    }
}

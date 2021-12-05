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

        public List<EEProducto> lista3 = new List<EEProducto>();

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

        private void btnVender_Click(object sender, EventArgs e)
        {
            Factura bus = new Factura();



            bus.lista = lista3;

            foreach (DataGridViewRow fila in dgvCliente.Rows)
            {
                EECliente dt = new EECliente();
                if (fila.Selected)
                {
                    dt.Cod_Cliente = Convert.ToInt32(fila.Cells[index: 0].Value);
                    dt.Nombre = fila.Cells[index: 2].Value.ToString();
                    dt.DNI = Convert.ToInt32(fila.Cells[index: 3].Value.ToString());
                    // dt.Categoria = fila.Cells[index: 3].Value.ToString();
                    dt.Correo = fila.Cells[index: 5].Value.ToString();
                    bus.Clien = dt;
                    


                }
            }

            this.Close();
            bus.Show();
        }
    }
}

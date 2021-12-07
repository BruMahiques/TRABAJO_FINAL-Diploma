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
    public partial class btnEntregado : Form
    {
        public btnEntregado()
        {
            InitializeComponent();
        }

        private void BuscarComprobante_Load(object sender, EventArgs e)
        {
            rbIdVenta.Checked = true;
            ObtenerComprobante();
            btnEmitido.Enabled = false;
            btnEntrega.Enabled = false;
            btnCancelado.Enabled = false;


        }

        BLLVenta BLLVenta = new BLLVenta();
        BLLVentaDet BLLVentaDet = new BLLVentaDet();

        private void ObtenerComprobante()
        {
            DataTable comprobantes;
            string desde = dateTimeDesde.Value.ToString("yyyy-MM-dd");
            string hasta = dateTimeHasta.Value.ToString("yyyy-MM-dd");

            comprobantes = BLLVenta.ListarVentasFiltrado(txtBusqComprobante.Text, desde, hasta, 6);
            dgvComprobante.DataSource = null;
            dgvComprobante.DataSource = comprobantes;
        }

        private void Filtrar_Click(object sender, EventArgs e)
        {
            DataTable comprobantes;

            string desde = dateTimeDesde.Value.ToString("yyyy-MM-dd");
            string hasta = dateTimeHasta.Value.ToString("yyyy-MM-dd");



            if (rbIdVenta.Checked == true)
            {
                comprobantes = BLLVenta.ListarVentasFiltrado(txtBusqComprobante.Text, desde, hasta, 1);

            }
            else
            {
                if (rbComprobante.Checked == true)
                {
                    comprobantes = BLLVenta.ListarVentasFiltrado(txtBusqComprobante.Text, desde, hasta, 2);

                }
                else
                {
                    if (rbNDoc.Checked == true)
                    {
                        comprobantes = BLLVenta.ListarVentasFiltrado(txtBusqComprobante.Text, desde, hasta, 3);

                    }
                    else
                    {
                        if (rbcliente.Checked == true)
                        {
                            comprobantes = BLLVenta.ListarVentasFiltrado(txtBusqComprobante.Text, desde, hasta, 4);

                        }
                        else
                        {
                            comprobantes = BLLVenta.ListarVentasFiltrado(txtBusqComprobante.Text, desde, hasta, 5);

                        }

                    }
                }
            }
            dgvComprobante.DataSource = null;
            dgvComprobante.DataSource = comprobantes;


        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            btnEmitido.Enabled = true;
            btnEntrega.Enabled = true;
            btnCancelado.Enabled = true;

            if (txtComprobante.Text != "-")
            { 
            DataTable items;

            items = BLLVentaDet.ListarVentaDet(txtComprobante.Text);

            dgvItems.DataSource = null;
            dgvItems.DataSource = items;
            }
        }

        private void dgvComprobante_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtComprobante.Text = dgvComprobante.Rows[e.RowIndex].Cells[0].Value.ToString();
        }
        private bool ValidarCampos()
        {

            bool respuesta = true;

            if (txtComprobante.Text == "-")
            {
                respuesta = false;

            }
            return respuesta;
        }

        private void btnEmitido_Click(object sender, EventArgs e)
        {
            Cambiar_estado("Emitido");
        }

        private void btnEntrega_Click(object sender, EventArgs e)
        {
            Cambiar_estado("Entregado");
        }

        private void btnCancelado_Click(object sender, EventArgs e)
        {
            Cambiar_estado("Cancelado");
        }

        private void Cambiar_estado(string Estado)
        {

            try
            {
                if (ValidarCampos())
                {
                    EEVenta Venta = new EEVenta();
                    Venta.Id_Venta = Convert.ToInt32(txtComprobante.Text);
                    Venta.Estado = Estado;

                    BLLVenta.Mod_Estado(Venta);

                    ObtenerComprobante();
                    btnEmitido.Enabled = false;
                    btnEntrega.Enabled = false;
                    btnCancelado.Enabled = false;
                    txtComprobante.Text = "-";
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
    }
}

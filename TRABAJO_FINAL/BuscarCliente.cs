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
    public partial class BuscarCliente : Form, InterfazIdiomaObserver
    {
        public BuscarCliente()
        {
            InitializeComponent();
            Traducir();
        }

        private void BuscarCliente_Load(object sender, EventArgs e)
        {
            ObtenerClientes();

            Singleton.Instancia.SuscribirObs(this);
            var bounds = Screen.FromControl(this).Bounds;
            this.Width = bounds.Width - 5;
            this.Height = bounds.Height - 110;
        }
        private void BuscarCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            Singleton.Instancia.DesuscribirObs(this);
        }

        BLLCliente BLLCliente = new BLLCliente();

        private void ObtenerClientes()
        {
            List<EECliente> clientes = BLLCliente.ListarClientes();

            dgvCliente.DataSource = null;
            dgvCliente.DataSource = clientes;
        }

        public List<EEProducto> lista3 = new List<EEProducto>();
        public List<EEProducto> lista4 = new List<EEProducto>();
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

                if (groupBox4.Tag != null && Traducciones.ContainsKey(groupBox4.Tag.ToString()))
                    groupBox4.Text = Traducciones[groupBox4.Tag.ToString()].Texto;

                if (label15.Tag != null && Traducciones.ContainsKey(label15.Tag.ToString()))
                    label15.Text = Traducciones[label15.Tag.ToString()].Texto;

                if (label2.Tag != null && Traducciones.ContainsKey(label2.Tag.ToString()))
                    label2.Text = Traducciones[label2.Tag.ToString()].Texto;

                if (Filtrar.Tag != null && Traducciones.ContainsKey(Filtrar.Tag.ToString()))
                    Filtrar.Text = Traducciones[Filtrar.Tag.ToString()].Texto;

                if (btnCargar.Tag != null && Traducciones.ContainsKey(btnCargar.Tag.ToString()))
                    btnCargar.Text = Traducciones[btnCargar.Tag.ToString()].Texto;

                if (btnSalir.Tag != null && Traducciones.ContainsKey(btnSalir.Tag.ToString()))
                    btnSalir.Text = Traducciones[btnSalir.Tag.ToString()].Texto;

                




            }

        }

        private void Filtrar_Click(object sender, EventArgs e)
        {
            List<EECliente> clientes;

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
                    dt.Apellido = fila.Cells[index: 1].Value.ToString();
                    dt.Nombre = fila.Cells[index: 2].Value.ToString();
                    dt.DNI = Convert.ToInt32(fila.Cells[index: 3].Value.ToString());
                    dt.FechaNac = Convert.ToDateTime(fila.Cells[index: 4].Value);
                    dt.Correo = fila.Cells[index: 5].Value.ToString();
                    bus.Clien = dt;
                    


                }
            }

            this.Close();
            bus.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reservas res = new Reservas();



            res.listaRes = lista4;

            foreach (DataGridViewRow fila in dgvCliente.Rows)
            {
                EECliente dt = new EECliente();
                if (fila.Selected)
                {
                    dt.Cod_Cliente = Convert.ToInt32(fila.Cells[index: 0].Value);
                    dt.Apellido = fila.Cells[index: 1].Value.ToString();
                    dt.Nombre = fila.Cells[index: 2].Value.ToString();
                    dt.DNI = Convert.ToInt32(fila.Cells[index: 3].Value.ToString());
                    dt.FechaNac = Convert.ToDateTime(fila.Cells[index: 4].Value);
                    dt.Correo = fila.Cells[index: 5].Value.ToString();
                    res.Cliente = dt;



                }
            }

            this.Close();
            res.Show();
        }
    }
}

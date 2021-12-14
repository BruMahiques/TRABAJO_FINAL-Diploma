using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SERVICIOS;
using EE;
using BLL;




namespace TRABAJO_FINAL
{
    public partial class MDI : Form, InterfazIdiomaObserver
    {
        private BLL.BLLUsuario bllUsuario;
        public MDI()
        {
            InitializeComponent();
            ValidarFormulario();
            MostrarIdiomas();
            MarcarIdioma();
            Traducir();

            bllUsuario = new BLLUsuario();
        }

        public void UpdateLanguage(EEIdioma idioma)
        {
            MarcarIdioma();
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

                foreach (ToolStripItem x in this.menuStrip1.Items) // Todos los menús
                {
                    if (x.Tag != null && Traducciones.ContainsKey(x.Tag.ToString()))
                        x.Text = Traducciones[x.Tag.ToString()].Texto;
                }

                foreach (Control x in this.Controls) // Todos los controles

                {
                    if (x.Tag != null && Traducciones.ContainsKey(x.Tag.ToString()))
                        x.Text = Traducciones[x.Tag.ToString()].Texto;

                    if (buscarToolStripMenuItem.Tag != null && Traducciones.ContainsKey(buscarToolStripMenuItem.Tag.ToString()))
                        buscarToolStripMenuItem.Text = Traducciones[buscarToolStripMenuItem.Tag.ToString()].Texto;


                    if (clienteToolStripMenuItem1.Tag != null && Traducciones.ContainsKey(clienteToolStripMenuItem1.Tag.ToString()))
                        clienteToolStripMenuItem1.Text = Traducciones[clienteToolStripMenuItem1.Tag.ToString()].Texto;

                    
                    if (productoToolStripMenuItem.Tag != null && Traducciones.ContainsKey(productoToolStripMenuItem.Tag.ToString()))
                        productoToolStripMenuItem.Text = Traducciones[productoToolStripMenuItem.Tag.ToString()].Texto;
                        
                    if (comprobantesToolStripMenuItem.Tag != null && Traducciones.ContainsKey(comprobantesToolStripMenuItem.Tag.ToString()))
                        comprobantesToolStripMenuItem.Text = Traducciones[comprobantesToolStripMenuItem.Tag.ToString()].Texto;

                    if (BitalStripMenuItem1.Tag != null && Traducciones.ContainsKey(BitalStripMenuItem1.Tag.ToString()))
                        BitalStripMenuItem1.Text = Traducciones[BitalStripMenuItem1.Tag.ToString()].Texto;

                    if (usuariosabmToolStripMenuItem.Tag != null && Traducciones.ContainsKey(usuariosabmToolStripMenuItem.Tag.ToString()))
                        usuariosabmToolStripMenuItem.Text = Traducciones[usuariosabmToolStripMenuItem.Tag.ToString()].Texto;

                    if (reservasToolStripMenuItem1.Tag != null && Traducciones.ContainsKey(reservasToolStripMenuItem1.Tag.ToString()))
                        reservasToolStripMenuItem1.Text = Traducciones[reservasToolStripMenuItem1.Tag.ToString()].Texto;

                    if (facturarToolStripMenuItem.Tag != null && Traducciones.ContainsKey(facturarToolStripMenuItem.Tag.ToString()))
                        facturarToolStripMenuItem.Text = Traducciones[facturarToolStripMenuItem.Tag.ToString()].Texto;

                    if (reservasToolStripMenuItem.Tag != null && Traducciones.ContainsKey(reservasToolStripMenuItem.Tag.ToString()))
                        reservasToolStripMenuItem.Text = Traducciones[reservasToolStripMenuItem.Tag.ToString()].Texto; 

                    if (informeToolStripMenuItem.Tag != null && Traducciones.ContainsKey(informeToolStripMenuItem.Tag.ToString()))
                        informeToolStripMenuItem.Text = Traducciones[informeToolStripMenuItem.Tag.ToString()].Texto;

                    if (versionadoToolStripMenuItem.Tag != null && Traducciones.ContainsKey(versionadoToolStripMenuItem.Tag.ToString()))
                        versionadoToolStripMenuItem.Text = Traducciones[versionadoToolStripMenuItem.Tag.ToString()].Texto;

                    if (serializaciónToolStripMenuItem.Tag != null && Traducciones.ContainsKey(serializaciónToolStripMenuItem.Tag.ToString()))
                        serializaciónToolStripMenuItem.Text = Traducciones[serializaciónToolStripMenuItem.Tag.ToString()].Texto;

                    if (ayudaToolStripMenuItem.Tag != null && Traducciones.ContainsKey(ayudaToolStripMenuItem.Tag.ToString()))
                        ayudaToolStripMenuItem.Text = Traducciones[ayudaToolStripMenuItem.Tag.ToString()].Texto;

                    
                    if (ventaToolStripMenuItem1.Tag != null && Traducciones.ContainsKey(ventaToolStripMenuItem1.Tag.ToString()))
                        ventaToolStripMenuItem1.Text = Traducciones[ventaToolStripMenuItem1.Tag.ToString()].Texto;

                    if (adminToolStripMenuItem1.Tag != null && Traducciones.ContainsKey(adminToolStripMenuItem1.Tag.ToString()))
                        adminToolStripMenuItem1.Text = Traducciones[adminToolStripMenuItem1.Tag.ToString()].Texto;

                    if (aBMToolStripMenuItem.Tag != null && Traducciones.ContainsKey(aBMToolStripMenuItem.Tag.ToString()))
                        aBMToolStripMenuItem.Text = Traducciones[aBMToolStripMenuItem.Tag.ToString()].Texto;

                    if (clienteToolStripMenuItem.Tag != null && Traducciones.ContainsKey(clienteToolStripMenuItem.Tag.ToString()))
                        clienteToolStripMenuItem.Text = Traducciones[clienteToolStripMenuItem.Tag.ToString()].Texto;

                    if (productosToolStripMenuItem.Tag != null && Traducciones.ContainsKey(productosToolStripMenuItem.Tag.ToString()))
                        productosToolStripMenuItem.Text = Traducciones[productosToolStripMenuItem.Tag.ToString()].Texto;

                    if (idiomasToolStripMenuItem.Tag != null && Traducciones.ContainsKey(idiomasToolStripMenuItem.Tag.ToString()))
                        idiomasToolStripMenuItem.Text = Traducciones[idiomasToolStripMenuItem.Tag.ToString()].Texto;

                    if (idiomaToolStripMenuItem1.Tag != null && Traducciones.ContainsKey(idiomaToolStripMenuItem1.Tag.ToString()))
                        idiomaToolStripMenuItem1.Text = Traducciones[idiomaToolStripMenuItem1.Tag.ToString()].Texto;

                    if (titulosDeIdiomaToolStripMenuItem1.Tag != null && Traducciones.ContainsKey(titulosDeIdiomaToolStripMenuItem1.Tag.ToString()))
                        titulosDeIdiomaToolStripMenuItem1.Text = Traducciones[titulosDeIdiomaToolStripMenuItem1.Tag.ToString()].Texto;

                    if (traduccionesDeIdiomaToolStripMenuItem1.Tag != null && Traducciones.ContainsKey(traduccionesDeIdiomaToolStripMenuItem1.Tag.ToString()))
                        traduccionesDeIdiomaToolStripMenuItem1.Text = Traducciones[traduccionesDeIdiomaToolStripMenuItem1.Tag.ToString()].Texto;

                    if (rOLToolStripMenuItem.Tag != null && Traducciones.ContainsKey(rOLToolStripMenuItem.Tag.ToString()))
                        rOLToolStripMenuItem.Text = Traducciones[rOLToolStripMenuItem.Tag.ToString()].Texto;

                    if (perfileToolStripMenuItem1.Tag != null && Traducciones.ContainsKey(perfileToolStripMenuItem1.Tag.ToString()))
                        perfileToolStripMenuItem1.Text = Traducciones[perfileToolStripMenuItem1.Tag.ToString()].Texto;

                    if (rolesToolStripMenuItem1.Tag != null && Traducciones.ContainsKey(rolesToolStripMenuItem1.Tag.ToString()))
                        rolesToolStripMenuItem1.Text = Traducciones[rolesToolStripMenuItem1.Tag.ToString()].Texto;

                    if (seleccionasIdiomaToolStripMenuItem.Tag != null && Traducciones.ContainsKey(seleccionasIdiomaToolStripMenuItem.Tag.ToString()))
                        seleccionasIdiomaToolStripMenuItem.Text = Traducciones[seleccionasIdiomaToolStripMenuItem.Tag.ToString()].Texto;

                    if (menúToolStripMenuItem.Tag != null && Traducciones.ContainsKey(menúToolStripMenuItem.Tag.ToString()))
                        menúToolStripMenuItem.Text = Traducciones[menúToolStripMenuItem.Tag.ToString()].Texto;

                    if (aBMayudaToolStripMenuItem1.Tag != null && Traducciones.ContainsKey(aBMayudaToolStripMenuItem1.Tag.ToString()))
                        aBMayudaToolStripMenuItem1.Text = Traducciones[aBMayudaToolStripMenuItem1.Tag.ToString()].Texto;

                    if (salirToolStripMenuItem1.Tag != null && Traducciones.ContainsKey(salirToolStripMenuItem1.Tag.ToString()))
                        salirToolStripMenuItem1.Text = Traducciones[salirToolStripMenuItem1.Tag.ToString()].Texto;


                }



            }

            if (Singleton.Instancia.Estalogueado())
            {
               
                ValidarPermisos();
            }

        }
        void MarcarIdioma()
        {

            if (!Singleton.Instancia.Estalogueado())
            {
                foreach (var item in seleccionasIdiomaToolStripMenuItem.DropDownItems)
                {

                    var i = ((EEIdioma)((ToolStripMenuItem)item).Tag);

                    ((ToolStripMenuItem)item).Checked = i.Por_Defecto;
                    ((ToolStripMenuItem)item).Enabled = false;

                }
            }
            else
            {
                foreach (var item in seleccionasIdiomaToolStripMenuItem.DropDownItems)
                {

                    ((ToolStripMenuItem)item).Enabled = true;
                    ((ToolStripMenuItem)item).Checked = Singleton.Instancia.Usuario.Idioma.Cod_Idioma.Equals(((EEIdioma)((ToolStripMenuItem)item).Tag).Cod_Idioma);
                }
            }

        }
                           
        
       

        private void compositeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        

        private void MDI_Load(object sender, EventArgs e)
        {
            Singleton.Instancia.SuscribirObs(this);
            IntegridadDB();
            this.FormClosed += new FormClosedEventHandler(Cerrarform);
        }

        private void Cerrarform(object sender, EventArgs e)
        {
            
                bllUsuario.Logut();
               
            
        }


        public void IntegridadDB()

        {
            SERVICIOS.DV.DigitoVerificador DV = new SERVICIOS.DV.DigitoVerificador();

            DV.VerificarIntegridadHorizonal(bllUsuario.ListarUsuarios());
            DV.VerificarIntegridadVertical(bllUsuario.ListarUsuarios());

        }
        public void ValidarFormulario() 

        {
            
            MarcarIdioma();
            Traducir();


        }
        public void ValidarPermisos() // Habilitar menu según permisos de usuario logueado

        {

            this.adminToolStripMenuItem.Enabled = Singleton.Instancia.IsInRole(EEPerfilTipoPermiso.PermisoB); // Admin
            /*this.adminToolStripMenuItem.Enabled = Singleton.Instancia.IsInRole(EEPerfilTipoPermiso.PermisoJ); // Idioma
            this.adminToolStripMenuItem.Enabled = Singleton.Instancia.IsInRole(EEPerfilTipoPermiso.PermisoC); // Asignar Perfiles a usuarios
            this.adminToolStripMenuItem.Enabled = Singleton.Instancia.IsInRole(EEPerfilTipoPermiso.PermisoN); // Versionado
            this.adminToolStripMenuItem.Enabled = Singleton.Instancia.IsInRole(EEPerfilTipoPermiso.PermisoP); // Bitacora
            this.adminToolStripMenuItem.Enabled = Singleton.Instancia.IsInRole(EEPerfilTipoPermiso.PermisoQ); // Back Up
            this.adminToolStripMenuItem.Enabled = Singleton.Instancia.IsInRole(EEPerfilTipoPermiso.PermisoA); // ABM Usuario
            this.adminToolStripMenuItem.Enabled = Singleton.Instancia.IsInRole(EEPerfilTipoPermiso.PermisoO); // Serializacion*/

            this.usuariosabmToolStripMenuItem.Enabled = Singleton.Instancia.IsInRole(EEPerfilTipoPermiso.PermisoA); // ABM Usuario
            this.rolesToolStripMenuItem1.Enabled = Singleton.Instancia.IsInRole(EEPerfilTipoPermiso.PermisoB); //  Gestion perfil usuario
            this.perfileToolStripMenuItem1.Enabled = Singleton.Instancia.IsInRole(EEPerfilTipoPermiso.PermisoC); // Asignar Perfiles a usuarios
            this.facturarToolStripMenuItem.Enabled = Singleton.Instancia.IsInRole(EEPerfilTipoPermiso.PermisoD); // Facturar
            this.reservasToolStripMenuItem.Enabled = Singleton.Instancia.IsInRole(EEPerfilTipoPermiso.PermisoE); // Reservar
            this.informeToolStripMenuItem.Enabled = Singleton.Instancia.IsInRole(EEPerfilTipoPermiso.PermisoF); // Informe
            this.clienteToolStripMenuItem.Enabled = Singleton.Instancia.IsInRole(EEPerfilTipoPermiso.PermisoG); // ABM Cliente
            this.buscarToolStripMenuItem.Enabled = Singleton.Instancia.IsInRole(EEPerfilTipoPermiso.PermisoH); // Buscar
            this.idiomasToolStripMenuItem.Enabled = Singleton.Instancia.IsInRole(EEPerfilTipoPermiso.PermisoJ); // Idioma
            this.productosToolStripMenuItem.Enabled = Singleton.Instancia.IsInRole(EEPerfilTipoPermiso.PermisoK); // ABM Productos
            this.ayudaToolStripMenuItem.Enabled = Singleton.Instancia.IsInRole(EEPerfilTipoPermiso.PermisoL); // Ayuda
            this.versionadoToolStripMenuItem.Enabled = Singleton.Instancia.IsInRole(EEPerfilTipoPermiso.PermisoN); // Versionado
            this.serializaciónToolStripMenuItem.Enabled = Singleton.Instancia.IsInRole(EEPerfilTipoPermiso.PermisoO); // Serializacion
            this.BitalStripMenuItem1.Enabled = Singleton.Instancia.IsInRole(EEPerfilTipoPermiso.PermisoP); // Bitacora
            this.backUpToolStripMenuItem.Enabled = Singleton.Instancia.IsInRole(EEPerfilTipoPermiso.PermisoQ); // Back Up



        }
        private void MostrarIdiomas()

        {
            var idiomas = BLLIdiomaTraductor.ObtenerIdiomas();

            foreach (var item in idiomas)

            {
                var t = new ToolStripMenuItem();
                t.Text = item.Idioma;
                t.Tag = item;
                this.seleccionasIdiomaToolStripMenuItem.DropDownItems.Add(t);
                t.Click += seleccionaIdiomaToolStripMenuItem_Click;

            }

        }
        
        private void backUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BackUp F5 = new BackUp();
            F5.MdiParent = this;
            F5.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Bitacora F5 = new Bitacora();
            F5.MdiParent = this;
            F5.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios F5 = new Usuarios();
            F5.MdiParent = this;
            F5.Show();
        }

        

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMClienteConectado F1 = new ABMClienteConectado();
            F1.MdiParent = this;
            F1.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMProductos F1 = new ABMProductos();
            F1.MdiParent = this;
            F1.Show();
        }

        private void idiomaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Idioma F5 = new Idioma();
            F5.MdiParent = this;
            F5.Show();
        }

        private void titulosDeIdiomaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            IdiomaTitulos F5 = new IdiomaTitulos();
            F5.MdiParent = this;
            F5.Show();
        }

        private void traduccionesDeIdiomaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            IdiomaTraducciones F5 = new IdiomaTraducciones();
            F5.MdiParent = this;
            F5.Show();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro que desea cerrar la sesión?", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                bllUsuario.Logut();
                while (ActiveMdiChild != null)
                {
                    ActiveMdiChild.Close();

                }
                ValidarFormulario();
                this.Close();
            }
        }

        private void seleccionaIdiomaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Singleton.Instancia.CambiarIdioma((EEIdioma)((ToolStripMenuItem)sender).Tag);

            MarcarIdioma();
        }

        private void perfilesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Perfiles F5 = new Perfiles();
            F5.MdiParent = this;
            F5.Show();
        }

        private void rolesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Roles F5 = new Roles();
            F5.MdiParent = this;
            F5.Show();
        }

        private void facturarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Factura F5 = new Factura();
            F5.MdiParent = this;
            F5.Show();
        }

        private void clienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BuscarCliente F5 = new BuscarCliente();
            F5.MdiParent = this;
            F5.Show();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarProducto F5 = new BuscarProducto();
            F5.MdiParent = this;
            F5.Show();
        }

        private void comprobantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuscarComprobante F5 = new BuscarComprobante();
            F5.MdiParent = this;
            F5.Show();
        }

        private void versionadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Versionado F5 = new Versionado();
            F5.MdiParent = this;
            F5.Show();
        }

        private void serializaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirSerialización F5 = new AbrirSerialización();
            F5.MdiParent = this;
            F5.Show();
              
            
        }

        private void informeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InformeVentas F5 = new InformeVentas();
            F5.MdiParent = this;
            F5.Show();
        }

        private void reservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reservas F5 = new Reservas();
            F5.MdiParent = this;
            F5.Show();
        }

        private void reservasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BuscarReserva F5 = new BuscarReserva();
            F5.MdiParent = this;
            F5.Show();
        }

        private void menúToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AyudaMenu F5 = new AyudaMenu();
            F5.MdiParent = this;
            F5.Show();
        }

        private void aBMayudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AyudaABM F5 = new AyudaABM();
            F5.MdiParent = this;
            F5.Show();
        }

        private void ventaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AyudaVenta F5 = new AyudaVenta();
            F5.MdiParent = this;
            F5.Show();
        }
    }
}

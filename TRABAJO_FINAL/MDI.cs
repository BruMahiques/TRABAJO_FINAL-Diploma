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

                    if (idiomaToolStripMenuItem.Tag != null && Traducciones.ContainsKey(idiomaToolStripMenuItem.Tag.ToString()))
                        idiomaToolStripMenuItem.Text = Traducciones[idiomaToolStripMenuItem.Tag.ToString()].Texto;


                    if (titulosDeIdiomaToolStripMenuItem.Tag != null && Traducciones.ContainsKey(titulosDeIdiomaToolStripMenuItem.Tag.ToString()))
                        titulosDeIdiomaToolStripMenuItem.Text = Traducciones[titulosDeIdiomaToolStripMenuItem.Tag.ToString()].Texto;

                    
                    if (traduccionesDeIdiomaToolStripMenuItem.Tag != null && Traducciones.ContainsKey(traduccionesDeIdiomaToolStripMenuItem.Tag.ToString()))
                        traduccionesDeIdiomaToolStripMenuItem.Text = Traducciones[traduccionesDeIdiomaToolStripMenuItem.Tag.ToString()].Texto;

                    if (idiomas1ToolStripMenuItem.Tag != null && Traducciones.ContainsKey(idiomas1ToolStripMenuItem.Tag.ToString()))
                        idiomas1ToolStripMenuItem.Text = Traducciones[idiomas1ToolStripMenuItem.Tag.ToString()].Texto;

                    if (BitalStripMenuItem1.Tag != null && Traducciones.ContainsKey(BitalStripMenuItem1.Tag.ToString()))
                        BitalStripMenuItem1.Text = Traducciones[BitalStripMenuItem1.Tag.ToString()].Texto;

                    if (usuariosToolStripMenuItem.Tag != null && Traducciones.ContainsKey(usuariosToolStripMenuItem.Tag.ToString()))
                        usuariosToolStripMenuItem.Text = Traducciones[usuariosToolStripMenuItem.Tag.ToString()].Texto;

                    if (compositeToolStripMenuItem.Tag != null && Traducciones.ContainsKey(compositeToolStripMenuItem.Tag.ToString()))
                        compositeToolStripMenuItem.Text = Traducciones[compositeToolStripMenuItem.Tag.ToString()].Texto;

                    if (perfilesToolStripMenuItem.Tag != null && Traducciones.ContainsKey(perfilesToolStripMenuItem.Tag.ToString()))
                        perfilesToolStripMenuItem.Text = Traducciones[perfilesToolStripMenuItem.Tag.ToString()].Texto;

                    if (rolesToolStripMenuItem.Tag != null && Traducciones.ContainsKey(rolesToolStripMenuItem.Tag.ToString()))
                        rolesToolStripMenuItem.Text = Traducciones[rolesToolStripMenuItem.Tag.ToString()].Texto;

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
                foreach (var item in idiomas1ToolStripMenuItem.DropDownItems)
                {

                    var i = ((EEIdioma)((ToolStripMenuItem)item).Tag);

                    ((ToolStripMenuItem)item).Checked = i.Por_Defecto;
                    ((ToolStripMenuItem)item).Enabled = false;

                }
            }
            else
            {
                foreach (var item in idiomas1ToolStripMenuItem.DropDownItems)
                {

                    ((ToolStripMenuItem)item).Enabled = true;
                    ((ToolStripMenuItem)item).Checked = Singleton.Instancia.Usuario.Idioma.Cod_Idioma.Equals(((EEIdioma)((ToolStripMenuItem)item).Tag).Cod_Idioma);
                }
            }

        }

        private void aBMCLIENTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ABMClienteConectado F1 = new ABMClienteConectado();
            F1.MdiParent = this;
            F1.Show();
        }

        private void aBMProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           /* ProductoDesconectado F2 = new ProductoDesconectado();
            F2.MdiParent = this;
            F2.Show();¨*/
        }

        private void ReservasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Reservas F3 = new Reservas();
            F3.MdiParent = this;
            F3.Show();*/
        }

        

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reporte_Consultas F5 = new Reporte_Consultas();
            F5.MdiParent = this;
            F5.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void compositeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void idiomaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Idioma F5 = new Idioma();
            F5.MdiParent = this;
            F5.Show();
        }

        private void titulosDeIdiomaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IdiomaTitulos F5 = new IdiomaTitulos();
            F5.MdiParent = this;
            F5.Show();
        }

        private void traduccionesDeIdiomaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IdiomaTraducciones F5 = new IdiomaTraducciones();
            F5.MdiParent = this;
            F5.Show();
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
            
            this.adminIdiomaToolStripMenuItem.Enabled = Singleton.Instancia.IsInRole(EEPerfilTipoPermiso.PermisoJ); // Gestión de Idiomas y Traduciones
           // this.aBMProductosToolStripMenuItem.Enabled = Singleton.Instancia.IsInRole(EEPerfilTipoPermiso.PermisoL); // ABM Productos
            this.compositeToolStripMenuItem.Enabled = Singleton.Instancia.IsInRole(EEPerfilTipoPermiso.PermisoC); // Asignar Perfiles a Usuarios
            this.adminToolStripMenuItem.Enabled = Singleton.Instancia.IsInRole(EEPerfilTipoPermiso.PermisoQ); // Gestion de Backup



        }
        private void MostrarIdiomas()

        {
            var idiomas = BLLIdiomaTraductor.ObtenerIdiomas();

            foreach (var item in idiomas)

            {
                var t = new ToolStripMenuItem();
                t.Text = item.Idioma;
                t.Tag = item;
                this.idiomas1ToolStripMenuItem.DropDownItems.Add(t);
                t.Click += idioma_Click;

            }

        }
        private void idioma_Click(object sender, EventArgs e)
        {
            Singleton.Instancia.CambiarIdioma((EEIdioma)((ToolStripMenuItem)sender).Tag);

            MarcarIdioma();
        }

        private void perfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Perfiles F5 = new Perfiles();
            F5.MdiParent = this;
            F5.Show();
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

        private void rolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Roles F5 = new Roles();
            F5.MdiParent = this;
            F5.Show();
        }
    }
}

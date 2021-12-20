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
    public partial class Roles : Form , InterfazIdiomaObserver
    {
        private BLL.BLLPerfilPatente bllPat;
        private BLL.BLLPerfilFamila bllFam;
        private EE.EEPerfilFamilia beFamSeleccion;
        private BLL.BLLPerfilComponente bllComp;
        public Roles()
        {
            InitializeComponent();
            Traducir();
            bllPat = new BLLPerfilPatente();
            bllFam = new BLLPerfilFamila();
            bllComp = new BLLPerfilComponente();
            comboBox3.DataSource = bllPat.ObtenerPatentesAtomicas();
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

                if (button2.Tag != null && Traducciones.ContainsKey(button2.Tag.ToString()))
                    button2.Text = Traducciones[button2.Tag.ToString()].Texto;

                if (button3.Tag != null && Traducciones.ContainsKey(button3.Tag.ToString()))
                    button3.Text = Traducciones[button3.Tag.ToString()].Texto;

                if (button1.Tag != null && Traducciones.ContainsKey(button1.Tag.ToString()))
                    button1.Text = Traducciones[button1.Tag.ToString()].Texto;

                if (label1.Tag != null && Traducciones.ContainsKey(label1.Tag.ToString()))
                    label1.Text = Traducciones[label1.Tag.ToString()].Texto;

                if (label2.Tag != null && Traducciones.ContainsKey(label2.Tag.ToString()))
                    label2.Text = Traducciones[label2.Tag.ToString()].Texto;

                if (button4.Tag != null && Traducciones.ContainsKey(button4.Tag.ToString()))
                    button4.Text = Traducciones[button4.Tag.ToString()].Texto;

                if (label3.Tag != null && Traducciones.ContainsKey(label3.Tag.ToString()))
                    label3.Text = Traducciones[label3.Tag.ToString()].Texto;

                if (button5.Tag != null && Traducciones.ContainsKey(button5.Tag.ToString()))
                    button5.Text = Traducciones[button5.Tag.ToString()].Texto;

                if (button6.Tag != null && Traducciones.ContainsKey(button6.Tag.ToString()))
                    button6.Text = Traducciones[button6.Tag.ToString()].Texto;

                if (label4.Tag != null && Traducciones.ContainsKey(label4.Tag.ToString()))
                    label4.Text = Traducciones[label4.Tag.ToString()].Texto;

                if (label5.Tag != null && Traducciones.ContainsKey(label5.Tag.ToString()))
                    label5.Text = Traducciones[label5.Tag.ToString()].Texto;

                if (button7.Tag != null && Traducciones.ContainsKey(button7.Tag.ToString()))
                    button7.Text = Traducciones[button7.Tag.ToString()].Texto;

                if (button8.Tag != null && Traducciones.ContainsKey(button8.Tag.ToString()))
                    button8.Text = Traducciones[button8.Tag.ToString()].Texto;

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tmp = (EEPerfilFamilia)this.comboBox1.SelectedItem;
            beFamSeleccion = new EEPerfilFamilia();
            beFamSeleccion.Id = tmp.Id;
            beFamSeleccion.Descripcion = tmp.Descripcion;

            MostrarFamilia(true);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (beFamSeleccion != null)
            {
                var familia = (EEPerfilFamilia)comboBox1.SelectedItem;
                if (familia != null)
                {

                    var esta = bllComp.Existe(beFamSeleccion, familia.Id);
                    if (esta)
                        MessageBox.Show("Ya exsite el Grupo");
                    else
                    {
                        bllComp.CompletarComponentesFamilia(familia);
                        beFamSeleccion.AgregarHijo(familia);
                        MostrarFamilia(false);
                    }


                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (beFamSeleccion != null)
            {

                var familia = (EEPerfilFamilia)comboBox1.SelectedItem;
                if (familia != null)
                {

                    var esta = bllComp.Existe(beFamSeleccion, familia.Id);
                    if (!esta)
                        MessageBox.Show("El Grupo No está Agregado");
                    else
                    {

                        bllComp.CompletarComponentesFamilia(familia);
                        beFamSeleccion.QuitarHijo(familia);
                        MostrarFamilia(false);
                    }


                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EEPerfilFamilia nFamilia = new EEPerfilFamilia()
            {
                Descripcion = textBox1.Text,
            };

            bllComp.GuardarComponente(nFamilia, true);
            CargarCombos();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (beFamSeleccion != null)
            {
                var patente = (EEPerfilPatente)comboBox2.SelectedItem;
                if (patente != null)
                {
                    var esta = bllComp.Existe(beFamSeleccion, patente.Id);
                    if (esta)
                        MessageBox.Show("Ya exsite el Permiso");
                    else
                    {

                        {
                            beFamSeleccion.AgregarHijo(patente);
                            MostrarFamilia(false);
                        }
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (beFamSeleccion != null)
            {
                var patente = (EEPerfilPatente)comboBox2.SelectedItem;
                if (patente != null)
                {
                    var esta = bllComp.Existe(beFamSeleccion, patente.Id);
                    if (!esta)
                        MessageBox.Show("El permiso no pertenece al Grupo");
                    else
                    {
                        {
                            beFamSeleccion.QuitarHijo(patente);
                            MostrarFamilia(false);
                        }
                    }
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            EEPerfilPatente nPatente = new EEPerfilPatente()
            {
                Descripcion = this.textBox2.Text,
                Permiso = (EEPerfilTipoPermiso)this.comboBox3.SelectedItem
            };

            bllComp.GuardarComponente(nPatente, false);
            CargarCombos();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                bllFam.GuardarFamilia(beFamSeleccion);
                MessageBox.Show("El Grupo se Guardó correctamente");
            }
            catch (Exception)
            {

                MessageBox.Show("Se produjo un Error al Guarda el Grupo");
            }
        }
        private void CargarCombos()

        {
            comboBox1.DataSource = bllFam.ObtenerFamilias();
            comboBox2.DataSource = bllPat.ObtenerPatentes();
            
        }

        void MostrarFamilia(bool init)
        {
            if (beFamSeleccion == null) return;

            IList<EEPerfilComponente> flia = null;

            if (init)
            {
                flia = bllComp.ObtenerTodo(beFamSeleccion);  // Traer de la DB
                foreach (var i in flia)
                    beFamSeleccion.AgregarHijo(i);
            }
            else
            {
                flia = beFamSeleccion.Hijos;
            }

            this.treeView1.Nodes.Clear();

            TreeNode root = new TreeNode(beFamSeleccion.Descripcion);
            root.Tag = beFamSeleccion;
            this.treeView1.Nodes.Add(root);

            foreach (var item in flia)
            {
                MostrarEnTree(root, item);
            }

            treeView1.ExpandAll();
        }

        void MostrarEnTree(TreeNode tn, EEPerfilComponente c)
        {
            TreeNode n = new TreeNode(c.Descripcion);
            tn.Tag = c;
            tn.Nodes.Add(n);
            if (c.Hijos != null)
                foreach (var item in c.Hijos)
                {
                    MostrarEnTree(n, item);
                }

        }

        private void Roles_Load(object sender, EventArgs e)
        {
            Singleton.Instancia.SuscribirObs(this);
            CargarCombos();
            var bounds = Screen.FromControl(this).Bounds;
            this.Width = bounds.Width - 5;
            this.Height = bounds.Height - 110;
        }
        private void Roles_FormClosing(object sender, FormClosingEventArgs e)
        {
            Singleton.Instancia.DesuscribirObs(this);
        }
    }
}

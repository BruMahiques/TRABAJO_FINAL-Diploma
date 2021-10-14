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
    public partial class Perfiles : Form
    {
        public BLL.BLLUsuario bllUsuario;
        public EE.EEUsuario EeUsuario;
        public BLL.BLLPerfilComponente bllComp;
        public BLL.BLLPerfilFamila bllFam;
        public BLL.BLLPerfilPatente bllPat;
        private EE.EEUsuario tmpUs;

        public Perfiles()
        {
            InitializeComponent();
            bllComp = new BLLPerfilComponente();
            bllUsuario = new BLLUsuario();
            bllFam = new BLLPerfilFamila();
            bllPat = new BLLPerfilPatente();
            comboUsuario.DataSource = bllUsuario.ListarUsuarios();
            comboGrupos.DataSource = bllFam.ObtenerFamilias();
            comboPermisos.DataSource = bllPat.ObtenerPatentes();
        }

        private void Perfiles_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EeUsuario = (EEUsuario)this.comboUsuario.SelectedItem;

            tmpUs = new EEUsuario();
            tmpUs.Id = EeUsuario.Id;
            tmpUs.Nombre = EeUsuario.Nombre;
            tmpUs.Apellido = EeUsuario.Apellido;
            bllComp.CargarPerfilUsuario(tmpUs);
            MostrarPerfil(tmpUs);
        }
        public void MostrarPerfil(EEUsuario Us)
        {
            this.treeArbolPermisos.Nodes.Clear();
            TreeNode raiz = new TreeNode(EeUsuario.ToString());

            foreach (var item in Us.Permisos)

            {
                LlenarTree(raiz, item);
            }

            this.treeArbolPermisos.Nodes.Add(raiz);
            this.treeArbolPermisos.ExpandAll();
        }

        public void LlenarTree(TreeNode Padre, EEPerfilComponente Comp)
        {
            TreeNode Hijo = new TreeNode(Comp.Descripcion);
            Hijo.Tag = Comp;
            Padre.Nodes.Add(Hijo);

            foreach (var item in Comp.Hijos)
            {
                LlenarTree(Hijo, item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tmpUs != null)
            {
                var Grupo = (EEPerfilFamilia)comboGrupos.SelectedItem;
                if (Grupo != null)
                {
                    var existe = false;

                    foreach (var item in tmpUs.Permisos)
                    {
                        if (bllComp.Existe(item, Grupo.Id))
                        {
                            existe = true;
                        }
                    }

                    if (existe)
                        MessageBox.Show("El usuario ya pertenece al Grupo");
                    else
                    {

                        bllComp.CompletarComponentesFamilia(Grupo);
                        tmpUs.AgregarPermiso(Grupo);
                        MostrarPerfil(tmpUs);

                    }
                }
            }
            else
                MessageBox.Show("Seleccione un usuario");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tmpUs != null)
            {
                var Grupo = (EEPerfilFamilia)comboGrupos.SelectedItem;
                if (Grupo != null)
                {
                    var existe = false;

                    foreach (var item in tmpUs.Permisos)
                    {
                        if (bllComp.Existe(item, Grupo.Id))
                        {
                            existe = true;
                        }
                    }

                    if (!existe)
                        MessageBox.Show("El Usuario no pertenece al Grupo");
                    else
                    {
                        if (tmpUs.ExistePermisoExplisito(Grupo) == true)
                        {
                            tmpUs.QuitarPermiso(Grupo);
                            MostrarPerfil(tmpUs);
                        }

                        else MessageBox.Show("No se puede Quitar el Grupo. El Usuario no pertenece al Grupo seleccionado de forma directa.");
                    }
                }
            }
            else
                MessageBox.Show("Seleccione un usuario");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (tmpUs != null)
            {
                var Permiso = (EEPerfilPatente)comboPermisos.SelectedItem;
                if (Permiso != null)
                {
                    var existe = false;

                    foreach (var item in tmpUs.Permisos)
                    {
                        if (bllComp.Existe(item, Permiso.Id))
                        {
                            existe = true;
                            break;
                        }
                    }
                    if (existe)
                        MessageBox.Show("El usuario ya posee el Permiso");
                    else
                    {
                        {
                            tmpUs.AgregarPermiso(Permiso);
                            MostrarPerfil(tmpUs);
                        }
                    }
                }
            }
            else
                MessageBox.Show("Seleccione un Usuario");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (tmpUs != null)
            {
                var Permiso = (EEPerfilPatente)comboPermisos.SelectedItem;
                if (Permiso != null)
                {
                    var existe = false;

                    foreach (var item in tmpUs.Permisos)
                    {
                        if (bllComp.Existe(item, Permiso.Id))
                        {
                            existe = true;
                            break;
                        }
                    }
                    if (!existe)
                        MessageBox.Show("El usuario no posee el Permiso");
                    else
                    {
                        {
                            if (tmpUs.ExistePermisoExplisito(Permiso) == true)
                            {
                                tmpUs.QuitarPermiso(Permiso);
                                MostrarPerfil(tmpUs);
                            }

                            else MessageBox.Show("No se puede Quitar el Permiso. El Usuario no tiene asignado el permiso de forma directa.");
                        }
                    }
                }
            }
            else
                MessageBox.Show("Seleccione un Usuario");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                bllUsuario.GuardarPermisos(tmpUs);
                MessageBox.Show("Perfil de Usuario Guardado Correctamente");
            }
            catch (Exception)
            {

                MessageBox.Show("Error al Guarda Perfil de Usuario");
            }
        }
    }
}

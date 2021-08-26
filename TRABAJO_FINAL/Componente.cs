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


namespace TRABAJO_FINAL
{
    public partial class Componente : Form
    {
        
        public Componente()
        {
            
            InitializeComponent();
            listBox1.DataSource = null;
            listBox2.DataSource = null;

            Repository Lista = new Repository();
            string d = "1";
            Lista.GetAll(d);
            dataGridView1.DataSource = Lista.GetAll(d);
            Lista.IsInRole(1);



            //listBox2.DataSource = Permiso1.ToString() ;

            string prueba = "1";
            var repo = new Repository();
            var lista = repo.GetAll(prueba);
            var puedeHacerBackup = repo.IsInRole(1);
        }
        /* 
         List<Composite> ListaComponentes = new List<Composite>();
         List<Composite> ListaPermisos = new List<Composite>();
         */ 
         private void button3_Click(object sender, EventArgs e)
        {
            /* Composite NuevoRol = new Familiaaa();
             NuevoRol.Nombre = textBox1.Text;
             NuevoRol.Descripcion = textBox2.Text;
             
            ListaComponentes.Add(NuevoRol);
            listBox1.DataSource = null;
            listBox1.DataSource = ListaComponentes;*/
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           // listBox2.DataSource = null;
           // listBox2.DataSource = ListaPermisos;
        }

        private void Button4_Click(object sender, EventArgs e)
        {


            //  Composite NuevoRolB = new Familia();
            //  NuevoRolB.Nombre = "B";
            //  NuevoRolB.Descripcion = "Segundo";

            //  Composite NuevoRolC = new Familia();
            //NuevoRolC.Nombre = "C";
            // NuevoRolC.Descripcion = "Segundo";

            //            Composite NuevoRolD = new Familia();
            // NuevoRolD.Nombre = "D";
            //NuevoRolD.Descripcion = "Tercero";

            //Composite NuevoRolE = new Familia();
            //            NuevoRolE.Nombre = "E";
            //NuevoRolE.Descripcion = "Tercero";

            //Composite PermisoF = new Permisos("F", "Agregar o Quitar roles");
            //Composite PermisoG = new Permisos("G", "Agregar o Quitar roles");
            //Composite PermisoH = new Permisos("H", "Agregar o Quitar roles");
            //Composite PermisoI = new Permisos("I", "Agregar o Quitar roles");
            //Composite PermisoJ = new Permisos("J", "Agregar o Quitar roles");

            //NuevoRolA.agregarHijo(NuevoRolB);
            //NuevoRolA.agregarHijo(NuevoRolC);

            //NuevoRolB.agregarHijo(NuevoRolD);
            //NuevoRolB.agregarHijo(NuevoRolE);


            // NuevoRolC.agregarHijo(PermisoI);
            // NuevoRolC.agregarHijo(PermisoJ);

            //            NuevoRolD.agregarHijo(PermisoF);

            //NuevoRolE.agregarHijo(PermisoG);
            //NuevoRolE.agregarHijo(PermisoH);



            treeView1.Nodes.Clear();

          
            

           // var tn = new TreeNode(NuevoRolA.Nombre + '-' + NuevoRolA.Descripcion);
           // this.treeView1.Nodes.Add(tn);
           // RecorrerArbol(NuevoRolA, tn);





        }


        


        /*void CrearArbol(Composite NuevoRol)
        {
            listaNodos = new List<Composite>();
            var nodos = BLLRoles.ListarRoles();
            int CantNodos = 0;
            if (nodos != null)
            {
                foreach (Composite nodo in nodos)
                {
                    
                    if (NuevoRol != null)
                    {
                            NuevoRol.Nombre = nodo.Nombre;
                            NuevoRol.Descripcion = nodo.Descripcion;
                            CantNodos = +1;
                                       
                    }
                   
                    
                }
            }
        }*/
        void RecorrerArbol(Componente rama, TreeNode tn)
        {

            List<Componente> ListaComponentes = new List<Componente>();
            var hijos = ListaComponentes;//rama._hijos;
            if (hijos != null)
            {
                foreach (Componente hijo in hijos)
                {
                    /*var nuevo = new TreeNode(hijo.Nombre+ '-' + hijo.Descripcion);
                    tn.Nodes.Add(nuevo);

                    RecorrerArbol(hijo, nuevo);*/
                }
            }
        }
    }
}

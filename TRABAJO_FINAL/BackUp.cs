using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SERVICIOS;
using EE;
using BLL;

namespace TRABAJO_FINAL
{
    public partial class BackUp : Form
    {
        public BackUp()
        {
            InitializeComponent();
        }
        string Directorio = @"C:\Backup\";

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SERVICIOS.BackUp.BackUp bkp = new SERVICIOS.BackUp.BackUp();
                bkp.NuevoBackup(Directorio);
                CargarBackups();
                MessageBox.Show("Backup Realizado correctamente");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void CargarBackups()

        {
            listBox1.Items.Clear();

            DirectoryInfo Carpeta = new DirectoryInfo(Directorio);
            FileInfo[] Backups = Carpeta.GetFiles("*.bak");

            foreach (FileInfo file in Backups)
            {
                listBox1.Items.Add(file.Name);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Singleton.Instancia.Usuario.Mail != "admin")

            {
                MessageBox.Show("Solo el usuario admin puede realizar esta operación");
            }

            else

            {
                if (listBox1.SelectedItem == null)

                {

                    MessageBox.Show("Debe seleccionar un backup del listado");
                }

                else

                {
                    DialogResult Respuesta = MessageBox.Show("Confirma restauración de Base de datos: " + listBox1.SelectedItem.ToString() + " ?", "Restaurar", MessageBoxButtons.YesNo);



                    if (Respuesta == DialogResult.Yes)

                    {
                        try
                        {
                            SERVICIOS.BackUp.BackUp bkp = new SERVICIOS.BackUp.BackUp();
                            string Path = Directorio + listBox1.SelectedItem.ToString();
                            bkp.Restaurar(Path);
                            MessageBox.Show("Restauración completada");
                        }

                        catch (Exception ex)

                        {
                            MessageBox.Show(ex.Message);
                        }

                    }


                }
            }
        }

        private void BackUp_Load(object sender, EventArgs e)
        {
            
            CargarBackups();
            
        }
    }
}

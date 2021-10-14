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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
            CargarGrilla();
        }

        private BLLUsuario bUsuario = new BLLUsuario();
        private EEUsuario oUsuario = new EEUsuario();

        private void button1_Click(object sender, EventArgs e)
        {
            if (textMail.Text == "" || textPass1.Text == "" || textPass2.Text == "" || textNombre.Text == "")

            { MessageBox.Show("Complete lo campos obligatorios"); }

            else

            {

                if (textPass1.Text != textPass2.Text) { MessageBox.Show("Las contraseñas no coinciden"); }

                else
                {
                    try
                    {
                        oUsuario.Nombre = textNombre.Text.Trim();
                        oUsuario.Apellido = textApellido.Text.Trim();
                        oUsuario.Mail = textMail.Text.Trim();
                        oUsuario.Clave = SERVICIOS.Inicio.Encriptador.Hash(textPass1.Text);
                        oUsuario.Idioma = (EEIdioma)comboIdioma.SelectedItem;
                        if (bUsuario.ExisteUsuario(oUsuario) == false)
                        {
                            bUsuario.Alta(oUsuario);
                        }
                        else MessageBox.Show("Ya existe un usuario con el mail ingresado");
                    }

                    catch (Exception ex) { MessageBox.Show(ex.Message); }

                    CargarGrilla();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textId.Text) == 0) { MessageBox.Show("Seleccione un usuario de la grilla"); }

            else

            {
                DialogResult Respuesta = MessageBox.Show("Confirma Modificación de Usuario?", "Modificar Usuario", MessageBoxButtons.YesNo);

                if (Respuesta == DialogResult.Yes)
                {
                    try
                    {
                        oUsuario.Id = Convert.ToInt32(textId.Text);
                        oUsuario.Nombre = textNombre.Text.Trim();
                        oUsuario.Apellido = textApellido.Text.Trim();
                        oUsuario.Mail = textMail.Text.Trim();
                        oUsuario.Clave = SERVICIOS.Inicio.Encriptador.Hash(textPass1.Text);
                        oUsuario.Idioma = (EEIdioma)comboIdioma.SelectedItem;

                        bUsuario.Editar(oUsuario);

                    }

                    catch (Exception ex)

                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                CargarGrilla();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(textId.Text) == 0) { MessageBox.Show("Seleccione un usuario de la grilla"); }

            else

            {
                DialogResult Respuesta = MessageBox.Show("Confirma Eliminar Usuario?", "Eliminar Usuario", MessageBoxButtons.YesNo);

                if (Respuesta == DialogResult.Yes)
                {
                    oUsuario.Id = Convert.ToInt32(textId.Text);
                    oUsuario.Mail = textMail.Text.Trim();

                    if (oUsuario.Mail == "admin") { MessageBox.Show("No se puede eliminar el Usuario admin"); }

                    else
                    {
                        bUsuario.Eliminar(oUsuario);
                        CargarGrilla();
                    }
                }
            }
        }
        public void CargarGrilla()

        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = bUsuario.ListarUsuarios();
            dataGridView1.Columns["Clave"].Visible = false;
            dataGridView1.Columns["DVH"].Visible = false;

        }
    }
}

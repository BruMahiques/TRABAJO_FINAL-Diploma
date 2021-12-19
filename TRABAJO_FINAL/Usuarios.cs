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
    public partial class Usuarios : Form, InterfazIdiomaObserver
    {
        public Usuarios()
        {
            InitializeComponent();
            CargarGrilla();
            Traducir();
        }

        private BLLUsuario bUsuario = new BLLUsuario();
        private EEUsuario oUsuario = new EEUsuario();

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

                foreach (Control x in this.Controls) // Todos los controles

                {

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

                    if (label4.Tag != null && Traducciones.ContainsKey(label4.Tag.ToString()))
                        label4.Text = Traducciones[label4.Tag.ToString()].Texto;

                    if (label3.Tag != null && Traducciones.ContainsKey(label3.Tag.ToString()))
                        label3.Text = Traducciones[label3.Tag.ToString()].Texto;

                    if (label5.Tag != null && Traducciones.ContainsKey(label5.Tag.ToString()))
                        label5.Text = Traducciones[label5.Tag.ToString()].Texto;

                    if (label6.Tag != null && Traducciones.ContainsKey(label6.Tag.ToString()))
                        label6.Text = Traducciones[label6.Tag.ToString()].Texto;

                    if (label7.Tag != null && Traducciones.ContainsKey(label7.Tag.ToString()))
                        label7.Text = Traducciones[label7.Tag.ToString()].Texto;


                }

            }

        }


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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;
            EEUsuario selU = new EEUsuario();
            selU = (EEUsuario)dataGridView1.CurrentRow.DataBoundItem;

            textId.Text = Convert.ToString(selU.Id);
            textNombre.Text = selU.Nombre;
            textApellido.Text = selU.Apellido;
            textMail.Text = selU.Mail;
            comboIdioma.SelectedItem = comboIdioma.Items.IndexOf(selU.Idioma.Cod_Idioma);

        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            CargarGrilla();
            List<EEIdioma> Idiomas = new List<EEIdioma>();
            Idiomas = BLLIdiomaTraductor.ObtenerIdiomas();
            comboIdioma.DataSource = Idiomas;
            Singleton.Instancia.SuscribirObs(this);
        }
        private void Usuarios_FormClosing(object sender, FormClosingEventArgs e)
        {
            Singleton.Instancia.DesuscribirObs(this);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using System.Data;
using System.Data.SqlClient;
using BLL;
using EE;
using System.Text.RegularExpressions;

namespace TRABAJO_FINAL
{
    public partial class ProductoDesconectado : Form
    {
        public ProductoDesconectado()
        {
            InitializeComponent();
           
        }

        SqlConnection cnn = new SqlConnection(@"Data Source=DESKTOP-M5FCUAS\BRUNO;Initial Catalog=JUEGOMES;Integrated Security=True");
        BLLProducto oBLLProducto = new BLLProducto();
        DataSet ds = new DataSet();
        DataRow dr;
        SqlDataAdapter Da;

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    DataRow dr2;
                    dr2 = ds.Tables[0].NewRow();

                    dr2["Tipo_Producto"] = comboBox1.SelectedItem.ToString();
                    dr2["Tamaño"] = txtTamaño.Text;
                    dr2["Cant_Personas"] = txtCant.Text;
                    dr2["Alquilado"] = radioButton1.Checked;

                    ds.Tables[0].Rows.Add(dr2);
                    LimpiarProd();
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
        public void CargarGrilla()
        {
            ds = oBLLProducto.Listar();
            List<EEProducto> ListaProd = oBLLProducto.ListarProductos();
            gridProductos.DataSource = null;
            gridProductos.DataSource = ds.Tables[0];
            
        }
        public void LimpiarProd()
        {

            comboBox1.Text = string.Empty;
            txtTamaño.Text = string.Empty;
            txtCant.Text = string.Empty;
            txtCodProd.Text = string.Empty;
            
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    dr = ((DataRowView)this.gridProductos.SelectedRows[0].DataBoundItem).Row;

                    dr["Tipo_Producto"] = comboBox1.SelectedItem.ToString();
                    dr["Tamaño"] = txtTamaño.Text;
                    dr["Cant_Personas"] = txtCant.Text;
                    dr["Alquilado"] = radioButton1.Checked;

                    LimpiarProd();
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

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos())
                {
                    ((DataRowView)this.gridProductos.SelectedRows[0].DataBoundItem).Row.Delete();
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

       
        private void gridProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Da = new SqlDataAdapter("SELECT * FROM Productos", cnn);


            //SE SETEAN LOS METODOS PARA GUARDAR DATOS EN BASE DE DATOS
            SqlCommandBuilder Cb = new SqlCommandBuilder(Da);
            Da.UpdateCommand = Cb.GetUpdateCommand();
            Da.DeleteCommand = Cb.GetDeleteCommand();
            Da.InsertCommand = Cb.GetInsertCommand();
            Da.ContinueUpdateOnError = true;

            //SE INTENTAN PERSISTIR LOS CAMBIOS EN LA BASE DE DATOS
            Da.Update(ds.Tables[0]);
        }

        private void btnDescartar_Click(object sender, EventArgs e)
        {
            ds.RejectChanges();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            ds.Tables[0].Rows.Clear();
            CargarGrilla();
        }

        private void ProductoDesconectado_Load(object sender, EventArgs e)
        {
            CargarGrilla();
         
        }

        private void gridProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodProd.Text = gridProductos.Rows[e.RowIndex].Cells[0].Value.ToString();
            comboBox1.Text = gridProductos.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtTamaño.Text = gridProductos.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtCant.Text = gridProductos.Rows[e.RowIndex].Cells[3].Value.ToString();
            radioButton1.Checked = (bool)gridProductos.Rows[e.RowIndex].Cells[4].Value;
        }

        void CambiarIdiomaEspañol(string Cultura)
        {


            Label1.Text = Resource1.CodigoProd;
            Label2.Text = Resource1.Tipo;
            Label3.Text = Resource1.Tamaño;
            Label4.Text = Resource1.Cantidad_de_Personas;
            label5.Text = Resource1.Filtrar;
            button1.Text = Resource1.CodigoProd;
            button2.Text = Resource1.Cantidad_de_Personas;
            radioButton1.Text = Resource1.Alquilado;
            btnNuevo.Text = Resource1.btnNuevo;
            btnModificar.Text = Resource1.btnModificar;
            btnGrabar.Text = Resource1.btnGrabar;
            btnDescartar.Text = Resource1.btnDescartar;
            btnEliminar.Text = Resource1.btnBaja;
            btnCargar.Text = Resource1.btnCargar;
            button5.Text = Resource1.Salir;

        }
        void CambiarIdiomaIngles(string Cultura)
        {



            Label1.Text = Resource2.CodigoProd;
            Label2.Text = Resource2.Tipo;
            Label3.Text = Resource2.Tamaño;
            Label4.Text = Resource2.Cantidad_de_Personas;
            label5.Text = Resource2.Filtrar;
            button1.Text = Resource2.CodigoProd;
            button2.Text = Resource2.Cantidad_de_Personas;
            radioButton1.Text = Resource2.Alquilado;
            btnNuevo.Text = Resource2.btnNuevo;
            btnModificar.Text = Resource2.btnModificar;
            btnGrabar.Text = Resource2.btnGrabar;
            btnDescartar.Text = Resource2.btnDescartar;
            btnEliminar.Text = Resource2.btnBaja;
            btnCargar.Text = Resource2.btnCargar;
            button5.Text = Resource2.Salir;


        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            CambiarIdiomaEspañol("Resource1");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            CambiarIdiomaIngles("Resource2");
        }

             
        private void button1_Click(object sender, EventArgs e)
        {
                     
            try
            {
                if (ValidarCampos2())
                {
                    DataView dv = ds.Tables[0].DefaultView;
                    dv.RowFilter = "Cod_Producto=" + textBox1.Text;
                    gridProductos.DataSource = dv;
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidarCampos3())
                {
                    DataView dv = ds.Tables[0].DefaultView;
                    dv.RowFilter = "Cant_Personas=" + textBox2.Text;
                    gridProductos.DataSource = dv;
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

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool ValidarCampos()
        {

            string Cant = txtCant.Text.Trim();

            bool respuesta3 = Regex.IsMatch(Cant, "^([0-9]+$)");
            if (respuesta3 == false)
            {
                MessageBox.Show("No escribio solo números en Cantidad de personas", "ERROR");
                return respuesta3;
            }

            


            string Tamaño = txtTamaño.Text.Trim();
            bool respuesta2 = false;
            respuesta2 = Regex.IsMatch(Tamaño, "^([a-zA-Z]+$)");
            if (respuesta2 == false)
            {
                MessageBox.Show("No escribio solo letras en Tamaño", "ERROR");
                return respuesta2;
            }

            return respuesta3;

        }
        private bool ValidarCampos2()
        {
            string filtro1 = textBox1.Text;

            bool respuesta4 = Regex.IsMatch(filtro1, "^([0-9]+$)");
            if (respuesta4 == false)
            {
                MessageBox.Show("No escribio solo números en el primer filtro", "ERROR");
                return respuesta4;
            }

            
            return respuesta4;
        }
        private bool ValidarCampos3()
        {
           

            string filtro2 = textBox2.Text;

            bool respuesta5 = Regex.IsMatch(filtro2, "^([0-9]+$)");
            if (respuesta5 == false)
            {
                MessageBox.Show("No escribio solo números en el segundo filtro", "ERROR");
                return respuesta5;
            }
            return respuesta5;
        }

    }
}

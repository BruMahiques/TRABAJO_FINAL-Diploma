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
using Datos;
using SERVICIOS;
using System.Text.RegularExpressions;

namespace TRABAJO_FINAL
{
    public partial class Pagos : Form, InterfazIdiomaObserver
    {
        public Pagos()
        {
            InitializeComponent();
            Traducir();
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

                                                
                foreach (Control x in this.Controls) // Todos los controles

                {
                    if (label7.Tag != null && Traducciones.ContainsKey(label7.Tag.ToString()))
                        label7.Text = Traducciones[label7.Tag.ToString()].Texto;



                    if (label12.Tag != null && Traducciones.ContainsKey(label12.Tag.ToString()))
                        label12.Text = Traducciones[label12.Tag.ToString()].Texto;

                    if (label13.Tag != null && Traducciones.ContainsKey(label13.Tag.ToString()))
                        label13.Text = Traducciones[label13.Tag.ToString()].Texto;




                    if (label1.Tag != null && Traducciones.ContainsKey(label1.Tag.ToString()))
                        label1.Text = Traducciones[label1.Tag.ToString()].Texto;

                    if (label2.Tag != null && Traducciones.ContainsKey(label2.Tag.ToString()))
                        label2.Text = Traducciones[label2.Tag.ToString()].Texto;


                    if (label14.Tag != null && Traducciones.ContainsKey(label14.Tag.ToString()))
                        label14.Text = Traducciones[label14.Tag.ToString()].Texto;

                    if (label19.Tag != null && Traducciones.ContainsKey(label19.Tag.ToString()))
                        label19.Text = Traducciones[label19.Tag.ToString()].Texto;

                    if (label4.Tag != null && Traducciones.ContainsKey(label4.Tag.ToString()))
                        label4.Text = Traducciones[label4.Tag.ToString()].Texto;

                    if (label5.Tag != null && Traducciones.ContainsKey(label5.Tag.ToString()))
                        label5.Text = Traducciones[label5.Tag.ToString()].Texto;

                    if (label3.Tag != null && Traducciones.ContainsKey(label3.Tag.ToString()))
                        label3.Text = Traducciones[label3.Tag.ToString()].Texto;

                    if (label6.Tag != null && Traducciones.ContainsKey(label6.Tag.ToString()))
                        label6.Text = Traducciones[label6.Tag.ToString()].Texto;
                }
            }

        }
        BLLTipoDePago BLLTipoDePago = new BLLTipoDePago();
        public EEVenta Venta = new EEVenta();
        BLLCliente bllcliente = new BLLCliente();
        public int condicion = 0;
        public float TotalAPagar = 0;
        public EEReserva Reserva = new EEReserva();
        private void Pagos_Load(object sender, EventArgs e)
        {
            cboTipoPago.DataSource = BLLTipoDePago.ListarTipoDePago();

            txtCodUsuario.Text = Venta.Cliente.Cod_Cliente.ToString();

            cod_venta.Text = Venta.Id_Venta.ToString();

            txtNombreCliente.Text = Venta.Cliente.Nombre.ToString();

            txtNumDoc.Text = Venta.Cliente.DNI.ToString();

            txtCorreo.Text = Venta.Cliente.Correo.ToString();

            total.Text = Venta.Total_Venta.ToString();

            if (condicion == 1)
            {
                float totalfinal = Venta.Total_Venta;
                Saldo.Text = Venta.Cliente.Saldo.ToString();
                totalfinal = totalfinal - Venta.Cliente.Saldo;
                total.Text = totalfinal.ToString();
            }
            else
                {
                if (condicion == 2)
                    {
                    Saldo.Text = Reserva.Cliente.Saldo.ToString();
                    total.Text = TotalAPagar.ToString();
                }
                else
                    {
                    Saldo.Text = Venta.Cliente.Saldo.ToString();
                    total.Text = TotalAPagar.ToString();
                    }
                }
            
            btnEfectivo.Enabled = false;
            btnQR.Enabled = false;
            btnTarjeta.Enabled = false;

            SeleccionCombo();

            if (Convert.ToSingle(total.Text)<0)
            {
                if (cboTipoPago.Text == "1-Efectivo")
                {
                    btnEfectivo.Enabled = true;
                    btnTarjeta.Enabled = false;
                    btnQR.Enabled = false;
                    texttarjeta.Enabled = false;
                    textcodigoseguridad.Enabled = false;
                    cboTipoPago.Enabled = false;
                }
            }

            Singleton.Instancia.SuscribirObs(this);

        }
        private void Pagos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Singleton.Instancia.DesuscribirObs(this);
        }
        private void SeleccionCombo()
        {
            if (cboTipoPago.Text == "1-Efectivo")
            {
                btnEfectivo.Enabled = true;
                btnTarjeta.Enabled = false;
                btnQR.Enabled = false;
                texttarjeta.Enabled = false;
                textcodigoseguridad.Enabled = false;
            }
            else
            {
                if (cboTipoPago.Text == "2-Código QR")
                {
                    btnQR.Enabled = true;
                    btnEfectivo.Enabled = false;
                    btnTarjeta.Enabled = false;
                    texttarjeta.Enabled = false;
                    textcodigoseguridad.Enabled = false;
                }
                else
                {
                    btnTarjeta.Enabled = true;
                    btnQR.Enabled = false;
                    btnEfectivo.Enabled = false;
                    texttarjeta.Enabled = true;
                    textcodigoseguridad.Enabled = true;
                }
            }
        }

        private void cboTipoPago_SelectedValueChanged(object sender, EventArgs e)
        {
            SeleccionCombo();
        }
        private void SaldoA0()
        {
            if (Saldo.Text != "-")
            {
                if (Convert.ToSingle(Saldo.Text) != 0)
                {
                    if (Convert.ToSingle(total.Text) > 0)
                    {
                        Venta.Cliente.Saldo = Convert.ToSingle(Venta.Cliente.Saldo) - Convert.ToSingle(Saldo.Text);
                        bllcliente.ALta_Mod_Cliente(Venta.Cliente);
                        
                    }
                    else
                    {
                        var Sal = Math.Abs(Convert.ToSingle(total.Text));
                        Venta.Cliente.Saldo = Sal;
                        bllcliente.ALta_Mod_Cliente(Venta.Cliente);
                        
                    }
                }
            }
        }

        private void btnEfectivo_Click(object sender, EventArgs e)
        {
            if (Convert.ToSingle(total.Text) < 0)
            {
                if (MessageBox.Show("Confirmar que el cliente quiera abonar con su saldo", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (condicion == 2)
                    {
                        Cambiar_estado_Reserva("Pagada");
                    }
                    else
                    {
                        Cambiar_estado_Venta("Pagado");
                        MessageBox.Show("El Saldo que le quedó al cliente es de : " + Venta.Cliente.Saldo);
                    }
                }
            }
            else
            {
                if (MessageBox.Show("Confirmar que el cliente haya abonado en efectivo", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (condicion == 2)
                    {
                        Cambiar_estado_Reserva("Pagada");
                    }
                    else
                    {
                        Cambiar_estado_Venta("Pagado");
                    }

                }
            }
        }

        private void btnQR_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirmar que la app haya confirmó el pago", "Confirmar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (condicion == 2)
                {
                    Cambiar_estado_Reserva("Pagada");
                }
                else
                {
                    Cambiar_estado_Venta("Pagado");
                }


            }
        }
        private void Cambiar_estado_Venta(string Estado)
        {

            try
            {

                BLLVenta bLLVenta = new BLLVenta();
                Venta.Estado = Estado;

                bLLVenta.Mod_Estado(Venta);
                btnQR.Enabled = false;
                btnEfectivo.Enabled = false;
                btnTarjeta.Enabled = false;
                texttarjeta.Enabled = false;
                textcodigoseguridad.Enabled = false;

                SaldoA0();
                MessageBox.Show("Venta Pagada Correctamente");
                cboTipoPago.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
                return;
            }
        }
        private void Cambiar_estado_Reserva(string Estado)
        {

            try
            {

                BLLReservas bLLReserva = new BLLReservas();
                Reserva.Estado = Estado;

                bLLReserva.Mod_Estado(Reserva);
                btnQR.Enabled = false;
                btnEfectivo.Enabled = false;
                btnTarjeta.Enabled = false;
                texttarjeta.Enabled = false;
                textcodigoseguridad.Enabled = false;

                SaldoA0();
                MessageBox.Show("Seña Pagada Correctamente");
                cboTipoPago.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error");
                return;
            }
        }

        private void btnTarjeta_Click(object sender, EventArgs e)
        {
            EETarjetas tarjeta = new EETarjetas();
            BLLTarjeta blltarjeta = new BLLTarjeta();

            if (ValidarCampos())
            {
                tarjeta = blltarjeta.BuscarNumero(Convert.ToInt64(texttarjeta.Text), Convert.ToInt32(textcodigoseguridad.Text));

                if(tarjeta != null)
                {
                    if (tarjeta.Saldo >= Convert.ToSingle(total.Text))
                    {
                        tarjeta.Saldo = tarjeta.Saldo - Convert.ToSingle(total.Text);
                        blltarjeta.DescontarSaldoTarjeta(tarjeta);
                        if (condicion == 2)
                        {
                            Cambiar_estado_Reserva("Pagada");
                        }
                        else
                        {
                            Cambiar_estado_Venta("Pagado");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No tiene suficiente saldo en la tarjeta", "ERROR");
                    }
                }
                else
                {
                    MessageBox.Show("Los datos de la tarjeta no coinciden", "ERROR");
                }
            }

        }
        private bool ValidarCampos()
        {
            string Numero = texttarjeta.Text;
             
            bool respuesta3 = Regex.IsMatch(Numero, "^([0-9]+$)");
            if (respuesta3 == false)
            {
                MessageBox.Show("No escribio solo números en N° Tarjeta", "ERROR");
                return respuesta3;
            }

            string Codigo = textcodigoseguridad.Text;
           
            bool respuesta4 = Regex.IsMatch(Codigo, "^([0-9]+$)");
            if (respuesta4 == false)
            {
                MessageBox.Show("No escribio solo números en Codigo de Seguridad", "ERROR");
                return respuesta4;
            }
            return respuesta3;
        }
    }
}

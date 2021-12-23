namespace TRABAJO_FINAL
{
    partial class Pagos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label7 = new System.Windows.Forms.Label();
            this.cboTipoPago = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCodUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cod_venta = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNumDoc = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.total = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTarjeta = new System.Windows.Forms.Button();
            this.btnQR = new System.Windows.Forms.Button();
            this.btnEfectivo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.texttarjeta = new System.Windows.Forms.TextBox();
            this.textcodigoseguridad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Saldo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(342, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 15);
            this.label7.TabIndex = 25;
            this.label7.Tag = "Forma de pago";
            this.label7.Text = "Forma de pago";
            // 
            // cboTipoPago
            // 
            this.cboTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoPago.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoPago.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.cboTipoPago.FormattingEnabled = true;
            this.cboTipoPago.Location = new System.Drawing.Point(345, 100);
            this.cboTipoPago.Name = "cboTipoPago";
            this.cboTipoPago.Size = new System.Drawing.Size(145, 23);
            this.cboTipoPago.TabIndex = 24;
            this.cboTipoPago.SelectedValueChanged += new System.EventHandler(this.cboTipoPago_SelectedValueChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(524, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 15);
            this.label12.TabIndex = 27;
            this.label12.Tag = "Cliente";
            this.label12.Text = "Cliente";
            // 
            // txtCodUsuario
            // 
            this.txtCodUsuario.Enabled = false;
            this.txtCodUsuario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodUsuario.Location = new System.Drawing.Point(527, 100);
            this.txtCodUsuario.Name = "txtCodUsuario";
            this.txtCodUsuario.ReadOnly = true;
            this.txtCodUsuario.Size = new System.Drawing.Size(67, 22);
            this.txtCodUsuario.TabIndex = 26;
            this.txtCodUsuario.Text = "-";
            this.txtCodUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(615, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 29;
            this.label2.Tag = "Venta";
            this.label2.Text = "Venta";
            // 
            // cod_venta
            // 
            this.cod_venta.Enabled = false;
            this.cod_venta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cod_venta.Location = new System.Drawing.Point(618, 101);
            this.cod_venta.Name = "cod_venta";
            this.cod_venta.ReadOnly = true;
            this.cod_venta.Size = new System.Drawing.Size(67, 22);
            this.cod_venta.TabIndex = 28;
            this.cod_venta.Tag = "Venta";
            this.cod_venta.Text = "-";
            this.cod_venta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(342, 181);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(39, 15);
            this.label19.TabIndex = 35;
            this.label19.Tag = "Correo";
            this.label19.Text = "Email";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(345, 198);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.ReadOnly = true;
            this.txtCorreo.Size = new System.Drawing.Size(255, 21);
            this.txtCorreo.TabIndex = 34;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(556, 140);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 15);
            this.label14.TabIndex = 33;
            this.label14.Tag = "N°Documento";
            this.label14.Text = "Nº Documento";
            // 
            // txtNumDoc
            // 
            this.txtNumDoc.Enabled = false;
            this.txtNumDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumDoc.Location = new System.Drawing.Point(554, 156);
            this.txtNumDoc.MaxLength = 15;
            this.txtNumDoc.Name = "txtNumDoc";
            this.txtNumDoc.Size = new System.Drawing.Size(234, 21);
            this.txtNumDoc.TabIndex = 32;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(342, 139);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(132, 15);
            this.label13.TabIndex = 31;
            this.label13.Tag = "Nombre/Razon Social";
            this.label13.Text = "Nombre / Razón social";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Location = new System.Drawing.Point(345, 156);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(203, 21);
            this.txtNombreCliente.TabIndex = 30;
            // 
            // total
            // 
            this.total.Enabled = false;
            this.total.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(554, 374);
            this.total.MaxLength = 15;
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(234, 21);
            this.total.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(495, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 15);
            this.label3.TabIndex = 37;
            this.label3.Tag = "A pagar";
            this.label3.Text = "A pagar";
            // 
            // btnTarjeta
            // 
            this.btnTarjeta.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTarjeta.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTarjeta.Image = global::TRABAJO_FINAL.Properties.Resources.tarjeta_de_debito;
            this.btnTarjeta.Location = new System.Drawing.Point(737, 401);
            this.btnTarjeta.Name = "btnTarjeta";
            this.btnTarjeta.Size = new System.Drawing.Size(51, 40);
            this.btnTarjeta.TabIndex = 40;
            this.btnTarjeta.UseVisualStyleBackColor = false;
            this.btnTarjeta.Click += new System.EventHandler(this.btnTarjeta_Click);
            // 
            // btnQR
            // 
            this.btnQR.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnQR.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQR.Image = global::TRABAJO_FINAL.Properties.Resources.codigo_qr;
            this.btnQR.Location = new System.Drawing.Point(680, 401);
            this.btnQR.Name = "btnQR";
            this.btnQR.Size = new System.Drawing.Size(51, 40);
            this.btnQR.TabIndex = 39;
            this.btnQR.UseVisualStyleBackColor = false;
            this.btnQR.Click += new System.EventHandler(this.btnQR_Click);
            // 
            // btnEfectivo
            // 
            this.btnEfectivo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnEfectivo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEfectivo.Image = global::TRABAJO_FINAL.Properties.Resources.dinero;
            this.btnEfectivo.Location = new System.Drawing.Point(623, 401);
            this.btnEfectivo.Name = "btnEfectivo";
            this.btnEfectivo.Size = new System.Drawing.Size(51, 40);
            this.btnEfectivo.TabIndex = 38;
            this.btnEfectivo.UseVisualStyleBackColor = false;
            this.btnEfectivo.Click += new System.EventHandler(this.btnEfectivo_Click);
            // 
            // label1
            // 
            this.label1.Image = global::TRABAJO_FINAL.Properties.Resources.metodo_de_pago__1_;
            this.label1.Location = new System.Drawing.Point(39, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 300);
            this.label1.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(342, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 15);
            this.label4.TabIndex = 41;
            this.label4.Tag = "N°Tarjeta";
            this.label4.Text = "N° Tarjeta";
            // 
            // texttarjeta
            // 
            this.texttarjeta.Enabled = false;
            this.texttarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texttarjeta.Location = new System.Drawing.Point(409, 274);
            this.texttarjeta.MaxLength = 20;
            this.texttarjeta.Name = "texttarjeta";
            this.texttarjeta.Size = new System.Drawing.Size(234, 21);
            this.texttarjeta.TabIndex = 42;
            // 
            // textcodigoseguridad
            // 
            this.textcodigoseguridad.Enabled = false;
            this.textcodigoseguridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textcodigoseguridad.Location = new System.Drawing.Point(455, 312);
            this.textcodigoseguridad.MaxLength = 15;
            this.textcodigoseguridad.Name = "textcodigoseguridad";
            this.textcodigoseguridad.Size = new System.Drawing.Size(104, 21);
            this.textcodigoseguridad.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(342, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 15);
            this.label5.TabIndex = 43;
            this.label5.Tag = "Codigo Seguridad";
            this.label5.Text = "Codigo Seguridad";
            // 
            // Saldo
            // 
            this.Saldo.Enabled = false;
            this.Saldo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Saldo.Location = new System.Drawing.Point(618, 198);
            this.Saldo.Name = "Saldo";
            this.Saldo.ReadOnly = true;
            this.Saldo.Size = new System.Drawing.Size(67, 22);
            this.Saldo.TabIndex = 45;
            this.Saldo.Text = "-";
            this.Saldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(615, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 46;
            this.label6.Tag = "Saldo";
            this.label6.Text = "Saldo";
            // 
            // Pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Saldo);
            this.Controls.Add(this.textcodigoseguridad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.texttarjeta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnTarjeta);
            this.Controls.Add(this.btnQR);
            this.Controls.Add(this.btnEfectivo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtNumDoc);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtNombreCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cod_venta);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtCodUsuario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboTipoPago);
            this.Controls.Add(this.label1);
            this.Name = "Pagos";
            this.Tag = "Pagos";
            this.Text = "Pagos";
            this.Load += new System.EventHandler(this.Pagos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboTipoPago;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCodUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox cod_venta;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNumDoc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox total;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEfectivo;
        private System.Windows.Forms.Button btnQR;
        private System.Windows.Forms.Button btnTarjeta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox texttarjeta;
        private System.Windows.Forms.TextBox textcodigoseguridad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Saldo;
        private System.Windows.Forms.Label label6;
    }
}
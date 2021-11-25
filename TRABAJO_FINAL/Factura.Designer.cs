namespace TRABAJO_FINAL
{
    partial class Factura
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblMontoEnletras = new System.Windows.Forms.Label();
            this.lblNumItems = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.dgvDetalleBoleta = new System.Windows.Forms.DataGridView();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboTipoPago = new System.Windows.Forms.ComboBox();
            this.btnBuscarXid = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.txtDireccionCliente = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpFechaEmision = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.cboTipDoc = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNumDoc = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCodUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCorrelativo = new System.Windows.Forms.Label();
            this.lblSerie = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAnular = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnQuitarItem = new System.Windows.Forms.Button();
            this.btnAgregarItem = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleBoleta)).BeginInit();
            this.gbCliente.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.lblMontoEnletras);
            this.panel1.Controls.Add(this.btnAnular);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnQuitarItem);
            this.panel1.Controls.Add(this.btnAgregarItem);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.lblNumItems);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.btnNuevo);
            this.panel1.Controls.Add(this.dgvDetalleBoleta);
            this.panel1.Location = new System.Drawing.Point(12, 266);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 292);
            this.panel1.TabIndex = 13;
            // 
            // lblMontoEnletras
            // 
            this.lblMontoEnletras.BackColor = System.Drawing.SystemColors.Control;
            this.lblMontoEnletras.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoEnletras.ForeColor = System.Drawing.Color.Black;
            this.lblMontoEnletras.Location = new System.Drawing.Point(93, 215);
            this.lblMontoEnletras.Name = "lblMontoEnletras";
            this.lblMontoEnletras.Size = new System.Drawing.Size(297, 23);
            this.lblMontoEnletras.TabIndex = 23;
            this.lblMontoEnletras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblNumItems
            // 
            this.lblNumItems.BackColor = System.Drawing.Color.Teal;
            this.lblNumItems.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumItems.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNumItems.Location = new System.Drawing.Point(15, 215);
            this.lblNumItems.Name = "lblNumItems";
            this.lblNumItems.Size = new System.Drawing.Size(72, 23);
            this.lblNumItems.TabIndex = 15;
            this.lblNumItems.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(428, 231);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 15);
            this.label10.TabIndex = 10;
            this.label10.Text = "Total S/ :";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.Ivory;
            this.txtTotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotal.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(487, 224);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(100, 25);
            this.txtTotal.TabIndex = 8;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dgvDetalleBoleta
            // 
            this.dgvDetalleBoleta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleBoleta.Location = new System.Drawing.Point(15, 27);
            this.dgvDetalleBoleta.Name = "dgvDetalleBoleta";
            this.dgvDetalleBoleta.Size = new System.Drawing.Size(572, 182);
            this.dgvDetalleBoleta.TabIndex = 4;
            // 
            // gbCliente
            // 
            this.gbCliente.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gbCliente.Controls.Add(this.label7);
            this.gbCliente.Controls.Add(this.cboTipoPago);
            this.gbCliente.Controls.Add(this.btnBuscarXid);
            this.gbCliente.Controls.Add(this.label19);
            this.gbCliente.Controls.Add(this.txtDireccionCliente);
            this.gbCliente.Controls.Add(this.label17);
            this.gbCliente.Controls.Add(this.dtpFechaEmision);
            this.gbCliente.Controls.Add(this.label15);
            this.gbCliente.Controls.Add(this.cboTipDoc);
            this.gbCliente.Controls.Add(this.label14);
            this.gbCliente.Controls.Add(this.txtNumDoc);
            this.gbCliente.Controls.Add(this.label13);
            this.gbCliente.Controls.Add(this.txtNombreCliente);
            this.gbCliente.Controls.Add(this.label12);
            this.gbCliente.Controls.Add(this.btnBuscarCliente);
            this.gbCliente.Controls.Add(this.txtCodUsuario);
            this.gbCliente.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbCliente.ForeColor = System.Drawing.Color.Black;
            this.gbCliente.Location = new System.Drawing.Point(12, 115);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(603, 145);
            this.gbCliente.TabIndex = 12;
            this.gbCliente.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(122, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 15);
            this.label7.TabIndex = 21;
            this.label7.Text = "Forma de pago";
            // 
            // cboTipoPago
            // 
            this.cboTipoPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoPago.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoPago.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.cboTipoPago.FormattingEnabled = true;
            this.cboTipoPago.Location = new System.Drawing.Point(125, 30);
            this.cboTipoPago.Name = "cboTipoPago";
            this.cboTipoPago.Size = new System.Drawing.Size(145, 23);
            this.cboTipoPago.TabIndex = 20;
            // 
            // btnBuscarXid
            // 
            this.btnBuscarXid.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarXid.Location = new System.Drawing.Point(531, 64);
            this.btnBuscarXid.Name = "btnBuscarXid";
            this.btnBuscarXid.Size = new System.Drawing.Size(37, 30);
            this.btnBuscarXid.TabIndex = 19;
            this.btnBuscarXid.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnBuscarXid.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(30, 97);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(59, 15);
            this.label19.TabIndex = 18;
            this.label19.Text = "Direccion";
            // 
            // txtDireccionCliente
            // 
            this.txtDireccionCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionCliente.Location = new System.Drawing.Point(33, 114);
            this.txtDireccionCliente.Name = "txtDireccionCliente";
            this.txtDireccionCliente.ReadOnly = true;
            this.txtDireccionCliente.Size = new System.Drawing.Size(315, 21);
            this.txtDireccionCliente.TabIndex = 17;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(479, 13);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(89, 15);
            this.label17.TabIndex = 16;
            this.label17.Text = "Fecha emisión";
            // 
            // dtpFechaEmision
            // 
            this.dtpFechaEmision.CalendarForeColor = System.Drawing.Color.Teal;
            this.dtpFechaEmision.Enabled = false;
            this.dtpFechaEmision.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEmision.Location = new System.Drawing.Point(481, 29);
            this.dtpFechaEmision.Name = "dtpFechaEmision";
            this.dtpFechaEmision.Size = new System.Drawing.Size(107, 20);
            this.dtpFechaEmision.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(236, 55);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 15);
            this.label15.TabIndex = 12;
            this.label15.Text = "Tip. Doc";
            // 
            // cboTipDoc
            // 
            this.cboTipDoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipDoc.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipDoc.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.cboTipDoc.FormattingEnabled = true;
            this.cboTipDoc.Location = new System.Drawing.Point(239, 71);
            this.cboTipDoc.Name = "cboTipDoc";
            this.cboTipDoc.Size = new System.Drawing.Size(109, 23);
            this.cboTipDoc.TabIndex = 11;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(351, 55);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 15);
            this.label14.TabIndex = 10;
            this.label14.Text = "Nº Documento";
            // 
            // txtNumDoc
            // 
            this.txtNumDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumDoc.Location = new System.Drawing.Point(353, 72);
            this.txtNumDoc.MaxLength = 15;
            this.txtNumDoc.Name = "txtNumDoc";
            this.txtNumDoc.Size = new System.Drawing.Size(123, 21);
            this.txtNumDoc.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(30, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(132, 15);
            this.label13.TabIndex = 8;
            this.label13.Text = "Nombre / Razón social";
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreCliente.Location = new System.Drawing.Point(33, 72);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.ReadOnly = true;
            this.txtNombreCliente.Size = new System.Drawing.Size(203, 21);
            this.txtNombreCliente.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(31, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 15);
            this.label12.TabIndex = 6;
            this.label12.Text = "Operativo";
            // 
            // txtCodUsuario
            // 
            this.txtCodUsuario.Enabled = false;
            this.txtCodUsuario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodUsuario.Location = new System.Drawing.Point(34, 29);
            this.txtCodUsuario.Name = "txtCodUsuario";
            this.txtCodUsuario.ReadOnly = true;
            this.txtCodUsuario.Size = new System.Drawing.Size(67, 22);
            this.txtCodUsuario.TabIndex = 1;
            this.txtCodUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(89, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(271, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Juegos de mesa modernos";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCorrelativo);
            this.groupBox1.Controls.Add(this.lblSerie);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(452, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 99);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // lblCorrelativo
            // 
            this.lblCorrelativo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrelativo.Location = new System.Drawing.Point(72, 69);
            this.lblCorrelativo.Name = "lblCorrelativo";
            this.lblCorrelativo.Size = new System.Drawing.Size(85, 19);
            this.lblCorrelativo.TabIndex = 8;
            // 
            // lblSerie
            // 
            this.lblSerie.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerie.Location = new System.Drawing.Point(10, 69);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(50, 19);
            this.lblSerie.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(2, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "FACTURA";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "30‑50000561‑3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "CUIT";
            // 
            // btnAnular
            // 
            this.btnAnular.Image = global::TRABAJO_FINAL.Properties.Resources.boton_eliminar__1_;
            this.btnAnular.Location = new System.Drawing.Point(266, 244);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(50, 40);
            this.btnAnular.TabIndex = 22;
            this.btnAnular.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Image = global::TRABAJO_FINAL.Properties.Resources.flecha_hacia_atras;
            this.btnSalir.Location = new System.Drawing.Point(15, 245);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(51, 40);
            this.btnSalir.TabIndex = 21;
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnQuitarItem
            // 
            this.btnQuitarItem.BackColor = System.Drawing.Color.Azure;
            this.btnQuitarItem.Image = global::TRABAJO_FINAL.Properties.Resources.eliminar__1_;
            this.btnQuitarItem.Location = new System.Drawing.Point(563, 1);
            this.btnQuitarItem.Name = "btnQuitarItem";
            this.btnQuitarItem.Size = new System.Drawing.Size(24, 25);
            this.btnQuitarItem.TabIndex = 20;
            this.btnQuitarItem.UseVisualStyleBackColor = false;
            // 
            // btnAgregarItem
            // 
            this.btnAgregarItem.BackColor = System.Drawing.Color.Azure;
            this.btnAgregarItem.Image = global::TRABAJO_FINAL.Properties.Resources.mas__1_;
            this.btnAgregarItem.Location = new System.Drawing.Point(15, 1);
            this.btnAgregarItem.Name = "btnAgregarItem";
            this.btnAgregarItem.Size = new System.Drawing.Size(25, 25);
            this.btnAgregarItem.TabIndex = 19;
            this.btnAgregarItem.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::TRABAJO_FINAL.Properties.Resources.salvar;
            this.btnGuardar.Location = new System.Drawing.Point(214, 244);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(50, 40);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNuevo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Image = global::TRABAJO_FINAL.Properties.Resources.adicional;
            this.btnNuevo.Location = new System.Drawing.Point(161, 244);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(51, 40);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.UseVisualStyleBackColor = false;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.BackColor = System.Drawing.Color.LightCyan;
            this.btnBuscarCliente.Image = global::TRABAJO_FINAL.Properties.Resources.lupa__1_;
            this.btnBuscarCliente.Location = new System.Drawing.Point(482, 62);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(38, 39);
            this.btnBuscarCliente.TabIndex = 5;
            this.btnBuscarCliente.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::TRABAJO_FINAL.Properties.Resources.impresora;
            this.button1.Location = new System.Drawing.Point(322, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 40);
            this.button1.TabIndex = 24;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 574);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Factura";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.Factura_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleBoleta)).EndInit();
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblMontoEnletras;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnQuitarItem;
        private System.Windows.Forms.Button btnAgregarItem;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblNumItems;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvDetalleBoleta;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboTipoPago;
        private System.Windows.Forms.Button btnBuscarXid;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtDireccionCliente;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtpFechaEmision;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cboTipDoc;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNumDoc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox txtCodUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCorrelativo;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}
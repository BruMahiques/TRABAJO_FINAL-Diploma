﻿namespace TRABAJO_FINAL
{
    partial class Reservas
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
            this.txtseña = new System.Windows.Forms.TextBox();
            this.lbleliminar = new System.Windows.Forms.Label();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnAnular = new System.Windows.Forms.Button();
            this.btnQuitarItem = new System.Windows.Forms.Button();
            this.btnAgregarItem = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblNumdesc = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgvDetalleBoleta = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbCliente = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cboTipoPago = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dtpFechaEmision = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNumDoc = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.txtCodUsuario = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCorrelativo = new System.Windows.Forms.Label();
            this.lblSerie = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pagar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleBoleta)).BeginInit();
            this.gbCliente.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pagar);
            this.panel1.Controls.Add(this.txtseña);
            this.panel1.Controls.Add(this.lbleliminar);
            this.panel1.Controls.Add(this.btnImprimir);
            this.panel1.Controls.Add(this.btnAnular);
            this.panel1.Controls.Add(this.btnQuitarItem);
            this.panel1.Controls.Add(this.btnAgregarItem);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.lblNumdesc);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.btnNuevo);
            this.panel1.Controls.Add(this.dgvDetalleBoleta);
            this.panel1.Location = new System.Drawing.Point(24, 268);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 292);
            this.panel1.TabIndex = 16;
            // 
            // txtseña
            // 
            this.txtseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtseña.Location = new System.Drawing.Point(93, 216);
            this.txtseña.MaxLength = 15;
            this.txtseña.Name = "txtseña";
            this.txtseña.Size = new System.Drawing.Size(123, 21);
            this.txtseña.TabIndex = 27;
            this.txtseña.Text = "-";
            this.txtseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lbleliminar
            // 
            this.lbleliminar.AutoSize = true;
            this.lbleliminar.Location = new System.Drawing.Point(511, 7);
            this.lbleliminar.Name = "lbleliminar";
            this.lbleliminar.Size = new System.Drawing.Size(10, 13);
            this.lbleliminar.TabIndex = 25;
            this.lbleliminar.Text = "-";
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnImprimir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnImprimir.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Image = global::TRABAJO_FINAL.Properties.Resources.impresora;
            this.btnImprimir.Location = new System.Drawing.Point(322, 244);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(51, 40);
            this.btnImprimir.TabIndex = 24;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.Image = global::TRABAJO_FINAL.Properties.Resources.boton_eliminar__1_;
            this.btnAnular.Location = new System.Drawing.Point(266, 244);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(50, 40);
            this.btnAnular.TabIndex = 22;
            this.btnAnular.UseVisualStyleBackColor = true;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
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
            this.btnQuitarItem.Click += new System.EventHandler(this.btnQuitarItem_Click);
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
            this.btnAgregarItem.Click += new System.EventHandler(this.btnAgregarItem_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = global::TRABAJO_FINAL.Properties.Resources.salvar;
            this.btnGuardar.Location = new System.Drawing.Point(214, 244);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(50, 40);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblNumdesc
            // 
            this.lblNumdesc.BackColor = System.Drawing.Color.Teal;
            this.lblNumdesc.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumdesc.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNumdesc.Location = new System.Drawing.Point(15, 215);
            this.lblNumdesc.Name = "lblNumdesc";
            this.lblNumdesc.Size = new System.Drawing.Size(72, 25);
            this.lblNumdesc.TabIndex = 15;
            this.lblNumdesc.Tag = "Seña";
            this.lblNumdesc.Text = "Seña";
            this.lblNumdesc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(428, 231);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 15);
            this.label10.TabIndex = 10;
            this.label10.Tag = "Total $";
            this.label10.Text = "Total $ :";
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
            this.txtTotal.Text = "-";
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
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
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgvDetalleBoleta
            // 
            this.dgvDetalleBoleta.AllowUserToAddRows = false;
            this.dgvDetalleBoleta.AllowUserToDeleteRows = false;
            this.dgvDetalleBoleta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalleBoleta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Producto,
            this.Precio,
            this.Cantidad,
            this.Subtotal});
            this.dgvDetalleBoleta.Location = new System.Drawing.Point(15, 27);
            this.dgvDetalleBoleta.MultiSelect = false;
            this.dgvDetalleBoleta.Name = "dgvDetalleBoleta";
            this.dgvDetalleBoleta.RowHeadersVisible = false;
            this.dgvDetalleBoleta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetalleBoleta.Size = new System.Drawing.Size(586, 182);
            this.dgvDetalleBoleta.TabIndex = 4;
            this.dgvDetalleBoleta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalleBoleta_CellContentClick);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // Producto
            // 
            this.Producto.HeaderText = "Producto";
            this.Producto.Name = "Producto";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            // 
            // gbCliente
            // 
            this.gbCliente.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.gbCliente.Controls.Add(this.button2);
            this.gbCliente.Controls.Add(this.label7);
            this.gbCliente.Controls.Add(this.cboTipoPago);
            this.gbCliente.Controls.Add(this.label19);
            this.gbCliente.Controls.Add(this.txtCorreo);
            this.gbCliente.Controls.Add(this.label17);
            this.gbCliente.Controls.Add(this.dtpFechaEmision);
            this.gbCliente.Controls.Add(this.label14);
            this.gbCliente.Controls.Add(this.txtNumDoc);
            this.gbCliente.Controls.Add(this.label13);
            this.gbCliente.Controls.Add(this.txtNombreCliente);
            this.gbCliente.Controls.Add(this.label12);
            this.gbCliente.Controls.Add(this.btnBuscarCliente);
            this.gbCliente.Controls.Add(this.txtCodUsuario);
            this.gbCliente.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbCliente.ForeColor = System.Drawing.Color.Black;
            this.gbCliente.Location = new System.Drawing.Point(24, 117);
            this.gbCliente.Name = "gbCliente";
            this.gbCliente.Size = new System.Drawing.Size(603, 145);
            this.gbCliente.TabIndex = 15;
            this.gbCliente.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Snow;
            this.button2.Image = global::TRABAJO_FINAL.Properties.Resources.eliminar_usuario;
            this.button2.Location = new System.Drawing.Point(526, 62);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(38, 39);
            this.button2.TabIndex = 24;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(122, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 15);
            this.label7.TabIndex = 21;
            this.label7.Tag = "Forma de pago";
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
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(30, 97);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(45, 15);
            this.label19.TabIndex = 18;
            this.label19.Tag = "Email";
            this.label19.Text = "Correo";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(33, 114);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.ReadOnly = true;
            this.txtCorreo.Size = new System.Drawing.Size(255, 21);
            this.txtCorreo.TabIndex = 17;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(479, 13);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(89, 15);
            this.label17.TabIndex = 16;
            this.label17.Tag = "Fecha emision";
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
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(242, 56);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 15);
            this.label14.TabIndex = 10;
            this.label14.Tag = "N°Documento";
            this.label14.Text = "Nº Documento";
            // 
            // txtNumDoc
            // 
            this.txtNumDoc.Enabled = false;
            this.txtNumDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumDoc.Location = new System.Drawing.Point(242, 73);
            this.txtNumDoc.MaxLength = 15;
            this.txtNumDoc.Name = "txtNumDoc";
            this.txtNumDoc.Size = new System.Drawing.Size(234, 21);
            this.txtNumDoc.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(30, 55);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(133, 15);
            this.label13.TabIndex = 8;
            this.label13.Tag = "Nombre/Razon Social";
            this.label13.Text = "Nombre / Razón Social";
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
            this.label12.Size = new System.Drawing.Size(47, 15);
            this.label12.TabIndex = 6;
            this.label12.Tag = "Codigo";
            this.label12.Text = "Código";
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
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
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
            this.txtCodUsuario.Text = "-";
            this.txtCodUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCorrelativo);
            this.groupBox1.Controls.Add(this.lblSerie);
            this.groupBox1.Location = new System.Drawing.Point(459, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(168, 42);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // lblCorrelativo
            // 
            this.lblCorrelativo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorrelativo.Location = new System.Drawing.Point(62, 16);
            this.lblCorrelativo.Name = "lblCorrelativo";
            this.lblCorrelativo.Size = new System.Drawing.Size(91, 19);
            this.lblCorrelativo.TabIndex = 8;
            this.lblCorrelativo.Text = "-";
            // 
            // lblSerie
            // 
            this.lblSerie.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerie.Location = new System.Drawing.Point(6, 16);
            this.lblSerie.Name = "lblSerie";
            this.lblSerie.Size = new System.Drawing.Size(50, 19);
            this.lblSerie.TabIndex = 7;
            this.lblSerie.Text = "R-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(269, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 25);
            this.label2.TabIndex = 28;
            this.label2.Tag = "Reservas";
            this.label2.Text = "Reservas";
            // 
            // pagar
            // 
            this.pagar.Enabled = false;
            this.pagar.Image = global::TRABAJO_FINAL.Properties.Resources.metodo_de_pago__2_;
            this.pagar.Location = new System.Drawing.Point(222, 213);
            this.pagar.Name = "pagar";
            this.pagar.Size = new System.Drawing.Size(28, 29);
            this.pagar.TabIndex = 58;
            this.pagar.UseVisualStyleBackColor = true;
            this.pagar.Click += new System.EventHandler(this.pagar_Click);
            // 
            // Reservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(656, 583);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbCliente);
            this.Controls.Add(this.groupBox1);
            this.Name = "Reservas";
            this.Tag = "Reservas";
            this.Text = "Reservas";
            this.Load += new System.EventHandler(this.Reservas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalleBoleta)).EndInit();
            this.gbCliente.ResumeLayout(false);
            this.gbCliente.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtseña;
        private System.Windows.Forms.Label lbleliminar;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.Button btnQuitarItem;
        private System.Windows.Forms.Button btnAgregarItem;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblNumdesc;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgvDetalleBoleta;
        private System.Windows.Forms.GroupBox gbCliente;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboTipoPago;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker dtpFechaEmision;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNumDoc;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox txtCodUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblCorrelativo;
        private System.Windows.Forms.Label lblSerie;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subtotal;
        private System.Windows.Forms.Button pagar;
    }
}
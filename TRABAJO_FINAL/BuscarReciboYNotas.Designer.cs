namespace TRABAJO_FINAL
{
    partial class BuscarReciboYNotas
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
            this.dgvComprobante = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbcliente = new System.Windows.Forms.RadioButton();
            this.rbEstado = new System.Windows.Forms.RadioButton();
            this.rbNDoc = new System.Windows.Forms.RadioButton();
            this.rbComprobante = new System.Windows.Forms.RadioButton();
            this.rbIdVenta = new System.Windows.Forms.RadioButton();
            this.txtBusqComprobante = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Filtrar = new System.Windows.Forms.Button();
            this.dateTimeHasta = new System.Windows.Forms.DateTimePicker();
            this.dateTimeDesde = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvRecibos = new System.Windows.Forms.DataGridView();
            this.dataNotas = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtComprobante = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textRecibo = new System.Windows.Forms.TextBox();
            this.btnselectNota = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textNota = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataRecibosDet = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.dataNotasDet = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprobante)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecibos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataNotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataRecibosDet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataNotasDet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvComprobante
            // 
            this.dgvComprobante.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvComprobante.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvComprobante.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvComprobante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComprobante.Location = new System.Drawing.Point(12, 177);
            this.dgvComprobante.Name = "dgvComprobante";
            this.dgvComprobante.Size = new System.Drawing.Size(1203, 150);
            this.dgvComprobante.TabIndex = 1;
            this.dgvComprobante.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComprobante_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbcliente);
            this.groupBox1.Controls.Add(this.rbEstado);
            this.groupBox1.Controls.Add(this.rbNDoc);
            this.groupBox1.Controls.Add(this.rbComprobante);
            this.groupBox1.Controls.Add(this.rbIdVenta);
            this.groupBox1.Controls.Add(this.txtBusqComprobante);
            this.groupBox1.Location = new System.Drawing.Point(30, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 95);
            this.groupBox1.TabIndex = 92;
            this.groupBox1.TabStop = false;
            this.groupBox1.Tag = "Buscar";
            this.groupBox1.Text = "Buscar por";
            // 
            // rbcliente
            // 
            this.rbcliente.AutoSize = true;
            this.rbcliente.Location = new System.Drawing.Point(394, 65);
            this.rbcliente.Name = "rbcliente";
            this.rbcliente.Size = new System.Drawing.Size(97, 17);
            this.rbcliente.TabIndex = 5;
            this.rbcliente.TabStop = true;
            this.rbcliente.Tag = "Nombre Cliente";
            this.rbcliente.Text = "Nombre Cliente";
            this.rbcliente.UseVisualStyleBackColor = true;
            // 
            // rbEstado
            // 
            this.rbEstado.AutoSize = true;
            this.rbEstado.Location = new System.Drawing.Point(515, 65);
            this.rbEstado.Name = "rbEstado";
            this.rbEstado.Size = new System.Drawing.Size(58, 17);
            this.rbEstado.TabIndex = 4;
            this.rbEstado.TabStop = true;
            this.rbEstado.Tag = "Estado";
            this.rbEstado.Text = "Estado";
            this.rbEstado.UseVisualStyleBackColor = true;
            // 
            // rbNDoc
            // 
            this.rbNDoc.AutoSize = true;
            this.rbNDoc.Location = new System.Drawing.Point(243, 65);
            this.rbNDoc.Name = "rbNDoc";
            this.rbNDoc.Size = new System.Drawing.Size(130, 17);
            this.rbNDoc.TabIndex = 3;
            this.rbNDoc.TabStop = true;
            this.rbNDoc.Tag = "N°Documento";
            this.rbNDoc.Text = "N° Documento Cliente";
            this.rbNDoc.UseVisualStyleBackColor = true;
            // 
            // rbComprobante
            // 
            this.rbComprobante.AutoSize = true;
            this.rbComprobante.Location = new System.Drawing.Point(121, 65);
            this.rbComprobante.Name = "rbComprobante";
            this.rbComprobante.Size = new System.Drawing.Size(88, 17);
            this.rbComprobante.TabIndex = 2;
            this.rbComprobante.TabStop = true;
            this.rbComprobante.Tag = "Comprobante";
            this.rbComprobante.Text = "Comprobante";
            this.rbComprobante.UseVisualStyleBackColor = true;
            // 
            // rbIdVenta
            // 
            this.rbIdVenta.AutoSize = true;
            this.rbIdVenta.Location = new System.Drawing.Point(19, 65);
            this.rbIdVenta.Name = "rbIdVenta";
            this.rbIdVenta.Size = new System.Drawing.Size(65, 17);
            this.rbIdVenta.TabIndex = 1;
            this.rbIdVenta.TabStop = true;
            this.rbIdVenta.Tag = "Id Venta";
            this.rbIdVenta.Text = "Id Venta";
            this.rbIdVenta.UseVisualStyleBackColor = true;
            // 
            // txtBusqComprobante
            // 
            this.txtBusqComprobante.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqComprobante.Location = new System.Drawing.Point(19, 30);
            this.txtBusqComprobante.Multiline = true;
            this.txtBusqComprobante.Name = "txtBusqComprobante";
            this.txtBusqComprobante.Size = new System.Drawing.Size(554, 23);
            this.txtBusqComprobante.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(326, 130);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 15);
            this.label8.TabIndex = 91;
            this.label8.Tag = "Hasta";
            this.label8.Text = "Hasta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 90;
            this.label6.Tag = "Desde";
            this.label6.Text = "Desde";
            // 
            // Filtrar
            // 
            this.Filtrar.BackColor = System.Drawing.Color.PowderBlue;
            this.Filtrar.Image = global::TRABAJO_FINAL.Properties.Resources.filtrar;
            this.Filtrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Filtrar.Location = new System.Drawing.Point(603, 119);
            this.Filtrar.Name = "Filtrar";
            this.Filtrar.Size = new System.Drawing.Size(90, 37);
            this.Filtrar.TabIndex = 89;
            this.Filtrar.Tag = "Filtrar";
            this.Filtrar.Text = "Filtrar";
            this.Filtrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Filtrar.UseVisualStyleBackColor = false;
            this.Filtrar.Click += new System.EventHandler(this.Filtrar_Click);
            // 
            // dateTimeHasta
            // 
            this.dateTimeHasta.Location = new System.Drawing.Point(372, 130);
            this.dateTimeHasta.Name = "dateTimeHasta";
            this.dateTimeHasta.Size = new System.Drawing.Size(200, 20);
            this.dateTimeHasta.TabIndex = 88;
            // 
            // dateTimeDesde
            // 
            this.dateTimeDesde.Location = new System.Drawing.Point(80, 130);
            this.dateTimeDesde.Name = "dateTimeDesde";
            this.dateTimeDesde.Size = new System.Drawing.Size(200, 20);
            this.dateTimeDesde.TabIndex = 87;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 86;
            this.label1.Tag = "Venta";
            this.label1.Text = "Venta";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 94;
            this.label2.Tag = "Recibos";
            this.label2.Text = "Recibos";
            // 
            // dgvRecibos
            // 
            this.dgvRecibos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvRecibos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRecibos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRecibos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecibos.Location = new System.Drawing.Point(12, 351);
            this.dgvRecibos.Name = "dgvRecibos";
            this.dgvRecibos.Size = new System.Drawing.Size(591, 139);
            this.dgvRecibos.TabIndex = 93;
            this.dgvRecibos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItems_CellContentClick);
            // 
            // dataNotas
            // 
            this.dataNotas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dataNotas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataNotas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataNotas.Location = new System.Drawing.Point(609, 351);
            this.dataNotas.Name = "dataNotas";
            this.dataNotas.Size = new System.Drawing.Size(606, 139);
            this.dataNotas.TabIndex = 95;
            this.dataNotas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataNotas_CellContentClick);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(607, 335);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 96;
            this.label3.Tag = "Notas de Credito";
            this.label3.Text = "Notas de Credito";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeleccionar.BackColor = System.Drawing.Color.LightGreen;
            this.btnSeleccionar.Image = global::TRABAJO_FINAL.Properties.Resources.seleccione;
            this.btnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSeleccionar.Location = new System.Drawing.Point(845, 42);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(93, 37);
            this.btnSeleccionar.TabIndex = 99;
            this.btnSeleccionar.Tag = "Seleccionar";
            this.btnSeleccionar.Text = "Seleecionar";
            this.btnSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(755, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 98;
            this.label4.Tag = "Venta";
            this.label4.Text = "Venta";
            // 
            // txtComprobante
            // 
            this.txtComprobante.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtComprobante.Location = new System.Drawing.Point(758, 51);
            this.txtComprobante.Name = "txtComprobante";
            this.txtComprobante.ReadOnly = true;
            this.txtComprobante.Size = new System.Drawing.Size(61, 20);
            this.txtComprobante.TabIndex = 97;
            this.txtComprobante.Text = "-";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.LightGreen;
            this.button1.Image = global::TRABAJO_FINAL.Properties.Resources.seleccione;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(845, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 37);
            this.button1.TabIndex = 102;
            this.button1.Tag = "Seleccionar";
            this.button1.Text = "Seleecionar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(755, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 101;
            this.label5.Tag = "Recibo";
            this.label5.Text = "Recibo";
            // 
            // textRecibo
            // 
            this.textRecibo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textRecibo.Location = new System.Drawing.Point(758, 94);
            this.textRecibo.Name = "textRecibo";
            this.textRecibo.ReadOnly = true;
            this.textRecibo.Size = new System.Drawing.Size(61, 20);
            this.textRecibo.TabIndex = 100;
            this.textRecibo.Text = "-";
            // 
            // btnselectNota
            // 
            this.btnselectNota.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnselectNota.BackColor = System.Drawing.Color.LightGreen;
            this.btnselectNota.Image = global::TRABAJO_FINAL.Properties.Resources.seleccione;
            this.btnselectNota.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnselectNota.Location = new System.Drawing.Point(845, 128);
            this.btnselectNota.Name = "btnselectNota";
            this.btnselectNota.Size = new System.Drawing.Size(93, 37);
            this.btnselectNota.TabIndex = 105;
            this.btnselectNota.Tag = "Seleccionar";
            this.btnselectNota.Text = "Seleecionar";
            this.btnselectNota.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnselectNota.UseVisualStyleBackColor = false;
            this.btnselectNota.Click += new System.EventHandler(this.btnselectNota_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(755, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 13);
            this.label7.TabIndex = 104;
            this.label7.Tag = "Nota de Credito";
            this.label7.Text = "Nota de Credito";
            // 
            // textNota
            // 
            this.textNota.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textNota.Location = new System.Drawing.Point(758, 137);
            this.textNota.Name = "textNota";
            this.textNota.ReadOnly = true;
            this.textNota.Size = new System.Drawing.Size(61, 20);
            this.textNota.TabIndex = 103;
            this.textNota.Text = "-";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 504);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 13);
            this.label9.TabIndex = 107;
            this.label9.Tag = "Detalle Recibos";
            this.label9.Text = "Detalle Recibos";
            // 
            // dataRecibosDet
            // 
            this.dataRecibosDet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dataRecibosDet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataRecibosDet.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataRecibosDet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRecibosDet.Location = new System.Drawing.Point(12, 520);
            this.dataRecibosDet.Name = "dataRecibosDet";
            this.dataRecibosDet.Size = new System.Drawing.Size(591, 139);
            this.dataRecibosDet.TabIndex = 106;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(607, 504);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(117, 13);
            this.label10.TabIndex = 109;
            this.label10.Tag = "Detalle Nota de Credito";
            this.label10.Text = "Detalle Nota de Credito";
            // 
            // dataNotasDet
            // 
            this.dataNotasDet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dataNotasDet.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataNotasDet.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataNotasDet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataNotasDet.Location = new System.Drawing.Point(610, 520);
            this.dataNotasDet.Name = "dataNotasDet";
            this.dataNotasDet.Size = new System.Drawing.Size(605, 139);
            this.dataNotasDet.TabIndex = 108;
            // 
            // BuscarReciboYNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 698);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dataNotasDet);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataRecibosDet);
            this.Controls.Add(this.btnselectNota);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textNota);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textRecibo);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtComprobante);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataNotas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvRecibos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Filtrar);
            this.Controls.Add(this.dateTimeHasta);
            this.Controls.Add(this.dateTimeDesde);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvComprobante);
            this.Name = "BuscarReciboYNotas";
            this.Tag = "Buscar Recibos y Notas";
            this.Text = "Buscar Recibos y Notas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BuscarReciboYNotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprobante)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecibos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataNotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataRecibosDet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataNotasDet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvComprobante;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbcliente;
        private System.Windows.Forms.RadioButton rbEstado;
        private System.Windows.Forms.RadioButton rbNDoc;
        private System.Windows.Forms.RadioButton rbComprobante;
        private System.Windows.Forms.RadioButton rbIdVenta;
        private System.Windows.Forms.TextBox txtBusqComprobante;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Filtrar;
        private System.Windows.Forms.DateTimePicker dateTimeHasta;
        private System.Windows.Forms.DateTimePicker dateTimeDesde;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvRecibos;
        private System.Windows.Forms.DataGridView dataNotas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtComprobante;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textRecibo;
        private System.Windows.Forms.Button btnselectNota;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textNota;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataRecibosDet;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dataNotasDet;
    }
}
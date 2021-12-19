namespace TRABAJO_FINAL
{
    partial class BuscarReserva
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtComprobante = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbcliente = new System.Windows.Forms.RadioButton();
            this.rbEstado = new System.Windows.Forms.RadioButton();
            this.rbNDoc = new System.Windows.Forms.RadioButton();
            this.rbComprobante = new System.Windows.Forms.RadioButton();
            this.rbIdReserva = new System.Windows.Forms.RadioButton();
            this.txtBusqComprobante = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimeHasta = new System.Windows.Forms.DateTimePicker();
            this.dateTimeDesde = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.dgvReserva = new System.Windows.Forms.DataGridView();
            this.btnFacturar = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.Filtrar = new System.Windows.Forms.Button();
            this.btnEntrega = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserva)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(641, 357);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 103;
            this.label3.Tag = "Reservas";
            this.label3.Text = "Reserva";
            // 
            // txtComprobante
            // 
            this.txtComprobante.Enabled = false;
            this.txtComprobante.Location = new System.Drawing.Point(704, 354);
            this.txtComprobante.Name = "txtComprobante";
            this.txtComprobante.ReadOnly = true;
            this.txtComprobante.Size = new System.Drawing.Size(61, 20);
            this.txtComprobante.TabIndex = 102;
            this.txtComprobante.Text = "-";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbcliente);
            this.groupBox1.Controls.Add(this.rbEstado);
            this.groupBox1.Controls.Add(this.rbNDoc);
            this.groupBox1.Controls.Add(this.rbComprobante);
            this.groupBox1.Controls.Add(this.rbIdReserva);
            this.groupBox1.Controls.Add(this.txtBusqComprobante);
            this.groupBox1.Location = new System.Drawing.Point(48, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 95);
            this.groupBox1.TabIndex = 101;
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
            this.rbComprobante.Tag = "Comprobantes";
            this.rbComprobante.Text = "Comprobante";
            this.rbComprobante.UseVisualStyleBackColor = true;
            // 
            // rbIdReserva
            // 
            this.rbIdReserva.AutoSize = true;
            this.rbIdReserva.Location = new System.Drawing.Point(19, 65);
            this.rbIdReserva.Name = "rbIdReserva";
            this.rbIdReserva.Size = new System.Drawing.Size(77, 17);
            this.rbIdReserva.TabIndex = 1;
            this.rbIdReserva.TabStop = true;
            this.rbIdReserva.Tag = "Id Reserva";
            this.rbIdReserva.Text = "Id Reserva";
            this.rbIdReserva.UseVisualStyleBackColor = true;
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
            this.label8.Location = new System.Drawing.Point(344, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 15);
            this.label8.TabIndex = 100;
            this.label8.Tag = "Hasta";
            this.label8.Text = "Hasta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(48, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 99;
            this.label6.Tag = "Desde";
            this.label6.Text = "Desde";
            // 
            // dateTimeHasta
            // 
            this.dateTimeHasta.Location = new System.Drawing.Point(390, 138);
            this.dateTimeHasta.Name = "dateTimeHasta";
            this.dateTimeHasta.Size = new System.Drawing.Size(200, 20);
            this.dateTimeHasta.TabIndex = 97;
            // 
            // dateTimeDesde
            // 
            this.dateTimeDesde.Location = new System.Drawing.Point(98, 138);
            this.dateTimeDesde.Name = "dateTimeDesde";
            this.dateTimeDesde.Size = new System.Drawing.Size(200, 20);
            this.dateTimeDesde.TabIndex = 96;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 95;
            this.label2.Tag = "Items";
            this.label2.Text = "Items";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 94;
            this.label1.Tag = "Reservas";
            this.label1.Text = "Reserva";
            // 
            // dgvItems
            // 
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Location = new System.Drawing.Point(33, 342);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.Size = new System.Drawing.Size(557, 293);
            this.dgvItems.TabIndex = 93;
            // 
            // dgvReserva
            // 
            this.dgvReserva.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReserva.Location = new System.Drawing.Point(33, 188);
            this.dgvReserva.Name = "dgvReserva";
            this.dgvReserva.Size = new System.Drawing.Size(1143, 122);
            this.dgvReserva.TabIndex = 92;
            this.dgvReserva.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComprobante_CellContentClick);
            // 
            // btnFacturar
            // 
            this.btnFacturar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFacturar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnFacturar.Image = global::TRABAJO_FINAL.Properties.Resources.copia_escrita;
            this.btnFacturar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFacturar.Location = new System.Drawing.Point(671, 409);
            this.btnFacturar.Name = "btnFacturar";
            this.btnFacturar.Size = new System.Drawing.Size(134, 49);
            this.btnFacturar.TabIndex = 106;
            this.btnFacturar.Tag = "Facturar y Entregar";
            this.btnFacturar.Text = "Facturar y Entregar";
            this.btnFacturar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFacturar.UseVisualStyleBackColor = false;
            this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeleccionar.BackColor = System.Drawing.Color.LightGreen;
            this.btnSeleccionar.Image = global::TRABAJO_FINAL.Properties.Resources.seleccione;
            this.btnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSeleccionar.Location = new System.Drawing.Point(782, 345);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(93, 37);
            this.btnSeleccionar.TabIndex = 104;
            this.btnSeleccionar.Tag = "Seleccionar";
            this.btnSeleccionar.Text = "Seleecionar";
            this.btnSeleccionar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // Filtrar
            // 
            this.Filtrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Filtrar.BackColor = System.Drawing.Color.PowderBlue;
            this.Filtrar.Image = global::TRABAJO_FINAL.Properties.Resources.filtrar;
            this.Filtrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Filtrar.Location = new System.Drawing.Point(621, 127);
            this.Filtrar.Name = "Filtrar";
            this.Filtrar.Size = new System.Drawing.Size(90, 37);
            this.Filtrar.TabIndex = 98;
            this.Filtrar.Tag = "Filtrar";
            this.Filtrar.Text = "Filtrar";
            this.Filtrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Filtrar.UseVisualStyleBackColor = false;
            this.Filtrar.Click += new System.EventHandler(this.Filtrar_Click);
            // 
            // btnEntrega
            // 
            this.btnEntrega.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEntrega.BackColor = System.Drawing.Color.Gold;
            this.btnEntrega.Image = global::TRABAJO_FINAL.Properties.Resources.paquete;
            this.btnEntrega.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEntrega.Location = new System.Drawing.Point(811, 409);
            this.btnEntrega.Name = "btnEntrega";
            this.btnEntrega.Size = new System.Drawing.Size(93, 49);
            this.btnEntrega.TabIndex = 107;
            this.btnEntrega.Tag = "Entregado";
            this.btnEntrega.Text = "Entregado";
            this.btnEntrega.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntrega.UseVisualStyleBackColor = false;
            this.btnEntrega.Click += new System.EventHandler(this.btnEntrega_Click);
            // 
            // BuscarReserva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1208, 655);
            this.Controls.Add(this.btnEntrega);
            this.Controls.Add(this.btnFacturar);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtComprobante);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Filtrar);
            this.Controls.Add(this.dateTimeHasta);
            this.Controls.Add(this.dateTimeDesde);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvItems);
            this.Controls.Add(this.dgvReserva);
            this.Name = "BuscarReserva";
            this.Tag = "Buscar Reserva";
            this.Text = "Buscar Reserva";
            this.Load += new System.EventHandler(this.BuscarReserva_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReserva)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnFacturar;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtComprobante;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbcliente;
        private System.Windows.Forms.RadioButton rbEstado;
        private System.Windows.Forms.RadioButton rbNDoc;
        private System.Windows.Forms.RadioButton rbComprobante;
        private System.Windows.Forms.RadioButton rbIdReserva;
        private System.Windows.Forms.TextBox txtBusqComprobante;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Filtrar;
        private System.Windows.Forms.DateTimePicker dateTimeHasta;
        private System.Windows.Forms.DateTimePicker dateTimeDesde;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.DataGridView dgvReserva;
        private System.Windows.Forms.Button btnEntrega;
    }
}
namespace TRABAJO_FINAL
{
    partial class btnEntregado
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
            this.dgvItems = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeDesde = new System.Windows.Forms.DateTimePicker();
            this.dateTimeHasta = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBusqComprobante = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbcliente = new System.Windows.Forms.RadioButton();
            this.rbEstado = new System.Windows.Forms.RadioButton();
            this.rbNDoc = new System.Windows.Forms.RadioButton();
            this.rbComprobante = new System.Windows.Forms.RadioButton();
            this.rbIdVenta = new System.Windows.Forms.RadioButton();
            this.txtComprobante = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancelado = new System.Windows.Forms.Button();
            this.btnEmitido = new System.Windows.Forms.Button();
            this.btnEntrega = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.Filtrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprobante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvComprobante
            // 
            this.dgvComprobante.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComprobante.Location = new System.Drawing.Point(18, 182);
            this.dgvComprobante.Name = "dgvComprobante";
            this.dgvComprobante.Size = new System.Drawing.Size(1143, 122);
            this.dgvComprobante.TabIndex = 0;
            this.dgvComprobante.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvComprobante_CellClick_1);
            // 
            // dgvItems
            // 
            this.dgvItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItems.Location = new System.Drawing.Point(18, 336);
            this.dgvItems.Name = "dgvItems";
            this.dgvItems.Size = new System.Drawing.Size(557, 293);
            this.dgvItems.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Comprobante";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Items";
            // 
            // dateTimeDesde
            // 
            this.dateTimeDesde.Location = new System.Drawing.Point(83, 132);
            this.dateTimeDesde.Name = "dateTimeDesde";
            this.dateTimeDesde.Size = new System.Drawing.Size(200, 20);
            this.dateTimeDesde.TabIndex = 8;
            // 
            // dateTimeHasta
            // 
            this.dateTimeHasta.Location = new System.Drawing.Point(375, 132);
            this.dateTimeHasta.Name = "dateTimeHasta";
            this.dateTimeHasta.Size = new System.Drawing.Size(200, 20);
            this.dateTimeHasta.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(33, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 83;
            this.label6.Text = "Desde";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(329, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 15);
            this.label8.TabIndex = 84;
            this.label8.Text = "Hasta";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbcliente);
            this.groupBox1.Controls.Add(this.rbEstado);
            this.groupBox1.Controls.Add(this.rbNDoc);
            this.groupBox1.Controls.Add(this.rbComprobante);
            this.groupBox1.Controls.Add(this.rbIdVenta);
            this.groupBox1.Controls.Add(this.txtBusqComprobante);
            this.groupBox1.Location = new System.Drawing.Point(33, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 95);
            this.groupBox1.TabIndex = 85;
            this.groupBox1.TabStop = false;
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
            this.rbIdVenta.Text = "Id Venta";
            this.rbIdVenta.UseVisualStyleBackColor = true;
            // 
            // txtComprobante
            // 
            this.txtComprobante.Location = new System.Drawing.Point(629, 367);
            this.txtComprobante.Name = "txtComprobante";
            this.txtComprobante.ReadOnly = true;
            this.txtComprobante.Size = new System.Drawing.Size(61, 20);
            this.txtComprobante.TabIndex = 86;
            this.txtComprobante.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(626, 351);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 87;
            this.label3.Text = "Comprobante";
            // 
            // btnCancelado
            // 
            this.btnCancelado.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancelado.Image = global::TRABAJO_FINAL.Properties.Resources.error;
            this.btnCancelado.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelado.Location = new System.Drawing.Point(815, 405);
            this.btnCancelado.Name = "btnCancelado";
            this.btnCancelado.Size = new System.Drawing.Size(93, 49);
            this.btnCancelado.TabIndex = 91;
            this.btnCancelado.Tag = "Filtrar";
            this.btnCancelado.Text = "Cancelado";
            this.btnCancelado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelado.UseVisualStyleBackColor = false;
            this.btnCancelado.Click += new System.EventHandler(this.btnCancelado_Click);
            // 
            // btnEmitido
            // 
            this.btnEmitido.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEmitido.BackColor = System.Drawing.Color.Plum;
            this.btnEmitido.Image = global::TRABAJO_FINAL.Properties.Resources.copia_escrita;
            this.btnEmitido.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmitido.Location = new System.Drawing.Point(615, 405);
            this.btnEmitido.Name = "btnEmitido";
            this.btnEmitido.Size = new System.Drawing.Size(93, 49);
            this.btnEmitido.TabIndex = 90;
            this.btnEmitido.Tag = "Filtrar";
            this.btnEmitido.Text = "Emitido";
            this.btnEmitido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmitido.UseVisualStyleBackColor = false;
            this.btnEmitido.Click += new System.EventHandler(this.btnEmitido_Click);
            // 
            // btnEntrega
            // 
            this.btnEntrega.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEntrega.BackColor = System.Drawing.Color.Gold;
            this.btnEntrega.Image = global::TRABAJO_FINAL.Properties.Resources.paquete;
            this.btnEntrega.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEntrega.Location = new System.Drawing.Point(716, 405);
            this.btnEntrega.Name = "btnEntrega";
            this.btnEntrega.Size = new System.Drawing.Size(93, 49);
            this.btnEntrega.TabIndex = 89;
            this.btnEntrega.Tag = "Filtrar";
            this.btnEntrega.Text = "Entregado";
            this.btnEntrega.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEntrega.UseVisualStyleBackColor = false;
            this.btnEntrega.Click += new System.EventHandler(this.btnEntrega_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSeleccionar.BackColor = System.Drawing.Color.LightGreen;
            this.btnSeleccionar.Image = global::TRABAJO_FINAL.Properties.Resources.seleccione;
            this.btnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSeleccionar.Location = new System.Drawing.Point(716, 358);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(93, 37);
            this.btnSeleccionar.TabIndex = 88;
            this.btnSeleccionar.Tag = "Filtrar";
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
            this.Filtrar.Location = new System.Drawing.Point(606, 121);
            this.Filtrar.Name = "Filtrar";
            this.Filtrar.Size = new System.Drawing.Size(90, 37);
            this.Filtrar.TabIndex = 79;
            this.Filtrar.Tag = "Filtrar";
            this.Filtrar.Text = "Filtrar";
            this.Filtrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Filtrar.UseVisualStyleBackColor = false;
            this.Filtrar.Click += new System.EventHandler(this.Filtrar_Click);
            // 
            // btnEntregado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 675);
            this.Controls.Add(this.btnCancelado);
            this.Controls.Add(this.btnEmitido);
            this.Controls.Add(this.btnEntrega);
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
            this.Controls.Add(this.dgvComprobante);
            this.Name = "btnEntregado";
            this.Text = "BuscarComprobante";
            this.Load += new System.EventHandler(this.BuscarComprobante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprobante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItems)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvComprobante;
        private System.Windows.Forms.DataGridView dgvItems;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeDesde;
        private System.Windows.Forms.DateTimePicker dateTimeHasta;
        private System.Windows.Forms.Button Filtrar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBusqComprobante;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbcliente;
        private System.Windows.Forms.RadioButton rbEstado;
        private System.Windows.Forms.RadioButton rbNDoc;
        private System.Windows.Forms.RadioButton rbComprobante;
        private System.Windows.Forms.RadioButton rbIdVenta;
        private System.Windows.Forms.TextBox txtComprobante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnEntrega;
        private System.Windows.Forms.Button btnEmitido;
        private System.Windows.Forms.Button btnCancelado;
    }
}
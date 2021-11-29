namespace TRABAJO_FINAL
{
    partial class BuscarProducto
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rCant = new System.Windows.Forms.RadioButton();
            this.rbPrecio = new System.Windows.Forms.RadioButton();
            this.rbCategoria = new System.Windows.Forms.RadioButton();
            this.rbNombreProd = new System.Windows.Forms.RadioButton();
            this.txtBusqProd = new System.Windows.Forms.TextBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.Filtrar = new System.Windows.Forms.Button();
            this.btnVender = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.BackColor = System.Drawing.Color.LightCoral;
            this.btnSalir.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(969, 98);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(80, 40);
            this.btnSalir.TabIndex = 56;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCargar.BackColor = System.Drawing.Color.LightGreen;
            this.btnCargar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCargar.Location = new System.Drawing.Point(883, 98);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(80, 40);
            this.btnCargar.TabIndex = 55;
            this.btnCargar.Text = "Actualizar";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rCant);
            this.groupBox1.Controls.Add(this.rbPrecio);
            this.groupBox1.Controls.Add(this.rbCategoria);
            this.groupBox1.Controls.Add(this.rbNombreProd);
            this.groupBox1.Controls.Add(this.txtBusqProd);
            this.groupBox1.Location = new System.Drawing.Point(23, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(491, 99);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar por";
            // 
            // rCant
            // 
            this.rCant.AutoSize = true;
            this.rCant.Location = new System.Drawing.Point(354, 65);
            this.rCant.Name = "rCant";
            this.rCant.Size = new System.Drawing.Size(131, 17);
            this.rCant.TabIndex = 4;
            this.rCant.TabStop = true;
            this.rCant.Text = "Cantidad de jugadores";
            this.rCant.UseVisualStyleBackColor = true;
            // 
            // rbPrecio
            // 
            this.rbPrecio.AutoSize = true;
            this.rbPrecio.Location = new System.Drawing.Point(248, 65);
            this.rbPrecio.Name = "rbPrecio";
            this.rbPrecio.Size = new System.Drawing.Size(55, 17);
            this.rbPrecio.TabIndex = 3;
            this.rbPrecio.TabStop = true;
            this.rbPrecio.Text = "Precio";
            this.rbPrecio.UseVisualStyleBackColor = true;
            // 
            // rbCategoria
            // 
            this.rbCategoria.AutoSize = true;
            this.rbCategoria.Location = new System.Drawing.Point(131, 65);
            this.rbCategoria.Name = "rbCategoria";
            this.rbCategoria.Size = new System.Drawing.Size(70, 17);
            this.rbCategoria.TabIndex = 2;
            this.rbCategoria.TabStop = true;
            this.rbCategoria.Text = "Categoria";
            this.rbCategoria.UseVisualStyleBackColor = true;
            // 
            // rbNombreProd
            // 
            this.rbNombreProd.AutoSize = true;
            this.rbNombreProd.Location = new System.Drawing.Point(19, 65);
            this.rbNombreProd.Name = "rbNombreProd";
            this.rbNombreProd.Size = new System.Drawing.Size(62, 17);
            this.rbNombreProd.TabIndex = 1;
            this.rbNombreProd.TabStop = true;
            this.rbNombreProd.Text = "Nombre";
            this.rbNombreProd.UseVisualStyleBackColor = true;
            // 
            // txtBusqProd
            // 
            this.txtBusqProd.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqProd.Location = new System.Drawing.Point(19, 30);
            this.txtBusqProd.Multiline = true;
            this.txtBusqProd.Name = "txtBusqProd";
            this.txtBusqProd.Size = new System.Drawing.Size(466, 27);
            this.txtBusqProd.TabIndex = 0;
            // 
            // dgvProductos
            // 
            this.dgvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(23, 144);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(1029, 361);
            this.dgvProductos.TabIndex = 52;
            // 
            // Filtrar
            // 
            this.Filtrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Filtrar.BackColor = System.Drawing.Color.PowderBlue;
            this.Filtrar.Image = global::TRABAJO_FINAL.Properties.Resources.filtrar;
            this.Filtrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Filtrar.Location = new System.Drawing.Point(530, 63);
            this.Filtrar.Name = "Filtrar";
            this.Filtrar.Size = new System.Drawing.Size(90, 37);
            this.Filtrar.TabIndex = 73;
            this.Filtrar.Tag = "Filtrar";
            this.Filtrar.Text = "Filtrar";
            this.Filtrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Filtrar.UseVisualStyleBackColor = false;
            this.Filtrar.Click += new System.EventHandler(this.Filtrar_Click);
            // 
            // btnVender
            // 
            this.btnVender.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVender.BackColor = System.Drawing.Color.Bisque;
            this.btnVender.Image = global::TRABAJO_FINAL.Properties.Resources.carrito_de_compras__2_;
            this.btnVender.Location = new System.Drawing.Point(797, 98);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(80, 40);
            this.btnVender.TabIndex = 54;
            this.btnVender.UseVisualStyleBackColor = false;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // BuscarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 544);
            this.Controls.Add(this.Filtrar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnVender);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvProductos);
            this.Name = "BuscarProducto";
            this.Text = "BuscarProducto";
            this.Load += new System.EventHandler(this.BuscarProducto_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbPrecio;
        private System.Windows.Forms.RadioButton rbCategoria;
        private System.Windows.Forms.RadioButton rbNombreProd;
        private System.Windows.Forms.TextBox txtBusqProd;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.RadioButton rCant;
        private System.Windows.Forms.Button Filtrar;
    }
}
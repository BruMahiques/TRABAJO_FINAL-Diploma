namespace TRABAJO_FINAL
{
    partial class ABMProductos
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
            this.label26 = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.txtDuracion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodigoP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textEdad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textCant = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textCategoria = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnEliminarP = new System.Windows.Forms.Button();
            this.btnSalirP = new System.Windows.Forms.Button();
            this.btnNuevoP = new System.Windows.Forms.Button();
            this.btnEditarP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(18, 100);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(55, 13);
            this.label26.TabIndex = 75;
            this.label26.Text = "Categoria:";
            // 
            // dgvProductos
            // 
            this.dgvProductos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(20, 248);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(1053, 260);
            this.dgvProductos.TabIndex = 65;
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPrecioVenta.BackColor = System.Drawing.Color.Aqua;
            this.txtPrecioVenta.Location = new System.Drawing.Point(336, 183);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(50, 20);
            this.txtPrecioVenta.TabIndex = 48;
            this.txtPrecioVenta.Text = "0,00";
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(232, 183);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 13);
            this.label16.TabIndex = 64;
            this.label16.Text = "Precio Venta s/:";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(132, 211);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(50, 20);
            this.txtStock.TabIndex = 50;
            this.txtStock.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 58;
            this.label7.Text = "Precio Compra s/:";
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNombre.Location = new System.Drawing.Point(132, 41);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(803, 20);
            this.txtNombre.TabIndex = 44;
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.BackColor = System.Drawing.Color.Aqua;
            this.txtPrecioCompra.Location = new System.Drawing.Point(132, 183);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(50, 20);
            this.txtPrecioCompra.TabIndex = 47;
            this.txtPrecioCompra.Text = "0,00";
            // 
            // txtDuracion
            // 
            this.txtDuracion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDuracion.Location = new System.Drawing.Point(132, 70);
            this.txtDuracion.Name = "txtDuracion";
            this.txtDuracion.Size = new System.Drawing.Size(803, 20);
            this.txtDuracion.TabIndex = 46;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 55;
            this.label6.Text = "Duracion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 211);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 52;
            this.label5.Text = "Stock:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Producto:";
            // 
            // txtCodigoP
            // 
            this.txtCodigoP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigoP.Enabled = false;
            this.txtCodigoP.Location = new System.Drawing.Point(132, 12);
            this.txtCodigoP.Name = "txtCodigoP";
            this.txtCodigoP.ReadOnly = true;
            this.txtCodigoP.Size = new System.Drawing.Size(803, 20);
            this.txtCodigoP.TabIndex = 45;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 43;
            this.label3.Text = "Codigo:";
            // 
            // textEdad
            // 
            this.textEdad.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textEdad.Location = new System.Drawing.Point(132, 130);
            this.textEdad.Name = "textEdad";
            this.textEdad.Size = new System.Drawing.Size(149, 20);
            this.textEdad.TabIndex = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 77;
            this.label1.Text = "Edad:";
            // 
            // textCant
            // 
            this.textCant.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textCant.Location = new System.Drawing.Point(132, 154);
            this.textCant.Name = "textCant";
            this.textCant.Size = new System.Drawing.Size(149, 20);
            this.textCant.TabIndex = 78;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 79;
            this.label4.Text = "Cant. de jugadores:";
            // 
            // textCategoria
            // 
            this.textCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textCategoria.Location = new System.Drawing.Point(132, 97);
            this.textCategoria.Name = "textCategoria";
            this.textCategoria.Size = new System.Drawing.Size(803, 20);
            this.textCategoria.TabIndex = 81;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Image = global::TRABAJO_FINAL.Properties.Resources.limpiar_deslizar;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(941, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 22);
            this.button2.TabIndex = 82;
            this.button2.Text = "Limpiar Codigo";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Image = global::TRABAJO_FINAL.Properties.Resources.limpiar;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(587, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 37);
            this.button1.TabIndex = 80;
            this.button1.Text = "Limpiar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEliminarP
            // 
            this.btnEliminarP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarP.Image = global::TRABAJO_FINAL.Properties.Resources.eliminar;
            this.btnEliminarP.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarP.Location = new System.Drawing.Point(973, 142);
            this.btnEliminarP.Name = "btnEliminarP";
            this.btnEliminarP.Size = new System.Drawing.Size(90, 37);
            this.btnEliminarP.TabIndex = 70;
            this.btnEliminarP.Text = "Eliminar";
            this.btnEliminarP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarP.UseVisualStyleBackColor = true;
            this.btnEliminarP.Click += new System.EventHandler(this.btnEliminarP_Click);
            // 
            // btnSalirP
            // 
            this.btnSalirP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalirP.Image = global::TRABAJO_FINAL.Properties.Resources.cerrar_sesion;
            this.btnSalirP.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalirP.Location = new System.Drawing.Point(973, 185);
            this.btnSalirP.Name = "btnSalirP";
            this.btnSalirP.Size = new System.Drawing.Size(90, 37);
            this.btnSalirP.TabIndex = 68;
            this.btnSalirP.Text = "Salir";
            this.btnSalirP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalirP.UseVisualStyleBackColor = true;
            this.btnSalirP.Click += new System.EventHandler(this.btnSalirP_Click);
            // 
            // btnNuevoP
            // 
            this.btnNuevoP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevoP.Image = global::TRABAJO_FINAL.Properties.Resources.agregar_archivo;
            this.btnNuevoP.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoP.Location = new System.Drawing.Point(973, 53);
            this.btnNuevoP.Name = "btnNuevoP";
            this.btnNuevoP.Size = new System.Drawing.Size(90, 37);
            this.btnNuevoP.TabIndex = 67;
            this.btnNuevoP.Text = "Nuevo";
            this.btnNuevoP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoP.UseVisualStyleBackColor = true;
            this.btnNuevoP.Click += new System.EventHandler(this.btnNuevoP_Click);
            // 
            // btnEditarP
            // 
            this.btnEditarP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditarP.Image = global::TRABAJO_FINAL.Properties.Resources.editar;
            this.btnEditarP.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditarP.Location = new System.Drawing.Point(973, 96);
            this.btnEditarP.Name = "btnEditarP";
            this.btnEditarP.Size = new System.Drawing.Size(90, 37);
            this.btnEditarP.TabIndex = 66;
            this.btnEditarP.Text = "Editar";
            this.btnEditarP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarP.UseVisualStyleBackColor = true;
            this.btnEditarP.Click += new System.EventHandler(this.btnEditarP_Click);
            // 
            // ABMProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 520);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textCategoria);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textCant);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textEdad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.btnEliminarP);
            this.Controls.Add(this.btnSalirP);
            this.Controls.Add(this.btnNuevoP);
            this.Controls.Add(this.btnEditarP);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.txtPrecioVenta);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtPrecioCompra);
            this.Controls.Add(this.txtDuracion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigoP);
            this.Controls.Add(this.label3);
            this.Name = "ABMProductos";
            this.Text = "ABMProductos";
            this.Load += new System.EventHandler(this.ABMProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Button btnEliminarP;
        private System.Windows.Forms.Button btnSalirP;
        private System.Windows.Forms.Button btnNuevoP;
        private System.Windows.Forms.Button btnEditarP;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.TextBox txtPrecioVenta;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtPrecioCompra;
        private System.Windows.Forms.TextBox txtDuracion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodigoP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textEdad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textCant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textCategoria;
        private System.Windows.Forms.Button button2;
    }
}
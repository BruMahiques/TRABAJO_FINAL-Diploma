namespace TRABAJO_FINAL
{
    partial class Clientes
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.btnEliminarP = new System.Windows.Forms.Button();
            this.btnNuevoP = new System.Windows.Forms.Button();
            this.btnEditarP = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(321, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(625, 403);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(90, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(90, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(90, 131);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(90, 240);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(28, 197);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 6;
            this.label1.Tag = "Nombre";
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Tag = "Apellido";
            this.label2.Text = "Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 8;
            this.label3.Tag = "DNI";
            this.label3.Text = "DNI:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 13);
            this.label4.TabIndex = 9;
            this.label4.Tag = "Fecha de nacimiento";
            this.label4.Text = "Fecha de nacimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 10;
            this.label5.Tag = "Email";
            this.label5.Text = "Correo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 13);
            this.label6.TabIndex = 11;
            this.label6.Tag = "Cod_Cliente";
            this.label6.Text = "Codigo del cliente:";
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(90, 319);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 12;
            this.textBox5.Text = "(..)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(196, 322);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 13;
            this.label7.Tag = "Modificar";
            this.label7.Text = "(Mod o Baja)";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(25, 345);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 17;
            this.button4.Tag = "Sacar";
            this.button4.Text = "Limpiar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnEliminarP
            // 
            this.btnEliminarP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarP.Image = global::TRABAJO_FINAL.Properties.Resources.eliminar;
            this.btnEliminarP.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminarP.Location = new System.Drawing.Point(208, 398);
            this.btnEliminarP.Name = "btnEliminarP";
            this.btnEliminarP.Size = new System.Drawing.Size(90, 37);
            this.btnEliminarP.TabIndex = 73;
            this.btnEliminarP.Tag = "Borrar";
            this.btnEliminarP.Text = "Eliminar";
            this.btnEliminarP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminarP.UseVisualStyleBackColor = true;
            this.btnEliminarP.Click += new System.EventHandler(this.btnEliminarP_Click);
            // 
            // btnNuevoP
            // 
            this.btnNuevoP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNuevoP.Image = global::TRABAJO_FINAL.Properties.Resources.agregar_archivo;
            this.btnNuevoP.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNuevoP.Location = new System.Drawing.Point(16, 397);
            this.btnNuevoP.Name = "btnNuevoP";
            this.btnNuevoP.Size = new System.Drawing.Size(90, 37);
            this.btnNuevoP.TabIndex = 72;
            this.btnNuevoP.Tag = "Nuevo";
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
            this.btnEditarP.Location = new System.Drawing.Point(112, 398);
            this.btnEditarP.Name = "btnEditarP";
            this.btnEditarP.Size = new System.Drawing.Size(90, 37);
            this.btnEditarP.TabIndex = 71;
            this.btnEditarP.Tag = "Editar";
            this.btnEditarP.Text = "Editar";
            this.btnEditarP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditarP.UseVisualStyleBackColor = true;
            this.btnEditarP.Click += new System.EventHandler(this.btnEditarP_Click);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(958, 447);
            this.Controls.Add(this.btnEliminarP);
            this.Controls.Add(this.btnNuevoP);
            this.Controls.Add(this.btnEditarP);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Clientes";
            this.Tag = "ABM Cliente";
            this.Text = "ABM Cliente";
            this.Load += new System.EventHandler(this.ABMClienteConectado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnEliminarP;
        private System.Windows.Forms.Button btnNuevoP;
        private System.Windows.Forms.Button btnEditarP;
    }
}
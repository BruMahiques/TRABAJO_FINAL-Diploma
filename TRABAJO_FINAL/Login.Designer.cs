namespace TRABAJO_FINAL
{
    partial class InicioSesion
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Usu = new System.Windows.Forms.Label();
            this.Clave = new System.Windows.Forms.Label();
            this.Entrar = new System.Windows.Forms.Button();
            this.Sal = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(342, 74);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(342, 132);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(160, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Usu
            // 
            this.Usu.AutoSize = true;
            this.Usu.Location = new System.Drawing.Point(267, 77);
            this.Usu.Name = "Usu";
            this.Usu.Size = new System.Drawing.Size(43, 13);
            this.Usu.TabIndex = 2;
            this.Usu.Tag = "Usuario";
            this.Usu.Text = "Usuario";
            // 
            // Clave
            // 
            this.Clave.AutoSize = true;
            this.Clave.Location = new System.Drawing.Point(267, 139);
            this.Clave.Name = "Clave";
            this.Clave.Size = new System.Drawing.Size(34, 13);
            this.Clave.TabIndex = 3;
            this.Clave.Tag = "Clave";
            this.Clave.Text = "Clave";
            // 
            // Entrar
            // 
            this.Entrar.Location = new System.Drawing.Point(342, 177);
            this.Entrar.Name = "Entrar";
            this.Entrar.Size = new System.Drawing.Size(75, 23);
            this.Entrar.TabIndex = 6;
            this.Entrar.Tag = "Entrar";
            this.Entrar.Text = "Entrar";
            this.Entrar.UseVisualStyleBackColor = true;
            this.Entrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Sal
            // 
            this.Sal.Location = new System.Drawing.Point(427, 177);
            this.Sal.Name = "Sal";
            this.Sal.Size = new System.Drawing.Size(75, 23);
            this.Sal.TabIndex = 21;
            this.Sal.Tag = "Salir";
            this.Sal.Text = "Salir";
            this.Sal.UseVisualStyleBackColor = true;
            this.Sal.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.Image = global::TRABAJO_FINAL.Properties.Resources.contrasena__1_;
            this.label3.Location = new System.Drawing.Point(201, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 61);
            this.label3.TabIndex = 24;
            this.label3.Text = "               ";
            // 
            // label2
            // 
            this.label2.Image = global::TRABAJO_FINAL.Properties.Resources.usuario;
            this.label2.Location = new System.Drawing.Point(201, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 61);
            this.label2.TabIndex = 23;
            this.label2.Text = "               ";
            // 
            // label1
            // 
            this.label1.Image = global::TRABAJO_FINAL.Properties.Resources.iniciar_sesion;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 190);
            this.label1.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 10);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(493, 30);
            this.label4.TabIndex = 25;
            this.label4.Text = "INGRESAR AL SISTEMA";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 261);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Sal);
            this.Controls.Add(this.Entrar);
            this.Controls.Add(this.Clave);
            this.Controls.Add(this.Usu);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "InicioSesion";
            this.Tag = "InicioSesion";
            this.Text = "Inicio de Sesion";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label Usu;
        private System.Windows.Forms.Label Clave;
        private System.Windows.Forms.Button Entrar;
        private System.Windows.Forms.Button Sal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
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
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(152, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(160, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(152, 136);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(160, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Usu
            // 
            this.Usu.AutoSize = true;
            this.Usu.Location = new System.Drawing.Point(61, 85);
            this.Usu.Name = "Usu";
            this.Usu.Size = new System.Drawing.Size(43, 13);
            this.Usu.TabIndex = 2;
            this.Usu.Tag = "Usuario";
            this.Usu.Text = "Usuario";
            // 
            // Clave
            // 
            this.Clave.AutoSize = true;
            this.Clave.Location = new System.Drawing.Point(61, 142);
            this.Clave.Name = "Clave";
            this.Clave.Size = new System.Drawing.Size(34, 13);
            this.Clave.TabIndex = 3;
            this.Clave.Tag = "Clave";
            this.Clave.Text = "Clave";
            // 
            // Entrar
            // 
            this.Entrar.Location = new System.Drawing.Point(197, 208);
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
            this.Sal.Location = new System.Drawing.Point(464, 241);
            this.Sal.Name = "Sal";
            this.Sal.Size = new System.Drawing.Size(75, 23);
            this.Sal.TabIndex = 21;
            this.Sal.Tag = "Salir";
            this.Sal.Text = "Salir";
            this.Sal.UseVisualStyleBackColor = true;
            this.Sal.Click += new System.EventHandler(this.button5_Click);
            // 
            // InicioSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 276);
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
    }
}
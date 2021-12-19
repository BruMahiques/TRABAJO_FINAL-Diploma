namespace TRABAJO_FINAL
{
    partial class IdiomaTraducciones
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboTitulo = new System.Windows.Forms.ComboBox();
            this.comboIdioma = new System.Windows.Forms.ComboBox();
            this.textTraduccion = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Tag = "Titulo";
            this.label1.Text = "Titulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Tag = "Idiomas";
            this.label2.Text = "Idiomas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 2;
            this.label3.Tag = "Traduccion";
            this.label3.Text = "Traduccion";
            // 
            // comboTitulo
            // 
            this.comboTitulo.FormattingEnabled = true;
            this.comboTitulo.Location = new System.Drawing.Point(151, 26);
            this.comboTitulo.Name = "comboTitulo";
            this.comboTitulo.Size = new System.Drawing.Size(121, 21);
            this.comboTitulo.TabIndex = 3;
            // 
            // comboIdioma
            // 
            this.comboIdioma.FormattingEnabled = true;
            this.comboIdioma.Location = new System.Drawing.Point(151, 63);
            this.comboIdioma.Name = "comboIdioma";
            this.comboIdioma.Size = new System.Drawing.Size(121, 21);
            this.comboIdioma.TabIndex = 4;
            // 
            // textTraduccion
            // 
            this.textTraduccion.Location = new System.Drawing.Point(151, 132);
            this.textTraduccion.Name = "textTraduccion";
            this.textTraduccion.Size = new System.Drawing.Size(100, 20);
            this.textTraduccion.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(151, 90);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Tag = "Buscar";
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(151, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Tag = "Insertar";
            this.button2.Text = "Insertar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label7
            // 
            this.label7.Image = global::TRABAJO_FINAL.Properties.Resources.buscar;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 85);
            this.label7.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.Image = global::TRABAJO_FINAL.Properties.Resources.traduccion__1_;
            this.label4.Location = new System.Drawing.Point(12, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 85);
            this.label4.TabIndex = 26;
            // 
            // IdiomaTraducciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 208);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textTraduccion);
            this.Controls.Add(this.comboIdioma);
            this.Controls.Add(this.comboTitulo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "IdiomaTraducciones";
            this.Tag = "Traducciones de Idioma";
            this.Text = "IdiomaTraducciones";
            this.Load += new System.EventHandler(this.IdiomaTraducciones_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboTitulo;
        private System.Windows.Forms.ComboBox comboIdioma;
        private System.Windows.Forms.TextBox textTraduccion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
    }
}
﻿namespace TRABAJO_FINAL
{
    partial class IdiomaTitulos
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.TxtCodTitulo = new System.Windows.Forms.TextBox();
            this.TxtTitulo = new System.Windows.Forms.TextBox();
            this.dataGridViewTitulos = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTitulos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Tag = "Cod_Titulo";
            this.label1.Text = "Cod_Titulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Tag = "Titulo";
            this.label2.Text = "Titulo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 136);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Tag = "Agregar";
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(132, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Tag = "Modificar";
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(213, 136);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Tag = "Borrar";
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // TxtCodTitulo
            // 
            this.TxtCodTitulo.Location = new System.Drawing.Point(190, 39);
            this.TxtCodTitulo.Name = "TxtCodTitulo";
            this.TxtCodTitulo.Size = new System.Drawing.Size(100, 20);
            this.TxtCodTitulo.TabIndex = 5;
            // 
            // TxtTitulo
            // 
            this.TxtTitulo.Location = new System.Drawing.Point(190, 65);
            this.TxtTitulo.Name = "TxtTitulo";
            this.TxtTitulo.Size = new System.Drawing.Size(100, 20);
            this.TxtTitulo.TabIndex = 6;
            // 
            // dataGridViewTitulos
            // 
            this.dataGridViewTitulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTitulos.Location = new System.Drawing.Point(15, 165);
            this.dataGridViewTitulos.Name = "dataGridViewTitulos";
            this.dataGridViewTitulos.Size = new System.Drawing.Size(313, 254);
            this.dataGridViewTitulos.TabIndex = 7;
            this.dataGridViewTitulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label5
            // 
            this.label5.Image = global::TRABAJO_FINAL.Properties.Resources.borrar;
            this.label5.Location = new System.Drawing.Point(231, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 38);
            this.label5.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.Image = global::TRABAJO_FINAL.Properties.Resources.editar__1_;
            this.label4.Location = new System.Drawing.Point(153, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 38);
            this.label4.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.Image = global::TRABAJO_FINAL.Properties.Resources.agregar;
            this.label3.Location = new System.Drawing.Point(68, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 38);
            this.label3.TabIndex = 26;
            // 
            // label7
            // 
            this.label7.Image = global::TRABAJO_FINAL.Properties.Resources.idiomas__3_;
            this.label7.Location = new System.Drawing.Point(12, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 98);
            this.label7.TabIndex = 25;
            // 
            // IdiomaTitulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 431);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridViewTitulos);
            this.Controls.Add(this.TxtTitulo);
            this.Controls.Add(this.TxtCodTitulo);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "IdiomaTitulos";
            this.Tag = "Titulos de Idioma";
            this.Text = "IdiomaTItulos";
            this.Load += new System.EventHandler(this.IdiomaTitulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTitulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox TxtCodTitulo;
        private System.Windows.Forms.TextBox TxtTitulo;
        private System.Windows.Forms.DataGridView dataGridViewTitulos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
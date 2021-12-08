namespace TRABAJO_FINAL
{
    partial class AbrirSerialización
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
            this.dgvSerializacion = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSerializacion)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSerializacion
            // 
            this.dgvSerializacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSerializacion.Location = new System.Drawing.Point(80, 53);
            this.dgvSerializacion.Name = "dgvSerializacion";
            this.dgvSerializacion.Size = new System.Drawing.Size(622, 350);
            this.dgvSerializacion.TabIndex = 0;
            // 
            // AbrirSerialización
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvSerializacion);
            this.Name = "AbrirSerialización";
            this.Text = "AbrirSerialización";
            this.Load += new System.EventHandler(this.AbrirSerialización_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSerializacion)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSerializacion;
    }
}
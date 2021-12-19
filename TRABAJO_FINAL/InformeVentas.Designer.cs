namespace TRABAJO_FINAL
{
    partial class InformeVentas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimeHasta = new System.Windows.Forms.DateTimePicker();
            this.dateTimeDesde = new System.Windows.Forms.DateTimePicker();
            this.dgvInforme1 = new System.Windows.Forms.DataGridView();
            this.dgvInforme2 = new System.Windows.Forms.DataGridView();
            this.Filtrar = new System.Windows.Forms.Button();
            this.btnCargarDatos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInforme1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInforme2)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 350);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(537, 407);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // chart2
            // 
            chartArea2.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(555, 350);
            this.chart2.Name = "chart2";
            this.chart2.Size = new System.Drawing.Size(537, 407);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(328, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 15);
            this.label8.TabIndex = 89;
            this.label8.Tag = "Hasta";
            this.label8.Text = "Hasta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(32, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 15);
            this.label6.TabIndex = 88;
            this.label6.Tag = "Desde";
            this.label6.Text = "Desde";
            // 
            // dateTimeHasta
            // 
            this.dateTimeHasta.Location = new System.Drawing.Point(374, 30);
            this.dateTimeHasta.Name = "dateTimeHasta";
            this.dateTimeHasta.Size = new System.Drawing.Size(200, 20);
            this.dateTimeHasta.TabIndex = 86;
            // 
            // dateTimeDesde
            // 
            this.dateTimeDesde.Location = new System.Drawing.Point(82, 30);
            this.dateTimeDesde.Name = "dateTimeDesde";
            this.dateTimeDesde.Size = new System.Drawing.Size(200, 20);
            this.dateTimeDesde.TabIndex = 85;
            // 
            // dgvInforme1
            // 
            this.dgvInforme1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInforme1.Location = new System.Drawing.Point(12, 68);
            this.dgvInforme1.Name = "dgvInforme1";
            this.dgvInforme1.Size = new System.Drawing.Size(537, 276);
            this.dgvInforme1.TabIndex = 90;
            // 
            // dgvInforme2
            // 
            this.dgvInforme2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInforme2.Location = new System.Drawing.Point(555, 68);
            this.dgvInforme2.Name = "dgvInforme2";
            this.dgvInforme2.Size = new System.Drawing.Size(537, 276);
            this.dgvInforme2.TabIndex = 91;
            // 
            // Filtrar
            // 
            this.Filtrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Filtrar.BackColor = System.Drawing.Color.PowderBlue;
            this.Filtrar.Image = global::TRABAJO_FINAL.Properties.Resources.filtrar;
            this.Filtrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Filtrar.Location = new System.Drawing.Point(605, 19);
            this.Filtrar.Name = "Filtrar";
            this.Filtrar.Size = new System.Drawing.Size(90, 37);
            this.Filtrar.TabIndex = 87;
            this.Filtrar.Tag = "Filtrar";
            this.Filtrar.Text = "Filtrar";
            this.Filtrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Filtrar.UseVisualStyleBackColor = false;
            this.Filtrar.Click += new System.EventHandler(this.Filtrar_Click);
            // 
            // btnCargarDatos
            // 
            this.btnCargarDatos.BackColor = System.Drawing.Color.FloralWhite;
            this.btnCargarDatos.Enabled = false;
            this.btnCargarDatos.Image = global::TRABAJO_FINAL.Properties.Resources.descargar_pdf;
            this.btnCargarDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCargarDatos.Location = new System.Drawing.Point(1098, 350);
            this.btnCargarDatos.Name = "btnCargarDatos";
            this.btnCargarDatos.Size = new System.Drawing.Size(123, 43);
            this.btnCargarDatos.TabIndex = 2;
            this.btnCargarDatos.Tag = "Exportar a PDF";
            this.btnCargarDatos.Text = "Exportar a PDF";
            this.btnCargarDatos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargarDatos.UseVisualStyleBackColor = false;
            this.btnCargarDatos.Click += new System.EventHandler(this.btnCargarDatos_Click);
            // 
            // InformeVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1330, 805);
            this.Controls.Add(this.dgvInforme2);
            this.Controls.Add(this.dgvInforme1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Filtrar);
            this.Controls.Add(this.dateTimeHasta);
            this.Controls.Add(this.dateTimeDesde);
            this.Controls.Add(this.btnCargarDatos);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart1);
            this.Name = "InformeVentas";
            this.Tag = "Informe";
            this.Text = "Informe Ventas";
            this.Load += new System.EventHandler(this.InformeVentas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInforme1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInforme2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.Button btnCargarDatos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Filtrar;
        private System.Windows.Forms.DateTimePicker dateTimeHasta;
        private System.Windows.Forms.DateTimePicker dateTimeDesde;
        private System.Windows.Forms.DataGridView dgvInforme1;
        private System.Windows.Forms.DataGridView dgvInforme2;
    }
}
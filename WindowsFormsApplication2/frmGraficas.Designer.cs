namespace WindowsFormsApplication2
{
    partial class frmGraficas
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.cbxSucursal = new System.Windows.Forms.ComboBox();
            this.calGrafica = new System.Windows.Forms.MonthCalendar();
            this.gCategorias = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gVentas = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.gCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gVentas)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxSucursal
            // 
            this.cbxSucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSucursal.FormattingEnabled = true;
            this.cbxSucursal.Location = new System.Drawing.Point(20, 4);
            this.cbxSucursal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxSucursal.Name = "cbxSucursal";
            this.cbxSucursal.Size = new System.Drawing.Size(255, 24);
            this.cbxSucursal.TabIndex = 0;
            // 
            // calGrafica
            // 
            this.calGrafica.Location = new System.Drawing.Point(15, 31);
            this.calGrafica.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.calGrafica.Name = "calGrafica";
            this.calGrafica.TabIndex = 1;
            // 
            // gCategorias
            // 
            chartArea1.Name = "ChartArea1";
            this.gCategorias.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.gCategorias.Legends.Add(legend1);
            this.gCategorias.Location = new System.Drawing.Point(651, 260);
            this.gCategorias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gCategorias.Name = "gCategorias";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.gCategorias.Series.Add(series1);
            this.gCategorias.Size = new System.Drawing.Size(543, 369);
            this.gCategorias.TabIndex = 2;
            this.gCategorias.Text = "chart1";
            // 
            // gVentas
            // 
            chartArea2.Name = "ChartArea1";
            this.gVentas.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.gVentas.Legends.Add(legend2);
            this.gVentas.Location = new System.Drawing.Point(13, 257);
            this.gVentas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gVentas.Name = "gVentas";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.gVentas.Series.Add(series2);
            this.gVentas.Size = new System.Drawing.Size(543, 369);
            this.gVentas.TabIndex = 3;
            this.gVentas.Text = "chart2";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.cbxSucursal);
            this.panel1.Controls.Add(this.calGrafica);
            this.panel1.Location = new System.Drawing.Point(454, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(298, 245);
            this.panel1.TabIndex = 4;
            // 
            // frmGraficas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1207, 640);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gVentas);
            this.Controls.Add(this.gCategorias);
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmGraficas";
            this.Text = "Graficos";
            this.Load += new System.EventHandler(this.frmGraficas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gVentas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxSucursal;
        private System.Windows.Forms.MonthCalendar calGrafica;
        private System.Windows.Forms.DataVisualization.Charting.Chart gCategorias;
        private System.Windows.Forms.DataVisualization.Charting.Chart gVentas;
        private System.Windows.Forms.Panel panel1;
    }
}
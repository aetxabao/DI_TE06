
namespace GraSupInf.Controles_Usuario {
    partial class PanelModuloUC {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.tlpPanel = new System.Windows.Forms.TableLayoutPanel();
            this.tlpPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flpDocentePersonal = new System.Windows.Forms.FlowLayoutPanel();
            this.lblDocente = new System.Windows.Forms.Label();
            this.lblDocenteNombre = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.lblDesdeFecha = new System.Windows.Forms.Label();
            this.flpDocenteModulos = new System.Windows.Forms.FlowLayoutPanel();
            this.lblModulo = new System.Windows.Forms.Label();
            this.tlpPanel.SuspendLayout();
            this.tlpPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flpDocentePersonal.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpPanel
            // 
            this.tlpPanel.ColumnCount = 1;
            this.tlpPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPanel.Controls.Add(this.tlpPanel5, 0, 0);
            this.tlpPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPanel.Location = new System.Drawing.Point(0, 0);
            this.tlpPanel.Name = "tlpPanel";
            this.tlpPanel.RowCount = 1;
            this.tlpPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpPanel.Size = new System.Drawing.Size(1448, 851);
            this.tlpPanel.TabIndex = 0;
            // 
            // tlpPanel5
            // 
            this.tlpPanel5.ColumnCount = 1;
            this.tlpPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpPanel5.Controls.Add(this.chart, 0, 1);
            this.tlpPanel5.Controls.Add(this.tableLayoutPanel1, 0, 3);
            this.tlpPanel5.Controls.Add(this.lblModulo, 0, 0);
            this.tlpPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpPanel5.Location = new System.Drawing.Point(3, 3);
            this.tlpPanel5.Name = "tlpPanel5";
            this.tlpPanel5.RowCount = 5;
            this.tlpPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55F));
            this.tlpPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tlpPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpPanel5.Size = new System.Drawing.Size(1442, 845);
            this.tlpPanel5.TabIndex = 0;
            // 
            // chart
            // 
            chartArea1.AxisX.Interval = 1D;
            chartArea1.AxisX.MajorGrid.Interval = 1D;
            chartArea1.AxisX.Maximum = 10D;
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX.Title = "Valor de la nota";
            chartArea1.AxisY.Interval = 5D;
            chartArea1.AxisY.MajorGrid.Interval = 5D;
            chartArea1.AxisY.Maximum = 25D;
            chartArea1.AxisY.Minimum = 0D;
            chartArea1.AxisY.Title = "Número de estudiantes";
            chartArea1.Name = "ChartArea1";
            this.chart.ChartAreas.Add(chartArea1);
            this.chart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart.Legends.Add(legend1);
            this.chart.Location = new System.Drawing.Point(3, 87);
            this.chart.Name = "chart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.SplineArea;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart.Series.Add(series1);
            this.chart.Size = new System.Drawing.Size(1436, 458);
            this.chart.TabIndex = 0;
            title1.Name = "Title1";
            title1.Text = "Distribución de notas del módulo";
            this.chart.Titles.Add(title1);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flpDocentePersonal, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.flpDocenteModulos, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 593);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1436, 163);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::GraSupInf.Properties.Resources.docente;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.tableLayoutPanel1.SetRowSpan(this.pictureBox1, 2);
            this.pictureBox1.Size = new System.Drawing.Size(294, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // flpDocentePersonal
            // 
            this.flpDocentePersonal.Controls.Add(this.lblDocente);
            this.flpDocentePersonal.Controls.Add(this.lblDocenteNombre);
            this.flpDocentePersonal.Controls.Add(this.lblDesde);
            this.flpDocentePersonal.Controls.Add(this.lblDesdeFecha);
            this.flpDocentePersonal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpDocentePersonal.Location = new System.Drawing.Point(303, 3);
            this.flpDocentePersonal.Name = "flpDocentePersonal";
            this.flpDocentePersonal.Size = new System.Drawing.Size(1413, 75);
            this.flpDocentePersonal.TabIndex = 1;
            // 
            // lblDocente
            // 
            this.lblDocente.AutoSize = true;
            this.lblDocente.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocente.Location = new System.Drawing.Point(40, 10);
            this.lblDocente.Margin = new System.Windows.Forms.Padding(40, 10, 10, 10);
            this.lblDocente.Name = "lblDocente";
            this.lblDocente.Size = new System.Drawing.Size(129, 32);
            this.lblDocente.TabIndex = 0;
            this.lblDocente.Text = "Docente:";
            this.lblDocente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDocenteNombre
            // 
            this.lblDocenteNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDocenteNombre.Location = new System.Drawing.Point(219, 10);
            this.lblDocenteNombre.Margin = new System.Windows.Forms.Padding(40, 10, 10, 10);
            this.lblDocenteNombre.Name = "lblDocenteNombre";
            this.lblDocenteNombre.Size = new System.Drawing.Size(250, 32);
            this.lblDocenteNombre.TabIndex = 1;
            this.lblDocenteNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesde.Location = new System.Drawing.Point(559, 10);
            this.lblDesde.Margin = new System.Windows.Forms.Padding(80, 10, 10, 10);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(105, 32);
            this.lblDesde.TabIndex = 2;
            this.lblDesde.Text = "Desde:";
            this.lblDesde.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblDesdeFecha
            // 
            this.lblDesdeFecha.AutoSize = true;
            this.lblDesdeFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesdeFecha.Location = new System.Drawing.Point(754, 10);
            this.lblDesdeFecha.Margin = new System.Windows.Forms.Padding(80, 10, 10, 10);
            this.lblDesdeFecha.Name = "lblDesdeFecha";
            this.lblDesdeFecha.Size = new System.Drawing.Size(0, 32);
            this.lblDesdeFecha.TabIndex = 3;
            this.lblDesdeFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flpDocenteModulos
            // 
            this.flpDocenteModulos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpDocenteModulos.Location = new System.Drawing.Point(303, 84);
            this.flpDocenteModulos.Name = "flpDocenteModulos";
            this.flpDocenteModulos.Size = new System.Drawing.Size(1413, 76);
            this.flpDocenteModulos.TabIndex = 2;
            // 
            // lblModulo
            // 
            this.lblModulo.AutoSize = true;
            this.lblModulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblModulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModulo.Location = new System.Drawing.Point(3, 0);
            this.lblModulo.Name = "lblModulo";
            this.lblModulo.Size = new System.Drawing.Size(1436, 84);
            this.lblModulo.TabIndex = 2;
            this.lblModulo.Text = "Módulo";
            this.lblModulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PanelModuloUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpPanel);
            this.Name = "PanelModuloUC";
            this.Size = new System.Drawing.Size(1448, 851);
            this.tlpPanel.ResumeLayout(false);
            this.tlpPanel5.ResumeLayout(false);
            this.tlpPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flpDocentePersonal.ResumeLayout(false);
            this.flpDocentePersonal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpPanel;
        private System.Windows.Forms.TableLayoutPanel tlpPanel5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flpDocentePersonal;
        private System.Windows.Forms.Label lblDocente;
        private System.Windows.Forms.Label lblDocenteNombre;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.Label lblDesdeFecha;
        private System.Windows.Forms.FlowLayoutPanel flpDocenteModulos;
        private System.Windows.Forms.Label lblModulo;
    }
}

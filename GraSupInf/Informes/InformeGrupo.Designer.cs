
namespace GraSupInf.Informes {
    partial class InformeGrupo {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.btnASIR1 = new System.Windows.Forms.Button();
            this.btnDAW1 = new System.Windows.Forms.Button();
            this.btnDAM1 = new System.Windows.Forms.Button();
            this.btnDAM2 = new System.Windows.Forms.Button();
            this.btnDAW2 = new System.Windows.Forms.Button();
            this.btnASIR2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 0);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1320, 990);
            this.crystalReportViewer1.TabIndex = 0;
            // 
            // btnASIR1
            // 
            this.btnASIR1.Location = new System.Drawing.Point(350, 42);
            this.btnASIR1.Name = "btnASIR1";
            this.btnASIR1.Size = new System.Drawing.Size(75, 23);
            this.btnASIR1.TabIndex = 1;
            this.btnASIR1.Text = "ASIR1";
            this.btnASIR1.UseVisualStyleBackColor = true;
            this.btnASIR1.Click += new System.EventHandler(this.btnASIR1_Click);
            // 
            // btnDAW1
            // 
            this.btnDAW1.Location = new System.Drawing.Point(603, 42);
            this.btnDAW1.Name = "btnDAW1";
            this.btnDAW1.Size = new System.Drawing.Size(75, 23);
            this.btnDAW1.TabIndex = 2;
            this.btnDAW1.Text = "DAW1";
            this.btnDAW1.UseVisualStyleBackColor = true;
            this.btnDAW1.Click += new System.EventHandler(this.btnDAW1_Click);
            // 
            // btnDAM1
            // 
            this.btnDAM1.Location = new System.Drawing.Point(480, 42);
            this.btnDAM1.Name = "btnDAM1";
            this.btnDAM1.Size = new System.Drawing.Size(75, 23);
            this.btnDAM1.TabIndex = 3;
            this.btnDAM1.Text = "DAM1";
            this.btnDAM1.UseVisualStyleBackColor = true;
            this.btnDAM1.Click += new System.EventHandler(this.btnDAM1_Click);
            // 
            // btnDAM2
            // 
            this.btnDAM2.Location = new System.Drawing.Point(959, 42);
            this.btnDAM2.Name = "btnDAM2";
            this.btnDAM2.Size = new System.Drawing.Size(75, 23);
            this.btnDAM2.TabIndex = 6;
            this.btnDAM2.Text = "DAM2";
            this.btnDAM2.UseVisualStyleBackColor = true;
            this.btnDAM2.Click += new System.EventHandler(this.btnDAM2_Click);
            // 
            // btnDAW2
            // 
            this.btnDAW2.Location = new System.Drawing.Point(1082, 42);
            this.btnDAW2.Name = "btnDAW2";
            this.btnDAW2.Size = new System.Drawing.Size(75, 23);
            this.btnDAW2.TabIndex = 5;
            this.btnDAW2.Text = "DAW2";
            this.btnDAW2.UseVisualStyleBackColor = true;
            this.btnDAW2.Click += new System.EventHandler(this.btnDAW2_Click);
            // 
            // btnASIR2
            // 
            this.btnASIR2.Location = new System.Drawing.Point(829, 42);
            this.btnASIR2.Name = "btnASIR2";
            this.btnASIR2.Size = new System.Drawing.Size(75, 23);
            this.btnASIR2.TabIndex = 4;
            this.btnASIR2.Text = "ASIR2";
            this.btnASIR2.UseVisualStyleBackColor = true;
            this.btnASIR2.Click += new System.EventHandler(this.btnASIR2_Click);
            // 
            // InformeGrupo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 990);
            this.Controls.Add(this.btnDAM2);
            this.Controls.Add(this.btnDAW2);
            this.Controls.Add(this.btnASIR2);
            this.Controls.Add(this.btnDAM1);
            this.Controls.Add(this.btnDAW1);
            this.Controls.Add(this.btnASIR1);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "InformeGrupo";
            this.Text = "InformeGrupo";
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        public CRGrupoASIR1 CRASIR1;
        public CRGrupoDAW1 CRDAW1;
        public CRGrupoDAM1 CRDAM1;
        private System.Windows.Forms.Button btnASIR1;
        private System.Windows.Forms.Button btnDAW1;
        private System.Windows.Forms.Button btnDAM1;
        private System.Windows.Forms.Button btnDAM2;
        private System.Windows.Forms.Button btnDAW2;
        private System.Windows.Forms.Button btnASIR2;
    }
}
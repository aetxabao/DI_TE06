
namespace GraSupInf.Controles_Usuario {
    partial class GrupoUC {
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
            this.lblGrupo = new System.Windows.Forms.Label();
            this.tLPGrupo = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.tLPGrupo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblGrupo
            // 
            this.lblGrupo.AutoSize = true;
            this.lblGrupo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrupo.Location = new System.Drawing.Point(3, 0);
            this.lblGrupo.Name = "lblGrupo";
            this.lblGrupo.Size = new System.Drawing.Size(818, 101);
            this.lblGrupo.TabIndex = 1;
            this.lblGrupo.Text = "GRUPO";
            this.lblGrupo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tLPGrupo
            // 
            this.tLPGrupo.AutoSize = true;
            this.tLPGrupo.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tLPGrupo.ColumnCount = 1;
            this.tLPGrupo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tLPGrupo.Controls.Add(this.lblGrupo, 0, 0);
            this.tLPGrupo.Controls.Add(this.pictureBox, 0, 1);
            this.tLPGrupo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tLPGrupo.Location = new System.Drawing.Point(0, 0);
            this.tLPGrupo.Name = "tLPGrupo";
            this.tLPGrupo.RowCount = 2;
            this.tLPGrupo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tLPGrupo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85F));
            this.tLPGrupo.Size = new System.Drawing.Size(824, 674);
            this.tLPGrupo.TabIndex = 2;
            // 
            // pictureBox
            // 
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Image = global::GraSupInf.Properties.Resources.cargando;
            this.pictureBox.Location = new System.Drawing.Point(3, 104);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(818, 567);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            // 
            // GrupoUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tLPGrupo);
            this.Name = "GrupoUC";
            this.Size = new System.Drawing.Size(824, 674);
            this.tLPGrupo.ResumeLayout(false);
            this.tLPGrupo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblGrupo;
        private System.Windows.Forms.TableLayoutPanel tLPGrupo;
        private System.Windows.Forms.PictureBox pictureBox;
    }
}

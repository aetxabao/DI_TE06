using System;
using System.Windows.Forms;

namespace GraSupInf.Informes {
    public partial class InformeGrupo : Form {
        public InformeGrupo() {
            InitializeComponent();
        }

        private void btnASIR1_Click(object sender, EventArgs e) {
            this.CRASIR1 = new GraSupInf.Informes.CRGrupoASIR1();
            this.crystalReportViewer1.ReportSource = this.CRASIR1;
        }

        private void btnDAM1_Click(object sender, EventArgs e) {
            this.CRDAM1 = new GraSupInf.Informes.CRGrupoDAM1();
            this.crystalReportViewer1.ReportSource = this.CRDAM1;
        }

        private void btnDAW1_Click(object sender, EventArgs e) {
            this.CRDAW1 = new GraSupInf.Informes.CRGrupoDAW1();
            this.crystalReportViewer1.ReportSource = this.CRDAW1;
        }

        private void btnASIR2_Click(object sender, EventArgs e) {
            MessageBox.Show("En breve se creará un informe similar a los de primero.", "Informe pendiente de realizar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnDAM2_Click(object sender, EventArgs e) {
            MessageBox.Show("En breve se creará un informe similar a los de primero.", "Informe pendiente de realizar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnDAW2_Click(object sender, EventArgs e) {
            MessageBox.Show("En breve se creará un informe similar a los de primero.", "Informe pendiente de realizar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}

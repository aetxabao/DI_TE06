using System;
using System.Windows.Forms;

namespace GraSupInf.Controles_Usuario {
    public partial class PanelPresentacionUC : UserControl {

        private Form1 form1;

        public PanelPresentacionUC() {
            InitializeComponent();
        }

        public PanelPresentacionUC(Form1 form1) {
            InitializeComponent();
            this.form1 = form1;
        }

        private void pictureBoxCentro_Click(object sender, EventArgs e) {
            form1.btnCentro_Click(sender, e);
        }

        private void pictureBoxGrupo_Click(object sender, EventArgs e) {
            form1.btnGrupo_Click(sender, e);
        }

        private void pictureBoxModulo_Click(object sender, EventArgs e) {
            form1.btnModulo_Click(sender, e);
        }
    }
}

using System;
using System.Windows.Forms;
using GraSupInf.Informes;

namespace GraSupInf.Controles_Usuario {
    public partial class PanelInformesUC : UserControl {
        public PanelInformesUC() {
            InitializeComponent();
        }

        private void pictureBoxEstudiante_Click(object sender, EventArgs e) {
            InformeNotasEstudiante informe = new InformeNotasEstudiante();
            informe.Show();
        }

        private void pictureBoxFiltro_Click(object sender, EventArgs e) {
            InformeFiltroEstudiantes informe = new InformeFiltroEstudiantes();
            informe.Show();
        }

        private void pictureBoxGrupo_Click(object sender, EventArgs e) {
            InformeGrupo informe = new InformeGrupo();
            informe.Show();
        }

        private void pictureBoxDistribuGrupo_Click(object sender, EventArgs e) {
            DistribucionNotasGrupo informe = new DistribucionNotasGrupo();
            informe.Show();
        }

        private void pictureBoxDistribuDocente_Click(object sender, EventArgs e) {
            DistribucionNotas informe = new DistribucionNotas();
            informe.Show();
        }

        private void pictureBoxDistribuModulo_Click(object sender, EventArgs e) {
            DistribucionNotasModulo informe = new DistribucionNotasModulo();
            informe.Show();
        }
    }
}

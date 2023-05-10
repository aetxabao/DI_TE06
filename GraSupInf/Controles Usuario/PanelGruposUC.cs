using System.Windows.Forms;

namespace GraSupInf.Controles_Usuario {
    public partial class PanelGruposUC : UserControl {

        GrupoUC[] grupoUCs = new GrupoUC[6];

        public PanelGruposUC() {
            InitializeComponent();
            grupoUCs[0] = grupoUC0;
            grupoUCs[1] = grupoUC1;
            grupoUCs[2] = grupoUC2;
            grupoUCs[3] = grupoUC3;
            grupoUCs[4] = grupoUC4;
            grupoUCs[5] = grupoUC5;
        }

        public void PonerNombres(string[] nombres) {
            for(int i = 0; i < 6; i++) {
                grupoUCs[i].PonerNombre(nombres[i]);
            }
        }

        public void LoadingData(int indice) {
            grupoUCs[indice].LoadingData();
        }

        public void DisplayData(int indice, int[] valores) {
            grupoUCs[indice].DisplayData(valores);
        }

    }
}

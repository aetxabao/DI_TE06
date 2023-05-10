using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace GraSupInf.Controles_Usuario {
    public partial class GrupoUC : UserControl {

        private Chart chart;

        public GrupoUC() {
            InitializeComponent();
            MyInit("GRUPO");
        }

        public GrupoUC(string grupo) {
            InitializeComponent();
            MyInit(grupo);
        }

        private void MyInit(string grupo) {
            PonerNombre(grupo);
            chart = new Chart();
            chart.ChartAreas.Add(new ChartArea());
            chart.Dock = DockStyle.Fill;
            chart.Series.Add(new Series());
            chart.Series[0].ChartType = SeriesChartType.Doughnut;
            chart.Series[0].Font = new Font(lblGrupo.Font.Name, lblGrupo.Font.Size - 4.0F,
                                            lblGrupo.Font.Style, lblGrupo.Font.Unit);
            chart.Series[0]["PieStartAngle"] = "270";
            tLPGrupo.Controls.Add(chart, 0, 1);
            chart.SendToBack();
        }

        public void PonerNombre(string grupo) {
            lblGrupo.Text = grupo;
        }

        private void ResetData() {
            chart.Series[0].Points.Clear();
        }

        public void LoadingData() {
            ResetData();
            chart.Visible = false;
            pictureBox.Visible = true;
        }

        public void DisplayData(int[] valores) {
            int[] rangos = Rangos(valores);
            int sum = rangos.Sum();
            int j = 0;
            Color[] ChartColors = new Color[] { Color.Green, Color.Yellow, Color.Orange, Color.Red };
            for(int i = 0; i < rangos.Length; i++) {
                int value = rangos[i];
                if(value != 0) {
                    int perc = value * 100 / sum;
                    chart.Series[0].Points.AddXY(perc +" %", value);
                    chart.Series[0].Points[j].Color = ChartColors[i];
                    j++;
                }
            }
            pictureBox.Visible = false;
            chart.Visible = true;
        }

        private int[] Rangos(int[] values) {
            int[] rangos = new int[4];
            rangos[0] = values[0];
            rangos[1] = values[1] + values[2];
            rangos[2] = values[3] + values[4];
            for(int i=5; i<values.Length; i++) {
                rangos[3] += values[i];
            }
            return rangos;
        }

    }
}

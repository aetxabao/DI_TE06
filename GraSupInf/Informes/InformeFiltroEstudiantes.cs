using System;
using System.Data;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using GsiGestor;

namespace GraSupInf.Informes {
    public partial class InformeFiltroEstudiantes : Form {
        public InformeFiltroEstudiantes() {
            InitializeComponent();
        }

        private void btnFiltrar_Click(object sender, EventArgs e) {
            int suspensos = 0;
            int horas = 0;
            if(!Int32.TryParse(txtSuspensos.Text, out suspensos)) {
                MessageBox.Show("Introduce un valor numérico para los suspensos.", "Error Número Suspensos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(suspensos < 0 || suspensos > 10) {
                MessageBox.Show("Los suspensos deben estar entre 0 y 10.", "Error Número Suspensos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(!Int32.TryParse(txtHoras.Text, out horas)) {
                MessageBox.Show("Introduce un valor numérico para las horas.", "Error Número Horas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if(horas < 0 || horas > 2000) {
                MessageBox.Show("Las horas deben estar entre 0 y 2000.", "Error Número Horas", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            DataTable table = Gestor.GetEstudiantesSuspensosHoras(suspensos, horas);
            ReportDocument rdc = new ReportDocument();
            //string path = @"C:\Users\kemena\source\repos\GraSupInf\GraSupInf\Informes\CREstudiantesSuspensosHoras.rpt";//Path absoluto informes
            //string path = Application.StartupPath + "\\Informes\\CREstudiantesSuspensosHoras.rpt";//Crear carpeta con informes donde el ejecutable
            //string path = Application.StartupPath + "\\Informes\\CREstudiantesSuspensosHoras.rpt";//Problema: coge el directorio de bin o debug
            string path = Application.StartupPath + "\\Informes\\CRFiltroSuspensosHoras.rpt";//Problema: coge el directorio de bin o debug
            int p = path.LastIndexOf("GraSupInf");
            if (p != -1) {
                int t = "GraSupInf".Length;
                path = path.Substring(0, p + t);
                //path = path + "\\Informes\\CREstudiantesSuspensosHoras.rpt";
                path = path + "\\Informes\\CRFiltroSuspensosHoras.rpt";
            }
            rdc.Load(path);
            rdc.SetDataSource(table);
            crystalReportViewer1.ReportSource = rdc;
        }
    }
}

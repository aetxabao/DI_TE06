
using System;
using System.Windows.Forms;
using GsiGestor;
using Microsoft.Reporting.WinForms;

namespace GraSupInf.Informes {
    public partial class DistribucionNotasGrupo : Form {
        public DistribucionNotasGrupo() {
            InitializeComponent();
        }

        private void DistribucionNotasGrupo_Load(object sender, EventArgs e) {
        }

        private void btnMostrar_Click(object sender, EventArgs e) {

            string grupo = cmbGrupo.Text;
            if(grupo.Length < 1) {
                MessageBox.Show("Selecciona un grupo.", "Error Falta Grupo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string curso = grupo.Substring(grupo.Length - 1);
            string ciclo = grupo.Substring(0, grupo.Length - 1);

            var reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", Gestor.GetDistribucioNotasCicloCurso(ciclo, int.Parse(curso)));
            this.reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);

            this.reportViewer1.LocalReport.EnableExternalImages = true;
            ReportParameter pCiclo = new ReportParameter("pCiclo", ciclo);
            ReportParameter pCurso = new ReportParameter("pCurso", curso);
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter[] { pCiclo, pCurso });

            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GraSupInf.Informes.Report1.rdlc";

            //this.reportViewer1.LocalReport.Refresh();
            this.reportViewer1.RefreshReport();
        }
    }
}

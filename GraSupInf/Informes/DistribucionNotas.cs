using System;
using System.Windows.Forms;
using GsiGestor;
using Microsoft.Reporting.WinForms;

namespace GraSupInf.Informes {
    public partial class DistribucionNotas : Form {
        public DistribucionNotas() {
            InitializeComponent();
        }

        private void DistribucionNotas_Load(object sender, EventArgs e) {
            var reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", Gestor.GetDistribucioNotas());
            this.reportViewer1.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);

            this.reportViewer1.LocalReport.EnableExternalImages = true;

            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GraSupInf.Informes.Report2.rdlc";

            this.reportViewer1.RefreshReport();
        }
    }
}

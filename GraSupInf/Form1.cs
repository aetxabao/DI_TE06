using GraSupInf.Controles_Usuario;
using GraSupInf.Informes;
using GsiGestor;
using System;
using System.ComponentModel;
using System.Threading;
using System.Windows.Forms;

namespace GraSupInf {
    public partial class Form1 : Form {

        private PanelGruposUC panelGruposUC;
        private PanelEstudiantesUC panelEstudiantesUC;
        private PanelModuloUC panelModuloUC;
        private PanelPresentacionUC panelPresentacionUC;
        private PanelInformesUC panelInformesUC;

        private Label lblTitulo;

        #region Constructor e inicialización
        public Form1() {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;

            lblTitulo = new Label();
            InitTitulo();

            panelGruposUC = new PanelGruposUC();
            InitPanel(panelGruposUC);
            panelGruposUC.PonerNombres(Gestor.NombresGrupos);

            panelEstudiantesUC = new PanelEstudiantesUC();
            InitPanel(panelEstudiantesUC);

            panelModuloUC = new PanelModuloUC();
            panelModuloUC.LinkForm(this);
            InitPanel(panelModuloUC);


            panelInformesUC = new PanelInformesUC();
            InitPanel(panelInformesUC);

            panelPresentacionUC = new PanelPresentacionUC(this);
            InitPanel(panelPresentacionUC);
            panelPresentacionUC.Visible = true;

            this.ttMensaje.SetToolTip(this.btnCentro, "Visión de suspensos de los grupos");
            this.ttMensaje.SetToolTip(this.btnGrupo, "Notas de los estudiantes de un grupo");
            this.ttMensaje.SetToolTip(this.btnModulo, "Distribución de notas de un módulo");
            this.ttMensaje.SetToolTip(this.btnInformes, "Informes imprimibles");
            this.ttMensaje.SetToolTip(this.btnFiltrar, "Mostrar resultados según filtros");

            this.ttMensaje.SetToolTip(this.cmbCiclo, "Selecciona el ciclo");
            this.ttMensaje.SetToolTip(this.cmbCurso, "Selecciona el curso");
            this.ttMensaje.SetToolTip(this.cmbModulo, "Selecciona el módulo");

            InitDataLoad();
        }

        private void InitTitulo() {
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = System.Drawing.Color.White;
            lblTitulo.Dock = DockStyle.Fill;
            lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblTitulo.Text = "Grados Superiores de Informática Coop.";
            lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            tlpDashboard.Controls.Add(lblTitulo, 1, 0);
            MostrarTituloFiltroCompleto(0);
        }

        private void InitPanel(UserControl panelUC) {
            panelUC.Dock = DockStyle.Fill;
            panelUC.Visible = false;
            tlpDashboard.Controls.Add(panelUC, 1, 1);
        }

        private void InitDataLoad() {
            if(!Gestor.TestDB()) {
                MessageBox.Show("No hay conexión con la base de datos.", "Error BD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else {
                cmbCiclo.DataSource = Gestor.GetCiclos();
                cmbCurso.DataSource = Gestor.GetCursos();
            }
        }

        #endregion

        #region Cambio de propiedades de controles
        private void ResaltarBoton(Button btn) {
            Button[] buttons = { btnCentro, btnGrupo, btnModulo, btnInformes };
            for(int i = 0; i < buttons.Length; i++) {
                if(btn == buttons[i]) {
                    PonerBotonEstado(buttons[i], true);
                } else {
                    PonerBotonEstado(buttons[i], false);
                }
            }
        }

        private void PonerBotonEstado(Button btn, bool active) {
            if(active) {
                btn.BackColor = System.Drawing.Color.WhiteSmoke;
            } else {
                btn.BackColor = System.Drawing.Color.White;
            }
        }

        private void OcultarPaneles() {
            UserControl[] panels = { panelGruposUC, panelEstudiantesUC, panelModuloUC, panelPresentacionUC };
            for(int i = 0; i < panels.Length; i++) {
                panels[i].Visible = false;
            }
        }

        private void MostrarTituloFiltroCompleto(int i) {
            if(i == 0) {
                lblTitulo.Visible = true;
                tlpFiltro.Visible = false;
            }else if(i == 1) {
                lblTitulo.Visible = false;
                tlpFiltro.Visible = true;
                tlpModulo.Visible = false;
                tlpFiltro.Controls.Remove(btnFiltrar);
                tlpFiltro.Controls.Add(btnFiltrar, 2, 0);
            } else if(i == 2) {
                lblTitulo.Visible = false;
                tlpFiltro.Controls.Remove(btnFiltrar);
                tlpFiltro.Controls.Add(btnFiltrar, 3, 0);
                tlpFiltro.Visible = true;
                tlpModulo.Visible = true;
            }
        }
        #endregion

        #region Eventos del menú
        private void manualDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e) {
            //Crear carpeta Help con ayuda donde el ejecutable. Problema: coge el directorio de bin o debug
            string path = Application.StartupPath + "\\Help\\Ayuda.chm";
            int p = path.LastIndexOf("GraSupInf");
            if(p != -1) {
                int t = "GraSupInf".Length;
                path = path.Substring(0, p + t);
                path = path + "\\Help\\Ayuda.chm";
            }
            Help.ShowHelp(this, "file://" + path);
        }

        private void centroToolStripMenuItem_Click(object sender, EventArgs e) {
            btnCentro_Click(this, e);
        }

        private void grupoToolStripMenuItem_Click(object sender, EventArgs e) {
            btnGrupo_Click(this, e);
        }

        private void móduloToolStripMenuItem_Click(object sender, EventArgs e) {
            btnModulo_Click(this, e);
        }

        private void estudianteToolStripMenuItem_Click(object sender, EventArgs e) {
            InformeNotasEstudiante informe = new InformeNotasEstudiante();
            informe.Show();
        }

        private void pasanToolStripMenuItem_Click(object sender, EventArgs e) {
            InformeFiltroEstudiantes informe = new InformeFiltroEstudiantes();
            informe.Show();
        }

        private void evaluaciónToolStripMenuItem_Click(object sender, EventArgs e) {
            InformeGrupo informe = new InformeGrupo();
            informe.Show();
        }

        private void dGrupoToolStripMenuItem_Click(object sender, EventArgs e) {
            DistribucionNotasGrupo informe = new DistribucionNotasGrupo();
            informe.Show();
        }

        private void resultadosToolStripMenuItem_Click(object sender, EventArgs e) {
            DistribucionNotas informe = new DistribucionNotas();
            informe.Show();
        }

        private void comparadorToolStripMenuItem_Click(object sender, EventArgs e) {
            DistribucionNotasModulo informe = new DistribucionNotasModulo();
            informe.Show();
        }
        #endregion

        #region Eventos de logo, botones y combos
        public void btnCentro_Click(object sender, System.EventArgs e) {
            if(backgroundWorker1.IsBusy != true) {
                MostrarTituloFiltroCompleto(0);
                OcultarPaneles();
                panelGruposUC.Visible = true;
                ResaltarBoton(btnCentro);

                backgroundWorker1.RunWorkerAsync();
            }
        }

        public void btnGrupo_Click(object sender, EventArgs e) {
            MostrarTituloFiltroCompleto(1);
            OcultarPaneles();
            panelEstudiantesUC.Visible = true;
            ResaltarBoton(btnGrupo);
        }

        public void btnModulo_Click(object sender, EventArgs e) {
            MostrarTituloFiltroCompleto(2);
            OcultarPaneles();
            panelModuloUC.Visible = true;
            ResaltarBoton(btnModulo);
            CargarModulosCombo();
        }

        private void btnInformes_Click(object sender, EventArgs e) {
            MostrarTituloFiltroCompleto(0);
            OcultarPaneles();
            panelInformesUC.Visible = true;
            ResaltarBoton(btnInformes);
        }

        private void pictureBoxLogo_Click(object sender, EventArgs e) {
            MostrarTituloFiltroCompleto(0);
            OcultarPaneles();
            panelPresentacionUC.Visible = true;
            ResaltarBoton(null);
        }

        private void btnFiltrar_Click(object sender, EventArgs e) {
            if(backgroundWorker2.IsBusy != true) {
                if(panelEstudiantesUC.Visible) {
                    panelEstudiantesUC.LoadingData();
                    Gestor.Grupo = (string)cmbCiclo.SelectedItem + cmbCurso.SelectedItem.ToString();
                    backgroundWorker2.RunWorkerAsync();
                }
                else if(panelModuloUC.Visible) {
                    panelModuloUC.StartLoadingData();
                    Gestor.Ciclo = (string)cmbCiclo.SelectedItem;
                    Gestor.Curso = (int)cmbCurso.SelectedItem;
                    Gestor.SiglasModulo = (string)cmbModulo.SelectedItem;
                    backgroundWorker2.RunWorkerAsync();
                }
            }
        }

        private void cmbCurso_SelectionChangeCommitted(object sender, EventArgs e) {
            CargarModulosCombo();
        }

        private void cmbCiclo_SelectionChangeCommitted(object sender, EventArgs e) {
            CargarModulosCombo();
        }

        public void CargarModulosCombo() {
            Gestor.Ciclo = (string)cmbCiclo.SelectedItem;
            Gestor.Curso = (int)cmbCurso.SelectedItem;
            cmbModulo.DataSource = Gestor.GetModulos();
        }

        #endregion

        #region Background Workers
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e) {
            Random rnd = new Random();
            BackgroundWorker worker = sender as BackgroundWorker;
            for (int i = 0; i < Gestor.NumeroGrupos; i++) {
                if(worker.CancellationPending == true) {
                    e.Cancel = true;
                    break;
                } else {
                    worker.ReportProgress(i * 10);
                    Thread.Sleep(rnd.Next(500, 1000));//Para simular un acceso más lento a BD
                    Gestor.GetSuspensosGrupo(i);
                    worker.ReportProgress(i * 10 + 1);
                }
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e) {
            int i = e.ProgressPercentage / 10;
            int a = e.ProgressPercentage % 10;
            if ( a==0 ) {
                panelGruposUC.LoadingData(i);
            } else {
                panelGruposUC.DisplayData(i, Gestor.SuspensosGrupos[i]);
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e) {
            if(panelEstudiantesUC.Visible) {
                Random rnd = new Random();
                Thread.Sleep(rnd.Next(600, 1600));//Para simular un acceso más lento a BD
                Gestor.GetNotasGrupo();
            } else if(panelModuloUC.Visible) {
                Random rnd = new Random();
                Thread.Sleep(rnd.Next(600, 1600));//Para simular un acceso más lento a BD
                Gestor.GetInfoModulo();
            }
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            if(panelEstudiantesUC.Visible) {
                panelEstudiantesUC.SetData(Gestor.NotasGrupo, Gestor.NombresModulos);
                panelEstudiantesUC.DisplayAverageGraph(Gestor.NombresModulos, Gestor.MediasModulos);
            } else if(panelModuloUC.Visible) {
                panelModuloUC.SetDistribucionNotas(Gestor.DistribucionNotasModulo);
                panelModuloUC.SetDatosDocente(Gestor.Docente);
                panelModuloUC.SetTitle(Gestor.Modulo.Nombre + " (" + Gestor.Modulo.Grupo + ")");
                panelModuloUC.FinishLoadingData();
            }
        }
        #endregion


    }
}


namespace GraSupInf {
    partial class Form1 {
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.tlpDashboard = new System.Windows.Forms.TableLayoutPanel();
            this.tlpBotones = new System.Windows.Forms.TableLayoutPanel();
            this.btnInformes = new System.Windows.Forms.Button();
            this.btnModulo = new System.Windows.Forms.Button();
            this.btnGrupo = new System.Windows.Forms.Button();
            this.btnCentro = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.tlpFiltro = new System.Windows.Forms.TableLayoutPanel();
            this.tlpModulo = new System.Windows.Forms.TableLayoutPanel();
            this.lblModulo = new System.Windows.Forms.Label();
            this.cmbModulo = new System.Windows.Forms.ComboBox();
            this.tlpCurso = new System.Windows.Forms.TableLayoutPanel();
            this.lblCurso = new System.Windows.Forms.Label();
            this.cmbCurso = new System.Windows.Forms.ComboBox();
            this.tlpCiclo = new System.Windows.Forms.TableLayoutPanel();
            this.lblCiclo = new System.Windows.Forms.Label();
            this.cmbCiclo = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.centroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grupoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.móduloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estudianteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evaluaciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dGrupoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comparadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlpDashboard.SuspendLayout();
            this.tlpBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.tlpFiltro.SuspendLayout();
            this.tlpModulo.SuspendLayout();
            this.tlpCurso.SuspendLayout();
            this.tlpCiclo.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlpDashboard
            // 
            this.tlpDashboard.BackColor = System.Drawing.Color.White;
            this.tlpDashboard.ColumnCount = 2;
            this.tlpDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlpDashboard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tlpDashboard.Controls.Add(this.tlpBotones, 0, 1);
            this.tlpDashboard.Controls.Add(this.pictureBoxLogo, 0, 0);
            this.tlpDashboard.Controls.Add(this.tlpFiltro, 1, 0);
            this.tlpDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpDashboard.Location = new System.Drawing.Point(0, 28);
            this.tlpDashboard.Name = "tlpDashboard";
            this.tlpDashboard.RowCount = 2;
            this.tlpDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tlpDashboard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tlpDashboard.Size = new System.Drawing.Size(1455, 735);
            this.tlpDashboard.TabIndex = 0;
            // 
            // tlpBotones
            // 
            this.tlpBotones.ColumnCount = 1;
            this.tlpBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpBotones.Controls.Add(this.btnInformes, 0, 3);
            this.tlpBotones.Controls.Add(this.btnModulo, 0, 2);
            this.tlpBotones.Controls.Add(this.btnGrupo, 0, 1);
            this.tlpBotones.Controls.Add(this.btnCentro, 0, 0);
            this.tlpBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpBotones.Location = new System.Drawing.Point(3, 76);
            this.tlpBotones.Name = "tlpBotones";
            this.tlpBotones.RowCount = 5;
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tlpBotones.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tlpBotones.Size = new System.Drawing.Size(285, 656);
            this.tlpBotones.TabIndex = 3;
            // 
            // btnInformes
            // 
            this.btnInformes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInformes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnInformes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInformes.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInformes.Image = global::GraSupInf.Properties.Resources.report;
            this.btnInformes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInformes.Location = new System.Drawing.Point(10, 550);
            this.btnInformes.Margin = new System.Windows.Forms.Padding(10);
            this.btnInformes.Name = "btnInformes";
            this.btnInformes.Size = new System.Drawing.Size(265, 160);
            this.btnInformes.TabIndex = 3;
            this.btnInformes.Text = "             Informes";
            this.btnInformes.UseVisualStyleBackColor = true;
            this.btnInformes.Click += new System.EventHandler(this.btnInformes_Click);
            // 
            // btnModulo
            // 
            this.btnModulo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnModulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModulo.Image = global::GraSupInf.Properties.Resources.modulo;
            this.btnModulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModulo.Location = new System.Drawing.Point(10, 370);
            this.btnModulo.Margin = new System.Windows.Forms.Padding(10);
            this.btnModulo.Name = "btnModulo";
            this.btnModulo.Size = new System.Drawing.Size(265, 160);
            this.btnModulo.TabIndex = 2;
            this.btnModulo.Text = "           Módulo";
            this.btnModulo.UseVisualStyleBackColor = true;
            this.btnModulo.Click += new System.EventHandler(this.btnModulo_Click);
            // 
            // btnGrupo
            // 
            this.btnGrupo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrupo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrupo.Image = global::GraSupInf.Properties.Resources.grupo;
            this.btnGrupo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGrupo.Location = new System.Drawing.Point(10, 190);
            this.btnGrupo.Margin = new System.Windows.Forms.Padding(10);
            this.btnGrupo.Name = "btnGrupo";
            this.btnGrupo.Size = new System.Drawing.Size(265, 160);
            this.btnGrupo.TabIndex = 1;
            this.btnGrupo.Text = "           Grupo";
            this.btnGrupo.UseVisualStyleBackColor = true;
            this.btnGrupo.Click += new System.EventHandler(this.btnGrupo_Click);
            // 
            // btnCentro
            // 
            this.btnCentro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCentro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCentro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCentro.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCentro.Image = global::GraSupInf.Properties.Resources.centro;
            this.btnCentro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCentro.Location = new System.Drawing.Point(10, 10);
            this.btnCentro.Margin = new System.Windows.Forms.Padding(10);
            this.btnCentro.Name = "btnCentro";
            this.btnCentro.Size = new System.Drawing.Size(265, 160);
            this.btnCentro.TabIndex = 0;
            this.btnCentro.Text = "           Centro";
            this.btnCentro.UseVisualStyleBackColor = true;
            this.btnCentro.Click += new System.EventHandler(this.btnCentro_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.helpProvider1.SetHelpString(this.pictureBoxLogo, "Clícame para acceder a la pantalla principal");
            this.pictureBoxLogo.Image = global::GraSupInf.Properties.Resources.logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(3, 3);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.helpProvider1.SetShowHelp(this.pictureBoxLogo, true);
            this.pictureBoxLogo.Size = new System.Drawing.Size(285, 67);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 4;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Click += new System.EventHandler(this.pictureBoxLogo_Click);
            // 
            // tlpFiltro
            // 
            this.tlpFiltro.ColumnCount = 4;
            this.tlpFiltro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpFiltro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpFiltro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpFiltro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlpFiltro.Controls.Add(this.tlpModulo, 2, 0);
            this.tlpFiltro.Controls.Add(this.tlpCurso, 1, 0);
            this.tlpFiltro.Controls.Add(this.tlpCiclo, 0, 0);
            this.tlpFiltro.Controls.Add(this.btnFiltrar, 3, 0);
            this.tlpFiltro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpFiltro.Location = new System.Drawing.Point(294, 3);
            this.tlpFiltro.Name = "tlpFiltro";
            this.tlpFiltro.RowCount = 1;
            this.tlpFiltro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpFiltro.Size = new System.Drawing.Size(1158, 67);
            this.tlpFiltro.TabIndex = 5;
            // 
            // tlpModulo
            // 
            this.tlpModulo.ColumnCount = 2;
            this.tlpModulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpModulo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpModulo.Controls.Add(this.lblModulo, 0, 0);
            this.tlpModulo.Controls.Add(this.cmbModulo, 1, 0);
            this.tlpModulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpModulo.Location = new System.Drawing.Point(581, 3);
            this.tlpModulo.Name = "tlpModulo";
            this.tlpModulo.RowCount = 1;
            this.tlpModulo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpModulo.Size = new System.Drawing.Size(283, 61);
            this.tlpModulo.TabIndex = 2;
            // 
            // lblModulo
            // 
            this.lblModulo.AutoSize = true;
            this.lblModulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblModulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModulo.Location = new System.Drawing.Point(3, 0);
            this.lblModulo.Name = "lblModulo";
            this.lblModulo.Size = new System.Drawing.Size(135, 61);
            this.lblModulo.TabIndex = 0;
            this.lblModulo.Text = "Módulo";
            this.lblModulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbModulo
            // 
            this.cmbModulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbModulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbModulo.FormattingEnabled = true;
            this.cmbModulo.Location = new System.Drawing.Point(144, 10);
            this.cmbModulo.Name = "cmbModulo";
            this.cmbModulo.Size = new System.Drawing.Size(136, 39);
            this.cmbModulo.TabIndex = 1;
            // 
            // tlpCurso
            // 
            this.tlpCurso.ColumnCount = 2;
            this.tlpCurso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCurso.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCurso.Controls.Add(this.lblCurso, 0, 0);
            this.tlpCurso.Controls.Add(this.cmbCurso, 1, 0);
            this.tlpCurso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCurso.Location = new System.Drawing.Point(292, 3);
            this.tlpCurso.Name = "tlpCurso";
            this.tlpCurso.RowCount = 1;
            this.tlpCurso.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCurso.Size = new System.Drawing.Size(283, 61);
            this.tlpCurso.TabIndex = 1;
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.Location = new System.Drawing.Point(3, 0);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(135, 61);
            this.lblCurso.TabIndex = 0;
            this.lblCurso.Text = "Curso";
            this.lblCurso.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbCurso
            // 
            this.cmbCurso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCurso.FormattingEnabled = true;
            this.cmbCurso.Location = new System.Drawing.Point(144, 10);
            this.cmbCurso.Name = "cmbCurso";
            this.cmbCurso.Size = new System.Drawing.Size(136, 39);
            this.cmbCurso.TabIndex = 1;
            this.cmbCurso.SelectionChangeCommitted += new System.EventHandler(this.cmbCurso_SelectionChangeCommitted);
            // 
            // tlpCiclo
            // 
            this.tlpCiclo.ColumnCount = 2;
            this.tlpCiclo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCiclo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCiclo.Controls.Add(this.lblCiclo, 0, 0);
            this.tlpCiclo.Controls.Add(this.cmbCiclo, 1, 0);
            this.tlpCiclo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpCiclo.Location = new System.Drawing.Point(3, 3);
            this.tlpCiclo.Name = "tlpCiclo";
            this.tlpCiclo.RowCount = 1;
            this.tlpCiclo.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpCiclo.Size = new System.Drawing.Size(283, 61);
            this.tlpCiclo.TabIndex = 0;
            // 
            // lblCiclo
            // 
            this.lblCiclo.AutoSize = true;
            this.lblCiclo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCiclo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiclo.Location = new System.Drawing.Point(3, 0);
            this.lblCiclo.Name = "lblCiclo";
            this.lblCiclo.Size = new System.Drawing.Size(135, 61);
            this.lblCiclo.TabIndex = 0;
            this.lblCiclo.Text = "Ciclo";
            this.lblCiclo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbCiclo
            // 
            this.cmbCiclo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbCiclo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCiclo.FormattingEnabled = true;
            this.cmbCiclo.Location = new System.Drawing.Point(144, 10);
            this.cmbCiclo.Name = "cmbCiclo";
            this.cmbCiclo.Size = new System.Drawing.Size(136, 39);
            this.cmbCiclo.TabIndex = 1;
            this.cmbCiclo.SelectionChangeCommitted += new System.EventHandler(this.cmbCiclo_SelectionChangeCommitted);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFiltrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Image = global::GraSupInf.Properties.Resources.filter1;
            this.btnFiltrar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnFiltrar.Location = new System.Drawing.Point(907, 8);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(210, 50);
            this.btnFiltrar.TabIndex = 3;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.WorkerSupportsCancellation = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            // 
            // backgroundWorker2
            // 
            this.backgroundWorker2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorker2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayudaToolStripMenuItem,
            this.dashboardToolStripMenuItem,
            this.informesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1455, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualDeUsuarioToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // manualDeUsuarioToolStripMenuItem
            // 
            this.manualDeUsuarioToolStripMenuItem.Name = "manualDeUsuarioToolStripMenuItem";
            this.manualDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.manualDeUsuarioToolStripMenuItem.Text = "Manual de usuario";
            this.manualDeUsuarioToolStripMenuItem.Click += new System.EventHandler(this.manualDeUsuarioToolStripMenuItem_Click);
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.centroToolStripMenuItem,
            this.grupoToolStripMenuItem,
            this.móduloToolStripMenuItem});
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.estudianteToolStripMenuItem,
            this.pasanToolStripMenuItem,
            this.evaluaciónToolStripMenuItem,
            this.dGrupoToolStripMenuItem,
            this.resultadosToolStripMenuItem,
            this.comparadorToolStripMenuItem});
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.informesToolStripMenuItem.Text = "Informes";
            // 
            // centroToolStripMenuItem
            // 
            this.centroToolStripMenuItem.Name = "centroToolStripMenuItem";
            this.centroToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.centroToolStripMenuItem.Text = "Centro";
            this.centroToolStripMenuItem.Click += new System.EventHandler(this.centroToolStripMenuItem_Click);
            // 
            // grupoToolStripMenuItem
            // 
            this.grupoToolStripMenuItem.Name = "grupoToolStripMenuItem";
            this.grupoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.grupoToolStripMenuItem.Text = "Grupo";
            this.grupoToolStripMenuItem.Click += new System.EventHandler(this.grupoToolStripMenuItem_Click);
            // 
            // móduloToolStripMenuItem
            // 
            this.móduloToolStripMenuItem.Name = "móduloToolStripMenuItem";
            this.móduloToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.móduloToolStripMenuItem.Text = "Módulo";
            this.móduloToolStripMenuItem.Click += new System.EventHandler(this.móduloToolStripMenuItem_Click);
            // 
            // estudianteToolStripMenuItem
            // 
            this.estudianteToolStripMenuItem.Name = "estudianteToolStripMenuItem";
            this.estudianteToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.estudianteToolStripMenuItem.Text = "Estudiante";
            this.estudianteToolStripMenuItem.Click += new System.EventHandler(this.estudianteToolStripMenuItem_Click);
            // 
            // pasanToolStripMenuItem
            // 
            this.pasanToolStripMenuItem.Name = "pasanToolStripMenuItem";
            this.pasanToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pasanToolStripMenuItem.Text = "Pasan";
            this.pasanToolStripMenuItem.Click += new System.EventHandler(this.pasanToolStripMenuItem_Click);
            // 
            // evaluaciónToolStripMenuItem
            // 
            this.evaluaciónToolStripMenuItem.Name = "evaluaciónToolStripMenuItem";
            this.evaluaciónToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.evaluaciónToolStripMenuItem.Text = "Evaluación";
            this.evaluaciónToolStripMenuItem.Click += new System.EventHandler(this.evaluaciónToolStripMenuItem_Click);
            // 
            // dGrupoToolStripMenuItem
            // 
            this.dGrupoToolStripMenuItem.Name = "dGrupoToolStripMenuItem";
            this.dGrupoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.dGrupoToolStripMenuItem.Text = "D. Grupo";
            this.dGrupoToolStripMenuItem.Click += new System.EventHandler(this.dGrupoToolStripMenuItem_Click);
            // 
            // resultadosToolStripMenuItem
            // 
            this.resultadosToolStripMenuItem.Name = "resultadosToolStripMenuItem";
            this.resultadosToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.resultadosToolStripMenuItem.Text = "Resultados";
            this.resultadosToolStripMenuItem.Click += new System.EventHandler(this.resultadosToolStripMenuItem_Click);
            // 
            // comparadorToolStripMenuItem
            // 
            this.comparadorToolStripMenuItem.Name = "comparadorToolStripMenuItem";
            this.comparadorToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.comparadorToolStripMenuItem.Text = "Comparador";
            this.comparadorToolStripMenuItem.Click += new System.EventHandler(this.comparadorToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1455, 763);
            this.Controls.Add(this.tlpDashboard);
            this.Controls.Add(this.menuStrip1);
            this.HelpButton = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.tlpDashboard.ResumeLayout(false);
            this.tlpBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.tlpFiltro.ResumeLayout(false);
            this.tlpModulo.ResumeLayout(false);
            this.tlpModulo.PerformLayout();
            this.tlpCurso.ResumeLayout(false);
            this.tlpCurso.PerformLayout();
            this.tlpCiclo.ResumeLayout(false);
            this.tlpCiclo.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpDashboard;
        private System.Windows.Forms.TableLayoutPanel tlpBotones;
        private System.Windows.Forms.Button btnCentro;
        private System.Windows.Forms.Button btnGrupo;
        private System.Windows.Forms.Button btnModulo;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.TableLayoutPanel tlpFiltro;
        private System.Windows.Forms.TableLayoutPanel tlpCiclo;
        private System.Windows.Forms.Label lblCiclo;
        public System.Windows.Forms.ComboBox cmbCiclo;
        private System.Windows.Forms.TableLayoutPanel tlpModulo;
        private System.Windows.Forms.Label lblModulo;
        public System.Windows.Forms.ComboBox cmbModulo;
        private System.Windows.Forms.TableLayoutPanel tlpCurso;
        private System.Windows.Forms.Label lblCurso;
        public System.Windows.Forms.ComboBox cmbCurso;
        public System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnInformes;
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem centroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem grupoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem móduloToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estudianteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evaluaciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dGrupoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resultadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comparadorToolStripMenuItem;
    }
}


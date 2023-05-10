using System;
using System.Windows.Forms;
using Utiles;

namespace GraSupInf.Controles_Usuario {
    public partial class PanelModuloUC : UserControl {

        PictureBox pictureBox;

        Form1 form1;

        public PanelModuloUC() {
            InitializeComponent();
            pictureBox = new PictureBox();
            pictureBox.Image = Properties.Resources.cargando;
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            tlpPanel.Controls.Add(pictureBox, 0, 0);
            //tlpPanel6.Visible = false;
            pictureBox.Visible = false;
        }
        
        public void LinkForm(Form1 form1) {
            this.form1 = form1;
        }

        public void StartLoadingData() {
            pictureBox.Visible = true;
            tlpPanel5.Visible = false;
        }
        
        public void FinishLoadingData() {
            pictureBox.Visible = false;
            tlpPanel5.Visible = true;
        }

        public void SetTitle(string titulo) {
           lblModulo.Text = titulo;
        }

        public void SetDistribucionNotas(int[] distribucion) {
            int[] axisX = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            chart.Series[0].Points.Clear();
            chart.Series[0].Points.DataBindXY(axisX, distribucion);
        }

        public void SetDatosDocente(DocenteDTO docente) {
            lblDocenteNombre.Text = docente.Nombre + " " + docente.Apellidos;
            lblDesdeFecha.Text = docente.FechaInicio.ToString().Substring(0, 10);
            flpDocenteModulos.Controls.Clear();
            foreach(var m in docente.Modulos) {
                flpDocenteModulos.Controls.Add(CrearBoton(m.Grupo + " " + m.Siglas));
            }
        }

        public Button CrearBoton(string texto) {
            Button button = new Button();
            button.AutoSize = true;
            button.BackColor = System.Drawing.Color.White;
            button.Cursor = System.Windows.Forms.Cursors.Hand;
            button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button.Location = new System.Drawing.Point(40, 10);
            button.Margin = new System.Windows.Forms.Padding(40, 10, 10, 10);
            button.Size = new System.Drawing.Size(240, 55);
            button.Text = texto;
            button.Click += new System.EventHandler(this.button_Click);
            return button;
        }

        private void button_Click(object sender, EventArgs e) {
            Button btn = (Button)sender;
            string str = btn.Text;
            string siglasModulo = str.Substring(str.IndexOf(' ')+1, str.Length - str.IndexOf(' ') - 1);
            str = str.Substring(0, str.IndexOf(' '));
            int curso = Int32.Parse(str.Substring(str.Length - 1, 1));
            string ciclo = str.Substring(0, str.Length - 1).Replace("-",string.Empty);
            //MessageBox.Show("*" + ciclo + "*" + curso + "*" + siglasModulo + "*");
            if(form1 != null) {
                form1.cmbCiclo.SelectedIndex = form1.cmbCiclo.FindStringExact(ciclo);
                form1.cmbCurso.SelectedItem = curso;
                form1.CargarModulosCombo();
                form1.cmbModulo.SelectedIndex = form1.cmbModulo.FindStringExact(siglasModulo);
                form1.btnFiltrar.PerformClick();
            }
        }

    }
}

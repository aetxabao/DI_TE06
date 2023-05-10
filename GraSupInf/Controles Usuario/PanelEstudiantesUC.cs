using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Utiles;

namespace GraSupInf.Controles_Usuario {
    public partial class PanelEstudiantesUC : UserControl {

        PictureBox pictureBox;

        private Color[] colors = { Color.Green, Color.Red, Color.PowderBlue, Color.IndianRed, Color.Pink, Color.Purple, Color.Gold, Color.Teal, Color.LimeGreen, Color.Chocolate};

        private string[] modulos = new string[0];

        private int searchIniIndex = -1;

        public PanelEstudiantesUC() {
            InitializeComponent();
            pictureBox = new PictureBox();
            pictureBox.Image = Properties.Resources.cargando;
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.SizeMode = PictureBoxSizeMode.CenterImage;
            tlpPanel.Controls.Add(pictureBox, 0, 0);
            //tlpPanel2.Visible = false;
            pictureBox.Visible = false;
        }

        public void LoadingData() {
            pictureBox.Visible = true;
            tlpPanel2.Visible = false;
        }

        public void SetData(List<EstudianteDTO> lista, string[] headers) {
            searchIniIndex = -1;

            int n = headers.Length + 3;
            dataGridView.DataSource = lista;
            int m = dataGridView.Columns.Count;
            for(int i = 0; i < n; i++) {
                dataGridView.Columns[i].Visible = true;
            }
            for(int i = n; i < m; i++) {
                dataGridView.Columns[i].Visible = false;
            }
            int w = dataGridView.Width;
            int x = (w - 240) / (n - 3);
            dataGridView.Columns[0].Width = 20;
            dataGridView.Columns[1].Width = 80;
            dataGridView.Columns[2].Width = 80;
            int j = 0;
            for(int i = 3; i < n; i++) {
                dataGridView.Columns[i].Width = x;
                dataGridView.Columns[i].HeaderText = headers[j++];
            }
            pictureBox.Visible = false;
            tlpPanel2.Visible = true;
        }

        public void DisplayAverageGraph(string[] modulos, int[] medias) {
            this.modulos = modulos;
            chart.Series[1].Points.Clear();
            chart.Series[0].Points.Clear();
            chart.Series[0].Points.DataBindXY(modulos, medias);
            for(int i = 0; i < modulos.Length; i++) {
                chart.Series[0].Points[i].Color = colors[i];
            }
        }
        
        public void DisplayStudentGraph(int num) {
            int[] notas = new int[modulos.Length];
            for(int i = 0; i <notas.Length; i++) {
                notas[i] = (int)dataGridView.Rows[num - 1].Cells[i + 3].Value;
            }
            chart.Series[1].Points.Clear();
            chart.Series[1].Points.DataBindXY(modulos, notas);

        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
            dataGridView.Rows[e.RowIndex].Selected = true;
            DisplayStudentGraph(e.RowIndex + 1);
        }

        private void btnLimpiar_Click(object sender, System.EventArgs e) {
            txtNombre.Text = "";
            dataGridView.ClearSelection();
            chart.Series[1].Points.Clear();
        }

        private void maskedTextBox_Enter(object sender, System.EventArgs e) {
            //this.BeginInvoke((MethodInvoker)delegate ()
            //{
            //    maskedTextBox.Select(0, 0);
            //});

            MaskedTextBox textBox = sender as MaskedTextBox;
            if(textBox != null) {
                this.BeginInvoke((MethodInvoker)delegate () {
                    int pos = textBox.SelectionStart;
                    if(pos > textBox.Text.Length)
                        pos = textBox.Text.Length;
                    textBox.Select(pos, 0);
                });
            }
        }

        private void btnBuscar_Click(object sender, System.EventArgs e) {
            if(dataGridView.Rows.Count < 1) {
                MessageBox.Show("Primero debes Filtrar el grupo.", "Error Filtrar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string nombre = txtNombre.Text.Trim().ToUpper();
            if (nombre.Length<1) {
                MessageBox.Show("Debes escribir al menos una letra.", "Error Nombre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            } 
            int n = dataGridView.Rows.Count;
            for(int i = searchIniIndex+1; i < n; i++) {
                string s = (string)(dataGridView.Rows[i].Cells[2].Value);
                if (s.ToUpper().StartsWith(nombre)) {
                    searchIniIndex = i;
                    dataGridView.ClearSelection();
                    dataGridView.Rows[i].Selected = true;
                    DisplayStudentGraph(i + 1);
                    return;
                }
            }
            if(searchIniIndex == -1) {
                MessageBox.Show("No hay nombres que empiecen por '" + txtNombre.Text.Trim() + "'.", "Error Nombre", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else {
                searchIniIndex = -1;
                btnBuscar_Click(sender, e);
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utiles {
    public class ModuloDTO {
        private string ciclo;
        private int curso;
        private string siglas;
        private string nombre;

        public ModuloDTO() {
            Ciclo = "";
            Curso = 0;
            Siglas = "";
            Nombre = "";
        }

        public ModuloDTO(string ciclo, int curso, string siglas, string nombre) {
            Ciclo = ciclo;
            Curso = curso;
            Siglas = siglas;
            Nombre = nombre;
        }

        public string Ciclo { get => ciclo; set => ciclo = value; }
        public int Curso { get => curso; set => curso = value; }
        public string Siglas { get => siglas; set => siglas = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public string Grupo {
            get {
                if(ciclo.Length > 3) {
                    return ciclo + curso;
                } else {
                    return ciclo + "-" + curso;
                }
            }
        }
    }
}

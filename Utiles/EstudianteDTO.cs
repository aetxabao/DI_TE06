using System;

namespace Utiles
{
    public class EstudianteDTO
    {
        private int num;
        private String apellidos;
        private String nombre;
        private int modulo0;
        private int modulo1;
        private int modulo2;
        private int modulo3;
        private int modulo4;
        private int modulo5;
        private int modulo6;
        private int modulo7;
        private int modulo8;
        private int modulo9;

        public EstudianteDTO() {
            apellidos = "";
            nombre = "";
        }

        public int Num { get => num; set => num = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Modulo0 { get => modulo0; set => modulo0 = value; }
        public int Modulo1 { get => modulo1; set => modulo1 = value; }
        public int Modulo2 { get => modulo2; set => modulo2 = value; }
        public int Modulo3 { get => modulo3; set => modulo3 = value; }
        public int Modulo4 { get => modulo4; set => modulo4 = value; }
        public int Modulo5 { get => modulo5; set => modulo5 = value; }
        public int Modulo6 { get => modulo6; set => modulo6 = value; }
        public int Modulo7 { get => modulo7; set => modulo7 = value; }
        public int Modulo8 { get => modulo8; set => modulo8 = value; }
        public int Modulo9 { get => modulo9; set => modulo9 = value; }

        public int NotaModulo(int i) {
            switch(i) {
                case 0: return modulo0;
                case 1: return modulo1;
                case 2: return modulo2;
                case 3: return modulo3;
                case 4: return modulo4;
                case 5: return modulo5;
                case 6: return modulo6;
                case 7: return modulo7;
                case 8: return modulo8;
                case 9: return modulo9;
            }
            return 0;
        }
    }
}

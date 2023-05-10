using System;
using System.Collections.Generic;

namespace Utiles {
    public class DocenteDTO {

        //CTRL+R, CTRL+E
        private int num;
        private string nombre;
        private string apellidos;
        private DateTime fechaInicio;
        private List<ModuloDTO> modulos;

        //CTRL+.
        public DocenteDTO() {
            Num = 0;
            Nombre = "";
            Apellidos = "";
            FechaInicio = new DateTime();
            Modulos = new List<ModuloDTO>();
        }
        public DocenteDTO(int num, string nombre, string apellidos, DateTime fechaInicio) {
            Num = num;
            Nombre = nombre;
            Apellidos = apellidos;
            FechaInicio = fechaInicio;
            Modulos = new List<ModuloDTO>();
        }

        public int Num { get => num; set => num = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public DateTime FechaInicio { get => fechaInicio; set => fechaInicio = value; }
        public List<ModuloDTO> Modulos { get => modulos; set => modulos = value; }

    }
}

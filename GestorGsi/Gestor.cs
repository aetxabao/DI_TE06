using System;
using System.Collections.Generic;
using System.Data;
using GsiSqlServer;
using Utiles;

namespace GsiGestor {
    public class Gestor {

        private static string[] nombresGrupos = new string[] { "ASIR1", "DAM-1", "DAW-1", "ASIR2", "DAM-2", "DAW-2" };
        public static string[] NombresGrupos { get => nombresGrupos; }

        public static int NumeroGrupos { get => nombresGrupos.Length; }

        private static string ciclo = "";
        public static string Ciclo { get => ciclo; set => ciclo = value; }

        private static int curso;
        public static int Curso { get => curso; set => curso = value; }        

        private static string siglasModulo;
        public static string SiglasModulo { get => siglasModulo; set => siglasModulo = value; }

        private static string grupo = "";
        public static string Grupo { 
            set {
                grupo = value;
                curso = Int32.Parse(grupo.Substring(grupo.Length - 1, 1));
                ciclo = grupo.Replace("-", "").Substring(0, grupo.Replace("-", "").Length - 1);
            }
        }

        private static int[][] suspensosGrupos = new int[6][];
        public static int[][] SuspensosGrupos { get => suspensosGrupos; }

        private static List<EstudianteDTO> notasGrupo = new List<EstudianteDTO>();
        public static List<EstudianteDTO> NotasGrupo { get => notasGrupo; }

        private static string[] nombresModulos = new string[0];
        public static string[] NombresModulos { get => nombresModulos; }

        public static int NumeroModulos { get => nombresModulos.Length; }

        private static int[] mediasModulos = new int[0];
        public static int[] MediasModulos { get => mediasModulos; }

        private static int[] distribucionNotasModulo = new int[11];
        public static int[] DistribucionNotasModulo { get => distribucionNotasModulo; }

        private static DocenteDTO docente = new DocenteDTO();
        public static DocenteDTO Docente { get => docente; }

        private static ModuloDTO modulo = new ModuloDTO();
        public static ModuloDTO Modulo { get => modulo; }

        public static bool TestDB() {
            return Consulta.HayConexion();
        }

        public static String[] GetCiclos() {
            return new String[] { "ASIR", "DAM", "DAW" };
        }
        public static int[] GetCursos() {
            return new int[] { 1, 2 };
        }
        public static String[] GetModulos() {
            nombresModulos = Consulta.ModulosGrupo(ciclo, curso);
            return nombresModulos;
        }

        public static void GetSuspensosGrupo(int i) {
            Grupo = NombresGrupos[i];
            suspensosGrupos[i] = Consulta.SuspensosGrupo(ciclo, curso);
        }

        public static void GetNotasGrupo() {
            notasGrupo = Consulta.NotasGrupo(ciclo, curso);
            nombresModulos = Consulta.ModulosGrupo(ciclo, curso);
            mediasModulos = new int[nombresModulos.Length];
            foreach(var e in notasGrupo) {
                for(int i = 0; i < mediasModulos.Length; i++) {
                    mediasModulos[i] += e.NotaModulo(i);
                }
            }
            for(int i = 0; i < mediasModulos.Length; i++) {
                mediasModulos[i] = (int)Math.Round((double)mediasModulos[i] / notasGrupo.Count);
            }
        }

        public static void GetInfoModulo() {
            distribucionNotasModulo = Consulta.DistribucionNotasModulo(ciclo, curso, siglasModulo);
            docente = Consulta.DocenteModulo(ciclo, curso, siglasModulo);
            docente.Modulos = Consulta.ModulosDocente(docente.Num);
            foreach(var m in docente.Modulos) {
                if (m.Ciclo.Equals(ciclo) && m.Curso == curso && m.Siglas.Equals(siglasModulo)) {
                    modulo = m;
                    return;
                }
            }
        }

        public static DataTable GetEstudiantesSuspensosHoras(int suspensos, int horas) {
            return Consulta.EstudiantesSuspensosHoras(suspensos, horas);
        }

        public static DataTable GetDistribucioNotasCicloCurso(string ciclo, int curso) {
            return Consulta.DistribucionNotasGrupo(ciclo, curso);
        }

        public static DataTable GetDistribucioNotasCicloCursoTranspuesta(string ciclo, int curso) {
            return Consulta.DistribucionNotasGrupoTranspuesta(ciclo, curso);
        }

        public static object GetDistribucioNotas() {
            return Consulta.DistribucioNotas();
        }
    }
}

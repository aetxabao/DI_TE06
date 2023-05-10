using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Utiles;

namespace GsiSqlServer
{
    public class Consulta {
        private const string CON_STRING = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=GRASUPINF;User ID=di;Password=1234";
        //private const string CON_STRING = @"Data Source=LEOPARD\SQLEXPRESS;Initial Catalog=GRASUPINF;User ID=di;Password=1234";
        //private const string CON_STRING = @"Data Source=LEOPARD\SQLEXPRESS;Initial Catalog=GRASUPINF;User ID=aitor;Password=1234";
        private const int MAX_MODULOS = 10;

        #region Sentencias sql

        private const string SQL_SUSPENSOS_GRUPO =
@"SELECT s.susp, COUNT(*) as cuantos FROM (
SELECT idEstudiante,
COUNT(*) AS susp
FROM dbo.notas, dbo.modulos
WHERE dbo.notas.idModulo = dbo.modulos.id
AND ciclo = '@ciclo' AND curso = @curso
AND valor < 5 
GROUP BY idEstudiante
) s
GROUP BY s.susp
UNION
SELECT 0 AS susp,
(SELECT COUNT(*)
FROM estudiantes
WHERE ciclo = '@ciclo' AND curso = @curso
) - (SELECT COUNT(*) FROM(
SELECT idEstudiante,
COUNT(*) AS susp
FROM dbo.notas, dbo.modulos
WHERE dbo.notas.idModulo = dbo.modulos.id
AND ciclo = '@ciclo' AND curso = @curso
AND valor < 5 
GROUP BY idEstudiante
) s ) AS cuantos
ORDER BY 1 ASC";

        private const string SQL_NOTAS_GRUPO =
@"SELECT apellidos, nombre, @lista_modulos
FROM (
SELECT e.apellidos, e.nombre, m.siglas, n.valor 
FROM estudiantes AS e, notas AS n, modulos AS m 
WHERE e.id = n.idEstudiante
AND n.idModulo = m.id 
AND e.ciclo = '@ciclo' AND e.curso = @curso 
) AS s
PIVOT  
(  
  AVG(valor)  
  FOR siglas IN ( @lista_modulos )  
) AS PivotTable  
ORDER BY 1 ASC ";

        private const string SQL_MODULOS_GRUPO = "SELECT siglas FROM modulos WHERE ciclo='@ciclo' AND curso=@curso ORDER BY 1";
        
        private const string SQL_DISTRIBUCION_NOTAS_MODULO =
@"SELECT valor, COUNT(*) AS estudiantes 
FROM dbo.notas, dbo.modulos 
WHERE dbo.notas.idModulo = dbo.modulos.id 
AND ciclo = '@ciclo' AND curso = @curso AND siglas = '@siglas' 
GROUP BY valor 
ORDER BY 1 ASC";
        
        private const string SQL_DOCENTE_MODULO =
@"SELECT CAST(docentes.id AS int) AS id, docentes.nombre, docentes.apellidos, docentes.fechaInicio  
FROM docentes, imparte, modulos 
WHERE docentes.id = imparte.idDocente AND imparte.idModulo = modulos.id 
AND ciclo = '@ciclo' AND curso = @curso AND siglas = '@siglas' ";
   
        private const string SQL_MODULOS_DOCENTE =
@"SELECT modulos.ciclo, modulos.curso, modulos.siglas, modulos.nombre 
FROM docentes, imparte, modulos 
WHERE docentes.id = imparte.idDocente AND imparte.idModulo = modulos.id 
AND docentes.id = @id ";

        #endregion

        #region Código anterior
        public static bool HayConexion() {
            using(SqlConnection connection = new SqlConnection(CON_STRING)) {
                try {
                    connection.Open();
                    return true;
                } catch(SqlException) {
                    return false;
                }
            }
        }

        public static int[] SuspensosGrupo(string ciclo, int curso) {
            int[] a = new int[MAX_MODULOS];
            using(SqlConnection connection = new SqlConnection(CON_STRING)) {
                connection.Open();
                string sql = SQL_SUSPENSOS_GRUPO.Replace("@curso", curso.ToString()).Replace("@ciclo", ciclo);
                using(SqlCommand sqlCommand = new SqlCommand(sql, connection)) {
                    using(SqlDataReader sqlDataReader = sqlCommand.ExecuteReader()) {
                        while(sqlDataReader.Read()) {
                            int i = sqlDataReader.GetInt32(0);
                            int v = sqlDataReader.GetInt32(1);
                            a[i] = v;
                        }
                    }
                }
            }
            return a;
        }

        public static List<EstudianteDTO> NotasGrupo(string ciclo, int curso) {
            string[] modulos = ModulosGrupo(ciclo, curso);
            string lista_modulos = ListaModulos(modulos);
            List<EstudianteDTO> lista = new List<EstudianteDTO>();
            int i = 1;
            int n = modulos.Length;
            using(SqlConnection connection = new SqlConnection(CON_STRING)) {
                connection.Open();
                string sql = SQL_NOTAS_GRUPO.Replace("@ciclo", ciclo).Replace("@curso", curso.ToString()).Replace("@lista_modulos", lista_modulos);
                using(SqlCommand sqlCommand = new SqlCommand(sql, connection)) {
                    using(SqlDataReader sqlDataReader = sqlCommand.ExecuteReader()) {
                        while(sqlDataReader.Read()) {
                            EstudianteDTO e = new EstudianteDTO();
                            e.Num = i++;
                            e.Apellidos = sqlDataReader.GetString(0);
                            e.Nombre = sqlDataReader.GetString(1);
                            if(n >= 1) e.Modulo0 = sqlDataReader.GetInt32(2);
                            if(n >= 2) e.Modulo1 = sqlDataReader.GetInt32(3);
                            if(n >= 3) e.Modulo2 = sqlDataReader.GetInt32(4);
                            if(n >= 4) e.Modulo3 = sqlDataReader.GetInt32(5);
                            if(n >= 5) e.Modulo4 = sqlDataReader.GetInt32(6);
                            if(n >= 6) e.Modulo5 = sqlDataReader.GetInt32(7);
                            if(n >= 7) e.Modulo6 = sqlDataReader.GetInt32(8);
                            if(n >= 8) e.Modulo7 = sqlDataReader.GetInt32(9);
                            if(n >= 9) e.Modulo8 = sqlDataReader.GetInt32(10);
                            if(n >= 10) e.Modulo9 = sqlDataReader.GetInt32(11);
                            lista.Add(e);
                        }
                    }
                }
            }
            return lista;
        }

        private static string ListaModulos(string[] modulos) {
            StringBuilder sb = new StringBuilder();
            for(int i = 0; i < modulos.Length; i++) {
                sb.Append("[").Append(modulos[i]).Append("], ");
            }
            if(modulos.Length > 0) {
                sb.Remove(sb.Length - 2, 2);
            }
            return sb.ToString();
        }

        public static string[] ModulosGrupo(string ciclo, int curso) {
            List<string> lista = new List<string>();
            using(SqlConnection connection = new SqlConnection(CON_STRING)) {
                connection.Open();
                string sql = SQL_MODULOS_GRUPO.Replace("@ciclo", ciclo).Replace("@curso", curso.ToString());
                using(SqlCommand sqlCommand = new SqlCommand(sql, connection)) {
                    using(SqlDataReader sqlDataReader = sqlCommand.ExecuteReader()) {
                        while(sqlDataReader.Read()) {
                            lista.Add(sqlDataReader.GetString(0));
                        }
                    }
                }
            }
            return lista.ToArray();
        }
        


        public static int[] DistribucionNotasModulo(string ciclo, int curso, string siglasModulo) {
            int[] a = new int[11];
            using(SqlConnection connection = new SqlConnection(CON_STRING)) {
                connection.Open();
                string sql = SQL_DISTRIBUCION_NOTAS_MODULO.Replace("@ciclo", ciclo).Replace("@curso", curso.ToString()).Replace("@siglas", siglasModulo);
                using(SqlCommand sqlCommand = new SqlCommand(sql, connection)) {
                    using(SqlDataReader sqlDataReader = sqlCommand.ExecuteReader()) {
                        while(sqlDataReader.Read()) {
                            int i = sqlDataReader.GetInt32(0);
                            int v = sqlDataReader.GetInt32(1);
                            a[i] = v;
                        }
                    }
                }
            }
            return a;
        }
        

        public static DocenteDTO DocenteModulo(string ciclo, int curso, string siglasModulo) {
            DocenteDTO docente = new DocenteDTO();
            using(SqlConnection connection = new SqlConnection(CON_STRING)) {
                connection.Open();
                string sql = SQL_DOCENTE_MODULO.Replace("@ciclo", ciclo).Replace("@curso", curso.ToString()).Replace("@siglas", siglasModulo);
                using(SqlCommand sqlCommand = new SqlCommand(sql, connection)) {
                    using(SqlDataReader sqlDataReader = sqlCommand.ExecuteReader()) {
                        if(sqlDataReader.Read()) {
                            docente.Num = sqlDataReader.GetInt32(0);
                            docente.Nombre = sqlDataReader.GetString(1);
                            docente.Apellidos = sqlDataReader.GetString(2);
                            docente.FechaInicio = sqlDataReader.GetDateTime(3);
                        }
                    }
                }
            }
            return docente;
        }
        
        public static List<ModuloDTO> ModulosDocente(int idDocente) {
            List<ModuloDTO> lista = new List<ModuloDTO>();
            using(SqlConnection connection = new SqlConnection(CON_STRING)) {
                connection.Open();
                string sql = SQL_MODULOS_DOCENTE.Replace("@id", idDocente.ToString());
                using(SqlCommand sqlCommand = new SqlCommand(sql, connection)) {
                    using(SqlDataReader sqlDataReader = sqlCommand.ExecuteReader()) {
                        while(sqlDataReader.Read()) {
                            ModuloDTO m = new ModuloDTO();
                            m.Ciclo = sqlDataReader.GetString(0);
                            m.Curso = sqlDataReader.GetInt32(1);
                            m.Siglas = sqlDataReader.GetString(2);
                            m.Nombre = sqlDataReader.GetString(3);
                            lista.Add(m);
                        }
                    }
                }
            }
            return lista;
        }

        public static DataTable EstudiantesSuspensosHoras(int suspensos, int horas) {
            DataTable table = new DataTable();
            using(SqlConnection con = new SqlConnection(CON_STRING)) {
                using(SqlCommand cmd = new SqlCommand("dbo.EstudiantesSuspensosHoras", con)) {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@suspensos", suspensos));
                    cmd.Parameters.Add(new SqlParameter("@horas", horas));

                    using(var da = new SqlDataAdapter(cmd)) {
                        cmd.CommandType = CommandType.StoredProcedure;
                        da.Fill(table);
                    }
                }
            }
            return table;
        }

        #endregion

        public static object DistribucioNotas() {
            DataTable table = new DataTable();
            using(SqlConnection con = new SqlConnection(CON_STRING)) {
                using(SqlCommand cmd = new SqlCommand("dbo.DistribucionNotas", con)) {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using(var da = new SqlDataAdapter(cmd)) {
                        cmd.CommandType = CommandType.StoredProcedure;
                        da.Fill(table);
                    }
                }
            }
            return table;
        }

        public static DataTable DistribucionNotasGrupo(string ciclo, int curso) {
            DataTable table = new DataTable();
            using(SqlConnection con = new SqlConnection(CON_STRING)) {
                using(SqlCommand cmd = new SqlCommand("dbo.DistribucionNotasCicloCurso", con)) {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ciclo", ciclo));
                    cmd.Parameters.Add(new SqlParameter("@curso", curso));

                    using(var da = new SqlDataAdapter(cmd)) {
                        cmd.CommandType = CommandType.StoredProcedure;
                        da.Fill(table);
                    }
                }
            }
            return table;
        }

        public static DataTable DistribucionNotasGrupoTranspuesta(string ciclo, int curso) {
            DataTable table = new DataTable();
            using(SqlConnection con = new SqlConnection(CON_STRING)) {
                using(SqlCommand cmd = new SqlCommand("dbo.DistribucionNotasGrupoTranspuesta", con)) {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@ciclo", ciclo));
                    cmd.Parameters.Add(new SqlParameter("@curso", curso));

                    using(var da = new SqlDataAdapter(cmd)) {
                        cmd.CommandType = CommandType.StoredProcedure;
                        da.Fill(table);
                    }
                }
            }
            return table;
        }

    }
}

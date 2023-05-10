USE [GRASUPINF]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** 
		Object:  StoredProcedure [dbo].[NotasEstudiante]    
		Notas de un estudiante, ej. 
		EXECUTE dbo.NotasEstudiante 'josh', 'morris' 
******/
CREATE OR ALTER PROCEDURE [dbo].[NotasEstudiante] @nombre nvarchar(50), @apellidos nvarchar(50) 
AS
SELECT ciclo, curso, siglas, nombre as modulo, valor as nota 
FROM notas JOIN modulos ON notas.idModulo = modulos.id
WHERE idEstudiante = (
SELECT id FROM estudiantes WHERE UPPER(nombre) = UPPER(@nombre) AND UPPER(apellidos) = UPPER(@apellidos)
) 
ORDER BY 1, 2, 3
GO

/****** 
		Object:  StoredProcedure [dbo].[EstudiantesSuspensosHoras]    
		Estudiantes con todo aprobado o hasta N suspensos y hasta M horas o menos pendientes, ej. 
		EXECUTE dbo.EstudiantesSuspensosHoras 2, 300 
******/
CREATE OR ALTER PROCEDURE [dbo].[EstudiantesSuspensosHoras] @suspensos int, @horas int 
AS
SELECT e.ciclo, e.curso, e.id, e.apellidos, e.nombre, 
SUM(m.horasTotales) AS horas, COUNT(*) AS suspensos 
FROM dbo.notas n, dbo.modulos m, dbo.estudiantes as e  
WHERE n.idModulo = m.id
AND e.id = n.idEstudiante 
AND valor < 5 
GROUP BY e.ciclo, e.curso, e.id, e.apellidos, e.nombre
HAVING SUM(m.horasTotales) <= @horas
AND COUNT(*) <= @suspensos
UNION
SELECT DISTINCT e.ciclo, e.curso, e.id, e.apellidos, e.nombre, 
'0' AS horas, '0' AS suspensos 
FROM dbo.estudiantes as e  
WHERE e.id NOT IN (SELECT DISTINCT idEstudiante
FROM dbo.notas, dbo.modulos
WHERE dbo.notas.idModulo = dbo.modulos.id
AND valor < 5 ) 
ORDER BY 1, 2, 6, 7
GO

/****** 
		Object:  StoredProcedure [dbo].[NotasASIR1]    
		Notas de todos los módulos de todos los estudiantes de ASIR1, ej. 
		EXECUTE dbo.NotasASIR1
******/
CREATE OR ALTER PROCEDURE [dbo].[NotasASIR1] 
AS
SELECT apellidos, nombre, [EMIE], [FUHA],[GEBD], [IMSO], [ING1], [LMGI], [PARE] 
FROM (
SELECT e.apellidos, e.nombre, m.siglas, n.valor 
FROM estudiantes AS e, notas AS n, modulos AS m 
WHERE e.id = n.idEstudiante
AND n.idModulo = m.id 
AND e.ciclo = 'ASIR' AND e.curso = 1 
) AS s
PIVOT  
(  
  AVG(valor)  
  FOR siglas IN ( [EMIE], [FUHA],[GEBD], [IMSO], [ING1], [LMGI], [PARE] )  
) AS PivotTable  
ORDER BY 1 ASC
GO

/****** 
		Object:  StoredProcedure [dbo].[NotasASIR2]    
		Notas de todos los módulos de todos los estudiantes de ASIR2, ej. 
		EXECUTE dbo.NotasASIR2
******/
CREATE OR ALTER PROCEDURE [dbo].[NotasASIR2] 
AS
SELECT apellidos, nombre, [ADBD], [ADSO], [FCET], [FOLA], [IAWE], [PROY], [SEAD], [SERI] 
FROM (
SELECT e.apellidos, e.nombre, m.siglas, n.valor 
FROM estudiantes AS e, notas AS n, modulos AS m 
WHERE e.id = n.idEstudiante
AND n.idModulo = m.id 
AND e.ciclo = 'ASIR' AND e.curso = 2 
) AS s
PIVOT  
(  
  AVG(valor)  
  FOR siglas IN ( [ADBD], [ADSO], [FCET], [FOLA], [IAWE], [PROY], [SEAD], [SERI] )  
) AS PivotTable  
ORDER BY 1 ASC
GO

/****** 
		Object:  StoredProcedure [dbo].[NotasDAM1]    
		Notas de todos los módulos de todos los estudiantes de DAM1, ej. 
		EXECUTE dbo.NotasDAM1
******/
CREATE OR ALTER PROCEDURE [dbo].[NotasDAM1] 
AS
SELECT apellidos, nombre, [BADA], [EMIE], [ENDE], [ING1], [LMGI], [PROG], [SIIN] 
FROM (
SELECT e.apellidos, e.nombre, m.siglas, n.valor 
FROM estudiantes AS e, notas AS n, modulos AS m 
WHERE e.id = n.idEstudiante
AND n.idModulo = m.id 
AND e.ciclo = 'DAM' AND e.curso = 1 
) AS s
PIVOT  
(  
  AVG(valor)  
  FOR siglas IN ( [BADA], [EMIE], [ENDE], [ING1], [LMGI], [PROG], [SIIN] )  
) AS PivotTable  
ORDER BY 1 ASC
GO

/****** 
		Object:  StoredProcedure [dbo].[NotasDAM2]    
		Notas de todos los módulos de todos los estudiantes de DAM2, ej. 
		EXECUTE dbo.NotasDAM2
******/
CREATE OR ALTER PROCEDURE [dbo].[NotasDAM2] 
AS
SELECT apellidos, nombre, [ACDA], [DEIN], [DEWE], [FCET], [FOLA], [ING2], [PMDM], [PROY], [PSEP], [SGEM] 
FROM (
SELECT e.apellidos, e.nombre, m.siglas, n.valor 
FROM estudiantes AS e, notas AS n, modulos AS m 
WHERE e.id = n.idEstudiante
AND n.idModulo = m.id 
AND e.ciclo = 'DAM' AND e.curso = 2 
) AS s
PIVOT  
(  
  AVG(valor)  
  FOR siglas IN ( [ACDA], [DEIN], [DEWE], [FCET], [FOLA], [ING2], [PMDM], [PROY], [PSEP], [SGEM]  )  
) AS PivotTable  
ORDER BY 1 ASC
GO

/****** 
		Object:  StoredProcedure [dbo].[NotasDAW1]    
		Notas de todos los módulos de todos los estudiantes de DAW1, ej. 
		EXECUTE dbo.NotasDAW1
******/
CREATE OR ALTER PROCEDURE [dbo].[NotasDAW1] 
AS
SELECT apellidos, nombre, [BADA], [EMIE], [ENDE], [ING1], [LMGI], [PROG], [SIIN] 
FROM (
SELECT e.apellidos, e.nombre, m.siglas, n.valor 
FROM estudiantes AS e, notas AS n, modulos AS m 
WHERE e.id = n.idEstudiante
AND n.idModulo = m.id 
AND e.ciclo = 'DAW' AND e.curso = 1 
) AS s
PIVOT  
(  
  AVG(valor)  
  FOR siglas IN ( [BADA], [EMIE], [ENDE], [ING1], [LMGI], [PROG], [SIIN] )  
) AS PivotTable  
ORDER BY 1 ASC
GO

/****** 
		Object:  StoredProcedure [dbo].[NotasDAW2]    
		Notas de todos los módulos de todos los estudiantes de DAW2, ej. 
		EXECUTE dbo.NotasDAW2
******/
CREATE OR ALTER PROCEDURE [dbo].[NotasDAW2] 
AS
SELECT apellidos, nombre, [DAWE], [DIWE], [DWEC], [DWES], [FCET], [FOLA], [ING2], [PROY] 
FROM (
SELECT e.apellidos, e.nombre, m.siglas, n.valor 
FROM estudiantes AS e, notas AS n, modulos AS m 
WHERE e.id = n.idEstudiante
AND n.idModulo = m.id 
AND e.ciclo = 'DAW' AND e.curso = 2 
) AS s
PIVOT  
(  
  AVG(valor)  
  FOR siglas IN ( [DAWE], [DIWE], [DWEC], [DWES], [FCET], [FOLA], [ING2], [PROY] )  
) AS PivotTable  
ORDER BY 1 ASC
GO


/****** 
		Object:  StoredProcedure [dbo].[DistribucionNotasCicloCurso]    
		Distribución de las notas de todos los módulos de un curso de un ciclo, ej. 
		EXECUTE dbo.DistribucionNotasCicloCurso 'ASIR', 1 
******/
CREATE OR ALTER PROCEDURE [dbo].[DistribucionNotasCicloCurso] @ciclo nvarchar(50), @curso int 
AS
SELECT siglas, [0] AS NOTA_0, [1] AS NOTA_1, [2] AS NOTA_2, [3] AS NOTA_3, [4] AS NOTA_4, [5] AS NOTA_5, [6] AS NOTA_6, [7] AS NOTA_7, [8] AS NOTA_8, [9] AS NOTA_9, [10]  AS NOTA_10
FROM (
SELECT m.siglas AS siglas , t.nota AS nota, ISNULL(d.estudiantes,0) AS estudiantes
FROM 
modulos AS m CROSS JOIN 
(SELECT * FROM ( VALUES (0), (1), (2), (3), (4), (5), (6), (7), (8), (9), (10)) AS X(nota)) AS t 
LEFT OUTER JOIN 
(SELECT modulos.siglas AS modulo, notas.valor AS valor, COUNT(*) AS estudiantes 
FROM dbo.notas AS notas, dbo.modulos AS modulos
WHERE notas.idModulo = modulos.id 
AND modulos.ciclo = @ciclo AND modulos.curso = @curso
GROUP BY modulos.siglas, valor) AS d ON t.nota = d.valor AND m.siglas = d.modulo 
WHERE ciclo = @ciclo AND curso = @curso 
) AS s
PIVOT  
(  
  AVG(estudiantes)  
  FOR nota IN ( [0], [1], [2], [3], [4], [5], [6], [7], [8], [9], [10] )  
) AS PivotTable  
ORDER BY 7 DESC
GO

/****** 
		Object:  StoredProcedure [dbo].[DistribucionNotas]    
		Distribución de las notas de todos los módulos de todos los grupos
		EXECUTE dbo.DistribucionNotas 
******/
CREATE OR ALTER   PROCEDURE [dbo].[DistribucionNotas] 
AS
SELECT ciclo, curso, modulo, [0] AS NOTA_0, [1] AS NOTA_1, [2] AS NOTA_2, [3] AS NOTA_3, [4] AS NOTA_4, [5] AS NOTA_5, [6] AS NOTA_6, [7] AS NOTA_7, [8] AS NOTA_8, [9] AS NOTA_9, [10]  AS NOTA_10
FROM (
SELECT m.ciclo AS ciclo , m.curso AS curso , m.modulo AS modulo , t.nota AS nota, ISNULL(d.estudiantes,0) AS estudiantes
FROM 
(SELECT modulos.ciclo, modulos.curso, modulos.siglas as modulo
FROM docentes, imparte, modulos 
WHERE docentes.id = imparte.idDocente AND imparte.idModulo = modulos.id ) AS m CROSS JOIN 
(SELECT * FROM ( VALUES (0), (1), (2), (3), (4), (5), (6), (7), (8), (9), (10)) AS X(nota)) AS t 
LEFT OUTER JOIN 
(SELECT modulos.ciclo AS ciclo, modulos.curso AS curso, modulos.siglas AS modulo, notas.valor AS valor, COUNT(*) AS estudiantes 
FROM dbo.notas AS notas, dbo.modulos AS modulos
WHERE notas.idModulo = modulos.id 
GROUP BY modulos.ciclo, modulos.curso, modulos.siglas, notas.valor) AS d ON t.nota = d.valor AND m.ciclo = d.ciclo AND m.curso = d.curso AND m.modulo = d.modulo 
) AS s
PIVOT  
(  
  AVG(estudiantes)  
  FOR nota IN ( [0], [1], [2], [3], [4], [5], [6], [7], [8], [9], [10] )  
) AS PivotTable  
ORDER BY 9 DESC
GO

/****** 
		Object:  StoredProcedure [dbo].[DistribucionNotasModulosProfesor]    
		Distribución de las notas de todos los módulos de un docente, ej. 
		EXECUTE dbo.DistribucionNotasModulosProfesor 'mikel', 'puy' 
******/
CREATE OR ALTER PROCEDURE [dbo].[DistribucionNotasModulosProfesor] @nombre nvarchar(50), @apellidos nvarchar(50) 
AS
SELECT ciclo, curso, modulo, [0] AS NOTA_0, [1] AS NOTA_1, [2] AS NOTA_2, [3] AS NOTA_3, [4] AS NOTA_4, [5] AS NOTA_5, [6] AS NOTA_6, [7] AS NOTA_7, [8] AS NOTA_8, [9] AS NOTA_9, [10]  AS NOTA_10
FROM (
SELECT m.ciclo AS ciclo , m.curso AS curso , m.modulo AS modulo , t.nota AS nota, ISNULL(d.estudiantes,0) AS estudiantes
FROM 
(SELECT modulos.ciclo, modulos.curso, modulos.siglas as modulo
FROM docentes, imparte, modulos 
WHERE docentes.id = imparte.idDocente AND imparte.idModulo = modulos.id 
AND UPPER(docentes.nombre) = UPPER(@nombre)
AND UPPER(docentes.apellidos) = UPPER(@apellidos)) AS m CROSS JOIN 
(SELECT * FROM ( VALUES (0), (1), (2), (3), (4), (5), (6), (7), (8), (9), (10)) AS X(nota)) AS t 
LEFT OUTER JOIN 
(SELECT modulos.ciclo AS ciclo, modulos.curso AS curso, modulos.siglas AS modulo, notas.valor AS valor, COUNT(*) AS estudiantes 
FROM dbo.notas AS notas, dbo.modulos AS modulos
WHERE notas.idModulo = modulos.id 
GROUP BY modulos.ciclo, modulos.curso, modulos.siglas, notas.valor) AS d ON t.nota = d.valor AND m.ciclo = d.ciclo AND m.curso = d.curso AND m.modulo = d.modulo 
) AS s
PIVOT  
(  
  AVG(estudiantes)  
  FOR nota IN ( [0], [1], [2], [3], [4], [5], [6], [7], [8], [9], [10] )  
) AS PivotTable  
ORDER BY 9 DESC
GO

/****** 
		Object:  StoredProcedure [dbo].[DistribucionNotasCiclosModulo]    
		Distribución de notas de un módulo de todos los ciclos que la contengan, ej. 
		EXECUTE dbo.DistribucionNotasCiclosModulo 'PROG' 
******/
CREATE OR ALTER PROCEDURE [dbo].[DistribucionNotasCiclosModulo] @modulo nvarchar(50) 
AS
SELECT CONCAT(ciclo, '-', curso) AS grupo, CONCAT(nombre, ' ', apellidos) AS docente, [0] AS NOTA_0, [1] AS NOTA_1, [2] AS NOTA_2, [3] AS NOTA_3, [4] AS NOTA_4, [5] AS NOTA_5, [6] AS NOTA_6, [7] AS NOTA_7, [8] AS NOTA_8, [9] AS NOTA_9, [10]  AS NOTA_10
FROM (
SELECT m.ciclo AS ciclo , m.curso AS curso , m.nombre AS nombre , m.apellidos AS apellidos , t.nota AS nota, ISNULL(d.estudiantes,0) AS estudiantes
FROM 
(SELECT modulos.ciclo, modulos.curso, docentes.nombre, docentes.apellidos 
FROM docentes 
JOIN imparte ON docentes.id = imparte.idDocente 
JOIN modulos ON modulos.id = imparte.idModulo 
WHERE modulos.siglas = @modulo) AS m CROSS JOIN 
(SELECT * FROM ( VALUES (0), (1), (2), (3), (4), (5), (6), (7), (8), (9), (10)) AS X(nota)) AS t 
LEFT OUTER JOIN 
(SELECT modulos.ciclo AS ciclo, modulos.curso AS curso, notas.valor AS valor, COUNT(*) AS estudiantes 
FROM dbo.notas AS notas, dbo.modulos AS modulos
WHERE notas.idModulo = modulos.id 
AND modulos.siglas = @modulo 
GROUP BY modulos.ciclo, modulos.curso, valor) AS d ON t.nota = d.valor AND m.ciclo = d.ciclo AND m.curso = d.curso 
) AS s
PIVOT  
(  
  AVG(estudiantes)  
  FOR nota IN ( [0], [1], [2], [3], [4], [5], [6], [7], [8], [9], [10] )  
) AS PivotTable  
ORDER BY 10 DESC
GO


/****** 
		Object:  StoredProcedure [dbo].[NotasEstudiante]    
		Notas de un estudiante, ej. 
		EXECUTE dbo.DistribucionNotasGrupoTranspuesta 'ASIR', 1 
******/
CREATE OR ALTER PROCEDURE [dbo].[DistribucionNotasGrupoTranspuesta] @ciclo nvarchar(50), @curso int 
AS
BEGIN
  -- SET NOCOUNT ON added to prevent extra result sets from
  -- interfering with SELECT statements.
  SET NOCOUNT ON;

  DECLARE @colsUnpivot AS NVARCHAR(MAX),
  @query  AS NVARCHAR(MAX),
  @queryPivot  AS NVARCHAR(MAX),
  @colsPivot as  NVARCHAR(MAX),
  @columnToPivot as NVARCHAR(MAX),
  @tableToPivot as NVARCHAR(MAX), 
  @colsResult as xml

  
   IF OBJECT_ID(N'dbo.tmp', N'U') IS NOT NULL  DROP TABLE [dbo].[tmp];  

    CREATE TABLE tmp (siglas nvarchar(50), NOTA_0 int, NOTA_1 int, NOTA_2 int, NOTA_3 int, NOTA_4 int, NOTA_5 int, NOTA_6 int, NOTA_7 int, NOTA_8 int, NOTA_9 int, NOTA_10 int)

    INSERT INTO tmp (siglas, NOTA_0, NOTA_1, NOTA_2, NOTA_3, NOTA_4, NOTA_5, NOTA_6, NOTA_7, NOTA_8, NOTA_9, NOTA_10)
    EXECUTE dbo.DistribucionNotasCicloCurso @ciclo, @curso 
	
	
  select @tableToPivot = 'tmp'
  select @columnToPivot = 'siglas'
  
  select @colsUnpivot = stuff((select ','+quotename(C.name)
       from sys.columns as C
       where C.object_id = object_id(@tableToPivot) and
             C.name <> @columnToPivot 
       for xml path('')), 1, 1, '')

  set @queryPivot = 'SELECT @colsResult = (SELECT  '','' 
                    + quotename('+@columnToPivot+')
                  from '+@tableToPivot+' t
                  where '+@columnToPivot+' <> ''''
          FOR XML PATH(''''), TYPE)'

  exec sp_executesql @queryPivot, N'@colsResult xml out', @colsResult out

  select @colsPivot = STUFF(@colsResult.value('.', 'NVARCHAR(MAX)'),1,1,'')

  set @query 
    = 'select name, rowid, '+@colsPivot+'
        from
        (
          select '+@columnToPivot+' , name, value, ROW_NUMBER() over (partition by '+@columnToPivot+' order by '+@columnToPivot+') as rowid
          from '+@tableToPivot+'
          unpivot
          (
            value for name in ('+@colsUnpivot+')
          ) unpiv
        ) src
        pivot
        (
          sum(value)
          for '+@columnToPivot+' in ('+@colsPivot+')
        ) piv
        order by rowid'
  exec(@query)
END
GO

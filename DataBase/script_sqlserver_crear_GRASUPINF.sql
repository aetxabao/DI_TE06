/*
** GRASUPINF
*/

SET NOCOUNT ON
GO
USE master
GO
if exists (select * from sysdatabases where name='GRASUPINF')
		drop database GRASUPINF
go

DECLARE @device_directory NVARCHAR(520)
SELECT @device_directory = SUBSTRING(filename, 1, CHARINDEX(N'master.mdf', LOWER(filename)) - 1)
FROM master.dbo.sysaltfiles WHERE dbid = 1 AND fileid = 1

EXECUTE (N'CREATE DATABASE GRASUPINF
  ON PRIMARY (NAME = N''GRASUPINF'', FILENAME = N''' + @device_directory + N'grasupinf.mdf'')
  LOG ON (NAME = N''GRASUPINF_log'',  FILENAME = N''' + @device_directory + N'grasupinf.ldf'')')
go

if CAST(SERVERPROPERTY('ProductMajorVersion') AS INT)<12 
BEGIN
  exec sp_dboption 'GRASUPINF','trunc. log on chkpt.','true'
  exec sp_dboption 'GRASUPINF','select into/bulkcopy','true'
END
ELSE ALTER DATABASE [GRASUPINF] SET RECOVERY SIMPLE WITH NO_WAIT
GO

set quoted_identifier on
GO
/****** Database [GRASUPINF] ******/
USE [GRASUPINF]
GO
/****** Object:  Table [dbo].[docentes] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[docentes](
	[id] [numeric](18, 0) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[apellidos] [nvarchar](50) NOT NULL,
	[fechaInicio] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_docentes] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[estudiantes] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[estudiantes](
	[id] [numeric](18, 0) NOT NULL,
	[nombre] [nvarchar](50) NOT NULL,
	[apellidos] [nvarchar](50) NOT NULL,
	[ciclo] [nvarchar](50) NOT NULL,
	[curso] [int] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[imparte] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[imparte](
	[id] [numeric](18, 0) NOT NULL,
	[idDocente] [numeric](18, 0) NOT NULL,
	[idModulo] [numeric](18, 0) NOT NULL,
 CONSTRAINT [PK_imparte] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[modulos] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[modulos](
	[id] [numeric](18, 0) NOT NULL,
	[ciclo] [nvarchar](50) NOT NULL,
	[curso] [int] NOT NULL,
	[codigo] [int] NOT NULL,
	[siglas] [nvarchar](50) NOT NULL,
	[nombre] [nvarchar](100) NOT NULL,
	[horasTotales] [int] NOT NULL,
	[horasSemanales] [int] NOT NULL,
 CONSTRAINT [PK_modulos] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[notas] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[notas](
	[id] [numeric](18, 0) NOT NULL,
	[idModulo] [numeric](18, 0) NOT NULL,
	[idEstudiante] [numeric](18, 0) NOT NULL,
	[valor] [int] NOT NULL,
 CONSTRAINT [PK_notas] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
USE [master]
GO
ALTER DATABASE [GRASUPINF] SET  READ_WRITE 
GO
USE [GRASUPINF]
GO
/****** Insert:  Table [dbo].[modulos] ******/
INSERT INTO [dbo].[modulos] (id,ciclo,curso,codigo,siglas,nombre,horasTotales,horasSemanales) VALUES
	 (1,N'ASIR',1,369,N'IMSO',N'Implantación de sistemas operativos',200,6),
	 (2,N'ASIR',1,370,N'PARE',N'Planificación y administración de redes',200,6),
	 (3,N'ASIR',1,371,N'FUHA',N'Fundamentos de hardware',120,4),
	 (4,N'ASIR',1,372,N'GEBD',N'Gestión de bases de datos',200,6),
	 (5,N'ASIR',1,373,N'LMGI',N'Lenguajes de marcas y sistemas de gestión de información',120,4),
	 (6,N'ASIR',1,1001,N'ING1',N'Inglés I',60,2),
	 (7,N'ASIR',1,381,N'EMIE',N'Empresa e iniciativa emprendedora',60,2),
	 (8,N'ASIR',2,374,N'ADSO',N'Administración de sistemas operativos',150,7),
	 (9,N'ASIR',2,375,N'SERI',N'Servicios de red e Internet',130,6),
	 (10,N'ASIR',2,376,N'IAWE',N'Implantación de aplicaciones web',110,5);
INSERT INTO [dbo].[modulos] (id,ciclo,curso,codigo,siglas,nombre,horasTotales,horasSemanales) VALUES
	 (11,N'ASIR',2,377,N'ADBD',N'Administración de sistemas gestores de bases de datos',70,3),
	 (12,N'ASIR',2,378,N'SEAD',N'Seguridad y alta disponibilidad',110,5),
	 (13,N'ASIR',2,380,N'FOLA',N'Formación y orientación laboral',90,4),
	 (14,N'ASIR',2,379,N'PROY',N'Proyecto de administración de sistemas informáticos en red',30,0),
	 (15,N'ASIR',2,382,N'FCET',N'Formación en centros de trabajo',350,0),
	 (16,N'DAM',1,483,N'SIIN',N'Sistemas informáticos',200,6),
	 (17,N'DAM',1,484,N'BADA',N'Bases de datos',160,5),
	 (18,N'DAM',1,485,N'PROG',N'Programación',260,8),
	 (19,N'DAM',1,373,N'LMGI',N'Lenguajes de marcas y sistemas de gestión de información',120,4),
	 (20,N'DAM',1,487,N'ENDE',N'Entornos de desarrollo',100,3);
INSERT INTO [dbo].[modulos] (id,ciclo,curso,codigo,siglas,nombre,horasTotales,horasSemanales) VALUES
	 (21,N'DAM',1,494,N'EMIE',N'Empresa e iniciativa emprendedora',60,2),
	 (22,N'DAM',1,1001,N'ING1',N'Inglés I',60,2),
	 (23,N'DAM',2,486,N'ACDA',N'Acceso a datos',90,4),
	 (24,N'DAM',2,488,N'DEIN',N'Desarrollo de interfaces',130,6),
	 (25,N'DAM',2,489,N'PMDM',N'Programación multimedia y dispositivos móviles',70,3),
	 (26,N'DAM',2,490,N'PSEP',N'Programación de servicios y procesos',40,2),
	 (27,N'DAM',2,491,N'SGEM',N'Sistemas de gestión empresarial',110,5),
	 (28,N'DAM',2,493,N'FOLA',N'Formación y orientación laboral',90,4),
	 (29,N'DAM',2,1002,N'ING2',N'Inglés II',40,2),
	 (30,N'DAM',2,1000,N'DEWE',N'Desarrollo web',90,4);
INSERT INTO [dbo].[modulos] (id,ciclo,curso,codigo,siglas,nombre,horasTotales,horasSemanales) VALUES
	 (31,N'DAM',2,492,N'PROY',N'Proyecto de desarrollo de aplicaciones multiplataforma',30,0),
	 (32,N'DAM',2,495,N'FCET',N'Formación en centros de trabajo',350,0),
	 (33,N'DAW',1,483,N'SIIN',N'Sistemas informáticos',200,6),
	 (34,N'DAW',1,484,N'BADA',N'Bases de datos',160,5),
	 (35,N'DAW',1,485,N'PROG',N'Programación',260,8),
	 (36,N'DAW',1,373,N'LMGI',N'Lenguajes de marcas y sistemas de gestión de información',120,4),
	 (37,N'DAW',1,487,N'ENDE',N'Entornos de desarrollo',100,3),
	 (38,N'DAW',1,618,N'EMIE',N'Empresa e iniciativa emprendedora',60,2),
	 (39,N'DAW',1,1001,N'ING1',N'Inglés I',60,2),
	 (40,N'DAW',2,612,N'DWEC',N'Desarrollo web en entorno cliente',150,7);
INSERT INTO [dbo].[modulos] (id,ciclo,curso,codigo,siglas,nombre,horasTotales,horasSemanales) VALUES
	 (41,N'DAW',2,613,N'DWES',N'Desarrollo web en entorno servidor',150,7),
	 (42,N'DAW',2,614,N'DAWE',N'Despliegue de aplicaciones web',90,4),
	 (43,N'DAW',2,615,N'DIWE',N'Diseño de interfaces web',130,6),
	 (44,N'DAW',2,617,N'FOLA',N'Formación y orientación laboral',90,4),
	 (45,N'DAW',2,1002,N'ING2',N'Inglés II',40,2),
	 (46,N'DAW',2,616,N'PROY',N'Proyecto de desarrollo de aplicaciones web',30,0),
	 (47,N'DAW',2,619,N'FCET',N'Formación en centros de trabajo',360,0);
/****** Insert:  Table [dbo].[docentes] ******/
INSERT INTO docentes (id,nombre,apellidos,fechaInicio) VALUES
	 (1,N'Aitor',N'García','2008-09-01 00:00:00.0000000'),
	 (2,N'Laura',N'Larralde','2021-09-01 00:00:00.0000000'),
	 (3,N'Mikel',N'Puy','2013-09-01 00:00:00.0000000'),
	 (4,N'Santi',N'Eseberri','2022-09-01 00:00:00.0000000'),
	 (5,N'Miren',N'Iturralde','2011-09-01 00:00:00.0000000'),
	 (6,N'Idoia',N'Nuñez','2005-09-01 00:00:00.0000000'),
	 (7,N'Ion',N'Perez','2007-09-01 00:00:00.0000000'),
	 (8,N'Karmen',N'Ruiz','2008-09-01 00:00:00.0000000'),
	 (9,N'Iñigo',N'Lizaso','2008-09-01 00:00:00.0000000'),
	 (10,N'Maite',N'Santesteban','2009-09-01 00:00:00.0000000');
INSERT INTO docentes (id,nombre,apellidos,fechaInicio) VALUES
	 (11,N'Silvia',N'Soto','2014-09-01 00:00:00.0000000'),
	 (12,N'Ibai',N'Elizalde','2008-09-01 00:00:00.0000000'),
	 (13,N'Nerea',N'Zubieta','2009-09-01 00:00:00.0000000'),
	 (14,N'Andrea',N'Ibaialde','2014-09-01 00:00:00.0000000'),
	 (15,N'Patxi',N'Aldekoa','2013-09-01 00:00:00.0000000');
/****** Insert:  Table [dbo].[imparte] ******/
INSERT INTO imparte (id,idDocente,idModulo) VALUES
	 (1,1,1),
	 (2,1,2),
	 (3,1,3),
	 (4,2,4),
	 (5,3,5),
	 (6,6,6),
	 (7,8,7),
	 (8,3,8),
	 (9,8,9),
	 (10,8,10);
INSERT INTO imparte (id,idDocente,idModulo) VALUES
	 (11,2,11),
	 (12,3,12),
	 (13,9,13),
	 (14,3,14),
	 (15,3,15),
	 (16,10,16),
	 (17,13,17),
	 (18,4,18),
	 (19,4,19),
	 (20,5,20);
INSERT INTO imparte (id,idDocente,idModulo) VALUES
	 (21,12,21),
	 (22,6,22),
	 (23,11,23),
	 (24,12,24),
	 (25,11,25),
	 (26,12,26),
	 (27,10,27),
	 (28,9,28),
	 (29,6,29),
	 (30,12,30);
INSERT INTO imparte (id,idDocente,idModulo) VALUES
	 (31,11,31),
	 (32,9,32),
	 (33,10,33),
	 (34,2,34),
	 (35,5,35),
	 (36,4,36),
	 (37,5,37),
	 (38,15,38),
	 (39,7,39),
	 (40,13,40);
INSERT INTO imparte (id,idDocente,idModulo) VALUES
	 (41,15,41),
	 (42,14,42),
	 (43,14,43),
	 (44,9,44),
	 (45,7,45),
	 (46,13,46),
	 (47,14,47);
/****** Insert:  Table [dbo].[estudiantes] ******/
INSERT INTO estudiantes (id,nombre,apellidos,ciclo,curso) VALUES
	 (1,N'Liam',N'Shields',N'ASIR',1),
	 (2,N'Marissa',N'Mills',N'ASIR',1),
	 (3,N'Johnny',N'Fall',N'ASIR',1),
	 (4,N'Moira',N'Flanders',N'ASIR',1),
	 (5,N'Marina',N'Wills',N'ASIR',1),
	 (6,N'Regina',N'Glynn',N'ASIR',1),
	 (7,N'Ruby',N'Yoman',N'ASIR',1),
	 (8,N'Harriet',N'Broomfield',N'ASIR',1),
	 (9,N'Janice',N'Redwood',N'ASIR',1),
	 (10,N'Phillip',N'Fleming',N'ASIR',1);
INSERT INTO estudiantes (id,nombre,apellidos,ciclo,curso) VALUES
	 (11,N'William',N'Sanchez',N'ASIR',1),
	 (12,N'Rita',N'Beal',N'ASIR',1),
	 (13,N'Bart',N'Wild',N'ASIR',1),
	 (14,N'Rocco',N'Stewart',N'ASIR',1),
	 (15,N'Payton',N'Simpson',N'ASIR',1),
	 (16,N'Alice',N'Mason',N'ASIR',1),
	 (17,N'Ruby',N'Lloyd',N'ASIR',1),
	 (18,N'Blake',N'Webster',N'ASIR',1),
	 (19,N'Gabriel',N'Latham',N'ASIR',1),
	 (20,N'Rick',N'Ellery',N'ASIR',1);
INSERT INTO estudiantes (id,nombre,apellidos,ciclo,curso) VALUES
	 (21,N'Peter',N'Wilde',N'ASIR',1),
	 (22,N'Cameron',N'Shelton',N'ASIR',1),
	 (23,N'Ronald',N'Pond',N'ASIR',1),
	 (24,N'Adelaide',N'Dann',N'ASIR',1),
	 (25,N'Julian',N'Edley',N'ASIR',1),
	 (26,N'Angela',N'Irwin',N'ASIR',2),
	 (27,N'Russel',N'Cavanagh',N'ASIR',2),
	 (28,N'Tyler',N'Shaw',N'ASIR',2),
	 (29,N'Ada',N'Mcleod',N'ASIR',2),
	 (30,N'Roger',N'Price',N'ASIR',2);
INSERT INTO estudiantes (id,nombre,apellidos,ciclo,curso) VALUES
	 (31,N'Caleb',N'Shields',N'ASIR',2),
	 (32,N'Adeline',N'Stone ',N'ASIR',2),
	 (33,N'Alexander',N'Redden',N'ASIR',2),
	 (34,N'Jackeline',N'Darcy',N'ASIR',2),
	 (35,N'Mike',N'Fox',N'ASIR',2),
	 (36,N'Sebastian',N'Faulkner',N'ASIR',2),
	 (37,N'Kurt',N'Upton',N'ASIR',2),
	 (38,N'Cedrick',N'Redwood',N'ASIR',2),
	 (39,N'Madelyn',N'Bright',N'ASIR',2),
	 (40,N'Jack',N'Hale',N'ASIR',2);
INSERT INTO estudiantes (id,nombre,apellidos,ciclo,curso) VALUES
	 (41,N'Dakota',N'Preston',N'ASIR',2),
	 (42,N'Keira',N'Dickson',N'ASIR',2),
	 (43,N'Jamie',N'Butler',N'ASIR',2),
	 (44,N'Peter',N'Silva',N'ASIR',2),
	 (45,N'Leilani',N'Styles',N'ASIR',2),
	 (46,N'Enoch',N'Hale',N'ASIR',2),
	 (47,N'Kaylee',N'Anderson',N'ASIR',2),
	 (48,N'Daniel',N'Nanton',N'ASIR',2),
	 (49,N'Chloe',N'Kelly',N'ASIR',2),
	 (50,N'Nick',N'Horton',N'ASIR',2);
INSERT INTO estudiantes (id,nombre,apellidos,ciclo,curso) VALUES
	 (51,N'Rick',N'Addley',N'DAM',1),
	 (52,N'John',N'Jordan',N'DAM',1),
	 (53,N'Alba',N'Johnson',N'DAM',1),
	 (54,N'Cassandra',N'Moran',N'DAM',1),
	 (55,N'Kendra',N'Phillips',N'DAM',1),
	 (56,N'Noah',N'Harper',N'DAM',1),
	 (57,N'Candace',N'Gallacher',N'DAM',1),
	 (58,N'Dasha',N'Warren',N'DAM',1),
	 (59,N'Bart',N'Harper',N'DAM',1),
	 (60,N'Mason',N'Lunt',N'DAM',1);
INSERT INTO estudiantes (id,nombre,apellidos,ciclo,curso) VALUES
	 (61,N'Daron',N'Utterson',N'DAM',1),
	 (62,N'Eryn',N'Rowe',N'DAM',1),
	 (63,N'Wade',N'Veale',N'DAM',1),
	 (64,N'Michaela',N'Connor',N'DAM',1),
	 (65,N'Mike',N'Saunders',N'DAM',1),
	 (66,N'Manuel',N'Rigg',N'DAM',1),
	 (67,N'Laila',N'Vernon',N'DAM',1),
	 (68,N'Ron',N'Ross',N'DAM',1),
	 (69,N'Abdul',N'Thomson',N'DAM',1),
	 (70,N'Doug',N'Kelly',N'DAM',1);
INSERT INTO estudiantes (id,nombre,apellidos,ciclo,curso) VALUES
	 (71,N'Noah',N'York',N'DAM',1),
	 (72,N'Gina',N'Funnell',N'DAM',1),
	 (73,N'Peter',N'Warden',N'DAM',1),
	 (74,N'David',N'Sylvester',N'DAM',1),
	 (75,N'Ethan',N'Noach',N'DAM',1),
	 (76,N'Charlotte',N'Thorpe',N'DAM',2),
	 (77,N'Hayden',N'Harrison',N'DAM',2),
	 (78,N'Phillip',N'Osmond',N'DAM',2),
	 (79,N'Madison',N'Chapman',N'DAM',2),
	 (80,N'Tyler',N'Irving',N'DAM',2);
INSERT INTO estudiantes (id,nombre,apellidos,ciclo,curso) VALUES
	 (81,N'Harmony',N'Ainsworth',N'DAM',2),
	 (82,N'Barney',N'Horton',N'DAM',2),
	 (83,N'Erick',N'Bailey',N'DAM',2),
	 (84,N'Ryan',N'Lindop',N'DAM',2),
	 (85,N'Emely',N'Anderson',N'DAM',2),
	 (86,N'Stephanie',N'Ingham',N'DAM',2),
	 (87,N'Henry',N'Spencer',N'DAM',2),
	 (88,N'Macy',N'Lewis',N'DAM',2),
	 (89,N'Adalind',N'Parr',N'DAM',2),
	 (90,N'Matt',N'Anderson',N'DAM',2);
INSERT INTO estudiantes (id,nombre,apellidos,ciclo,curso) VALUES
	 (91,N'Carmen',N'Bright',N'DAM',2),
	 (92,N'Rachael',N'Lambert',N'DAM',2),
	 (93,N'Rosalyn',N'Gregory',N'DAM',2),
	 (94,N'Samara',N'Cattell',N'DAM',2),
	 (95,N'Domenic',N'Palmer',N'DAM',2),
	 (96,N'Eileen',N'Bryson',N'DAM',2),
	 (97,N'Rihanna',N'Cobb',N'DAM',2),
	 (98,N'Elly',N'Mackenzie',N'DAM',2),
	 (99,N'Percy',N'Pierce',N'DAM',2),
	 (100,N'Amelia',N'Veale',N'DAM',2);
INSERT INTO estudiantes (id,nombre,apellidos,ciclo,curso) VALUES
	 (101,N'Eryn',N'Fox',N'DAW',1),
	 (102,N'Noah',N'Page ',N'DAW',1),
	 (103,N'Carter',N'Gray',N'DAW',1),
	 (104,N'Benjamin',N'Plumb',N'DAW',1),
	 (105,N'Carrie',N'Nanton',N'DAW',1),
	 (106,N'Mary',N'Dubois',N'DAW',1),
	 (107,N'Alexa',N'Edwards',N'DAW',1),
	 (108,N'Maya',N'Tyler',N'DAW',1),
	 (109,N'Josh',N'Morris',N'DAW',1),
	 (110,N'Laila',N'Taylor',N'DAW',1);
INSERT INTO estudiantes (id,nombre,apellidos,ciclo,curso) VALUES
	 (111,N'Sebastian',N'Sawyer',N'DAW',1),
	 (112,N'Nicholas',N'Robinson',N'DAW',1),
	 (113,N'Hank',N'Owen',N'DAW',1),
	 (114,N'Hayden',N'Brett',N'DAW',1),
	 (115,N'Kenzie',N'Cooper',N'DAW',1),
	 (116,N'Julian',N'Hudson',N'DAW',1),
	 (117,N'Benny',N'Edwards',N'DAW',1),
	 (118,N'Florence',N'Dyson',N'DAW',1),
	 (119,N'Benjamin',N'Harvey',N'DAW',1),
	 (120,N'Deborah',N'Utterson',N'DAW',1);
INSERT INTO estudiantes (id,nombre,apellidos,ciclo,curso) VALUES
	 (121,N'Camila',N'Thorne',N'DAW',1),
	 (122,N'Audrey',N'Penn',N'DAW',1),
	 (123,N'Sage',N'Oldfield',N'DAW',1),
	 (124,N'Liam',N'Murphy',N'DAW',1),
	 (125,N'Mike',N'Gilmore',N'DAW',1),
	 (126,N'Mara',N'Franks',N'DAW',2),
	 (127,N'Isla',N'Morris',N'DAW',2),
	 (128,N'Abdul',N'Kelly',N'DAW',2),
	 (129,N'Elise',N'Sheldon',N'DAW',2),
	 (130,N'Elly',N'Stevens',N'DAW',2);
INSERT INTO estudiantes (id,nombre,apellidos,ciclo,curso) VALUES
	 (131,N'Jacqueline',N'Seymour',N'DAW',2),
	 (132,N'Rosemary',N'Judd',N'DAW',2),
	 (133,N'Havana',N'Sylvester',N'DAW',2),
	 (134,N'Adela',N'Higgs',N'DAW',2),
	 (135,N'Eve',N'Walter',N'DAW',2),
	 (136,N'Ronald',N'Andrews',N'DAW',2),
	 (137,N'Hank',N'Ellis',N'DAW',2),
	 (138,N'Boris',N'Becker',N'DAW',2),
	 (139,N'Erica',N'Garcia',N'DAW',2),
	 (140,N'Rocco',N'Chester',N'DAW',2);
INSERT INTO estudiantes (id,nombre,apellidos,ciclo,curso) VALUES
	 (141,N'Lauren',N'Mills',N'DAW',2),
	 (142,N'Johnny',N'Yoman',N'DAW',2),
	 (143,N'Erick',N'Kent',N'DAW',2),
	 (144,N'Doug',N'Mould',N'DAW',2),
	 (145,N'William',N'Gibson',N'DAW',2),
	 (146,N'Sebastian',N'Howard',N'DAW',2),
	 (147,N'Claire',N'Ellison',N'DAW',2),
	 (148,N'Isla',N'Noon',N'DAW',2),
	 (149,N'Gloria',N'Veale',N'DAW',2),
	 (150,N'Tiffany',N'Stone',N'DAW',2);
/****** Insert:  Table [dbo].[notas] ******/
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (1,1,1,5),
	 (2,1,2,6),
	 (3,1,3,2),
	 (4,1,4,5),
	 (5,1,5,1),
	 (6,1,6,2),
	 (7,1,7,2),
	 (8,1,8,6),
	 (9,1,9,3),
	 (10,1,10,7);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (11,1,11,3),
	 (12,1,12,4),
	 (13,1,13,5),
	 (14,1,14,5),
	 (15,1,15,5),
	 (16,1,16,5),
	 (17,1,17,5),
	 (18,1,18,5),
	 (19,1,19,5),
	 (20,1,20,1);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (21,1,21,5),
	 (22,1,22,8),
	 (23,1,23,5),
	 (24,1,24,3),
	 (25,1,25,4),
	 (26,2,1,5),
	 (27,2,2,4),
	 (28,2,3,5),
	 (29,2,4,4),
	 (30,2,5,6);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (31,2,6,7),
	 (32,2,7,3),
	 (33,2,8,2),
	 (34,2,9,5),
	 (35,2,10,6),
	 (36,2,11,2),
	 (37,2,12,8),
	 (38,2,13,5),
	 (39,2,14,4),
	 (40,2,15,0);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (41,2,16,5),
	 (42,2,17,5),
	 (43,2,18,5),
	 (44,2,19,5),
	 (45,2,20,5),
	 (46,2,21,1),
	 (47,2,22,6),
	 (48,2,23,0),
	 (49,2,24,9),
	 (50,2,25,4);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (51,3,1,5),
	 (52,3,2,4),
	 (53,3,3,5),
	 (54,3,4,6),
	 (55,3,5,3),
	 (56,3,6,5),
	 (57,3,7,5),
	 (58,3,8,7),
	 (59,3,9,10),
	 (60,3,10,2);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (61,3,11,6),
	 (62,3,12,4),
	 (63,3,13,5),
	 (64,3,14,3),
	 (65,3,15,5),
	 (66,3,16,5),
	 (67,3,17,5),
	 (68,3,18,5),
	 (69,3,19,4),
	 (70,3,20,6);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (71,3,21,5),
	 (72,3,22,0),
	 (73,3,23,3),
	 (74,3,24,7),
	 (75,3,25,5),
	 (76,4,1,5),
	 (77,4,2,6),
	 (78,4,3,5),
	 (79,4,4,4),
	 (80,4,5,8);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (81,4,6,8),
	 (82,4,7,4),
	 (83,4,8,3),
	 (84,4,9,4),
	 (85,4,10,3),
	 (86,4,11,1),
	 (87,4,12,5),
	 (88,4,13,5),
	 (89,4,14,5),
	 (90,4,15,8);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (91,4,16,5),
	 (92,4,17,8),
	 (93,4,18,5),
	 (94,4,19,6),
	 (95,4,20,6),
	 (96,4,21,3),
	 (97,4,22,7),
	 (98,4,23,4),
	 (99,4,24,5),
	 (100,4,25,4);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (101,5,1,5),
	 (102,5,2,6),
	 (103,5,3,7),
	 (104,5,4,3),
	 (105,5,5,5),
	 (106,5,6,5),
	 (107,5,7,4),
	 (108,5,8,5),
	 (109,5,9,6),
	 (110,5,10,5);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (111,5,11,7),
	 (112,5,12,3),
	 (113,5,13,5),
	 (114,5,14,5),
	 (115,5,15,3),
	 (116,5,16,5),
	 (117,5,17,4),
	 (118,5,18,5),
	 (119,5,19,2),
	 (120,5,20,5);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (121,5,21,5),
	 (122,5,22,5),
	 (123,5,23,4),
	 (124,5,24,1),
	 (125,5,25,6),
	 (126,6,1,5),
	 (127,6,2,10),
	 (128,6,3,4),
	 (129,6,4,9),
	 (130,6,5,4);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (131,6,6,2),
	 (132,6,7,6),
	 (133,6,8,6),
	 (134,6,9,7),
	 (135,6,10,5),
	 (136,6,11,4),
	 (137,6,12,4),
	 (138,6,13,5),
	 (139,6,14,3),
	 (140,6,15,4);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (141,6,16,5),
	 (142,6,17,5),
	 (143,6,18,5),
	 (144,6,19,5),
	 (145,6,20,7),
	 (146,6,21,6),
	 (147,6,22,2),
	 (148,6,23,6),
	 (149,6,24,6),
	 (150,6,25,2);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (151,7,1,5),
	 (152,7,2,5),
	 (153,7,3,4),
	 (154,7,4,6),
	 (155,7,5,5),
	 (156,7,6,5),
	 (157,7,7,5),
	 (158,7,8,5),
	 (159,7,9,5),
	 (160,7,10,2);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (161,7,11,5),
	 (162,7,12,5),
	 (163,7,13,4),
	 (164,7,14,4),
	 (165,7,15,5),
	 (166,7,16,7),
	 (167,7,17,5),
	 (168,7,18,3),
	 (169,7,19,5),
	 (170,7,20,5);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (171,7,21,5),
	 (172,7,22,5),
	 (173,7,23,5),
	 (174,7,24,7),
	 (175,7,25,6),
	 (176,8,26,5),
	 (177,8,27,6),
	 (178,8,28,6),
	 (179,8,29,8),
	 (180,8,30,5);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (181,8,31,5),
	 (182,8,32,5),
	 (183,8,33,5),
	 (184,8,34,8),
	 (185,8,35,6),
	 (186,8,36,5),
	 (187,8,37,5),
	 (188,8,38,2),
	 (189,8,39,10),
	 (190,8,40,5);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (191,8,41,6),
	 (192,8,42,5),
	 (193,8,43,5),
	 (194,8,44,5),
	 (195,8,45,4),
	 (196,8,46,5),
	 (197,8,47,3),
	 (198,8,48,4),
	 (199,8,49,4),
	 (200,8,50,5);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (201,9,26,5),
	 (202,9,27,3),
	 (203,9,28,7),
	 (204,9,29,5),
	 (205,9,30,5),
	 (206,9,31,5),
	 (207,9,32,5),
	 (208,9,33,5),
	 (209,9,34,6),
	 (210,9,35,4);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (211,9,36,5),
	 (212,9,37,5),
	 (213,9,38,6),
	 (214,9,39,4),
	 (215,9,40,5),
	 (216,9,41,6),
	 (217,9,42,5),
	 (218,9,43,5),
	 (219,9,44,5),
	 (220,9,45,6);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (221,9,46,5),
	 (222,9,47,9),
	 (223,9,48,6),
	 (224,9,49,6),
	 (225,9,50,6),
	 (226,10,26,5),
	 (227,10,27,6),
	 (228,10,28,5),
	 (229,10,29,7),
	 (230,10,30,5);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (231,10,31,5),
	 (232,10,32,5),
	 (233,10,33,5),
	 (234,10,34,5),
	 (235,10,35,6),
	 (236,10,36,5),
	 (237,10,37,5),
	 (238,10,38,5),
	 (239,10,39,7),
	 (240,10,40,5);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (241,10,41,7),
	 (242,10,42,5),
	 (243,10,43,8),
	 (244,10,44,5),
	 (245,10,45,8),
	 (246,10,46,5),
	 (247,10,47,5),
	 (248,10,48,6),
	 (249,10,49,8),
	 (250,10,50,5);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (251,11,26,5),
	 (252,11,27,4),
	 (253,11,28,6),
	 (254,11,29,1),
	 (255,11,30,5),
	 (256,11,31,5),
	 (257,11,32,5),
	 (258,11,33,5),
	 (259,11,34,4),
	 (260,11,35,9);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (261,11,36,5),
	 (262,11,37,5),
	 (263,11,38,5),
	 (264,11,39,3),
	 (265,11,40,5),
	 (266,11,41,5),
	 (267,11,42,5),
	 (268,11,43,3),
	 (269,11,44,5),
	 (270,11,45,5);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (271,11,46,5),
	 (272,11,47,3),
	 (273,11,48,4),
	 (274,11,49,9),
	 (275,11,50,3),
	 (276,12,26,5),
	 (277,12,27,5),
	 (278,12,28,0),
	 (279,12,29,5),
	 (280,12,30,5);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (281,12,31,5),
	 (282,12,32,5),
	 (283,12,33,5),
	 (284,12,34,5),
	 (285,12,35,5),
	 (286,12,36,5),
	 (287,12,37,5),
	 (288,12,38,7),
	 (289,12,39,4),
	 (290,12,40,5);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (291,12,41,1),
	 (292,12,42,5),
	 (293,12,43,6),
	 (294,12,44,5),
	 (295,12,45,0),
	 (296,12,46,5),
	 (297,12,47,4),
	 (298,12,48,3),
	 (299,12,49,2),
	 (300,12,50,7);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (301,13,26,5),
	 (302,13,27,6),
	 (303,13,28,4),
	 (304,13,29,4),
	 (305,13,30,5),
	 (306,13,31,5),
	 (307,13,32,5),
	 (308,13,33,5),
	 (309,13,34,9),
	 (310,13,35,5);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (311,13,36,5),
	 (312,13,37,5),
	 (313,13,38,7),
	 (314,13,39,5),
	 (315,13,40,5),
	 (316,13,41,5),
	 (317,13,42,5),
	 (318,13,43,4),
	 (319,13,44,5),
	 (320,13,45,6);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (321,13,46,5),
	 (322,13,47,6),
	 (323,13,48,6),
	 (324,13,49,5),
	 (325,13,50,4),
	 (326,14,26,5),
	 (327,14,27,2),
	 (328,14,28,3),
	 (329,14,29,2),
	 (330,14,30,5);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (331,14,31,5),
	 (332,14,32,5),
	 (333,14,33,5),
	 (334,14,34,6),
	 (335,14,35,7),
	 (336,14,36,5),
	 (337,14,37,5),
	 (338,14,38,4),
	 (339,14,39,5),
	 (340,14,40,5);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (341,14,41,4),
	 (342,14,42,5),
	 (343,14,43,5),
	 (344,14,44,5),
	 (345,14,45,5),
	 (346,14,46,5),
	 (347,14,47,4),
	 (348,14,48,7),
	 (349,14,49,4),
	 (350,14,50,5);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (351,15,26,5),
	 (352,15,27,3),
	 (353,15,28,6),
	 (354,15,29,2),
	 (355,15,30,5),
	 (356,15,31,5),
	 (357,15,32,5),
	 (358,15,33,5),
	 (359,15,34,5),
	 (360,15,35,5);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (361,15,36,5),
	 (362,15,37,5),
	 (363,15,38,4),
	 (364,15,39,5),
	 (365,15,40,5),
	 (366,15,41,5),
	 (367,15,42,5),
	 (368,15,43,1),
	 (369,15,44,5),
	 (370,15,45,5);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (371,15,46,5),
	 (372,15,47,5),
	 (373,15,48,1),
	 (374,15,49,6),
	 (375,15,50,2),
	 (376,16,51,1),
	 (377,16,52,5),
	 (378,16,53,9),
	 (379,16,54,5),
	 (380,16,55,5);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (381,16,56,5),
	 (382,16,57,5),
	 (383,16,58,4),
	 (384,16,59,5),
	 (385,16,60,6),
	 (386,16,61,3),
	 (387,16,62,8),
	 (388,16,63,2),
	 (389,16,64,5),
	 (390,16,65,5);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (391,16,66,3),
	 (392,16,67,2),
	 (393,16,68,6),
	 (394,16,69,4),
	 (395,16,70,2),
	 (396,16,71,6),
	 (397,16,72,1),
	 (398,16,73,5),
	 (399,16,74,5),
	 (400,16,75,5);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (401,17,51,2),
	 (402,17,52,6),
	 (403,17,53,4),
	 (404,17,54,5),
	 (405,17,55,5),
	 (406,17,56,5),
	 (407,17,57,3),
	 (408,17,58,3),
	 (409,17,59,5),
	 (410,17,60,5);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (411,17,61,6),
	 (412,17,62,8),
	 (413,17,63,1),
	 (414,17,64,5),
	 (415,17,65,4),
	 (416,17,66,6),
	 (417,17,67,5),
	 (418,17,68,6),
	 (419,17,69,5),
	 (420,17,70,8);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (421,17,71,6),
	 (422,17,72,6),
	 (423,17,73,5),
	 (424,17,74,5),
	 (425,17,75,5),
	 (426,18,51,5),
	 (427,18,52,6),
	 (428,18,53,4),
	 (429,18,54,5),
	 (430,18,55,3);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (431,18,56,5),
	 (432,18,57,5),
	 (433,18,58,6),
	 (434,18,59,5),
	 (435,18,60,6),
	 (436,18,61,7),
	 (437,18,62,3),
	 (438,18,63,5),
	 (439,18,64,8),
	 (440,18,65,4);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (441,18,66,5),
	 (442,18,67,5),
	 (443,18,68,2),
	 (444,18,69,3),
	 (445,18,70,3),
	 (446,18,71,5),
	 (447,18,72,5),
	 (448,18,73,5),
	 (449,18,74,5),
	 (450,18,75,5);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (451,19,51,7),
	 (452,19,52,1),
	 (453,19,53,4),
	 (454,19,54,5),
	 (455,19,55,3),
	 (456,19,56,5),
	 (457,19,57,7),
	 (458,19,58,6),
	 (459,19,59,5),
	 (460,19,60,6);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (461,19,61,5),
	 (462,19,62,4),
	 (463,19,63,7),
	 (464,19,64,6),
	 (465,19,65,7),
	 (466,19,66,6),
	 (467,19,67,3),
	 (468,19,68,3),
	 (469,19,69,6),
	 (470,19,70,4);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (471,19,71,7),
	 (472,19,72,3),
	 (473,19,73,5),
	 (474,19,74,5),
	 (475,19,75,5),
	 (476,20,51,6),
	 (477,20,52,8),
	 (478,20,53,5),
	 (479,20,54,5),
	 (480,20,55,4);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (481,20,56,5),
	 (482,20,57,6),
	 (483,20,58,5),
	 (484,20,59,5),
	 (485,20,60,4),
	 (486,20,61,6),
	 (487,20,62,5),
	 (488,20,63,6),
	 (489,20,64,5),
	 (490,20,65,2);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (491,20,66,5),
	 (492,20,67,4),
	 (493,20,68,5),
	 (494,20,69,3),
	 (495,20,70,6),
	 (496,20,71,9),
	 (497,20,72,4),
	 (498,20,73,5),
	 (499,20,74,5),
	 (500,20,75,5);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (501,21,51,4),
	 (502,21,52,1),
	 (503,21,53,6),
	 (504,21,54,5),
	 (505,21,55,8),
	 (506,21,56,5),
	 (507,21,57,4),
	 (508,21,58,5),
	 (509,21,59,5),
	 (510,21,60,7);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (511,21,61,2),
	 (512,21,62,4),
	 (513,21,63,4),
	 (514,21,64,3),
	 (515,21,65,6),
	 (516,21,66,6),
	 (517,21,67,2),
	 (518,21,68,5),
	 (519,21,69,6),
	 (520,21,70,2);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (521,21,71,6),
	 (522,21,72,5),
	 (523,21,73,5),
	 (524,21,74,5),
	 (525,21,75,5),
	 (526,22,51,4),
	 (527,22,52,9),
	 (528,22,53,6),
	 (529,22,54,5),
	 (530,22,55,4);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (531,22,56,5),
	 (532,22,57,3),
	 (533,22,58,6),
	 (534,22,59,5),
	 (535,22,60,7),
	 (536,22,61,0),
	 (537,22,62,2),
	 (538,22,63,3),
	 (539,22,64,5),
	 (540,22,65,5);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (541,22,66,2),
	 (542,22,67,9),
	 (543,22,68,4),
	 (544,22,69,3),
	 (545,22,70,8),
	 (546,22,71,3),
	 (547,22,72,6),
	 (548,22,73,5),
	 (549,22,74,5),
	 (550,22,75,5);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (551,23,76,5),
	 (552,23,77,5),
	 (553,23,78,3),
	 (554,23,79,5),
	 (555,23,80,5),
	 (556,23,81,5),
	 (557,23,82,5),
	 (558,23,83,5),
	 (559,23,84,5),
	 (560,23,85,5);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (561,23,86,5),
	 (562,23,87,6),
	 (563,23,88,5),
	 (564,23,89,5),
	 (565,23,90,5),
	 (566,23,91,5),
	 (567,23,92,5),
	 (568,23,93,5),
	 (569,23,94,6),
	 (570,23,95,7);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (571,23,96,5),
	 (572,23,97,6),
	 (573,23,98,5),
	 (574,23,99,5),
	 (575,23,100,5),
	 (576,24,76,5),
	 (577,24,77,5),
	 (578,24,78,5),
	 (579,24,79,5),
	 (580,24,80,5);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (581,24,81,5),
	 (582,24,82,5),
	 (583,24,83,5),
	 (584,24,84,5),
	 (585,24,85,5),
	 (586,24,86,5),
	 (587,24,87,6),
	 (588,24,88,5),
	 (589,24,89,5),
	 (590,24,90,5);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (591,24,91,5),
	 (592,24,92,5),
	 (593,24,93,5),
	 (594,24,94,5),
	 (595,24,95,3),
	 (596,24,96,5),
	 (597,24,97,6),
	 (598,24,98,7),
	 (599,24,99,5),
	 (600,24,100,6);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (601,25,76,5),
	 (602,25,77,5),
	 (603,25,78,3),
	 (604,25,79,5),
	 (605,25,80,5),
	 (606,25,81,5),
	 (607,25,82,5),
	 (608,25,83,5),
	 (609,25,84,5),
	 (610,25,85,5);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (611,25,86,5),
	 (612,25,87,7),
	 (613,25,88,5),
	 (614,25,89,5),
	 (615,25,90,5),
	 (616,25,91,5),
	 (617,25,92,5),
	 (618,25,93,5),
	 (619,25,94,2),
	 (620,25,95,5);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (621,25,96,5),
	 (622,25,97,5),
	 (623,25,98,0),
	 (624,25,99,5),
	 (625,25,100,5),
	 (626,26,76,5),
	 (627,26,77,5),
	 (628,26,78,9),
	 (629,26,79,5),
	 (630,26,80,5);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (631,26,81,5),
	 (632,26,82,5),
	 (633,26,83,5),
	 (634,26,84,5),
	 (635,26,85,5),
	 (636,26,86,5),
	 (637,26,87,1),
	 (638,26,88,5),
	 (639,26,89,5),
	 (640,26,90,5);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (641,26,91,5),
	 (642,26,92,5),
	 (643,26,93,5),
	 (644,26,94,8),
	 (645,26,95,6),
	 (646,26,96,5),
	 (647,26,97,6),
	 (648,26,98,3),
	 (649,26,99,5),
	 (650,26,100,4);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (651,27,76,5),
	 (652,27,77,5),
	 (653,27,78,6),
	 (654,27,79,5),
	 (655,27,80,5),
	 (656,27,81,5),
	 (657,27,82,5),
	 (658,27,83,5),
	 (659,27,84,5),
	 (660,27,85,5);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (661,27,86,5),
	 (662,27,87,0),
	 (663,27,88,5),
	 (664,27,89,5),
	 (665,27,90,5),
	 (666,27,91,5),
	 (667,27,92,5),
	 (668,27,93,5),
	 (669,27,94,1),
	 (670,27,95,5);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (671,27,96,5),
	 (672,27,97,5),
	 (673,27,98,6),
	 (674,27,99,5),
	 (675,27,100,5),
	 (676,28,76,5),
	 (677,28,77,5),
	 (678,28,78,5),
	 (679,28,79,0),
	 (680,28,80,5);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (681,28,81,5),
	 (682,28,82,5),
	 (683,28,83,5),
	 (684,28,84,5),
	 (685,28,85,5),
	 (686,28,86,5),
	 (687,28,87,5),
	 (688,28,88,5),
	 (689,28,89,5),
	 (690,28,90,5);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (691,28,91,5),
	 (692,28,92,5),
	 (693,28,93,5),
	 (694,28,94,6),
	 (695,28,95,4),
	 (696,28,96,5),
	 (697,28,97,5),
	 (698,28,98,5),
	 (699,28,99,5),
	 (700,28,100,2);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (701,29,76,5),
	 (702,29,77,5),
	 (703,29,78,8),
	 (704,29,79,6),
	 (705,29,80,5),
	 (706,29,81,5),
	 (707,29,82,5),
	 (708,29,83,5),
	 (709,29,84,5),
	 (710,29,85,5);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (711,29,86,5),
	 (712,29,87,1),
	 (713,29,88,5),
	 (714,29,89,5),
	 (715,29,90,5),
	 (716,29,91,5),
	 (717,29,92,5),
	 (718,29,93,5),
	 (719,29,94,7),
	 (720,29,95,8);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (721,29,96,5),
	 (722,29,97,0),
	 (723,29,98,3),
	 (724,29,99,5),
	 (725,29,100,4),
	 (726,30,76,5),
	 (727,30,77,5),
	 (728,30,78,8),
	 (729,30,79,1),
	 (730,30,80,5);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (731,30,81,5),
	 (732,30,82,5),
	 (733,30,83,5),
	 (734,30,84,5),
	 (735,30,85,5),
	 (736,30,86,5),
	 (737,30,87,5),
	 (738,30,88,5),
	 (739,30,89,5),
	 (740,30,90,5);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (741,30,91,5),
	 (742,30,92,5),
	 (743,30,93,5),
	 (744,30,94,7),
	 (745,30,95,4),
	 (746,30,96,5),
	 (747,30,97,5),
	 (748,30,98,2),
	 (749,30,99,5),
	 (750,30,100,5);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (751,31,76,5),
	 (752,31,77,5),
	 (753,31,78,4),
	 (754,31,79,4),
	 (755,31,80,5),
	 (756,31,81,5),
	 (757,31,82,5),
	 (758,31,83,5),
	 (759,31,84,5),
	 (760,31,85,5);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (761,31,86,5),
	 (762,31,87,7),
	 (763,31,88,5),
	 (764,31,89,5),
	 (765,31,90,5),
	 (766,31,91,5),
	 (767,31,92,5),
	 (768,31,93,5),
	 (769,31,94,3),
	 (770,31,95,5);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (771,31,96,5),
	 (772,31,97,7),
	 (773,31,98,5),
	 (774,31,99,5),
	 (775,31,100,7),
	 (776,32,76,5),
	 (777,32,77,5),
	 (778,32,78,2),
	 (779,32,79,6),
	 (780,32,80,5);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (781,32,81,5),
	 (782,32,82,5),
	 (783,32,83,5),
	 (784,32,84,5),
	 (785,32,85,5),
	 (786,32,86,5),
	 (787,32,87,2),
	 (788,32,88,5),
	 (789,32,89,5),
	 (790,32,90,5);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (791,32,91,5),
	 (792,32,92,5),
	 (793,32,93,5),
	 (794,32,94,3),
	 (795,32,95,3),
	 (796,32,96,5),
	 (797,32,97,6),
	 (798,32,98,6),
	 (799,32,99,5),
	 (800,32,100,7);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (801,33,101,6),
	 (802,33,102,5),
	 (803,33,103,5),
	 (804,33,104,7),
	 (805,33,105,4),
	 (806,33,106,5),
	 (807,33,107,6),
	 (808,33,108,4),
	 (809,33,109,6),
	 (810,33,110,0);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (811,33,111,4),
	 (812,33,112,4),
	 (813,33,113,5),
	 (814,33,114,5),
	 (815,33,115,5),
	 (816,33,116,5),
	 (817,33,117,6),
	 (818,33,118,5),
	 (819,33,119,6),
	 (820,33,120,7);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (821,33,121,7),
	 (822,33,122,7),
	 (823,33,123,6),
	 (824,33,124,2),
	 (825,33,125,7),
	 (826,34,101,3),
	 (827,34,102,5),
	 (828,34,103,5),
	 (829,34,104,4),
	 (830,34,105,7);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (831,34,106,5),
	 (832,34,107,3),
	 (833,34,108,4),
	 (834,34,109,6),
	 (835,34,110,9),
	 (836,34,111,4),
	 (837,34,112,0),
	 (838,34,113,5),
	 (839,34,114,5),
	 (840,34,115,5);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (841,34,116,5),
	 (842,34,117,4),
	 (843,34,118,3),
	 (844,34,119,5),
	 (845,34,120,5),
	 (846,34,121,3),
	 (847,34,122,2),
	 (848,34,123,5),
	 (849,34,124,5),
	 (850,34,125,5);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (851,35,101,4),
	 (852,35,102,5),
	 (853,35,103,5),
	 (854,35,104,7),
	 (855,35,105,8),
	 (856,35,106,5),
	 (857,35,107,7),
	 (858,35,108,5),
	 (859,35,109,2),
	 (860,35,110,1);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (861,35,111,4),
	 (862,35,112,5),
	 (863,35,113,5),
	 (864,35,114,5),
	 (865,35,115,5),
	 (866,35,116,2),
	 (867,35,117,6),
	 (868,35,118,6),
	 (869,35,119,5),
	 (870,35,120,5);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (871,35,121,5),
	 (872,35,122,6),
	 (873,35,123,6),
	 (874,35,124,7),
	 (875,35,125,5),
	 (876,36,101,5),
	 (877,36,102,5),
	 (878,36,103,5),
	 (879,36,104,8),
	 (880,36,105,4);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (881,36,106,5),
	 (882,36,107,4),
	 (883,36,108,4),
	 (884,36,109,7),
	 (885,36,110,4),
	 (886,36,111,7),
	 (887,36,112,4),
	 (888,36,113,5),
	 (889,36,114,5),
	 (890,36,115,5);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (891,36,116,6),
	 (892,36,117,5),
	 (893,36,118,4),
	 (894,36,119,7),
	 (895,36,120,5),
	 (896,36,121,6),
	 (897,36,122,4),
	 (898,36,123,3),
	 (899,36,124,9),
	 (900,36,125,2);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (901,37,101,4),
	 (902,37,102,5),
	 (903,37,103,5),
	 (904,37,104,5),
	 (905,37,105,3),
	 (906,37,106,5),
	 (907,37,107,8),
	 (908,37,108,8),
	 (909,37,109,1),
	 (910,37,110,5);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (911,37,111,5),
	 (912,37,112,5),
	 (913,37,113,5),
	 (914,37,114,5),
	 (915,37,115,5),
	 (916,37,116,6),
	 (917,37,117,3),
	 (918,37,118,5),
	 (919,37,119,4),
	 (920,37,120,2);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (921,37,121,7),
	 (922,37,122,6),
	 (923,37,123,8),
	 (924,37,124,7),
	 (925,37,125,2),
	 (926,38,101,4),
	 (927,38,102,5),
	 (928,38,103,5),
	 (929,38,104,2),
	 (930,38,105,7);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (931,38,106,5),
	 (932,38,107,4),
	 (933,38,108,4),
	 (934,38,109,5),
	 (935,38,110,4),
	 (936,38,111,7),
	 (937,38,112,3),
	 (938,38,113,5),
	 (939,38,114,5),
	 (940,38,115,5);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (941,38,116,7),
	 (942,38,117,5),
	 (943,38,118,7),
	 (944,38,119,7),
	 (945,38,120,2),
	 (946,38,121,5),
	 (947,38,122,8),
	 (948,38,123,3),
	 (949,38,124,3),
	 (950,38,125,5);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (951,39,101,5),
	 (952,39,102,5),
	 (953,39,103,5),
	 (954,39,104,5),
	 (955,39,105,3),
	 (956,39,106,5),
	 (957,39,107,6),
	 (958,39,108,7),
	 (959,39,109,6),
	 (960,39,110,10);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (961,39,111,6),
	 (962,39,112,8),
	 (963,39,113,5),
	 (964,39,114,5),
	 (965,39,115,5),
	 (966,39,116,2),
	 (967,39,117,7),
	 (968,39,118,4),
	 (969,39,119,5),
	 (970,39,120,6);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (971,39,121,3),
	 (972,39,122,7),
	 (973,39,123,6),
	 (974,39,124,3),
	 (975,39,125,2),
	 (976,40,126,5),
	 (977,40,127,5),
	 (978,40,128,5),
	 (979,40,129,5),
	 (980,40,130,8);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (981,40,131,5),
	 (982,40,132,5),
	 (983,40,133,5),
	 (984,40,134,5),
	 (985,40,135,5),
	 (986,40,136,7),
	 (987,40,137,6),
	 (988,40,138,5),
	 (989,40,139,5),
	 (990,40,140,5);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (991,40,141,5),
	 (992,40,142,5),
	 (993,40,143,6),
	 (994,40,144,3),
	 (995,40,145,7),
	 (996,40,146,3),
	 (997,40,147,6),
	 (998,40,148,6),
	 (999,40,149,5),
	 (1000,40,150,5);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (1001,41,126,5),
	 (1002,41,127,5),
	 (1003,41,128,5),
	 (1004,41,129,5),
	 (1005,41,130,8),
	 (1006,41,131,5),
	 (1007,41,132,5),
	 (1008,41,133,4),
	 (1009,41,134,5),
	 (1010,41,135,5);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (1011,41,136,4),
	 (1012,41,137,1),
	 (1013,41,138,5),
	 (1014,41,139,5),
	 (1015,41,140,6),
	 (1016,41,141,5),
	 (1017,41,142,5),
	 (1018,41,143,5),
	 (1019,41,144,8),
	 (1020,41,145,5);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (1021,41,146,9),
	 (1022,41,147,1),
	 (1023,41,148,4),
	 (1024,41,149,4),
	 (1025,41,150,5),
	 (1026,42,126,5),
	 (1027,42,127,5),
	 (1028,42,128,5),
	 (1029,42,129,5),
	 (1030,42,130,3);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (1031,42,131,2),
	 (1032,42,132,5),
	 (1033,42,133,5),
	 (1034,42,134,5),
	 (1035,42,135,5),
	 (1036,42,136,5),
	 (1037,42,137,7),
	 (1038,42,138,5),
	 (1039,42,139,5),
	 (1040,42,140,3);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (1041,42,141,5),
	 (1042,42,142,5),
	 (1043,42,143,3),
	 (1044,42,144,7),
	 (1045,42,145,4),
	 (1046,42,146,5),
	 (1047,42,147,5),
	 (1048,42,148,1),
	 (1049,42,149,5),
	 (1050,42,150,7);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (1051,43,126,5),
	 (1052,43,127,5),
	 (1053,43,128,5),
	 (1054,43,129,5),
	 (1055,43,130,2),
	 (1056,43,131,5),
	 (1057,43,132,5),
	 (1058,43,133,5),
	 (1059,43,134,5),
	 (1060,43,135,5);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (1061,43,136,5),
	 (1062,43,137,3),
	 (1063,43,138,5),
	 (1064,43,139,5),
	 (1065,43,140,3),
	 (1066,43,141,5),
	 (1067,43,142,5),
	 (1068,43,143,5),
	 (1069,43,144,6),
	 (1070,43,145,8);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (1071,43,146,6),
	 (1072,43,147,6),
	 (1073,43,148,3),
	 (1074,43,149,8),
	 (1075,43,150,2),
	 (1076,44,126,5),
	 (1077,44,127,5),
	 (1078,44,128,5),
	 (1079,44,129,5),
	 (1080,44,130,2);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (1081,44,131,5),
	 (1082,44,132,5),
	 (1083,44,133,5),
	 (1084,44,134,5),
	 (1085,44,135,5),
	 (1086,44,136,7),
	 (1087,44,137,4),
	 (1088,44,138,5),
	 (1089,44,139,5),
	 (1090,44,140,7);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (1091,44,141,5),
	 (1092,44,142,5),
	 (1093,44,143,5),
	 (1094,44,144,5),
	 (1095,44,145,2),
	 (1096,44,146,7),
	 (1097,44,147,6),
	 (1098,44,148,6),
	 (1099,44,149,6),
	 (1100,44,150,3);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (1101,45,126,5),
	 (1102,45,127,5),
	 (1103,45,128,5),
	 (1104,45,129,5),
	 (1105,45,130,7),
	 (1106,45,131,3),
	 (1107,45,132,5),
	 (1108,45,133,5),
	 (1109,45,134,5),
	 (1110,45,135,5);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (1111,45,136,10),
	 (1112,45,137,6),
	 (1113,45,138,5),
	 (1114,45,139,5),
	 (1115,45,140,5),
	 (1116,45,141,5),
	 (1117,45,142,5),
	 (1118,45,143,7),
	 (1119,45,144,2),
	 (1120,45,145,0);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (1121,45,146,4),
	 (1122,45,147,5),
	 (1123,45,148,3),
	 (1124,45,149,2),
	 (1125,45,150,4),
	 (1126,46,126,5),
	 (1127,46,127,5),
	 (1128,46,128,5),
	 (1129,46,129,5),
	 (1130,46,130,5);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (1131,46,131,4),
	 (1132,46,132,5),
	 (1133,46,133,5),
	 (1134,46,134,5),
	 (1135,46,135,5),
	 (1136,46,136,5),
	 (1137,46,137,6),
	 (1138,46,138,5),
	 (1139,46,139,5),
	 (1140,46,140,3);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (1141,46,141,5),
	 (1142,46,142,5),
	 (1143,46,143,4),
	 (1144,46,144,9),
	 (1145,46,145,5),
	 (1146,46,146,1),
	 (1147,46,147,3),
	 (1148,46,148,5),
	 (1149,46,149,5),
	 (1150,46,150,1);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (1151,47,126,5),
	 (1152,47,127,5),
	 (1153,47,128,5),
	 (1154,47,129,5),
	 (1155,47,130,5),
	 (1156,47,131,2),
	 (1157,47,132,5),
	 (1158,47,133,3),
	 (1159,47,134,5),
	 (1160,47,135,5);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (1161,47,136,4),
	 (1162,47,137,6),
	 (1163,47,138,5),
	 (1164,47,139,5),
	 (1165,47,140,2),
	 (1166,47,141,5),
	 (1167,47,142,5),
	 (1168,47,143,3),
	 (1169,47,144,5),
	 (1170,47,145,3);
INSERT INTO notas (id,idModulo,idEstudiante,valor) VALUES
	 (1171,47,146,4),
	 (1172,47,147,5),
	 (1173,47,148,5),
	 (1174,47,149,2),
	 (1175,47,150,9);

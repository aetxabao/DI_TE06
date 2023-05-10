<!-- Based on the Best-README-Template. -->
<a name="readme-top"></a>

<div align="center">
<h1 align="center">GraSupInf</h1>

[![IMAGE ALT TEXT](https://img.youtube.com/vi/WdymnUBVrgk/0.jpg)](https://youtu.be/WdymnUBVrgk "Aplicación GraSupInf")

[![IMAGE ALT TEXT](https://img.youtube.com/vi/UNyAnY0NQgk/0.jpg)](https://youtu.be/UNyAnY0NQgk "Informes de GraSupInf")

</div>

---
<!-- TABLE OF CONTENTS -->
<details>
  <summary>Índice</summary>
  <ol>
    <li>
      <a href="#about">About</a>
    </li>
    <li>
      <a href="#guía-de-instalacion">Guía de instalación</a>
      <ul>
        <li><a href="#dependencias">Dependencias</a></li>
        <li><a href="#dependencias">Informes</a></li>
      </ul>
    </li>
    <li><a href="#licencia">Licencia</a></li>
    <li><a href="#contacto">Contacto</a></li>
    <li><a href="#referencias">Referencias</a></li>
  </ol>
</details>

---
## About

Programa realizado en el módulo de Desarrollo de Interfaces (DI) del ciclo de Desarrollo de Aplicaciones Multiplataforma (DAM) de [birt.eus](https://www.birt.eus/)

La aplicación ha sido desarrollada en diferentes unidades de trabajo. En un principio se incidió en los principios de usabilidad, luego en el módelo MVC, después en el desarrollo de componentes visuales, creación de GUIs con Controles de Usuario, generación de informes y finalmente, documentación y distribución de aplicaciones. 

<p align="right">(<a href="#readme-top">volver al inicio</a>)</p>

---
## Guía de instalación


La solución tiene un proyecto InstaladorApp que instalará el software en el directorio:

    C:\Program Files (x86)\Birt\DI06

Para crear una nueva instalación desde MVS es preciso
- Limpiar la solución
- Recompilar el InstaladorApp
- Instalar el InstaladorApp

### Dependencias

El trabajo se ha desarrollado en un portátil con procesador i7, 16GB de RAM y monitos configurado a 1920x1080 utilizando Windows 10 Education.

Se ha hecho uso del siguiente software:

* Microsoft .NET Framework 4.7.2
* Microsoft Visual Studio (MVS) Community 2019
  * Microsoft Visual Studio Installer Projects (extensión)
  * Microsoft RDLC Report Designer (extensión)
* SAP Crystal Reports for MVS (desarrollo)
* SAP Crystal Reports Runtime Engine for .NET Framework (despliegue)
* SQL Server 2019

La configuración para el acceso a la base de datos se realiza en el fichero Consultas.cs en GsiSqlServer. 

    private const string CON_STRING = @"Data Source=localhost\SQLEXPRESS;Initial Catalog=GRASUPINF;User ID=di;Password=1234";

Adapta la conexión según sea la configuración. Recuerda crear un usuario con permisos.

    private const string CON_STRING = @"Data Source=LEOPARD\SQLEXPRESS;Initial Catalog=GRASUPINF;User ID=aitor;Password=1234"


### Informes

Los informes se han creado utilizando Crystal Reports y Report Viewer de distintas formas. 

| N.  | Título GUI | Tipo informe    | Pide id BD |
|-----|------------|-----------------|------------|
| 1   | Estudiante | Crystal Reports | Sí         |
| 2   | Pasan      | Crystal Reports | No         |
| 3   | Evaluación | Crystal Reports | Sí         |
| 4   | D. Grupo   | Report Viewer   | No         |
| 5   | Resultados | Report Viewer   | No         |
| 6   | Comparador | Crystal Reports | Sí         |

En todos los informes que piden id puede ser necesario establecer la ubicación del origen de datos según la base de datos de producción, por defecto "localhost\SQLEXPRESS"

El informe "Pasan" de Crystal Reports carga los datos de un DataTable que se obtiene mediante Consulta.cs. El fichero CRFiltroSuspensosHoras.rpt debe estar en la carpeta Informes. El instalador lo copia.

<p align="right">(<a href="#readme-top">volver al inicio</a>)</p>

---
## Licencia 

Este obra está bajo una licencia MIT (c) 2023 aetxabao.

<p align="right">(<a href="#readme-top">volver al inicio</a>)</p>

---
## Contacto

Sobre mi: Soy un profesor de informática que siempre está aprendiendo.

Contacto: aetxabao - [por.favor.no@contactar.me](mailto:please.dont@contact.me)

Github: [https://github.com/aetxabao](https://github.com/aetxabao)

Youtube: [https://www.youtube.com/@aetxabao/playlists](https://www.youtube.com/@aetxabao/playlists)

<p align="right">(<a href="#readme-top">volver al inicio</a>)</p>

---
## Referencias

Enlaces del software utilizado en este proyecto.
* [Visual Studio](https://visualstudio.microsoft.com/es/)
* [Microsoft Visual C++ Redistributable](https://learn.microsoft.com/es-es/cpp/windows/latest-supported-vc-redist?view=msvc-170)
* [Microsoft Report Viewer Runtime](https://www.microsoft.com/es-ES/download/details.aspx?id=45496)
* [SQL server](https://www.microsoft.com/es-es/sql-server/sql-server-downloads)
* [SQL Server Management Studio (SSMS)](https://learn.microsoft.com/es-es/sql/ssms/download-sql-server-management-studio-ssms?view=sql-server-ver15)
* [Descargas de SAP Crystal Reports](https://www.sap.com/cmp/td/sap-crystal-reports-visual-studio-trial.html)
* [Microsoft HTML Help Downloads](https://learn.microsoft.com/en-us/previous-versions/windows/desktop/htmlhelp/microsoft-html-help-downloads) Descarga inaccesible
* [Best-README-Template](https://github.com/othneildrew/Best-README-Template/blob/master/README.md)

<p align="right">(<a href="#readme-top">volver al inicio</a>)</p>


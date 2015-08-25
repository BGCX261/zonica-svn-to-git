1.- Para que compile la solución:
 + Agregar al PATH del sistema el path al BIN del SDK, para que encuentre
 gacutil. Por ejemplo:
	- C:\Archivos de programa\Microsoft Visual Studio .NET 2003\SDK\v1.1\BIN
	- o C:\WINDOWS\Microsoft.NET\Framework\v1.1.4322

2.- Para agregar una dll:
  + Tirarla en ..\ExternalAssemblies y agregarla al proyecto.

3.- Para agregar un proyecto a la solución:
 + Evitar commitear las carpetas bin y obj y los archivos .user (agregarlos al SVN Ignore)
 + Tomar referencias sólo entre proyectos o de la carpeta ExternalAssemblies

4.- Para que el visual studio pueda abrir el proyecto web:
 + Si da un error que dice web access failed, crear un directorio virtual en la consola
   de administración de internet information services. Se debe llamar Zonica, y debe
   apuntar al directorio de la solución Zonica.Web.UI.
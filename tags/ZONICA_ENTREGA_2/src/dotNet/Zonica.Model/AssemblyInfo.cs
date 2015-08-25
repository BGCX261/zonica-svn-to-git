using System.Reflection;
//
// La información general de un ensamblado se controla mediante el siguiente 
// conjunto de atributos. Cambie estos atributos para modificar la información
// asociada con un ensamblado.
//
[assembly : AssemblyTitle("Zonica.Model")]
[assembly : AssemblyDescription("Modelo del Proyecto Zonica")]
[assembly : AssemblyCompany("Grupo 4 - Proyecto 2006")]
[assembly : AssemblyCopyright("Grupo 4 - Proyecto 2006")]
[assembly : AssemblyTrademark("Zonica")]
[assembly : AssemblyConfiguration("")]
[assembly : AssemblyProduct("")]
[assembly : AssemblyCulture("")]

//
// La información de versión de un ensamblado consta de los siguientes cuatro valores:
//
//      Versión principal
//      Versión secundaria 
//      Versión de compilación
//      Revisión
//
// Puede especificar todos los valores o usar los valores predeterminados (número de versión de compilación y de revisión) 
// usando el símbolo '*' como se muestra a continuación:

[assembly : AssemblyVersion("1.0.0.0")]

//
// In order to sign your assembly you must specify a key to use. Refer to the 
// Microsoft .NET Framework documentation for more information on assembly signing.
//
// Use the attributes below to control which key is used for signing. 
//
// Notes: 
//   (*) If no key is specified, the assembly is not signed.
//   (*) KeyName refers to a key that has been installed in the Crypto Service
//       Provider (CSP) on your machine. KeyFile refers to a file which contains
//       a key.
//   (*) If the KeyFile and the KeyName values are both specified, the 
//       following processing occurs:
//       (1) If the KeyName can be found in the CSP, that key is used.
//       (2) If the KeyName does not exist and the KeyFile does exist, the key 
//           in the KeyFile is installed into the CSP and used.
//   (*) In order to create a KeyFile, you can use the sn.exe (Strong Name) utility.
//       When specifying the KeyFile, the location of the KeyFile should be
//       relative to the project output directory which is
//       %Project Directory%\obj\<configuration>. For example, if your KeyFile is
//       located in the project directory, you would specify the AssemblyKeyFile 
//       attribute as [assembly: AssemblyKeyFile("..\\..\\mykey.snk")]
//   (*) Delay Signing is an advanced option - see the Microsoft .NET Framework
//       documentation for more information on this.
//
/*
[assembly : AssemblyDelaySign(false)]
[assembly : AssemblyKeyFile(@"..\..\..\Zonica.key")]
[assembly : AssemblyKeyName("")]
*/
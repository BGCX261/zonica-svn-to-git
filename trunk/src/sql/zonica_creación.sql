/****** Objeto:  base de datos Zonica   fecha de la secuencia de comandos: 24/10/2006 12:38:55 a.m. ******/
IF EXISTS (SELECT name FROM master.dbo.sysdatabases WHERE name = N'Zonica')
	DROP DATABASE [Zonica]
GO

CREATE DATABASE [Zonica]  ON (NAME = N'Zonica', FILENAME = N'C:\Archivos de programa\Microsoft SQL Server\MSSQL\Data\Zonica.mdf' , SIZE = 2, FILEGROWTH = 10%) LOG ON (NAME = N'Zonica_log', FILENAME = N'C:\Archivos de programa\Microsoft SQL Server\MSSQL\Data\Zonica_log.LDF' , SIZE = 1, FILEGROWTH = 10%)
 COLLATE Modern_Spanish_CI_AS
GO

exec sp_dboption N'Zonica', N'autoclose', N'true'
GO

exec sp_dboption N'Zonica', N'bulkcopy', N'false'
GO

exec sp_dboption N'Zonica', N'trunc. log', N'true'
GO

exec sp_dboption N'Zonica', N'torn page detection', N'true'
GO

exec sp_dboption N'Zonica', N'read only', N'false'
GO

exec sp_dboption N'Zonica', N'dbo use', N'false'
GO

exec sp_dboption N'Zonica', N'single', N'false'
GO

exec sp_dboption N'Zonica', N'autoshrink', N'true'
GO

exec sp_dboption N'Zonica', N'ANSI null default', N'false'
GO

exec sp_dboption N'Zonica', N'recursive triggers', N'false'
GO

exec sp_dboption N'Zonica', N'ANSI nulls', N'false'
GO

exec sp_dboption N'Zonica', N'concat null yields null', N'false'
GO

exec sp_dboption N'Zonica', N'cursor close on commit', N'false'
GO

exec sp_dboption N'Zonica', N'default to local cursor', N'false'
GO

exec sp_dboption N'Zonica', N'quoted identifier', N'false'
GO

exec sp_dboption N'Zonica', N'ANSI warnings', N'false'
GO

exec sp_dboption N'Zonica', N'auto create statistics', N'true'
GO

exec sp_dboption N'Zonica', N'auto update statistics', N'true'
GO

use [Zonica]
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_Album_Artista]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[Album] DROP CONSTRAINT FK_Album_Artista
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_Artista_EstiloMusical_Artista]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[Artista_EstiloMusical] DROP CONSTRAINT FK_Artista_EstiloMusical_Artista
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_TemaMusical_Artista]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[TemaMusical] DROP CONSTRAINT FK_TemaMusical_Artista
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_Artista_EstiloMusical_EstiloMusical]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[Artista_EstiloMusical] DROP CONSTRAINT FK_Artista_EstiloMusical_EstiloMusical
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_Provincia_Pais]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[Provincia] DROP CONSTRAINT FK_Provincia_Pais
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_ContactoUsuario_TipoContacto]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[ContactoUsuario] DROP CONSTRAINT FK_ContactoUsuario_TipoContacto
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_TemaMusical_Album]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[TemaMusical] DROP CONSTRAINT FK_TemaMusical_Album
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_Ciudad_Provincia]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[Ciudad] DROP CONSTRAINT FK_Ciudad_Provincia
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_Usuario_Ciudad]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[Usuario] DROP CONSTRAINT FK_Usuario_Ciudad
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_Escucha_TemaMusical]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[Escucha] DROP CONSTRAINT FK_Escucha_TemaMusical
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_ContactoUsuario_Usuario]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[ContactoUsuario] DROP CONSTRAINT FK_ContactoUsuario_Usuario
GO

if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[FK_Escucha_Usuario]') and OBJECTPROPERTY(id, N'IsForeignKey') = 1)
ALTER TABLE [dbo].[Escucha] DROP CONSTRAINT FK_Escucha_Usuario
GO

/****** Objeto: tabla [dbo].[ContactoUsuario]    fecha de la secuencia de comandos: 24/10/2006 12:38:57 a.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[ContactoUsuario]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[ContactoUsuario]
GO

/****** Objeto: tabla [dbo].[Escucha]    fecha de la secuencia de comandos: 24/10/2006 12:38:57 a.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Escucha]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Escucha]
GO

/****** Objeto: tabla [dbo].[Usuario]    fecha de la secuencia de comandos: 24/10/2006 12:38:57 a.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Usuario]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Usuario]
GO

/****** Objeto: tabla [dbo].[Ciudad]    fecha de la secuencia de comandos: 24/10/2006 12:38:57 a.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Ciudad]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Ciudad]
GO

/****** Objeto: tabla [dbo].[TemaMusical]    fecha de la secuencia de comandos: 24/10/2006 12:38:57 a.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TemaMusical]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[TemaMusical]
GO

/****** Objeto: tabla [dbo].[Album]    fecha de la secuencia de comandos: 24/10/2006 12:38:57 a.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Album]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Album]
GO

/****** Objeto: tabla [dbo].[Artista_EstiloMusical]    fecha de la secuencia de comandos: 24/10/2006 12:38:57 a.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Artista_EstiloMusical]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Artista_EstiloMusical]
GO

/****** Objeto: tabla [dbo].[Provincia]    fecha de la secuencia de comandos: 24/10/2006 12:38:57 a.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Provincia]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Provincia]
GO

/****** Objeto: tabla [dbo].[Artista]    fecha de la secuencia de comandos: 24/10/2006 12:38:57 a.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Artista]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Artista]
GO

/****** Objeto: tabla [dbo].[EstiloMusical]    fecha de la secuencia de comandos: 24/10/2006 12:38:57 a.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[EstiloMusical]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[EstiloMusical]
GO

/****** Objeto: tabla [dbo].[Pais]    fecha de la secuencia de comandos: 24/10/2006 12:38:57 a.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[Pais]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[Pais]
GO

/****** Objeto: tabla [dbo].[TipoContacto]    fecha de la secuencia de comandos: 24/10/2006 12:38:57 a.m. ******/
if exists (select * from dbo.sysobjects where id = object_id(N'[dbo].[TipoContacto]') and OBJECTPROPERTY(id, N'IsUserTable') = 1)
drop table [dbo].[TipoContacto]
GO

/****** Objeto: inicio de sesión zonica   fecha de la secuencia de comandos: 24/10/2006 12:38:55 a.m. ******/
if not exists (select * from master.dbo.syslogins where loginname = N'zonica')
BEGIN
	declare @logindb nvarchar(132), @loginlang nvarchar(132) select @logindb = N'Zonica', @loginlang = N'us_english'
	if @logindb is null or not exists (select * from master.dbo.sysdatabases where name = @logindb)
		select @logindb = N'master'
	if @loginlang is null or (not exists (select * from master.dbo.syslanguages where name = @loginlang) and @loginlang <> N'us_english')
		select @loginlang = @@language
	exec sp_addlogin N'zonica', null, @logindb, @loginlang
END
GO

/****** Objeto: inicio de sesión BUILTIN\Administradores   fecha de la secuencia de comandos: 24/10/2006 12:38:56 a.m. ******/
exec sp_addsrvrolemember N'BUILTIN\Administradores', sysadmin
GO

/****** Objeto: usuario dbo    fecha de la secuencia de comandos: 24/10/2006 12:38:56 a.m. ******/
/****** Objeto: usuario zonica    fecha de la secuencia de comandos: 24/10/2006 12:38:56 a.m. ******/
if not exists (select * from dbo.sysusers where name = N'zonica' and uid < 16382)
	EXEC sp_grantdbaccess N'zonica', N'zonica'
GO

/****** Objeto: usuario zonica    fecha de la secuencia de comandos: 24/10/2006 12:38:56 a.m. ******/
exec sp_addrolemember N'db_datareader', N'zonica'
GO

/****** Objeto: usuario zonica    fecha de la secuencia de comandos: 24/10/2006 12:38:56 a.m. ******/
exec sp_addrolemember N'db_datawriter', N'zonica'
GO

/****** Objeto: tabla [dbo].[Artista]    fecha de la secuencia de comandos: 24/10/2006 12:38:58 a.m. ******/
CREATE TABLE [dbo].[Artista] (
	[id] [numeric](10, 0) IDENTITY (0, 1) NOT NULL ,
	[nombre] [varchar] (50) COLLATE Modern_Spanish_CI_AS NOT NULL 
) ON [PRIMARY]
GO

/****** Objeto: tabla [dbo].[EstiloMusical]    fecha de la secuencia de comandos: 24/10/2006 12:38:58 a.m. ******/
CREATE TABLE [dbo].[EstiloMusical] (
	[id] [numeric](10, 0) IDENTITY (0, 1) NOT NULL ,
	[nombre] [varchar] (50) COLLATE Modern_Spanish_CI_AS NOT NULL 
) ON [PRIMARY]
GO

/****** Objeto: tabla [dbo].[Pais]    fecha de la secuencia de comandos: 24/10/2006 12:38:58 a.m. ******/
CREATE TABLE [dbo].[Pais] (
	[id] [numeric](10, 0) IDENTITY (0, 1) NOT NULL ,
	[nombre] [varchar] (50) COLLATE Modern_Spanish_CI_AS NOT NULL 
) ON [PRIMARY]
GO

/****** Objeto: tabla [dbo].[TipoContacto]    fecha de la secuencia de comandos: 24/10/2006 12:38:58 a.m. ******/
CREATE TABLE [dbo].[TipoContacto] (
	[id] [numeric](10, 0) IDENTITY (1, 1) NOT NULL ,
	[nombre] [nvarchar] (50) COLLATE Modern_Spanish_CI_AS NOT NULL ,
	[icono] [nvarchar] (50) COLLATE Modern_Spanish_CI_AS NOT NULL 
) ON [PRIMARY]
GO

/****** Objeto: tabla [dbo].[Album]    fecha de la secuencia de comandos: 24/10/2006 12:38:59 a.m. ******/
CREATE TABLE [dbo].[Album] (
	[id] [numeric](10, 0) IDENTITY (0, 1) NOT NULL ,
	[id_artista] [numeric](10, 0) NOT NULL ,
	[nombre] [varchar] (50) COLLATE Modern_Spanish_CI_AS NOT NULL ,
	[anioPublicacion] [numeric](10, 2) NULL 
) ON [PRIMARY]
GO

/****** Objeto: tabla [dbo].[Artista_EstiloMusical]    fecha de la secuencia de comandos: 24/10/2006 12:38:59 a.m. ******/
CREATE TABLE [dbo].[Artista_EstiloMusical] (
	[id_artista] [numeric](10, 0) NOT NULL ,
	[id_estiloMusical] [numeric](10, 0) NOT NULL 
) ON [PRIMARY]
GO

/****** Objeto: tabla [dbo].[Provincia]    fecha de la secuencia de comandos: 24/10/2006 12:38:59 a.m. ******/
CREATE TABLE [dbo].[Provincia] (
	[id] [numeric](10, 0) IDENTITY (0, 1) NOT NULL ,
	[nombre] [varchar] (50) COLLATE Modern_Spanish_CI_AS NOT NULL ,
	[id_pais] [numeric](10, 0) NOT NULL 
) ON [PRIMARY]
GO

/****** Objeto: tabla [dbo].[Ciudad]    fecha de la secuencia de comandos: 24/10/2006 12:38:59 a.m. ******/
CREATE TABLE [dbo].[Ciudad] (
	[id] [numeric](10, 0) IDENTITY (0, 1) NOT NULL ,
	[id_provincia] [numeric](10, 0) NOT NULL ,
	[nombre] [varchar] (50) COLLATE Modern_Spanish_CI_AS NOT NULL 
) ON [PRIMARY]
GO

/****** Objeto: tabla [dbo].[TemaMusical]    fecha de la secuencia de comandos: 24/10/2006 12:38:59 a.m. ******/
CREATE TABLE [dbo].[TemaMusical] (
	[id] [numeric](10, 0) IDENTITY (0, 1) NOT NULL ,
	[id_album] [numeric](10, 0) NOT NULL ,
	[id_autor] [numeric](10, 0) NOT NULL ,
	[nombre] [varchar] (250) COLLATE Modern_Spanish_CI_AS NOT NULL 
) ON [PRIMARY]
GO

/****** Objeto: tabla [dbo].[Usuario]    fecha de la secuencia de comandos: 24/10/2006 12:38:59 a.m. ******/
CREATE TABLE [dbo].[Usuario] (
	[id] [numeric](10, 0) IDENTITY (0, 1) NOT NULL ,
	[id_ciudad] [numeric](10, 0) NULL ,
	[nombreUsuario] [nvarchar] (50) COLLATE Modern_Spanish_CI_AS NOT NULL ,
	[password] [nvarchar] (50) COLLATE Modern_Spanish_CI_AS NOT NULL ,
	[apodo] [nvarchar] (50) COLLATE Modern_Spanish_CI_AS NULL ,
	[nombreCompleto] [nvarchar] (75) COLLATE Modern_Spanish_CI_AS NULL ,
	[fechaCreacion] [datetime] NOT NULL ,
	[fechaActualizacion] [datetime] NOT NULL ,
	[fechaNacimiento] [datetime] NOT NULL 
) ON [PRIMARY]
GO

/****** Objeto: tabla [dbo].[ContactoUsuario]    fecha de la secuencia de comandos: 24/10/2006 12:38:59 a.m. ******/
CREATE TABLE [dbo].[ContactoUsuario] (
	[id] [numeric](10, 0) IDENTITY (1, 1) NOT NULL ,
	[id_usuario] [numeric](10, 0) NOT NULL ,
	[id_tipoContacto] [numeric](10, 0) NOT NULL ,
	[nombre] [nvarchar] (50) COLLATE Modern_Spanish_CI_AS NOT NULL 
) ON [PRIMARY]
GO

/****** Objeto: tabla [dbo].[Escucha]    fecha de la secuencia de comandos: 24/10/2006 12:38:59 a.m. ******/
CREATE TABLE [dbo].[Escucha] (
	[id] [numeric](10, 0) IDENTITY (0, 1) NOT NULL ,
	[id_temaMusical] [numeric](10, 0) NOT NULL ,
	[id_usuario] [numeric](10, 0) NOT NULL ,
	[momentoEscucha] [datetime] NOT NULL ,
	[valoracion] [numeric](10, 0) NOT NULL 
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Artista] WITH NOCHECK ADD 
	CONSTRAINT [PK_Artista] PRIMARY KEY  CLUSTERED 
	(
		[id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[EstiloMusical] WITH NOCHECK ADD 
	CONSTRAINT [PK_Estilo] PRIMARY KEY  CLUSTERED 
	(
		[id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[Pais] WITH NOCHECK ADD 
	CONSTRAINT [PK_Pais] PRIMARY KEY  CLUSTERED 
	(
		[id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[TipoContacto] WITH NOCHECK ADD 
	CONSTRAINT [PK_TipoContacto] PRIMARY KEY  CLUSTERED 
	(
		[id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[Album] WITH NOCHECK ADD 
	CONSTRAINT [PK_Album] PRIMARY KEY  CLUSTERED 
	(
		[id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[Artista_EstiloMusical] WITH NOCHECK ADD 
	CONSTRAINT [PK_Artista_Estilo] PRIMARY KEY  CLUSTERED 
	(
		[id_artista],
		[id_estiloMusical]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[Provincia] WITH NOCHECK ADD 
	CONSTRAINT [PK_Provincia] PRIMARY KEY  CLUSTERED 
	(
		[id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[Ciudad] WITH NOCHECK ADD 
	CONSTRAINT [PK_Ciudad] PRIMARY KEY  CLUSTERED 
	(
		[id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[TemaMusical] WITH NOCHECK ADD 
	CONSTRAINT [PK_Tema] PRIMARY KEY  CLUSTERED 
	(
		[id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[Usuario] WITH NOCHECK ADD 
	CONSTRAINT [PK_Usuario] PRIMARY KEY  CLUSTERED 
	(
		[id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[ContactoUsuario] WITH NOCHECK ADD 
	CONSTRAINT [PK_Tabla1] PRIMARY KEY  CLUSTERED 
	(
		[id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[Escucha] WITH NOCHECK ADD 
	CONSTRAINT [PK_Escucha] PRIMARY KEY  CLUSTERED 
	(
		[id]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[TipoContacto] WITH NOCHECK ADD 
	CONSTRAINT [IX_TipoContacto] UNIQUE  NONCLUSTERED 
	(
		[nombre]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[Usuario] WITH NOCHECK ADD 
	CONSTRAINT [IX_Usuario] UNIQUE  NONCLUSTERED 
	(
		[nombreUsuario]
	)  ON [PRIMARY] 
GO

ALTER TABLE [dbo].[Album] ADD 
	CONSTRAINT [FK_Album_Artista] FOREIGN KEY 
	(
		[id_artista]
	) REFERENCES [dbo].[Artista] (
		[id]
	) ON DELETE CASCADE 
GO

ALTER TABLE [dbo].[Artista_EstiloMusical] ADD 
	CONSTRAINT [FK_Artista_EstiloMusical_Artista] FOREIGN KEY 
	(
		[id_artista]
	) REFERENCES [dbo].[Artista] (
		[id]
	) ON DELETE CASCADE ,
	CONSTRAINT [FK_Artista_EstiloMusical_EstiloMusical] FOREIGN KEY 
	(
		[id_estiloMusical]
	) REFERENCES [dbo].[EstiloMusical] (
		[id]
	) ON DELETE CASCADE 
GO

ALTER TABLE [dbo].[Provincia] ADD 
	CONSTRAINT [FK_Provincia_Pais] FOREIGN KEY 
	(
		[id_pais]
	) REFERENCES [dbo].[Pais] (
		[id]
	) ON DELETE CASCADE 
GO

ALTER TABLE [dbo].[Ciudad] ADD 
	CONSTRAINT [FK_Ciudad_Provincia] FOREIGN KEY 
	(
		[id_provincia]
	) REFERENCES [dbo].[Provincia] (
		[id]
	) ON DELETE CASCADE 
GO

ALTER TABLE [dbo].[TemaMusical] ADD 
	CONSTRAINT [FK_TemaMusical_Album] FOREIGN KEY 
	(
		[id_album]
	) REFERENCES [dbo].[Album] (
		[id]
	),
	CONSTRAINT [FK_TemaMusical_Artista] FOREIGN KEY 
	(
		[id_autor]
	) REFERENCES [dbo].[Artista] (
		[id]
	)
GO

ALTER TABLE [dbo].[Usuario] ADD 
	CONSTRAINT [FK_Usuario_Ciudad] FOREIGN KEY 
	(
		[id_ciudad]
	) REFERENCES [dbo].[Ciudad] (
		[id]
	)
GO

ALTER TABLE [dbo].[ContactoUsuario] ADD 
	CONSTRAINT [FK_ContactoUsuario_TipoContacto] FOREIGN KEY 
	(
		[id_tipoContacto]
	) REFERENCES [dbo].[TipoContacto] (
		[id]
	),
	CONSTRAINT [FK_ContactoUsuario_Usuario] FOREIGN KEY 
	(
		[id_usuario]
	) REFERENCES [dbo].[Usuario] (
		[id]
	)
GO

ALTER TABLE [dbo].[Escucha] ADD 
	CONSTRAINT [FK_Escucha_TemaMusical] FOREIGN KEY 
	(
		[id_temaMusical]
	) REFERENCES [dbo].[TemaMusical] (
		[id]
	),
	CONSTRAINT [FK_Escucha_Usuario] FOREIGN KEY 
	(
		[id_usuario]
	) REFERENCES [dbo].[Usuario] (
		[id]
	)
GO


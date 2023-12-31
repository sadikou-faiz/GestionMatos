USE [master]
GO
/****** Object:  Database [GestionMatos]    Script Date: 04/05/2022 18:42:06 ******/
CREATE DATABASE [GestionMatos]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'gestion', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\gestion.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'gestion_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\gestion_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [GestionMatos] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GestionMatos].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GestionMatos] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GestionMatos] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GestionMatos] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GestionMatos] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GestionMatos] SET ARITHABORT OFF 
GO
ALTER DATABASE [GestionMatos] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [GestionMatos] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GestionMatos] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GestionMatos] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GestionMatos] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GestionMatos] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GestionMatos] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GestionMatos] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GestionMatos] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GestionMatos] SET  DISABLE_BROKER 
GO
ALTER DATABASE [GestionMatos] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GestionMatos] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GestionMatos] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GestionMatos] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GestionMatos] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GestionMatos] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [GestionMatos] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GestionMatos] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [GestionMatos] SET  MULTI_USER 
GO
ALTER DATABASE [GestionMatos] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GestionMatos] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GestionMatos] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GestionMatos] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [GestionMatos] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [GestionMatos] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [GestionMatos] SET QUERY_STORE = OFF
GO
USE [GestionMatos]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 04/05/2022 18:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[ClientID] [int] IDENTITY(1,1) NOT NULL,
	[Nom] [varchar](50) NOT NULL,
	[Tel] [varchar](20) NOT NULL,
	[Mail] [varchar](50) NOT NULL,
 CONSTRAINT [Client_PK] PRIMARY KEY CLUSTERED 
(
	[ClientID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Interventions]    Script Date: 04/05/2022 18:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Interventions](
	[InterID] [int] IDENTITY(1,1) NOT NULL,
	[Date] [datetime] NOT NULL,
	[Description] [varchar](500) NULL,
	[MaterielID] [int] NOT NULL,
 CONSTRAINT [Interventions_PK] PRIMARY KEY CLUSTERED 
(
	[InterID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [Interventions_MATERIEL_AK] UNIQUE NONCLUSTERED 
(
	[MaterielID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MATERIEL]    Script Date: 04/05/2022 18:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MATERIEL](
	[MaterielID] [int] IDENTITY(1,1) NOT NULL,
	[Nom] [varchar](50) NOT NULL,
	[NoSerie] [varchar](50) NOT NULL,
	[DateInstallation] [datetime] NULL,
	[MTBF] [int] NULL,
	[Description] [varchar](500) NULL,
	[SiteID] [int] NOT NULL,
	[ClientID] [int] NOT NULL,
	[TypeID] [int] NOT NULL,
 CONSTRAINT [MATERIEL_PK] PRIMARY KEY CLUSTERED 
(
	[MaterielID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SITE]    Script Date: 04/05/2022 18:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SITE](
	[SiteID] [int] IDENTITY(1,1) NOT NULL,
	[Nom] [varchar](50) NOT NULL,
	[Adresse] [varchar](100) NOT NULL,
 CONSTRAINT [SITE_PK] PRIMARY KEY CLUSTERED 
(
	[SiteID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Type]    Script Date: 04/05/2022 18:42:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Type](
	[TypeID] [int] IDENTITY(1,1) NOT NULL,
	[Nom] [varchar](50) NOT NULL,
	[Description] [varchar](500) NULL,
 CONSTRAINT [Type_PK] PRIMARY KEY CLUSTERED 
(
	[TypeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Interventions]  WITH CHECK ADD  CONSTRAINT [Interventions_MATERIEL_FK] FOREIGN KEY([MaterielID])
REFERENCES [dbo].[MATERIEL] ([MaterielID])
GO
ALTER TABLE [dbo].[Interventions] CHECK CONSTRAINT [Interventions_MATERIEL_FK]
GO
ALTER TABLE [dbo].[MATERIEL]  WITH CHECK ADD  CONSTRAINT [MATERIEL_Client0_FK] FOREIGN KEY([ClientID])
REFERENCES [dbo].[Client] ([ClientID])
GO
ALTER TABLE [dbo].[MATERIEL] CHECK CONSTRAINT [MATERIEL_Client0_FK]
GO
ALTER TABLE [dbo].[MATERIEL]  WITH CHECK ADD  CONSTRAINT [MATERIEL_SITE_FK] FOREIGN KEY([SiteID])
REFERENCES [dbo].[SITE] ([SiteID])
GO
ALTER TABLE [dbo].[MATERIEL] CHECK CONSTRAINT [MATERIEL_SITE_FK]
GO
ALTER TABLE [dbo].[MATERIEL]  WITH CHECK ADD  CONSTRAINT [MATERIEL_Type1_FK] FOREIGN KEY([TypeID])
REFERENCES [dbo].[Type] ([TypeID])
GO
ALTER TABLE [dbo].[MATERIEL] CHECK CONSTRAINT [MATERIEL_Type1_FK]
GO
USE [master]
GO
ALTER DATABASE [GestionMatos] SET  READ_WRITE 
GO

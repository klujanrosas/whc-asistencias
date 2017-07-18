USE [master]
GO
/****** Object:  Database [WHCAsistencias]    Script Date: 18/07/2017 14:49:04 ******/
CREATE DATABASE [WHCAsistencias]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'WHCAsistencias', FILENAME = N'D:\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\WHCAsistencias.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'WHCAsistencias_log', FILENAME = N'D:\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\WHCAsistencias_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [WHCAsistencias] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [WHCAsistencias].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [WHCAsistencias] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [WHCAsistencias] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [WHCAsistencias] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [WHCAsistencias] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [WHCAsistencias] SET ARITHABORT OFF 
GO
ALTER DATABASE [WHCAsistencias] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [WHCAsistencias] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [WHCAsistencias] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [WHCAsistencias] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [WHCAsistencias] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [WHCAsistencias] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [WHCAsistencias] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [WHCAsistencias] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [WHCAsistencias] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [WHCAsistencias] SET  DISABLE_BROKER 
GO
ALTER DATABASE [WHCAsistencias] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [WHCAsistencias] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [WHCAsistencias] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [WHCAsistencias] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [WHCAsistencias] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [WHCAsistencias] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [WHCAsistencias] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [WHCAsistencias] SET RECOVERY FULL 
GO
ALTER DATABASE [WHCAsistencias] SET  MULTI_USER 
GO
ALTER DATABASE [WHCAsistencias] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [WHCAsistencias] SET DB_CHAINING OFF 
GO
ALTER DATABASE [WHCAsistencias] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [WHCAsistencias] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [WHCAsistencias] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'WHCAsistencias', N'ON'
GO
ALTER DATABASE [WHCAsistencias] SET QUERY_STORE = OFF
GO
USE [WHCAsistencias]
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [WHCAsistencias]
GO
/****** Object:  Table [dbo].[Appointment]    Script Date: 18/07/2017 14:49:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Appointment](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[scheduledDate] [datetime] NOT NULL,
	[attended] [int] NOT NULL,
	[doctorId] [int] NOT NULL,
	[patientId] [int] NOT NULL,
 CONSTRAINT [PK_Appointment] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Business]    Script Date: 18/07/2017 14:49:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Business](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[businessName] [nvarchar](200) NULL,
	[businessRUC] [nvarchar](15) NULL,
	[deleted] [bit] NULL,
 CONSTRAINT [PK_Business] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Doctor]    Script Date: 18/07/2017 14:49:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctor](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[deleted] [bit] NOT NULL,
 CONSTRAINT [PK_Doctor] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Patient]    Script Date: 18/07/2017 14:49:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Patient](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[firstName] [nchar](10) NOT NULL,
	[lastName] [nchar](10) NOT NULL,
	[DNI] [nchar](10) NOT NULL,
	[businessId] [int] NOT NULL,
 CONSTRAINT [PK_Patient] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Appointment] ON 

GO
INSERT [dbo].[Appointment] ([id], [scheduledDate], [attended], [doctorId], [patientId]) VALUES (1, CAST(N'2017-06-22T09:30:00.000' AS DateTime), 0, 1, 1)
GO
INSERT [dbo].[Appointment] ([id], [scheduledDate], [attended], [doctorId], [patientId]) VALUES (2, CAST(N'2017-07-22T16:30:00.000' AS DateTime), 0, 1, 2)
GO
INSERT [dbo].[Appointment] ([id], [scheduledDate], [attended], [doctorId], [patientId]) VALUES (3, CAST(N'2017-08-15T17:45:00.000' AS DateTime), 0, 1, 3)
GO
INSERT [dbo].[Appointment] ([id], [scheduledDate], [attended], [doctorId], [patientId]) VALUES (4, CAST(N'2017-08-16T18:30:00.000' AS DateTime), 0, 2, 4)
GO
INSERT [dbo].[Appointment] ([id], [scheduledDate], [attended], [doctorId], [patientId]) VALUES (5, CAST(N'2017-08-16T18:50:00.000' AS DateTime), 0, 2, 5)
GO
INSERT [dbo].[Appointment] ([id], [scheduledDate], [attended], [doctorId], [patientId]) VALUES (6, CAST(N'2017-08-16T10:30:00.000' AS DateTime), 0, 2, 6)
GO
SET IDENTITY_INSERT [dbo].[Appointment] OFF
GO
SET IDENTITY_INSERT [dbo].[Business] ON 

GO
INSERT [dbo].[Business] ([id], [businessName], [businessRUC], [deleted]) VALUES (1, N'Scotiabank', N'20689564623', 0)
GO
INSERT [dbo].[Business] ([id], [businessName], [businessRUC], [deleted]) VALUES (2, N'Saga Falabella', N'20326554878', 0)
GO
INSERT [dbo].[Business] ([id], [businessName], [businessRUC], [deleted]) VALUES (3, N'Banco de la Nación', N'20546587982', 0)
GO
SET IDENTITY_INSERT [dbo].[Business] OFF
GO
SET IDENTITY_INSERT [dbo].[Doctor] ON 

GO
INSERT [dbo].[Doctor] ([id], [name], [deleted]) VALUES (1, N'Miriam Arévalo Lozano', 0)
GO
INSERT [dbo].[Doctor] ([id], [name], [deleted]) VALUES (2, N'John Del Águila Castillo', 0)
GO
SET IDENTITY_INSERT [dbo].[Doctor] OFF
GO
SET IDENTITY_INSERT [dbo].[Patient] ON 

GO
INSERT [dbo].[Patient] ([id], [firstName], [lastName], [DNI], [businessId]) VALUES (1, N'Sharmely  ', N'Quinto    ', N'Álvarez   ', 1)
GO
INSERT [dbo].[Patient] ([id], [firstName], [lastName], [DNI], [businessId]) VALUES (2, N'Victor    ', N'Tubilla   ', N'Espinoza  ', 1)
GO
INSERT [dbo].[Patient] ([id], [firstName], [lastName], [DNI], [businessId]) VALUES (3, N'Kendrick  ', N'Leon      ', N'Moreno    ', 2)
GO
INSERT [dbo].[Patient] ([id], [firstName], [lastName], [DNI], [businessId]) VALUES (4, N'Lia       ', N'Quiñones  ', N'Del Águila', 2)
GO
INSERT [dbo].[Patient] ([id], [firstName], [lastName], [DNI], [businessId]) VALUES (5, N'Pedro     ', N'Gorritti  ', N'Del Toro  ', 3)
GO
INSERT [dbo].[Patient] ([id], [firstName], [lastName], [DNI], [businessId]) VALUES (6, N'Marushka  ', N'Chocobar  ', N'Sifuentes ', 3)
GO
SET IDENTITY_INSERT [dbo].[Patient] OFF
GO
ALTER TABLE [dbo].[Appointment] ADD  CONSTRAINT [DF_Appointment_attended]  DEFAULT ((0)) FOR [attended]
GO
ALTER TABLE [dbo].[Business] ADD  CONSTRAINT [DF_Business_deleted]  DEFAULT ((0)) FOR [deleted]
GO
ALTER TABLE [dbo].[Doctor] ADD  CONSTRAINT [DF_Doctor_deleted]  DEFAULT ((0)) FOR [deleted]
GO
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD  CONSTRAINT [FK_Doctor_Appointment] FOREIGN KEY([doctorId])
REFERENCES [dbo].[Doctor] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Appointment] CHECK CONSTRAINT [FK_Doctor_Appointment]
GO
ALTER TABLE [dbo].[Appointment]  WITH CHECK ADD  CONSTRAINT [FK_Patient_Appointment] FOREIGN KEY([patientId])
REFERENCES [dbo].[Patient] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Appointment] CHECK CONSTRAINT [FK_Patient_Appointment]
GO
ALTER TABLE [dbo].[Patient]  WITH CHECK ADD  CONSTRAINT [FK_Business_Patient] FOREIGN KEY([businessId])
REFERENCES [dbo].[Business] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Patient] CHECK CONSTRAINT [FK_Business_Patient]
GO
/****** Object:  StoredProcedure [dbo].[AppointmentsByBusinessId]    Script Date: 18/07/2017 14:49:04 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[AppointmentsByBusinessId]
	@businessId int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT DISTINCT D.name as Doctor, A.scheduledDate as 'Fecha de Cita', CONCAT(P.firstName, ' ', P.lastName, ' ', P.DNI) as Paciente, A.attended as Estado FROM Doctor D INNER JOIN Appointment A ON A.doctorId = D.id INNER JOIN Patient P ON A.patientId = P.id INNER JOIN Business B ON P.businessId = @businessId
END

GO
USE [master]
GO
ALTER DATABASE [WHCAsistencias] SET  READ_WRITE 
GO

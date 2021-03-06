USE [master]
GO
/****** Object:  Database [HomeworkDatabase]    Script Date: 6/16/2022 6:02:08 PM ******/
CREATE DATABASE [HomeworkDatabase] ON  PRIMARY 
( NAME = N'HomeworkDatabase', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\HomeworkDatabase.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'HomeworkDatabase_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\HomeworkDatabase_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HomeworkDatabase].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HomeworkDatabase] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [HomeworkDatabase] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [HomeworkDatabase] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [HomeworkDatabase] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [HomeworkDatabase] SET ARITHABORT OFF 
GO
ALTER DATABASE [HomeworkDatabase] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [HomeworkDatabase] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [HomeworkDatabase] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [HomeworkDatabase] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [HomeworkDatabase] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [HomeworkDatabase] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [HomeworkDatabase] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [HomeworkDatabase] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [HomeworkDatabase] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [HomeworkDatabase] SET  DISABLE_BROKER 
GO
ALTER DATABASE [HomeworkDatabase] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [HomeworkDatabase] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [HomeworkDatabase] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [HomeworkDatabase] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [HomeworkDatabase] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [HomeworkDatabase] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [HomeworkDatabase] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [HomeworkDatabase] SET RECOVERY FULL 
GO
ALTER DATABASE [HomeworkDatabase] SET  MULTI_USER 
GO
ALTER DATABASE [HomeworkDatabase] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [HomeworkDatabase] SET DB_CHAINING OFF 
GO
EXEC sys.sp_db_vardecimal_storage_format N'HomeworkDatabase', N'ON'
GO
USE [HomeworkDatabase]
GO
/****** Object:  Table [dbo].[Reservation]    Script Date: 6/16/2022 6:02:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reservation](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[StartLocation] [nvarchar](50) NULL,
	[EndLocation] [nvarchar](50) NULL,
	[TypeId] [int] NOT NULL,
 CONSTRAINT [PK_Reservation] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReservationType]    Script Date: 6/16/2022 6:02:08 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReservationType](
	[TypeId] [int] IDENTITY(1,1) NOT NULL,
	[Type] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ReservationType] PRIMARY KEY CLUSTERED 
(
	[TypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Reservation] ON 

INSERT [dbo].[Reservation] ([Id], [Name], [StartLocation], [EndLocation], [TypeId]) VALUES (2, N'Work', N'hanoi', N'hanoi', 1)
INSERT [dbo].[Reservation] ([Id], [Name], [StartLocation], [EndLocation], [TypeId]) VALUES (3, N'Play', N'hanoi', N'hanoi', 2)
INSERT [dbo].[Reservation] ([Id], [Name], [StartLocation], [EndLocation], [TypeId]) VALUES (4, N'Work2', N'hanoi', N'hanoi', 1)
INSERT [dbo].[Reservation] ([Id], [Name], [StartLocation], [EndLocation], [TypeId]) VALUES (5, N'work3', N'hanoi', N'hanoi', 1)
SET IDENTITY_INSERT [dbo].[Reservation] OFF
GO
SET IDENTITY_INSERT [dbo].[ReservationType] ON 

INSERT [dbo].[ReservationType] ([TypeId], [Type]) VALUES (1, N'Work')
INSERT [dbo].[ReservationType] ([TypeId], [Type]) VALUES (2, N'Play')
SET IDENTITY_INSERT [dbo].[ReservationType] OFF
GO
ALTER TABLE [dbo].[Reservation]  WITH CHECK ADD  CONSTRAINT [FK_Reservation_ReservationType] FOREIGN KEY([TypeId])
REFERENCES [dbo].[ReservationType] ([TypeId])
GO
ALTER TABLE [dbo].[Reservation] CHECK CONSTRAINT [FK_Reservation_ReservationType]
GO
USE [master]
GO
ALTER DATABASE [HomeworkDatabase] SET  READ_WRITE 
GO

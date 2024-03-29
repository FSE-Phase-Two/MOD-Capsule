USE [master]
GO
/****** Object:  Database [FSE_MOD]    Script Date: 15-11-2019 18:27:41 ******/
CREATE DATABASE [FSE_MOD]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'FSE_MOD', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\FSE_MOD.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'FSE_MOD_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\FSE_MOD_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [FSE_MOD] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [FSE_MOD].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [FSE_MOD] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [FSE_MOD] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [FSE_MOD] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [FSE_MOD] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [FSE_MOD] SET ARITHABORT OFF 
GO
ALTER DATABASE [FSE_MOD] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [FSE_MOD] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [FSE_MOD] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [FSE_MOD] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [FSE_MOD] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [FSE_MOD] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [FSE_MOD] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [FSE_MOD] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [FSE_MOD] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [FSE_MOD] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [FSE_MOD] SET  DISABLE_BROKER 
GO
ALTER DATABASE [FSE_MOD] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [FSE_MOD] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [FSE_MOD] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [FSE_MOD] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [FSE_MOD] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [FSE_MOD] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [FSE_MOD] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [FSE_MOD] SET RECOVERY FULL 
GO
ALTER DATABASE [FSE_MOD] SET  MULTI_USER 
GO
ALTER DATABASE [FSE_MOD] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [FSE_MOD] SET DB_CHAINING OFF 
GO
ALTER DATABASE [FSE_MOD] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [FSE_MOD] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'FSE_MOD', N'ON'
GO
USE [FSE_MOD]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 15-11-2019 18:27:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Mentor]    Script Date: 15-11-2019 18:27:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mentor](
	[MentorId] [int] IDENTITY(1,1) NOT NULL,
	[Password] [varchar](250) NOT NULL,
	[EmailId] [varchar](250) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[ContactNumber] [varchar](50) NOT NULL,
	[RegDatetime] [datetime2](7) NOT NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_Mentor] PRIMARY KEY CLUSTERED 
(
	[MentorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MentorCalender]    Script Date: 15-11-2019 18:27:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MentorCalender](
	[MentorCalenderId] [int] IDENTITY(1,1) NOT NULL,
	[StartDate] [datetime2](7) NOT NULL,
	[EndDate] [datetime2](7) NOT NULL,
	[StartTime] [time](7) NOT NULL,
	[EndTime] [time](7) NOT NULL,
	[MentorId] [int] NOT NULL,
	[TechnologyId] [int] NOT NULL,
 CONSTRAINT [PK_MentorCalender] PRIMARY KEY CLUSTERED 
(
	[MentorCalenderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[MentorTechnology]    Script Date: 15-11-2019 18:27:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MentorTechnology](
	[MentorTechnologyId] [int] IDENTITY(1,1) NOT NULL,
	[Experience] [int] NOT NULL,
	[SelfRating] [int] NOT NULL,
	[MentorId] [int] NOT NULL,
	[TechnologyId] [int] NOT NULL,
 CONSTRAINT [PK_MentorTechnology] PRIMARY KEY CLUSTERED 
(
	[MentorTechnologyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Payment]    Script Date: 15-11-2019 18:27:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Payment](
	[PaymentId] [int] IDENTITY(1,1) NOT NULL,
	[Amount] [float] NOT NULL,
	[TransactionDate] [datetime2](7) NOT NULL,
	[TransactionType] [varchar](250) NOT NULL,
	[Remark] [varchar](1000) NOT NULL,
	[MentorId] [int] NOT NULL,
 CONSTRAINT [PK_Payment] PRIMARY KEY CLUSTERED 
(
	[PaymentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Technology]    Script Date: 15-11-2019 18:27:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Technology](
	[TechnologyId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](250) NOT NULL,
	[TechnologyContent] [nvarchar](max) NOT NULL,
	[Prerequisite] [nvarchar](max) NOT NULL,
	[Duration] [int] NOT NULL,
	[Fees] [float] NOT NULL,
 CONSTRAINT [PK_Technology] PRIMARY KEY CLUSTERED 
(
	[TechnologyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Training]    Script Date: 15-11-2019 18:27:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Training](
	[TrainingId] [int] IDENTITY(1,1) NOT NULL,
	[Status] [varchar](50) NOT NULL,
	[Progress] [int] NOT NULL,
	[Rating] [int] NOT NULL,
	[AmountReceived] [float] NOT NULL,
	[StartDate] [datetime2](7) NOT NULL,
	[EndDate] [datetime2](7) NOT NULL,
	[StartTime] [time](7) NOT NULL,
	[EndTime] [time](7) NOT NULL,
	[UserId] [int] NOT NULL,
	[MentorId] [int] NOT NULL,
	[TechnologyId] [int] NOT NULL,
 CONSTRAINT [PK_Training] PRIMARY KEY CLUSTERED 
(
	[TrainingId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[User]    Script Date: 15-11-2019 18:27:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[User](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[Password] [varchar](250) NOT NULL,
	[EmailId] [varchar](250) NOT NULL,
	[FirstName] [varchar](50) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[ContactNumber] [varchar](50) NOT NULL,
	[RegDatetime] [datetime2](7) NOT NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Index [IX_MentorCalender_MentorId]    Script Date: 15-11-2019 18:27:41 ******/
CREATE NONCLUSTERED INDEX [IX_MentorCalender_MentorId] ON [dbo].[MentorCalender]
(
	[MentorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MentorCalender_TechnologyId]    Script Date: 15-11-2019 18:27:41 ******/
CREATE NONCLUSTERED INDEX [IX_MentorCalender_TechnologyId] ON [dbo].[MentorCalender]
(
	[TechnologyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MentorTechnology_MentorId]    Script Date: 15-11-2019 18:27:41 ******/
CREATE NONCLUSTERED INDEX [IX_MentorTechnology_MentorId] ON [dbo].[MentorTechnology]
(
	[MentorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_MentorTechnology_TechnologyId]    Script Date: 15-11-2019 18:27:41 ******/
CREATE NONCLUSTERED INDEX [IX_MentorTechnology_TechnologyId] ON [dbo].[MentorTechnology]
(
	[TechnologyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Payment_MentorId]    Script Date: 15-11-2019 18:27:41 ******/
CREATE NONCLUSTERED INDEX [IX_Payment_MentorId] ON [dbo].[Payment]
(
	[MentorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Training_MentorId]    Script Date: 15-11-2019 18:27:41 ******/
CREATE NONCLUSTERED INDEX [IX_Training_MentorId] ON [dbo].[Training]
(
	[MentorId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Training_TechnologyId]    Script Date: 15-11-2019 18:27:41 ******/
CREATE NONCLUSTERED INDEX [IX_Training_TechnologyId] ON [dbo].[Training]
(
	[TechnologyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [IX_Training_UserId]    Script Date: 15-11-2019 18:27:41 ******/
CREATE NONCLUSTERED INDEX [IX_Training_UserId] ON [dbo].[Training]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[MentorCalender]  WITH CHECK ADD  CONSTRAINT [FK_MentorCalender_Mentor_MentorId] FOREIGN KEY([MentorId])
REFERENCES [dbo].[Mentor] ([MentorId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[MentorCalender] CHECK CONSTRAINT [FK_MentorCalender_Mentor_MentorId]
GO
ALTER TABLE [dbo].[MentorCalender]  WITH CHECK ADD  CONSTRAINT [FK_MentorCalender_Technology_TechnologyId] FOREIGN KEY([TechnologyId])
REFERENCES [dbo].[Technology] ([TechnologyId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[MentorCalender] CHECK CONSTRAINT [FK_MentorCalender_Technology_TechnologyId]
GO
ALTER TABLE [dbo].[MentorTechnology]  WITH CHECK ADD  CONSTRAINT [FK_MentorTechnology_Mentor_MentorId] FOREIGN KEY([MentorId])
REFERENCES [dbo].[Mentor] ([MentorId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[MentorTechnology] CHECK CONSTRAINT [FK_MentorTechnology_Mentor_MentorId]
GO
ALTER TABLE [dbo].[MentorTechnology]  WITH CHECK ADD  CONSTRAINT [FK_MentorTechnology_Technology_TechnologyId] FOREIGN KEY([TechnologyId])
REFERENCES [dbo].[Technology] ([TechnologyId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[MentorTechnology] CHECK CONSTRAINT [FK_MentorTechnology_Technology_TechnologyId]
GO
ALTER TABLE [dbo].[Payment]  WITH CHECK ADD  CONSTRAINT [FK_Payment_Mentor_MentorId] FOREIGN KEY([MentorId])
REFERENCES [dbo].[Mentor] ([MentorId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Payment] CHECK CONSTRAINT [FK_Payment_Mentor_MentorId]
GO
ALTER TABLE [dbo].[Training]  WITH CHECK ADD  CONSTRAINT [FK_Training_Mentor_MentorId] FOREIGN KEY([MentorId])
REFERENCES [dbo].[Mentor] ([MentorId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Training] CHECK CONSTRAINT [FK_Training_Mentor_MentorId]
GO
ALTER TABLE [dbo].[Training]  WITH CHECK ADD  CONSTRAINT [FK_Training_Technology_TechnologyId] FOREIGN KEY([TechnologyId])
REFERENCES [dbo].[Technology] ([TechnologyId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Training] CHECK CONSTRAINT [FK_Training_Technology_TechnologyId]
GO
ALTER TABLE [dbo].[Training]  WITH CHECK ADD  CONSTRAINT [FK_Training_User_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([UserId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Training] CHECK CONSTRAINT [FK_Training_User_UserId]
GO
USE [master]
GO
ALTER DATABASE [FSE_MOD] SET  READ_WRITE 
GO

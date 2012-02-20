USE [master]
GO
/****** Object:  Database [HomeworkSubmission]    Script Date: 02/20/2012 21:39:05 ******/
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'HomeworkSubmission')
BEGIN
CREATE DATABASE [HomeworkSubmission] ON  PRIMARY 
( NAME = N'HomeworkSubmission', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\HomeworkSubmission.mdf' , SIZE = 2048KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'HomeworkSubmission_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\HomeworkSubmission_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
END
GO
ALTER DATABASE [HomeworkSubmission] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [HomeworkSubmission].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [HomeworkSubmission] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [HomeworkSubmission] SET ANSI_NULLS OFF
GO
ALTER DATABASE [HomeworkSubmission] SET ANSI_PADDING OFF
GO
ALTER DATABASE [HomeworkSubmission] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [HomeworkSubmission] SET ARITHABORT OFF
GO
ALTER DATABASE [HomeworkSubmission] SET AUTO_CLOSE OFF
GO
ALTER DATABASE [HomeworkSubmission] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [HomeworkSubmission] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [HomeworkSubmission] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [HomeworkSubmission] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [HomeworkSubmission] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [HomeworkSubmission] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [HomeworkSubmission] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [HomeworkSubmission] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [HomeworkSubmission] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [HomeworkSubmission] SET  DISABLE_BROKER
GO
ALTER DATABASE [HomeworkSubmission] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [HomeworkSubmission] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [HomeworkSubmission] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [HomeworkSubmission] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [HomeworkSubmission] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [HomeworkSubmission] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [HomeworkSubmission] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [HomeworkSubmission] SET  READ_WRITE
GO
ALTER DATABASE [HomeworkSubmission] SET RECOVERY SIMPLE
GO
ALTER DATABASE [HomeworkSubmission] SET  MULTI_USER
GO
ALTER DATABASE [HomeworkSubmission] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [HomeworkSubmission] SET DB_CHAINING OFF
GO
USE [HomeworkSubmission]
GO
/****** Object:  Table [dbo].[Students]    Script Date: 02/20/2012 21:39:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Students]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Students](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nchar](30) NOT NULL,
	[LastName] [nchar](30) NOT NULL,
	[Email] [nchar](30) NOT NULL,
	[AcademyID] [nchar](10) NULL,
 CONSTRAINT [PK_Students] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Courses]    Script Date: 02/20/2012 21:39:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Courses]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Courses](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](100) NOT NULL,
	[IsActive] [bit] NOT NULL,
 CONSTRAINT [PK_Courses] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[StudentsCourses]    Script Date: 02/20/2012 21:39:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StudentsCourses]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[StudentsCourses](
	[StudentID] [int] NOT NULL,
	[CourseID] [int] NOT NULL,
 CONSTRAINT [PK_StudentsCourses] PRIMARY KEY CLUSTERED 
(
	[StudentID] ASC,
	[CourseID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Topics]    Script Date: 02/20/2012 21:39:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Topics]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Topics](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[CourseID] [int] NOT NULL,
	[Name] [nchar](100) NOT NULL,
	[IsActive] [bit] NOT NULL,
	[ActiveFrom] [date] NULL,
	[ActiveTo] [date] NULL,
 CONSTRAINT [PK_Topics] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  Table [dbo].[Submissions]    Script Date: 02/20/2012 21:39:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Submissions]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Submissions](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[StudentID] [int] NOT NULL,
	[TopicID] [int] NOT NULL,
	[UploadDate] [date] NOT NULL,
	[MIMEType] [nchar](50) NOT NULL,
 CONSTRAINT [PK_Submissions] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
/****** Object:  ForeignKey [FK_StudentsCourses_Courses]    Script Date: 02/20/2012 21:39:06 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_StudentsCourses_Courses]') AND parent_object_id = OBJECT_ID(N'[dbo].[StudentsCourses]'))
ALTER TABLE [dbo].[StudentsCourses]  WITH CHECK ADD  CONSTRAINT [FK_StudentsCourses_Courses] FOREIGN KEY([CourseID])
REFERENCES [dbo].[Courses] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_StudentsCourses_Courses]') AND parent_object_id = OBJECT_ID(N'[dbo].[StudentsCourses]'))
ALTER TABLE [dbo].[StudentsCourses] CHECK CONSTRAINT [FK_StudentsCourses_Courses]
GO
/****** Object:  ForeignKey [FK_StudentsCourses_Students]    Script Date: 02/20/2012 21:39:06 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_StudentsCourses_Students]') AND parent_object_id = OBJECT_ID(N'[dbo].[StudentsCourses]'))
ALTER TABLE [dbo].[StudentsCourses]  WITH CHECK ADD  CONSTRAINT [FK_StudentsCourses_Students] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Students] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_StudentsCourses_Students]') AND parent_object_id = OBJECT_ID(N'[dbo].[StudentsCourses]'))
ALTER TABLE [dbo].[StudentsCourses] CHECK CONSTRAINT [FK_StudentsCourses_Students]
GO
/****** Object:  ForeignKey [FK_Topics_Courses]    Script Date: 02/20/2012 21:39:06 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Topics_Courses]') AND parent_object_id = OBJECT_ID(N'[dbo].[Topics]'))
ALTER TABLE [dbo].[Topics]  WITH CHECK ADD  CONSTRAINT [FK_Topics_Courses] FOREIGN KEY([CourseID])
REFERENCES [dbo].[Courses] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Topics_Courses]') AND parent_object_id = OBJECT_ID(N'[dbo].[Topics]'))
ALTER TABLE [dbo].[Topics] CHECK CONSTRAINT [FK_Topics_Courses]
GO
/****** Object:  ForeignKey [FK_Submissions_Students]    Script Date: 02/20/2012 21:39:06 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Submissions_Students]') AND parent_object_id = OBJECT_ID(N'[dbo].[Submissions]'))
ALTER TABLE [dbo].[Submissions]  WITH CHECK ADD  CONSTRAINT [FK_Submissions_Students] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Students] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Submissions_Students]') AND parent_object_id = OBJECT_ID(N'[dbo].[Submissions]'))
ALTER TABLE [dbo].[Submissions] CHECK CONSTRAINT [FK_Submissions_Students]
GO
/****** Object:  ForeignKey [FK_Submissions_Topics]    Script Date: 02/20/2012 21:39:06 ******/
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Submissions_Topics]') AND parent_object_id = OBJECT_ID(N'[dbo].[Submissions]'))
ALTER TABLE [dbo].[Submissions]  WITH CHECK ADD  CONSTRAINT [FK_Submissions_Topics] FOREIGN KEY([TopicID])
REFERENCES [dbo].[Topics] ([ID])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Submissions_Topics]') AND parent_object_id = OBJECT_ID(N'[dbo].[Submissions]'))
ALTER TABLE [dbo].[Submissions] CHECK CONSTRAINT [FK_Submissions_Topics]
GO

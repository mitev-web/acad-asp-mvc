USE [master]
GO
/****** Object:  Database [WebCalendar]    Script Date: 01/18/2012 16:24:26 ******/
CREATE DATABASE [WebCalendar] ON  PRIMARY 
( NAME = N'WebCalendar', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\WebCalendar.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'WebCalendar_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL10.SQLEXPRESS\MSSQL\DATA\WebCalendar_log.ldf' , SIZE = 2560KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [WebCalendar] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [WebCalendar].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [WebCalendar] SET ANSI_NULL_DEFAULT OFF
GO
ALTER DATABASE [WebCalendar] SET ANSI_NULLS OFF
GO
ALTER DATABASE [WebCalendar] SET ANSI_PADDING OFF
GO
ALTER DATABASE [WebCalendar] SET ANSI_WARNINGS OFF
GO
ALTER DATABASE [WebCalendar] SET ARITHABORT OFF
GO
ALTER DATABASE [WebCalendar] SET AUTO_CLOSE ON
GO
ALTER DATABASE [WebCalendar] SET AUTO_CREATE_STATISTICS ON
GO
ALTER DATABASE [WebCalendar] SET AUTO_SHRINK OFF
GO
ALTER DATABASE [WebCalendar] SET AUTO_UPDATE_STATISTICS ON
GO
ALTER DATABASE [WebCalendar] SET CURSOR_CLOSE_ON_COMMIT OFF
GO
ALTER DATABASE [WebCalendar] SET CURSOR_DEFAULT  GLOBAL
GO
ALTER DATABASE [WebCalendar] SET CONCAT_NULL_YIELDS_NULL OFF
GO
ALTER DATABASE [WebCalendar] SET NUMERIC_ROUNDABORT OFF
GO
ALTER DATABASE [WebCalendar] SET QUOTED_IDENTIFIER OFF
GO
ALTER DATABASE [WebCalendar] SET RECURSIVE_TRIGGERS OFF
GO
ALTER DATABASE [WebCalendar] SET  DISABLE_BROKER
GO
ALTER DATABASE [WebCalendar] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO
ALTER DATABASE [WebCalendar] SET DATE_CORRELATION_OPTIMIZATION OFF
GO
ALTER DATABASE [WebCalendar] SET TRUSTWORTHY OFF
GO
ALTER DATABASE [WebCalendar] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO
ALTER DATABASE [WebCalendar] SET PARAMETERIZATION SIMPLE
GO
ALTER DATABASE [WebCalendar] SET READ_COMMITTED_SNAPSHOT OFF
GO
ALTER DATABASE [WebCalendar] SET HONOR_BROKER_PRIORITY OFF
GO
ALTER DATABASE [WebCalendar] SET  READ_WRITE
GO
ALTER DATABASE [WebCalendar] SET RECOVERY SIMPLE
GO
ALTER DATABASE [WebCalendar] SET  MULTI_USER
GO
ALTER DATABASE [WebCalendar] SET PAGE_VERIFY CHECKSUM
GO
ALTER DATABASE [WebCalendar] SET DB_CHAINING OFF
GO
USE [WebCalendar]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 01/18/2012 16:24:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Description] [text] NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [UQ__Categori__737584F600551192] UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Categories] ON
INSERT [dbo].[Categories] ([ID], [Description], [Name]) VALUES (1, N'This is the default category', N'Default')
INSERT [dbo].[Categories] ([ID], [Description], [Name]) VALUES (2, N'Meetings with high priority', N'Important')
SET IDENTITY_INSERT [dbo].[Categories] OFF
/****** Object:  Table [dbo].[Users]    Script Date: 01/18/2012 16:24:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](255) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[PasswordSalt] [nvarchar](255) NOT NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [UQ__Users__A9D105342F10007B] UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [UQ__Users__C9F2845631EC6D26] UNIQUE NONCLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Users] ON
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (1, N'test', N'test123', N'pesho83@abv.bg', N'Petur', N'Stoyanov', N'2sdfsdifj29')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (2, N'Ivan', N'fisjdf9', N'ivan.petrov@gmail.com', N'Ivan', N'Petrov', N'sdfsdfsdgf')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (4, N'Maya91', N'bg_djsdf2', N'maya.bab@gmail.com', N'Maya', N'Kostova', N'dfsdfsdf')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3659, N'pessdfsdro1', N'jj1', N'messfddry1@mail.bg', N'Ivan1', N'Petrov1', N'1')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3660, N'pessdfsdro2', N'jj2', N'messfddry2@mail.bg', N'Ivan2', N'Petrov2', N'2')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3661, N'pessdfsdro3', N'jj3', N'messfddry3@mail.bg', N'Ivan3', N'Petrov3', N'3')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3662, N'pessdfsdro4', N'jj4', N'messfddry4@mail.bg', N'Ivan4', N'Petrov4', N'4')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3663, N'pessdfsdro5', N'jj5', N'messfddry5@mail.bg', N'Ivan5', N'Petrov5', N'5')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3664, N'pessdfsdro6', N'jj6', N'messfddry6@mail.bg', N'Ivan6', N'Petrov6', N'6')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3665, N'pessdfsdro7', N'jj7', N'messfddry7@mail.bg', N'Ivan7', N'Petrov7', N'7')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3666, N'pessdfsdro8', N'jj8', N'messfddry8@mail.bg', N'Ivan8', N'Petrov8', N'8')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3667, N'pessdfsdro9', N'jj9', N'messfddry9@mail.bg', N'Ivan9', N'Petrov9', N'9')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3668, N'pessdfsdro10', N'jj10', N'messfddry10@mail.bg', N'Ivan10', N'Petrov10', N'10')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3669, N'pessdfsdro11', N'jj11', N'messfddry11@mail.bg', N'Ivan11', N'Petrov11', N'11')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3670, N'pessdfsdro12', N'jj12', N'messfddry12@mail.bg', N'Ivan12', N'Petrov12', N'12')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3671, N'pessdfsdro13', N'jj13', N'messfddry13@mail.bg', N'Ivan13', N'Petrov13', N'13')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3672, N'pessdfsdro14', N'jj14', N'messfddry14@mail.bg', N'Ivan14', N'Petrov14', N'14')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3673, N'pessdfsdro15', N'jj15', N'messfddry15@mail.bg', N'Ivan15', N'Petrov15', N'15')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3674, N'pessdfsdro16', N'jj16', N'messfddry16@mail.bg', N'Ivan16', N'Petrov16', N'16')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3675, N'pessdfsdro17', N'jj17', N'messfddry17@mail.bg', N'Ivan17', N'Petrov17', N'17')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3676, N'pessdfsdro18', N'jj18', N'messfddry18@mail.bg', N'Ivan18', N'Petrov18', N'18')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3677, N'pessdfsdro19', N'jj19', N'messfddry19@mail.bg', N'Ivan19', N'Petrov19', N'19')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3678, N'pessdfsdro20', N'jj20', N'messfddry20@mail.bg', N'Ivan20', N'Petrov20', N'20')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3679, N'pessdfsdro21', N'jj21', N'messfddry21@mail.bg', N'Ivan21', N'Petrov21', N'21')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3680, N'pessdfsdro22', N'jj22', N'messfddry22@mail.bg', N'Ivan22', N'Petrov22', N'22')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3681, N'pessdfsdro23', N'jj23', N'messfddry23@mail.bg', N'Ivan23', N'Petrov23', N'23')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3682, N'pessdfsdro24', N'jj24', N'messfddry24@mail.bg', N'Ivan24', N'Petrov24', N'24')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3683, N'pessdfsdro25', N'jj25', N'messfddry25@mail.bg', N'Ivan25', N'Petrov25', N'25')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3684, N'pessdfsdro26', N'jj26', N'messfddry26@mail.bg', N'Ivan26', N'Petrov26', N'26')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3685, N'pessdfsdro27', N'jj27', N'messfddry27@mail.bg', N'Ivan27', N'Petrov27', N'27')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3686, N'pessdfsdro28', N'jj28', N'messfddry28@mail.bg', N'Ivan28', N'Petrov28', N'28')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3687, N'pessdfsdro29', N'jj29', N'messfddry29@mail.bg', N'Ivan29', N'Petrov29', N'29')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3688, N'pessdfsdro30', N'jj30', N'messfddry30@mail.bg', N'Ivan30', N'Petrov30', N'30')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3689, N'pessdfs1', N'jj1', N'messfddry1@abv.bg', N'Ivan1', N'Petrov1', N'1')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3690, N'pessdfs2', N'jj2', N'messfddry2@abv.bg', N'Ivan2', N'Petrov2', N'2')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3691, N'pessdfs3', N'jj3', N'messfddry3@abv.bg', N'Ivan3', N'Petrov3', N'3')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3692, N'pessdfs4', N'jj4', N'messfddry4@abv.bg', N'Ivan4', N'Petrov4', N'4')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3693, N'pessdfs5', N'jj5', N'messfddry5@abv.bg', N'Ivan5', N'Petrov5', N'5')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3694, N'pessdfs6', N'jj6', N'messfddry6@abv.bg', N'Ivan6', N'Petrov6', N'6')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3695, N'pessdfs7', N'jj7', N'messfddry7@abv.bg', N'Ivan7', N'Petrov7', N'7')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3696, N'pessdfs8', N'jj8', N'messfddry8@abv.bg', N'Ivan8', N'Petrov8', N'8')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3697, N'pessdfs9', N'jj9', N'messfddry9@abv.bg', N'Ivan9', N'Petrov9', N'9')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3698, N'pessdfs10', N'jj10', N'messfddry10@abv.bg', N'Ivan10', N'Petrov10', N'10')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3699, N'pessdfs11', N'jj11', N'messfddry11@abv.bg', N'Ivan11', N'Petrov11', N'11')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3700, N'pessdfs12', N'jj12', N'messfddry12@abv.bg', N'Ivan12', N'Petrov12', N'12')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3701, N'pessdfs13', N'jj13', N'messfddry13@abv.bg', N'Ivan13', N'Petrov13', N'13')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3702, N'pessdfs14', N'jj14', N'messfddry14@abv.bg', N'Ivan14', N'Petrov14', N'14')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3703, N'pessdfs15', N'jj15', N'messfddry15@abv.bg', N'Ivan15', N'Petrov15', N'15')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3704, N'pessdfs16', N'jj16', N'messfddry16@abv.bg', N'Ivan16', N'Petrov16', N'16')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3705, N'pessdfs17', N'jj17', N'messfddry17@abv.bg', N'Ivan17', N'Petrov17', N'17')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3706, N'pessdfs18', N'jj18', N'messfddry18@abv.bg', N'Ivan18', N'Petrov18', N'18')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3707, N'pessdfs19', N'jj19', N'messfddry19@abv.bg', N'Ivan19', N'Petrov19', N'19')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3708, N'pessdfs20', N'jj20', N'messfddry20@abv.bg', N'Ivan20', N'Petrov20', N'20')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3709, N'pessdfs21', N'jj21', N'messfddry21@abv.bg', N'Ivan21', N'Petrov21', N'21')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3710, N'pessdfs22', N'jj22', N'messfddry22@abv.bg', N'Ivan22', N'Petrov22', N'22')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3711, N'pessdfs23', N'jj23', N'messfddry23@abv.bg', N'Ivan23', N'Petrov23', N'23')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3712, N'pessdfs24', N'jj24', N'messfddry24@abv.bg', N'Ivan24', N'Petrov24', N'24')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3713, N'pessdfs25', N'jj25', N'messfddry25@abv.bg', N'Ivan25', N'Petrov25', N'25')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3714, N'pessdfs26', N'jj26', N'messfddry26@abv.bg', N'Ivan26', N'Petrov26', N'26')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3715, N'pessdfs27', N'jj27', N'messfddry27@abv.bg', N'Ivan27', N'Petrov27', N'27')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3716, N'pessdfs28', N'jj28', N'messfddry28@abv.bg', N'Ivan28', N'Petrov28', N'28')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3717, N'pessdfs29', N'jj29', N'messfddry29@abv.bg', N'Ivan29', N'Petrov29', N'29')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3718, N'pessdfs30', N'jj30', N'messfddry30@abv.bg', N'Ivan30', N'Petrov30', N'30')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3719, N'erererer', N'erererer', N'erererer', NULL, NULL, N'test')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3720, N'petka', N'BB8B75BDF7856A1F6F95EC6D631C4521D33CFDC8', N'petka', NULL, NULL, N'ZmOSqiYNHnNRHB1Hu3yR8l+0FMX3B28A9I0Fwf5ds8U=')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3721, N'tester', N'BA12DE8E2DEF4A5EA0D554A4A56FB4B8DA3032CF', N'fdsfsfd', NULL, NULL, N'BHAlBHcdfyimGy4WiAE6RnnpVGz9JsBCKxcf5h3MWvw=')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3722, N'y0y0', N'8FDB459F92E409B9EF60B2F1F1A0A0B37F1A4E21', N'fdsf', NULL, NULL, N'FVNC+c7qAENj40JQN1/fdht38asZf9EAqsTiTKIF3Ag=')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3723, N'penka', N'8829EEC2B7AD898905AC06B74F7654CA11585A87', N'sdfsdf', NULL, NULL, N'IrLvj7RQUL3WgLZu92PBUt4kpbo4pirTzD8D2MYCTp4=')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3724, N'penkaa', N'8740970A6038C73297A0FB4A729B6653727BE1B1', N'sdfsdfsdfs', NULL, NULL, N'FcHRgb7fGWxTwXVeRQpJ4ZFaPNB92rD2RE+u33Q9Lj4=')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3725, N'fff', N'9049F8EF6F355CB73E1153FF1355B9B3D024452A', N'sdfsdfsdfsfdsdfsdf', NULL, NULL, N'gND/+ePLmsFbLmvcM/mKm1QWvXwrLb8jPadFm4LR1E8=')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3726, N'testFF', N'67BF9DFA0B72C2165C34643F20A48BAA1B8D631D', N'sdfsdfsdfsfdsdfsdf@abv.bg', NULL, NULL, N'zPoygYd4jupWJNK7DshxhqVqbthC5hN8bZQ1boLWnvM=')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3727, N'test334', N'4B2E684A5F15114E71357E14D95E7412A34AD48D', N'sdfsdf@fdsf.df', NULL, NULL, N'+cOu9Ty721J6QT9R7L/yx6En/IJgDkG3B5ukj5XfMTY=')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3728, N'testFF1', N'6B14BA6506F0C867D032B4B05DCCF69206673DD0', N'testeeer', NULL, NULL, N'gSxCx42IKlAzUdD2ENTEPH5Wf7LHhHn+i03KcnO4vgM=')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3729, N'qqJt17', N'D15902CE08FACE5FE3BE5E75F246CE14A3D9DC29', N'testwewq1', NULL, NULL, N'KfQJz135xxW8RAEdoTu227qvTv4am+Pr+QULKyxdgSg=')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3730, N'qqJt171', N'9354EA40A26F287F50438825096CC3F53135E2FD', N'testsfdsdf', NULL, NULL, N'qEbL3tDI70ayUC6IOmTIMC/0yj8ZZQZ7tRtZwkc2EM8=')
INSERT [dbo].[Users] ([ID], [UserName], [Password], [Email], [FirstName], [LastName], [PasswordSalt]) VALUES (3731, N'fefefe', N'3247A914D989AC72CD15BBC0E3B69A14CD511905', N'fsdfsdfsdf', NULL, NULL, N'GSN5JNZfRRejFxbRoetrMkRsDZhrLYb9fLcGpso6I4c=')
SET IDENTITY_INSERT [dbo].[Users] OFF
/****** Object:  Table [dbo].[Meetings]    Script Date: 01/18/2012 16:24:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Meetings](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Date] [smalldatetime] NOT NULL,
	[Description] [text] NOT NULL,
	[Location] [nvarchar](50) NULL,
	[UserID] [int] NOT NULL,
	[CategoryID] [int] NOT NULL,
 CONSTRAINT [PK_Meetings] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Meetings] ON
INSERT [dbo].[Meetings] ([ID], [Date], [Description], [Location], [UserID], [CategoryID]) VALUES (1, CAST(0xA11A0000 AS SmallDateTime), N'Office Meeting', N'Small Hall', 2, 2)
INSERT [dbo].[Meetings] ([ID], [Date], [Description], [Location], [UserID], [CategoryID]) VALUES (2, CAST(0x9FE60000 AS SmallDateTime), N'Job Interview', N'My office', 2, 1)
INSERT [dbo].[Meetings] ([ID], [Date], [Description], [Location], [UserID], [CategoryID]) VALUES (4, CAST(0x9FE60000 AS SmallDateTime), N'Meeting with John', N'Small Hall', 4, 1)
SET IDENTITY_INSERT [dbo].[Meetings] OFF
/****** Object:  Table [dbo].[Contacts]    Script Date: 01/18/2012 16:24:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Contacts](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Email] [nvarchar](50) NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Phone] [nvarchar](50) NULL,
	[Address] [nvarchar](50) NULL,
	[Note] [text] NULL,
	[UserID] [int] NOT NULL,
 CONSTRAINT [PK_Contacts] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [UQ__Contacts__A9D105343D5E1FD2] UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Contacts] ON
INSERT [dbo].[Contacts] ([ID], [Email], [FirstName], [LastName], [Phone], [Address], [Note], [UserID]) VALUES (2, NULL, N'Stoyan', N'Mutafov', NULL, NULL, NULL, 4)
INSERT [dbo].[Contacts] ([ID], [Email], [FirstName], [LastName], [Phone], [Address], [Note], [UserID]) VALUES (3, N'mary_91@abv.bg', N'Maria', N'Stomanova', N'088334223', N'Sofia, Carigradsko shose 45', NULL, 2)
INSERT [dbo].[Contacts] ([ID], [Email], [FirstName], [LastName], [Phone], [Address], [Note], [UserID]) VALUES (4, N'ivanka17@gmail.com', N'Ivanka', N'Kocheva', N'088313232', NULL, NULL, 2)
INSERT [dbo].[Contacts] ([ID], [Email], [FirstName], [LastName], [Phone], [Address], [Note], [UserID]) VALUES (5, N'pepa1@abv.bg', N'Pepa1', N'Popova1', N'+35913211', N'1', N'fggf gfdsg fd df dfg df gdf gdfgdf gdfgfdg dfgdfg df gfd gdfg fdg ', 4)
INSERT [dbo].[Contacts] ([ID], [Email], [FirstName], [LastName], [Phone], [Address], [Note], [UserID]) VALUES (6, N'pepa2@abv.bg', N'Pepa2', N'Popova2', N'+35923212', N'2', N'', 4)
INSERT [dbo].[Contacts] ([ID], [Email], [FirstName], [LastName], [Phone], [Address], [Note], [UserID]) VALUES (7, N'pepa3@abv.bg', N'Pepa3', N'Popova3', N'+35933213', N'3', N'', 4)
INSERT [dbo].[Contacts] ([ID], [Email], [FirstName], [LastName], [Phone], [Address], [Note], [UserID]) VALUES (8, N'pepa4@abv.bg', N'Pepa4', N'Popova4', N'+35943214', N'4', N'', 4)
INSERT [dbo].[Contacts] ([ID], [Email], [FirstName], [LastName], [Phone], [Address], [Note], [UserID]) VALUES (10, N'pepa6@abv.bg', N'Pepa6', N'Popova6', N'+35963216', N'6', N'', 4)
INSERT [dbo].[Contacts] ([ID], [Email], [FirstName], [LastName], [Phone], [Address], [Note], [UserID]) VALUES (11, N'pepa7@abv.bg', N'Pepa7', N'Popova7', N'+35973217', N'7', N'', 4)
INSERT [dbo].[Contacts] ([ID], [Email], [FirstName], [LastName], [Phone], [Address], [Note], [UserID]) VALUES (12, N'pepa8@abv.bg', N'Pepa8', N'Popova8', N'+35983218', N'8', N'', 4)
INSERT [dbo].[Contacts] ([ID], [Email], [FirstName], [LastName], [Phone], [Address], [Note], [UserID]) VALUES (13, N'pepa9@abv.bg', N'Pepa9', N'Popova9', N'+35993219', N'9', N'', 4)
INSERT [dbo].[Contacts] ([ID], [Email], [FirstName], [LastName], [Phone], [Address], [Note], [UserID]) VALUES (14, N'pepa10@abv.bg', N'Pepa10', N'Popova10', N'+3591032110', N'10', N'', 4)
INSERT [dbo].[Contacts] ([ID], [Email], [FirstName], [LastName], [Phone], [Address], [Note], [UserID]) VALUES (15, N'pepa11@abv.bg', N'Pepa11', N'Popova11', N'+3591132111', N'11', N'', 4)
INSERT [dbo].[Contacts] ([ID], [Email], [FirstName], [LastName], [Phone], [Address], [Note], [UserID]) VALUES (16, N'pepa12@abv.bg', N'Pepa12', N'Popova12', N'+3591232112', N'12', N'', 4)
INSERT [dbo].[Contacts] ([ID], [Email], [FirstName], [LastName], [Phone], [Address], [Note], [UserID]) VALUES (17, N'pepa13@abv.bg', N'Pepa13', N'Popova13', N'+3591332113', N'13', N'', 4)
INSERT [dbo].[Contacts] ([ID], [Email], [FirstName], [LastName], [Phone], [Address], [Note], [UserID]) VALUES (18, N'pepa14@abv.bg', N'Pepa14', N'Popova14', N'+3591432114', N'14', N'', 4)
INSERT [dbo].[Contacts] ([ID], [Email], [FirstName], [LastName], [Phone], [Address], [Note], [UserID]) VALUES (19, N'pepa15@abv.bg', N'Pepa15', N'Popova15', N'+3591532115', N'15', N'', 4)
INSERT [dbo].[Contacts] ([ID], [Email], [FirstName], [LastName], [Phone], [Address], [Note], [UserID]) VALUES (20, N'pepa16@abv.bg', N'Pepa16', N'Popova16', N'+3591632116', N'16', N'', 4)
INSERT [dbo].[Contacts] ([ID], [Email], [FirstName], [LastName], [Phone], [Address], [Note], [UserID]) VALUES (21, N'pepa17@abv.bg', N'Pepa17', N'Popova17', N'+3591732117', N'17', N'', 4)
INSERT [dbo].[Contacts] ([ID], [Email], [FirstName], [LastName], [Phone], [Address], [Note], [UserID]) VALUES (22, N'pepa18@abv.bg', N'Pepa18', N'Popova18', N'+3591832118', N'18', N'', 4)
INSERT [dbo].[Contacts] ([ID], [Email], [FirstName], [LastName], [Phone], [Address], [Note], [UserID]) VALUES (23, N'pepa19@abv.bg', N'Pepa19', N'Popova19', N'+3591932119', N'19', N'', 4)
INSERT [dbo].[Contacts] ([ID], [Email], [FirstName], [LastName], [Phone], [Address], [Note], [UserID]) VALUES (24, N'pepa20@abv.bg', N'Pepa20', N'Popova20', N'+3592032120', N'20', N'', 4)
INSERT [dbo].[Contacts] ([ID], [Email], [FirstName], [LastName], [Phone], [Address], [Note], [UserID]) VALUES (25, N'pepa21@abv.bg', N'Pepa21', N'Popova21', N'+3592132121', N'21', N'', 4)
INSERT [dbo].[Contacts] ([ID], [Email], [FirstName], [LastName], [Phone], [Address], [Note], [UserID]) VALUES (26, N'pepa22@abv.bg', N'Pepa22', N'Popova22', N'+3592232122', N'22', N'', 4)
INSERT [dbo].[Contacts] ([ID], [Email], [FirstName], [LastName], [Phone], [Address], [Note], [UserID]) VALUES (27, N'pepa23@abv.bg', N'Pepa23', N'Popova23', N'+3592332123', N'23', N'', 4)
INSERT [dbo].[Contacts] ([ID], [Email], [FirstName], [LastName], [Phone], [Address], [Note], [UserID]) VALUES (28, N'pepa24@abv.bg', N'Pepa24', N'Popova24', N'+3592432124', N'24', N'', 4)
INSERT [dbo].[Contacts] ([ID], [Email], [FirstName], [LastName], [Phone], [Address], [Note], [UserID]) VALUES (29, N'pepa25@abv.bg', N'Pepa25', N'Popova25', N'+3592532125', N'25', N'', 4)
INSERT [dbo].[Contacts] ([ID], [Email], [FirstName], [LastName], [Phone], [Address], [Note], [UserID]) VALUES (30, N'pepa26@abv.bg', N'Pepa26', N'Popova26', N'+3592632126', N'26', N'', 4)
INSERT [dbo].[Contacts] ([ID], [Email], [FirstName], [LastName], [Phone], [Address], [Note], [UserID]) VALUES (31, N'pepa27@abv.bg', N'Pepa27', N'Popova27', N'+3592732127', N'27', N'', 4)
INSERT [dbo].[Contacts] ([ID], [Email], [FirstName], [LastName], [Phone], [Address], [Note], [UserID]) VALUES (32, N'pepa28@abv.bg', N'Pepa28', N'Popova28', N'+3592832128', N'28', N'', 4)
INSERT [dbo].[Contacts] ([ID], [Email], [FirstName], [LastName], [Phone], [Address], [Note], [UserID]) VALUES (33, N'pepa29@abv.bg', N'Pepa29', N'Popova29', N'+3592932129', N'29', N'', 4)
INSERT [dbo].[Contacts] ([ID], [Email], [FirstName], [LastName], [Phone], [Address], [Note], [UserID]) VALUES (34, N'pepa30@abv.bg', N'Pepa30', N'Popova30', N'+3593032130', N'30', N'', 4)
INSERT [dbo].[Contacts] ([ID], [Email], [FirstName], [LastName], [Phone], [Address], [Note], [UserID]) VALUES (35, N'pepa31@abv.bg', N'Pepa31', N'Popova31', N'+3593132131', N'31', N'', 4)
INSERT [dbo].[Contacts] ([ID], [Email], [FirstName], [LastName], [Phone], [Address], [Note], [UserID]) VALUES (36, N'pepa32@abv.bg', N'Pepa32', N'Popova32', N'+3593232132', N'32', N'', 4)
INSERT [dbo].[Contacts] ([ID], [Email], [FirstName], [LastName], [Phone], [Address], [Note], [UserID]) VALUES (37, N'pepa33@abv.bg', N'Pepa33', N'Popova33', N'+3593332133', N'33', N'', 4)
INSERT [dbo].[Contacts] ([ID], [Email], [FirstName], [LastName], [Phone], [Address], [Note], [UserID]) VALUES (38, N'pepa34@abv.bg', N'Pepa34', N'Popova34', N'+3593432134', N'34', N'', 4)
INSERT [dbo].[Contacts] ([ID], [Email], [FirstName], [LastName], [Phone], [Address], [Note], [UserID]) VALUES (39, N'pepa35@abv.bg', N'Pepa35', N'Popova35', N'+3593532135', N'35', N'', 4)
INSERT [dbo].[Contacts] ([ID], [Email], [FirstName], [LastName], [Phone], [Address], [Note], [UserID]) VALUES (40, N'pepa36@abv.bg', N'Pepa36', N'Popova36', N'+3593632136', N'36', N'', 4)
INSERT [dbo].[Contacts] ([ID], [Email], [FirstName], [LastName], [Phone], [Address], [Note], [UserID]) VALUES (41, N'pepa37@abv.bg', N'Pepa37', N'Popova37', N'+3593732137', N'37', N'', 4)
INSERT [dbo].[Contacts] ([ID], [Email], [FirstName], [LastName], [Phone], [Address], [Note], [UserID]) VALUES (42, N'pepa38@abv.bg', N'Pepa38', N'Popova38', N'+3593832138', N'38', N'', 4)
INSERT [dbo].[Contacts] ([ID], [Email], [FirstName], [LastName], [Phone], [Address], [Note], [UserID]) VALUES (43, N'pepa39@abv.bg', N'Pepa39', N'Popova39', N'+3593932139', N'39', N'', 4)
INSERT [dbo].[Contacts] ([ID], [Email], [FirstName], [LastName], [Phone], [Address], [Note], [UserID]) VALUES (44, N'pepa40@abv.bg', N'Pepa40', N'Popova40', N'+3594032140', N'40', N'', 4)
INSERT [dbo].[Contacts] ([ID], [Email], [FirstName], [LastName], [Phone], [Address], [Note], [UserID]) VALUES (45, N'pepa41@abv.bg', N'Pepa41', N'Popova41', N'+3594132141', N'41', N'', 4)
INSERT [dbo].[Contacts] ([ID], [Email], [FirstName], [LastName], [Phone], [Address], [Note], [UserID]) VALUES (46, N'pepa42@abv.bg', N'Pepa42', N'Popova42', N'+3594232142', N'42', N'', 4)
INSERT [dbo].[Contacts] ([ID], [Email], [FirstName], [LastName], [Phone], [Address], [Note], [UserID]) VALUES (47, N'pepa43@abv.bg', N'Pepa43', N'Popova43', N'+3594332143', N'43', N'', 4)
INSERT [dbo].[Contacts] ([ID], [Email], [FirstName], [LastName], [Phone], [Address], [Note], [UserID]) VALUES (48, N'pepa44@abv.bg', N'Pepa44', N'Popova31', N'+3594432144', N'44', NULL, 4)
INSERT [dbo].[Contacts] ([ID], [Email], [FirstName], [LastName], [Phone], [Address], [Note], [UserID]) VALUES (49, N'pepa45@abv.bg', N'Pepa45', N'Popova45', N'+3594532145', N'45', N'', 4)
INSERT [dbo].[Contacts] ([ID], [Email], [FirstName], [LastName], [Phone], [Address], [Note], [UserID]) VALUES (50, N'pepa46@abv.bg', N'Pepa46', N'Popova46', N'+3594632146', N'46', N'', 4)
INSERT [dbo].[Contacts] ([ID], [Email], [FirstName], [LastName], [Phone], [Address], [Note], [UserID]) VALUES (51, N'pepa47@abv.bg', N'Pepa47', N'Popova47', N'+3594732147', N'47', N'', 4)
INSERT [dbo].[Contacts] ([ID], [Email], [FirstName], [LastName], [Phone], [Address], [Note], [UserID]) VALUES (52, N'pepa48@abv.bg', N'Pepa48', N'Popova48', N'+3594832148', N'48', N'', 4)
INSERT [dbo].[Contacts] ([ID], [Email], [FirstName], [LastName], [Phone], [Address], [Note], [UserID]) VALUES (54, N'pepa50@abv.bg', N'Pepa50', N'Popova50', N'+3595032150', N'50', N'', 4)
INSERT [dbo].[Contacts] ([ID], [Email], [FirstName], [LastName], [Phone], [Address], [Note], [UserID]) VALUES (55, N'pepa51@abv.bg', N'Pepa51', N'Popova51', N'+3595132151', N'51', N'', 4)
INSERT [dbo].[Contacts] ([ID], [Email], [FirstName], [LastName], [Phone], [Address], [Note], [UserID]) VALUES (56, N'pepa52@abv.bg', N'Pepa52', N'Popova52', N'+3595232152', N'52', N'', 4)
INSERT [dbo].[Contacts] ([ID], [Email], [FirstName], [LastName], [Phone], [Address], [Note], [UserID]) VALUES (57, N'pepa53@abv.bg', N'Pepa53', N'Popova53', N'+3595332153', N'53', N'', 4)
INSERT [dbo].[Contacts] ([ID], [Email], [FirstName], [LastName], [Phone], [Address], [Note], [UserID]) VALUES (58, N'pepa54@abv.bg', N'Pepa54', N'Popova54', N'+3595432154', N'54', N'', 4)
INSERT [dbo].[Contacts] ([ID], [Email], [FirstName], [LastName], [Phone], [Address], [Note], [UserID]) VALUES (59, N'pepa55@abv.bg', N'Pepa55', N'Popova55', N'+3595532155', N'55', N'', 4)
INSERT [dbo].[Contacts] ([ID], [Email], [FirstName], [LastName], [Phone], [Address], [Note], [UserID]) VALUES (60, N'pepa56@abv.bg', N'Pepa56', N'Popova56', N'+3595632156', N'56', N'', 4)
INSERT [dbo].[Contacts] ([ID], [Email], [FirstName], [LastName], [Phone], [Address], [Note], [UserID]) VALUES (61, N'pepa57@abv.bg', N'Pepa57', N'Popova57', N'+3595732157', N'57', N'', 4)
INSERT [dbo].[Contacts] ([ID], [Email], [FirstName], [LastName], [Phone], [Address], [Note], [UserID]) VALUES (62, N'pepa58@abv.bg', N'Pepa58', N'Popova58', N'+3595832158', N'58', N'', 4)
INSERT [dbo].[Contacts] ([ID], [Email], [FirstName], [LastName], [Phone], [Address], [Note], [UserID]) VALUES (63, N'pepa59@abv.bg', N'Pepa59', N'Popova59', N'+3595932159', N'59', N'', 4)
INSERT [dbo].[Contacts] ([ID], [Email], [FirstName], [LastName], [Phone], [Address], [Note], [UserID]) VALUES (64, N'pepa60@abv.bg', N'Pepa60', N'Popova60', N'+3596032160', N'60', N'', 4)
SET IDENTITY_INSERT [dbo].[Contacts] OFF
/****** Object:  Table [dbo].[MeetingsContacts]    Script Date: 01/18/2012 16:24:27 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MeetingsContacts](
	[MeetingID] [int] NOT NULL,
	[ContactID] [int] NOT NULL,
 CONSTRAINT [PK_MeetingsContacts] PRIMARY KEY CLUSTERED 
(
	[MeetingID] ASC,
	[ContactID] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Default [DF_Meetings_CategoryID]    Script Date: 01/18/2012 16:24:27 ******/
ALTER TABLE [dbo].[Meetings] ADD  CONSTRAINT [DF_Meetings_CategoryID]  DEFAULT ((1)) FOR [CategoryID]
GO
/****** Object:  ForeignKey [FK_Meetings_Categories]    Script Date: 01/18/2012 16:24:27 ******/
ALTER TABLE [dbo].[Meetings]  WITH CHECK ADD  CONSTRAINT [FK_Meetings_Categories] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Categories] ([ID])
GO
ALTER TABLE [dbo].[Meetings] CHECK CONSTRAINT [FK_Meetings_Categories]
GO
/****** Object:  ForeignKey [FK_Meetings_Users]    Script Date: 01/18/2012 16:24:27 ******/
ALTER TABLE [dbo].[Meetings]  WITH CHECK ADD  CONSTRAINT [FK_Meetings_Users] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([ID])
GO
ALTER TABLE [dbo].[Meetings] CHECK CONSTRAINT [FK_Meetings_Users]
GO
/****** Object:  ForeignKey [FK_Contacts_Users]    Script Date: 01/18/2012 16:24:27 ******/
ALTER TABLE [dbo].[Contacts]  WITH CHECK ADD  CONSTRAINT [FK_Contacts_Users] FOREIGN KEY([UserID])
REFERENCES [dbo].[Users] ([ID])
GO
ALTER TABLE [dbo].[Contacts] CHECK CONSTRAINT [FK_Contacts_Users]
GO
/****** Object:  ForeignKey [FK_MeetingsContacts_Contacts]    Script Date: 01/18/2012 16:24:27 ******/
ALTER TABLE [dbo].[MeetingsContacts]  WITH CHECK ADD  CONSTRAINT [FK_MeetingsContacts_Contacts] FOREIGN KEY([ContactID])
REFERENCES [dbo].[Contacts] ([ID])
GO
ALTER TABLE [dbo].[MeetingsContacts] CHECK CONSTRAINT [FK_MeetingsContacts_Contacts]
GO
/****** Object:  ForeignKey [FK_MeetingsContacts_Meetings]    Script Date: 01/18/2012 16:24:27 ******/
ALTER TABLE [dbo].[MeetingsContacts]  WITH CHECK ADD  CONSTRAINT [FK_MeetingsContacts_Meetings] FOREIGN KEY([MeetingID])
REFERENCES [dbo].[Meetings] ([ID])
GO
ALTER TABLE [dbo].[MeetingsContacts] CHECK CONSTRAINT [FK_MeetingsContacts_Meetings]
GO

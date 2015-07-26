USE [master]
GO
/****** Object:  Database [SLIIT.ITP]    Script Date: 7/26/2015 1:18:36 PM ******/
CREATE DATABASE [SLIIT.ITP]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SLIIT.ITP', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.DEV\MSSQL\DATA\SLIIT.ITP.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SLIIT.ITP_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.DEV\MSSQL\DATA\SLIIT.ITP_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [SLIIT.ITP] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SLIIT.ITP].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SLIIT.ITP] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SLIIT.ITP] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SLIIT.ITP] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SLIIT.ITP] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SLIIT.ITP] SET ARITHABORT OFF 
GO
ALTER DATABASE [SLIIT.ITP] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SLIIT.ITP] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [SLIIT.ITP] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SLIIT.ITP] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SLIIT.ITP] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SLIIT.ITP] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SLIIT.ITP] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SLIIT.ITP] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SLIIT.ITP] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SLIIT.ITP] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SLIIT.ITP] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SLIIT.ITP] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SLIIT.ITP] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SLIIT.ITP] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SLIIT.ITP] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SLIIT.ITP] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SLIIT.ITP] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SLIIT.ITP] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SLIIT.ITP] SET RECOVERY FULL 
GO
ALTER DATABASE [SLIIT.ITP] SET  MULTI_USER 
GO
ALTER DATABASE [SLIIT.ITP] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SLIIT.ITP] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SLIIT.ITP] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SLIIT.ITP] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
EXEC sys.sp_db_vardecimal_storage_format N'SLIIT.ITP', N'ON'
GO
USE [SLIIT.ITP]
GO
/****** Object:  Table [dbo].[TB_Menu]    Script Date: 7/26/2015 1:18:37 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TB_Menu](
	[RnMenu] [int] IDENTITY(1,1) NOT NULL,
	[MenuName] [varchar](max) NULL,
	[MenuImage] [varchar](max) NULL,
	[MenuPath] [varchar](max) NULL,
	[MenuColorStyle] [varchar](max) NULL,
	[MenuOrder] [int] NULL,
 CONSTRAINT [PK_TB_Menu] PRIMARY KEY CLUSTERED 
(
	[RnMenu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TB_MenuRole]    Script Date: 7/26/2015 1:18:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_MenuRole](
	[RnMenuRoleID] [int] IDENTITY(1,1) NOT NULL,
	[MenuID] [int] NULL,
	[RoleID] [int] NULL,
 CONSTRAINT [PK_TB_MenuRole] PRIMARY KEY CLUSTERED 
(
	[RnMenuRoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TB_Role]    Script Date: 7/26/2015 1:18:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TB_Role](
	[RnRoleID] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [varchar](max) NULL,
	[RoleIcon] [varchar](max) NULL,
 CONSTRAINT [PK_TB_Role] PRIMARY KEY CLUSTERED 
(
	[RnRoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TB_User]    Script Date: 7/26/2015 1:18:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TB_User](
	[RnUserID] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [varchar](max) NOT NULL,
	[Password] [varchar](max) NOT NULL,
	[FirstName] [varchar](max) NULL,
	[LastName] [varchar](max) NULL,
	[ProfilePic] [varchar](max) NULL,
 CONSTRAINT [PK_TB_User] PRIMARY KEY CLUSTERED 
(
	[RnUserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[TB_UserRole]    Script Date: 7/26/2015 1:18:38 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TB_UserRole](
	[RnUserRoleID] [int] IDENTITY(1,1) NOT NULL,
	[RoleID] [int] NULL,
	[UserID] [int] NULL,
 CONSTRAINT [PK_TB_UserRole] PRIMARY KEY CLUSTERED 
(
	[RnUserRoleID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[TB_User] ON 

INSERT [dbo].[TB_User] ([RnUserID], [UserName], [Password], [FirstName], [LastName], [ProfilePic]) VALUES (1, N'admin', N'123', N'Admin', N'', NULL)
SET IDENTITY_INSERT [dbo].[TB_User] OFF
ALTER TABLE [dbo].[TB_MenuRole]  WITH CHECK ADD  CONSTRAINT [FK_TB_MenuRole_TB_Menu] FOREIGN KEY([MenuID])
REFERENCES [dbo].[TB_Menu] ([RnMenu])
GO
ALTER TABLE [dbo].[TB_MenuRole] CHECK CONSTRAINT [FK_TB_MenuRole_TB_Menu]
GO
ALTER TABLE [dbo].[TB_MenuRole]  WITH CHECK ADD  CONSTRAINT [FK_TB_MenuRole_TB_Role] FOREIGN KEY([RoleID])
REFERENCES [dbo].[TB_Role] ([RnRoleID])
GO
ALTER TABLE [dbo].[TB_MenuRole] CHECK CONSTRAINT [FK_TB_MenuRole_TB_Role]
GO
ALTER TABLE [dbo].[TB_UserRole]  WITH CHECK ADD  CONSTRAINT [FK_TB_UserRole_TB_Role] FOREIGN KEY([RoleID])
REFERENCES [dbo].[TB_Role] ([RnRoleID])
GO
ALTER TABLE [dbo].[TB_UserRole] CHECK CONSTRAINT [FK_TB_UserRole_TB_Role]
GO
ALTER TABLE [dbo].[TB_UserRole]  WITH CHECK ADD  CONSTRAINT [FK_TB_UserRole_TB_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[TB_User] ([RnUserID])
GO
ALTER TABLE [dbo].[TB_UserRole] CHECK CONSTRAINT [FK_TB_UserRole_TB_User]
GO
USE [master]
GO
ALTER DATABASE [SLIIT.ITP] SET  READ_WRITE 
GO

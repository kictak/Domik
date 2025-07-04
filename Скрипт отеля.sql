USE [master]
GO
/****** Object:  Database [Hotels2]    Script Date: 21.06.2025 3:40:40 ******/
CREATE DATABASE [Hotels2]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Hotels2', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Hotels2.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Hotels2_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\Hotels2_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [Hotels2] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Hotels2].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Hotels2] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Hotels2] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Hotels2] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Hotels2] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Hotels2] SET ARITHABORT OFF 
GO
ALTER DATABASE [Hotels2] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Hotels2] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Hotels2] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Hotels2] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Hotels2] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Hotels2] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Hotels2] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Hotels2] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Hotels2] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Hotels2] SET  ENABLE_BROKER 
GO
ALTER DATABASE [Hotels2] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Hotels2] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Hotels2] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Hotels2] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Hotels2] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Hotels2] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [Hotels2] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Hotels2] SET RECOVERY FULL 
GO
ALTER DATABASE [Hotels2] SET  MULTI_USER 
GO
ALTER DATABASE [Hotels2] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Hotels2] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Hotels2] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Hotels2] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Hotels2] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Hotels2] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'Hotels2', N'ON'
GO
ALTER DATABASE [Hotels2] SET QUERY_STORE = ON
GO
ALTER DATABASE [Hotels2] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [Hotels2]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 21.06.2025 3:40:41 ******/
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
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CheckIns]    Script Date: 21.06.2025 3:40:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CheckIns](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Enter] [date] NOT NULL,
	[Exit] [date] NOT NULL,
	[GuestId] [int] NOT NULL,
	[RoomId] [int] NOT NULL,
 CONSTRAINT [PK_CheckIns] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DocumentTypes]    Script Date: 21.06.2025 3:40:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DocumentTypes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DocumentName] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_DocumentTypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Genders]    Script Date: 21.06.2025 3:40:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Genders](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_Genders] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Guests]    Script Date: 21.06.2025 3:40:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Guests](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[MiddleName] [nvarchar](max) NULL,
	[LastName] [nvarchar](max) NOT NULL,
	[Adress] [nvarchar](max) NULL,
	[DateOfBirth] [date] NOT NULL,
	[DocumentNumber] [nvarchar](max) NOT NULL,
	[GenderId] [int] NOT NULL,
	[DocumentTypeId] [int] NOT NULL,
 CONSTRAINT [PK_Guests] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rooms]    Script Date: 21.06.2025 3:40:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rooms](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Number] [int] NOT NULL,
	[RoomTypeId] [int] NOT NULL,
	[DayPrice] [int] NOT NULL,
 CONSTRAINT [PK_Rooms] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RoomStuff]    Script Date: 21.06.2025 3:40:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoomStuff](
	[RoomsId] [int] NOT NULL,
	[StuffsId] [int] NOT NULL,
 CONSTRAINT [PK_RoomStuff] PRIMARY KEY CLUSTERED 
(
	[RoomsId] ASC,
	[StuffsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RoomTypes]    Script Date: 21.06.2025 3:40:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoomTypes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Type] [nvarchar](max) NOT NULL,
	[Places] [int] NOT NULL,
 CONSTRAINT [PK_RoomTypes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Stuffs]    Script Date: 21.06.2025 3:40:41 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stuffs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Age] [int] NOT NULL,
	[Name] [nvarchar](max) NOT NULL,
	[LastName] [nvarchar](max) NOT NULL,
	[MiddleName] [nvarchar](max) NULL,
	[ShiftNumber] [int] NOT NULL,
 CONSTRAINT [PK_Stuffs] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20250620174549_InitCheckInTable', N'8.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20250620180908_Checkin', N'8.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20250620184118_ADdroom', N'8.0.0')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20250620202432_CreateRoomAddd', N'8.0.0')
GO
SET IDENTITY_INSERT [dbo].[CheckIns] ON 

INSERT [dbo].[CheckIns] ([Id], [Enter], [Exit], [GuestId], [RoomId]) VALUES (5, CAST(N'2000-01-01' AS Date), CAST(N'2000-01-01' AS Date), 1, 1)
INSERT [dbo].[CheckIns] ([Id], [Enter], [Exit], [GuestId], [RoomId]) VALUES (6, CAST(N'2025-06-21' AS Date), CAST(N'2025-06-22' AS Date), 5, 1)
SET IDENTITY_INSERT [dbo].[CheckIns] OFF
GO
SET IDENTITY_INSERT [dbo].[DocumentTypes] ON 

INSERT [dbo].[DocumentTypes] ([Id], [DocumentName]) VALUES (1, N'Паспорт')
INSERT [dbo].[DocumentTypes] ([Id], [DocumentName]) VALUES (2, N'Водительские права')
SET IDENTITY_INSERT [dbo].[DocumentTypes] OFF
GO
SET IDENTITY_INSERT [dbo].[Genders] ON 

INSERT [dbo].[Genders] ([Id], [Name]) VALUES (1, N'мужчина')
INSERT [dbo].[Genders] ([Id], [Name]) VALUES (2, N'женщина')
SET IDENTITY_INSERT [dbo].[Genders] OFF
GO
SET IDENTITY_INSERT [dbo].[Guests] ON 

INSERT [dbo].[Guests] ([Id], [Name], [MiddleName], [LastName], [Adress], [DateOfBirth], [DocumentNumber], [GenderId], [DocumentTypeId]) VALUES (1, N'TEST', N'TEST', N'TEST', N'41', CAST(N'2025-06-21' AS Date), N'4124', 2, 2)
INSERT [dbo].[Guests] ([Id], [Name], [MiddleName], [LastName], [Adress], [DateOfBirth], [DocumentNumber], [GenderId], [DocumentTypeId]) VALUES (2, N'Test', N'Test', N'Test', N'312Test', CAST(N'2025-06-05' AS Date), N'31231', 1, 1)
INSERT [dbo].[Guests] ([Id], [Name], [MiddleName], [LastName], [Adress], [DateOfBirth], [DocumentNumber], [GenderId], [DocumentTypeId]) VALUES (3, N'using DataModel.Directories;', N'using DataModel.Directories;', N'using DataModel.Directories;', N'41', CAST(N'2025-05-29' AS Date), N'using DataModel.Directories;', 2, 2)
INSERT [dbo].[Guests] ([Id], [Name], [MiddleName], [LastName], [Adress], [DateOfBirth], [DocumentNumber], [GenderId], [DocumentTypeId]) VALUES (4, N'Stepan', N'sew', N'ew', N'waeaw', CAST(N'2000-01-01' AS Date), N'3213', 1, 1)
INSERT [dbo].[Guests] ([Id], [Name], [MiddleName], [LastName], [Adress], [DateOfBirth], [DocumentNumber], [GenderId], [DocumentTypeId]) VALUES (5, N'STWE', N'STWE', N'STWE', N'412 STWESTWE', CAST(N'2025-06-04' AS Date), N'3231', 2, 2)
SET IDENTITY_INSERT [dbo].[Guests] OFF
GO
SET IDENTITY_INSERT [dbo].[Rooms] ON 

INSERT [dbo].[Rooms] ([Id], [Number], [RoomTypeId], [DayPrice]) VALUES (1, 32, 1, 321)
INSERT [dbo].[Rooms] ([Id], [Number], [RoomTypeId], [DayPrice]) VALUES (3, 321, 1, 123)
SET IDENTITY_INSERT [dbo].[Rooms] OFF
GO
INSERT [dbo].[RoomStuff] ([RoomsId], [StuffsId]) VALUES (1, 1)
GO
SET IDENTITY_INSERT [dbo].[RoomTypes] ON 

INSERT [dbo].[RoomTypes] ([Id], [Type], [Places]) VALUES (1, N'Стандарт', 1)
INSERT [dbo].[RoomTypes] ([Id], [Type], [Places]) VALUES (3, N'Люкс', 4)
INSERT [dbo].[RoomTypes] ([Id], [Type], [Places]) VALUES (4, N'Двухместный', 2)
SET IDENTITY_INSERT [dbo].[RoomTypes] OFF
GO
SET IDENTITY_INSERT [dbo].[Stuffs] ON 

INSERT [dbo].[Stuffs] ([Id], [Age], [Name], [LastName], [MiddleName], [ShiftNumber]) VALUES (1, 32, N'Света', N'Симакова', N'Кириловна', 32)
SET IDENTITY_INSERT [dbo].[Stuffs] OFF
GO
/****** Object:  Index [IX_CheckIns_GuestId]    Script Date: 21.06.2025 3:40:41 ******/
CREATE NONCLUSTERED INDEX [IX_CheckIns_GuestId] ON [dbo].[CheckIns]
(
	[GuestId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_CheckIns_RoomId]    Script Date: 21.06.2025 3:40:41 ******/
CREATE NONCLUSTERED INDEX [IX_CheckIns_RoomId] ON [dbo].[CheckIns]
(
	[RoomId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Guests_DocumentTypeId]    Script Date: 21.06.2025 3:40:41 ******/
CREATE NONCLUSTERED INDEX [IX_Guests_DocumentTypeId] ON [dbo].[Guests]
(
	[DocumentTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Guests_GenderId]    Script Date: 21.06.2025 3:40:41 ******/
CREATE NONCLUSTERED INDEX [IX_Guests_GenderId] ON [dbo].[Guests]
(
	[GenderId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_Rooms_RoomTypeId]    Script Date: 21.06.2025 3:40:41 ******/
CREATE NONCLUSTERED INDEX [IX_Rooms_RoomTypeId] ON [dbo].[Rooms]
(
	[RoomTypeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
/****** Object:  Index [IX_RoomStuff_StuffsId]    Script Date: 21.06.2025 3:40:41 ******/
CREATE NONCLUSTERED INDEX [IX_RoomStuff_StuffsId] ON [dbo].[RoomStuff]
(
	[StuffsId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CheckIns]  WITH CHECK ADD  CONSTRAINT [FK_CheckIns_Guests_GuestId] FOREIGN KEY([GuestId])
REFERENCES [dbo].[Guests] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CheckIns] CHECK CONSTRAINT [FK_CheckIns_Guests_GuestId]
GO
ALTER TABLE [dbo].[CheckIns]  WITH CHECK ADD  CONSTRAINT [FK_CheckIns_Rooms_RoomId] FOREIGN KEY([RoomId])
REFERENCES [dbo].[Rooms] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CheckIns] CHECK CONSTRAINT [FK_CheckIns_Rooms_RoomId]
GO
ALTER TABLE [dbo].[Guests]  WITH CHECK ADD  CONSTRAINT [FK_Guests_DocumentTypes_DocumentTypeId] FOREIGN KEY([DocumentTypeId])
REFERENCES [dbo].[DocumentTypes] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Guests] CHECK CONSTRAINT [FK_Guests_DocumentTypes_DocumentTypeId]
GO
ALTER TABLE [dbo].[Guests]  WITH CHECK ADD  CONSTRAINT [FK_Guests_Genders_GenderId] FOREIGN KEY([GenderId])
REFERENCES [dbo].[Genders] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Guests] CHECK CONSTRAINT [FK_Guests_Genders_GenderId]
GO
ALTER TABLE [dbo].[Rooms]  WITH CHECK ADD  CONSTRAINT [FK_Rooms_RoomTypes_RoomTypeId] FOREIGN KEY([RoomTypeId])
REFERENCES [dbo].[RoomTypes] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Rooms] CHECK CONSTRAINT [FK_Rooms_RoomTypes_RoomTypeId]
GO
ALTER TABLE [dbo].[RoomStuff]  WITH CHECK ADD  CONSTRAINT [FK_RoomStuff_Rooms_RoomsId] FOREIGN KEY([RoomsId])
REFERENCES [dbo].[Rooms] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RoomStuff] CHECK CONSTRAINT [FK_RoomStuff_Rooms_RoomsId]
GO
ALTER TABLE [dbo].[RoomStuff]  WITH CHECK ADD  CONSTRAINT [FK_RoomStuff_Stuffs_StuffsId] FOREIGN KEY([StuffsId])
REFERENCES [dbo].[Stuffs] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[RoomStuff] CHECK CONSTRAINT [FK_RoomStuff_Stuffs_StuffsId]
GO
USE [master]
GO
ALTER DATABASE [Hotels2] SET  READ_WRITE 
GO

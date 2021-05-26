USE [JewelryStore]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 26.05.2021 23:39:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Title] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Category_ID] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Check]    Script Date: 26.05.2021 23:39:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Check](
	[ID] [int] NOT NULL,
	[IDClient] [int] NOT NULL,
	[IDJewelry] [int] NOT NULL,
	[Date] [date] NOT NULL,
	[Commission] [float] NULL,
	[TotalPrice] [float] NOT NULL,
 CONSTRAINT [PK_Check] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 26.05.2021 23:39:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[ID] [int] NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[SecondName] [nvarchar](50) NULL,
	[Phone] [char](30) NOT NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Jewelry]    Script Date: 26.05.2021 23:39:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Jewelry](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[JewImg] [image] NULL,
	[JewName] [nvarchar](100) NOT NULL,
	[CategoryID] [int] NOT NULL,
	[Material] [nvarchar](100) NOT NULL,
	[Pice] [bigint] NOT NULL,
	[ParametersID] [int] NOT NULL,
 CONSTRAINT [PK_Jewerly_ID] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Parameters]    Script Date: 26.05.2021 23:39:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Parameters](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Height] [nvarchar](100) NOT NULL,
	[Width] [nvarchar](100) NOT NULL,
	[Weight] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Parameters_ID] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 26.05.2021 23:39:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[ID] [nchar](1) NOT NULL,
	[Title] [nvarchar](20) NOT NULL,
 CONSTRAINT [PK_Role_ID] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SignIn]    Script Date: 26.05.2021 23:39:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SignIn](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[LogIn] [nvarchar](100) NOT NULL,
	[Password] [nvarchar](100) NOT NULL,
	[RoleID] [nchar](1) NOT NULL,
 CONSTRAINT [PK_SignIn_ID] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([ID], [Title]) VALUES (1, N'Арт-деко')
INSERT [dbo].[Category] ([ID], [Title]) VALUES (2, N'Винтаж')
INSERT [dbo].[Category] ([ID], [Title]) VALUES (3, N'Ретро')
INSERT [dbo].[Category] ([ID], [Title]) VALUES (4, N'Ар-нуво')
INSERT [dbo].[Category] ([ID], [Title]) VALUES (5, N'Гламур')
INSERT [dbo].[Category] ([ID], [Title]) VALUES (6, N'Арт-деко')
INSERT [dbo].[Category] ([ID], [Title]) VALUES (7, N'Винтаж')
INSERT [dbo].[Category] ([ID], [Title]) VALUES (8, N'Ретро')
INSERT [dbo].[Category] ([ID], [Title]) VALUES (9, N'Ар-нуво')
INSERT [dbo].[Category] ([ID], [Title]) VALUES (10, N'Гламур')
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
INSERT [dbo].[Client] ([ID], [FirstName], [LastName], [SecondName], [Phone]) VALUES (0, N'Абдулхаким', N'Магомедов', N'Салимсолтанович', N'+79292726501                  ')
GO
SET IDENTITY_INSERT [dbo].[Parameters] ON 

INSERT [dbo].[Parameters] ([ID], [Height], [Width], [Weight]) VALUES (1, N'32', N'32', N'32')
SET IDENTITY_INSERT [dbo].[Parameters] OFF
GO
INSERT [dbo].[Role] ([ID], [Title]) VALUES (N'A', N'Admin')
GO
SET IDENTITY_INSERT [dbo].[SignIn] ON 

INSERT [dbo].[SignIn] ([ID], [LogIn], [Password], [RoleID]) VALUES (1, N'Zarina', N'12345', N'A')
INSERT [dbo].[SignIn] ([ID], [LogIn], [Password], [RoleID]) VALUES (2, N'zarina', N'12345', N'A')
INSERT [dbo].[SignIn] ([ID], [LogIn], [Password], [RoleID]) VALUES (3, N'a', N'a', N'A')
SET IDENTITY_INSERT [dbo].[SignIn] OFF
GO
ALTER TABLE [dbo].[Check]  WITH CHECK ADD  CONSTRAINT [FK_Check_Client] FOREIGN KEY([IDClient])
REFERENCES [dbo].[Client] ([ID])
GO
ALTER TABLE [dbo].[Check] CHECK CONSTRAINT [FK_Check_Client]
GO
ALTER TABLE [dbo].[Check]  WITH CHECK ADD  CONSTRAINT [FK_Check_Jewelry] FOREIGN KEY([IDJewelry])
REFERENCES [dbo].[Jewelry] ([ID])
GO
ALTER TABLE [dbo].[Check] CHECK CONSTRAINT [FK_Check_Jewelry]
GO
ALTER TABLE [dbo].[Jewelry]  WITH CHECK ADD  CONSTRAINT [FK_Jewerly_CategoryID_Category_ID] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Category] ([ID])
GO
ALTER TABLE [dbo].[Jewelry] CHECK CONSTRAINT [FK_Jewerly_CategoryID_Category_ID]
GO
ALTER TABLE [dbo].[Jewelry]  WITH CHECK ADD  CONSTRAINT [FK_Jewerly_ParametersID_Parameters_ID] FOREIGN KEY([ParametersID])
REFERENCES [dbo].[Parameters] ([ID])
GO
ALTER TABLE [dbo].[Jewelry] CHECK CONSTRAINT [FK_Jewerly_ParametersID_Parameters_ID]
GO
ALTER TABLE [dbo].[SignIn]  WITH CHECK ADD  CONSTRAINT [FK_SignIn_RoleID_Role_ID] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Role] ([ID])
GO
ALTER TABLE [dbo].[SignIn] CHECK CONSTRAINT [FK_SignIn_RoleID_Role_ID]
GO

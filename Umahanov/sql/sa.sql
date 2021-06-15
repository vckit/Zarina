--CREATE DATABASE [dbBookLove]

USE [dbBookLove]
GO
/****** Object:  Table [dbo].[Author]    Script Date: 6/15/2021 2:31:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Author](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[firstName] [nvarchar](50) NOT NULL,
	[lastName] [nvarchar](50) NOT NULL,
	[secondName] [nvarchar](50) NULL,
 CONSTRAINT [PK_Author] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Basket]    Script Date: 6/15/2021 2:31:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Basket](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idClient] [int] NOT NULL,
	[idProvider] [int] NOT NULL,
	[idBook] [int] NOT NULL,
	[count] [int] NOT NULL,
	[totalPrice] [float] NOT NULL,
 CONSTRAINT [PK_Basket] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Book]    Script Date: 6/15/2021 2:31:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Book](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[title] [nvarchar](50) NULL,
	[idAuthor] [int] NOT NULL,
	[idGenre] [int] NOT NULL,
	[idPublisher] [int] NOT NULL,
	[count] [int] NOT NULL,
	[price] [float] NOT NULL,
	[pucture] [nvarchar](1000) NULL,
 CONSTRAINT [PK_Book] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[City]    Script Date: 6/15/2021 2:31:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[City](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[title] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_City] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 6/15/2021 2:31:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[title] [nvarchar](50) NOT NULL,
	[idCity] [int] NOT NULL,
	[street] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Genre]    Script Date: 6/15/2021 2:31:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Genre](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[title] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Genre] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 6/15/2021 2:31:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Login](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Login] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Provider]    Script Date: 6/15/2021 2:31:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Provider](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[title] [nvarchar](50) NOT NULL,
	[city] [nvarchar](50) NULL,
 CONSTRAINT [PK_Provider] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Publisher]    Script Date: 6/15/2021 2:31:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Publisher](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[titile] [nvarchar](50) NOT NULL,
	[address] [nvarchar](100) NULL,
	[contact] [nvarchar](50) NULL,
 CONSTRAINT [PK_Publisher] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Registration]    Script Date: 6/15/2021 2:31:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Registration](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[firstName] [nvarchar](50) NOT NULL,
	[lastName] [nvarchar](50) NOT NULL,
	[secondName] [nvarchar](50) NULL,
	[numberContract] [nvarchar](50) NOT NULL,
	[dateOfRegistration] [date] NOT NULL,
	[idLogin] [int] NOT NULL,
 CONSTRAINT [PK_Registration] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Supple]    Script Date: 6/15/2021 2:31:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Supple](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idProvider] [int] NOT NULL,
	[idBook] [int] NOT NULL,
	[idClient] [int] NOT NULL,
	[dateSupple] [date] NOT NULL,
	[description] [nvarchar](500) NULL,
	[totalPrice] [float] NOT NULL,
	[count] [int] NOT NULL,
 CONSTRAINT [PK_Supple] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Author] ON 

INSERT [dbo].[Author] ([id], [firstName], [lastName], [secondName]) VALUES (1, N'Лев', N'Николаевич', N'Толстой')
INSERT [dbo].[Author] ([id], [firstName], [lastName], [secondName]) VALUES (2, N'fff', N'fff', N'ffff')
INSERT [dbo].[Author] ([id], [firstName], [lastName], [secondName]) VALUES (3, N'-', N'-', N'-')
INSERT [dbo].[Author] ([id], [firstName], [lastName], [secondName]) VALUES (4, N'-', N'-', N'-')
SET IDENTITY_INSERT [dbo].[Author] OFF
GO
SET IDENTITY_INSERT [dbo].[Book] ON 

INSERT [dbo].[Book] ([id], [title], [idAuthor], [idGenre], [idPublisher], [count], [price], [pucture]) VALUES (4, N'Накопительный эффект', 3, 2, 1, 5, 2500, N'\pics\1darren-khardi-nakopitelnyy-effekt-ot-postupka-k-privychke-ot-privychki-k-vydayushchimsya-rezultatam-obzor-knigi .jpg')
INSERT [dbo].[Book] ([id], [title], [idAuthor], [idGenre], [idPublisher], [count], [price], [pucture]) VALUES (5, N'Богатый папа Бедный папа', 4, 3, 1, 7, 2000, N'\pics\30805119-robert-kiyosaki-bogatyy-papa-bednyy-papa-ubileynyy-vypusk-k-20-le-30805119.jpg')
SET IDENTITY_INSERT [dbo].[Book] OFF
GO
SET IDENTITY_INSERT [dbo].[City] ON 

INSERT [dbo].[City] ([id], [title]) VALUES (1, N'Москва')
INSERT [dbo].[City] ([id], [title]) VALUES (2, N'Махачкала')
INSERT [dbo].[City] ([id], [title]) VALUES (3, N'Санк-Петербург')
INSERT [dbo].[City] ([id], [title]) VALUES (4, N'Новосибирск')
SET IDENTITY_INSERT [dbo].[City] OFF
GO
SET IDENTITY_INSERT [dbo].[Client] ON 

INSERT [dbo].[Client] ([id], [title], [idCity], [street]) VALUES (1, N'Покупатель 1', 1, N'ул. Белова, дом 128, корпус №2')
INSERT [dbo].[Client] ([id], [title], [idCity], [street]) VALUES (2, N'Читай город', 2, N'ул. Акушинского, д.26')
SET IDENTITY_INSERT [dbo].[Client] OFF
GO
SET IDENTITY_INSERT [dbo].[Genre] ON 

INSERT [dbo].[Genre] ([id], [title]) VALUES (1, N'Роман')
INSERT [dbo].[Genre] ([id], [title]) VALUES (2, N'Саморазвитие')
INSERT [dbo].[Genre] ([id], [title]) VALUES (3, N'Детектив')
INSERT [dbo].[Genre] ([id], [title]) VALUES (4, N'Дорама')
SET IDENTITY_INSERT [dbo].[Genre] OFF
GO
SET IDENTITY_INSERT [dbo].[Login] ON 

INSERT [dbo].[Login] ([id], [username], [password]) VALUES (1, N'a', N'a')
INSERT [dbo].[Login] ([id], [username], [password]) VALUES (2, N'abdulkhak1m@mail.ru', N'qUxvPK7Y')
SET IDENTITY_INSERT [dbo].[Login] OFF
GO
SET IDENTITY_INSERT [dbo].[Provider] ON 

INSERT [dbo].[Provider] ([id], [title], [city]) VALUES (1, N'Агенство "Белый парус"', N'Москва')
INSERT [dbo].[Provider] ([id], [title], [city]) VALUES (2, N'Московская фирма "Бледный"', N'г. Москва')
SET IDENTITY_INSERT [dbo].[Provider] OFF
GO
SET IDENTITY_INSERT [dbo].[Publisher] ON 

INSERT [dbo].[Publisher] ([id], [titile], [address], [contact]) VALUES (1, N'Питерский издательский дом', NULL, NULL)
INSERT [dbo].[Publisher] ([id], [titile], [address], [contact]) VALUES (2, N'Московский  издательский дом 17', N'ул. Крамского. д.89, кр.2', N'+790007657676')
SET IDENTITY_INSERT [dbo].[Publisher] OFF
GO
SET IDENTITY_INSERT [dbo].[Registration] ON 

INSERT [dbo].[Registration] ([id], [firstName], [lastName], [secondName], [numberContract], [dateOfRegistration], [idLogin]) VALUES (1, N'a', N'a', N'a', N'1111', CAST(N'2021-06-14' AS Date), 1)
INSERT [dbo].[Registration] ([id], [firstName], [lastName], [secondName], [numberContract], [dateOfRegistration], [idLogin]) VALUES (2, N'Абдулхаким', N'Магомедов', N'', N'3214', CAST(N'2021-06-14' AS Date), 2)
SET IDENTITY_INSERT [dbo].[Registration] OFF
GO
SET IDENTITY_INSERT [dbo].[Supple] ON 

INSERT [dbo].[Supple] ([id], [idProvider], [idBook], [idClient], [dateSupple], [description], [totalPrice], [count]) VALUES (1, 1, 4, 1, CAST(N'2021-06-14' AS Date), NULL, 2500, 1)
INSERT [dbo].[Supple] ([id], [idProvider], [idBook], [idClient], [dateSupple], [description], [totalPrice], [count]) VALUES (2, 1, 4, 1, CAST(N'2021-06-14' AS Date), NULL, 2500, 1)
INSERT [dbo].[Supple] ([id], [idProvider], [idBook], [idClient], [dateSupple], [description], [totalPrice], [count]) VALUES (3, 1, 4, 1, CAST(N'2021-06-14' AS Date), NULL, 2500, 1)
INSERT [dbo].[Supple] ([id], [idProvider], [idBook], [idClient], [dateSupple], [description], [totalPrice], [count]) VALUES (4, 1, 4, 1, CAST(N'2021-06-14' AS Date), N'fdsafadsf', 2500, 1)
INSERT [dbo].[Supple] ([id], [idProvider], [idBook], [idClient], [dateSupple], [description], [totalPrice], [count]) VALUES (5, 1, 4, 1, CAST(N'2021-06-15' AS Date), N'', 5000, 2)
INSERT [dbo].[Supple] ([id], [idProvider], [idBook], [idClient], [dateSupple], [description], [totalPrice], [count]) VALUES (6, 1, 5, 1, CAST(N'2021-06-15' AS Date), N'', 2000, 1)
INSERT [dbo].[Supple] ([id], [idProvider], [idBook], [idClient], [dateSupple], [description], [totalPrice], [count]) VALUES (7, 2, 4, 2, CAST(N'2021-06-15' AS Date), N'', 5000, 2)
INSERT [dbo].[Supple] ([id], [idProvider], [idBook], [idClient], [dateSupple], [description], [totalPrice], [count]) VALUES (8, 2, 5, 2, CAST(N'2021-06-15' AS Date), N'', 2000, 1)
INSERT [dbo].[Supple] ([id], [idProvider], [idBook], [idClient], [dateSupple], [description], [totalPrice], [count]) VALUES (9, 1, 5, 1, CAST(N'2021-06-15' AS Date), N'', 6000, 3)
INSERT [dbo].[Supple] ([id], [idProvider], [idBook], [idClient], [dateSupple], [description], [totalPrice], [count]) VALUES (10, 1, 4, 1, CAST(N'2021-06-15' AS Date), N'', 12500, 5)
SET IDENTITY_INSERT [dbo].[Supple] OFF
GO
ALTER TABLE [dbo].[Basket]  WITH CHECK ADD  CONSTRAINT [FK_Basket_Book] FOREIGN KEY([idBook])
REFERENCES [dbo].[Book] ([id])
GO
ALTER TABLE [dbo].[Basket] CHECK CONSTRAINT [FK_Basket_Book]
GO
ALTER TABLE [dbo].[Basket]  WITH CHECK ADD  CONSTRAINT [FK_Basket_Client] FOREIGN KEY([idClient])
REFERENCES [dbo].[Client] ([id])
GO
ALTER TABLE [dbo].[Basket] CHECK CONSTRAINT [FK_Basket_Client]
GO
ALTER TABLE [dbo].[Basket]  WITH CHECK ADD  CONSTRAINT [FK_Basket_Provider] FOREIGN KEY([idProvider])
REFERENCES [dbo].[Provider] ([id])
GO
ALTER TABLE [dbo].[Basket] CHECK CONSTRAINT [FK_Basket_Provider]
GO
ALTER TABLE [dbo].[Book]  WITH CHECK ADD  CONSTRAINT [FK_Book_Author] FOREIGN KEY([idAuthor])
REFERENCES [dbo].[Author] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Book] CHECK CONSTRAINT [FK_Book_Author]
GO
ALTER TABLE [dbo].[Book]  WITH CHECK ADD  CONSTRAINT [FK_Book_Genre] FOREIGN KEY([idGenre])
REFERENCES [dbo].[Genre] ([id])
GO
ALTER TABLE [dbo].[Book] CHECK CONSTRAINT [FK_Book_Genre]
GO
ALTER TABLE [dbo].[Book]  WITH CHECK ADD  CONSTRAINT [FK_Book_Publisher] FOREIGN KEY([idPublisher])
REFERENCES [dbo].[Publisher] ([id])
GO
ALTER TABLE [dbo].[Book] CHECK CONSTRAINT [FK_Book_Publisher]
GO
ALTER TABLE [dbo].[Client]  WITH CHECK ADD  CONSTRAINT [FK_Client_City] FOREIGN KEY([idCity])
REFERENCES [dbo].[City] ([id])
GO
ALTER TABLE [dbo].[Client] CHECK CONSTRAINT [FK_Client_City]
GO
ALTER TABLE [dbo].[Registration]  WITH CHECK ADD  CONSTRAINT [FK_Registration_Login] FOREIGN KEY([idLogin])
REFERENCES [dbo].[Login] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Registration] CHECK CONSTRAINT [FK_Registration_Login]
GO
ALTER TABLE [dbo].[Supple]  WITH CHECK ADD  CONSTRAINT [FK_Supple_Book1] FOREIGN KEY([idBook])
REFERENCES [dbo].[Book] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Supple] CHECK CONSTRAINT [FK_Supple_Book1]
GO
ALTER TABLE [dbo].[Supple]  WITH CHECK ADD  CONSTRAINT [FK_Supple_Client] FOREIGN KEY([idClient])
REFERENCES [dbo].[Client] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Supple] CHECK CONSTRAINT [FK_Supple_Client]
GO
ALTER TABLE [dbo].[Supple]  WITH CHECK ADD  CONSTRAINT [FK_Supple_Provider] FOREIGN KEY([idProvider])
REFERENCES [dbo].[Provider] ([id])
GO
ALTER TABLE [dbo].[Supple] CHECK CONSTRAINT [FK_Supple_Provider]
GO

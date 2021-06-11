USE [dbConfectionery]
GO
/****** Object:  Table [dbo].[Basket]    Script Date: 6/12/2021 1:57:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Basket](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idClient] [int] NOT NULL,
	[idProduct] [int] NOT NULL,
	[count] [int] NOT NULL,
	[totalPrice] [float] NOT NULL,
 CONSTRAINT [PK_Basket] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Card]    Script Date: 6/12/2021 1:57:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Card](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[number] [char](32) NOT NULL,
	[cvc] [char](3) NOT NULL,
	[shelfLife] [char](5) NOT NULL,
 CONSTRAINT [PK_Card] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CheckList]    Script Date: 6/12/2021 1:57:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CheckList](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[idProduct] [int] NOT NULL,
	[idClient] [int] NOT NULL,
	[count] [int] NOT NULL,
	[totalPrice] [float] NOT NULL,
	[dateCheck] [date] NOT NULL,
	[idPayment] [int] NOT NULL,
 CONSTRAINT [PK_CheckList] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 6/12/2021 1:57:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[firstName] [nvarchar](50) NOT NULL,
	[lastName] [nvarchar](50) NOT NULL,
	[phone] [char](22) NOT NULL,
	[idCard] [int] NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DataEmploye]    Script Date: 6/12/2021 1:57:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DataEmploye](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[firstName] [nvarchar](50) NOT NULL,
	[lastName] [nvarchar](50) NOT NULL,
	[idLogin] [int] NOT NULL,
	[numberCertificate] [int] NULL,
	[dateRegistration] [date] NOT NULL,
 CONSTRAINT [PK_DataEmploye] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Login]    Script Date: 6/12/2021 1:57:50 AM ******/
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
/****** Object:  Table [dbo].[PaymentType]    Script Date: 6/12/2021 1:57:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PaymentType](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[title] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_PaymentType] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 6/12/2021 1:57:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[title] [nvarchar](100) NOT NULL,
	[description] [nvarchar](max) NULL,
	[price] [float] NOT NULL,
	[idStructure] [int] NULL,
	[weight] [int] NOT NULL,
	[photo] [nvarchar](max) NULL,
	[count] [int] NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Structure]    Script Date: 6/12/2021 1:57:50 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Structure](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[calories] [int] NULL,
	[fats] [int] NULL,
	[sugar] [int] NULL,
	[carbohydrates] [int] NULL,
 CONSTRAINT [PK_Structure] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[CheckList] ON 

INSERT [dbo].[CheckList] ([id], [idProduct], [idClient], [count], [totalPrice], [dateCheck], [idPayment]) VALUES (2, 2, 1, 1, 432, CAST(N'2021-06-12' AS Date), 1)
INSERT [dbo].[CheckList] ([id], [idProduct], [idClient], [count], [totalPrice], [dateCheck], [idPayment]) VALUES (3, 2, 1, 1, 432, CAST(N'2021-06-12' AS Date), 1)
INSERT [dbo].[CheckList] ([id], [idProduct], [idClient], [count], [totalPrice], [dateCheck], [idPayment]) VALUES (4, 2, 1, 2, 864, CAST(N'2021-06-12' AS Date), 1)
INSERT [dbo].[CheckList] ([id], [idProduct], [idClient], [count], [totalPrice], [dateCheck], [idPayment]) VALUES (5, 2, 1, 1, 432, CAST(N'2021-06-12' AS Date), 1)
INSERT [dbo].[CheckList] ([id], [idProduct], [idClient], [count], [totalPrice], [dateCheck], [idPayment]) VALUES (6, 2, 1, 1, 432, CAST(N'2021-06-12' AS Date), 1)
INSERT [dbo].[CheckList] ([id], [idProduct], [idClient], [count], [totalPrice], [dateCheck], [idPayment]) VALUES (7, 2, 1, 1, 432, CAST(N'2021-06-12' AS Date), 1)
INSERT [dbo].[CheckList] ([id], [idProduct], [idClient], [count], [totalPrice], [dateCheck], [idPayment]) VALUES (8, 2, 1, 1, 432, CAST(N'2021-06-12' AS Date), 1)
INSERT [dbo].[CheckList] ([id], [idProduct], [idClient], [count], [totalPrice], [dateCheck], [idPayment]) VALUES (9, 2, 1, 2, 864, CAST(N'2021-06-12' AS Date), 1)
INSERT [dbo].[CheckList] ([id], [idProduct], [idClient], [count], [totalPrice], [dateCheck], [idPayment]) VALUES (10, 2, 1, 2, 864, CAST(N'2021-06-12' AS Date), 1)
SET IDENTITY_INSERT [dbo].[CheckList] OFF
GO
SET IDENTITY_INSERT [dbo].[Client] ON 

INSERT [dbo].[Client] ([id], [firstName], [lastName], [phone], [idCard]) VALUES (1, N'fdsf', N'fsdf', N'432423                ', NULL)
INSERT [dbo].[Client] ([id], [firstName], [lastName], [phone], [idCard]) VALUES (2, N'fsdaf', N'fasd', N'432423                ', NULL)
SET IDENTITY_INSERT [dbo].[Client] OFF
GO
SET IDENTITY_INSERT [dbo].[DataEmploye] ON 

INSERT [dbo].[DataEmploye] ([id], [firstName], [lastName], [idLogin], [numberCertificate], [dateRegistration]) VALUES (1, N'a', N'a', 1, 12345, CAST(N'2021-06-11' AS Date))
SET IDENTITY_INSERT [dbo].[DataEmploye] OFF
GO
SET IDENTITY_INSERT [dbo].[Login] ON 

INSERT [dbo].[Login] ([id], [username], [password]) VALUES (1, N'a', N'a')
SET IDENTITY_INSERT [dbo].[Login] OFF
GO
SET IDENTITY_INSERT [dbo].[PaymentType] ON 

INSERT [dbo].[PaymentType] ([id], [title]) VALUES (1, N'Наличкой')
INSERT [dbo].[PaymentType] ([id], [title]) VALUES (2, N'Картой')
SET IDENTITY_INSERT [dbo].[PaymentType] OFF
GO
SET IDENTITY_INSERT [dbo].[Product] ON 

INSERT [dbo].[Product] ([id], [title], [description], [price], [idStructure], [weight], [photo], [count]) VALUES (2, N'fsdaf', N'fasdfa', 432, NULL, 432, N'\pics\images.png', 4)
SET IDENTITY_INSERT [dbo].[Product] OFF
GO
ALTER TABLE [dbo].[Basket]  WITH CHECK ADD  CONSTRAINT [FK_Basket_Client] FOREIGN KEY([idClient])
REFERENCES [dbo].[Client] ([id])
GO
ALTER TABLE [dbo].[Basket] CHECK CONSTRAINT [FK_Basket_Client]
GO
ALTER TABLE [dbo].[Basket]  WITH CHECK ADD  CONSTRAINT [FK_Basket_Product] FOREIGN KEY([idProduct])
REFERENCES [dbo].[Product] ([id])
GO
ALTER TABLE [dbo].[Basket] CHECK CONSTRAINT [FK_Basket_Product]
GO
ALTER TABLE [dbo].[CheckList]  WITH CHECK ADD  CONSTRAINT [FK_CheckList_Client] FOREIGN KEY([idClient])
REFERENCES [dbo].[Client] ([id])
GO
ALTER TABLE [dbo].[CheckList] CHECK CONSTRAINT [FK_CheckList_Client]
GO
ALTER TABLE [dbo].[CheckList]  WITH CHECK ADD  CONSTRAINT [FK_CheckList_PaymentType] FOREIGN KEY([idPayment])
REFERENCES [dbo].[PaymentType] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CheckList] CHECK CONSTRAINT [FK_CheckList_PaymentType]
GO
ALTER TABLE [dbo].[CheckList]  WITH CHECK ADD  CONSTRAINT [FK_CheckList_Product] FOREIGN KEY([idProduct])
REFERENCES [dbo].[Product] ([id])
GO
ALTER TABLE [dbo].[CheckList] CHECK CONSTRAINT [FK_CheckList_Product]
GO
ALTER TABLE [dbo].[Client]  WITH CHECK ADD  CONSTRAINT [FK_Client_Card] FOREIGN KEY([idCard])
REFERENCES [dbo].[Card] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Client] CHECK CONSTRAINT [FK_Client_Card]
GO
ALTER TABLE [dbo].[DataEmploye]  WITH CHECK ADD  CONSTRAINT [FK_DataEmploye_Login] FOREIGN KEY([idLogin])
REFERENCES [dbo].[Login] ([id])
GO
ALTER TABLE [dbo].[DataEmploye] CHECK CONSTRAINT [FK_DataEmploye_Login]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Structure] FOREIGN KEY([idStructure])
REFERENCES [dbo].[Structure] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Structure]
GO

USE [IceCreamDB]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 3/30/2024 4:24:24 PM ******/
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
/****** Object:  Table [dbo].[Company]    Script Date: 3/30/2024 4:24:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Company](
	[CompanyId] [int] IDENTITY(1,1) NOT NULL,
	[CompanyName] [nvarchar](max) NULL,
	[Picture] [nvarchar](200) NULL,
	[IsDeleted] [int] NOT NULL,
 CONSTRAINT [PK_Company] PRIMARY KEY CLUSTERED 
(
	[CompanyId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ConcernPerson]    Script Date: 3/30/2024 4:24:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ConcernPerson](
	[ConcernPersonId] [int] IDENTITY(1,1) NOT NULL,
	[ConcernPersonName] [nvarchar](max) NULL,
	[IsDeleted] [int] NOT NULL,
 CONSTRAINT [PK_ConcernPerson] PRIMARY KEY CLUSTERED 
(
	[ConcernPersonId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[products]    Script Date: 3/30/2024 4:24:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[products](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[ProductName] [nvarchar](200) NULL,
	[Description] [varchar](100) NULL,
	[CompanyId] [int] NOT NULL,
	[IsActive] [int] NOT NULL,
	[Price] [decimal](18, 2) NULL,
	[Sequence] [int] NULL,
	[IsDeleted] [int] NOT NULL,
 CONSTRAINT [PK_products] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RoleAssagin]    Script Date: 3/30/2024 4:24:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoleAssagin](
	[RoleAssaginId] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [int] NOT NULL,
	[UserId] [int] NOT NULL,
 CONSTRAINT [PK_RoleAssagin] PRIMARY KEY CLUSTERED 
(
	[RoleAssaginId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RoleMaster]    Script Date: 3/30/2024 4:24:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RoleMaster](
	[RoleId] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](max) NOT NULL,
 CONSTRAINT [PK_RoleMaster] PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SalesDistribute]    Script Date: 3/30/2024 4:24:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalesDistribute](
	[SalesDistributeID] [bigint] IDENTITY(1,1) NOT NULL,
	[TotalPrice] [decimal](18, 2) NOT NULL,
	[TotalReceive] [int] NOT NULL,
	[TotalReturn] [int] NOT NULL,
	[TotalSales] [int] NOT NULL,
	[GrandTotal] [decimal](18, 2) NOT NULL,
	[ConcernPersonId] [int] NOT NULL,
	[CreationTime] [datetime] NOT NULL,
	[IsDeleted] [int] NOT NULL,
 CONSTRAINT [PK_SalesDistribute] PRIMARY KEY CLUSTERED 
(
	[SalesDistributeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SalesDistributeDetails]    Script Date: 3/30/2024 4:24:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SalesDistributeDetails](
	[SalesDistributeDetailsID] [uniqueidentifier] NOT NULL,
	[SalesDistributeID] [bigint] NOT NULL,
	[ProductId] [int] NOT NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[ReceiveQuantity] [int] NOT NULL,
	[ReturnQuantity] [int] NOT NULL,
	[SalesQuantity] [int] NOT NULL,
	[TotalSalesPrice] [decimal](18, 2) NOT NULL,
	[CreationTime] [datetime] NOT NULL,
	[IsDeleted] [int] NOT NULL,
 CONSTRAINT [PK_SalesDistributeDetails] PRIMARY KEY CLUSTERED 
(
	[SalesDistributeDetailsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Stock]    Script Date: 3/30/2024 4:24:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Stock](
	[StockID] [bigint] IDENTITY(1,1) NOT NULL,
	[CompanyId] [int] NOT NULL,
	[TotalEja] [int] NOT NULL,
	[TotalPrice] [decimal](18, 2) NOT NULL,
	[TotalNewProduct] [int] NOT NULL,
	[GrandTotal] [int] NOT NULL,
	[TotalSalesQuantity] [int] NOT NULL,
	[GrandTotalAmount] [decimal](18, 2) NOT NULL,
	[CreationTime] [datetime] NOT NULL,
	[IsDeleted] [int] NOT NULL,
	[DamageAmount] [decimal](18, 2) NOT NULL,
	[SRCommission] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_Stock] PRIMARY KEY CLUSTERED 
(
	[StockID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StockDetails]    Script Date: 3/30/2024 4:24:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StockDetails](
	[StockDetailsID] [uniqueidentifier] NOT NULL,
	[StockID] [bigint] NOT NULL,
	[ProductId] [int] NOT NULL,
	[CompanyId] [int] NOT NULL,
	[Eja] [int] NULL,
	[RestockQuantity] [int] NULL,
	[SalesQuantity] [int] NULL,
	[Price] [decimal](18, 2) NOT NULL,
	[TotalQuantity] [int] NULL,
	[TotalAmount] [decimal](18, 2) NULL,
	[CreationTime] [datetime] NOT NULL,
	[IsDeleted] [int] NOT NULL,
	[DamageQuantity] [int] NULL,
 CONSTRAINT [PK_StockDetails_1] PRIMARY KEY CLUSTERED 
(
	[StockDetailsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 3/30/2024 4:24:25 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NOT NULL,
	[LastName] [nvarchar](max) NOT NULL,
	[UserName] [nvarchar](max) NOT NULL,
	[Password] [nvarchar](max) NOT NULL,
	[Token] [nvarchar](max) NULL,
	[RoleId] [int] NOT NULL,
	[IsDeleted] [int] NOT NULL,
	[UserStatus] [int] NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20240326164224_IceCreamDBScript', N'6.0.19')
GO
SET IDENTITY_INSERT [dbo].[Company] ON 

INSERT [dbo].[Company] ([CompanyId], [CompanyName], [Picture], [IsDeleted]) VALUES (1, N'Google', N'', 0)
INSERT [dbo].[Company] ([CompanyId], [CompanyName], [Picture], [IsDeleted]) VALUES (2, N'EYE', N'', 0)
SET IDENTITY_INSERT [dbo].[Company] OFF
GO
SET IDENTITY_INSERT [dbo].[ConcernPerson] ON 

INSERT [dbo].[ConcernPerson] ([ConcernPersonId], [ConcernPersonName], [IsDeleted]) VALUES (1, N'Rasel Khan1', 1)
INSERT [dbo].[ConcernPerson] ([ConcernPersonId], [ConcernPersonName], [IsDeleted]) VALUES (2, N'Abdul Ahad 2', 1)
INSERT [dbo].[ConcernPerson] ([ConcernPersonId], [ConcernPersonName], [IsDeleted]) VALUES (3, N'Abdul Ahad  ', 0)
INSERT [dbo].[ConcernPerson] ([ConcernPersonId], [ConcernPersonName], [IsDeleted]) VALUES (4, N'Rakim ', 0)
INSERT [dbo].[ConcernPerson] ([ConcernPersonId], [ConcernPersonName], [IsDeleted]) VALUES (5, N'Rakim Pro', 1)
INSERT [dbo].[ConcernPerson] ([ConcernPersonId], [ConcernPersonName], [IsDeleted]) VALUES (6, N'Hina', 1)
INSERT [dbo].[ConcernPerson] ([ConcernPersonId], [ConcernPersonName], [IsDeleted]) VALUES (7, N'lina', 1)
INSERT [dbo].[ConcernPerson] ([ConcernPersonId], [ConcernPersonName], [IsDeleted]) VALUES (8, N'Rakim ', 1)
INSERT [dbo].[ConcernPerson] ([ConcernPersonId], [ConcernPersonName], [IsDeleted]) VALUES (9, N'Rakim ', 1)
INSERT [dbo].[ConcernPerson] ([ConcernPersonId], [ConcernPersonName], [IsDeleted]) VALUES (10, N'Rakim ', 1)
INSERT [dbo].[ConcernPerson] ([ConcernPersonId], [ConcernPersonName], [IsDeleted]) VALUES (11, N'Rakim ', 1)
INSERT [dbo].[ConcernPerson] ([ConcernPersonId], [ConcernPersonName], [IsDeleted]) VALUES (12, N'Rasel Khan', 1)
INSERT [dbo].[ConcernPerson] ([ConcernPersonId], [ConcernPersonName], [IsDeleted]) VALUES (13, N'Rasel Khan', 1)
INSERT [dbo].[ConcernPerson] ([ConcernPersonId], [ConcernPersonName], [IsDeleted]) VALUES (14, N'Rasel Khan', 0)
INSERT [dbo].[ConcernPerson] ([ConcernPersonId], [ConcernPersonName], [IsDeleted]) VALUES (15, N'rima', 1)
INSERT [dbo].[ConcernPerson] ([ConcernPersonId], [ConcernPersonName], [IsDeleted]) VALUES (16, N'Lotas', 0)
INSERT [dbo].[ConcernPerson] ([ConcernPersonId], [ConcernPersonName], [IsDeleted]) VALUES (17, N'', 0)
INSERT [dbo].[ConcernPerson] ([ConcernPersonId], [ConcernPersonName], [IsDeleted]) VALUES (18, N'Md.Shaon Khalifa', 0)
SET IDENTITY_INSERT [dbo].[ConcernPerson] OFF
GO
SET IDENTITY_INSERT [dbo].[products] ON 

INSERT [dbo].[products] ([ProductId], [ProductName], [Description], [CompanyId], [IsActive], [Price], [Sequence], [IsDeleted]) VALUES (4, N'CON', N'None', 1, 0, CAST(100.00 AS Decimal(18, 2)), 1, 0)
SET IDENTITY_INSERT [dbo].[products] OFF
GO
SET IDENTITY_INSERT [dbo].[Users] ON 

INSERT [dbo].[Users] ([UserId], [FirstName], [LastName], [UserName], [Password], [Token], [RoleId], [IsDeleted], [UserStatus]) VALUES (1, N'Md.Shaon', N'Khalifa', N'shaon', N'$2a$11$R7MrGC./StUBgTJsr9zIbOo4VK9qmuwIOaUxiQyW4/.3m/RGYnL8O', N' ', 1, 0, 1)
INSERT [dbo].[Users] ([UserId], [FirstName], [LastName], [UserName], [Password], [Token], [RoleId], [IsDeleted], [UserStatus]) VALUES (9, N'Rakibul', N'Hasib', N'rakim', N'$2a$11$3M1UYKaq3h8BRyt7.Fp5.ur.0.dg5jryxPdvYSC7PA7a2dd.3VM8u', N' ', 1, 0, 4)
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
ALTER TABLE [dbo].[SalesDistribute] ADD  DEFAULT (getdate()) FOR [CreationTime]
GO
ALTER TABLE [dbo].[SalesDistributeDetails] ADD  DEFAULT (getdate()) FOR [CreationTime]
GO
ALTER TABLE [dbo].[Stock] ADD  DEFAULT (getdate()) FOR [CreationTime]
GO
ALTER TABLE [dbo].[Stock] ADD  DEFAULT ((0.00)) FOR [DamageAmount]
GO
ALTER TABLE [dbo].[Stock] ADD  DEFAULT ((0.00)) FOR [SRCommission]
GO
ALTER TABLE [dbo].[StockDetails] ADD  DEFAULT (getdate()) FOR [CreationTime]
GO
ALTER TABLE [dbo].[products]  WITH CHECK ADD  CONSTRAINT [FK_products_Company_CompanyId] FOREIGN KEY([CompanyId])
REFERENCES [dbo].[Company] ([CompanyId])
GO
ALTER TABLE [dbo].[products] CHECK CONSTRAINT [FK_products_Company_CompanyId]
GO
ALTER TABLE [dbo].[SalesDistributeDetails]  WITH CHECK ADD  CONSTRAINT [FK_SalesDistributeDetails_SalesDistribute_SalesDistributeID] FOREIGN KEY([SalesDistributeID])
REFERENCES [dbo].[SalesDistribute] ([SalesDistributeID])
GO
ALTER TABLE [dbo].[SalesDistributeDetails] CHECK CONSTRAINT [FK_SalesDistributeDetails_SalesDistribute_SalesDistributeID]
GO
ALTER TABLE [dbo].[Stock]  WITH CHECK ADD  CONSTRAINT [FK_Stock_Company_CompanyId] FOREIGN KEY([CompanyId])
REFERENCES [dbo].[Company] ([CompanyId])
GO
ALTER TABLE [dbo].[Stock] CHECK CONSTRAINT [FK_Stock_Company_CompanyId]
GO
ALTER TABLE [dbo].[StockDetails]  WITH CHECK ADD  CONSTRAINT [FK_StockDetails_products_ProductId] FOREIGN KEY([ProductId])
REFERENCES [dbo].[products] ([ProductId])
GO
ALTER TABLE [dbo].[StockDetails] CHECK CONSTRAINT [FK_StockDetails_products_ProductId]
GO
ALTER TABLE [dbo].[StockDetails]  WITH CHECK ADD  CONSTRAINT [FK_StockDetails_Stock_StockID] FOREIGN KEY([StockID])
REFERENCES [dbo].[Stock] ([StockID])
GO
ALTER TABLE [dbo].[StockDetails] CHECK CONSTRAINT [FK_StockDetails_Stock_StockID]
GO

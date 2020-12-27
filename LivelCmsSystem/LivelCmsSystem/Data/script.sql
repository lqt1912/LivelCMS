/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 12/21/2020 9:31:46 PM ******/
use LivelCMSDb1
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
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 12/21/2020 9:31:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 12/21/2020 9:31:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 12/21/2020 9:31:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 12/21/2020 9:31:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 12/21/2020 9:31:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 12/21/2020 9:31:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 12/21/2020 9:31:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](128) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Brand]    Script Date: 12/21/2020 9:31:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Brand](
	[Id] [uniqueidentifier] NOT NULL,
	[BrandName] [nvarchar](50) NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedDate] [datetime] NULL,
 CONSTRAINT [PK_Brand] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 12/21/2020 9:31:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Address] [nvarchar](100) NULL,
	[PhoneNumber] [nvarchar](20) NULL,
	[Email] [nvarchar](50) NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedDate] [datetime] NULL,
	[IsActive] [bit] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Invoice]    Script Date: 12/21/2020 9:31:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Invoice](
	[Id] [uniqueidentifier] NOT NULL,
	[Discription] [nvarchar](max) NULL,
	[CreatedDate] [datetime] NULL,
	[ModifedDate] [datetime] NULL,
	[TotalPrice] [int] NULL,
	[Status] [uniqueidentifier] NULL,
	[CustomerId] [uniqueidentifier] NULL,
	[RemainDebt] [int] NULL,
 CONSTRAINT [PK_Invoice] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InvoiceDetail]    Script Date: 12/21/2020 9:31:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InvoiceDetail](
	[Id] [uniqueidentifier] NOT NULL,
	[Product] [uniqueidentifier] NULL,
	[Amount] [int] NULL,
	[UnitPrice] [int] NULL,
	[TotalPrice] [int] NULL,
	[InvoiceId] [uniqueidentifier] NULL,
	[ModifiedDate] [datetime] NULL,
	[CreatedDate] [datetime] NULL,
 CONSTRAINT [PK_InvoiceDetail] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[InvoiceStatus]    Script Date: 12/21/2020 9:31:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[InvoiceStatus](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](50) NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 12/21/2020 9:31:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[Id] [uniqueidentifier] NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Brand] [uniqueidentifier] NULL,
	[UnitPrice] [int] NULL,
	[ProductType] [uniqueidentifier] NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedDate] [datetime] NULL,
	[IsActive] [bit] NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ProductType]    Script Date: 12/21/2020 9:31:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProductType](
	[Id] [uniqueidentifier] NOT NULL,
	[ProductTypeName] [nvarchar](50) NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedDate] [datetime] NULL,
 CONSTRAINT [PK_ProductType] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Receipt]    Script Date: 12/21/2020 9:31:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Receipt](
	[Id] [uniqueidentifier] NOT NULL,
	[CustomerId] [uniqueidentifier] NULL,
	[ReceivedAmount] [int] NULL,
	[Description] [nvarchar](max) NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedDate] [datetime] NULL,
	[InvoiceId] [uniqueidentifier] NULL,
 CONSTRAINT [PK_Receipt] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'00000000000000_CreateIdentitySchema', N'3.1.7')
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'e8ce6ca5-96aa-459b-83e5-8bf2022ad808', N'admin@livel.com', N'ADMIN@LIVEL.COM', N'admin@livel.com', N'ADMIN@LIVEL.COM', 1, N'AQAAAAEAACcQAAAAEEFOzZUw1HC8IBeHI14i3xDMtqylGYCxl909HLbMZmztB3L6zwxS9CznV4CHbBaVlQ==', N'H3LSOFGM5LOKV6XMCT2UZCBRPIWTUOWV', N'0c29b5e5-3fd4-45ce-87d0-52e387535435', NULL, 0, 0, NULL, 1, 0)
GO
INSERT [dbo].[AspNetUserTokens] ([UserId], [LoginProvider], [Name], [Value]) VALUES (N'e8ce6ca5-96aa-459b-83e5-8bf2022ad808', N'[AspNetUserStore]', N'AuthenticatorKey', N'ECTQ2K6P6H7AMMUNWBUM4MG54EENFIRB')
GO
INSERT [dbo].[Brand] ([Id], [BrandName], [CreatedDate], [ModifiedDate]) VALUES (N'7bfd18fc-9d00-49f3-b418-2bb156660fbd', N'Thaco', CAST(N'2020-10-12T14:22:13.000' AS DateTime), CAST(N'2020-10-12T14:22:13.000' AS DateTime))
INSERT [dbo].[Brand] ([Id], [BrandName], [CreatedDate], [ModifiedDate]) VALUES (N'16e2b4b5-fead-4acf-b079-4ea9869bdea3', N'Wave', CAST(N'2020-10-12T14:22:13.000' AS DateTime), CAST(N'2020-10-12T14:22:13.000' AS DateTime))
INSERT [dbo].[Brand] ([Id], [BrandName], [CreatedDate], [ModifiedDate]) VALUES (N'dbba6830-2fb4-4467-be27-8ad115b89ab9', N'Honda', CAST(N'2020-10-12T14:22:13.000' AS DateTime), CAST(N'2020-10-12T14:22:13.000' AS DateTime))
INSERT [dbo].[Brand] ([Id], [BrandName], [CreatedDate], [ModifiedDate]) VALUES (N'e32356ca-d0ac-42f5-a8df-96df5f538d67', N'Martin', CAST(N'2020-10-12T14:22:13.000' AS DateTime), CAST(N'2020-10-12T14:22:13.000' AS DateTime))
INSERT [dbo].[Brand] ([Id], [BrandName], [CreatedDate], [ModifiedDate]) VALUES (N'7dc4d627-8797-47aa-a525-cf346353bf8f', N'Vinfact', CAST(N'2020-10-12T14:22:13.000' AS DateTime), CAST(N'2020-10-12T14:22:13.000' AS DateTime))
GO
INSERT [dbo].[Customer] ([Id], [Name], [Address], [PhoneNumber], [Email], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'46ef5d75-f5d5-4f13-bf0f-018afa1ba6c2', N'Đại lý số 2', N'Quận Hải Châu, Đà Nẵng', N'+84235678769', N'dailydanang@gmail.com', CAST(N'2020-10-12T15:44:11.000' AS DateTime), CAST(N'2020-10-12T15:44:11.000' AS DateTime), 0)
INSERT [dbo].[Customer] ([Id], [Name], [Address], [PhoneNumber], [Email], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'1a27fec5-57a4-4335-855f-05cc414568bc', N'Đại lý số 2', N'Quận Hải Châu, Đà Nẵng', N'0235678769', N'dailydanang@gmail.com', CAST(N'2020-11-28T02:59:54.827' AS DateTime), CAST(N'2020-11-28T02:59:54.827' AS DateTime), 1)
INSERT [dbo].[Customer] ([Id], [Name], [Address], [PhoneNumber], [Email], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'768da56f-3575-44a7-b3e5-165be6d59621', N'Peter Griffin', N'Family Guys', N'112233', N'FG@FG.com', CAST(N'2020-11-04T08:38:47.253' AS DateTime), CAST(N'2020-11-04T08:38:47.253' AS DateTime), 0)
INSERT [dbo].[Customer] ([Id], [Name], [Address], [PhoneNumber], [Email], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'9f536517-9efd-4e00-8a53-2003d32d1ef3', N'Cửa hàng Dân', N'H. Châu Thành, Tây Ninh', N'0915257486', N'duonganhlinhh@gmail.com', NULL, CAST(N'2020-11-28T16:21:05.150' AS DateTime), 1)
INSERT [dbo].[Customer] ([Id], [Name], [Address], [PhoneNumber], [Email], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'896e9529-8d42-4658-aca4-2078f972ed6e', N'aaaaabbbbbbb', N'aaa', N'11aaa', N'aaaaaa', CAST(N'2020-11-04T08:25:33.067' AS DateTime), CAST(N'2020-11-04T08:25:33.067' AS DateTime), 0)
INSERT [dbo].[Customer] ([Id], [Name], [Address], [PhoneNumber], [Email], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'da4fe8d2-56a0-4049-9dd0-2520f0379ad7', N'Lê Quốc Thắng', N'TN, 111', N'0857394951', N'thanglequoc1912@gmail.com', CAST(N'2020-11-28T10:14:54.877' AS DateTime), CAST(N'2020-11-28T10:14:54.877' AS DateTime), 0)
INSERT [dbo].[Customer] ([Id], [Name], [Address], [PhoneNumber], [Email], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'f0172b22-6bf9-449f-8559-27c45579f943', N'Lê Quốc Thắng', N'TN, 111', N'0857394952', N'thanglequoc1912@gmail.com1', CAST(N'2020-11-28T10:31:57.953' AS DateTime), CAST(N'2020-11-28T10:31:57.953' AS DateTime), 0)
INSERT [dbo].[Customer] ([Id], [Name], [Address], [PhoneNumber], [Email], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'bb06d7dd-2976-445d-bf95-2edb7e9bff94', N'Cửa hàng Bình Dân', N'H. Châu Thành, Tây Ninh', N'0235678769', N'binhdanshop@gmail.com', CAST(N'2020-10-12T15:44:11.000' AS DateTime), CAST(N'2020-10-12T15:44:11.000' AS DateTime), 1)
INSERT [dbo].[Customer] ([Id], [Name], [Address], [PhoneNumber], [Email], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'a20aaeb3-1eea-4708-a8b3-2eee5684593f', NULL, NULL, NULL, NULL, CAST(N'2020-11-04T08:36:52.473' AS DateTime), CAST(N'2020-11-04T08:36:52.473' AS DateTime), 0)
INSERT [dbo].[Customer] ([Id], [Name], [Address], [PhoneNumber], [Email], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'938adcc8-70d7-4089-81a1-37911139aac9', NULL, NULL, NULL, NULL, CAST(N'2020-11-04T07:21:54.967' AS DateTime), CAST(N'2020-11-04T07:21:54.967' AS DateTime), 0)
INSERT [dbo].[Customer] ([Id], [Name], [Address], [PhoneNumber], [Email], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'75754db0-a096-4599-a529-4bff2b5a265d', N'Lê Quốc Thắng', N'aaaaaaaaaa', N'0857394951', N'thanglequoc1912@gmail.com', CAST(N'2020-10-31T12:26:49.800' AS DateTime), CAST(N'2020-12-02T19:24:16.033' AS DateTime), 1)
INSERT [dbo].[Customer] ([Id], [Name], [Address], [PhoneNumber], [Email], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'24f9be1a-2f20-43c7-8819-4c7709f74eec', N'12213214124124', N'12321412412421421', N'12334567864', N'1233242343242323434324324324', CAST(N'2020-11-28T13:31:54.217' AS DateTime), CAST(N'2020-11-28T13:31:54.217' AS DateTime), 0)
INSERT [dbo].[Customer] ([Id], [Name], [Address], [PhoneNumber], [Email], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'c2a9b067-93a8-407b-a660-53966daeb6c7', N'aaaaaaaaaj', N'46a nguyễn xiển p9 ad hcmmmm', N'7895445215', N'hsadssadsad@gmail.com', CAST(N'2020-11-29T18:37:24.297' AS DateTime), CAST(N'2020-12-02T19:17:14.443' AS DateTime), 0)
INSERT [dbo].[Customer] ([Id], [Name], [Address], [PhoneNumber], [Email], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'890dbaaa-ea4b-4cab-a683-573dfbb3c5d5', N'Cửa hàng Bình Dân', N'H. Châu Thành, Tây Ninh', N'0235678769', N'danshop@gmail.com', CAST(N'2020-10-31T09:36:09.547' AS DateTime), CAST(N'2020-10-31T09:36:09.547' AS DateTime), 1)
INSERT [dbo].[Customer] ([Id], [Name], [Address], [PhoneNumber], [Email], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'0f90198a-0c3f-4e18-917c-6a64ccd930c9', N'aaaaa', N'aaa', N'11aaa', N'aaaaaa', CAST(N'2020-10-31T12:46:14.253' AS DateTime), CAST(N'2020-10-31T12:46:14.253' AS DateTime), 0)
INSERT [dbo].[Customer] ([Id], [Name], [Address], [PhoneNumber], [Email], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'4ceec93d-3937-47d8-91dd-6af52a817cf0', N'Đại lý số 2', N'Quận Hải Châu, Đà Nẵng', N'+84235678769', N'dailydanang@gmail.com', CAST(N'2020-10-31T12:36:50.440' AS DateTime), CAST(N'2020-10-31T12:36:50.440' AS DateTime), 0)
INSERT [dbo].[Customer] ([Id], [Name], [Address], [PhoneNumber], [Email], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'd0ce7346-5377-418d-b59c-6b3cad75d941', N'aaaaa', N'aaa', N'11aaa', N'aaaaaa', CAST(N'2020-11-04T07:23:25.090' AS DateTime), CAST(N'2020-11-04T07:23:25.090' AS DateTime), 0)
INSERT [dbo].[Customer] ([Id], [Name], [Address], [PhoneNumber], [Email], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'128c1027-936e-47c5-9421-6fcd3cffe748', N'Lê Quốc Thắng', N'TN, 111', N'085739495111', N'thanglequoc1912@gmail.comm', CAST(N'2020-11-28T10:35:45.590' AS DateTime), CAST(N'2020-11-28T10:35:45.590' AS DateTime), 0)
INSERT [dbo].[Customer] ([Id], [Name], [Address], [PhoneNumber], [Email], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'1e0f73f4-08de-4c23-a8b8-710072b18f70', N'Lê Quốc Thắng', N'TN, 111', N'0857394951', N'thanglequoc1912@gmail.com', CAST(N'2020-10-12T16:07:23.317' AS DateTime), CAST(N'2020-10-12T16:07:23.320' AS DateTime), 0)
INSERT [dbo].[Customer] ([Id], [Name], [Address], [PhoneNumber], [Email], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'77beccf6-5fca-4637-a67e-7266c4be750b', N'Glen Quagmire', N'Rhode Island', N'4204204200', N'glenquagmire@gmail.com', NULL, CAST(N'2020-12-18T03:09:20.487' AS DateTime), 1)
INSERT [dbo].[Customer] ([Id], [Name], [Address], [PhoneNumber], [Email], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'b8302612-2d04-483f-86c3-765c9439d7e4', N'Lê Quốc Thắng', N'TN, 111', N'0857394951', N'thanglequoc1912@gmail.com', CAST(N'2020-11-28T10:09:26.620' AS DateTime), CAST(N'2020-11-28T10:09:26.620' AS DateTime), 0)
INSERT [dbo].[Customer] ([Id], [Name], [Address], [PhoneNumber], [Email], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'670b84fe-2062-4aac-b7cf-7cf643b52ae5', N'A Nam', N'12', N'123456', N'a@gmail.com', CAST(N'2020-10-31T09:24:35.810' AS DateTime), CAST(N'2020-10-31T09:24:35.810' AS DateTime), 0)
INSERT [dbo].[Customer] ([Id], [Name], [Address], [PhoneNumber], [Email], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'535fb564-655a-4cab-8770-8833331fc554', N'Cửa hàng Dân', N'H. Châu Thành, Tây Ninh', N'+84235678769', N'binhdanshop@gmail.com', CAST(N'2020-10-31T09:36:32.453' AS DateTime), CAST(N'2020-10-31T09:36:32.453' AS DateTime), 0)
INSERT [dbo].[Customer] ([Id], [Name], [Address], [PhoneNumber], [Email], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'd009171d-3059-4e34-ab49-8a4215c7102c', N'Lê Quốc Thắng', N'TN, 111', N'08573949511', N'thanglequoc1912@gmail.com1', CAST(N'2020-11-28T10:11:22.503' AS DateTime), CAST(N'2020-11-28T10:11:22.503' AS DateTime), 0)
INSERT [dbo].[Customer] ([Id], [Name], [Address], [PhoneNumber], [Email], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'c0b3b232-df1d-48f7-81e5-96e9e3e9ea9b', N'Lê Quốc Thắng', N'TN, 111', N'0857394952', N'thanglequoc1912@gmail.com', CAST(N'2020-11-28T03:05:56.840' AS DateTime), CAST(N'2020-11-28T03:05:56.840' AS DateTime), 0)
INSERT [dbo].[Customer] ([Id], [Name], [Address], [PhoneNumber], [Email], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'29379daa-bf47-41f4-bc79-a777e80a11cc', N'Lê Quốc Thắng', N'Lê Quốc Thắng', N'+857394953', N'thanglequoc1912@gmail.comm', CAST(N'2020-11-28T03:20:58.910' AS DateTime), CAST(N'2020-11-28T03:20:58.910' AS DateTime), 0)
INSERT [dbo].[Customer] ([Id], [Name], [Address], [PhoneNumber], [Email], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'0646d5ea-0c47-43ef-a3ad-a9868271dcb8', N'Lê Quốc Thắng', N'Lê Quốc Thắng', N'0857394951', N'thanglequoc1912@gmail.com', CAST(N'2020-11-28T03:06:50.983' AS DateTime), CAST(N'2020-11-28T03:06:50.983' AS DateTime), 0)
INSERT [dbo].[Customer] ([Id], [Name], [Address], [PhoneNumber], [Email], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'7759feeb-05da-4681-97e3-add7850035d6', N'Đại lý số 1', N'Quận 7, TP HCM', N'+84235678765', N'dailysomot@gmail.com', CAST(N'2020-10-12T17:13:20.117' AS DateTime), CAST(N'2020-10-12T17:13:20.117' AS DateTime), 0)
INSERT [dbo].[Customer] ([Id], [Name], [Address], [PhoneNumber], [Email], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'aa8e7458-9e9a-49f2-ac57-ba2a8d4dea49', N'a111111421421421', N'12322221323213123', N'123123213213', N'1242311321321312222222222', CAST(N'2020-11-28T04:47:40.520' AS DateTime), CAST(N'2020-11-28T04:47:40.520' AS DateTime), 0)
INSERT [dbo].[Customer] ([Id], [Name], [Address], [PhoneNumber], [Email], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'fb24b913-185c-4d8c-bbb8-c47801ca8ccb', N'Đại lý số 1', N'Quận 7, TP HCM', N'+84235678765', N'dailysomot@gmail.com', CAST(N'2020-10-12T15:44:11.000' AS DateTime), CAST(N'2020-10-12T15:44:11.000' AS DateTime), 0)
INSERT [dbo].[Customer] ([Id], [Name], [Address], [PhoneNumber], [Email], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'1bc0b910-8377-4c4a-850d-c7b01a5f98ab', N'Phạm Tuấn Anh', N'203, đường Huỳnh Văn Lũy, khu 6, phường Phú Lợi, TP.Thủ Dầu Một, tỉnh Bình Dương', N'0868992467', N'chienthan1999@gmail.com', CAST(N'2020-12-08T05:08:41.460' AS DateTime), CAST(N'2020-12-08T05:08:41.460' AS DateTime), 1)
INSERT [dbo].[Customer] ([Id], [Name], [Address], [PhoneNumber], [Email], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'755c3181-b195-426b-9f8c-d16552b23789', N'Cửa hàng Bình Dân', N'H. Châu Thành, Tây Ninh', N'+84235678769', N'binhdanshop@gmail.com', CAST(N'2020-10-31T09:35:07.493' AS DateTime), CAST(N'2020-10-31T09:35:07.493' AS DateTime), 0)
INSERT [dbo].[Customer] ([Id], [Name], [Address], [PhoneNumber], [Email], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'd1e2c311-0637-442a-bd3f-e1540f882f95', N'Cửa hàng Hồng Hoa', N'H. Châu Thành, Tiền Giang', N'+84235678769', N'rosingshop@gmail.com', CAST(N'2020-10-12T15:44:11.000' AS DateTime), CAST(N'2020-10-12T15:44:11.000' AS DateTime), 0)
INSERT [dbo].[Customer] ([Id], [Name], [Address], [PhoneNumber], [Email], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'd6480197-15ed-405b-b368-e24fbf349639', N'Đại lý số 11', N'Quận 7, TP HCM', N'84235678788', N'dailysomotggggmail..com', NULL, CAST(N'2020-11-28T09:38:10.330' AS DateTime), 1)
INSERT [dbo].[Customer] ([Id], [Name], [Address], [PhoneNumber], [Email], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'723603b4-9dc2-4b68-b6c1-f53a3d955d13', NULL, N'H. Châu Thành, Tây Ninh', N'+84235678769', N'binhdanshop@gmail.com', CAST(N'2020-11-04T07:20:52.370' AS DateTime), CAST(N'2020-11-04T07:20:52.370' AS DateTime), 0)
INSERT [dbo].[Customer] ([Id], [Name], [Address], [PhoneNumber], [Email], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'bc6bb680-4438-436a-8f70-f8b4789b2b04', N'Cửa hàng Bình Dân', N'H. Châu Thành, Tây Ninh', N'0235678769', N'binhdanshop@gmail.com', CAST(N'2020-11-28T04:19:24.767' AS DateTime), CAST(N'2020-11-28T16:20:54.790' AS DateTime), 0)
GO
INSERT [dbo].[Invoice] ([Id], [Discription], [CreatedDate], [ModifedDate], [TotalPrice], [Status], [CustomerId], [RemainDebt]) VALUES (N'111fbb5b-7715-479d-ad3e-089772bc4ed4', N'12', CAST(N'2020-12-06T06:44:05.157' AS DateTime), CAST(N'2020-12-06T06:44:05.157' AS DateTime), 11200000, N'a46e56ac-c0b6-4ad6-bd4c-83e47b23d31b', N'9f536517-9efd-4e00-8a53-2003d32d1ef3', 11200000)
INSERT [dbo].[Invoice] ([Id], [Discription], [CreatedDate], [ModifedDate], [TotalPrice], [Status], [CustomerId], [RemainDebt]) VALUES (N'cf81b3df-5ac0-4635-9998-3dba1deab72e', NULL, CAST(N'2020-11-28T12:37:21.087' AS DateTime), CAST(N'2020-11-28T12:41:57.673' AS DateTime), 600, N'd2eb43bf-f6f0-4fa1-af9b-97fce37977c6', N'da4fe8d2-56a0-4049-9dd0-2520f0379ad7', 0)
INSERT [dbo].[Invoice] ([Id], [Discription], [CreatedDate], [ModifedDate], [TotalPrice], [Status], [CustomerId], [RemainDebt]) VALUES (N'9f596f90-c88b-48ae-bb5b-50a7edb2db9d', N'fdsfd', CAST(N'2020-11-29T15:51:53.820' AS DateTime), CAST(N'2020-11-29T15:52:18.610' AS DateTime), 0, N'a46e56ac-c0b6-4ad6-bd4c-83e47b23d31b', N'890dbaaa-ea4b-4cab-a683-573dfbb3c5d5', 0)
INSERT [dbo].[Invoice] ([Id], [Discription], [CreatedDate], [ModifedDate], [TotalPrice], [Status], [CustomerId], [RemainDebt]) VALUES (N'33d5c409-bc51-4253-8f70-630c82bdda12', N'qqqqq', CAST(N'2020-11-28T02:49:17.810' AS DateTime), CAST(N'2020-11-28T10:49:10.830' AS DateTime), 240001000, N'3f74b911-771a-4af4-b297-79b7c3c695a5', N'46ef5d75-f5d5-4f13-bf0f-018afa1ba6c2', 239989889)
INSERT [dbo].[Invoice] ([Id], [Discription], [CreatedDate], [ModifedDate], [TotalPrice], [Status], [CustomerId], [RemainDebt]) VALUES (N'6192f5a2-4499-46aa-bec6-70484de53a44', N'AA', CAST(N'2020-11-28T08:15:59.387' AS DateTime), CAST(N'2020-11-28T08:46:12.747' AS DateTime), 2000, N'a46e56ac-c0b6-4ad6-bd4c-83e47b23d31b', N'd6480197-15ed-405b-b368-e24fbf349639', 500)
INSERT [dbo].[Invoice] ([Id], [Discription], [CreatedDate], [ModifedDate], [TotalPrice], [Status], [CustomerId], [RemainDebt]) VALUES (N'7635ff42-dea1-40bd-97d4-7426f856f8e8', N'AAAA', CAST(N'2020-11-28T05:23:54.220' AS DateTime), CAST(N'2020-11-28T12:32:10.003' AS DateTime), 200, N'a46e56ac-c0b6-4ad6-bd4c-83e47b23d31b', N'da4fe8d2-56a0-4049-9dd0-2520f0379ad7', 0)
INSERT [dbo].[Invoice] ([Id], [Discription], [CreatedDate], [ModifedDate], [TotalPrice], [Status], [CustomerId], [RemainDebt]) VALUES (N'5345b167-eb40-454c-b9d1-75be4c0c766c', N'ĐA', CAST(N'2020-12-19T15:04:46.913' AS DateTime), CAST(N'2020-12-19T15:04:46.913' AS DateTime), 0, N'a46e56ac-c0b6-4ad6-bd4c-83e47b23d31b', N'1a27fec5-57a4-4335-855f-05cc414568bc', 0)
INSERT [dbo].[Invoice] ([Id], [Discription], [CreatedDate], [ModifedDate], [TotalPrice], [Status], [CustomerId], [RemainDebt]) VALUES (N'85d57f9b-e6c7-49a4-a056-905ef0a4f9b4', N'Mua hàng', CAST(N'2020-11-28T05:54:05.023' AS DateTime), CAST(N'2020-11-28T05:55:47.103' AS DateTime), 24000000, N'd2eb43bf-f6f0-4fa1-af9b-97fce37977c6', N'bc6bb680-4438-436a-8f70-f8b4789b2b04', 0)
INSERT [dbo].[Invoice] ([Id], [Discription], [CreatedDate], [ModifedDate], [TotalPrice], [Status], [CustomerId], [RemainDebt]) VALUES (N'5a2d0006-f3f5-46bb-b732-9e79f48f8488', N'Mua mới', CAST(N'2020-11-28T03:40:30.550' AS DateTime), CAST(N'2020-11-29T17:33:51.217' AS DateTime), 211, N'3f74b911-771a-4af4-b297-79b7c3c695a5', N'128c1027-936e-47c5-9421-6fcd3cffe748', 10)
INSERT [dbo].[Invoice] ([Id], [Discription], [CreatedDate], [ModifedDate], [TotalPrice], [Status], [CustomerId], [RemainDebt]) VALUES (N'37c3eb97-7841-4d45-a4c1-bbac9865eaae', N'a1', CAST(N'2020-11-28T12:21:07.213' AS DateTime), CAST(N'2020-11-28T12:59:06.997' AS DateTime), 1000, N'a46e56ac-c0b6-4ad6-bd4c-83e47b23d31b', N'da4fe8d2-56a0-4049-9dd0-2520f0379ad7', 1000)
INSERT [dbo].[Invoice] ([Id], [Discription], [CreatedDate], [ModifedDate], [TotalPrice], [Status], [CustomerId], [RemainDebt]) VALUES (N'4f39ec3c-5cab-4a21-bbda-becdb92a5315', NULL, CAST(N'2020-12-08T05:09:40.587' AS DateTime), CAST(N'2020-12-08T05:09:40.587' AS DateTime), 31000000, N'a46e56ac-c0b6-4ad6-bd4c-83e47b23d31b', N'1bc0b910-8377-4c4a-850d-c7b01a5f98ab', 31000000)
INSERT [dbo].[Invoice] ([Id], [Discription], [CreatedDate], [ModifedDate], [TotalPrice], [Status], [CustomerId], [RemainDebt]) VALUES (N'2b22ee6f-b559-415a-a902-bed3735eba60', N'aaaaaaaaaaaaaaaaaaaa', CAST(N'2020-11-29T16:03:33.653' AS DateTime), CAST(N'2020-12-18T03:49:04.853' AS DateTime), 7550, N'a46e56ac-c0b6-4ad6-bd4c-83e47b23d31b', N'd6480197-15ed-405b-b368-e24fbf349639', 7550)
INSERT [dbo].[Invoice] ([Id], [Discription], [CreatedDate], [ModifedDate], [TotalPrice], [Status], [CustomerId], [RemainDebt]) VALUES (N'd82517e9-68cb-4278-8d6e-ea2767fddc4b', N'phúc', CAST(N'2020-11-29T15:56:13.060' AS DateTime), CAST(N'2020-11-29T15:56:13.060' AS DateTime), 111, N'a46e56ac-c0b6-4ad6-bd4c-83e47b23d31b', N'9f536517-9efd-4e00-8a53-2003d32d1ef3', 111)
INSERT [dbo].[Invoice] ([Id], [Discription], [CreatedDate], [ModifedDate], [TotalPrice], [Status], [CustomerId], [RemainDebt]) VALUES (N'9cb15886-6b06-4047-b8d4-efb0c5271947', NULL, CAST(N'2020-11-28T12:36:53.070' AS DateTime), CAST(N'2020-11-28T12:36:53.070' AS DateTime), 0, N'a46e56ac-c0b6-4ad6-bd4c-83e47b23d31b', N'da4fe8d2-56a0-4049-9dd0-2520f0379ad7', 0)
GO
INSERT [dbo].[InvoiceDetail] ([Id], [Product], [Amount], [UnitPrice], [TotalPrice], [InvoiceId], [ModifiedDate], [CreatedDate]) VALUES (N'1ed6018a-c8d6-4ac8-a01b-0eb6cc97c88c', N'ab8d8591-3f67-49e1-8e07-17d068f65ddd', 1, 2000, 2000, N'2b22ee6f-b559-415a-a902-bed3735eba60', CAST(N'2020-12-18T03:40:21.030' AS DateTime), CAST(N'2020-12-18T03:40:21.030' AS DateTime))
INSERT [dbo].[InvoiceDetail] ([Id], [Product], [Amount], [UnitPrice], [TotalPrice], [InvoiceId], [ModifiedDate], [CreatedDate]) VALUES (N'62721382-cc9b-421a-ab18-2446996193f4', N'a186851f-5528-43c8-a8d9-14262d06d452', 50, 111, 5550, N'2b22ee6f-b559-415a-a902-bed3735eba60', CAST(N'2020-12-02T20:17:34.193' AS DateTime), CAST(N'2020-12-02T20:17:34.193' AS DateTime))
INSERT [dbo].[InvoiceDetail] ([Id], [Product], [Amount], [UnitPrice], [TotalPrice], [InvoiceId], [ModifiedDate], [CreatedDate]) VALUES (N'cb97c2fd-ee51-4c27-8471-423e61322bec', N'8ddd9d9f-69fa-4650-baad-04421f8bb329', 10, 100, 1000, N'33d5c409-bc51-4253-8f70-630c82bdda12', CAST(N'2020-11-28T02:49:26.567' AS DateTime), CAST(N'2020-11-28T02:49:26.567' AS DateTime))
INSERT [dbo].[InvoiceDetail] ([Id], [Product], [Amount], [UnitPrice], [TotalPrice], [InvoiceId], [ModifiedDate], [CreatedDate]) VALUES (N'7d9b00b8-1ff1-4954-bddd-4c1cf0b2c62b', N'a186851f-5528-43c8-a8d9-14262d06d452', 1, 111, 111, N'd82517e9-68cb-4278-8d6e-ea2767fddc4b', CAST(N'2020-11-29T15:56:23.897' AS DateTime), CAST(N'2020-11-29T15:56:23.897' AS DateTime))
INSERT [dbo].[InvoiceDetail] ([Id], [Product], [Amount], [UnitPrice], [TotalPrice], [InvoiceId], [ModifiedDate], [CreatedDate]) VALUES (N'8e81f373-21dd-45cf-81b3-51d9e30229bd', N'8ddd9d9f-69fa-4650-baad-04421f8bb329', 1, 100, 100, N'7635ff42-dea1-40bd-97d4-7426f856f8e8', CAST(N'2020-11-28T12:27:48.330' AS DateTime), CAST(N'2020-11-28T12:27:48.330' AS DateTime))
INSERT [dbo].[InvoiceDetail] ([Id], [Product], [Amount], [UnitPrice], [TotalPrice], [InvoiceId], [ModifiedDate], [CreatedDate]) VALUES (N'dba6647f-eba1-4738-97ad-56a969023a0e', N'8ddd9d9f-69fa-4650-baad-04421f8bb329', 1, 100, 100, N'5a2d0006-f3f5-46bb-b732-9e79f48f8488', CAST(N'2020-11-28T03:40:40.627' AS DateTime), CAST(N'2020-11-28T03:40:40.627' AS DateTime))
INSERT [dbo].[InvoiceDetail] ([Id], [Product], [Amount], [UnitPrice], [TotalPrice], [InvoiceId], [ModifiedDate], [CreatedDate]) VALUES (N'4e32db0d-6684-4f32-9b48-591a41fbfe13', N'984a6da0-2d35-4876-82d6-27a202935315', 10, 2000000, 20000000, N'85d57f9b-e6c7-49a4-a056-905ef0a4f9b4', CAST(N'2020-11-28T05:54:15.723' AS DateTime), CAST(N'2020-11-28T05:54:15.723' AS DateTime))
INSERT [dbo].[InvoiceDetail] ([Id], [Product], [Amount], [UnitPrice], [TotalPrice], [InvoiceId], [ModifiedDate], [CreatedDate]) VALUES (N'1602c1df-7db1-4f8d-8333-62b3ac42bb96', N'8ddd9d9f-69fa-4650-baad-04421f8bb329', 1, 100, 100, N'cf81b3df-5ac0-4635-9998-3dba1deab72e', CAST(N'2020-11-28T12:38:24.993' AS DateTime), CAST(N'2020-11-28T12:38:24.993' AS DateTime))
INSERT [dbo].[InvoiceDetail] ([Id], [Product], [Amount], [UnitPrice], [TotalPrice], [InvoiceId], [ModifiedDate], [CreatedDate]) VALUES (N'c8ffaa3f-53d0-4a61-a8cc-6b193d3e281f', N'8ddd9d9f-69fa-4650-baad-04421f8bb329', 1, 1000, 1000, N'37c3eb97-7841-4d45-a4c1-bbac9865eaae', CAST(N'2020-11-28T12:55:23.470' AS DateTime), CAST(N'2020-11-28T12:55:23.470' AS DateTime))
INSERT [dbo].[InvoiceDetail] ([Id], [Product], [Amount], [UnitPrice], [TotalPrice], [InvoiceId], [ModifiedDate], [CreatedDate]) VALUES (N'23c40ec0-cdf4-4d2c-9bd7-771cba392e76', N'6250d2dc-a0cb-4c65-b3f5-3af854574264', 31, 1000000, 31000000, N'4f39ec3c-5cab-4a21-bbda-becdb92a5315', CAST(N'2020-12-08T05:09:56.750' AS DateTime), CAST(N'2020-12-08T05:09:56.750' AS DateTime))
INSERT [dbo].[InvoiceDetail] ([Id], [Product], [Amount], [UnitPrice], [TotalPrice], [InvoiceId], [ModifiedDate], [CreatedDate]) VALUES (N'3f45eace-b058-489d-a040-8735a458b2b2', N'8ddd9d9f-69fa-4650-baad-04421f8bb329', 4, 100, 400, N'cf81b3df-5ac0-4635-9998-3dba1deab72e', CAST(N'2020-11-28T12:38:47.707' AS DateTime), CAST(N'2020-11-28T12:38:47.707' AS DateTime))
INSERT [dbo].[InvoiceDetail] ([Id], [Product], [Amount], [UnitPrice], [TotalPrice], [InvoiceId], [ModifiedDate], [CreatedDate]) VALUES (N'69c9a5b4-6c56-45a5-996a-9709fd755888', N'984a6da0-2d35-4876-82d6-27a202935315', 2, 2000000, 4000000, N'85d57f9b-e6c7-49a4-a056-905ef0a4f9b4', CAST(N'2020-11-28T05:54:24.307' AS DateTime), CAST(N'2020-11-28T05:54:24.307' AS DateTime))
INSERT [dbo].[InvoiceDetail] ([Id], [Product], [Amount], [UnitPrice], [TotalPrice], [InvoiceId], [ModifiedDate], [CreatedDate]) VALUES (N'1363ded3-f8ea-4032-bc07-b79a80da64ab', N'ab8d8591-3f67-49e1-8e07-17d068f65ddd', 1, 2000, 2000, N'6192f5a2-4499-46aa-bec6-70484de53a44', CAST(N'2020-11-28T08:41:46.460' AS DateTime), CAST(N'2020-11-28T08:41:46.460' AS DateTime))
INSERT [dbo].[InvoiceDetail] ([Id], [Product], [Amount], [UnitPrice], [TotalPrice], [InvoiceId], [ModifiedDate], [CreatedDate]) VALUES (N'4780b86f-822a-4857-878a-c3507fb92438', N'8ddd9d9f-69fa-4650-baad-04421f8bb329', 1, 100, 100, N'cf81b3df-5ac0-4635-9998-3dba1deab72e', CAST(N'2020-11-28T12:38:21.277' AS DateTime), CAST(N'2020-11-28T12:38:21.277' AS DateTime))
INSERT [dbo].[InvoiceDetail] ([Id], [Product], [Amount], [UnitPrice], [TotalPrice], [InvoiceId], [ModifiedDate], [CreatedDate]) VALUES (N'b999a5f4-b9f2-41ee-a3f8-c46b1dca97d7', N'a186851f-5528-43c8-a8d9-14262d06d452', 1, 111, 111, N'5a2d0006-f3f5-46bb-b732-9e79f48f8488', CAST(N'2020-11-28T03:40:47.980' AS DateTime), CAST(N'2020-11-28T03:40:47.980' AS DateTime))
INSERT [dbo].[InvoiceDetail] ([Id], [Product], [Amount], [UnitPrice], [TotalPrice], [InvoiceId], [ModifiedDate], [CreatedDate]) VALUES (N'34052767-bd53-4d71-843f-db1273246799', N'c17d982e-f82f-4a9d-8654-34b2193ba9c5', 1, 11200000, 11200000, N'111fbb5b-7715-479d-ad3e-089772bc4ed4', CAST(N'2020-12-17T03:49:34.783' AS DateTime), CAST(N'2020-12-17T03:49:34.783' AS DateTime))
INSERT [dbo].[InvoiceDetail] ([Id], [Product], [Amount], [UnitPrice], [TotalPrice], [InvoiceId], [ModifiedDate], [CreatedDate]) VALUES (N'fc2b180e-36c7-4c16-9afe-ef15a8e58f51', N'629171fa-ed97-4362-8d78-1ca1ef5baf9a', 12, 20000000, 240000000, N'33d5c409-bc51-4253-8f70-630c82bdda12', CAST(N'2020-11-28T02:49:32.127' AS DateTime), CAST(N'2020-11-28T02:49:32.127' AS DateTime))
INSERT [dbo].[InvoiceDetail] ([Id], [Product], [Amount], [UnitPrice], [TotalPrice], [InvoiceId], [ModifiedDate], [CreatedDate]) VALUES (N'c6663311-5800-4aa4-8a0d-f909b134d378', N'8ddd9d9f-69fa-4650-baad-04421f8bb329', 1, 100, 100, N'7635ff42-dea1-40bd-97d4-7426f856f8e8', CAST(N'2020-11-28T12:32:09.597' AS DateTime), CAST(N'2020-11-28T12:32:09.597' AS DateTime))
GO
INSERT [dbo].[InvoiceStatus] ([Id], [Name], [CreatedDate], [ModifiedDate]) VALUES (N'3f74b911-771a-4af4-b297-79b7c3c695a5', N'Còn nợ', CAST(N'2020-10-12T17:34:28.000' AS DateTime), CAST(N'2020-10-12T17:34:28.000' AS DateTime))
INSERT [dbo].[InvoiceStatus] ([Id], [Name], [CreatedDate], [ModifiedDate]) VALUES (N'a46e56ac-c0b6-4ad6-bd4c-83e47b23d31b', N'Chưa thanh toán', CAST(N'2020-10-12T17:34:28.000' AS DateTime), CAST(N'2020-10-12T17:34:28.000' AS DateTime))
INSERT [dbo].[InvoiceStatus] ([Id], [Name], [CreatedDate], [ModifiedDate]) VALUES (N'd2eb43bf-f6f0-4fa1-af9b-97fce37977c6', N'Đã thanh toán', CAST(N'2020-10-12T17:34:28.000' AS DateTime), CAST(N'2020-10-12T17:34:28.000' AS DateTime))
INSERT [dbo].[InvoiceStatus] ([Id], [Name], [CreatedDate], [ModifiedDate]) VALUES (N'533a62d0-f24e-4a36-b8dd-ffe893c8d397', N'Đã hủy', CAST(N'2020-10-12T17:34:28.000' AS DateTime), CAST(N'2020-10-12T17:34:28.000' AS DateTime))
GO
INSERT [dbo].[Product] ([Id], [Name], [Brand], [UnitPrice], [ProductType], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'8ddd9d9f-69fa-4650-baad-04421f8bb329', N'Xe test', N'7bfd18fc-9d00-49f3-b418-2bb156660fbd', 1000, N'ae48c81c-d53b-4231-9dab-49fab8c5026a', NULL, CAST(N'2020-11-28T05:39:23.060' AS DateTime), 0)
INSERT [dbo].[Product] ([Id], [Name], [Brand], [UnitPrice], [ProductType], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'0230f7ec-1bb8-4b00-939e-0a41321315f1', N'Texst nè ', N'7bfd18fc-9d00-49f3-b418-2bb156660fbd', 1, N'ae48c81c-d53b-4231-9dab-49fab8c5026a', NULL, CAST(N'2020-11-27T21:02:20.427' AS DateTime), NULL)
INSERT [dbo].[Product] ([Id], [Name], [Brand], [UnitPrice], [ProductType], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'a13faf64-7423-4065-a5c7-0e816580a00b', N'Xe đạp Martin 1', N'16e2b4b5-fead-4acf-b079-4ea9869bdea3', 154000099, N'2c737a65-0e99-4afb-8364-e83588554b0c', CAST(N'2020-10-14T14:58:42.307' AS DateTime), CAST(N'2020-10-14T14:58:42.307' AS DateTime), 0)
INSERT [dbo].[Product] ([Id], [Name], [Brand], [UnitPrice], [ProductType], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'a186851f-5528-43c8-a8d9-14262d06d452', N'Xe pro vip', N'16e2b4b5-fead-4acf-b079-4ea9869bdea3', 111, N'ae48c81c-d53b-4231-9dab-49fab8c5026a', CAST(N'2020-11-04T08:32:28.600' AS DateTime), CAST(N'2020-11-04T08:32:28.600' AS DateTime), 1)
INSERT [dbo].[Product] ([Id], [Name], [Brand], [UnitPrice], [ProductType], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'800d56fa-ad0c-468b-93ef-15eecc0bf666', N'Xe máy điện Vinfast 2', N'7dc4d627-8797-47aa-a525-cf346353bf8f', 30000000, N'ae48c81c-d53b-4231-9dab-49fab8c5026a', CAST(N'2020-10-12T15:07:42.000' AS DateTime), CAST(N'2020-10-12T15:07:42.000' AS DateTime), 0)
INSERT [dbo].[Product] ([Id], [Name], [Brand], [UnitPrice], [ProductType], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'ab8d8591-3f67-49e1-8e07-17d068f65ddd', N'Lê Quốc Thắng - AB8D', N'7bfd18fc-9d00-49f3-b418-2bb156660fbd', 2000, N'ae48c81c-d53b-4231-9dab-49fab8c5026a', CAST(N'2020-11-28T12:45:57.610' AS DateTime), CAST(N'2020-11-28T12:45:57.613' AS DateTime), 1)
INSERT [dbo].[Product] ([Id], [Name], [Brand], [UnitPrice], [ProductType], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'4f893e4b-478e-4cca-ab07-197a8368bcee', N'Xe máy điện Honda 2', N'dbba6830-2fb4-4467-be27-8ad115b89ab9', 1000, N'ae48c81c-d53b-4231-9dab-49fab8c5026a', NULL, CAST(N'2020-11-28T05:43:01.927' AS DateTime), 0)
INSERT [dbo].[Product] ([Id], [Name], [Brand], [UnitPrice], [ProductType], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'543c48fb-5a3e-4cff-95b9-1aca94568583', N'Xe đạp Martin 1111111111111', N'16e2b4b5-fead-4acf-b079-4ea9869bdea3', 15400009, N'2c737a65-0e99-4afb-8364-e83588554b0c', CAST(N'2020-10-14T14:59:42.753' AS DateTime), CAST(N'2020-10-14T14:59:42.753' AS DateTime), 0)
INSERT [dbo].[Product] ([Id], [Name], [Brand], [UnitPrice], [ProductType], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'f1299419-57f9-4184-a266-1b7996342128', NULL, N'7bfd18fc-9d00-49f3-b418-2bb156660fbd', NULL, N'ae48c81c-d53b-4231-9dab-49fab8c5026a', CAST(N'2020-11-28T02:27:07.623' AS DateTime), CAST(N'2020-11-28T02:27:07.623' AS DateTime), 0)
INSERT [dbo].[Product] ([Id], [Name], [Brand], [UnitPrice], [ProductType], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'629171fa-ed97-4362-8d78-1ca1ef5baf9a', N'Xe máy Thaco 1', N'7bfd18fc-9d00-49f3-b418-2bb156660fbd', 20000000, N'6d5fbd67-7690-4be8-b0d8-94c7bffbf3cb', CAST(N'2020-10-12T15:07:42.000' AS DateTime), CAST(N'2020-10-12T15:07:42.000' AS DateTime), 0)
INSERT [dbo].[Product] ([Id], [Name], [Brand], [UnitPrice], [ProductType], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'33aef940-a165-4e56-a6b0-1d5a9178e70e', N'a - 33AE', N'7bfd18fc-9d00-49f3-b418-2bb156660fbd', 1000, N'ae48c81c-d53b-4231-9dab-49fab8c5026a', CAST(N'2020-12-17T04:39:14.540' AS DateTime), CAST(N'2020-12-17T04:39:14.540' AS DateTime), 0)
INSERT [dbo].[Product] ([Id], [Name], [Brand], [UnitPrice], [ProductType], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'a38d5ed4-d5c3-4874-8909-23243b70e662', N'Xe máy điện Honda 4', N'dbba6830-2fb4-4467-be27-8ad115b89ab9', 6000000, N'ae48c81c-d53b-4231-9dab-49fab8c5026a', CAST(N'2020-10-12T15:07:42.000' AS DateTime), CAST(N'2020-10-12T15:07:42.000' AS DateTime), 1)
INSERT [dbo].[Product] ([Id], [Name], [Brand], [UnitPrice], [ProductType], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'984a6da0-2d35-4876-82d6-27a202935315', N'Xe đạp Martin 2', N'e32356ca-d0ac-42f5-a8df-96df5f538d67', 2000000, N'2c737a65-0e99-4afb-8364-e83588554b0c', CAST(N'2020-10-12T15:07:42.000' AS DateTime), CAST(N'2020-10-12T15:07:42.000' AS DateTime), 1)
INSERT [dbo].[Product] ([Id], [Name], [Brand], [UnitPrice], [ProductType], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'd1db5c35-e646-4034-9b31-29336ff45255', N'Xe máy Thaco 3', N'7bfd18fc-9d00-49f3-b418-2bb156660fbd', 40000000, N'6d5fbd67-7690-4be8-b0d8-94c7bffbf3cb', CAST(N'2020-10-12T15:07:42.000' AS DateTime), CAST(N'2020-10-12T15:07:42.000' AS DateTime), 1)
INSERT [dbo].[Product] ([Id], [Name], [Brand], [UnitPrice], [ProductType], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'f2542f5b-70ae-41a1-bf74-2ce8088422e4', N'Xe đạp Martin 1', N'e32356ca-d0ac-42f5-a8df-96df5f538d67', 121212, N'ae48c81c-d53b-4231-9dab-49fab8c5026a', CAST(N'2020-11-28T04:12:42.177' AS DateTime), CAST(N'2020-11-28T04:12:42.177' AS DateTime), 0)
INSERT [dbo].[Product] ([Id], [Name], [Brand], [UnitPrice], [ProductType], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'020805c1-8c25-4b8e-9c91-2ef46821076f', N'Xe đạp Martin 1', N'16e2b4b5-fead-4acf-b079-4ea9869bdea3', 11000, N'2c737a65-0e99-4afb-8364-e83588554b0c', NULL, CAST(N'2020-11-25T22:26:04.073' AS DateTime), 0)
INSERT [dbo].[Product] ([Id], [Name], [Brand], [UnitPrice], [ProductType], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'531e6996-8682-471b-b33c-33f1fb7d747e', N'Xe đạp Martin 111', N'16e2b4b5-fead-4acf-b079-4ea9869bdea3', 1540000, N'2c737a65-0e99-4afb-8364-e83588554b0c', CAST(N'2020-10-14T14:57:55.367' AS DateTime), CAST(N'2020-10-14T14:57:55.367' AS DateTime), 0)
INSERT [dbo].[Product] ([Id], [Name], [Brand], [UnitPrice], [ProductType], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'c17d982e-f82f-4a9d-8654-34b2193ba9c5', N'Xe máy điện Vinfast 3', N'7dc4d627-8797-47aa-a525-cf346353bf8f', 11200000, N'ae48c81c-d53b-4231-9dab-49fab8c5026a', CAST(N'2020-10-12T15:07:42.000' AS DateTime), CAST(N'2020-10-12T15:07:42.000' AS DateTime), 1)
INSERT [dbo].[Product] ([Id], [Name], [Brand], [UnitPrice], [ProductType], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'6250d2dc-a0cb-4c65-b3f5-3af854574264', N'Tuấn Anh - 6250', N'dbba6830-2fb4-4467-be27-8ad115b89ab9', 1000000, N'6d5fbd67-7690-4be8-b0d8-94c7bffbf3cb', CAST(N'2020-12-08T05:08:16.020' AS DateTime), CAST(N'2020-12-08T05:08:16.020' AS DateTime), 1)
INSERT [dbo].[Product] ([Id], [Name], [Brand], [UnitPrice], [ProductType], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'70bfaf82-ec16-4c90-87c5-3d14184db43f', N'Xe đạp Martin 1111111111111', N'16e2b4b5-fead-4acf-b079-4ea9869bdea3', 1540000, N'2c737a65-0e99-4afb-8364-e83588554b0c', CAST(N'2020-10-14T14:59:01.680' AS DateTime), CAST(N'2020-10-14T14:59:01.680' AS DateTime), 0)
INSERT [dbo].[Product] ([Id], [Name], [Brand], [UnitPrice], [ProductType], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'c688a05c-f666-48e9-b66c-411cfec53e42', N'Xe máy điện Honda 1', N'dbba6830-2fb4-4467-be27-8ad115b89ab9', 21120000, N'ae48c81c-d53b-4231-9dab-49fab8c5026a', CAST(N'2020-10-12T15:07:42.000' AS DateTime), CAST(N'2020-10-12T15:07:42.000' AS DateTime), 0)
INSERT [dbo].[Product] ([Id], [Name], [Brand], [UnitPrice], [ProductType], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'3a1ae9a6-0f4e-4586-8fe9-4427814ff700', N'Xe máy Thaco 2', N'7bfd18fc-9d00-49f3-b418-2bb156660fbd', 30003300, N'6d5fbd67-7690-4be8-b0d8-94c7bffbf3cb', NULL, CAST(N'2020-10-31T12:44:17.597' AS DateTime), 0)
INSERT [dbo].[Product] ([Id], [Name], [Brand], [UnitPrice], [ProductType], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'1144ee88-b6d2-4c2b-8ad0-532b9fc63f01', NULL, N'7bfd18fc-9d00-49f3-b418-2bb156660fbd', NULL, N'ae48c81c-d53b-4231-9dab-49fab8c5026a', CAST(N'2020-11-28T01:47:41.063' AS DateTime), CAST(N'2020-11-28T01:47:41.063' AS DateTime), 0)
INSERT [dbo].[Product] ([Id], [Name], [Brand], [UnitPrice], [ProductType], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'fe6aedd1-62cd-4662-aa86-5c71f11eb588', N'Xe máy điện Honda 4', N'dbba6830-2fb4-4467-be27-8ad115b89ab9', 6012000, N'ae48c81c-d53b-4231-9dab-49fab8c5026a', CAST(N'2020-10-12T15:07:42.000' AS DateTime), CAST(N'2020-10-12T15:07:42.000' AS DateTime), 0)
INSERT [dbo].[Product] ([Id], [Name], [Brand], [UnitPrice], [ProductType], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'7d7ded54-9f8f-40e9-9b7e-64fd196a8914', N'Xe đạp Martin 111', N'16e2b4b5-fead-4acf-b079-4ea9869bdea3', 1540004, N'2c737a65-0e99-4afb-8364-e83588554b0c', CAST(N'2020-10-14T14:58:04.250' AS DateTime), CAST(N'2020-10-14T14:58:04.250' AS DateTime), 1)
INSERT [dbo].[Product] ([Id], [Name], [Brand], [UnitPrice], [ProductType], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'3588edcf-2e38-4c7c-8b45-65bbb982679b', N'Xe máy điện Honda 2', N'dbba6830-2fb4-4467-be27-8ad115b89ab9', 223344, N'ae48c81c-d53b-4231-9dab-49fab8c5026a', NULL, CAST(N'2020-11-04T06:58:26.567' AS DateTime), 0)
INSERT [dbo].[Product] ([Id], [Name], [Brand], [UnitPrice], [ProductType], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'daf47783-fb59-4ff2-9a11-696b9af550ea', N'Xe máy điện Vinfast 1', N'7dc4d627-8797-47aa-a525-cf346353bf8f', 20000000, N'ae48c81c-d53b-4231-9dab-49fab8c5026a', CAST(N'2020-10-12T15:07:42.000' AS DateTime), CAST(N'2020-10-12T15:07:42.000' AS DateTime), 1)
INSERT [dbo].[Product] ([Id], [Name], [Brand], [UnitPrice], [ProductType], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'3f265495-31bb-4af1-8b9e-6d06201ac9b9', N'b - 3F26', N'7bfd18fc-9d00-49f3-b418-2bb156660fbd', 500000000, N'ae48c81c-d53b-4231-9dab-49fab8c5026a', CAST(N'2020-12-17T04:40:05.303' AS DateTime), CAST(N'2020-12-17T04:40:05.303' AS DateTime), 1)
INSERT [dbo].[Product] ([Id], [Name], [Brand], [UnitPrice], [ProductType], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'59c18238-849a-4bab-a2bf-6e87e9f1c46d', N'The quick brown fox jumps over the lazy dog - 59C1', N'7bfd18fc-9d00-49f3-b418-2bb156660fbd', 1000, N'ae48c81c-d53b-4231-9dab-49fab8c5026a', CAST(N'2020-12-17T05:06:41.417' AS DateTime), CAST(N'2020-12-17T05:06:41.417' AS DateTime), 1)
INSERT [dbo].[Product] ([Id], [Name], [Brand], [UnitPrice], [ProductType], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'a812436d-8c22-451c-94ae-737b136c56ac', N'Lê Quốc Thắng - A812', N'7bfd18fc-9d00-49f3-b418-2bb156660fbd', 500000000, N'ae48c81c-d53b-4231-9dab-49fab8c5026a', NULL, CAST(N'2020-12-16T10:53:50.093' AS DateTime), 1)
INSERT [dbo].[Product] ([Id], [Name], [Brand], [UnitPrice], [ProductType], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'5a49fb3a-7ada-41e1-8738-74b058ba81cb', N'Xe máy điện Vinfast 22', N'7bfd18fc-9d00-49f3-b418-2bb156660fbd', 7575555, N'ae48c81c-d53b-4231-9dab-49fab8c5026a', CAST(N'2020-10-21T09:15:22.057' AS DateTime), CAST(N'2020-10-21T09:15:22.057' AS DateTime), 0)
INSERT [dbo].[Product] ([Id], [Name], [Brand], [UnitPrice], [ProductType], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'fea7a2d1-420f-4414-a651-7895c866526e', N'Xe máy Thaco 3', N'7bfd18fc-9d00-49f3-b418-2bb156660fbd', 40220000, N'6d5fbd67-7690-4be8-b0d8-94c7bffbf3cb', CAST(N'2020-10-12T15:07:42.000' AS DateTime), CAST(N'2020-10-12T15:07:42.000' AS DateTime), 0)
INSERT [dbo].[Product] ([Id], [Name], [Brand], [UnitPrice], [ProductType], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'f9881363-b54f-43cb-8ca9-7e385c19e123', N'Xe máy điện Vinfast 2', N'7dc4d627-8797-47aa-a525-cf346353bf8f', 22000000, N'ae48c81c-d53b-4231-9dab-49fab8c5026a', NULL, CAST(N'2020-12-08T17:59:32.833' AS DateTime), 1)
INSERT [dbo].[Product] ([Id], [Name], [Brand], [UnitPrice], [ProductType], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'e1841bcf-ba76-4694-849d-8084a0ebe8da', N'Xe đạp Martin 111', N'e32356ca-d0ac-42f5-a8df-96df5f538d67', 1560000, N'2c737a65-0e99-4afb-8364-e83588554b0c', NULL, CAST(N'2020-12-08T17:58:48.510' AS DateTime), 1)
INSERT [dbo].[Product] ([Id], [Name], [Brand], [UnitPrice], [ProductType], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'ae006422-0bde-4302-9f4c-80e1e2ac8ea1', N'Lê Quốc Thắng', N'7bfd18fc-9d00-49f3-b418-2bb156660fbd', 120000, N'6d5fbd67-7690-4be8-b0d8-94c7bffbf3cb', CAST(N'2020-10-12T16:24:35.353' AS DateTime), CAST(N'2020-10-12T16:24:35.357' AS DateTime), 1)
INSERT [dbo].[Product] ([Id], [Name], [Brand], [UnitPrice], [ProductType], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'724adda0-3749-4efc-b213-843c5b3065f8', N'Xe đạp Martin 1', N'e32356ca-d0ac-42f5-a8df-96df5f538d67', 1540000, N'2c737a65-0e99-4afb-8364-e83588554b0c', CAST(N'2020-10-14T14:39:16.990' AS DateTime), CAST(N'2020-10-14T14:39:16.990' AS DateTime), 0)
INSERT [dbo].[Product] ([Id], [Name], [Brand], [UnitPrice], [ProductType], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'51e8da53-3ec7-4a1a-996d-85ede9471650', N'Xe đạp Martin 1', N'e32356ca-d0ac-42f5-a8df-96df5f538d67', 1540001, N'2c737a65-0e99-4afb-8364-e83588554b0c', CAST(N'2020-10-14T14:39:33.447' AS DateTime), CAST(N'2020-10-14T14:39:33.447' AS DateTime), 0)
INSERT [dbo].[Product] ([Id], [Name], [Brand], [UnitPrice], [ProductType], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'c9602404-8d0f-4eb0-99b7-89a989550471', N'Xe Lăn', N'7bfd18fc-9d00-49f3-b418-2bb156660fbd', 666666, N'ae48c81c-d53b-4231-9dab-49fab8c5026a', CAST(N'2020-10-31T12:42:37.577' AS DateTime), CAST(N'2020-10-31T12:42:37.577' AS DateTime), 1)
INSERT [dbo].[Product] ([Id], [Name], [Brand], [UnitPrice], [ProductType], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'94d25ebd-2d9e-441f-8622-8ef95d2b8b1b', N'Xe máy điện Honda 1', N'dbba6830-2fb4-4467-be27-8ad115b89ab9', 2000000, N'ae48c81c-d53b-4231-9dab-49fab8c5026a', CAST(N'2020-10-12T15:07:42.000' AS DateTime), CAST(N'2020-10-12T15:07:42.000' AS DateTime), 1)
INSERT [dbo].[Product] ([Id], [Name], [Brand], [UnitPrice], [ProductType], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'6a629cc9-ceef-4d27-9042-a540cd754871', N'Xe máy Thaco 1', N'7bfd18fc-9d00-49f3-b418-2bb156660fbd', 20034000, N'6d5fbd67-7690-4be8-b0d8-94c7bffbf3cb', CAST(N'2020-10-12T15:07:42.000' AS DateTime), CAST(N'2020-10-12T15:07:42.000' AS DateTime), 0)
INSERT [dbo].[Product] ([Id], [Name], [Brand], [UnitPrice], [ProductType], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'c6fb8f6d-e364-4b5a-b18c-ac746d3c93d2', N'Xe đạp Martin 1', N'16e2b4b5-fead-4acf-b079-4ea9869bdea3', 15400009, N'2c737a65-0e99-4afb-8364-e83588554b0c', CAST(N'2020-10-14T14:57:47.423' AS DateTime), CAST(N'2020-10-14T14:57:47.423' AS DateTime), 0)
INSERT [dbo].[Product] ([Id], [Name], [Brand], [UnitPrice], [ProductType], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'd7f3b2e1-3cf9-456c-88d8-afc4308a0796', N'Xe đạp Martin 2', N'e32356ca-d0ac-42f5-a8df-96df5f538d67', 21230000, N'2c737a65-0e99-4afb-8364-e83588554b0c', CAST(N'2020-10-12T15:07:42.000' AS DateTime), CAST(N'2020-10-12T15:07:42.000' AS DateTime), 0)
INSERT [dbo].[Product] ([Id], [Name], [Brand], [UnitPrice], [ProductType], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'6a9ef2cc-dc00-403a-acea-b218336ddc82', N'Xe đạp Martin 3', N'e32356ca-d0ac-42f5-a8df-96df5f538d67', 500000000, N'2c737a65-0e99-4afb-8364-e83588554b0c', NULL, CAST(N'2020-12-17T02:57:20.763' AS DateTime), 1)
INSERT [dbo].[Product] ([Id], [Name], [Brand], [UnitPrice], [ProductType], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'0ece7e7d-755a-4ba2-902f-b486d9cc4c60', N'Xe đạp Martin 1', N'e32356ca-d0ac-42f5-a8df-96df5f538d67', 1500000, N'2c737a65-0e99-4afb-8364-e83588554b0c', CAST(N'2020-10-12T15:07:42.000' AS DateTime), CAST(N'2020-10-12T15:07:42.000' AS DateTime), 0)
INSERT [dbo].[Product] ([Id], [Name], [Brand], [UnitPrice], [ProductType], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'bbffc85b-aabb-4f2f-b398-b4b9cfc271ae', N'Xe đạp Martin 1', N'e32356ca-d0ac-42f5-a8df-96df5f538d67', 1112222, N'ae48c81c-d53b-4231-9dab-49fab8c5026a', CAST(N'2020-11-28T04:13:19.250' AS DateTime), CAST(N'2020-11-28T04:13:19.250' AS DateTime), 0)
INSERT [dbo].[Product] ([Id], [Name], [Brand], [UnitPrice], [ProductType], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'ea3a5a25-8acd-43cc-9325-ba265aee4144', N'Xe máy điện Vinfast 2', N'7dc4d627-8797-47aa-a525-cf346353bf8f', 32100000, N'ae48c81c-d53b-4231-9dab-49fab8c5026a', CAST(N'2020-10-12T15:07:42.000' AS DateTime), CAST(N'2020-10-12T15:07:42.000' AS DateTime), 0)
INSERT [dbo].[Product] ([Id], [Name], [Brand], [UnitPrice], [ProductType], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'a6f563cd-d2fa-4400-932f-bab49c73a19b', N'Xe máy điện Honda 3', N'dbba6830-2fb4-4467-be27-8ad115b89ab9', 50234000, N'ae48c81c-d53b-4231-9dab-49fab8c5026a', CAST(N'2020-10-12T15:07:42.000' AS DateTime), CAST(N'2020-10-12T15:07:42.000' AS DateTime), 0)
INSERT [dbo].[Product] ([Id], [Name], [Brand], [UnitPrice], [ProductType], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'59be7ded-4536-482d-a16c-bbb6c19a3860', N'quyên - 59BE', N'dbba6830-2fb4-4467-be27-8ad115b89ab9', 1000, N'c0b55282-7926-412c-b3dd-ce3f25095337', NULL, CAST(N'2020-12-18T01:57:39.200' AS DateTime), 0)
INSERT [dbo].[Product] ([Id], [Name], [Brand], [UnitPrice], [ProductType], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'6de0a816-dab2-429a-b6f6-c369b47ddda6', N'Xe đạp Martin 1111111111111', N'7bfd18fc-9d00-49f3-b418-2bb156660fbd', 1540000, N'2c737a65-0e99-4afb-8364-e83588554b0c', CAST(N'2020-10-14T14:59:56.057' AS DateTime), CAST(N'2020-10-14T14:59:56.057' AS DateTime), 0)
INSERT [dbo].[Product] ([Id], [Name], [Brand], [UnitPrice], [ProductType], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'b2d756b5-55dc-4aac-a9d7-c9b2623fe389', N'Xe máy điện Honda 3', N'dbba6830-2fb4-4467-be27-8ad115b89ab9', 48000000, N'ae48c81c-d53b-4231-9dab-49fab8c5026a', NULL, CAST(N'2020-12-08T17:59:18.923' AS DateTime), 1)
INSERT [dbo].[Product] ([Id], [Name], [Brand], [UnitPrice], [ProductType], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'6257b834-e632-4d47-890b-d66d41645122', N'Lê Quốc Thắng - 6257', N'7bfd18fc-9d00-49f3-b418-2bb156660fbd', 1000, N'6d5fbd67-7690-4be8-b0d8-94c7bffbf3cb', CAST(N'2020-11-28T06:03:00.143' AS DateTime), CAST(N'2020-11-28T06:03:00.143' AS DateTime), 0)
INSERT [dbo].[Product] ([Id], [Name], [Brand], [UnitPrice], [ProductType], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'62dc7a56-0073-4202-844f-d7e9f3b8aa60', N'Xe đạp Martin 3', N'e32356ca-d0ac-42f5-a8df-96df5f538d67', 40232000, N'2c737a65-0e99-4afb-8364-e83588554b0c', CAST(N'2020-10-12T15:07:42.000' AS DateTime), CAST(N'2020-10-12T15:07:42.000' AS DateTime), 0)
INSERT [dbo].[Product] ([Id], [Name], [Brand], [UnitPrice], [ProductType], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'a3af6a8b-a76c-42c1-8c42-d9a9c763553d', N'xe lăn pro vip', N'7dc4d627-8797-47aa-a525-cf346353bf8f', -2, N'ae48c81c-d53b-4231-9dab-49fab8c5026a', NULL, CAST(N'2020-11-27T21:02:43.587' AS DateTime), NULL)
INSERT [dbo].[Product] ([Id], [Name], [Brand], [UnitPrice], [ProductType], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'3efe7f54-3924-4ab4-994a-dd2105d93fa3', N'm - 3EFE', N'7bfd18fc-9d00-49f3-b418-2bb156660fbd', 1000, N'ae48c81c-d53b-4231-9dab-49fab8c5026a', CAST(N'2020-11-28T04:45:17.283' AS DateTime), CAST(N'2020-11-28T04:45:17.283' AS DateTime), 0)
INSERT [dbo].[Product] ([Id], [Name], [Brand], [UnitPrice], [ProductType], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'a4b5cb99-692c-47dc-b608-e5f307f6fb11', N'The quick brown fox jumps over the lazy dog - A4B5', N'7bfd18fc-9d00-49f3-b418-2bb156660fbd', 1000, N'ae48c81c-d53b-4231-9dab-49fab8c5026a', CAST(N'2020-12-17T05:08:56.720' AS DateTime), CAST(N'2020-12-17T05:08:56.720' AS DateTime), 1)
INSERT [dbo].[Product] ([Id], [Name], [Brand], [UnitPrice], [ProductType], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'dad8a6b5-b3fa-49a4-8b2f-e8473395c506', N'@#@#@# - DAD8', N'7bfd18fc-9d00-49f3-b418-2bb156660fbd', 1000, N'ae48c81c-d53b-4231-9dab-49fab8c5026a', CAST(N'2020-12-17T05:27:45.323' AS DateTime), CAST(N'2020-12-17T05:27:45.323' AS DateTime), 1)
INSERT [dbo].[Product] ([Id], [Name], [Brand], [UnitPrice], [ProductType], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'07610658-cb32-479d-b022-e9beca7a0b03', N'Xe đạp Martin 1', N'e32356ca-d0ac-42f5-a8df-96df5f538d67', 1550000, N'2c737a65-0e99-4afb-8364-e83588554b0c', NULL, CAST(N'2020-11-28T04:31:44.157' AS DateTime), 0)
INSERT [dbo].[Product] ([Id], [Name], [Brand], [UnitPrice], [ProductType], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'3878e692-264d-47fc-af1a-f050aa8f897c', N'Xe máy điện Honda 2', N'dbba6830-2fb4-4467-be27-8ad115b89ab9', 200001, N'ae48c81c-d53b-4231-9dab-49fab8c5026a', NULL, CAST(N'2020-10-31T10:24:04.753' AS DateTime), 0)
INSERT [dbo].[Product] ([Id], [Name], [Brand], [UnitPrice], [ProductType], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'83b787d3-badb-474f-bfd0-f1dd3ca33e6b', N'Xe máy Thaco 2', N'7bfd18fc-9d00-49f3-b418-2bb156660fbd', 30000000, N'6d5fbd67-7690-4be8-b0d8-94c7bffbf3cb', CAST(N'2020-10-12T15:07:42.000' AS DateTime), CAST(N'2020-10-12T15:07:42.000' AS DateTime), 1)
INSERT [dbo].[Product] ([Id], [Name], [Brand], [UnitPrice], [ProductType], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'48dcd904-6183-4178-9bfc-f2a596c1c4f1', N'Xe máy điện Vinfast 3', N'7dc4d627-8797-47aa-a525-cf346353bf8f', 15000000, N'ae48c81c-d53b-4231-9dab-49fab8c5026a', CAST(N'2020-10-12T15:07:42.000' AS DateTime), CAST(N'2020-10-12T15:07:42.000' AS DateTime), 0)
INSERT [dbo].[Product] ([Id], [Name], [Brand], [UnitPrice], [ProductType], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'fabc41d6-74e9-4f69-8496-f537fdbd22b6', N'Xe đạp Martin 1', N'16e2b4b5-fead-4acf-b079-4ea9869bdea3', 1540000, N'6d5fbd67-7690-4be8-b0d8-94c7bffbf3cb', CAST(N'2020-10-14T14:40:34.167' AS DateTime), CAST(N'2020-10-14T14:40:34.167' AS DateTime), 0)
INSERT [dbo].[Product] ([Id], [Name], [Brand], [UnitPrice], [ProductType], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'0eca4f82-c5ca-42b3-b3e0-fa29c8db06ab', N'123 - 0ECA', N'7bfd18fc-9d00-49f3-b418-2bb156660fbd', -100, N'ae48c81c-d53b-4231-9dab-49fab8c5026a', NULL, CAST(N'2020-11-28T04:43:48.857' AS DateTime), 0)
INSERT [dbo].[Product] ([Id], [Name], [Brand], [UnitPrice], [ProductType], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'f91a8fc0-ac5d-4291-a125-fc5a3f280f99', N'Xe máy điện Vinfast 1', N'7dc4d627-8797-47aa-a525-cf346353bf8f', 45000000, N'ae48c81c-d53b-4231-9dab-49fab8c5026a', CAST(N'2020-10-12T15:07:42.000' AS DateTime), CAST(N'2020-10-12T15:07:42.000' AS DateTime), 0)
INSERT [dbo].[Product] ([Id], [Name], [Brand], [UnitPrice], [ProductType], [CreatedDate], [ModifiedDate], [IsActive]) VALUES (N'f87f44e4-dc4d-4921-bea2-ff809f848991', N'quyên - F87F', N'7bfd18fc-9d00-49f3-b418-2bb156660fbd', 54545, N'ae48c81c-d53b-4231-9dab-49fab8c5026a', CAST(N'2020-12-19T14:57:32.553' AS DateTime), CAST(N'2020-12-19T14:57:32.553' AS DateTime), 1)
GO
INSERT [dbo].[ProductType] ([Id], [ProductTypeName], [CreatedDate], [ModifiedDate]) VALUES (N'ae48c81c-d53b-4231-9dab-49fab8c5026a', N'Xe máy điện', CAST(N'2020-10-12T14:13:36.000' AS DateTime), CAST(N'2020-10-12T14:13:36.000' AS DateTime))
INSERT [dbo].[ProductType] ([Id], [ProductTypeName], [CreatedDate], [ModifiedDate]) VALUES (N'6d5fbd67-7690-4be8-b0d8-94c7bffbf3cb', N'Xe máy', CAST(N'2020-10-12T14:13:36.000' AS DateTime), CAST(N'2020-10-12T14:13:36.000' AS DateTime))
INSERT [dbo].[ProductType] ([Id], [ProductTypeName], [CreatedDate], [ModifiedDate]) VALUES (N'c0b55282-7926-412c-b3dd-ce3f25095337', N'Xe đạp điện', CAST(N'2020-10-12T14:13:36.000' AS DateTime), CAST(N'2020-10-12T14:13:36.000' AS DateTime))
INSERT [dbo].[ProductType] ([Id], [ProductTypeName], [CreatedDate], [ModifiedDate]) VALUES (N'2c737a65-0e99-4afb-8364-e83588554b0c', N'Xe đạp', CAST(N'2020-10-12T14:13:36.000' AS DateTime), CAST(N'2020-10-12T14:13:36.000' AS DateTime))
GO
INSERT [dbo].[Receipt] ([Id], [CustomerId], [ReceivedAmount], [Description], [CreatedDate], [ModifiedDate], [InvoiceId]) VALUES (N'd6b35ef1-13c3-4b96-abb8-4b56cebcdff9', N'bc6bb680-4438-436a-8f70-f8b4789b2b04', 23000000, N'Trả hết', CAST(N'2020-11-28T05:55:11.970' AS DateTime), CAST(N'2020-11-28T05:55:11.970' AS DateTime), N'85d57f9b-e6c7-49a4-a056-905ef0a4f9b4')
INSERT [dbo].[Receipt] ([Id], [CustomerId], [ReceivedAmount], [Description], [CreatedDate], [ModifiedDate], [InvoiceId]) VALUES (N'b176e2c5-5387-4dfe-960c-6e787b552eae', N'bc6bb680-4438-436a-8f70-f8b4789b2b04', 1000000, N'Trả phần còn lại', CAST(N'2020-11-28T05:55:47.360' AS DateTime), CAST(N'2020-11-28T05:55:47.360' AS DateTime), N'85d57f9b-e6c7-49a4-a056-905ef0a4f9b4')
INSERT [dbo].[Receipt] ([Id], [CustomerId], [ReceivedAmount], [Description], [CreatedDate], [ModifiedDate], [InvoiceId]) VALUES (N'3a9bac28-20af-4908-9ec5-6ea14b8d627c', N'128c1027-936e-47c5-9421-6fcd3cffe748', 200, N'Trả 1 phần', CAST(N'2020-11-28T03:44:36.810' AS DateTime), CAST(N'2020-11-28T03:44:36.810' AS DateTime), N'5a2d0006-f3f5-46bb-b732-9e79f48f8488')
INSERT [dbo].[Receipt] ([Id], [CustomerId], [ReceivedAmount], [Description], [CreatedDate], [ModifiedDate], [InvoiceId]) VALUES (N'f60e61ce-851c-4f5a-9197-8173ab12e77e', N'da4fe8d2-56a0-4049-9dd0-2520f0379ad7', 600, N'tra no', CAST(N'2020-11-28T12:41:58.017' AS DateTime), CAST(N'2020-11-28T12:41:58.017' AS DateTime), N'cf81b3df-5ac0-4635-9998-3dba1deab72e')
INSERT [dbo].[Receipt] ([Id], [CustomerId], [ReceivedAmount], [Description], [CreatedDate], [ModifiedDate], [InvoiceId]) VALUES (N'fef3a539-afac-4240-afea-855688810aa0', N'd6480197-15ed-405b-b368-e24fbf349639', 1500, N'Trả tiền', CAST(N'2020-11-28T08:46:13.010' AS DateTime), CAST(N'2020-11-28T08:46:13.010' AS DateTime), N'6192f5a2-4499-46aa-bec6-70484de53a44')
INSERT [dbo].[Receipt] ([Id], [CustomerId], [ReceivedAmount], [Description], [CreatedDate], [ModifiedDate], [InvoiceId]) VALUES (N'd635125b-a3e0-4756-9995-968e5d504248', N'da4fe8d2-56a0-4049-9dd0-2520f0379ad7', 600, N'tra tien', CAST(N'2020-11-28T12:39:24.340' AS DateTime), CAST(N'2020-11-28T12:39:24.340' AS DateTime), N'cf81b3df-5ac0-4635-9998-3dba1deab72e')
INSERT [dbo].[Receipt] ([Id], [CustomerId], [ReceivedAmount], [Description], [CreatedDate], [ModifiedDate], [InvoiceId]) VALUES (N'99fce565-c024-4611-8632-d0bc1cf33c10', N'128c1027-936e-47c5-9421-6fcd3cffe748', 1, N'fsd', CAST(N'2020-11-29T17:33:51.490' AS DateTime), CAST(N'2020-11-29T17:33:51.490' AS DateTime), N'5a2d0006-f3f5-46bb-b732-9e79f48f8488')
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[Invoice]  WITH CHECK ADD  CONSTRAINT [FK_Invoice_Customer] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([Id])
GO
ALTER TABLE [dbo].[Invoice] CHECK CONSTRAINT [FK_Invoice_Customer]
GO
ALTER TABLE [dbo].[Invoice]  WITH CHECK ADD  CONSTRAINT [FK_Invoice_InvoiceStatus] FOREIGN KEY([Status])
REFERENCES [dbo].[InvoiceStatus] ([Id])
GO
ALTER TABLE [dbo].[Invoice] CHECK CONSTRAINT [FK_Invoice_InvoiceStatus]
GO
ALTER TABLE [dbo].[InvoiceDetail]  WITH CHECK ADD  CONSTRAINT [FK_InvoiceDetail_Invoice] FOREIGN KEY([InvoiceId])
REFERENCES [dbo].[Invoice] ([Id])
GO
ALTER TABLE [dbo].[InvoiceDetail] CHECK CONSTRAINT [FK_InvoiceDetail_Invoice]
GO
ALTER TABLE [dbo].[InvoiceDetail]  WITH CHECK ADD  CONSTRAINT [FK_InvoiceDetail_Product] FOREIGN KEY([Product])
REFERENCES [dbo].[Product] ([Id])
GO
ALTER TABLE [dbo].[InvoiceDetail] CHECK CONSTRAINT [FK_InvoiceDetail_Product]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_Brand] FOREIGN KEY([Brand])
REFERENCES [dbo].[Brand] ([Id])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_Brand]
GO
ALTER TABLE [dbo].[Product]  WITH CHECK ADD  CONSTRAINT [FK_Product_ProductType] FOREIGN KEY([ProductType])
REFERENCES [dbo].[ProductType] ([Id])
GO
ALTER TABLE [dbo].[Product] CHECK CONSTRAINT [FK_Product_ProductType]
GO
ALTER TABLE [dbo].[Receipt]  WITH CHECK ADD  CONSTRAINT [FK_Receipt_Customer] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([Id])
GO
ALTER TABLE [dbo].[Receipt] CHECK CONSTRAINT [FK_Receipt_Customer]
GO

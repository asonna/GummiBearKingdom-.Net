USE [GummiBearKingdom]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 2/14/2017 2:51:48 PM ******/
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
/****** Object:  Table [dbo].[Products]    Script Date: 2/14/2017 2:51:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Products](
	[ProductId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
	[OriginCountry] [nvarchar](max) NULL,
	[SectionId] [int] NOT NULL,
	[cost] [int] NOT NULL,
 CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED 
(
	[ProductId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Sections]    Script Date: 2/14/2017 2:51:49 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sections](
	[SectionId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](max) NULL,
 CONSTRAINT [PK_Sections] PRIMARY KEY CLUSTERED 
(
	[SectionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20170210185605_Initial', N'1.0.0-rtm-21431')
SET IDENTITY_INSERT [dbo].[Products] ON 

INSERT [dbo].[Products] ([ProductId], [Name], [OriginCountry], [SectionId], [cost]) VALUES (1, N'German Bear', N'German', 1, 10)
INSERT [dbo].[Products] ([ProductId], [Name], [OriginCountry], [SectionId], [cost]) VALUES (2, N'African Gummi', N'Cameroon', 7, 15)
INSERT [dbo].[Products] ([ProductId], [Name], [OriginCountry], [SectionId], [cost]) VALUES (3, N'Gummy Bear', N'USA', 4, 8)
INSERT [dbo].[Products] ([ProductId], [Name], [OriginCountry], [SectionId], [cost]) VALUES (4, N'Belgium Bear King', N'Belgium', 5, 22)
SET IDENTITY_INSERT [dbo].[Products] OFF
SET IDENTITY_INSERT [dbo].[Sections] ON 

INSERT [dbo].[Sections] ([SectionId], [Name]) VALUES (1, N'German')
INSERT [dbo].[Sections] ([SectionId], [Name]) VALUES (2, N'French')
INSERT [dbo].[Sections] ([SectionId], [Name]) VALUES (3, N'Italian')
INSERT [dbo].[Sections] ([SectionId], [Name]) VALUES (4, N'American')
INSERT [dbo].[Sections] ([SectionId], [Name]) VALUES (5, N'Belgium')
INSERT [dbo].[Sections] ([SectionId], [Name]) VALUES (6, N'Asian')
INSERT [dbo].[Sections] ([SectionId], [Name]) VALUES (7, N'African')
SET IDENTITY_INSERT [dbo].[Sections] OFF
ALTER TABLE [dbo].[Products]  WITH CHECK ADD  CONSTRAINT [FK_Products_Sections_SectionId] FOREIGN KEY([SectionId])
REFERENCES [dbo].[Sections] ([SectionId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Products] CHECK CONSTRAINT [FK_Products_Sections_SectionId]
GO

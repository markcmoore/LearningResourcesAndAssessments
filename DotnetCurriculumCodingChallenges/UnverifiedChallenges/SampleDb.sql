/* Note: If database “SampleDB_EF” exists, then rename it in this script and set a new name */
USE [master]
GO
CREATE DATABASE [SampleDB_EF]
GO
USE [SampleDB_EF]
GO
/****** Object: Table [dbo].[Addresses] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Addresses](
[id] [int] IDENTITY(1,1) NOT NULL,
[addressLine1] [varchar](50) NOT NULL,
[addressLine2] [varchar](50) NULL,
[city] [varchar](100) NULL,
[countryCode] [char](3) NULL,
CONSTRAINT [PK_Address] PRIMARY KEY CLUSTERED
(
[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS =
ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object: Table [dbo].[Customers] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
[id] [int] IDENTITY(1,1) NOT NULL,
[firstName] [varchar](50) NOT NULL,
[lastName] [varchar](50) NOT NULL,
[addressID] [int] NOT NULL,
[lastOrderDate] [date] NULL,
[remarks] [varchar](250) NULL,
CONSTRAINT [PK_Customers] PRIMARY KEY CLUSTERED
(
[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS =
ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object: Table [dbo].[Orders] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
[id] [int] IDENTITY(1,1) NOT NULL,
[orderDate] [date] NOT NULL,
[totalAmount] [float] NOT NULL,
[customerID] [int] NOT NULL,
CONSTRAINT [PK_Orders] PRIMARY KEY CLUSTERED
(
[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS =
ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

/* If databse "SampleDB_EF" was renamed in the above script, please rename it */
/* in this script as well */
--Insert Sample Data
USE [SampleDB_EF]
GO
SET IDENTITY_INSERT [dbo].[Addresses] ON
GO
INSERT [dbo].[Addresses] ([id], [addressLine1], [addressLine2], [city], [countryCode]) VALUES
(1, N'address1', NULL, N'city1', N'CY ')
GO
INSERT [dbo].[Addresses] ([id], [addressLine1], [addressLine2], [city], [countryCode]) VALUES
(2, N'address2', NULL, N'city2', N'CY ')
GO
INSERT [dbo].[Addresses] ([id], [addressLine1], [addressLine2], [city], [countryCode]) VALUES
(3, N'address3', NULL, N'city3', N'CY ')
GO
SET IDENTITY_INSERT [dbo].[Addresses] OFF
GO
SET IDENTITY_INSERT [dbo].[Customers] ON
GO
INSERT [dbo].[Customers] ([id], [firstName], [lastName], [addressID], [lastOrderDate],
[remarks]) VALUES (1, N'cusFirstName1', N'cusLastName1', 1, CAST(N'2019-03-15' AS Date), NULL)
GO
INSERT [dbo].[Customers] ([id], [firstName], [lastName], [addressID], [lastOrderDate],
[remarks]) VALUES (2, N'cusFirstName2', N'cusLastName2', 2, CAST(N'2019-03-14' AS Date), NULL)
GO
INSERT [dbo].[Customers] ([id], [firstName], [lastName], [addressID], [lastOrderDate],
[remarks]) VALUES (3, N'cusFirstName3', N'cusLastName3', 3, CAST(N'2019-03-13' AS Date), NULL)
GO
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO
SET IDENTITY_INSERT [dbo].[Orders] ON
GO
INSERT [dbo].[Orders] ([id], [orderDate], [totalAmount], [customerID])
VALUES (1, CAST(N'2019-03-15' AS Date), 90.55, 1)
GO
INSERT [dbo].[Orders] ([id], [orderDate], [totalAmount], [customerID])
VALUES (3, CAST(N'2019-03-14' AS Date), 253.45, 2)
GO
INSERT [dbo].[Orders] ([id], [orderDate], [totalAmount], [customerID])
VALUES (4, CAST(N'2019-03-13' AS Date), 150, 3)
GO
SET IDENTITY_INSERT [dbo].[Orders] OFF
GO
--Set Constraints
ALTER TABLE [dbo].[Customers] WITH CHECK ADD CONSTRAINT [FK_Customers_Addresses] FOREIGN
KEY([addressID])
REFERENCES [dbo].[Addresses] ([id])
GO
ALTER TABLE [dbo].[Customers] CHECK CONSTRAINT [FK_Customers_Addresses]
GO
ALTER TABLE [dbo].[Orders] WITH CHECK ADD CONSTRAINT [FK_Orders_Customers] FOREIGN
KEY([customerID])
REFERENCES [dbo].[Customers] ([id])
GO
ALTER TABLE [dbo].[Orders] CHECK CONSTRAINT [FK_Orders_Customers]
GO
USE [master]
GO
ALTER DATABASE [SampleDB_EF] SET READ_WRITE
GO

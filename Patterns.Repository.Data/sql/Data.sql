
PRINT N'Genereating [Customer] data ...';
SET IDENTITY_INSERT [dbo].[Customer] ON
INSERT INTO [dbo].[Customer] ([Id], [Name], [Address], [TownCity], [CountyState], [PostcodeZip]) VALUES (1, N'Frodo Baggins', N'Bag End', N'The Shire', N'Eriador', N'ME1')
INSERT INTO [dbo].[Customer] ([Id], [Name], [Address], [TownCity], [CountyState], [PostcodeZip]) VALUES (2, N'Samwise Gamgee', N'Nextdoor to Bag End', N'The Shire', N'Eriador', N'ME1')
INSERT INTO [dbo].[Customer] ([Id], [Name], [Address], [TownCity], [CountyState], [PostcodeZip]) VALUES (3, N'Théoden', N'The Great Hall', N'Rohan', N'Rohan', N'ME2')
INSERT INTO [dbo].[Customer] ([Id], [Name], [Address], [TownCity], [CountyState], [PostcodeZip]) VALUES (4, N'Denethor', N'Meduseld', N'Minas Tirith', N'Gondor', N'ME3')
SET IDENTITY_INSERT [dbo].[Customer] OFF

PRINT N'Generating [StockItem] data ...'
SET IDENTITY_INSERT [dbo].[StockItem] ON
INSERT INTO [dbo].[StockItem] ([Id], [ProductCode], [Name], [NetPricePerUnit], [SalesTaxPercentage]) VALUES (1, N'B1', N'Bow', CAST(100.0000 AS Decimal(18, 4)), CAST(20.0000 AS Decimal(18, 4)))
INSERT INTO [dbo].[StockItem] ([Id], [ProductCode], [Name], [NetPricePerUnit], [SalesTaxPercentage]) VALUES (2, N'A1', N'Arrow', CAST(10.0000 AS Decimal(18, 4)), CAST(20.0000 AS Decimal(18, 4)))
INSERT INTO [dbo].[StockItem] ([Id], [ProductCode], [Name], [NetPricePerUnit], [SalesTaxPercentage]) VALUES (3, N'S1', N'Sword (Narsil)', CAST(500.0000 AS Decimal(18, 4)), CAST(20.0000 AS Decimal(18, 4)))
INSERT INTO [dbo].[StockItem] ([Id], [ProductCode], [Name], [NetPricePerUnit], [SalesTaxPercentage]) VALUES (4, N'S2', N'Sword (Anduril)', CAST(550.0000 AS Decimal(18, 4)), CAST(20.0000 AS Decimal(18, 4)))
INSERT INTO [dbo].[StockItem] ([Id], [ProductCode], [Name], [NetPricePerUnit], [SalesTaxPercentage]) VALUES (5, N'S3', N'Sword (Glamdring)', CAST(700.0000 AS Decimal(18, 4)), CAST(20.0000 AS Decimal(18, 4)))
INSERT INTO [dbo].[StockItem] ([Id], [ProductCode], [Name], [NetPricePerUnit], [SalesTaxPercentage]) VALUES (6, N'D1', N'Dagger (Sting)', CAST(250.0000 AS Decimal(18, 4)), CAST(20.0000 AS Decimal(18, 4)))
SET IDENTITY_INSERT [dbo].[StockItem] OFF

PRINT N'Generating [Invoice] data ...'
SET IDENTITY_INSERT [dbo].[Invoice] ON
INSERT INTO [dbo].[Invoice] ([Id], [CustomerID], [InvoiceDate], [TermsDays]) VALUES (1, 1, N'2010-01-01 00:00:00', 30)
INSERT INTO [dbo].[Invoice] ([Id], [CustomerID], [InvoiceDate], [TermsDays]) VALUES (2, 2, N'2013-01-02 00:00:00', 90)
INSERT INTO [dbo].[Invoice] ([Id], [CustomerID], [InvoiceDate], [TermsDays]) VALUES (3, 3, N'2010-01-01 00:00:00', 30)
INSERT INTO [dbo].[Invoice] ([Id], [CustomerID], [InvoiceDate], [TermsDays]) VALUES (4, 1, N'2010-01-01 00:00:00', 30)
INSERT INTO [dbo].[Invoice] ([Id], [CustomerID], [InvoiceDate], [TermsDays]) VALUES (5, 4, N'2012-02-02 00:00:00', 30)
SET IDENTITY_INSERT [dbo].[Invoice] OFF

PRINT N'Generating [InvoiceLine] data ...'
SET IDENTITY_INSERT [dbo].[InvoiceLine] ON
INSERT INTO [dbo].[InvoiceLine] ([Id], [InvoiceID], [StockItemID], [NumberOfUnits], [NetLinePriceAdjustment], [Ordinal]) VALUES (1, 1, 1, CAST(1.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), 1)
INSERT INTO [dbo].[InvoiceLine] ([Id], [InvoiceID], [StockItemID], [NumberOfUnits], [NetLinePriceAdjustment], [Ordinal]) VALUES (2, 1, 2, CAST(100.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), 2)
INSERT INTO [dbo].[InvoiceLine] ([Id], [InvoiceID], [StockItemID], [NumberOfUnits], [NetLinePriceAdjustment], [Ordinal]) VALUES (3, 2, 3, CAST(1.0000 AS Decimal(18, 4)), CAST(-100.0000 AS Decimal(18, 4)), 1)
INSERT INTO [dbo].[InvoiceLine] ([Id], [InvoiceID], [StockItemID], [NumberOfUnits], [NetLinePriceAdjustment], [Ordinal]) VALUES (4, 3, 4, CAST(1.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), 1)
INSERT INTO [dbo].[InvoiceLine] ([Id], [InvoiceID], [StockItemID], [NumberOfUnits], [NetLinePriceAdjustment], [Ordinal]) VALUES (5, 3, 5, CAST(1.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), 2)
INSERT INTO [dbo].[InvoiceLine] ([Id], [InvoiceID], [StockItemID], [NumberOfUnits], [NetLinePriceAdjustment], [Ordinal]) VALUES (6, 4, 1, CAST(1.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), 1)
INSERT INTO [dbo].[InvoiceLine] ([Id], [InvoiceID], [StockItemID], [NumberOfUnits], [NetLinePriceAdjustment], [Ordinal]) VALUES (7, 4, 2, CAST(250.0000 AS Decimal(18, 4)), CAST(-50.0000 AS Decimal(18, 4)), 2)
SET IDENTITY_INSERT [dbo].[InvoiceLine] OFF



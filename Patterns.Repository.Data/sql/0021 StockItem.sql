SET IDENTITY_INSERT [dbo].[StockItem] ON
INSERT INTO [dbo].[StockItem] ([Id], [ProductCode], [Name], [NetPricePerUnit], [SalesTaxPercentage]) VALUES (1, N'B1', N'Bow', CAST(100.0000 AS Decimal(18, 4)), CAST(20.0000 AS Decimal(18, 4)))
INSERT INTO [dbo].[StockItem] ([Id], [ProductCode], [Name], [NetPricePerUnit], [SalesTaxPercentage]) VALUES (2, N'A1', N'Arrow', CAST(10.0000 AS Decimal(18, 4)), CAST(20.0000 AS Decimal(18, 4)))
INSERT INTO [dbo].[StockItem] ([Id], [ProductCode], [Name], [NetPricePerUnit], [SalesTaxPercentage]) VALUES (3, N'S1', N'Sword (Narsil)', CAST(500.0000 AS Decimal(18, 4)), CAST(20.0000 AS Decimal(18, 4)))
INSERT INTO [dbo].[StockItem] ([Id], [ProductCode], [Name], [NetPricePerUnit], [SalesTaxPercentage]) VALUES (4, N'S2', N'Sword (Anduril)', CAST(550.0000 AS Decimal(18, 4)), CAST(20.0000 AS Decimal(18, 4)))
INSERT INTO [dbo].[StockItem] ([Id], [ProductCode], [Name], [NetPricePerUnit], [SalesTaxPercentage]) VALUES (5, N'S3', N'Sword (Glamdring)', CAST(700.0000 AS Decimal(18, 4)), CAST(20.0000 AS Decimal(18, 4)))
INSERT INTO [dbo].[StockItem] ([Id], [ProductCode], [Name], [NetPricePerUnit], [SalesTaxPercentage]) VALUES (6, N'D1', N'Dagger (Sting)', CAST(250.0000 AS Decimal(18, 4)), CAST(20.0000 AS Decimal(18, 4)))
SET IDENTITY_INSERT [dbo].[StockItem] OFF

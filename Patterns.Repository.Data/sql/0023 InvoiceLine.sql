SET IDENTITY_INSERT [dbo].[InvoiceLine] ON
INSERT INTO [dbo].[InvoiceLine] ([Id], [InvoiceID], [StockItemID], [NumberOfUnits], [NetLinePriceAdjustment], [Ordinal]) VALUES (1, 1, 1, CAST(1.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), 1)
INSERT INTO [dbo].[InvoiceLine] ([Id], [InvoiceID], [StockItemID], [NumberOfUnits], [NetLinePriceAdjustment], [Ordinal]) VALUES (2, 1, 2, CAST(100.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), 2)
INSERT INTO [dbo].[InvoiceLine] ([Id], [InvoiceID], [StockItemID], [NumberOfUnits], [NetLinePriceAdjustment], [Ordinal]) VALUES (3, 2, 3, CAST(1.0000 AS Decimal(18, 4)), CAST(-100.0000 AS Decimal(18, 4)), 1)
INSERT INTO [dbo].[InvoiceLine] ([Id], [InvoiceID], [StockItemID], [NumberOfUnits], [NetLinePriceAdjustment], [Ordinal]) VALUES (4, 3, 4, CAST(1.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), 1)
INSERT INTO [dbo].[InvoiceLine] ([Id], [InvoiceID], [StockItemID], [NumberOfUnits], [NetLinePriceAdjustment], [Ordinal]) VALUES (5, 3, 5, CAST(1.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), 2)
INSERT INTO [dbo].[InvoiceLine] ([Id], [InvoiceID], [StockItemID], [NumberOfUnits], [NetLinePriceAdjustment], [Ordinal]) VALUES (6, 4, 1, CAST(1.0000 AS Decimal(18, 4)), CAST(0.0000 AS Decimal(18, 4)), 1)
INSERT INTO [dbo].[InvoiceLine] ([Id], [InvoiceID], [StockItemID], [NumberOfUnits], [NetLinePriceAdjustment], [Ordinal]) VALUES (7, 4, 2, CAST(250.0000 AS Decimal(18, 4)), CAST(-50.0000 AS Decimal(18, 4)), 2)
SET IDENTITY_INSERT [dbo].[InvoiceLine] OFF

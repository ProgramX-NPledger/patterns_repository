SET IDENTITY_INSERT [dbo].[Invoice] ON
INSERT INTO [dbo].[Invoice] ([Id], [CustomerID], [InvoiceDate], [TermsDays]) VALUES (1, 1, N'2010-01-01 00:00:00', 30)
INSERT INTO [dbo].[Invoice] ([Id], [CustomerID], [InvoiceDate], [TermsDays]) VALUES (2, 2, N'2013-01-02 00:00:00', 90)
INSERT INTO [dbo].[Invoice] ([Id], [CustomerID], [InvoiceDate], [TermsDays]) VALUES (3, 3, N'2010-01-01 00:00:00', 30)
INSERT INTO [dbo].[Invoice] ([Id], [CustomerID], [InvoiceDate], [TermsDays]) VALUES (4, 1, N'2010-01-01 00:00:00', 30)
INSERT INTO [dbo].[Invoice] ([Id], [CustomerID], [InvoiceDate], [TermsDays]) VALUES (5, 4, N'2012-02-02 00:00:00', 30)
SET IDENTITY_INSERT [dbo].[Invoice] OFF

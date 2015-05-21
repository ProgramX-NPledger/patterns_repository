SET IDENTITY_INSERT [dbo].[Customer] ON
INSERT INTO [dbo].[Customer] ([Id], [Name], [Address], [TownCity], [CountyState], [PostcodeZip]) VALUES (1, N'Frodo Baggins', N'Bag End', N'The Shire', N'Eriador', N'ME1')
INSERT INTO [dbo].[Customer] ([Id], [Name], [Address], [TownCity], [CountyState], [PostcodeZip]) VALUES (2, N'Samwise Gamgee', N'Nextdoor to Bag End', N'The Shire', N'Eriador', N'ME1')
INSERT INTO [dbo].[Customer] ([Id], [Name], [Address], [TownCity], [CountyState], [PostcodeZip]) VALUES (3, N'Théoden', N'The Great Hall', N'Rohan', N'Rohan', N'ME2')
INSERT INTO [dbo].[Customer] ([Id], [Name], [Address], [TownCity], [CountyState], [PostcodeZip]) VALUES (4, N'Denethor', N'Meduseld', N'Minas Tirith', N'Gondor', N'ME3')
SET IDENTITY_INSERT [dbo].[Customer] OFF

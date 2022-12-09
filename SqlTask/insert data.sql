INSERT INTO [dbo].[Categories] ([CategoryName]) VALUES ('Books');
INSERT INTO [dbo].[Categories] ([CategoryName]) VALUES ('History');
INSERT INTO [dbo].[Categories] ([CategoryName]) VALUES ('Science');
INSERT INTO [dbo].[Categories] ([CategoryName]) VALUES ('Souvenirs');
INSERT INTO [dbo].[Categories] ([CategoryName]) VALUES ('Toys');

INSERT INTO [dbo].[Products] ([ProductName]) VALUES ('The Adventures of Sherlock Holmes');
INSERT INTO [dbo].[Products] ([ProductName]) VALUES ('The Forgotten 500');
INSERT INTO [dbo].[Products] ([ProductName]) VALUES ('Fury (2014)');
INSERT INTO [dbo].[Products] ([ProductName]) VALUES ('C# in Depth by Jon Skeet');
INSERT INTO [dbo].[Products] ([ProductName]) VALUES ('Awesome keyring');
INSERT INTO [dbo].[Products] ([ProductName]) VALUES ('Arthas Menethil Statuette');
INSERT INTO [dbo].[Products] ([ProductName]) VALUES ('Calculator');
INSERT INTO [dbo].[Products] ([ProductName]) VALUES ('Pizza');

INSERT INTO [dbo].[Products_Categories] ([ProductID], [CategoryID]) VALUES (1, 1);
INSERT INTO [dbo].[Products_Categories] ([ProductID], [CategoryID]) VALUES (2, 1);
INSERT INTO [dbo].[Products_Categories] ([ProductID], [CategoryID]) VALUES (2, 2);
INSERT INTO [dbo].[Products_Categories] ([ProductID], [CategoryID]) VALUES (3, 2);
INSERT INTO [dbo].[Products_Categories] ([ProductID], [CategoryID]) VALUES (4, 1);
INSERT INTO [dbo].[Products_Categories] ([ProductID], [CategoryID]) VALUES (4, 3);
INSERT INTO [dbo].[Products_Categories] ([ProductID], [CategoryID]) VALUES (5, 4);
INSERT INTO [dbo].[Products_Categories] ([ProductID], [CategoryID]) VALUES (6, 4);
INSERT INTO [dbo].[Products_Categories] ([ProductID], [CategoryID]) VALUES (6, 5);
INSERT INTO [dbo].[Products_Categories] ([ProductID], [CategoryID]) VALUES (7, 3);
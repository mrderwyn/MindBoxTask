CREATE TABLE [dbo].[Categories]
(
	[CategoryID]   INT           IDENTITY (1, 1) NOT NULL,
    [CategoryName] NVARCHAR (15) NOT NULL,
	CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED ([CategoryID] ASC)
);

CREATE TABLE [dbo].[Products]
(
	[ProductID]		INT				IDENTITY (1, 1) NOT NULL,
	[ProductName]	NVARCHAR (40)	NOT NULL,
	CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED ([ProductID] ASC)
);

CREATE TABLE [dbo].[Products_Categories]
(
    [ProductID] INT NOT NULL,
	[CategoryID] INT NOT NULL, 
    CONSTRAINT [PK_Products_Categories] PRIMARY KEY ([ProductID], [CategoryID])
);
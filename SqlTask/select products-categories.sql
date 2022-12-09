SELECT p.ProductName [product], c.CategoryName [category]
FROM [dbo].[Products] p
	LEFT JOIN [dbo].[Products_Categories] links ON p.ProductID = links.ProductID
	LEFT JOIN [dbo].[Categories] c ON c.CategoryID = links.CategoryID
ORDER BY p.ProductName
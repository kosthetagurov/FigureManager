SELECT 
	p.Name, ISNULL(c.Name, 'Без категории') AS CategoryName
FROM Products p
	LEFT JOIN ProductCategories pc ON p.Id = pc.ProductId
	LEFT JOIN Categories c ON pc.CategoryId = c.Id;

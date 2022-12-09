# MindBoxTask

## C# part
Решение - [MindBoxTask](https://github.com/mrderwyn/MindBoxTask/blob/master/MIndBoxTask)

NUnit тесты - [MindBoxTaskTests](https://github.com/mrderwyn/MindBoxTask/blob/master/MindBoxTaskTests)

## Sql part
Скрипт создания бд - [create tables.sql](https://github.com/mrderwyn/MindBoxTask/blob/master/SqlTask/create%20tables.sql)

Скрипт с данными - [insert data.sql](https://github.com/mrderwyn/MindBoxTask/blob/master/SqlTask/insert%20data.sql)

Скрипт запроса для выбора всех пар «Имя продукта – Имя категории» - [select products-categories.sql](https://github.com/mrderwyn/MindBoxTask/blob/master/SqlTask/select%20products-categories.sql)

    SELECT p.ProductName [product], c.CategoryName [category]
    FROM [dbo].[Products] p
      LEFT JOIN [dbo].[Products_Categories] links ON p.ProductID = links.ProductID
      LEFT JOIN [dbo].[Categories] c ON c.CategoryID = links.CategoryID
    ORDER BY p.ProductName

Данные в таблице Products:
| ProductId | ProductName |
|-----------|-------------|
| 1 |	The Adventures of Sherlock Holmes |
| 2 |	The Forgotten 500 |
| 3 |	Fury (2014) |
| 4 |	C# in Depth by Jon Skeet |
| 5 |	Awesome keyring |
| 6 |	Arthas Menethil Statuette |
| 7 |	Calculator |
| 8 |	Pizza |

Данные в таблице Categories:
| CategoryId | CategoryName |
|------------|--------------|
| 1	| Books |
| 2	| History |
| 3	| Science |
| 4	| Souvenirs |
| 5	| Toys |

Результат запроса:
| product | category |
|---------|----------|
| Arthas Menethil Statuette	|	Souvenirs |
| Arthas Menethil Statuette	|	Toys |
| Awesome keyring	|	Souvenirs |
| C# in Depth by Jon Skeet	|	Books |
| C# in Depth by Jon Skeet	|	Science |
| Calculator	|	Science |
| Fury (2014)	|	History |
| Pizza	|	NULL |
| The Adventures of Sherlock Holmes	|	Books |
| The Forgotten 500	|	Books |
| The Forgotten 500 |	History |

CREATE TABLE [dbo].[product]
(
	[id] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[name] NVARCHAR(30) NOT NULL,
	[description] NVARCHAR(75) NOT NULL,
	[price] DECIMAL(18,2) DEFAULT(0),
	[family] NVARCHAR(30) NOT NULL,
	CONSTRAINT uq_product_name UNIQUE ([name] asc)
)
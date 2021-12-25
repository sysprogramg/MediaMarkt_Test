CREATE PROCEDURE product_GetByName
		@strName		NVARCHAR(30) = NULL
	,	@strDescription	NVARCHAR(75) = NULL
AS
	SELECT
			[id]
		,	[name]
		,	[description]
		,	[price]
		,	[family]
	FROM
		product
	WHERE
			(@strName IS NULL OR [name] LIKE '%' + @strName + '%')
		OR
			(@strDescription IS NULL OR [description] LIKE '%' + @strDescription + '%');
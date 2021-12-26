CREATE PROCEDURE product_GetByString
	@strSearchString NVARCHAR(75) = NULL
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
			(@strSearchString IS NULL OR [name] LIKE '%' + @strSearchString + '%')
		OR
			(@strSearchString IS NULL OR [description] LIKE '%' + @strSearchString + '%');
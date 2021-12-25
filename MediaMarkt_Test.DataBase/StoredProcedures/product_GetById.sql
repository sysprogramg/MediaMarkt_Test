CREATE PROCEDURE product_GetById
	@intId	INT
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
		id = @intId;
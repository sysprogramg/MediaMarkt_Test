CREATE PROCEDURE product_Insert
		@strName		NVARCHAR(30)
	,	@strDescription	NVARCHAR(75)
	,	@decPrice		DECIMAL(18,2)
	,	@strFamily		NVARCHAR(30)
AS
BEGIN
	INSERT INTO product (
			[name]
		,	[description]
		,	[price]
		,	[family]
	) VALUES (
			@strName
		,	@strDescription
		,	@decPrice
		,	@strFamily
	)
END
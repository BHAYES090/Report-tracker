CREATE PROCEDURE [dbo].[spProducts_GetById]
	@Id int
AS
BEGIN 
	SET NOCOUNT ON;
		
	SELECT Id, ProductName, [Description], RetailPrice, QuantityInStock, IsTaxable
	FROM dbo.Product
	WHERE Id = @Id;
END

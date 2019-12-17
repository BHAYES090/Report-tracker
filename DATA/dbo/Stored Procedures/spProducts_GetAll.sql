CREATE PROCEDURE [dbo].[spProducts_GetAll]

AS
BEGIN
	set nocount on;

	SELECT Id, ProductName, [Description], RetailPrice, QuantityInStock, IsTaxable
	FROM dbo.Product
	order by ProductName;
END
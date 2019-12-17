CREATE PROCEDURE [dbo].[spSale_LookUp]
	@CashierId nvarchar(128),
	@SaleDate datetime2(7)
AS
BEGIN 
	SET NOCOUNT ON;	

	SELECT Id
	from dbo.Sale
	where CashierId = @CashierId and SaleDate = @SaleDate;

END 

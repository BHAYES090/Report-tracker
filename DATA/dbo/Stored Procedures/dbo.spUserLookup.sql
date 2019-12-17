CREATE PROCEDURE [dbo].[spUserLookup]
	@Id nvarchar(128)
	
AS
BEGIN
SET NOCOUNT ON; 

	select Id, FirstName, LastName, EmailAddress, CreateDate
	from [dbo].[User]
	where Id = @Id
END
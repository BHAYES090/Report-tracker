CREATE PROCEDURE [dbo].[spUserLookup1]
	@Id nvarchar(128)
	
AS
BEGIN
SET NOCOUNT ON; 

	select Id, FirstName, LastName, EmailAddress, CreatedDate
	from [dbo].[User1]
	where Id = @Id;
END

CREATE PROCEDURE [dbo].[spInterReport_Post]
	@Id int = 0 output,
    @UserNameEmailAddress nvarchar(100),
    @PhoneNumber varchar(20),
    @CommentBox nvarchar(200),
    @CreateDate nvarchar(50)

AS
BEGIN
 SET NOCOUNT ON;

 INSERT INTO dbo.InterReport (UserNameEmailAddress, PhoneNumber, CommentBox, CreateDate)
 VALUES (@UserNameEmailAddress, @PhoneNumber, @CommentBox, @CreateDate)
 SELECT @Id = SCOPE_IDENTITY();

END

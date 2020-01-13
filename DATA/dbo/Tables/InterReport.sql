CREATE TABLE [dbo].[InterReport]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [UserNameEmailAddress] NVARCHAR(256) NOT NULL, 
    [PhoneNumber] VARCHAR(20) NOT NULL, 
    [CommentBox] NVARCHAR(200) NOT NULL, 
    [CreateDate] NVARCHAR(50) NOT NULL,
)

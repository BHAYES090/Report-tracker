CREATE TABLE [dbo].[PERSONS]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [FirstName] NVARCHAR(50) NULL, 
    [LastName] NVARCHAR(50) NULL, 
    [UserName] NVARCHAR(50) NULL, 
    [CellPhone] INT NULL, 
    [PassWord] NVARCHAR(50) NULL, 
    [EmailAddress] NVARCHAR(50) NULL
)

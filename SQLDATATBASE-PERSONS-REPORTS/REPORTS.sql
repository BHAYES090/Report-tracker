CREATE TABLE [dbo].[REPORTS]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [ReportName] NVARCHAR(50) NULL, 
    [Details] NVARCHAR(50) NULL, 
    [Comments] NVARCHAR(50) NULL, 
    [Severity] INT NULL, 
    [Status] NVARCHAR(50) NULL, 
    [DateFirstReported] DATETIME2 NULL, 

    [FirstReporter] NVARCHAR(50) NULL, 
    [BugBehavior] NVARCHAR(50) NULL, 
    [ReportID] INT NULL, 
)

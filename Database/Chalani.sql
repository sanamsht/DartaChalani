CREATE TABLE [dbo].[Table]
(
	[ChalaniNo] INT NOT NULL PRIMARY KEY, 
    [ChalaniDate] DATE NULL, 
    [FiscalYear] NVARCHAR(50) NULL, 
    [ReferenceNo] NVARCHAR(50) NULL, 
    [PatraDate] NVARCHAR(50) NULL, 
    [Subject] NVARCHAR(MAX) NULL, 
    [CC] NVARCHAR(MAX) NULL, 
    [File] NVARCHAR(50) NULL, 
    [Remarks] NVARCHAR(MAX) NULL, 
    [Action] NVARCHAR(50) NULL
)

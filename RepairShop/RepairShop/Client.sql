CREATE TABLE [dbo].[Client]
(
	[ID] INT NOT NULL PRIMARY KEY, 
    [FirstName] NVARCHAR(30) NOT NULL, 
    [LastName] NVARCHAR(30) NOT NULL, 
    [Phone] NCHAR(12) NOT NULL, 
    [Email] NVARCHAR(50) NULL
)

CREATE TABLE [dbo].[Lists]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [BoardId] INT NOT NULL, 
    [Title] NVARCHAR(50) NOT NULL, 
    [Description] NVARCHAR(50) NULL, 
    CONSTRAINT [FK_Lists_Boards] FOREIGN KEY ([BoardId]) REFERENCES [Boards]([Id])
    ON DELETE CASCADE    
)

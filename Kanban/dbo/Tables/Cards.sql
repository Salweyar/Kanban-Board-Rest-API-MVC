CREATE TABLE [dbo].[Cards]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ListId] INT NOT NULL, 
    [Title] NVARCHAR(50) NOT NULL, 
    [Description] NVARCHAR(50) NULL, 
    [Status] NVARCHAR(50) NOT NULL, 
    [StartDate] DATETIME NULL, 
    [EndDate] DATETIME NULL, 
    [AssigneTo] NVARCHAR(30) NULL, 
    [ReportTo] NVARCHAR(30) NULL, 
    [StoryPoints] INT NULL, 
    CONSTRAINT [FK_Cards_Lists] FOREIGN KEY ([ListId]) REFERENCES [Lists]([Id])
    ON DELETE CASCADE 
)

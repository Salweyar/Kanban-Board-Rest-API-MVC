﻿CREATE TABLE [dbo].[Boards]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Title] NVARCHAR(50) NOT NULL, 
    [Description] NVARCHAR(50) NULL
)

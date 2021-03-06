﻿CREATE TABLE [dbo].[RawMaterialActionReason]
(
	[ID] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Code] NVARCHAR(50) NOT NULL, 
    [Description] NVARCHAR(100) NOT NULL, 
	[SortOrder] INT NOT NULL DEFAULT 0,
    [DateEntered] DATETIME NOT NULL, 
    [EnteredBy] NVARCHAR(100) NOT NULL, 
    [LastModified] DATETIME NOT NULL, 
    [ModifiedBy] NVARCHAR(100) NOT NULL
)

GO

CREATE UNIQUE INDEX [IX_RawMaterialActionReason_Code] ON [dbo].[RawMaterialActionReason] ([Code])

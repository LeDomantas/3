﻿CREATE TABLE [dbo].[Vehicle]
(
	[ID] INT NOT NULL PRIMARY KEY, 
    [VIN] NCHAR(17) NOT NULL, 
    [Color] NCHAR(10) NULL, 
    [OwnerID] NCHAR(10) NOT NULL
)

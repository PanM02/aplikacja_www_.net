﻿CREATE TABLE [dbo].[Producenci]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nazwa] NCHAR(100) NOT NULL, 
    [Adres] NCHAR(100) NOT NULL, 
    [Tel] NCHAR(12) NOT NULL
)

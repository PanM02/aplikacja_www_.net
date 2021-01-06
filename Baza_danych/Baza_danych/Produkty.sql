CREATE TABLE [dbo].[Produkty]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nazwa] NCHAR(50) NOT NULL, 
    [Id_producenta] INT NOT NULL, 
    [Ilość] NCHAR(10) NULL, 
    CONSTRAINT [FK_Produkty_To_Producenci] FOREIGN KEY ([Id_producenta]) REFERENCES [Producenci]([Id])
)

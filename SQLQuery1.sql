CREATE TABLE [dbo].[Patienten]
(
	[Id] INT NOT NULL, 
    [Vorname] NVARCHAR(50) NULL, 
    [Nachname] NVARCHAR(50) NULL, 
    [Geburtsdaum] SMALLDATETIME NULL, 
    CONSTRAINT [PK_Table] PRIMARY KEY ([Id])  
)

GO
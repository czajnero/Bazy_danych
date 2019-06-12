CREATE TABLE [dbo].[Pojazdy]
(
	[Id_pojazd] INT NOT NULL PRIMARY KEY IDENTITY, 
    [marka] NVARCHAR(50) NOT NULL, 
    [model] NVARCHAR(50) NOT NULL, 
    [rok_prod] INT NOT NULL, 
    [nr_rej] NVARCHAR(50) NOT NULL, 
    [przebieg] INT NOT NULL, 
    [rodzaj_pal] NVARCHAR(50) NOT NULL, 
    [kolor] NVARCHAR(50) NOT NULL, 
    [rodzaj_pojazd] NVARCHAR(50) NOT NULL, 
    [numer_pojazd] NVARCHAR(50) NOT NULL
)

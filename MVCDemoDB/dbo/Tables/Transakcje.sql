CREATE TABLE [dbo].[Transakcje]
(
	[Id_transakcji] INT NOT NULL PRIMARY KEY IDENTITY, 
    [rodzaj_tran] NVARCHAR(30) NOT NULL, 
    [kwota] MONEY NULL, 
    [nr_faktury] NVARCHAR(20) NULL, 
    [sposob_zapl] NVARCHAR(30) NOT NULL, 
    [znizka] INT NULL, 
    [data_tran] DATE NULL, 
    [zaplacono] NVARCHAR(50) NULL, 
    [numer_pojazd] INT NOT NULL
)

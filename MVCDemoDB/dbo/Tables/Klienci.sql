CREATE TABLE [dbo].[Klienci]
(
	[Id_klienta] INT NOT NULL PRIMARY KEY IDENTITY, 
    [imie] NVARCHAR(30) NOT NULL, 
    [nazwisko] NVARCHAR(30) NOT NULL, 
    [pesel] NVARCHAR(30) NOT NULL, 
    [kod_pocztowy] NVARCHAR(30) NOT NULL, 
    [miasto] NVARCHAR(25) NOT NULL, 
    [ulica] NVARCHAR(25) NOT NULL, 
    [nr_domu] NVARCHAR(30) NOT NULL, 
    [nr_lokalu] NVARCHAR(30) NULL, 
    [r_dokument] NVARCHAR(25) NOT NULL, 
    [nr_dokument] NVARCHAR(25) NOT NULL, 
    [nip] NVARCHAR(30) NULL, 
    [telefon] NVARCHAR(30) NOT NULL, 
    [email] NVARCHAR(40) NOT NULL
)

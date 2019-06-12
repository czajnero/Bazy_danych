﻿/*
Deployment script for MVCDemoDB

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "MVCDemoDB"
:setvar DefaultFilePrefix "MVCDemoDB"
:setvar DefaultDataPath "C:\Users\Czajnero\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB"
:setvar DefaultLogPath "C:\Users\Czajnero\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB"

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
/*
The column [dbo].[Transakcje].[Id_klienta] is being dropped, data loss could occur.

The column [dbo].[Transakcje].[Id_pojazd] is being dropped, data loss could occur.

The column [dbo].[Transakcje].[numer_pojazd] on table [dbo].[Transakcje] must be added, but the column has no default value and does not allow NULL values. If the table contains data, the ALTER script will not work. To avoid this issue you must either: add a default value to the column, mark it as allowing NULL values, or enable the generation of smart-defaults as a deployment option.
*/

IF EXISTS (select top 1 1 from [dbo].[Transakcje])
    RAISERROR (N'Rows were detected. The schema update is terminating because data loss might occur.', 16, 127) WITH NOWAIT

GO
PRINT N'Altering [dbo].[Transakcje]...';


GO
ALTER TABLE [dbo].[Transakcje] DROP COLUMN [Id_klienta], COLUMN [Id_pojazd];


GO
ALTER TABLE [dbo].[Transakcje] ALTER COLUMN [zaplacono] NVARCHAR (50) NOT NULL;


GO
ALTER TABLE [dbo].[Transakcje]
    ADD [numer_pojazd] INT NOT NULL;


GO
PRINT N'Update complete.';


GO

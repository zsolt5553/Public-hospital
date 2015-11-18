
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/18/2015 17:18:48
-- Generated from EDMX file: C:\Users\User\Source\Repos\Public-hospital\PublicHospital\PersistenceLayer\DataModel2.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [dmaj0914_3Sem_4_1];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Admin]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Admin];
GO
IF OBJECT_ID(N'[dbo].[Doctor]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Doctor];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Admin'
CREATE TABLE [dbo].[Admin] (
    [id] int  NOT NULL,
    [firstName] nchar(20)  NOT NULL,
    [lastName] nchar(20)  NOT NULL,
    [city] nchar(30)  NOT NULL,
    [zip] int  NOT NULL,
    [street] nchar(30)  NOT NULL,
    [streetNr] int  NOT NULL,
    [phoneNr] nchar(20)  NOT NULL
);
GO

-- Creating table 'Doctor'
CREATE TABLE [dbo].[Doctor] (
    [id] int  NOT NULL,
    [firstName] nchar(20)  NOT NULL,
    [lastName] nchar(20)  NOT NULL,
    [city] nchar(30)  NOT NULL,
    [zip] int  NOT NULL,
    [street] nchar(30)  NOT NULL,
    [streetNr] int  NOT NULL,
    [phoneNr] nchar(20)  NOT NULL,
    [specialty] nchar(30)  NOT NULL,
    [description] nchar(200)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [id] in table 'Admin'
ALTER TABLE [dbo].[Admin]
ADD CONSTRAINT [PK_Admin]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [id] in table 'Doctor'
ALTER TABLE [dbo].[Doctor]
ADD CONSTRAINT [PK_Doctor]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
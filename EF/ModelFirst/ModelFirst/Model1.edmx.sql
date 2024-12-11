
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 12/11/2024 16:22:15
-- Generated from EDMX file: C:\Banu\Infinite_1\EF\ModelFirst\ModelFirst\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [MotorDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Cars'
CREATE TABLE [dbo].[Cars] (
    [CarID] int IDENTITY(1,1) NOT NULL,
    [CarName] nvarchar(max)  NOT NULL,
    [CarCost] float  NOT NULL,
    [ManufacturerID] int  NOT NULL,
    [ManufacturerMfr_ID] int  NOT NULL
);
GO

-- Creating table 'Manufacturers'
CREATE TABLE [dbo].[Manufacturers] (
    [Mfr_ID] int IDENTITY(1,1) NOT NULL,
    [Mfr_Name] nvarchar(max)  NOT NULL,
    [CarType] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [CarID] in table 'Cars'
ALTER TABLE [dbo].[Cars]
ADD CONSTRAINT [PK_Cars]
    PRIMARY KEY CLUSTERED ([CarID] ASC);
GO

-- Creating primary key on [Mfr_ID] in table 'Manufacturers'
ALTER TABLE [dbo].[Manufacturers]
ADD CONSTRAINT [PK_Manufacturers]
    PRIMARY KEY CLUSTERED ([Mfr_ID] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ManufacturerMfr_ID] in table 'Cars'
ALTER TABLE [dbo].[Cars]
ADD CONSTRAINT [FK_ManufacturerCars]
    FOREIGN KEY ([ManufacturerMfr_ID])
    REFERENCES [dbo].[Manufacturers]
        ([Mfr_ID])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ManufacturerCars'
CREATE INDEX [IX_FK_ManufacturerCars]
ON [dbo].[Cars]
    ([ManufacturerMfr_ID]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
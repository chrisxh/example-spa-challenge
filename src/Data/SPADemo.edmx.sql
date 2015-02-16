
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/16/2015 20:33:32
-- Generated from EDMX file: F:\_Work\Vkan\vkan-it\example-spa-challenge\src\Data\SPADemo.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Demo_SPA];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ScreenField]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Fields] DROP CONSTRAINT [FK_ScreenField];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Screens]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Screens];
GO
IF OBJECT_ID(N'[dbo].[Fields]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Fields];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Screens'
CREATE TABLE [dbo].[Screens] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [System] nvarchar(max)  NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [LastUpdate] datetime  NOT NULL
);
GO

-- Creating table 'Fields'
CREATE TABLE [dbo].[Fields] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Caption] nvarchar(max)  NOT NULL,
    [Status] nvarchar(max)  NOT NULL,
    [ToolTip] nvarchar(max)  NOT NULL,
    [LastUpdate] datetime  NOT NULL,
    [ScreenId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Screens'
ALTER TABLE [dbo].[Screens]
ADD CONSTRAINT [PK_Screens]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Fields'
ALTER TABLE [dbo].[Fields]
ADD CONSTRAINT [PK_Fields]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [ScreenId] in table 'Fields'
ALTER TABLE [dbo].[Fields]
ADD CONSTRAINT [FK_ScreenField]
    FOREIGN KEY ([ScreenId])
    REFERENCES [dbo].[Screens]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_ScreenField'
CREATE INDEX [IX_FK_ScreenField]
ON [dbo].[Fields]
    ([ScreenId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
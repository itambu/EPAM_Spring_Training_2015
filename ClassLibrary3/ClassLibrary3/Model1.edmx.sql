
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 12/01/2017 12:28:56
-- Generated from EDMX file: D:\EPMTrainingExamples\EPAM_Spring_Training_2015\ClassLibrary3\ClassLibrary3\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [SaleDB];
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

-- Creating table 'Items'
CREATE TABLE [dbo].[Items] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Agents'
CREATE TABLE [dbo].[Agents] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Orders'
CREATE TABLE [dbo].[Orders] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Created] nvarchar(max)  NOT NULL,
    [Amount] nvarchar(max)  NOT NULL,
    [Sum] nvarchar(max)  NOT NULL,
    [Item_Id] int  NOT NULL,
    [Provider_Id] int  NOT NULL,
    [Customer_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Items'
ALTER TABLE [dbo].[Items]
ADD CONSTRAINT [PK_Items]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Agents'
ALTER TABLE [dbo].[Agents]
ADD CONSTRAINT [PK_Agents]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Orders'
ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT [PK_Orders]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Item_Id] in table 'Orders'
ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT [FK_ItemOrder]
    FOREIGN KEY ([Item_Id])
    REFERENCES [dbo].[Items]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ItemOrder'
CREATE INDEX [IX_FK_ItemOrder]
ON [dbo].[Orders]
    ([Item_Id]);
GO

-- Creating foreign key on [Provider_Id] in table 'Orders'
ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT [FK_AgentOrder]
    FOREIGN KEY ([Provider_Id])
    REFERENCES [dbo].[Agents]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_AgentOrder'
CREATE INDEX [IX_FK_AgentOrder]
ON [dbo].[Orders]
    ([Provider_Id]);
GO

-- Creating foreign key on [Customer_Id] in table 'Orders'
ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT [FK_AgentOrder1]
    FOREIGN KEY ([Customer_Id])
    REFERENCES [dbo].[Agents]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_AgentOrder1'
CREATE INDEX [IX_FK_AgentOrder1]
ON [dbo].[Orders]
    ([Customer_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
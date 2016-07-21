
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 07/16/2016 08:45:41
-- Generated from EDMX file: D:\EPMTrainingExamples\EPAM_Spring_Training_2015\Automata\Billing\BillingModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [BillingDb];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_ClientContract]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ContractSet] DROP CONSTRAINT [FK_ClientContract];
GO
IF OBJECT_ID(N'[dbo].[FK_ContractContractBillingPlanBinding]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ContractBillingPlanBindingSet] DROP CONSTRAINT [FK_ContractContractBillingPlanBinding];
GO
IF OBJECT_ID(N'[dbo].[FK_BillingPlanContractBillingPlanBinding]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ContractBillingPlanBindingSet] DROP CONSTRAINT [FK_BillingPlanContractBillingPlanBinding];
GO
IF OBJECT_ID(N'[dbo].[FK_TerminalBillingInfo]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BillingInfoSet] DROP CONSTRAINT [FK_TerminalBillingInfo];
GO
IF OBJECT_ID(N'[dbo].[FK_TerminalContract]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[ContractSet] DROP CONSTRAINT [FK_TerminalContract];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[ClientSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClientSet];
GO
IF OBJECT_ID(N'[dbo].[ContractSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ContractSet];
GO
IF OBJECT_ID(N'[dbo].[BillingInfoSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BillingInfoSet];
GO
IF OBJECT_ID(N'[dbo].[BillingPlanSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BillingPlanSet];
GO
IF OBJECT_ID(N'[dbo].[ContractBillingPlanBindingSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ContractBillingPlanBindingSet];
GO
IF OBJECT_ID(N'[dbo].[TerminalSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TerminalSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ClientSet'
CREATE TABLE [dbo].[ClientSet] (
    [Id] uniqueidentifier  NOT NULL,
    [FullName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'ContractSet'
CREATE TABLE [dbo].[ContractSet] (
    [Id] uniqueidentifier  NOT NULL,
    [ContractStartDate] datetime  NOT NULL,
    [ContractCloseDate] datetime  NULL,
    [Client_Id] uniqueidentifier  NOT NULL,
    [Terminal_Id] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'BillingInfoSet'
CREATE TABLE [dbo].[BillingInfoSet] (
    [Id] uniqueidentifier  NOT NULL,
    [Started] datetime  NOT NULL,
    [Duration] time  NOT NULL,
    [Cost] decimal(18,0)  NOT NULL,
    [Source_Id] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'BillingPlanSet'
CREATE TABLE [dbo].[BillingPlanSet] (
    [Id] uniqueidentifier  NOT NULL,
    [boxedObj] varbinary(max)  NULL
);
GO

-- Creating table 'ContractBillingPlanBindingSet'
CREATE TABLE [dbo].[ContractBillingPlanBindingSet] (
    [Id] uniqueidentifier  NOT NULL,
    [BindingDate] datetime  NOT NULL,
    [Contract_Id] uniqueidentifier  NOT NULL,
    [BillingPlan_Id] uniqueidentifier  NOT NULL
);
GO

-- Creating table 'TerminalSet'
CREATE TABLE [dbo].[TerminalSet] (
    [Id] uniqueidentifier  NOT NULL,
    [TerminalNumber] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'ClientSet'
ALTER TABLE [dbo].[ClientSet]
ADD CONSTRAINT [PK_ClientSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ContractSet'
ALTER TABLE [dbo].[ContractSet]
ADD CONSTRAINT [PK_ContractSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BillingInfoSet'
ALTER TABLE [dbo].[BillingInfoSet]
ADD CONSTRAINT [PK_BillingInfoSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BillingPlanSet'
ALTER TABLE [dbo].[BillingPlanSet]
ADD CONSTRAINT [PK_BillingPlanSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'ContractBillingPlanBindingSet'
ALTER TABLE [dbo].[ContractBillingPlanBindingSet]
ADD CONSTRAINT [PK_ContractBillingPlanBindingSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TerminalSet'
ALTER TABLE [dbo].[TerminalSet]
ADD CONSTRAINT [PK_TerminalSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Client_Id] in table 'ContractSet'
ALTER TABLE [dbo].[ContractSet]
ADD CONSTRAINT [FK_ClientContract]
    FOREIGN KEY ([Client_Id])
    REFERENCES [dbo].[ClientSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ClientContract'
CREATE INDEX [IX_FK_ClientContract]
ON [dbo].[ContractSet]
    ([Client_Id]);
GO

-- Creating foreign key on [Contract_Id] in table 'ContractBillingPlanBindingSet'
ALTER TABLE [dbo].[ContractBillingPlanBindingSet]
ADD CONSTRAINT [FK_ContractContractBillingPlanBinding]
    FOREIGN KEY ([Contract_Id])
    REFERENCES [dbo].[ContractSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_ContractContractBillingPlanBinding'
CREATE INDEX [IX_FK_ContractContractBillingPlanBinding]
ON [dbo].[ContractBillingPlanBindingSet]
    ([Contract_Id]);
GO

-- Creating foreign key on [BillingPlan_Id] in table 'ContractBillingPlanBindingSet'
ALTER TABLE [dbo].[ContractBillingPlanBindingSet]
ADD CONSTRAINT [FK_BillingPlanContractBillingPlanBinding]
    FOREIGN KEY ([BillingPlan_Id])
    REFERENCES [dbo].[BillingPlanSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_BillingPlanContractBillingPlanBinding'
CREATE INDEX [IX_FK_BillingPlanContractBillingPlanBinding]
ON [dbo].[ContractBillingPlanBindingSet]
    ([BillingPlan_Id]);
GO

-- Creating foreign key on [Source_Id] in table 'BillingInfoSet'
ALTER TABLE [dbo].[BillingInfoSet]
ADD CONSTRAINT [FK_TerminalBillingInfo]
    FOREIGN KEY ([Source_Id])
    REFERENCES [dbo].[TerminalSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_TerminalBillingInfo'
CREATE INDEX [IX_FK_TerminalBillingInfo]
ON [dbo].[BillingInfoSet]
    ([Source_Id]);
GO

-- Creating foreign key on [Terminal_Id] in table 'ContractSet'
ALTER TABLE [dbo].[ContractSet]
ADD CONSTRAINT [FK_TerminalContract]
    FOREIGN KEY ([Terminal_Id])
    REFERENCES [dbo].[TerminalSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_TerminalContract'
CREATE INDEX [IX_FK_TerminalContract]
ON [dbo].[ContractSet]
    ([Terminal_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
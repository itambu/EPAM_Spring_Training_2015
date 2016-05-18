
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 05/11/2016 20:06:20
-- Generated from EDMX file: D:\EPMTrainingExamples\EPAM_Spring_Training_2015\BlogExample.Model\BlogExample.Model\Model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [blogapp];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_TagTagToBlog]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[TagToBlogSet] DROP CONSTRAINT [FK_TagTagToBlog];
GO
IF OBJECT_ID(N'[dbo].[FK_TagToBlogBlogItem]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BlogItemSet] DROP CONSTRAINT [FK_TagToBlogBlogItem];
GO
IF OBJECT_ID(N'[dbo].[FK_AuthorAuthorToBlog]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AuthorToBlogSet] DROP CONSTRAINT [FK_AuthorAuthorToBlog];
GO
IF OBJECT_ID(N'[dbo].[FK_AuthorToBlogBlogItem]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BlogItemSet] DROP CONSTRAINT [FK_AuthorToBlogBlogItem];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[BlogItemSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BlogItemSet];
GO
IF OBJECT_ID(N'[dbo].[AuthorSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AuthorSet];
GO
IF OBJECT_ID(N'[dbo].[TagSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TagSet];
GO
IF OBJECT_ID(N'[dbo].[TagToBlogSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[TagToBlogSet];
GO
IF OBJECT_ID(N'[dbo].[AuthorToBlogSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AuthorToBlogSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'BlogItemSet'
CREATE TABLE [dbo].[BlogItemSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Title] nvarchar(max)  NOT NULL,
    [Context] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'AuthorSet'
CREATE TABLE [dbo].[AuthorSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'TagSet'
CREATE TABLE [dbo].[TagSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [TagValue] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'TagToBlogSet'
CREATE TABLE [dbo].[TagToBlogSet] (
    [Id] int  NOT NULL,
    [Tag_Id] int  NOT NULL,
    [BlogItem_Id] int  NULL
);
GO

-- Creating table 'AuthorToBlogSet'
CREATE TABLE [dbo].[AuthorToBlogSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [BlogItemId] int  NOT NULL,
    [Author_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'BlogItemSet'
ALTER TABLE [dbo].[BlogItemSet]
ADD CONSTRAINT [PK_BlogItemSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AuthorSet'
ALTER TABLE [dbo].[AuthorSet]
ADD CONSTRAINT [PK_AuthorSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TagSet'
ALTER TABLE [dbo].[TagSet]
ADD CONSTRAINT [PK_TagSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'TagToBlogSet'
ALTER TABLE [dbo].[TagToBlogSet]
ADD CONSTRAINT [PK_TagToBlogSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'AuthorToBlogSet'
ALTER TABLE [dbo].[AuthorToBlogSet]
ADD CONSTRAINT [PK_AuthorToBlogSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Tag_Id] in table 'TagToBlogSet'
ALTER TABLE [dbo].[TagToBlogSet]
ADD CONSTRAINT [FK_TagTagToBlog]
    FOREIGN KEY ([Tag_Id])
    REFERENCES [dbo].[TagSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_TagTagToBlog'
CREATE INDEX [IX_FK_TagTagToBlog]
ON [dbo].[TagToBlogSet]
    ([Tag_Id]);
GO

-- Creating foreign key on [Author_Id] in table 'AuthorToBlogSet'
ALTER TABLE [dbo].[AuthorToBlogSet]
ADD CONSTRAINT [FK_AuthorAuthorToBlog]
    FOREIGN KEY ([Author_Id])
    REFERENCES [dbo].[AuthorSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_AuthorAuthorToBlog'
CREATE INDEX [IX_FK_AuthorAuthorToBlog]
ON [dbo].[AuthorToBlogSet]
    ([Author_Id]);
GO

-- Creating foreign key on [BlogItem_Id] in table 'TagToBlogSet'
ALTER TABLE [dbo].[TagToBlogSet]
ADD CONSTRAINT [FK_BlogItemTagToBlog]
    FOREIGN KEY ([BlogItem_Id])
    REFERENCES [dbo].[BlogItemSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_BlogItemTagToBlog'
CREATE INDEX [IX_FK_BlogItemTagToBlog]
ON [dbo].[TagToBlogSet]
    ([BlogItem_Id]);
GO

-- Creating foreign key on [BlogItemId] in table 'AuthorToBlogSet'
ALTER TABLE [dbo].[AuthorToBlogSet]
ADD CONSTRAINT [FK_BlogItemAuthorToBlog]
    FOREIGN KEY ([BlogItemId])
    REFERENCES [dbo].[BlogItemSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_BlogItemAuthorToBlog'
CREATE INDEX [IX_FK_BlogItemAuthorToBlog]
ON [dbo].[AuthorToBlogSet]
    ([BlogItemId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
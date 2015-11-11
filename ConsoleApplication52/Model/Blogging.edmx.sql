
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 11/10/2015 20:01:59
-- Generated from EDMX file: D:\EPMTrainingExamples\EPAM_Spring_Training_2015\ConsoleApplication52\Model\Blogging.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [blog];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_UserBlogItem]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BlogItemSet] DROP CONSTRAINT [FK_UserBlogItem];
GO
IF OBJECT_ID(N'[dbo].[FK_BlogItemBlog]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[BlogItemSet] DROP CONSTRAINT [FK_BlogItemBlog];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[BlogSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BlogSet];
GO
IF OBJECT_ID(N'[dbo].[BlogItemSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[BlogItemSet];
GO
IF OBJECT_ID(N'[dbo].[UserSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UserSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'BlogSet'
CREATE TABLE [dbo].[BlogSet] (
    [Id] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'BlogItemSet'
CREATE TABLE [dbo].[BlogItemSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [User_Id] int  NOT NULL,
    [Blog_Id] int  NOT NULL
);
GO

-- Creating table 'UserSet'
CREATE TABLE [dbo].[UserSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [UserName] nvarchar(max)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'BlogSet'
ALTER TABLE [dbo].[BlogSet]
ADD CONSTRAINT [PK_BlogSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'BlogItemSet'
ALTER TABLE [dbo].[BlogItemSet]
ADD CONSTRAINT [PK_BlogItemSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UserSet'
ALTER TABLE [dbo].[UserSet]
ADD CONSTRAINT [PK_UserSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [User_Id] in table 'BlogItemSet'
ALTER TABLE [dbo].[BlogItemSet]
ADD CONSTRAINT [FK_UserBlogItem]
    FOREIGN KEY ([User_Id])
    REFERENCES [dbo].[UserSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_UserBlogItem'
CREATE INDEX [IX_FK_UserBlogItem]
ON [dbo].[BlogItemSet]
    ([User_Id]);
GO

-- Creating foreign key on [Blog_Id] in table 'BlogItemSet'
ALTER TABLE [dbo].[BlogItemSet]
ADD CONSTRAINT [FK_BlogItemBlog]
    FOREIGN KEY ([Blog_Id])
    REFERENCES [dbo].[BlogSet]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_BlogItemBlog'
CREATE INDEX [IX_FK_BlogItemBlog]
ON [dbo].[BlogItemSet]
    ([Blog_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
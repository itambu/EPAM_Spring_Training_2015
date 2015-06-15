
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 06/08/2015 21:34:53
-- Generated from EDMX file: C:\Users\USER\Documents\Visual Studio 2012\ConsoleApplication52\Model\Blogging.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [blogs];
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
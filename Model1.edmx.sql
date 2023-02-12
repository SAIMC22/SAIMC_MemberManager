
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/12/2023 05:11:16
-- Generated from EDMX file: C:\Users\KeagandeCastro\source\repos\SAIMC_MemberManager\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [SAIMCDBV2];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_MemberMeeting_Meeting]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MemberMeeting] DROP CONSTRAINT [FK_MemberMeeting_Meeting];
GO
IF OBJECT_ID(N'[dbo].[FK_MemberMeeting_Members]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[MemberMeeting] DROP CONSTRAINT [FK_MemberMeeting_Members];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Meeting]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Meeting];
GO
IF OBJECT_ID(N'[dbo].[MemberMeeting]', 'U') IS NOT NULL
    DROP TABLE [dbo].[MemberMeeting];
GO
IF OBJECT_ID(N'[dbo].[Members]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Members];
GO
IF OBJECT_ID(N'[dbo].[QRGeneration]', 'U') IS NOT NULL
    DROP TABLE [dbo].[QRGeneration];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Meetings'
CREATE TABLE [dbo].[Meetings] (
    [Meetingid] int IDENTITY(1,1) NOT NULL,
    [Agenda] varchar(255)  NOT NULL,
    [date] datetime  NOT NULL,
    [CPDpoints] int  NULL
);
GO

-- Creating table 'MemberMeetings'
CREATE TABLE [dbo].[MemberMeetings] (
    [MemberMeetingID] int IDENTITY(1,1) NOT NULL,
    [Meetingid] int  NULL,
    [MemberId] int  NULL
);
GO

-- Creating table 'Members'
CREATE TABLE [dbo].[Members] (
    [MemberId] int IDENTITY(1,1) NOT NULL,
    [SAIMC_Nr] int  NOT NULL,
    [Invoice_Type] varchar(50)  NULL,
    [Members_Rating] varchar(50)  NULL,
    [Branch] varchar(50)  NULL,
    [Title] char(10)  NULL,
    [Initial] char(5)  NULL,
    [Nickname] char(50)  NULL,
    [Surname] char(50)  NULL,
    [E_Mail] varchar(100)  NULL,
    [MobilePhone] varchar(15)  NULL,
    [ECSA] varchar(100)  NULL,
    [Paid] varchar(100)  NULL,
    [Balance] varchar(100)  NULL,
    [Haspaid] bit  NULL,
    [MemberQRCode] varbinary(max)  NULL
);
GO

-- Creating table 'QRGenerations'
CREATE TABLE [dbo].[QRGenerations] (
    [id] int IDENTITY(1,1) NOT NULL,
    [Name] char(20)  NULL,
    [Surname] char(20)  NULL,
    [SAIMC_Nr] int  NOT NULL,
    [MemberQRCode] varbinary(max)  NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Meetingid] in table 'Meetings'
ALTER TABLE [dbo].[Meetings]
ADD CONSTRAINT [PK_Meetings]
    PRIMARY KEY CLUSTERED ([Meetingid] ASC);
GO

-- Creating primary key on [MemberMeetingID] in table 'MemberMeetings'
ALTER TABLE [dbo].[MemberMeetings]
ADD CONSTRAINT [PK_MemberMeetings]
    PRIMARY KEY CLUSTERED ([MemberMeetingID] ASC);
GO

-- Creating primary key on [MemberId] in table 'Members'
ALTER TABLE [dbo].[Members]
ADD CONSTRAINT [PK_Members]
    PRIMARY KEY CLUSTERED ([MemberId] ASC);
GO

-- Creating primary key on [id] in table 'QRGenerations'
ALTER TABLE [dbo].[QRGenerations]
ADD CONSTRAINT [PK_QRGenerations]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Meetingid] in table 'MemberMeetings'
ALTER TABLE [dbo].[MemberMeetings]
ADD CONSTRAINT [FK_MemberMeeting_Meeting]
    FOREIGN KEY ([Meetingid])
    REFERENCES [dbo].[Meetings]
        ([Meetingid])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MemberMeeting_Meeting'
CREATE INDEX [IX_FK_MemberMeeting_Meeting]
ON [dbo].[MemberMeetings]
    ([Meetingid]);
GO

-- Creating foreign key on [MemberId] in table 'MemberMeetings'
ALTER TABLE [dbo].[MemberMeetings]
ADD CONSTRAINT [FK_MemberMeeting_Members]
    FOREIGN KEY ([MemberId])
    REFERENCES [dbo].[Members]
        ([MemberId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_MemberMeeting_Members'
CREATE INDEX [IX_FK_MemberMeeting_Members]
ON [dbo].[MemberMeetings]
    ([MemberId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------
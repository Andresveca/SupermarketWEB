CREATE TABLE [dbo].[PayMode] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (MAX) NOT NULL,
    [Description] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_PayMode] PRIMARY KEY CLUSTERED ([Id] ASC)
);

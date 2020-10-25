CREATE TABLE [dbo].[Users] (

    [Id]           INT             IDENTITY (1, 1) NOT NULL,

    [PasswordHash] VARBINARY (MAX) NULL,

    [PasswordSalt] VARBINARY (MAX) NULL,

    [Username]     NVARCHAR (MAX)  NULL,
	
	[Email]        NVARCHAR (MAX)  NULL

);
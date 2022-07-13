CREATE TABLE [dbo].[TUSERS] (
    [ID]        INT            NOT NULL,
    [CDT]       DATETIME       NULL,
    [MDT]       DATETIME       NULL,
    [EDSEQ]     INT            NULL,
    [USERID]    VARCHAR (50)   NULL,
    [NAMEREFID] INT            NULL,
    [PASSWORD]  NVARCHAR (250) NULL,
    [ISACTIVE]  BIT            NULL,
    [ISSYSADM]  BIT            NULL
);


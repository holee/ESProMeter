CREATE TABLE [dbo].[TACTIVITY] (
    [ID]          BIGINT         NULL,
    [CDT]         DATETIME       NULL,
    [MDT]         DATETIME       NULL,
    [EDSEQ]       INT            NULL,
    [BOQID]       BIGINT         NULL,
    [ACTNAME]     NVARCHAR (50)  NULL,
    [DESCRIPTION] NVARCHAR (MAX) NULL,
    [STATUS]      INT            NULL,
    [ISACTIVE]    TINYINT        NULL
);


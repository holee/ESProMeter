CREATE TABLE [dbo].[TCUSTOMERCONTACT] (
    [ID]          BIGINT         NULL,
    [CDT]         DATETIME       NULL,
    [MDT]         DATETIME       NULL,
    [EDSEQ]       INT            NULL,
    [SALUTATION]  NCHAR (10)     NULL,
    [FIRSTNAME]   NVARCHAR (50)  NULL,
    [LASTNAME]    NVARCHAR (50)  NULL,
    [JOBTITLE]    NVARCHAR (250) NULL,
    [ISACTIVE]    TINYINT        NULL,
    [CUSTOMERID]  BIGINT         NULL,
    [ADDRESSID]   BIGINT         NULL,
    [MOBILEPHONE] VARCHAR (50)   NULL,
    [ALTPHONE]    VARCHAR (50)   NULL,
    [EMAIL]       VARCHAR (MAX)  NULL
);


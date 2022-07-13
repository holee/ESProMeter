CREATE TABLE [dbo].[TNAME] (
    [ID]          BIGINT          NULL,
    [CDT]         DATETIME        NULL,
    [MDT]         DATETIME        NULL,
    [EDSEQ]       INT             NULL,
    [NAME]        NVARCHAR (50)   NULL,
    [NAMETYPE]    NVARCHAR (50)   NULL,
    [ISACTIVE]    TINYINT         NULL,
    [SALUTATION]  NCHAR (10)      NULL,
    [FIRSTNAME]   NVARCHAR (50)   NULL,
    [LASTNAME]    NVARCHAR (50)   NULL,
    [JOBTITLE]    NVARCHAR (250)  NULL,
    [ADDRESSID]   BIGINT          NULL,
    [MAINPHONE]   VARCHAR (50)    NULL,
    [ALTPHONE]    VARCHAR (50)    NULL,
    [FAX]         VARCHAR (50)    NULL,
    [EMAIL]       VARCHAR (MAX)   NULL,
    [WEBSITE]     VARCHAR (MAX)   NULL,
    [CREDITLIMIT] NUMERIC (18, 2) NULL
);


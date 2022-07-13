CREATE TABLE [dbo].[TBOQ] (
    [ID]             BIGINT         NULL,
    [CDT]            DATETIME       NULL,
    [MDT]            DATETIME       NULL,
    [EDSEQ]          INT            NULL,
    [REFNUMBER]      VARCHAR (50)   NULL,
    [BOQTITLE]       NVARCHAR (150) NULL,
    [BOQDESC]        NVARCHAR (500) NULL,
    [CUSTOMERID]     BIGINT         NULL,
    [BOQDATE]        DATE           NULL,
    [VALIDDATE]      DATE           NULL,
    [ISACTIVE]       TINYINT        NULL,
    [SITEID]         BIGINT         NULL,
    [DIVID]          BIGINT         NULL,
    [TERMSCONDITION] NVARCHAR (MAX) NULL,
    [STATUS]         INT            NULL,
    [UID]            BIGINT         NULL
);


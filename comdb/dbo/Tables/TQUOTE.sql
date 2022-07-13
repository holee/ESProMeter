CREATE TABLE [dbo].[TQUOTE] (
    [ID]             BIGINT          NULL,
    [CDT]            DATETIME        NULL,
    [MDT]            DATETIME        NULL,
    [EDSEQ]          INT             NULL,
    [BOQID]          BIGINT          NULL,
    [CUSTOMERID]     BIGINT          NULL,
    [QUOTEDATE]      DATE            NULL,
    [REFNUMBER]      VARCHAR (50)    NULL,
    [ISACTIVE]       TINYINT         NULL,
    [SITEID]         BIGINT          NULL,
    [DIVID]          BIGINT          NULL,
    [VALIDDATE]      DATE            NULL,
    [TERMSCONDITION] NVARCHAR (MAX)  NULL,
    [TOTALAMOUNT]    NUMERIC (18, 5) NULL
);


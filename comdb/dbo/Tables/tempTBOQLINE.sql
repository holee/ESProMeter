CREATE TABLE [dbo].[tempTBOQLINE] (
    [BOQID]        BIGINT          NULL,
    [BOQITEMID]    BIGINT          NULL,
    [LineSeq]      INT             NULL,
    [NO]           NVARCHAR (50)   NULL,
    [BOQITEMDESC]  NVARCHAR (250)  NULL,
    [BOQITEMUOMID] BIGINT          NULL,
    [BOQITEMQTY]   NUMERIC (18, 5) NULL,
    [REMARKS]      NVARCHAR (MAX)  NULL,
    [UID]          BIGINT          NULL
);


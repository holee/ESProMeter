CREATE TYPE [dbo].[udt_tempNewBOQLINE] AS TABLE (
    [boqId]        BIGINT          NOT NULL,
    [boqItemId]    BIGINT          NOT NULL,
    [lineSeq]      INT             NULL,
    [no]           NVARCHAR (50)   NULL,
    [boqItemDesc]  NVARCHAR (250)  NULL,
    [boqItemUOMId] BIGINT          NOT NULL,
    [boqItemQty]   NUMERIC (18, 5) NOT NULL,
    [remarks]      NVARCHAR (MAX)  NULL,
    [uId]          BIGINT          NOT NULL);


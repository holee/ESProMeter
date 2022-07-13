CREATE TYPE [dbo].[udt_tempNewBOQLINEDetails] AS TABLE (
    [boqId]                BIGINT          NOT NULL,
    [boqItemId]            BIGINT          NOT NULL,
    [boqItemQty]           NUMERIC (18, 5) NOT NULL,
    [boqLineLineSeq]       INT             NULL,
    [boqItemItemLineId]    BIGINT          NOT NULL,
    [boqItemItemLineType]  NVARCHAR (50)   NULL,
    [boqItemItemLineUOMId] BIGINT          NOT NULL,
    [boqItemItemLineQty]   NUMERIC (18, 5) NOT NULL,
    [isQtyInPercentage]    TINYINT         NULL,
    [amount]               NUMERIC (18, 5) NULL,
    [uId]                  BIGINT          NOT NULL);


CREATE TYPE [dbo].[udt_BOQItemLine_New] AS TABLE (
    [boqItemID]        BIGINT          NULL,
    [boqItemLineID]    BIGINT          NULL,
    [boqItemLineSeq]   INT             NULL,
    [boqItemLineUOMID] BIGINT          NULL,
    [boqItemLineQty]   NUMERIC (18, 5) NULL);


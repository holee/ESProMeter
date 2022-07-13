CREATE TYPE [dbo].[udt_BoqItemLine_Insert] AS TABLE (
    [BOQITEMID]        BIGINT          NULL,
    [BOQITEMLINEID]    BIGINT          NULL,
    [BOQITEMLINESEQ]   INT             NULL,
    [BOQITEMLINEUOMID] BIGINT          NULL,
    [BOQITEMLINEQTY]   DECIMAL (18, 3) NULL);


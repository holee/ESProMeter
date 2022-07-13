CREATE TABLE [dbo].[tempTBOQLINEDETAILS] (
    [BOQID]                BIGINT          NULL,
    [BOQITEMID]            BIGINT          NULL,
    [BOQITEMQTY]           NUMERIC (18, 5) NULL,
    [BOQLINELineSeq]       INT             NULL,
    [BOQITEMITEMLINEID]    BIGINT          NULL,
    [BOQITEMITEMLINETYPE]  NVARCHAR (50)   NULL,
    [BOQITEMITEMLINEUOMID] BIGINT          NULL,
    [BOQITEMITEMLINEQTY]   NUMERIC (18, 5) NULL,
    [ISQTYINPERCENTAGE]    TINYINT         NULL,
    [AMOUNT]               NUMERIC (18, 5) NULL,
    [UID]                  BIGINT          NULL
);


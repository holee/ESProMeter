CREATE TABLE [dbo].[tempTBOQ] (
    [ID]             BIGINT         NOT NULL,
    [CDT]            DATETIME       CONSTRAINT [DF_tempTBOQ_CDT] DEFAULT (getdate()) NULL,
    [MDT]            DATETIME       CONSTRAINT [DF_tempTBOQ_MDT] DEFAULT (getdate()) NULL,
    [EDSEQ]          INT            CONSTRAINT [DF_tempTBOQ_EDSEQ] DEFAULT ((0)) NULL,
    [REFNUMBER]      VARCHAR (50)   NULL,
    [BOQTITLE]       NVARCHAR (150) NULL,
    [BOQDESC]        NVARCHAR (500) NULL,
    [CUSTOMERID]     BIGINT         NULL,
    [BOQDATE]        DATE           CONSTRAINT [DF_tempTBOQ_BOQDATE] DEFAULT (getdate()) NULL,
    [VALIDDATE]      DATE           CONSTRAINT [DF_tempTBOQ_VALIDDATE] DEFAULT (getdate()) NULL,
    [ISACTIVE]       TINYINT        CONSTRAINT [DF_tempTBOQ_ISACTIVE] DEFAULT ((1)) NULL,
    [SITEID]         BIGINT         NULL,
    [DIVID]          BIGINT         CONSTRAINT [DF_tempTBOQ_DIVID] DEFAULT ((0)) NULL,
    [TERMSCONDITION] NVARCHAR (MAX) NULL,
    [STATUS]         INT            CONSTRAINT [DF_tempTBOQ_STATUS] DEFAULT ((2)) NULL,
    [UID]            BIGINT         NULL
);

